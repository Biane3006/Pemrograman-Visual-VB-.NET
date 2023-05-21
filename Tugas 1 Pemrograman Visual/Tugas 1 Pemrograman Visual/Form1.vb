Public Class Form1
    'Error Handling TextBox Quantity
    Private Sub TxtBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxQty.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                MessageBox.Show("Masukkan Angka!!!", "Error")
                e.Handled = True
            End If
        End If
    End Sub

    'Membuat Grafik sesuai data yang ada
    Private Sub Grafik()
        Dim JmlhBarangAqua As Integer = 0
        Dim JmlhBarangSabun As Integer = 0
        Dim JmlhBarangPastaGigi As Integer = 0
        If DataGridView1 IsNot Nothing Then
            Dim indeks As Integer = 0
            'Perulangan untuk menghitung jumlah quantity dari setiap barang.
            While (indeks <= (DataGridView1.Rows.Count - 2))
                If DataGridView1.Rows(indeks).Cells(1).Value.Equals("Aqua") Then
                    JmlhBarangAqua = JmlhBarangAqua + DataGridView1.Rows(indeks).Cells(2).Value
                ElseIf DataGridView1.Rows(indeks).Cells(1).Value.Equals("Sabun") Then
                    JmlhBarangSabun = JmlhBarangSabun + DataGridView1.Rows(indeks).Cells(2).Value
                ElseIf DataGridView1.Rows(indeks).Cells(1).Value.Equals("Pasta Gigi") Then
                    JmlhBarangPastaGigi = JmlhBarangPastaGigi + DataGridView1.Rows(indeks).Cells(2).Value
                End If
                indeks = indeks + 1
            End While
            QtyAqua.Text = JmlhBarangAqua
            QtySabun.Text = JmlhBarangSabun
            QtyPastaGigi.Text = JmlhBarangPastaGigi
            With Chart1
                .Titles.Clear()
                .Series.Clear()
                .Titles.Add("Laporan Stok Barang Bulan Januari 2023")
                .Series.Add("Jumlah Barang")
                .Series(0).Points.Clear()
                .Series(0).Points.AddXY("Aqua", QtyAqua.Text)
                .Series(0).Points.AddXY("Sabun", QtySabun.Text)
                .Series(0).Points.AddXY("Pasta Gigi", QtyPastaGigi.Text)
            End With
        End If
    End Sub

    'Tombol Tambah data dan logical error inputan
    Private Sub TambahBarang_Click(sender As Object, e As EventArgs) Handles TambahBarang.Click
        'Kode untuk memasukkan data ke dalam grid
        If ComboBoxNmBrng.Text = "" Then
            MessageBox.Show("Nama Barang belum diisi!!!", "Error")
        ElseIf TxtBoxQty.Text = "" Then
            MessageBox.Show("Quantity Barang belum diisi!!!", "Error")
        ElseIf ComboBoxNmBrng.Text = "Aqua" Or ComboBoxNmBrng.Text = "Sabun" Or ComboBoxNmBrng.Text = "Pasta Gigi" Then
            DataGridView1.Rows.Add("", ComboBoxNmBrng.Text, TxtBoxQty.Text)
            'Kode Untuk Membersihkan TextBox
            ComboBoxNmBrng.Text = ""
            TxtBoxQty.Text = ""
            Grafik()
        Else
            MessageBox.Show("Nama Barang Tidak Tersedia!!!", "Error")
        End If
        Call Penomoran()
    End Sub

    'Untuk membuat nomor urut
    Private Sub Penomoran()
        If DataGridView1 IsNot Nothing Then
            Dim JmlhKolom As Integer = 0
            While (JmlhKolom <= (DataGridView1.Rows.Count - 2))
                DataGridView1.Rows(JmlhKolom).Cells(0).Value = String.Format((JmlhKolom + 1).ToString(), "0")
                JmlhKolom = JmlhKolom + 1
            End While
        End If
    End Sub

    'Tombol Edit, Simpan dan Hapus (Tombolnya ada di dalam DataGridView)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "BtnUbah" Then
            Dim DataBarang As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ComboBoxNmBrng.Text = DataBarang.Cells(1).Value.ToString()
            TxtBoxQty.Text = DataBarang.Cells(2).Value.ToString()
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "BtnSimpan" Then
            Dim DataBarang As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If ComboBoxNmBrng.Text = "" Then
                MessageBox.Show("Nama Barang tidak boleh kosong!!!", "WOYYYYY")
            ElseIf TxtBoxQty.Text = "" Then
                MessageBox.Show("Quantity Barang tidak boleh kosong!!!", "WOYYYYY")
            Else
                DataBarang.Cells(1).Value = ComboBoxNmBrng.Text
                DataBarang.Cells(2).Value = TxtBoxQty.Text
                ComboBoxNmBrng.Text = ""
                TxtBoxQty.Text = ""
                Grafik()
            End If
        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "BtnHapus" Then
            DataGridView1.Rows.RemoveAt(DataGridView1.Rows(e.RowIndex).Index)
            Grafik()
        End If
        Call Penomoran()
    End Sub

    'Membuat Grafik awal pada saat aplikasi dijalankan
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QtyAqua.Text = 0
        QtySabun.Text = 0
        QtyPastaGigi.Text = 0
        With Chart1
            .Series.Clear()
            .Series.Add("Jumlah Barang")
            .Titles.Add("Laporan Stok Barang Bulan Januari 2023")
            .ChartAreas("ChartArea1").AxisX.Title = "Nama Barang"
            .ChartAreas("ChartArea1").AxisY.Title = "Quantity"
            .Series(0).Points.AddXY("Aqua", 0)
            .Series(0).Points.AddXY("Sabun", 0)
            .Series(0).Points.AddXY("Pasta Gigi", 0)
        End With
    End Sub
End Class
