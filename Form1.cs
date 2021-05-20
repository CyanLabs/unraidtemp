using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Windows.Forms;
using Renci.SshNet;
using Microsoft.Win32;

namespace UnraidTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string cpu, mb;
        private bool closeapp;
        private string[] result;
        private SshClient sshClient;
        IPAddress ip;

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            GetTemp();
            if (Properties.Settings.Default.ShowCPU == true)
            {
                GenerateIcon(cpu, CPUTemp);
                CPUTemp.Text = "CPU temperature is " + cpu + "c";
            }
            else
            {
                CPUTemp.Visible = false;
            }

            if (Properties.Settings.Default.ShowMB == true)
            {
                GenerateIcon(mb, MBTemp);
                MBTemp.Text = "Motherboard temperature is " + mb + "c";
            }
            else
            {
                MBTemp.Visible = false;
            }
        }
        

        public void GetTemp()
        {
            var command = sshClient.CreateCommand("sensors -A|awk 'BEGIN{cpu=\"- \";mb=\"-\";fan=\"-\"}{if (/^CPU Temp/) cpu=$3*1; if (/^MB Temp/) mb=$3*1; if (/^Array Fan/) fan=$3*1} END{print cpu,mb,fan}'");
            try
            {
                command.Execute();
                result = command.Result.Split('-');
                if(Properties.Settings.Default.ShowCPU) cpu = Math.Round(Convert.ToDecimal(result[0].Replace(" ",""))).ToString(CultureInfo.InvariantCulture);
                if(Properties.Settings.Default.ShowMB) mb = Math.Round(Convert.ToDecimal(result[1].Replace(" ", ""))).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, the following message may help: " + ex.Message, "General Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Opacity = 1;
                this.ShowInTaskbar = true;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sshClient.Disconnect();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP = txtIP.Text;
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Interval = (int)updownInterval.Value;
            Properties.Settings.Default.ShowCPU = chkCPU.Checked;
            Properties.Settings.Default.ShowMB = chkMB.Checked;
            Properties.Settings.Default.StartWithWindows = chkStartup.Checked;
            // 'confirm info is valid
            if (!chkCPU.Checked && !chkMB.Checked)
                MessageBox.Show("Atleast one temperature must be selected", "No Icon Selected", MessageBoxButtons.OK,MessageBoxIcon.Error);
            if (!IPAddress.TryParse(Properties.Settings.Default.IP, out ip))
                MessageBox.Show("Invalid IP Address", "Invalid IP", MessageBoxButtons.OK,MessageBoxIcon.Error);
            if ((IPAddress.TryParse(Properties.Settings.Default.IP, out ip) && chkCPU.Checked == true) | chkMB.Checked == true)
            {
                Properties.Settings.Default.Save();
                this.Opacity = 0;
                this.ShowInTaskbar = false;
                Form1_Load_1(sender, e);
            }
            Properties.Settings.Default.Save();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartup.Checked)
            {
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true)?.SetValue(Application.ProductName, Application.ExecutablePath);
            }
            else
            {
                Registry.CurrentUser.DeleteValue(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\" + Application.ProductName, false);
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIP.Text = Properties.Settings.Default.IP;
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;
            updownInterval.Value = Properties.Settings.Default.Interval;
            chkCPU.Checked = Properties.Settings.Default.ShowCPU;
            chkMB.Checked = Properties.Settings.Default.ShowMB;
            chkStartup.Checked = Properties.Settings.Default.StartWithWindows;
            sshClient?.Disconnect();
            RefreshTimer.Stop();
            this.Opacity = 1;
            this.ShowInTaskbar = true;
        }

        public void GenerateIcon(string temp, NotifyIcon trayicon)
        {
            var clsBitmap = new Bitmap(16, 16);
            Graphics clsGraphics = Graphics.FromImage(clsBitmap);
            var sf = new StringFormat();
            clsGraphics.Clear(Color.Transparent);
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            clsGraphics.DrawString(temp, new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), Brushes.White, new PointF(7, 8), sf);
            clsGraphics.Dispose();
            IntPtr ptrIcon = clsBitmap.GetHicon();
            clsBitmap.Dispose();
            trayicon.Icon = Icon.FromHandle(ptrIcon);
            trayicon.Visible = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            sshClient = new SshClient(Properties.Settings.Default.IP, Properties.Settings.Default.Username, Properties.Settings.Default.Password);
            if (IPAddress.TryParse(Properties.Settings.Default.IP, out ip))
            {
                try
                {
                    sshClient.Connect();
                    RefreshTimer.Start();
                }
                catch (System.Net.Sockets.SocketException ex)
                {
                    MessageBox.Show(ex.Message + ". Please make sure that your IP address matches your UnRAID server and that SSH access is enabled and allowed for that user.","Invalid Credentials", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    this.Opacity = 1;
                    this.ShowInTaskbar = true;
                }
                catch (Renci.SshNet.Common.SshAuthenticationException ex)
                {
                    MessageBox.Show("Please make sure that the username and password match your UnRAID server", "Invalid Credentials", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    MessageBox.Show(Properties.Settings.Default.IP + Properties.Settings.Default.Username + Properties.Settings.Default.Password);
                    this.Opacity = 1;
                    this.ShowInTaskbar = true;
                }
            }
            else
            {
                this.Opacity = 1;
                this.ShowInTaskbar = true;
            }
        }
    }
}