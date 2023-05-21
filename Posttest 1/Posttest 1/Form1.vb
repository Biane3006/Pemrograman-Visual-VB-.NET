Public Class Form1
    Private Sub Konversi_Click(sender As Object, e As EventArgs) Handles Konversi.Click
        Dim Konversi As Double = 0
        'Percabangan untuk memeriksa inputan
        'Membaca inputan, kemudian mengubah ke KILOMETER SEMUA
        If SatuanInput.Text = "Kilometer (Km)" Then
            'Mengubah ke Km
            Konversi = TextBoxInput.Text
        ElseIf SatuanInput.Text = "Hektometer (Hm)" Then
            'Mengubah ke Km
            Konversi = TextBoxInput.Text / 10
        ElseIf SatuanInput.Text = "Dekameter (Dam)" Then
            'Mengubah ke Km
            Konversi = TextBoxInput.Text / 100
        ElseIf SatuanInput.Text = "Meter (M)" Then
            'Mengubah ke Km
            Konversi = TextBoxInput.Text / 1000
        ElseIf SatuanInput.Text = "Desimeter (Dm)" Then
            'Mengubah ke Km
            Konversi = TextBoxInput.Text / 10000
        ElseIf SatuanInput.Text = "Centimeter (Cm)" Then
            Konversi = TextBoxInput.Text / 100000
        ElseIf SatuanInput.Text = "Milimeter (Mm)" Then
            Konversi = TextBoxInput.Text / 1000000
        End If

        'Percabangan untuk memeriksa jenis satuan HASIL
        'Kemudian jika sesuai maka akan dikonversi dari KILOMETER (hasil percabangan diatas) 
        'ke Jenis Satuan HASIL yang dipakai
        If SatuanHasil.Text = "Kilometer (Km)" Then
            'Langsung memasukkan ke TextBoxHasil karena sama2 Kilometer
            TextBoxHasil.Text = Konversi
        ElseIf SatuanHasil.Text = "Hektometer (Hm)" Then
            'Mengubah dari Kilometer ke Hektometer
            Konversi = Konversi * 10
            'Memasukkan Hasil konversi ke TextBoxHasil
            TextBoxHasil.Text = Konversi
        ElseIf SatuanHasil.Text = "Dekameter (Dam)" Then
            'Mengubah dari Kilometer ke Dekameter
            Konversi = Konversi * 100
            'Memasukkan Hasil konversi ke TextBoxHasil
            TextBoxHasil.Text = Konversi
        ElseIf SatuanHasil.Text = "Meter (M)" Then
            'Mengubah dari Kilometer ke Meter
            Konversi = Konversi * 1000
            'Memasukkan Hasil konversi ke TextBoxHasil
            TextBoxHasil.Text = Konversi
        ElseIf SatuanHasil.Text = "Desimeter (Dm)" Then
            'Mengubah dari Kilometer ke Desimeter
            Konversi = Konversi * 10000
            'Memasukkan Hasil konversi ke TextBoxHasil
            TextBoxHasil.Text = Konversi
        ElseIf SatuanHasil.Text = "Centimeter (Cm)" Then
            'Mengubah dari Kilometer ke Centimeter
            Konversi = Konversi * 100000
            'Memasukkan Hasil konversi ke TextBoxHasil
            TextBoxHasil.Text = Konversi
        ElseIf SatuanHasil.Text = "Milimeter (Mm)" Then
            'Mengubah dari Kilometer ke Milimeter
            Konversi = Konversi * 1000000
            'Memasukkan Hasil konversi ke TextBoxHasil
            TextBoxHasil.Text = Konversi
        End If
    End Sub
End Class
