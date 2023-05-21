Public Class Form1
    Private Sub TambahBarang_Click(sender As Object, e As EventArgs) Handles TambahBarang.Click
        'Kode untuk memasukkan data ke dalam grid
        DataGridView1.Rows.Add(TxtBoxNmBrng.Text, TxtBoxQty.Text)
        'Kode Untuk Membersihkan TextBox
        TxtBoxNmBrng.Text = ""
        TxtBoxQty.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Fungsi Penomoran
    Sub Penomoran()
        If DataGridView1 IsNot Nothing Then
            Dim JmlhKolom As Integer = 0
            While (JmlhKolom <= (DataGridView1.Rows.Count - 2))
                DataGridView1.Rows(JmlhKolom).HeaderCell.Value = String.Format((JmlhKolom + 1).ToString(), "0")
                JmlhKolom = JmlhKolom + 1
            End While
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Call Penomoran()
    End Sub
End Class
