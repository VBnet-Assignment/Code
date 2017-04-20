Public Class EditAttendance
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = Database.mdb"
    Dim selectedintakesql As String = "SELECT * From Student WHERE IntakeCode='" & Dashboard.selectedintake & "' ORDER BY StudentName"
    Public Property selectedintakeds As New DataSet
    Dim selectedintakeda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(selectedintakesql, con)

    Dim presentstatus, latestatus, absentstatus, totalpresent, present, totalabsent, absent, totallate, late, totalclass As Integer
    Dim classpercent As Double

    Dim inc, maxstudent, stdindex As Integer
    Dim selectedstudent As String

    Private Sub EditAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' -------- Load database to display Selected Intake Details --------------------------
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        selectedintakeda.Fill(selectedintakeds, "Student")
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
        Dim studentdetailsql As String = "SELECT * From Attendance WHERE SubjectCode=" & Dashboard.selectedsubject & " AND TPNumber=" & selectedintakeds.Tables("Student").Rows(stdindex).Item(0)
        Dim studentdetailda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(studentdetailsql, con)


        con.ConnectionString = dbProvider & dbSource
        con.Open()
        studentdetailda.Fill(studentdetailds, "Attendance")
        con.Close()

        txtAtt.Text = studentdetailds.Tables("Attendance").Rows(0).Item(2)
        txtAbsent.Text = studentdetailds.Tables("Attendance").Rows(0).Item(3)
        txtLateAtt.Text = studentdetailds.Tables("Attendance").Rows(0).Item(4)

        lblStudentName.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(1)
        lblStudentContact.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(2)
        lblTP.Text = (String.Format("TP{0:000000}", selectedintakeds.Tables("Student").Rows(stdindex).Item(0)))
        lblStudentEmail.Text = selectedintakeds.Tables("Student").Rows(stdindex).Item(3)

        lblTotalClass.Text = studentdetailds.Tables("Attendance").Rows(0).Item(1)
        txtAtt.Text = studentdetailds.Tables("Attendance").Rows(0).Item(2)
        txtAbsent.Text = studentdetailds.Tables("Attendance").Rows(0).Item(3)
        txtLateAtt.Text = studentdetailds.Tables("Attendance").Rows(0).Item(4)

        present = txtAtt.Text
        absent = txtAbsent.Text
        late = txtLateAtt.Text
        totalclass = present + absent + late
        totalclass = lblTotalClass.Text

        classpercent = ((present + (late * 0.5)) / totalclass) * 100

        If Double.IsInfinity(classpercent) Then
            classpercent = 0
        End If
        If classpercent < 10 Then
            lblPercent.Text = String.Format("{0:0.00}%", classpercent)
        ElseIf classpercent < 100 Then
            lblPercent.Text = String.Format("{0:00.00}%", classpercent)
        Else
            lblPercent.Text = String.Format("{0:000.00}%", classpercent)
        End If

        lstStudentName.SelectedIndex = stdindex
        btnUpdate.Text = "Update"
        btnUpdate.Enabled = False

    End Sub
    '================ END OF STUDENT DETAILS NAGIGATION =========================

    '================ START OF ADDING ATTENDANCE =====================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim datainc As Integer
        datainc = 0
        If datainc <> -1 Then
            ModifyAttendance()
            btnUpdate.Text = "Updated"
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub ModifyAttendance()
        Dim studentdetailds As New DataSet
        Dim studentdetailsql As String = "SELECT * From Attendance WHERE SubjectCode=" & Dashboard.selectedsubject & " AND TPNumber=" & selectedintakeds.Tables("Student").Rows(stdindex).Item(0)
        Dim studentdetailda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(studentdetailsql, con)
        Dim update As New OleDb.OleDbCommandBuilder(studentdetailda)

        con.ConnectionString = dbProvider & dbSource
        con.Open()
        studentdetailda.Fill(studentdetailds, "Attendance")
        con.Close()

        studentdetailds.Tables("Attendance").Rows(0).Item(2) = txtAtt.Text
        studentdetailds.Tables("Attendance").Rows(0).Item(3) = txtAbsent.Text
        studentdetailds.Tables("Attendance").Rows(0).Item(4) = txtLateAtt.Text

        studentdetailda.Update(studentdetailds, "Attendance")
    End Sub

    Private Sub txtAtt_TextChanged(sender As Object, e As EventArgs) Handles txtAtt.TextChanged
        btnUpdate.Enabled = True
    End Sub
End Class