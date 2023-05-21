Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Memasukkan Data Makanan
        Dim lokasiFile As String = CurDir()
        dgvMakanan.Rows.Add("", "Bakso Ayam", "15000", lokasiFile + "\Gambar\Makanan\Bakso Ayam.bmp")
        dgvMakanan.Rows.Add("", "Bakso Kambing", "20000", lokasiFile + "\Gambar\Makanan\Bakso Kambing.jpg")
        dgvMakanan.Rows.Add("", "Mie Ayam", "13000", lokasiFile + "\Gambar\Makanan\Mie Ayam.jpg")
        dgvMakanan.Rows.Add("", "Nasi Ayam Bakar", "10000", lokasiFile + "\Gambar\Makanan\Nasi Ayam Bakar.jpg")
        dgvMakanan.Rows.Add("", "Nasi Ayam Geprek", "11000", lokasiFile + "\Gambar\Makanan\Nasi Ayam Geprek.jpg")
        dgvMakanan.Rows.Add("", "Nasi Ayam Goreng", "11000", lokasiFile + "\Gambar\Makanan\Nasi Ayam Goreng.jpg")
        dgvMakanan.Rows.Add("", "Nasi Goreng Biasa", "12000", lokasiFile + "\Gambar\Makanan\Nasi Goreng Biasa.jpg")
        dgvMakanan.Rows.Add("", "Nasi Goreng Spesial", "22000", lokasiFile + "\Gambar\Makanan\Nasi Goreng Spesial.jpg")
        dgvMakanan.Rows.Add("", "Sate Ayam", "17000", lokasiFile + "\Gambar\Makanan\Sate Ayam.jpg")
        dgvMakanan.Rows.Add("", "Sate Kambing", "20000", lokasiFile + "\Gambar\Makanan\Sate Kambing.jpg")
        'Membuat Penomoran pada Tabel Makanan
        Penomoran(dgvMakanan)

        'Memasukkan Data Minuman
        dgvMinuman.Rows.Add("", "Aqua 330ml", "5000", lokasiFile + "\Gambar\Minuman\Aqua 330ml.jpg")
        dgvMinuman.Rows.Add("", "Aqua 600ml", "8000", lokasiFile + "\Gambar\Minuman\Aqua 600ml.jpg")
        dgvMinuman.Rows.Add("", "Cappucino Cincau", "10000", lokasiFile + "\Gambar\Minuman\Cappucino Cincau.jpg")
        dgvMinuman.Rows.Add("", "Es Coklat", "12000", lokasiFile + "\Gambar\Minuman\Es Coklat.jpg")
        dgvMinuman.Rows.Add("", "Es Jeruk", "7000", lokasiFile + "\Gambar\Minuman\Es Jeruk.jpg")
        dgvMinuman.Rows.Add("", "Es Teh", "7000", lokasiFile + "\Gambar\Minuman\Es Teh.jpg")
        dgvMinuman.Rows.Add("", "Ice Blend", "15000", lokasiFile + "\Gambar\Minuman\Ice Blend.bmp")
        dgvMinuman.Rows.Add("", "Kopi Pahit", "4000", lokasiFile + "\Gambar\Minuman\Kopi Pahit.jpg")
        dgvMinuman.Rows.Add("", "Kopi Susu", "8000", lokasiFile + "\Gambar\Minuman\Kopi Susu.jpg")
        dgvMinuman.Rows.Add("", "Teh Hangat", "7000", lokasiFile + "\Gambar\Minuman\Teh Hangat.jpg")
        'Membuat Penomoran pada Tabel Minuman
        Penomoran(dgvMinuman)
        UpdateTotalPembayaran()
        tbNoPesanan.Text = "001/SMD/2023"
    End Sub



    'Penomoran
    Private Sub Penomoran(ByRef data As DataGridView)
        If data IsNot Nothing Then
            Dim JmlhKolom As Integer = 0
            While (JmlhKolom <= (data.Rows.Count - 1))
                data.Rows(JmlhKolom).Cells(0).Value = String.Format((JmlhKolom + 1).ToString(), "0")
                JmlhKolom = JmlhKolom + 1
            End While
        End If
    End Sub


    'Pesan Makanan
    'Mikir algoritmanya sampe PUSING PUSING
    Private Sub btnTambahMakanan_Click(sender As Object, e As EventArgs) Handles btnTambahMakanan.Click
        Dim jumlahCellsTerpilih As Integer = dgvMakanan.GetCellCount(DataGridViewElementStates.Selected)
        If jumlahCellsTerpilih > 0 Then
            Dim i As Integer
            For i = 0 To jumlahCellsTerpilih - 1
                Dim indeks As Integer = dgvMakanan.SelectedCells(i).RowIndex
                Dim namaMakanan As String = dgvMakanan.Rows(indeks).Cells(1).Value
                Dim hargaSatuan As String = dgvMakanan.Rows(indeks).Cells(2).Value
                If dgvPesanan IsNot Nothing Then
                    Dim j As Integer = 0
                    Dim sama As Boolean = False
                    'Memeriksa pesanan yang sudah dipesan
                    While (j <= (dgvPesanan.Rows.Count - 1))
                        If dgvPesanan.Rows(j).Cells(1).Value.Equals(namaMakanan) Then
                            sama = True
                            MessageBox.Show("Makanan Sudah Dipesan, Silahkan Ganti Jumlah Pesanan!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit While
                        End If
                        j = j + 1
                    End While
                    If sama = False Then
                        dgvPesanan.Rows.Add("", namaMakanan, "1", hargaSatuan, hargaSatuan)
                    End If
                End If
            Next
        Else
            MessageBox.Show("Silahkan Pilih Menu Yang Tersedia!!!", "Warning")
        End If
        Penomoran(dgvPesanan)
        UpdateTotalPembayaran()
    End Sub

    'Pesan Minuman
    Private Sub btnTambahMinuman_Click(sender As Object, e As EventArgs) Handles btnTambahMinuman.Click
        Dim jumlahCellsTerpilih As Integer = dgvMinuman.GetCellCount(DataGridViewElementStates.Selected)
        If jumlahCellsTerpilih > 0 Then
            Dim i As Integer
            For i = 0 To jumlahCellsTerpilih - 1
                Dim indeks As Integer = dgvMinuman.SelectedCells(i).RowIndex
                Dim namaMinuman As String = dgvMinuman.Rows(indeks).Cells(1).Value
                Dim hargaSatuan As String = dgvMinuman.Rows(indeks).Cells(2).Value
                If dgvPesanan IsNot Nothing Then
                    Dim j As Integer = 0
                    Dim sama As Boolean = False
                    'Memeriksa pesanan yang sudah dipesan
                    While (j <= (dgvPesanan.Rows.Count - 1))
                        If dgvPesanan.Rows(j).Cells(1).Value.Equals(namaMinuman) Then
                            sama = True
                            MessageBox.Show("Minuman Sudah Dipesan, Silahkan Ganti Jumlah Pesanan!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit While
                        End If
                        j = j + 1
                    End While
                    If sama = False Then
                        dgvPesanan.Rows.Add("", namaMinuman, "1", hargaSatuan, hargaSatuan)
                    End If
                End If
            Next
        Else
            MessageBox.Show("Silahkan Pilih Menu Yang Tersedia!!!", "Warning")
        End If
        Penomoran(dgvPesanan)
        UpdateTotalPembayaran()
    End Sub

    'Menampilkan Gambar sesuai makanan
    Private Sub dgvMakanan_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakanan.CellEnter
        fotoMakanan.ImageLocation = dgvMakanan.Rows(e.RowIndex).Cells(3).Value.ToString
    End Sub

    'Menampilkan Gambar Sesuai Minuman
    Private Sub dgvMinuman_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMinuman.CellEnter
        fotoMinuman.ImageLocation = dgvMinuman.Rows(e.RowIndex).Cells(3).Value.ToString
    End Sub


    'Mengubah Jumlah Pesanan
    Private Sub dgvPesanan_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvPesanan.CurrentCellDirtyStateChanged
        Try
            If dgvPesanan.CurrentRow.Cells(2).Value = 0 Then
                dgvPesanan.Rows.RemoveAt(dgvPesanan.CurrentRow.Index)
                Penomoran(dgvPesanan)
                UpdateTotalPembayaran()
            End If
            Dim Total As Integer = Val(dgvPesanan.CurrentRow.Cells(2).Value) * Val(dgvPesanan.CurrentRow.Cells(3).Value)
            dgvPesanan.CurrentRow.Cells(4).Value = Total
            UpdateTotalPembayaran()
        Catch ex As Exception
            MessageBox.Show("Masukkan Angka!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvPesanan.CurrentRow.Cells(2).Value = 1
            Dim Total As Integer = Val(dgvPesanan.CurrentRow.Cells(2).Value) * Val(dgvPesanan.CurrentRow.Cells(3).Value)
            dgvPesanan.CurrentRow.Cells(4).Value = Total
        End Try
    End Sub

    'Menghapus Pesanan
    Private Sub dgvPesanan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesanan.CellContentClick
        If dgvPesanan.Columns(e.ColumnIndex).Name = "btnBatal" Then
            dgvPesanan.Rows.RemoveAt(dgvPesanan.Rows(e.RowIndex).Index)
            Penomoran(dgvPesanan)
            UpdateTotalPembayaran()
        End If
    End Sub

    'Fungsi untuk mengupdate Total Pembayaran/Total Pesanan
    Private Sub UpdateTotalPembayaran()
        If dgvPesanan IsNot Nothing Then
            Dim totalPembayaran As Double = 0
            Dim indeks As Integer
            While (indeks <= dgvPesanan.Rows.Count - 1)
                totalPembayaran = totalPembayaran + dgvPesanan.Rows(indeks).Cells(4).Value
                indeks = indeks + 1
            End While
            tbTotalPesanan.Text = totalPembayaran
        Else
            tbTotalPesanan.Text = 0
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbNamaPemesan.Text = "" Then
            MessageBox.Show("Nama Pemesan Masih Kosong!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cbMejaPemesan.SelectedIndex < 0 Then
            MessageBox.Show("Nomor Meja Belum Dipilih!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf dgvPesanan.Rows.Count = 0 Then
            MessageBox.Show("Anda Belum Memesan Apapun", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Pesanan Telah Disimpan, Silahkan Tunggu Pesanan Datang!", "Pemesanan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbNamaPemesan.Text = ""
            cbMejaPemesan.Text = ""
            tbTotalPesanan.Text = ""
            dgvPesanan.Rows.Clear()
            'Nomor Pesanan
            Dim NomorPesanan As Integer = Val(Microsoft.VisualBasic.Left(tbNoPesanan.Text, 3)) + 1
            If NomorPesanan < 10 Then
                tbNoPesanan.Text = "00" + NomorPesanan.ToString + "/SMD/2023"
            ElseIf NomorPesanan >= 10 And NomorPesanan < 100 Then
                tbNoPesanan.Text = "0" + NomorPesanan.ToString + "/SMD/2023"
            ElseIf NomorPesanan >= 100 And NomorPesanan < 1000 Then
                tbNoPesanan.Text = NomorPesanan.ToString + "/SMD/2023"
            Else
                'Klo lebih dari 999 maka mengulang dari awal lagi
                tbNoPesanan.Text = "001/SMD/2023"
            End If
        End If

    End Sub

    Private Sub dgvPesanan_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvPesanan.DataError
        MessageBox.Show("Minuman Sudah Dipesan, Silahkan Ganti Jumlah Pesanan!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class
