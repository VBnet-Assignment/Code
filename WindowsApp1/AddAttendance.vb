Public Class AddAttendance
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = Database.mdb"
    Dim selectedintakesql As String = "SELECT * From Student WHERE IntakeCode='" & Dashboard.selectedintake & "' ORDER BY StudentName"
    Public Property selectedintakeds As New DataSet
    Dim selectedintakeda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(selectedintakesql, con)
    Dim inc, maxstudent, stdindex As Integer
    Dim selectedstudent As String

    Private Sub AddAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' -------- Load database to display Selected Intake Details --------------------------
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        selectedintakeda.Fill(selectedintakeds, "Student")
        con.Close()

        Me.Text = "Attendence – " & Dashboard.lectureName & " (" & Dashboard.lectureID & ")"
        lblIntake.Text = Dashboard.selectedintake
        inc = -1
        maxstudent = selectedintakeds.Tables("Student").Rows.Count

        Do While inc < maxstudent - 1
            inc = inc + 1
            lstAddAttendance.View = View.List
            lstAddAttendance.Items.Add(selectedintakeds.Tables("Student").Rows(inc).Item(1))
            lstAddAttendance.CheckBoxes = True
        Loop
    End Sub
End Class