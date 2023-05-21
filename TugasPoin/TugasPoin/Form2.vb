Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = tambah(Val(TextBox1.Text), Val(TextBox2.Text))
    End Sub
End Class