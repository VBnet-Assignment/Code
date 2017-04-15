<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.lstIntakecode = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_newatt = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(381, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.OptionsToolStripMenuItem.Text = "Account"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change password"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'lblGreeting
        '
        Me.lblGreeting.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(12, 38)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(100, 15)
        Me.lblGreeting.TabIndex = 5
        Me.lblGreeting.Text = "Welcome, Admin"
        '
        'lstIntakecode
        '
        Me.lstIntakecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIntakecode.FormattingEnabled = True
        Me.lstIntakecode.ItemHeight = 15
        Me.lstIntakecode.Location = New System.Drawing.Point(15, 104)
        Me.lstIntakecode.Name = "lstIntakecode"
        Me.lstIntakecode.Size = New System.Drawing.Size(234, 124)
        Me.lstIntakecode.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "My classes:"
        '
        'btn_newatt
        '
        Me.btn_newatt.Location = New System.Drawing.Point(263, 104)
        Me.btn_newatt.Name = "btn_newatt"
        Me.btn_newatt.Size = New System.Drawing.Size(103, 33)
        Me.btn_newatt.TabIndex = 9
        Me.btn_newatt.Text = "New Attendance"
        Me.btn_newatt.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(263, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 33)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "View Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(263, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 33)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Edit Attendances"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 272)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_newatt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstIntakecode)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblGreeting As Label
    Friend WithEvents lstIntakecode As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_newatt As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
