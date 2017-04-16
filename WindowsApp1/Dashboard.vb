Public Class Dashboard

    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = Database.mdb"
    Dim intakecodesql As String = "SELECT IntakeCode From Student GROUP BY IntakeCode"
    Public Property intakeds As New DataSet
    Dim intakeda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(intakecodesql, con)
    Dim inc, maxintake As Integer
    Public Property selectedintake As String
    Public Property selectedsubject As String

    Public Property userID As Integer
    Public Property lectureID As String
    Public Property lecturePassword As String
    Public Property lectureName As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lectureID = String.Format("LEC{0:000}", userID + 1)
        lecturePassword = Login.ds.Tables("Lecturer").Rows(userID).Item(2)
        lectureName = Login.ds.Tables("Lecturer").Rows(userID).Item(1)
        Me.Text = "Dashboard – " & lectureName & " (" & lectureID & ")"
        lblGreeting.Text = "Welcome, " & lectureName

        ' -------- Load database to display available IntakeCode --------------------------
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        intakeda.Fill(intakeds, "Student")
        con.Close()

        btnEdit.Enabled = False
        btn_newatt.Enabled = False
        Button2.Enabled = False

        inc = -1
        maxintake = intakeds.Tables("Student").Rows.Count
        Do While inc < maxintake - 1
            inc = inc + 1
            lstIntakecode.Items.Add(intakeds.Tables("Student").Rows(inc).Item(0))
        Loop
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    '===========Edit Attendance Button ===============
    Private Sub btn_newatt_Click(sender As Object, e As EventArgs) Handles btn_newatt.Click
        If lstIntakecode.SelectedIndex >= 0 Then
            selectedsubject = lstIntakecode.SelectedItem
            Me.Hide()
            AddAttendance.Show()
        Else
            MessageBox.Show("Select a subject", "Subject not found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lstIntakecode.SelectedIndex >= 0 Then
            selectedsubject = lstIntakecode.SelectedItem
            Me.Hide()
            EditAttendance.Show()
        Else
            MessageBox.Show("Select a subject", "Subject not found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If lstIntakecode.SelectedIndex >= 0 Then
            selectedintake = lstIntakecode.SelectedItem
            lstIntakecode.Items.Clear()

            SelectSubject()
        Else
            MessageBox.Show("Select an intake", "Intake not found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub SelectSubject()
        Dim subjectsql As String = "SELECT SubjectCode FROM IntakeSubjects WHERE IntakeCode='" & selectedintake & "' ORDER BY SubjectCode"
        Dim subjectds As New DataSet
        Dim subjectda As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(subjectsql, con)
        Dim maxsubject, subjectinc As Integer
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        subjectda.Fill(subjectds, "IntakeSubjects")
        con.Close()

        maxsubject = subjectds.Tables("IntakeSubjects").Rows.Count
        subjectinc = -1
        Do While subjectinc < maxsubject - 1
            subjectinc = subjectinc + 1
            lstIntakecode.Items.Add(subjectds.Tables("IntakeSubjects").Rows(subjectinc).Item(0))
        Loop
        btn_newatt.Enabled = True
        btnEdit.Enabled = True
        Button2.Enabled = True
        btnNext.Enabled = False
        Label1.Text = "My classes :"
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.Show()
    End Sub
End Class