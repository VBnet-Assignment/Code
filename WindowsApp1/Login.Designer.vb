<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLecturerID = New System.Windows.Forms.Label()
        Me.lblLecturerPassword = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtID.Location = New System.Drawing.Point(324, 386)
        Me.txtID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(471, 41)
        Me.txtID.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(324, 475)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(471, 41)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 45)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(123, 41)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 42)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblLecturerID
        '
        Me.lblLecturerID.AutoSize = True
        Me.lblLecturerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLecturerID.Location = New System.Drawing.Point(124, 393)
        Me.lblLecturerID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLecturerID.Name = "lblLecturerID"
        Me.lblLecturerID.Size = New System.Drawing.Size(169, 36)
        Me.lblLecturerID.TabIndex = 3
        Me.lblLecturerID.Text = "Lecturer ID:"
        Me.lblLecturerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLecturerPassword
        '
        Me.lblLecturerPassword.AutoSize = True
        Me.lblLecturerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLecturerPassword.Location = New System.Drawing.Point(145, 482)
        Me.lblLecturerPassword.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblLecturerPassword.Name = "lblLecturerPassword"
        Me.lblLecturerPassword.Size = New System.Drawing.Size(155, 36)
        Me.lblLecturerPassword.TabIndex = 4
        Me.lblLecturerPassword.Text = "Password:"
        Me.lblLecturerPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Location = New System.Drawing.Point(131, 98)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(7)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(670, 236)
        Me.picLogo.TabIndex = 5
        Me.picLogo.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnLogin.Location = New System.Drawing.Point(376, 587)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(7)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(194, 83)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(947, 732)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblLecturerPassword)
        Me.Controls.Add(Me.lblLecturerID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Login"
        Me.Text = "Login – Student Attendance System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLecturerID As Label
    Friend WithEvents lblLecturerPassword As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
