Public Class Dashboard
    Public Property userID As Integer
    Public Property lectureID As String
    Public Property lecturePassword As String
    Public Property lectureName As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lectureID = String.Format("LEC{0:000}", userID + 1)
        lecturePassword = Login.ds.Tables("Lecturer").Rows(userID).Item(2)
        lectureName = Login.ds.Tables("Lecturer").Rows(userID).Item(1)
        Me.Text = "Dashboard – " & lectureName & " (" & lectureID & ")"
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.Show()
    End Sub
End Class