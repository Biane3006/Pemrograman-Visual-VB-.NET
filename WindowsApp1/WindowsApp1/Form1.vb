Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = New DateTime(2002, 10, 20)
        MessageBox.Show("Tanggal : ", DateTimePicker1.Value.Date)
        MessageBox.Show("Hari : ", DateTimePicker1.Value.Date.ToString)
        MessageBox.Show("Minggu : ", DateTimePicker1.Value.DayOfWeek)
    End Sub
End Class
