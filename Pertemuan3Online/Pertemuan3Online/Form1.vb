Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "*.jpg|"
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Nama, JK, Prodi, Hobi As String
        Dim Nim As Integer
        Dim Tanggal As Date

        Nama = tbNama.Text
        Nim = tbNim.Text

        If rbLaki.Checked Then
            JK = rbLaki.Text
        Else
            JK = rbPerempuan.Text
        End If

        Tanggal = DateTimePicker1.Value.Date
        Prodi = cbProdi.Text

    End Sub
End Class
