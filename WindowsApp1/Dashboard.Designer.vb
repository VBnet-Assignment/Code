<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.lstIntakecode = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_newatt = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(14, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(889, 49)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(125, 41)
        Me.OptionsToolStripMenuItem.Text = "Account"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(335, 42)
        Me.ChangePasswordToolStripMenuItem.Text = "Change password"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(335, 42)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'lblGreeting
        '
        Me.lblGreeting.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(28, 85)
        Me.lblGreeting.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(217, 31)
        Me.lblGreeting.TabIndex = 5
        Me.lblGreeting.Text = "Welcome, Admin"
        '
        'lstIntakecode
        '
        Me.lstIntakecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIntakecode.FormattingEnabled = True
        Me.lstIntakecode.ItemHeight = 31
        Me.lstIntakecode.Location = New System.Drawing.Point(35, 232)
        Me.lstIntakecode.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.lstIntakecode.Name = "lstIntakecode"
        Me.lstIntakecode.Size = New System.Drawing.Size(541, 252)
        Me.lstIntakecode.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 187)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "My intakes:"
        '
        'btn_newatt
        '
        Me.btn_newatt.Location = New System.Drawing.Point(614, 232)
        Me.btn_newatt.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btn_newatt.Name = "btn_newatt"
        Me.btn_newatt.Size = New System.Drawing.Size(240, 74)
        Me.btn_newatt.TabIndex = 9
        Me.btn_newatt.Text = "New Attendance"
        Me.btn_newatt.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(670, 435)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 74)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "View Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(614, 335)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(240, 74)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit Attendance"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(614, 435)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(61, 74)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(614, 435)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(61, 74)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 607)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_newatt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstIntakecode)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
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
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
End Class
