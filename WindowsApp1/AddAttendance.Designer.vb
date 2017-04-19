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
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.intakeText = New System.Windows.Forms.Label()
        Me.btnLate = New System.Windows.Forms.Button()
        Me.lblLate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAbsent = New System.Windows.Forms.Button()
        Me.lblAbsent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIntake
        '
        Me.lblIntake.AutoSize = True
        Me.lblIntake.Location = New System.Drawing.Point(537, 22)
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
        Me.TPText.Location = New System.Drawing.Point(42, 43)
        Me.TPText.Name = "TPText"
        Me.TPText.Size = New System.Drawing.Size(64, 13)
        Me.TPText.TabIndex = 4
        Me.TPText.Text = "Student ID :"
        '
        'lblTP
        '
        Me.lblTP.AutoSize = True
        Me.lblTP.Location = New System.Drawing.Point(126, 43)
        Me.lblTP.Name = "lblTP"
        Me.lblTP.Size = New System.Drawing.Size(0, 13)
        Me.lblTP.TabIndex = 5
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Location = New System.Drawing.Point(126, 72)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(0, 13)
        Me.lblPresent.TabIndex = 7
        '
        'PresentText
        '
        Me.PresentText.AutoSize = True
        Me.PresentText.Location = New System.Drawing.Point(27, 72)
        Me.PresentText.Name = "PresentText"
        Me.PresentText.Size = New System.Drawing.Size(79, 13)
        Me.PresentText.TabIndex = 6
        Me.PresentText.Text = "Total Present  :"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(537, 43)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(0, 13)
        Me.lblSubject.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Subject :"
        '
        'intakeText
        '
        Me.intakeText.AutoSize = True
        Me.intakeText.Location = New System.Drawing.Point(488, 22)
        Me.intakeText.Name = "intakeText"
        Me.intakeText.Size = New System.Drawing.Size(43, 13)
        Me.intakeText.TabIndex = 22
        Me.intakeText.Text = "Intake :"
        '
        'btnLate
        '
        Me.btnLate.Location = New System.Drawing.Point(129, 248)
        Me.btnLate.Name = "btnLate"
        Me.btnLate.Size = New System.Drawing.Size(168, 57)
        Me.btnLate.TabIndex = 26
        Me.btnLate.Text = "Late"
        Me.btnLate.UseVisualStyleBackColor = True
        '
        'lblLate
        '
        Me.lblLate.AutoSize = True
        Me.lblLate.Location = New System.Drawing.Point(126, 98)
        Me.lblLate.Name = "lblLate"
        Me.lblLate.Size = New System.Drawing.Size(0, 13)
        Me.lblLate.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Total Late  :"
        '
        'btnAbsent
        '
        Me.btnAbsent.Location = New System.Drawing.Point(129, 346)
        Me.btnAbsent.Name = "btnAbsent"
        Me.btnAbsent.Size = New System.Drawing.Size(168, 57)
        Me.btnAbsent.TabIndex = 29
        Me.btnAbsent.Text = "Absent"
        Me.btnAbsent.UseVisualStyleBackColor = True
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.Location = New System.Drawing.Point(126, 126)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(0, 13)
        Me.lblAbsent.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Total Absent  :"
        '
        'AddAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 457)
        Me.Controls.Add(Me.lblAbsent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAbsent)
        Me.Controls.Add(Me.lblLate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLate)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.intakeText)
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
    Friend WithEvents lblSubject As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents intakeText As Label
    Friend WithEvents btnLate As Button
    Friend WithEvents lblLate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAbsent As Button
    Friend WithEvents lblAbsent As Label
    Friend WithEvents Label4 As Label
End Class
