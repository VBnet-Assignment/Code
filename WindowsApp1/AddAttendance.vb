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
            lstStudentName.Items.Add(selectedintakeds.Tables("Student").Rows(inc).Item(1))
        Loop
        StudentNav()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If stdindex > 0 Then
            stdindex = stdindex - 1
            StudentNav()
        Else
            MsgBox("No more students")
        End If
    End Sub

    Private Sub lstStudentName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudentName.SelectedIndexChanged
        stdindex = lstStudentName.SelectedIndex
        StudentNav()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If stdindex <> maxstudent - 1 Then
            stdindex = stdindex + 1
            StudentNav()
        Else
            MsgBox("No more students")
        End If
    End Sub

    Private Sub StudentNav()
        lblStudentName.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(1)
        lblStudentContact.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(2)
        lblTP.Text = (String.Format("TP{0:000000}", selectedintakeds.Tables("Student").Rows(stdindex).Item(0)))
        lblStudentEmail.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(3)
        lstStudentName.SelectedIndex = stdindex
    End Sub
End Class