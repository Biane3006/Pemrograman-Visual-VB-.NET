Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUsername.Text.Equals("User") And tbPassword.Text.Equals("12345") Then
            MessageBox.Show("Login Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
        Else
            MessageBox.Show("Username dan Password Salah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPass.CheckedChanged
        If cbShowPass.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class
