Public Class ChangePassword
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Equals("")) Or (TextBox2.Text.Equals("")) Or (TextBox3.Text.Equals("")) Then
            MsgBox("Please enter your old password and confirm your new password")
        Else
            If TextBox1.Text.Equals(Dashboard.lecturePassword) Then
                If TextBox2.Text.Equals(TextBox3.Text) Then
                    Login.ds.Tables("Lecturer").Rows(Dashboard.userID).Item(2) = TextBox2.Text
                    MsgBox("Password changed. Please use your new password to login.")
                    Dashboard.Close()
                    Login.Show()
                    Me.Close()
                Else
                    MsgBox("New passwords dosen't match. Please try again.")
                End If
            Else
                MsgBox("Please check your current password and try again.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown, TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class