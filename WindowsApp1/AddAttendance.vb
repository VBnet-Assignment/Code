Public Class AddAttendance
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = Database.mdb"
    Dim selectedintakesql As String = "SELECT * From Student WHERE IntakeCode='" & Dashboard.selectedintake & "' ORDER BY StudentName"
    Public Property selectedintakeds As New DataSet
    Dim selectedintakeda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(selectedintakesql, con)
    Dim inc, maxstudent, stdindex, presentstatus As Integer



    Dim totalpresent, present As Integer

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
        lstStudentName.SelectedIndex = stdindex
        AddAttendance()
    End Sub
    '================ START OF STUDENT DETAILS NAGIGATION =========================

    Private Sub lstStudentName_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstStudentName.SelectedIndexChanged
        stdindex = lstStudentName.SelectedIndex
        StudentNav()
    End Sub

    Private Sub btnPresent_Click(sender As Object, e As EventArgs) Handles btnPresent.Click
        presentstatus = 1
        If stdindex <> maxstudent - 1 Then
            StudentNav()
            AddAttendance()
            stdindex = stdindex + 1
        Else
            MsgBox("No more students")
        End If
    End Sub

    Private Sub AddAttendance()
        '============ DIM NEW ATTENDANCE
        Dim attendancesql As String = "SELECT * From Attendance WHERE SubjectCode=" & Dashboard.selectedsubject & " AND TPNumber=" & selectedintakeds.Tables("Student").Rows(stdindex).Item(0)
        Dim attendanceds As New DataSet
        Dim attendanceda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(attendancesql, con)

        ' -------- Load database to display Student Attendance Details --------------------------
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        attendanceda.Fill(attendanceds, "Attendance")
        con.Close()
        Dim update As New OleDb.OleDbCommandBuilder(attendanceda)
        MsgBox(stdindex)

        present = lblPresent.Text
        totalpresent = presentstatus + present
        MsgBox(totalpresent)

        attendanceds.Tables("Attendance").Rows(0).Item(2) = totalpresent
        attendanceda.Update(attendanceds, "Attendance")
    End Sub

    Private Sub StudentNav()
        '========= DIM NEW ATTENDANCE ==========
        Dim attendancesql As String = "SELECT * From Attendance WHERE SubjectCode=" & Dashboard.selectedsubject & " AND TPNumber=" & selectedintakeds.Tables("Student").Rows(stdindex).Item(0)
        Dim attendanceds As New DataSet
        Dim attendanceda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(attendancesql, con)

        ' -------- Load database to display Student Attendance Details --------------------------
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        attendanceda.Fill(attendanceds, "Attendance")
        con.Close()

        lblPresent.Text = attendanceds.Tables("Attendance").Rows(0).Item(2)
        lblTP.Text = (String.Format("TP{0:000000}", selectedintakeds.Tables("Student").Rows(stdindex).Item(0)))
        lstStudentName.SelectedIndex = stdindex
    End Sub
    '================ END OF STUDENT DETAILS NAGIGATION =========================
End Class