Public Class Form1
    'Error Handling Inputan Selain Angka,,, sehingga angka negatif pun tak bisa karena tanda mines(-) bukan angka
    Private Sub tbGajiPokok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbGajiPokok.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                MessageBox.Show("Masukkan Angka !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbIzin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbIzin.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                MessageBox.Show("Masukkan Angka !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbSakit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSakit.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                MessageBox.Show("Masukkan Angka !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbTanpaKeterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTanpaKeterangan.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                MessageBox.Show("Masukkan Angka !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Gaji Pokok", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Bulan", 75, HorizontalAlignment.Center)
        ListView1.Columns.Add("Jumlah Hari Kerja", 125, HorizontalAlignment.Center)
        ListView1.Columns.Add("Sakit", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tanpa Keterangan", 125, HorizontalAlignment.Center)
        ListView1.Columns.Add("Izin", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tunjangan", 125, HorizontalAlignment.Center)
        ListView1.Columns.Add("Gaji Bersih", 125, HorizontalAlignment.Center)
        btnClear.Enabled = False
    End Sub

    Sub Clear()
        tbGajiPokok.Text = ""
        cbBulan.Text = ""
        tbHariKerja.Text = ""
        tbSakit.Text = ""
        tbTanpaKeterangan.Text = ""
        tbIzin.Text = ""
        tbTunjangan.Text = ""
        tbGajiBersih.Text = ""
        tbGajiPokok.Focus()
        btnClear.Enabled = False
    End Sub

    Private Function Hitung_Hari_Kerja()
        If cbBulan.Text = "Januari" Or cbBulan.Text = "Maret" Or cbBulan.Text = "Mei" Or cbBulan.Text = "Juli" Or cbBulan.Text = "Agustus" Or cbBulan.Text = "Oktober" Or cbBulan.Text = "Desember" Then
            Return (31 - 4)
        ElseIf cbBulan.Text = "April" Or cbBulan.Text = "Juni" Or cbBulan.Text = "September" Or cbBulan.Text = "November" Then
            Return (30 - 4)
        ElseIf cbBulan.Text = "Februari" Then
            Return (28 - 4)
        End If
        Return 0
    End Function

    Private Function Hitung_Tunjangan()
        Dim Hari_Kerja, Sakit, Izin, Tanpa_Keterangan, Tunjangan As Double
        Hari_Kerja = Val(tbHariKerja.Text)
        Sakit = Val(tbSakit.Text)
        Izin = Val(tbIzin.Text)
        Tanpa_Keterangan = Val(tbTanpaKeterangan.Text)
        Tunjangan = (Hari_Kerja * 50000) - (Sakit * 20000) - (Izin * 5000) - (Tanpa_Keterangan * 30000)
        Return Tunjangan
    End Function

    Private Function Hitung_Gaji_Bersih()
        Dim Gaji_Bersih, Gaji_Pokok As Double
        Gaji_Pokok = Val(tbGajiPokok.Text)
        Gaji_Bersih = Gaji_Pokok + Hitung_Tunjangan()
        Return Gaji_Bersih
    End Function

    Private Function CekFormKosong()
        If tbGajiPokok.Text = "" Then
            MessageBox.Show("Gaji Pokok Wajib Diisi!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbGajiPokok.Focus()
        ElseIf cbBulan.Text = "" Then
            MessageBox.Show("Bulan Wajib Diisi!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbBulan.Focus()
        ElseIf tbSakit.Text = "" Then
            MessageBox.Show("Jumlah Sakit Wajib Diisi!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbSakit.Focus()
        ElseIf tbTanpaKeterangan.Text = "" Then
            MessageBox.Show("Jumlah Tanpa Keterangan Wajib Diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbTanpaKeterangan.Focus()
        ElseIf tbIzin.Text = "" Then
            MessageBox.Show("Jumlah Izin Wajib Diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbIzin.Focus()
        Else
            Return True
        End If
        Return False
    End Function



    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If CekFormKosong() = True Then
            Dim Data(8) As String
            Data(0) = tbGajiPokok.Text
            Data(1) = cbBulan.Text
            Data(2) = tbHariKerja.Text
            Data(3) = tbSakit.Text
            Data(4) = tbTanpaKeterangan.Text
            Data(5) = tbIzin.Text
            Data(6) = tbTunjangan.Text
            Data(7) = tbGajiBersih.Text

            Dim ListItem As ListViewItem
            ListItem = ListView1.Items.Add(Data(0))
            ListItem.SubItems.Add(Data(1))
            ListItem.SubItems.Add(Data(2))
            ListItem.SubItems.Add(Data(3))
            ListItem.SubItems.Add(Data(4))
            ListItem.SubItems.Add(Data(5))
            ListItem.SubItems.Add(Data(6))
            ListItem.SubItems.Add(Data(7))
            Clear()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub cbBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBulan.SelectedIndexChanged
        tbHariKerja.Text = Hitung_Hari_Kerja()
        tbTunjangan.Text = Hitung_Tunjangan()
        tbGajiBersih.Text = Hitung_Gaji_Bersih()
        btnClear.Enabled = True
        EnableDisableClear()
    End Sub

    Private Sub tbSakit_TextChanged(sender As Object, e As EventArgs) Handles tbSakit.TextChanged
        tbTunjangan.Text = Hitung_Tunjangan()
        tbGajiBersih.Text = Hitung_Gaji_Bersih()
        btnClear.Enabled = True
        EnableDisableClear()
    End Sub

    Private Sub tbTanpaKeterangan_TextChanged(sender As Object, e As EventArgs) Handles tbTanpaKeterangan.TextChanged
        tbTunjangan.Text = Hitung_Tunjangan()
        tbGajiBersih.Text = Hitung_Gaji_Bersih()
        btnClear.Enabled = True
        EnableDisableClear()
    End Sub

    Private Sub tbIzin_TextChanged(sender As Object, e As EventArgs) Handles tbIzin.TextChanged
        tbTunjangan.Text = Hitung_Tunjangan()
        tbGajiBersih.Text = Hitung_Gaji_Bersih()
        btnClear.Enabled = True
        EnableDisableClear()
    End Sub

    Private Sub tbGajiPokok_TextChanged(sender As Object, e As EventArgs) Handles tbGajiPokok.TextChanged
        btnClear.Enabled = True
        EnableDisableClear()
    End Sub

    Sub EnableDisableClear()
        If tbGajiPokok.Text = "" And tbIzin.Text = "" And tbTanpaKeterangan.Text = "" And tbSakit.Text = "" And cbBulan.Text = "" Then
            btnClear.Enabled = False
        Else
            btnClear.Enabled = True
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim Close As String
        Close = MessageBox.Show("Apakah Anda Ingin Keluar ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Close = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
