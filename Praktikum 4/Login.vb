Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call koneksi()
        CMD = New MySqlCommand("Select * From tbAkun where namaUser='" & txtUser.Text & "' and passwordUser='" & txtPass.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            Me.Visible = False
            Fmenu.Show()
            FMenu.ToolStripStatusLabel1.Text = RD.GetString(0)
            FMenu.ToolStripStatusLabel2.Text = RD.GetString(1)
            FMenu.ToolStripStatusLabel3.Text = RD.GetString(2)
            RD.Close()
            If FMenu.ToolStripStatusLabel3.Text <> "ADMIN" Then
                FMenu.UserToolStripMenuItem.Enabled = False
            Else
                FMenu.UserToolStripMenuItem.Enabled = True

            End If
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa kembali username dan password", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUser.Focus()
            txtUser.Text = ""
            txtPass.Text = ""
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        End
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then txtPass.Focus()
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then btnLogin.Focus()
    End Sub


End Class