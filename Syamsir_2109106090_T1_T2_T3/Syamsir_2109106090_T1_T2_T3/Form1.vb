Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity - 0.1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity <= 0 Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity = Me.Opacity + 0.1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Start()
        Label2.Location = New Point((Me.Width / 2) - (Label2.Width / 2), 1)
        Panel1.Width = Me.Width
        Panel2.Width = Me.Width
        Panel1.Location = New Point(0, Me.Height - Panel1.Height)
        btnClose.Location = New Point(Me.Width - 200, 8)
        btnYes.Location = New Point(Me.Width - 100, 8)
        btnNo.Location = New Point(Me.Width - 200, 8)
        GroupBox1.Location = New Point((Me.Width / 2) - (GroupBox1.Width / 2), 125)
    End Sub


    Private Sub TimerTeksJalan_Tick(sender As Object, e As EventArgs) Handles TimerTeksJalan.Tick
        If Label1.Left >= Me.Width Then
            Label1.Left = -Label1.Width
        Else
            Label1.Left = Label1.Left + 10
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnClose.Visible = False
        btnNo.Visible = True
        btnYes.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        btnYes.Visible = False
        btnNo.Visible = False
        btnClose.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Timer1.Start()
        Timer2.Start()
        Timer3.Stop()
    End Sub

    Private Sub tbKonstanta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKonstanta.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbKonstanta_Enter(sender As Object, e As EventArgs) Handles tbKonstanta.Enter
        If tbKonstanta.Text = "Konstanta Pegas" Then
            tbKonstanta.Text = ""
            tbKonstanta.ForeColor = Color.Black
        End If
    End Sub


    Private Sub tbKonstanta_Leave(sender As Object, e As EventArgs) Handles tbKonstanta.Leave
        If tbKonstanta.Text = "" Then
            tbKonstanta.ForeColor = System.Drawing.Color.FromArgb(191, 205, 219, 255)
            tbKonstanta.Text = "Konstanta Pegas"
        End If
    End Sub

    Private Sub tbDeltaX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDeltaX.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbDeltaX_Enter(sender As Object, e As EventArgs) Handles tbDeltaX.Enter
        If tbDeltaX.Text = "Pertambahan Panjang" Then
            tbDeltaX.Text = ""
            tbDeltaX.ForeColor = Color.Black
        End If
    End Sub


    Private Sub tbDeltaX_Leave(sender As Object, e As EventArgs) Handles tbDeltaX.Leave
        If tbDeltaX.Text = "" Then
            tbDeltaX.ForeColor = System.Drawing.Color.FromArgb(191, 205, 219, 255)
            tbDeltaX.Text = "Pertambahan Panjang"
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        tbUsaha.Text = (1 / 2) * Val(tbKonstanta.Text) * Val(tbDeltaX.Text) * Val(tbDeltaX.Text)
    End Sub
End Class
