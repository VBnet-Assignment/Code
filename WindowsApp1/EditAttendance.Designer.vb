<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditAttendance
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
        Me.components = New System.ComponentModel.Container()
        Me.lstStudentName = New System.Windows.Forms.ListBox()
        Me.intakeText = New System.Windows.Forms.Label()
        Me.lblIntake = New System.Windows.Forms.Label()
        Me.studentnametxt = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.TPtext = New System.Windows.Forms.Label()
        Me.lblTP = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblStudentEmail = New System.Windows.Forms.Label()
        Me.stdemailtext = New System.Windows.Forms.Label()
        Me.lblStudentContact = New System.Windows.Forms.Label()
        Me.stdcontacttext = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtAtt = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.attendanceText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLateAtt = New System.Windows.Forms.TextBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAbsent = New System.Windows.Forms.TextBox()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalClass = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstStudentName
        '
        Me.lstStudentName.FormattingEnabled = True
        Me.lstStudentName.ItemHeight = 29
        Me.lstStudentName.Location = New System.Drawing.Point(1339, 125)
        Me.lstStudentName.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.lstStudentName.Name = "lstStudentName"
        Me.lstStudentName.Size = New System.Drawing.Size(471, 961)
        Me.lstStudentName.TabIndex = 0
        '
        'intakeText
        '
        Me.intakeText.AutoSize = True
        Me.intakeText.Location = New System.Drawing.Point(1332, 20)
        Me.intakeText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.intakeText.Name = "intakeText"
        Me.intakeText.Size = New System.Drawing.Size(89, 29)
        Me.intakeText.TabIndex = 1
        Me.intakeText.Text = "Intake :"
        '
        'lblIntake
        '
        Me.lblIntake.AutoSize = True
        Me.lblIntake.Location = New System.Drawing.Point(1433, 20)
        Me.lblIntake.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblIntake.Name = "lblIntake"
        Me.lblIntake.Size = New System.Drawing.Size(0, 29)
        Me.lblIntake.TabIndex = 2
        '
        'studentnametxt
        '
        Me.studentnametxt.AutoSize = True
        Me.studentnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentnametxt.Location = New System.Drawing.Point(28, 51)
        Me.studentnametxt.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.studentnametxt.Name = "studentnametxt"
        Me.studentnametxt.Size = New System.Drawing.Size(267, 40)
        Me.studentnametxt.TabIndex = 3
        Me.studentnametxt.Text = "Student Name :"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(322, 51)
        Me.lblStudentName.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(0, 40)
        Me.lblStudentName.TabIndex = 4
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(947, 814)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(175, 51)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'TPtext
        '
        Me.TPtext.AutoSize = True
        Me.TPtext.Location = New System.Drawing.Point(28, 125)
        Me.TPtext.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.TPtext.Name = "TPtext"
        Me.TPtext.Size = New System.Drawing.Size(200, 29)
        Me.TPtext.TabIndex = 6
        Me.TPtext.Text = "Student Number :"
        '
        'lblTP
        '
        Me.lblTP.AutoSize = True
        Me.lblTP.Location = New System.Drawing.Point(252, 125)
        Me.lblTP.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTP.Name = "lblTP"
        Me.lblTP.Size = New System.Drawing.Size(0, 29)
        Me.lblTP.TabIndex = 7
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(133, 814)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(175, 51)
        Me.btnPrevious.TabIndex = 8
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblStudentEmail
        '
        Me.lblStudentEmail.AutoSize = True
        Me.lblStudentEmail.Location = New System.Drawing.Point(252, 185)
        Me.lblStudentEmail.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblStudentEmail.Name = "lblStudentEmail"
        Me.lblStudentEmail.Size = New System.Drawing.Size(0, 29)
        Me.lblStudentEmail.TabIndex = 10
        '
        'stdemailtext
        '
        Me.stdemailtext.AutoSize = True
        Me.stdemailtext.Location = New System.Drawing.Point(28, 185)
        Me.stdemailtext.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.stdemailtext.Name = "stdemailtext"
        Me.stdemailtext.Size = New System.Drawing.Size(198, 29)
        Me.stdemailtext.TabIndex = 9
        Me.stdemailtext.Text = "Student Email     :"
        '
        'lblStudentContact
        '
        Me.lblStudentContact.AutoSize = True
        Me.lblStudentContact.Location = New System.Drawing.Point(978, 125)
        Me.lblStudentContact.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblStudentContact.Name = "lblStudentContact"
        Me.lblStudentContact.Size = New System.Drawing.Size(0, 29)
        Me.lblStudentContact.TabIndex = 12
        '
        'stdcontacttext
        '
        Me.stdcontacttext.AutoSize = True
        Me.stdcontacttext.Location = New System.Drawing.Point(754, 125)
        Me.stdcontacttext.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.stdcontacttext.Name = "stdcontacttext"
        Me.stdcontacttext.Size = New System.Drawing.Size(194, 29)
        Me.stdcontacttext.TabIndex = 11
        Me.stdcontacttext.Text = "Student Contact :"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtAtt
        '
        Me.txtAtt.Location = New System.Drawing.Point(264, 294)
        Me.txtAtt.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtAtt.Name = "txtAtt"
        Me.txtAtt.Size = New System.Drawing.Size(62, 35)
        Me.txtAtt.TabIndex = 15
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(679, 814)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(175, 51)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'attendanceText
        '
        Me.attendanceText.AutoSize = True
        Me.attendanceText.Location = New System.Drawing.Point(28, 301)
        Me.attendanceText.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.attendanceText.Name = "attendanceText"
        Me.attendanceText.Size = New System.Drawing.Size(213, 29)
        Me.attendanceText.TabIndex = 17
        Me.attendanceText.Text = "Classes Attended :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 393)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Classes Late        :"
        '
        'txtLateAtt
        '
        Me.txtLateAtt.Location = New System.Drawing.Point(266, 386)
        Me.txtLateAtt.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtLateAtt.Name = "txtLateAtt"
        Me.txtLateAtt.Size = New System.Drawing.Size(62, 35)
        Me.txtLateAtt.TabIndex = 18
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(1447, 67)
        Me.lblSubject.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(0, 29)
        Me.lblSubject.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1318, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 29)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Subject :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 486)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 29)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Classes Absent    :"
        '
        'txtAbsent
        '
        Me.txtAbsent.Location = New System.Drawing.Point(268, 480)
        Me.txtAbsent.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.txtAbsent.Name = "txtAbsent"
        Me.txtAbsent.Size = New System.Drawing.Size(62, 35)
        Me.txtAbsent.TabIndex = 22
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(978, 294)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(0, 29)
        Me.lblPercent.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(673, 294)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 29)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Attendance Percentage :"
        '
        'lblTotalClass
        '
        Me.lblTotalClass.AutoSize = True
        Me.lblTotalClass.Location = New System.Drawing.Point(295, 598)
        Me.lblTotalClass.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTotalClass.Name = "lblTotalClass"
        Me.lblTotalClass.Size = New System.Drawing.Size(0, 29)
        Me.lblTotalClass.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 598)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 29)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Total Class :"
        '
        'EditAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1843, 1118)
        Me.Controls.Add(Me.lblTotalClass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAbsent)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLateAtt)
        Me.Controls.Add(Me.attendanceText)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtAtt)
        Me.Controls.Add(Me.lblStudentContact)
        Me.Controls.Add(Me.stdcontacttext)
        Me.Controls.Add(Me.lblStudentEmail)
        Me.Controls.Add(Me.stdemailtext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblTP)
        Me.Controls.Add(Me.TPtext)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.studentnametxt)
        Me.Controls.Add(Me.lblIntake)
        Me.Controls.Add(Me.intakeText)
        Me.Controls.Add(Me.lstStudentName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Name = "EditAttendance"
        Me.Text = "Edit Attendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstStudentName As ListBox
    Friend WithEvents intakeText As Label
    Friend WithEvents lblIntake As Label
    Friend WithEvents studentnametxt As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents TPtext As Label
    Friend WithEvents lblTP As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblStudentEmail As Label
    Friend WithEvents stdemailtext As Label
    Friend WithEvents lblStudentContact As Label
    Friend WithEvents stdcontacttext As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtAtt As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents attendanceText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLateAtt As TextBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAbsent As TextBox
    Friend WithEvents lblPercent As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalClass As Label
    Friend WithEvents Label6 As Label
End Class
