using System.ComponentModel;

namespace UnraidTemp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnApply = new System.Windows.Forms.Button();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.updownInterval = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            this.btnColors = new System.Windows.Forms.Button();
            this.chkMB = new System.Windows.Forms.CheckBox();
            this.chkCPU = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.MaskedTextBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.grpCredentials = new System.Windows.Forms.GroupBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.LinkLabel();
            this.MBTemp = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CPUTemp = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.updownInterval)).BeginInit();
            this.grpSettings.SuspendLayout();
            this.grpCredentials.SuspendLayout();
            this.IconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(13, 253);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(184, 32);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Save and apply settings!";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.Button1_Click);
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Location = new System.Drawing.Point(35, 103);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(114, 17);
            this.chkStartup.TabIndex = 9;
            this.chkStartup.Text = "Start with windows";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // updownInterval
            // 
            this.updownInterval.Location = new System.Drawing.Point(103, 19);
            this.updownInterval.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.updownInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updownInterval.Name = "updownInterval";
            this.updownInterval.Size = new System.Drawing.Size(53, 20);
            this.updownInterval.TabIndex = 8;
            this.updownInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(30, 22);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(67, 13);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Interval (ms):";
            this.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnColors
            // 
            this.btnColors.Enabled = false;
            this.btnColors.Location = new System.Drawing.Point(14, 72);
            this.btnColors.Name = "btnColors";
            this.btnColors.Size = new System.Drawing.Size(161, 23);
            this.btnColors.TabIndex = 2;
            this.btnColors.Text = "Colors coming soon";
            this.btnColors.UseVisualStyleBackColor = true;
            // 
            // chkMB
            // 
            this.chkMB.AutoSize = true;
            this.chkMB.Location = new System.Drawing.Point(103, 49);
            this.chkMB.Name = "chkMB";
            this.chkMB.Size = new System.Drawing.Size(72, 17);
            this.chkMB.TabIndex = 1;
            this.chkMB.Text = "Show MB";
            this.chkMB.UseVisualStyleBackColor = true;
            // 
            // chkCPU
            // 
            this.chkCPU.AutoSize = true;
            this.chkCPU.Location = new System.Drawing.Point(14, 49);
            this.chkCPU.Name = "chkCPU";
            this.chkCPU.Size = new System.Drawing.Size(78, 17);
            this.chkCPU.TabIndex = 0;
            this.chkCPU.Text = "Show CPU";
            this.chkCPU.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(73, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(102, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(73, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(102, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpSettings.Controls.Add(this.chkStartup);
            this.grpSettings.Controls.Add(this.updownInterval);
            this.grpSettings.Controls.Add(this.lblInterval);
            this.grpSettings.Controls.Add(this.btnColors);
            this.grpSettings.Controls.Add(this.chkMB);
            this.grpSettings.Controls.Add(this.chkCPU);
            this.grpSettings.Location = new System.Drawing.Point(13, 118);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(184, 129);
            this.grpSettings.TabIndex = 6;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 51);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(73, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(102, 22);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 3000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // grpCredentials
            // 
            this.grpCredentials.Controls.Add(this.txtPassword);
            this.grpCredentials.Controls.Add(this.lblPassword);
            this.grpCredentials.Controls.Add(this.txtUsername);
            this.grpCredentials.Controls.Add(this.lblUsername);
            this.grpCredentials.Controls.Add(this.lblIP);
            this.grpCredentials.Controls.Add(this.txtIP);
            this.grpCredentials.Location = new System.Drawing.Point(13, 8);
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.Size = new System.Drawing.Size(184, 105);
            this.grpCredentials.TabIndex = 5;
            this.grpCredentials.TabStop = false;
            this.grpCredentials.Text = "SSH Credentials";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 24);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(61, 13);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP Address:";
            this.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.LinkArea = new System.Windows.Forms.LinkArea(100, 19);
            this.lblAbout.Location = new System.Drawing.Point(2, 297);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(210, 42);
            this.lblAbout.TabIndex = 4;
            this.lblAbout.TabStop = true;
            this.lblAbout.Text = "This software was created by CyanLabs\r\nThis software is in alpha stage please\r\nre" +
    "port any issues at http://cyanlabs.net";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbout.UseCompatibleTextRendering = true;
            // 
            // MBTemp
            // 
            this.MBTemp.ContextMenuStrip = this.IconMenu;
            this.MBTemp.Icon = ((System.Drawing.Icon)(resources.GetObject("MBTemp.Icon")));
            this.MBTemp.Text = "MBTemp";
            this.MBTemp.Visible = true;
            this.MBTemp.DoubleClick += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // IconMenu
            // 
            this.IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.IconMenu.Name = "Menu";
            this.IconMenu.Size = new System.Drawing.Size(117, 48);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // CPUTemp
            // 
            this.CPUTemp.ContextMenuStrip = this.IconMenu;
            this.CPUTemp.Icon = ((System.Drawing.Icon)(resources.GetObject("CPUTemp.Icon")));
            this.CPUTemp.Text = "CPUTemp";
            this.CPUTemp.Visible = true;
            this.CPUTemp.DoubleClick += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(214, 347);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.grpCredentials);
            this.Controls.Add(this.lblAbout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnRAID Temperature";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.updownInterval)).EndInit();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpCredentials.ResumeLayout(false);
            this.grpCredentials.PerformLayout();
            this.IconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnApply;
        internal System.Windows.Forms.CheckBox chkStartup;
        internal System.Windows.Forms.NumericUpDown updownInterval;
        internal System.Windows.Forms.Label lblInterval;
        internal System.Windows.Forms.Button btnColors;
        internal System.Windows.Forms.CheckBox chkMB;
        internal System.Windows.Forms.CheckBox chkCPU;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.GroupBox grpSettings;
        internal System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.MaskedTextBox txtIP;
        internal System.Windows.Forms.Timer RefreshTimer;
        internal System.Windows.Forms.GroupBox grpCredentials;
        internal System.Windows.Forms.Label lblIP;
        internal System.Windows.Forms.LinkLabel lblAbout;
        internal System.Windows.Forms.NotifyIcon MBTemp;
        internal System.Windows.Forms.ContextMenuStrip IconMenu;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.NotifyIcon CPUTemp;
    }
}