Imports System.Net
Imports Renci.SshNet
Public Class Form1
    Dim cpu, mb As String, closeapp As Boolean, result
    Dim sshclient As New SshClient(My.Settings.IP, My.Settings.Username, My.Settings.Password)
    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        GetTemp()
        If My.Settings.ShowCPU = True Then
            GenerateIcon(cpu, CPUTemp)
            CPUTemp.Text = "CPU temperature is " & cpu & "c"
        Else
            CPUTemp.Visible = False
        End If
        If My.Settings.ShowMB = True Then
            GenerateIcon(mb, MBTemp)
            MBTemp.Text = "Motherboard temperature is " & mb & "c"
        Else
            MBTemp.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IPAddress.TryParse(My.Settings.IP, Nothing) Then
            sshclient.Connect()
            RefreshTimer.Start()
        Else
            Me.Opacity = 1
            Me.ShowInTaskbar = True
        End If
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not IPAddress.TryParse(My.Settings.IP, Nothing) Then
            MsgBox("Invalid IP Address")
            e.Cancel = True
            Exit Sub
        End If
        If chkCPU.Checked = False And chkMB.Checked = False Then
            MsgBox("Atleast one temperature must be selected")
            e.Cancel = True
            Exit Sub
        End If
        My.Settings.Save()
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        sshclient = New SshClient(My.Settings.IP, My.Settings.Username, My.Settings.Password)
        sshclient.Connect()
        RefreshTimer.Start()
        If closeapp = False Then e.Cancel = True
    End Sub

    Public Sub GetTemp()
        Dim command = sshclient.CreateCommand("sensors -A|awk 'BEGIN{cpu=""-"";mb=""-"";fan=""-""}{if (/^CPU Temp/) cpu=$3*1; if (/^MB Temp/) mb=$3*1; if (/^Array Fan/) fan=$3*1} END{print cpu,mb,fan}'")
        command.Execute()
        result = command.Result.Split(" - ")
        cpu = Math.Round(Convert.ToDecimal(result(0)))
        mb = Math.Round(Convert.ToDecimal(result(1)))
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        closeapp = True
        sshclient.Disconnect()
        Application.Exit()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkStartup.CheckedChanged
        If sender.checked = True Then
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        Else
            If Not My.Computer.Registry.CurrentUser.GetValue("SOFTWARE\Microsoft\Windows\CurrentVersion\Run") Is Nothing Then My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        sshclient.Disconnect()
        RefreshTimer.Stop()
        Me.Opacity = 1
        Me.ShowInTaskbar = True
    End Sub

    Public Sub GenerateIcon(ByVal temp As String, trayicon As NotifyIcon)
        Dim clsBitmap As New Bitmap(16, 16)
        Dim clsGraphics As Graphics = Graphics.FromImage(clsBitmap)
        Dim sf As New StringFormat
        clsGraphics.Clear(Color.Transparent)
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Center
        clsGraphics.DrawString(temp, New Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), Brushes.White, New PointF(7, 8), sf)
        clsGraphics.Dispose()
        Dim ptrIcon As IntPtr = clsBitmap.GetHicon()
        clsBitmap.Dispose()
        trayicon.Icon = Icon.FromHandle(ptrIcon)
        trayicon.Visible = True
    End Sub
End Class