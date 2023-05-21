Imports MySql.Data.MySqlClient
Public Class DataJenis
    Sub Kosong()
        txtKodeJenis.Clear()
        txtJenis.Clear()
    End Sub
    Sub Isi()
        txtJenis.Clear()
        txtJenis.Focus()
    End Sub
    Sub TampilJenis()
        DA = New MySqlDataAdapter("Select * From tbjenis", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbjenis")
        DataGridView1.DataSource = DS.Tables("tbjenis")
        DataGridView1.Refresh()
    End Sub
    Sub AturGrid()
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(0).HeaderText = "KODE JENIS"
        DataGridView1.Columns(1).HeaderText = "NAMA JENIS"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilJenis()
        Call Kosong()
        Call AturGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeJenis.Text = "" Or txtJenis.Text = "" Then
            MsgBox("Data belum lengkap")
            txtKodeJenis.Focus()
            Exit Sub
        Else

            CMD = New MySqlCommand("Select * From tbjenis where kodeJenis='" & txtKodeJenis.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tbjenis(kodeJenis,jenis)Values ('" &
                    txtKodeJenis.Text & "' , '" & txtJenis.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Simpan data sukses...|", MsgBoxStyle.Information, "Perhatian")
            End If

            Call TampilJenis()
            Call Kosong()
            txtKodeJenis.Focus()
        End If
    End Sub

    Private Sub txtJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJenis.KeyPress
        txtJenis.MaxLength = 50
        If e.KeyChar = Chr(13) Then
            txtJenis.Text = UCase(txtJenis.Text)
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtKodeJenis.Text = "" Then
            MsgBox("Kode Jenis belum diisi")
            txtKodeJenis.Focus()
        Else
            Dim Ubah As String = "Update tbjenis set kodeJenis ='" & txtKodeJenis.Text & "', jenis =
                                  '" & txtJenis.Text & "' where kodeJenis = '" & txtKodeJenis.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data sudah diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilJenis()
            Call Kosong()
            txtKodeJenis.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeJenis.Text = "" Then
            MsgBox("Kode buku belum diisi")
            txtKodeJenis.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus Data Jenis " & txtKodeJenis.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbjenis Where kodeJenis = '" & txtKodeJenis.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Kosong()
                Call TampilJenis()
            Else
                Call Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub txtKodeJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeJenis.KeyPress
        txtKodeJenis.MaxLength = 2
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbjenis where kodeJenis='" & txtKodeJenis.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtJenis.Text = RD.Item(1)
                txtJenis.Focus()
            Else
                Call Isi()
                txtJenis.Focus()
            End If
            RD.Close()
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbjenis where kodeJenis like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From tbjenis where kodeJenis like '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            txtKodeJenis.Text = .Cells(0).Value
            txtJenis.Text = .Cells(1).Value
        End With
    End Sub

End Class