Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Procedure Fungtion"
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Kode Barang")
        ListView1.Columns.Add("Nama Barang")
        ListView1.Columns.Add("Satuan")
        ListView1.Columns.Add("Harga")
        ListView1.Columns.Add("Harga Barang")
        ListView1.Columns.Add("Jumlah")
        ListView1.Columns.Add("Total")
        KB.Focus()
        Bersih()
    End Sub

    Sub Bersih()
        NB.Text = ""
        S.Text = ""
        HS.Text = ""
        J.Text = ""
        TH.Text = ""

        KB.Focus()
        TH.Enabled = False
    End Sub

    Private Function Hitung()
        Dim Jumlah, HargaSatuan, Total As Integer
        Jumlah = Val(J.Text)
        HargaSatuan = HS.Text
        Total = Jumlah * HargaSatuan
        TH.Text = Total
        Return Total
    End Function

    Private Function CekDataKosong()
        If KB.Text = "" Then
            MessageBox.Show("Kode Barang Wajib Diisi !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf NB.Text = "" Then
            MessageBox.Show("Nama Barang Wajib Diisi !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf S.Text = "" Then
            MessageBox.Show("Kolom Satuan Wajib Diisi !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf HS.Text = "" Then
            MessageBox.Show("Harga Satuan Wajib Diisi !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf J.Text = "" Then
            MessageBox.Show("Kolom Jumlah Wajib Diisi !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Return True
        End If

        Return False
    End Function

    Private Sub BtnH_Click(sender As Object, e As EventArgs) Handles BtnH.Click
        If CekDataKosong() = True Then
            Dim DataBarang(6) As String
            DataBarang(0) = KB.Text
            DataBarang(1) = NB.Text
            DataBarang(2) = S.Text
            DataBarang(3) = HS.Text
            DataBarang(4) = J.Text
            DataBarang(5) = Hitung()

            Dim DataBarangListView As ListViewItem
            DataBarangListView = ListView1.Items.Add(DataBarang(0))
            DataBarangListView.SubItems.Add(DataBarang(1))
            DataBarangListView.SubItems.Add(DataBarang(2))
            DataBarangListView.SubItems.Add(DataBarang(3))
            DataBarangListView.SubItems.Add(DataBarang(4))
            DataBarangListView.SubItems.Add(DataBarang(5))
            KB.Text = KB.Text + 1
            KB.Focus()
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        Bersih()
    End Sub

    Private Sub BtnE_Click(sender As Object, e As EventArgs) Handles BtnE.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Apakah Ingin Kelar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    End Sub
End Class
