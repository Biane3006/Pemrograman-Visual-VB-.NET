Public Class DetailPemesanan
    Private Sub DetailPemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Form2.cbJudul.Text
        Label4.Text = Form2.tbStudio.Text
        Label6.Text = Form2.cbHari.Text
        Label8.Text = Form2.tbJumlah.Text

        If Form2.rb1.Checked = True Then
            Label10.Text = Form2.rb1.Text
        ElseIf Form2.rb2.Checked = True Then
            Label10.Text = Form2.rb1.Text
        ElseIf Form2.rb3.Checked = True Then
            Label10.Text = Form2.rb1.Text
        End If
        Dim harga As Double = 0
        If Form2.cbHari.Text = "Senin" Or Form2.cbHari.Text = "Selasa" Or Form2.cbHari.Text = "Rabu" Or Form2.cbHari.Text = "Kamis" Then
            harga = 35000 * Val(Form2.tbJumlah.Text)
        ElseIf Form2.cbHari.Text = "Jumat" Then
            harga = 45000 * Val(Form2.tbJumlah.Text)
        ElseIf Form2.cbHari.Text = "Sabtu" Or Form2.cbHari.Text = "Minggu" Then
            harga = 55000 * Val(Form2.tbJumlah.Text)
        End If
        Label14.Text = harga

        Dim isi As New List(Of String)
        For Each cbx As CheckBox In Form2.GroupBox2.Controls.OfType(Of CheckBox)
            If cbx.Checked Then
                isi.Add(cbx.Text)
            End If
        Next
        Dim kursi As String = String.Join(",", isi)
        Label12.Text = kursi
    End Sub
End Class