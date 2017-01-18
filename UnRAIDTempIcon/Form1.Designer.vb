<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CPUTemp = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.IconMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MBTemp = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lblAbout = New System.Windows.Forms.LinkLabel()
        Me.grpCredentials = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.MaskedTextBox()
        Me.grpSettings = New System.Windows.Forms.GroupBox()
        Me.chkStartup = New System.Windows.Forms.CheckBox()
        Me.updownInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.btnColors = New System.Windows.Forms.Button()
        Me.chkMB = New System.Windows.Forms.CheckBox()
        Me.chkCPU = New System.Windows.Forms.CheckBox()
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.IconMenu.SuspendLayout()
        Me.grpCredentials.SuspendLayout()
        Me.grpSettings.SuspendLayout()
        CType(Me.updownInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPUTemp
        '
        Me.CPUTemp.ContextMenuStrip = Me.IconMenu
        Me.CPUTemp.Text = "CPUTemp"
        '
        'IconMenu
        '
        Me.IconMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.IconMenu.Name = "Menu"
        Me.IconMenu.Size = New System.Drawing.Size(117, 48)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MBTemp
        '
        Me.MBTemp.ContextMenuStrip = Me.IconMenu
        Me.MBTemp.Text = "MBTemp"
        '
        'lblAbout
        '
        Me.lblAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAbout.AutoSize = True
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.LinkArea = New System.Windows.Forms.LinkArea(100, 19)
        Me.lblAbout.Location = New System.Drawing.Point(2, 266)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(210, 42)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.TabStop = True
        Me.lblAbout.Text = "This software was created by CyanLabs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This software is in alpha stage please" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "re" &
    "port any issues at http://cyanlabs.net"
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAbout.UseCompatibleTextRendering = True
        '
        'grpCredentials
        '
        Me.grpCredentials.Controls.Add(Me.txtPassword)
        Me.grpCredentials.Controls.Add(Me.lblPassword)
        Me.grpCredentials.Controls.Add(Me.txtUsername)
        Me.grpCredentials.Controls.Add(Me.lblUsername)
        Me.grpCredentials.Controls.Add(Me.lblIP)
        Me.grpCredentials.Controls.Add(Me.txtIP)
        Me.grpCredentials.Location = New System.Drawing.Point(13, 13)
        Me.grpCredentials.Name = "grpCredentials"
        Me.grpCredentials.Size = New System.Drawing.Size(184, 105)
        Me.grpCredentials.TabIndex = 1
        Me.grpCredentials.TabStop = False
        Me.grpCredentials.Text = "Credentials"
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UnRAIDTempIcon.My.MySettings.Default, "Password", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPassword.Location = New System.Drawing.Point(73, 75)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(102, 20)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.Text = Global.UnRAIDTempIcon.My.MySettings.Default.Password
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(11, 78)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UnRAIDTempIcon.My.MySettings.Default, "Username", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtUsername.Location = New System.Drawing.Point(73, 48)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(102, 20)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.Text = Global.UnRAIDTempIcon.My.MySettings.Default.Username
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(9, 51)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(6, 24)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(61, 13)
        Me.lblIP.TabIndex = 1
        Me.lblIP.Text = "IP Address:"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIP
        '
        Me.txtIP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.UnRAIDTempIcon.My.MySettings.Default, "IP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(73, 19)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(102, 22)
        Me.txtIP.TabIndex = 0
        Me.txtIP.Text = Global.UnRAIDTempIcon.My.MySettings.Default.IP
        Me.txtIP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'grpSettings
        '
        Me.grpSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.grpSettings.Controls.Add(Me.chkStartup)
        Me.grpSettings.Controls.Add(Me.updownInterval)
        Me.grpSettings.Controls.Add(Me.lblInterval)
        Me.grpSettings.Controls.Add(Me.btnColors)
        Me.grpSettings.Controls.Add(Me.chkMB)
        Me.grpSettings.Controls.Add(Me.chkCPU)
        Me.grpSettings.Location = New System.Drawing.Point(13, 124)
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.Size = New System.Drawing.Size(184, 129)
        Me.grpSettings.TabIndex = 2
        Me.grpSettings.TabStop = False
        Me.grpSettings.Text = "Settings"
        '
        'chkStartup
        '
        Me.chkStartup.AutoSize = True
        Me.chkStartup.Checked = Global.UnRAIDTempIcon.My.MySettings.Default.StartWithWindows
        Me.chkStartup.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UnRAIDTempIcon.My.MySettings.Default, "StartWithWindows", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkStartup.Location = New System.Drawing.Point(35, 103)
        Me.chkStartup.Name = "chkStartup"
        Me.chkStartup.Size = New System.Drawing.Size(114, 17)
        Me.chkStartup.TabIndex = 9
        Me.chkStartup.Text = "Start with windows"
        Me.chkStartup.UseVisualStyleBackColor = True
        '
        'updownInterval
        '
        Me.updownInterval.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.UnRAIDTempIcon.My.MySettings.Default, "RefreshRate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.updownInterval.Location = New System.Drawing.Point(103, 19)
        Me.updownInterval.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me.updownInterval.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updownInterval.Name = "updownInterval"
        Me.updownInterval.Size = New System.Drawing.Size(53, 20)
        Me.updownInterval.TabIndex = 8
        Me.updownInterval.Value = Global.UnRAIDTempIcon.My.MySettings.Default.RefreshRate
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(30, 22)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(67, 13)
        Me.lblInterval.TabIndex = 7
        Me.lblInterval.Text = "Interval (ms):"
        Me.lblInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnColors
        '
        Me.btnColors.Enabled = False
        Me.btnColors.Location = New System.Drawing.Point(14, 72)
        Me.btnColors.Name = "btnColors"
        Me.btnColors.Size = New System.Drawing.Size(161, 23)
        Me.btnColors.TabIndex = 2
        Me.btnColors.Text = "Colors coming soon"
        Me.btnColors.UseVisualStyleBackColor = True
        '
        'chkMB
        '
        Me.chkMB.AutoSize = True
        Me.chkMB.Checked = Global.UnRAIDTempIcon.My.MySettings.Default.ShowMB
        Me.chkMB.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UnRAIDTempIcon.My.MySettings.Default, "ShowMB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkMB.Location = New System.Drawing.Point(103, 49)
        Me.chkMB.Name = "chkMB"
        Me.chkMB.Size = New System.Drawing.Size(72, 17)
        Me.chkMB.TabIndex = 1
        Me.chkMB.Text = "Show MB"
        Me.chkMB.UseVisualStyleBackColor = True
        '
        'chkCPU
        '
        Me.chkCPU.AutoSize = True
        Me.chkCPU.Checked = Global.UnRAIDTempIcon.My.MySettings.Default.ShowCPU
        Me.chkCPU.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.UnRAIDTempIcon.My.MySettings.Default, "ShowCPU", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkCPU.Location = New System.Drawing.Point(14, 49)
        Me.chkCPU.Name = "chkCPU"
        Me.chkCPU.Size = New System.Drawing.Size(78, 17)
        Me.chkCPU.TabIndex = 0
        Me.chkCPU.Text = "Show CPU"
        Me.chkCPU.UseVisualStyleBackColor = True
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Interval = Global.UnRAIDTempIcon.My.MySettings.Default.Interval
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 311)
        Me.Controls.Add(Me.grpSettings)
        Me.Controls.Add(Me.grpCredentials)
        Me.Controls.Add(Me.lblAbout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UnRAID Temperature"
        Me.IconMenu.ResumeLayout(False)
        Me.grpCredentials.ResumeLayout(False)
        Me.grpCredentials.PerformLayout()
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        CType(Me.updownInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CPUTemp As NotifyIcon
    Friend WithEvents MBTemp As NotifyIcon
    Friend WithEvents RefreshTimer As Timer
    Friend WithEvents lblAbout As LinkLabel
    Friend WithEvents grpCredentials As GroupBox
    Friend WithEvents txtIP As MaskedTextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents grpSettings As GroupBox
    Friend WithEvents btnColors As Button
    Friend WithEvents chkMB As CheckBox
    Friend WithEvents chkCPU As CheckBox
    Friend WithEvents IconMenu As ContextMenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents updownInterval As NumericUpDown
    Friend WithEvents lblInterval As Label
    Friend WithEvents chkStartup As CheckBox
End Class
