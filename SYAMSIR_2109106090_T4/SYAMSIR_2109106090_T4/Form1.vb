Public Class Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnClose.Visible = False
        btnNo.Visible = True
        btnYes.Visible = True
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        btnYes.Visible = False
        btnNo.Visible = False
        btnClose.Visible = True
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Timer1.Start()
        Timer2.Start()
        Timer3.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Start()
        btnClose.Location = New Point(Me.Width - 202, 0)
        btnYes.Location = New Point(Me.Width - 202, 0)
        btnNo.Location = New Point(Me.Width - 90, 0)
        Label14.Location = New Point((Me.Width / 2) - (Label14.Width / 2), 14)
        Label5.Location = New Point((Me.Width / 2) - (Label5.Width / 2), 0)
        Label9.Location = New Point((Me.Width / 2) - (Label9.Width / 2), 0)
        Label10.Location = New Point((Me.Width / 2) - (Label10.Width / 2), 0)
        dtpTanggalLahir.MaxDate = DateTime.Now

        Label2.Location = New Point(Label14.Location.X - 20, 0)
        tbNIK.Location = New Point(Label2.Location.X + Label2.Width + 17, 9)
        Label15.Location = New Point(tbNIK.Location.X - 25, Label2.Location.Y)

        Label1.Location = New Point(Label2.Location.X, Label2.Height)
        tbNamaLengkap.Location = New Point(tbNIK.Location.X, tbNIK.Location.Y + tbNIK.Height + 8)
        Label16.Location = New Point(Label15.Location.X, Label1.Location.Y)

        Label4.Location = New Point(Label2.Location.X, Label2.Height + Label1.Height)
        dtpTanggalLahir.Location = New Point(tbNIK.Location.X, tbNamaLengkap.Location.Y + tbNamaLengkap.Height + 10)
        Label17.Location = New Point(Label15.Location.X, Label4.Location.Y)

        Label3.Location = New Point(Label2.Location.X, 0)
        cbProvinsiAlamat.Location = New Point(tbNIK.Location.X, 9)
        Label18.Location = New Point(Label15.Location.X, Label3.Location.Y)

        Label6.Location = New Point(Label2.Location.X, Label3.Height)
        cbKotaAlamat.Location = New Point(tbNIK.Location.X, cbProvinsiAlamat.Location.Y + cbProvinsiAlamat.Height + 8)
        Label19.Location = New Point(Label15.Location.X, Label6.Location.Y)

        Label7.Location = New Point(Label2.Location.X, Label3.Height + Label6.Height)
        cbKecamatan.Location = New Point(tbNIK.Location.X, cbKotaAlamat.Location.Y + cbKotaAlamat.Height + 8)
        Label20.Location = New Point(Label15.Location.X, Label7.Location.Y)

        Label8.Location = New Point(Label2.Location.X, Label3.Height + Label6.Height + Label7.Height)
        cbKelurahan.Location = New Point(tbNIK.Location.X, cbKecamatan.Location.Y + cbKecamatan.Height + 8)
        Label21.Location = New Point(Label15.Location.X, Label8.Location.Y)

        Label26.Location = New Point(Label2.Location.X, Label3.Height + Label6.Height + Label7.Height + Label8.Height)
        tbNamaJalan.Location = New Point(tbNIK.Location.X, cbKelurahan.Location.Y + cbKelurahan.Height + 8)
        Label25.Location = New Point(Label15.Location.X, Label26.Location.Y)

        Label13.Location = New Point(Label2.Location.X, 0)
        cbFaskes.Location = New Point(tbNIK.Location.X, 9)
        Label24.Location = New Point(Label15.Location.X, Label13.Location.Y)

        btnCetak.Location = New Point(tbNIK.Location.X, cbFaskes.Location.Y + cbFaskes.Height + 10)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity - 0.1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity <= 0 Then

            End
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity = Me.Opacity + 0.1
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If tbNIK.Text = "" Or tbNIK.TextLength < 16 Then
            MessageBox.Show("Data NIK Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbNIK.Focus()
        ElseIf tbNamaLengkap.Text = "" Then
            MessageBox.Show("Data Nama Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbNamaLengkap.Focus()
        ElseIf cbProvinsiAlamat.SelectedItem Is Nothing Then
            MessageBox.Show("Data Provinsi Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbProvinsiAlamat.Focus()
        ElseIf cbKotaAlamat.SelectedItem Is Nothing Then
            MessageBox.Show("Data Kota Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbKotaAlamat.Focus()
        ElseIf cbKecamatan.SelectedItem Is Nothing Then
            MessageBox.Show("Data Kecamatan Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbKecamatan.Focus()
        ElseIf cbKelurahan.SelectedItem Is Nothing Then
            MessageBox.Show("Data Kelurahan Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbKelurahan.Focus()
        ElseIf tbNamaJalan.Text = "" Then
            MessageBox.Show("Data Alamat Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbNamaJalan.Focus()
        ElseIf cbFaskes.SelectedItem Is Nothing Then
            MessageBox.Show("Data Faskes Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbFaskes.Focus()
        Else
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.FormBorderStyle = FormBorderStyle.None
            PrintPreviewDialog1.WindowState = FormWindowState.Maximized
            AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim randomNomor As String = ""
        Randomize()
        For i As Integer = 1 To 13
            randomNomor &= Int(Rnd() * 10)
        Next

        Dim rect As New Rectangle(50, 50, 1000, 646)
        Dim borderRadius As Integer = 20
        Dim penBorder As New Pen(Color.FromArgb(255, 0, 112, 64), 8)

        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        'Kiri Atas
        path.AddArc(rect.X, rect.Y, borderRadius * 2, borderRadius * 2, 180, 90)
        'path.AddLine(rect.X + borderRadius, rect.Y, rect.X + rect.Width - borderRadius, rect.Y)
        'Kanan Atas
        path.AddArc(rect.X + rect.Width - borderRadius * 2, rect.Y, borderRadius * 2, borderRadius * 2, 270, 90)
        'path.AddLine(rect.X + rect.Width, rect.Y + borderRadius, rect.X + rect.Width, rect.Y + rect.Y)

        path.AddLine(rect.Right, rect.Top + 120, rect.Left, rect.Top + 120)
        path.AddLine(rect.Left, rect.Top + 120, rect.Left, rect.Top + borderRadius)
        'Mengisi path dengan warna (HEADERNYA)
        Dim brush As New Drawing2D.LinearGradientBrush(rect, Color.FromArgb(255, 0, 112, 64), Color.FromArgb(255, 0, 112, 64), Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillPath(brush, path)


        'Membuat kotak ISIANNYA
        path.AddArc(rect.X + rect.Width - borderRadius * 2, rect.Y + rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90)
        path.AddLine(rect.X + rect.Width, rect.Y + rect.Height - borderRadius, rect.X + rect.Width, rect.Y + rect.Height - borderRadius)
        'Mengisi path dengan gambar (ISIANNYA)
        'Mengisi background image
        Dim gambarBackground As Image = gbrBackground.Image
        e.Graphics.DrawImage(gambarBackground, rect.Left, rect.Top + 120, rect.Width, rect.Bottom - 170)

        path.CloseFigure()
        ' Draw the top and bottom lines inside the rectangle
        e.Graphics.DrawLine(penBorder, rect.Left, rect.Top + 120, rect.Right, rect.Top + 120)

        Dim penBorder1 As New Pen(Color.FromArgb(255, 0, 166, 80), 5)
        'Garis Tepi atas
        e.Graphics.DrawLine(penBorder1, rect.Left + borderRadius, rect.Top, rect.Right - borderRadius, rect.Top)
        'Garis Tepi bawah
        e.Graphics.DrawLine(penBorder1, rect.Left + borderRadius, rect.Bottom, rect.Right - borderRadius, rect.Bottom)
        'Garis Tepi Kanan
        e.Graphics.DrawLine(penBorder1, rect.Right, rect.Top + borderRadius, rect.Right, rect.Bottom - borderRadius)
        'Garis Tepi Kiri
        e.Graphics.DrawLine(penBorder1, rect.Left, rect.Top + borderRadius, rect.Left, rect.Bottom - borderRadius)

        'Lengkungan Kanan Atas
        e.Graphics.DrawCurve(penBorder1, {New Point(rect.Right - borderRadius - 1, rect.Top), New Point(rect.Right - 6, rect.Top + 6), New Point(rect.Right, rect.Top + borderRadius + 1)})
        'Lengkungan Kiri Atas
        e.Graphics.DrawCurve(penBorder1, {New Point(rect.Left + borderRadius + 1, rect.Top), New Point(rect.Left + 6, rect.Top + 6), New Point(rect.Left, rect.Top + borderRadius + 1)})
        'Lengkungan Kanan Bawah
        e.Graphics.DrawCurve(penBorder1, {New Point(rect.Right - borderRadius - 1, rect.Bottom), New Point(rect.Right - 6, rect.Bottom - 6), New Point(rect.Right, rect.Bottom - borderRadius - 1)})
        'Lengkungan Kiri Bawah
        e.Graphics.DrawCurve(penBorder1, {New Point(rect.Left + borderRadius + 1, rect.Bottom), New Point(rect.Left + 6, rect.Bottom - 6), New Point(rect.Left, rect.Bottom - borderRadius - 1)})


        ' Load the Garuda image
        Dim garudaImage As Image = gbrGaruda.Image

        ' Draw the Garuda image on the left side of the rectangle
        e.Graphics.DrawImage(garudaImage, rect.Left + 20, rect.Top + 3, 120, 120)

        ' Load the Healthy Care logo image
        Dim healthyCareImage As Image = gbrHealthy.Image

        ' Draw the Healthy Care logo image on the left side of the rectangle
        e.Graphics.DrawImage(healthyCareImage, rect.Left + 855, rect.Top + 3, 130, 120)


        ' Load Gambar Barcode
        Dim barcodeImage As Image = gbrBarcode.Image

        ' Draw the Garuda image on the left side of the rectangle
        e.Graphics.DrawImage(barcodeImage, rect.Left + 100, rect.Top + 150, 400, 40)

        ' Draw the text data inside the rectangle
        Dim fontJudul As New Font("Calibri", 40, FontStyle.Bold)
        e.Graphics.DrawString("Kartu Indonesia Sehat", fontJudul, Brushes.White, rect.Left + 240, rect.Top + 30)

        Dim fontData As New Font("Arial", 18, FontStyle.Regular)
        e.Graphics.DrawString("Nomor Kartu", fontData, Brushes.Black, rect.Left + 100, rect.Top + 200)
        e.Graphics.DrawString(": " & randomNomor, fontData, Brushes.Black, rect.Left + 300, rect.Top + 200)

        e.Graphics.DrawString("Nama", fontData, Brushes.Black, rect.Left + 100, rect.Top + 240)
        e.Graphics.DrawString(": " & tbNamaLengkap.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 240)

        e.Graphics.DrawString("Alamat", fontData, Brushes.Black, rect.Left + 100, rect.Top + 280)

        If Len(tbNamaJalan.Text & " " & cbKelurahan.Text & " " & cbKecamatan.Text) > 50 Then
            e.Graphics.DrawString(": " & tbNamaJalan.Text & " " & cbKelurahan.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 280)
            e.Graphics.DrawString("  " & cbKecamatan.Text & " " & cbKotaAlamat.Text & " " & cbProvinsiAlamat.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 320)
        Else
            e.Graphics.DrawString(": " & tbNamaJalan.Text & " " & cbKelurahan.Text & " " & cbKecamatan.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 280)
            e.Graphics.DrawString("  " & cbKotaAlamat.Text & " " & cbProvinsiAlamat.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 320)
        End If

        e.Graphics.DrawString("Tanggal Lahir", fontData, Brushes.Black, rect.Left + 100, rect.Top + 360)
        e.Graphics.DrawString(": " & dtpTanggalLahir.Value.ToString("dd-MM-yyyy"), fontData, Brushes.Black, rect.Left + 300, rect.Top + 360)

        e.Graphics.DrawString("NIK", fontData, Brushes.Black, rect.Left + 100, rect.Top + 400)
        e.Graphics.DrawString(": " & tbNIK.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 400)

        e.Graphics.DrawString("Faskes Tingkat 1", fontData, Brushes.Black, rect.Left + 100, rect.Top + 440)
        e.Graphics.DrawString(": " & cbFaskes.Text, fontData, Brushes.Black, rect.Left + 300, rect.Top + 440)

        Dim fontKetentuan As New Font("Arial", 10, FontStyle.Regular)
        e.Graphics.DrawString("Syarat dan Ketentuan:
1.Kartu Peserta harap dibawa ketika berobat.
2. Apabila kartu ini disalahgunakan akan dikenakan sanksi.
3. Apabila ada perubahan atau kehilangan Kartu, segera lapor ke kantor BPJS Kesehatan setempat.

BPJS Kesehatan Care Center 165
www.bpjs-kesehatan.go.id
", fontKetentuan, Brushes.Black, rect.Left + 100, rect.Top + 485)
    End Sub


    Private Sub tbNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbProvinsiAlamat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvinsiAlamat.SelectedIndexChanged
        If cbProvinsiAlamat.Text = "Kalimantan Timur" Then
            cbKotaAlamat.Items.Add("Berau")
            cbKotaAlamat.Items.Add("Kutai Barat")
            cbKotaAlamat.Items.Add("Kutai Kartanegara")
            cbKotaAlamat.Items.Add("Kutai Timur")
            cbKotaAlamat.Items.Add("Mahakam Ulu")
            cbKotaAlamat.Items.Add("Paser")
            cbKotaAlamat.Items.Add("Penajam Paser Utara")
            cbKotaAlamat.Items.Add("Balikpapan")
            cbKotaAlamat.Items.Add("Bontang")
            cbKotaAlamat.Items.Add("Samarinda")
        End If
    End Sub

    Private Sub cbKotaAlamat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKotaAlamat.SelectedIndexChanged
        cbKecamatan.Items.Clear()
        If cbKotaAlamat.Text = "Berau" Then
            cbKecamatan.Items.Add("Batu Putih")
            cbKecamatan.Items.Add("Pulau Derawan")
        ElseIf cbKotaAlamat.Text = "Kutai Barat" Then
            cbKecamatan.Items.Add("Damai")
            cbKecamatan.Items.Add("Jempang")
        ElseIf cbKotaAlamat.Text = "Kutai Kartanegara" Then
            cbKecamatan.Items.Add("Anggana")
            cbKecamatan.Items.Add("Kota Bangun")
        ElseIf cbKotaAlamat.Text = "Kutai Timur" Then
            cbKecamatan.Items.Add("Bengalon")
            cbKecamatan.Items.Add("Busang")
        ElseIf cbKotaAlamat.Text = "Mahakam Ulu" Then
            cbKecamatan.Items.Add("Laham")
            cbKecamatan.Items.Add("Long Apari")
        ElseIf cbKotaAlamat.Text = "Paser" Then
            cbKecamatan.Items.Add("Kuaro")
            cbKecamatan.Items.Add("Long Kali")
        ElseIf cbKotaAlamat.Text = "Penajam Paser Utara" Then
            cbKecamatan.Items.Add("Babulu")
            cbKecamatan.Items.Add("Penajam")
        ElseIf cbKotaAlamat.Text = "Balikpapan" Then
            cbKecamatan.Items.Add("Balikpapan Timur")
            cbKecamatan.Items.Add("Balikpapan Barat")
        ElseIf cbKotaAlamat.Text = "Bontang" Then
            cbKecamatan.Items.Add("Bontang Barat")
            cbKecamatan.Items.Add("Bontang Selatan")
        ElseIf cbKotaAlamat.Text = "Samarinda" Then
            cbKecamatan.Items.Add("Sambutan")
            cbKecamatan.Items.Add("Palaran")
        End If
    End Sub

    Private Sub cbKecamatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKecamatan.SelectedIndexChanged
        cbKelurahan.Items.Clear()
        cbFaskes.Items.Clear()
        If cbKecamatan.Text = "Batu Putih" Then
            cbKelurahan.Items.Add("Kayu Indah")
            cbKelurahan.Items.Add("Tembudan")
            cbFaskes.Items.Add("Puskesmas Batu Indah")
            cbFaskes.Items.Add("Puskesmas Tembudan")
        ElseIf cbKecamatan.Text = "Pulau Derawan" Then
            cbKelurahan.Items.Add("Kasai")
            cbKelurahan.Items.Add("Tanjung Batu")
            cbFaskes.Items.Add("Puskesmas Kasai")
            cbFaskes.Items.Add("Puskesmas Tanjung Batu")
        ElseIf cbKecamatan.Text = "Damai" Then
            cbKelurahan.Items.Add("Benung")
            cbKelurahan.Items.Add("Bermai")
            cbFaskes.Items.Add("Puskesmas Benung")
            cbFaskes.Items.Add("Puskesmas Bermai")
        ElseIf cbKecamatan.Text = "Jempang" Then
            cbKelurahan.Items.Add("Mancong")
            cbKelurahan.Items.Add("Perigiq")
            cbFaskes.Items.Add("Puskesmas Mancong")
            cbFaskes.Items.Add("Puskesmas Perigiq")
        ElseIf cbKecamatan.Text = "Anggana" Then
            cbKelurahan.Items.Add("Anggana")
            cbKelurahan.Items.Add("Kutai Lama")
            cbFaskes.Items.Add("Puskesmas Anggana")
            cbFaskes.Items.Add("Puskesmas Kutai Lama")
        ElseIf cbKecamatan.Text = "Kota Bangun" Then
            cbKelurahan.Items.Add("Wonosari")
            cbKelurahan.Items.Add("Pela")
            cbFaskes.Items.Add("Puskesmas Wonosari")
            cbFaskes.Items.Add("Puskesmas Pela")
        ElseIf cbKecamatan.Text = "Bengalon" Then
            cbKelurahan.Items.Add("Keraitan")
            cbKelurahan.Items.Add("Sepaso")
            cbFaskes.Items.Add("Puskesmas Keraitan")
            cbFaskes.Items.Add("Puskesmas Sepaso")
        ElseIf cbKecamatan.Text = "Busang" Then
            cbKelurahan.Items.Add("Long Bentuk")
            cbKelurahan.Items.Add("Long Lees")
            cbFaskes.Items.Add("Puskesmas Long Bentuk")
            cbFaskes.Items.Add("Puskesmas Long Lees")
        ElseIf cbKecamatan.Text = "Laham" Then
            cbKelurahan.Items.Add("Muara Ratah")
            cbKelurahan.Items.Add("Danum Paroy")
            cbFaskes.Items.Add("Puskesmas Muara Ratah")
            cbFaskes.Items.Add("Puskesmas Danum Paroy")
        ElseIf cbKecamatan.Text = "Long Apari" Then
            cbKelurahan.Items.Add("Long Kerioq")
            cbKelurahan.Items.Add("Long Apari")
            cbFaskes.Items.Add("Puskesmas Long Kerioq")
            cbFaskes.Items.Add("Puskesmas Long Apari")
        ElseIf cbKecamatan.Text = "Kuaro" Then
            cbKelurahan.Items.Add("Kerta Bumi")
            cbKelurahan.Items.Add("Sandeley")
            cbFaskes.Items.Add("Puskesmas Kuaro")
            cbFaskes.Items.Add("Puskesmas Kerta Bumi")
        ElseIf cbKecamatan.Text = "Long Kali" Then
            cbKelurahan.Items.Add("Makmur")
            cbKelurahan.Items.Add("Munggu")
            cbFaskes.Items.Add("Puskesmas Makmur")
            cbFaskes.Items.Add("Puskesmas Munggu")
        ElseIf cbKecamatan.Text = "Babulu" Then
            cbKelurahan.Items.Add("Rintik")
            cbKelurahan.Items.Add("Sri Raharja")
            cbFaskes.Items.Add("Puskesmas Rintik")
            cbFaskes.Items.Add("Puskesmas Sri Raharja")
        ElseIf cbKecamatan.Text = "Penajam" Then
            cbKelurahan.Items.Add("Pejala")
            cbKelurahan.Items.Add("Nenang")
            cbFaskes.Items.Add("Puskesmas Pejala")
            cbFaskes.Items.Add("Puskesmas Nenang")
        ElseIf cbKecamatan.Text = "Balikpapan Timur" Then
            cbKelurahan.Items.Add("Lamaru")
            cbKelurahan.Items.Add("Manggar")
            cbFaskes.Items.Add("Puskesmas Lamaru")
            cbFaskes.Items.Add("Puskesmas Manggar")
        ElseIf cbKecamatan.Text = "Balikpapan Barat" Then
            cbKelurahan.Items.Add("Margo Mulyo")
            cbKelurahan.Items.Add("Margasari")
            cbFaskes.Items.Add("Puskesmas Margo Mulyo")
            cbFaskes.Items.Add("Puskesmas Margasari")
        ElseIf cbKecamatan.Text = "Bontang Barat" Then
            cbKelurahan.Items.Add("Belimbing")
            cbKelurahan.Items.Add("Kanaan")
            cbFaskes.Items.Add("Puskesmas Belimbing")
            cbFaskes.Items.Add("Puskesmas Kanaan")
        ElseIf cbKecamatan.Text = "Bontang Selatan" Then
            cbKelurahan.Items.Add("Berbas Pantai")
            cbKelurahan.Items.Add("Berbas Tengah")
            cbFaskes.Items.Add("Puskesmas Berbas Pantai")
            cbFaskes.Items.Add("Puskesmas Berbas Tengah")
        ElseIf cbKecamatan.Text = "Sambutan" Then
            cbKelurahan.Items.Add("Makroman")
            cbKelurahan.Items.Add("Pulau Atas")
            cbFaskes.Items.Add("Puskesmas Makroman")
            cbFaskes.Items.Add("Puskesmas Pulau Atas")
        ElseIf cbKecamatan.Text = "Palaran" Then
            cbKelurahan.Items.Add("Bukuan")
            cbKelurahan.Items.Add("Bantuas")
            cbFaskes.Items.Add("Puskesmas Bukuan")
            cbFaskes.Items.Add("Puskesmas Bantuas")
        End If
    End Sub

    Private Sub tbNamaLengkap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNamaLengkap.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 65) And (tombol <= 90)) Or ((tombol >= 97) And (tombol <= 122)) Or (tombol = 8) Or (tombol = 32) Or (tombol = 46)) Then
            e.Handled = True
        End If
    End Sub
End Class
