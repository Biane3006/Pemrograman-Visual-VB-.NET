Public Class Form2
    Private Sub chkA1_CheckedChanged(sender As Object, e As EventArgs) Handles chkA1.CheckedChanged, chkA2.CheckedChanged, chkA3.CheckedChanged, chkA4.CheckedChanged, chkA5.CheckedChanged, chkA6.CheckedChanged, chkA7.CheckedChanged, chkA8.CheckedChanged, chkB1.CheckedChanged, chkB2.CheckedChanged, chkB3.CheckedChanged, chkB4.CheckedChanged, chkB5.CheckedChanged, chkB6.CheckedChanged, chkB7.CheckedChanged, chkB8.CheckedChanged, chkC1.CheckedChanged, chkC2.CheckedChanged, chkC3.CheckedChanged, chkC4.CheckedChanged, chkC5.CheckedChanged, chkC6.CheckedChanged, chkC7.CheckedChanged, chkC8.CheckedChanged
        Dim chkBox As CheckBox
        For Each Objek As Object In Me.GroupBox2.Controls
            If TypeOf Objek Is CheckBox Then
                chkBox = Objek
                If chkBox.Checked Then
                    chkBox.BackColor = Color.Lime
                Else
                    chkBox.BackColor = Color.Black
                End If
            End If
        Next
    End Sub



    Sub Clear()
        cbJudul.Text = ""
        tbStudio.Text = ""
        cbHari.Text = ""
        For Each rb As RadioButton In GroupBox1.Controls.OfType(Of RadioButton)
            If rb.Checked Then
                rb.Checked = False
            End If
        Next

        For Each cb As CheckBox In GroupBox2.Controls.OfType(Of CheckBox)
            If cb.Checked Then
                cb.Checked = False
            End If
        Next
        tbJumlah.Text = ""
        cbJudul.Focus()
    End Sub

    Private Function CekFormKosong()
        If cbJudul.Text = "" Then
            MessageBox.Show("Judul Tidak Boleh Kosong!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbJudul.Focus()
            Return False
        ElseIf cbHari.Text = "" Then
            MessageBox.Show("Hari wajib dipilih!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbHari.Focus()
            Return False
        ElseIf tbJumlah.Text = "" Then
            MessageBox.Show("Jumlah Tiket!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbJumlah.Focus()
            Return False
        Else
            Return True
        End If

        Dim benar As Integer = 0
        For Each rb As RadioButton In GroupBox1.Controls.OfType(Of RadioButton)
            If rb.Checked = False Then
                benar = benar + 1
            End If
            If benar = 3 Then
                MessageBox.Show("Pilihan Jam Tayang tidak Boleh Kosong!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        If CekFormKosong() = True Then
            DetailPemesanan.Show()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Clear()
    End Sub

    Private Sub cbJudul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJudul.SelectedIndexChanged
        If cbJudul.Text = "20th Century Girl" Then
            tbStudio.Text = "Studio 1"
        ElseIf cbJudul.Text = "Titanic" Then
            tbStudio.Text = "Studio 2"
        ElseIf cbJudul.Text = "The Avengers 2012" Then
            tbStudio.Text = "Studio 3"
        ElseIf cbJudul.Text = "Transformers" Then
            tbStudio.Text = "Studio 4"
        End If
    End Sub

    Private Sub tbJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbJumlah.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                MessageBox.Show("Masukkan Angka !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class