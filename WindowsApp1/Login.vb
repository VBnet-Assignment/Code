Public Class Login
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER = Microsoft.JET.OLEDB.4.0;"
    Dim dbSource As String = "Data Source = Database.mdb"
    Dim sql As String = "SELECT * From Lecturer"
    Public Property ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        da.Fill(ds, "Lecturer")
        con.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        For i = 0 To ds.Tables("Lecturer").Rows.Count - 1
            If txtID.Text = (String.Format("LEC{0:000}", ds.Tables("Lecturer").Rows(i).Item(0))) Then
                If txtPassword.Text = ds.Tables("Lecturer").Rows(i).Item(2) Then
                    If Not chkRememberPassword.Checked Then
                        txtPassword.Clear()
                    End If
                    Me.Hide()
                    Dashboard.userID = i
                    Dashboard.Show()
                Else
                    MessageBox.Show("Please check your password and try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit For
            Else
                If (i = ds.Tables("Lecturer").Rows.Count - 1) Then
                    MessageBox.Show("User not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub txtIdPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown, txtID.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub chkRememberPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkRememberPassword.CheckedChanged
        If chkRememberPassword.Checked Then
            Dim rememberPasswordConfirm As Integer = MessageBox.Show("Only remember passwords on your personal devices." & vbNewLine & "Are you sure to remember password?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If rememberPasswordConfirm = DialogResult.No Then
                chkRememberPassword.Checked = False
            End If
        End If
    End Sub
End Class
