Public Class EditAttendance
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = Database.mdb"
    Dim selectedintakesql As String = "SELECT * From Student WHERE IntakeCode='" & Dashboard.selectedintake & "' ORDER BY StudentName"
    Public Property selectedintakeds As New DataSet
    Dim selectedintakeda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(selectedintakesql, con)

    ' ----------- Dim attendance database -------------------------------
    Dim attendancesql As String = "SELECT * From Attendance"
    Public Property attendanceds As New DataSet
    Dim attendanceda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(attendancesql, con)

    Dim inc, maxstudent, stdindex As Integer
    Dim selectedstudent As String

    Private Sub EditAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' -------- Load database to display Selected Intake Details --------------------------
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        selectedintakeda.Fill(selectedintakeds, "Student")
        con.Close()

        ' -------- Load database to display Attendance Details --------------------------
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        attendanceda.Fill(attendanceds, "Attendance")
        con.Close()

        Me.Text = "Attendence – " & Dashboard.lectureName & " (" & Dashboard.lectureID & ")"
        lblIntake.Text = Dashboard.selectedintake
        lblSubject.Text = Dashboard.selectedsubject
        inc = -1
        maxstudent = selectedintakeds.Tables("Student").Rows.Count
        Do While inc < maxstudent - 1
            inc = inc + 1
            lstStudentName.Items.Add(selectedintakeds.Tables("Student").Rows(inc).Item(1))
        Loop
        StudentNav()
    End Sub

    '================ START OF STUDENT DETAILS NAGIGATION =========================
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If stdindex > 0 Then
            stdindex = stdindex - 1
            StudentNav()
        Else
            MsgBox("No more students")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If stdindex <> maxstudent - 1 Then
            stdindex = stdindex + 1
            StudentNav()
        Else
            MsgBox("No more students")
        End If
    End Sub

    Private Sub lstStudentName_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstStudentName.SelectedIndexChanged
        stdindex = lstStudentName.SelectedIndex
        StudentNav()
    End Sub

    Private Sub StudentNav()
        Dim studentdetailds As New DataSet
        Dim studentdetailsql As String = "SELECT SUM(TotalClasses), SUM(TotalLates) From Attendance WHERE TPNumber=" & selectedintakeds.Tables("Student").Rows(stdindex).Item(0) & " GROUP BY TPNumber"
        Dim studentdetailda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(studentdetailsql, con)

        con.ConnectionString = dbProvider & dbSource
        con.Open()
        studentdetailda.Fill(studentdetailds, "Attendance")
        con.Close()

        txtAtt.Text = studentdetailds.Tables("Attendance").Rows(0).Item(0)
        txtLateAtt.Text = studentdetailds.Tables("Attendance").Rows(0).Item(1)

        lblStudentName.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(1)
        lblStudentContact.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(2)
        lblTP.Text = (String.Format("TP{0:000000}", selectedintakeds.Tables("Student").Rows(stdindex).Item(0)))
        lblStudentEmail.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(3)
        lstStudentName.SelectedIndex = stdindex
        txtLateAtt.Clear()
        btnUpdate.Text = "Update"
        btnUpdate.Enabled = False

    End Sub
    '================ END OF STUDENT DETAILS NAGIGATION =========================

    '================ START OF ADDING ATTENDANCE =====================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim update As New OleDb.OleDbCommandBuilder(attendanceda)
        Dim datainc As Integer
        Dim newattendance As DataRow

        datainc = 0
        If datainc <> -1 Then
            newattendance = attendanceds.Tables("Attendance").NewRow()

            newattendance.Item("SubjectCode") = "1"
            newattendance.Item("TotalClasses") = txtAtt.Text
            newattendance.Item("TotalLates") = txtLateAtt.Text
            newattendance.Item("TPNumber") = selectedintakeds.Tables("Student").Rows(stdindex).Item(0)

            attendanceds.Tables("Attendance").Rows.Add(newattendance)
            attendanceda.Update(attendanceds, "Attendance")
            btnUpdate.Text = "Updated"
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub txtAtt_TextChanged(sender As Object, e As EventArgs) Handles txtAtt.TextChanged
        btnUpdate.Enabled = True

    End Sub
End Class