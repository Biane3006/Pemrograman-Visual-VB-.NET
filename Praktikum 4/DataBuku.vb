Imports MySql.Data.MySqlClient
Public Class DataBuku

    Sub Kosong()
        txtKodeBuku.Clear()
        cbKodeJenis.Text = ""
        txtJudul.Clear()
        txtPengarang.Clear()
        txtPenerbit.Clear()
        txtJumlah.Clear()
        txtHarga.Clear()
        txtJenis.Clear()
        txtDeskrip.Clear()
        txtKodeBuku.Focus()
    End Sub

    Sub isi()
        cbKodeJenis.Text = ""
        txtJudul.Clear()
        txtPengarang.Clear()
        txtPenerbit.Clear()
        txtJumlah.Clear()
        txtHarga.Clear()
        txtJenis.Clear()
        txtDeskrip.Clear()
        cbKodeJenis.Focus()
    End Sub

    Sub TampilBuku()
        DA = New MySqlDataAdapter("Select * From tbBuku", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Buku")
        DataGridView1.DataSource = DS.Tables("Buku")
        DataGridView1.Refresh()
    End Sub

    Sub TampilJenis()
        CMD = New MySqlCommand("Select kodeJenis From tbjenis", CONN)
        RD = CMD.ExecuteReader
        Do While RD.Read
            cbKodeJenis.Items.Add(RD.Item(0))
        Loop
        RD.Close()
    End Sub

    Sub AturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 30
        DataGridView1.Columns(2).Width = 300
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100

        DataGridView1.Columns(0).HeaderText = "KODE BUKU"
        DataGridView1.Columns(1).HeaderText = "NAMA JENIS"
        DataGridView1.Columns(2).HeaderText = "JUDUL"
        DataGridView1.Columns(3).HeaderText = "PENGARANG"
        DataGridView1.Columns(4).HeaderText = "PENERBIT"
        DataGridView1.Columns(5).HeaderText = "JUMLAH"
        DataGridView1.Columns(6).HeaderText = "HARGA"
        DataGridView1.Columns(7).HeaderText = "DESKRIPSI"
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeBuku.Text = "" Or cbKodeJenis.Text = "" Or txtJudul.Text = "" Or
            txtPengarang.Text = "" Or txtPenerbit.Text = "" Or txtJumlah.Text = "" Or txtHarga.Text = "" Then

            MsgBox("Data belum lengkap")
            txtKodeBuku.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From tbBuku where kodeJenis='" & txtKodeBuku.Text & "'", CONN)
            RD = CMD.ExecuteReader

            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tbBuku(kodeBuku,kodeJenis,judul,pengarang,penerbit,jumlahBuku,harga,deskripsi)values
                                        ('" & txtKodeBuku.Text & "','" & cbKodeJenis.Text & "','" & txtJudul.Text & "',
                                        '" & txtPengarang.Text & "','" & txtPenerbit.Text & "'
                                        ,'" & txtJumlah.Text & "','" & txtHarga.Text & "','" & txtDeskrip.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Simpan data sukses......|", MsgBoxStyle.Information, "Perhatian")
            End If
            RD.Close()
            Call TampilBuku()
            Call Kosong()
            txtKodeBuku.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
        Call TampilBuku()
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbBuku where kodeBuku like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From tbBuku where kodeBuku like '%" & txtCari.Text & "%'", CONN)
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

    Private Sub DataBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilJenis()
        Call TampilBuku()
        Call Kosong()
        Call AturGrid()
    End Sub

    Private Sub cbKodeJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKodeJenis.SelectedIndexChanged
        CMD = New MySqlCommand("Select * From tbjenis where kodeJenis='" & cbKodeJenis.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows = True Then
            txtJenis.Text = RD.Item(1)
        Else
            MsgBox("Kode Jenis ini Tidak Terdaftar")
        End If
        RD.Close()
    End Sub


    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Hide()
    End Sub

    'BTN UBAH NYA MASIH ERROR YGY
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtKodeBuku.Text = "" Then
            MsgBox("Kode Jenis belum diisi")
            txtKodeBuku.Focus()
        Else
            Dim Ubah As String = "Update tbbuku set kodebuku ='" & txtKodeBuku.Text & "', judul =
                                  '" & txtJudul.Text & "'" & txtKodeBuku.Text & "',
                                  '" & txtPengarang.Text & "','" & txtPenerbit.Text & "'
                                  ,'" & txtJumlah.Text & "','" & txtHarga.Text & "','" & txtDeskrip.Text &
                                  "' where kodebuku = '" & txtKodeBuku.Text & "'"

            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data sudah diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilBuku()
            Call Kosong()
            txtKodeBuku.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeBuku.Text = "" Then
            MsgBox("Kode buku belum diisi")
            txtKodeBuku.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus Data Buku " & txtKodeBuku.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbbuku Where kodeBuku = '" & txtKodeBuku.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call Kosong()
                Call TampilBuku()
            Else
                Call Kosong()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            txtKodeBuku.Text = .Cells(0).Value
            cbKodeJenis.Text = .Cells(1).Value
            txtJudul.Text = .Cells(2).Value
            txtPengarang.Text = .Cells(3).Value
            txtPenerbit.Text = .Cells(4).Value
            txtJumlah.Text = .Cells(5).Value
            txtHarga.Text = .Cells(6).Value
            txtDeskrip.Text = .Cells(7).Value
        End With
    End Sub

End Class