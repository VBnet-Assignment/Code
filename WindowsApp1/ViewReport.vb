Public Class ViewReport
    Private Sub ViewReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.DatabaseDataSet.Attendance)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class