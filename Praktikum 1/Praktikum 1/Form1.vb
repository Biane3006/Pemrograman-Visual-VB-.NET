Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim Angka1, Angka2, Hasil As Double
		Angka1 = Val(TextBox2.Text)
		Angka2 = Val(TextBox3.Text)
		Hasil = Angka1 + Angka2
		TextBox1.Text = Hasil
	End Sub
	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
		Dim Angka1, Angka2, Hasil As Double
		Angka1 = Val(TextBox2.Text)
		Angka2 = Val(TextBox3.Text)


	End Sub
End Class
