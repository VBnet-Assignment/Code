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
        Me.SuspendLayout()
        '
        'lstStudentName
        '
        Me.lstStudentName.FormattingEnabled = True
        Me.lstStudentName.Location = New System.Drawing.Point(574, 56)
        Me.lstStudentName.Name = "lstStudentName"
        Me.lstStudentName.Size = New System.Drawing.Size(204, 433)
        Me.lstStudentName.TabIndex = 0
        '
        'intakeText
        '
        Me.intakeText.AutoSize = True
        Me.intakeText.Location = New System.Drawing.Point(571, 28)
        Me.intakeText.Name = "intakeText"
        Me.intakeText.Size = New System.Drawing.Size(43, 13)
        Me.intakeText.TabIndex = 1
        Me.intakeText.Text = "Intake :"
        '
        'lblIntake
        '
        Me.lblIntake.AutoSize = True
        Me.lblIntake.Location = New System.Drawing.Point(620, 28)
        Me.lblIntake.Name = "lblIntake"
        Me.lblIntake.Size = New System.Drawing.Size(0, 13)
        Me.lblIntake.TabIndex = 2
        '
        'studentnametxt
        '
        Me.studentnametxt.AutoSize = True
        Me.studentnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentnametxt.Location = New System.Drawing.Point(12, 23)
        Me.studentnametxt.Name = "studentnametxt"
        Me.studentnametxt.Size = New System.Drawing.Size(120, 20)
        Me.studentnametxt.TabIndex = 3
        Me.studentnametxt.Text = "Student Name :"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(138, 23)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(0, 20)
        Me.lblStudentName.TabIndex = 4
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(406, 365)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'TPtext
        '
        Me.TPtext.AutoSize = True
        Me.TPtext.Location = New System.Drawing.Point(12, 56)
        Me.TPtext.Name = "TPtext"
        Me.TPtext.Size = New System.Drawing.Size(90, 13)
        Me.TPtext.TabIndex = 6
        Me.TPtext.Text = "Student Number :"
        '
        'lblTP
        '
        Me.lblTP.AutoSize = True
        Me.lblTP.Location = New System.Drawing.Point(108, 56)
        Me.lblTP.Name = "lblTP"
        Me.lblTP.Size = New System.Drawing.Size(0, 13)
        Me.lblTP.TabIndex = 7
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(57, 365)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 8
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblStudentEmail
        '
        Me.lblStudentEmail.AutoSize = True
        Me.lblStudentEmail.Location = New System.Drawing.Point(108, 83)
        Me.lblStudentEmail.Name = "lblStudentEmail"
        Me.lblStudentEmail.Size = New System.Drawing.Size(0, 13)
        Me.lblStudentEmail.TabIndex = 10
        '
        'stdemailtext
        '
        Me.stdemailtext.AutoSize = True
        Me.stdemailtext.Location = New System.Drawing.Point(12, 83)
        Me.stdemailtext.Name = "stdemailtext"
        Me.stdemailtext.Size = New System.Drawing.Size(90, 13)
        Me.stdemailtext.TabIndex = 9
        Me.stdemailtext.Text = "Student Email     :"
        '
        'lblStudentContact
        '
        Me.lblStudentContact.AutoSize = True
        Me.lblStudentContact.Location = New System.Drawing.Point(419, 56)
        Me.lblStudentContact.Name = "lblStudentContact"
        Me.lblStudentContact.Size = New System.Drawing.Size(0, 13)
        Me.lblStudentContact.TabIndex = 12
        '
        'stdcontacttext
        '
        Me.stdcontacttext.AutoSize = True
        Me.stdcontacttext.Location = New System.Drawing.Point(323, 56)
        Me.stdcontacttext.Name = "stdcontacttext"
        Me.stdcontacttext.Size = New System.Drawing.Size(90, 13)
        Me.stdcontacttext.TabIndex = 11
        Me.stdcontacttext.Text = "Student Contact :"
        '
        'AddAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 501)
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
        Me.Name = "AddAttendance"
        Me.Text = "AddAttendance"
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
End Class
