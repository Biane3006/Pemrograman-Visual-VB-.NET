Public Class Login
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity - 0.1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity <= 0 Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity = Me.Opacity + 0.1
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Berikut Username dan Passwordnya
Username | Password
syamsir1   |  syam1
syamsir2   |  syam2
reza99999 |  99999
reza88888 |  88888"
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Start()
        Panel2.Left = Me.Width
        tbUsername.Focus()
    End Sub

    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel1.MouseDown, Panel2.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbUsername.Text = "syamsir1" And tbPassword.Text = "syam1" Then
            Form1.Label1.Text = "Selamat Datang " & tbUsername.Text & " Di Aplikasi Hitung Usaha Pegas"
            Timer1.Start()
            Timer2.Start()
            Timer3.Stop()
        ElseIf tbUsername.Text = "syamsir2" And tbPassword.Text = "syam2" Then
            Form1.Label1.Text = "Selamat Datang " & tbUsername.Text & " Di Aplikasi Hitung Usaha Pegas"
            Timer1.Start()
            Timer2.Start()
            Timer3.Stop()
        ElseIf tbUsername.Text = "reza99999" And tbPassword.Text = "99999" Then
            Form1.Label1.Text = "Selamat Datang " & tbUsername.Text & " Di Aplikasi Hitung Usaha Pegas"
            Timer1.Start()
            Timer2.Start()
            Timer3.Stop()
        ElseIf tbUsername.Text = "reza88888" And tbPassword.Text = "88888" Then
            Form1.Label1.Text = "Selamat Datang " & tbUsername.Text & " Di Aplikasi Hitung Usaha Pegas"
            Timer1.Start()
            Timer2.Start()
            Timer3.Stop()
        Else
            TimerTurun.Enabled = True
            TimerNaik.Enabled = False
        End If
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Panel1.MouseMove, Panel2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub

    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover
        btnLogin.BackColor = Color.Lime
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles TimerGeserPanel.Tick
        If Panel2.Left > 0 Then
            Panel2.Left = Int(Panel2.Left - 50)
        Else
            Panel2.Left = 0
        End If
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.White
    End Sub

    Private Sub tbUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUsername.KeyPress
        e.KeyChar = LCase(e.KeyChar)
    End Sub
    Private Sub tbPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPassword.KeyPress
        e.KeyChar = LCase(e.KeyChar)
    End Sub

    Private Sub TimerTurun_Tick(sender As Object, e As EventArgs) Handles TimerTurun.Tick
        If Me.Height < 493 Then
            Me.Height = Int(Me.Height + 5)
        Else
            Me.Height = 493
            TimerDurasi.Enabled = True
        End If
    End Sub

    Private Sub TimerNaik_Tick(sender As Object, e As EventArgs) Handles TimerNaik.Tick
        If Me.Height > 412 Then
            Me.Height = Int(Me.Height - 5)
        Else
            Me.Height = 412
            TimerDurasi.Enabled = False
        End If
    End Sub

    Private Sub tbUsername_Enter(sender As Object, e As EventArgs) Handles tbUsername.Enter
        If tbUsername.Text = "Username" Then
            tbUsername.Text = ""
            tbUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbPassword_Enter(sender As Object, e As EventArgs) Handles tbPassword.Enter
        If tbPassword.Text = "Password" Then
            tbPassword.Text = ""
            tbPassword.UseSystemPasswordChar = True
            tbPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbUsername_Leave(sender As Object, e As EventArgs) Handles tbUsername.Leave
        If tbUsername.Text = "" Or tbUsername.Text = "Username" Then
            tbUsername.ForeColor = System.Drawing.Color.FromArgb(191, 205, 219, 255)
            tbUsername.Text = "Username"
        End If
    End Sub

    Private Sub tbPassword_Leave(sender As Object, e As EventArgs) Handles tbPassword.Leave
        If tbPassword.Text = "" Or tbPassword.Text = "Password" Then
            tbPassword.UseSystemPasswordChar = False
            tbPassword.ForeColor = System.Drawing.Color.FromArgb(191, 205, 219, 255)
            tbPassword.Text = "Password"
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TimerDurasi_Tick(sender As Object, e As EventArgs) Handles TimerDurasi.Tick
        TimerTurun.Enabled = False
        TimerNaik.Enabled = True
    End Sub
End Class