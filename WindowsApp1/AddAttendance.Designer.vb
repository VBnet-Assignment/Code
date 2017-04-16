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
        Me.lstAddAttendance = New System.Windows.Forms.ListView()
        Me.lblIntake = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstAddAttendance
        '
        Me.lstAddAttendance.Location = New System.Drawing.Point(12, 143)
        Me.lstAddAttendance.Name = "lstAddAttendance"
        Me.lstAddAttendance.Size = New System.Drawing.Size(670, 302)
        Me.lstAddAttendance.TabIndex = 0
        Me.lstAddAttendance.UseCompatibleStateImageBehavior = False
        '
        'lblIntake
        '
        Me.lblIntake.AutoSize = True
        Me.lblIntake.Location = New System.Drawing.Point(12, 9)
        Me.lblIntake.Name = "lblIntake"
        Me.lblIntake.Size = New System.Drawing.Size(0, 13)
        Me.lblIntake.TabIndex = 1
        '
        'AddAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 457)
        Me.Controls.Add(Me.lblIntake)
        Me.Controls.Add(Me.lstAddAttendance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddAttendance"
        Me.Text = "Add Attendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAddAttendance As ListView
    Friend WithEvents lblIntake As Label
End Class
