<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAttendance
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
        Me.lblIntake = New System.Windows.Forms.Label()
        Me.lstStudentName = New System.Windows.Forms.ListBox()
        Me.btnPresent = New System.Windows.Forms.Button()
        Me.TPText = New System.Windows.Forms.Label()
        Me.lblTP = New System.Windows.Forms.Label()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.PresentText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIntake
        '
        Me.lblIntake.AutoSize = True
        Me.lblIntake.Location = New System.Drawing.Point(12, 9)
        Me.lblIntake.Name = "lblIntake"
        Me.lblIntake.Size = New System.Drawing.Size(0, 13)
        Me.lblIntake.TabIndex = 1
        '
        'lstStudentName
        '
        Me.lstStudentName.FormattingEnabled = True
        Me.lstStudentName.Location = New System.Drawing.Point(491, 87)
        Me.lstStudentName.Name = "lstStudentName"
        Me.lstStudentName.Size = New System.Drawing.Size(191, 355)
        Me.lstStudentName.TabIndex = 2
        '
        'btnPresent
        '
        Me.btnPresent.Location = New System.Drawing.Point(129, 160)
        Me.btnPresent.Name = "btnPresent"
        Me.btnPresent.Size = New System.Drawing.Size(168, 57)
        Me.btnPresent.TabIndex = 3
        Me.btnPresent.Text = "Present"
        Me.btnPresent.UseVisualStyleBackColor = True
        '
        'TPText
        '
        Me.TPText.AutoSize = True
        Me.TPText.Location = New System.Drawing.Point(42, 87)
        Me.TPText.Name = "TPText"
        Me.TPText.Size = New System.Drawing.Size(64, 13)
        Me.TPText.TabIndex = 4
        Me.TPText.Text = "Student ID :"
        '
        'lblTP
        '
        Me.lblTP.AutoSize = True
        Me.lblTP.Location = New System.Drawing.Point(126, 87)
        Me.lblTP.Name = "lblTP"
        Me.lblTP.Size = New System.Drawing.Size(0, 13)
        Me.lblTP.TabIndex = 5
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Location = New System.Drawing.Point(126, 116)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(0, 13)
        Me.lblPresent.TabIndex = 7
        '
        'PresentText
        '
        Me.PresentText.AutoSize = True
        Me.PresentText.Location = New System.Drawing.Point(27, 116)
        Me.PresentText.Name = "PresentText"
        Me.PresentText.Size = New System.Drawing.Size(79, 13)
        Me.PresentText.TabIndex = 6
        Me.PresentText.Text = "Total Present  :"
        '
        'AddAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 457)
        Me.Controls.Add(Me.lblPresent)
        Me.Controls.Add(Me.PresentText)
        Me.Controls.Add(Me.lblTP)
        Me.Controls.Add(Me.TPText)
        Me.Controls.Add(Me.btnPresent)
        Me.Controls.Add(Me.lstStudentName)
        Me.Controls.Add(Me.lblIntake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddAttendance"
        Me.Text = "Add Attendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntake As Label
    Friend WithEvents lstStudentName As ListBox
    Friend WithEvents btnPresent As Button
    Friend WithEvents TPText As Label
    Friend WithEvents lblTP As Label
    Friend WithEvents lblPresent As Label
    Friend WithEvents PresentText As Label
End Class
