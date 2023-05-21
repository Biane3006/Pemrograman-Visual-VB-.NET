Public Class Form1
    'Buat memasukkan gambar dari Browse File
    Private Sub tambahGambar(ByVal namaGambar As String)
        If namaGambar <> "" Then
            ImageList1.Images.Add(Image.FromFile(namaGambar))
            ListBox1.BeginUpdate()
            ListBox1.Items.Add(namaGambar)
            ListBox1.EndUpdate()
        End If
    End Sub

    'Menampilkan gambar pada saat list box dipilih
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = ImageList1.Images.Item(ListBox1.SelectedIndex)
    End Sub

    'Mengambil gambar dari file yang dimasukkan
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
        OpenFileDialog1.Filter = "Images|*.Jpg;*.png;*.bmp"
        OpenFileDialog1.Multiselect = True
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            If OpenFileDialog1.FileNames IsNot Nothing Then
                For i As Integer = 0 To OpenFileDialog1.FileNames.Length - 1
                    tambahGambar(OpenFileDialog1.FileNames(i))
                Next
            Else
                tambahGambar(OpenFileDialog1.FileName)
            End If
        End If
    End Sub

    'mengambil gambar dari dalam satu folder
    Private Sub btnBrowseFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Membersihkan Nama File yang ada Dalam ListBox
            ListBox1.Items.Clear()
            'Membersihkan Image dalam ListImage
            ImageList1.Images.Clear()
            'lokasi folder
            Dim lokasiFolder As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)

            'Mengambil seluruh file yang ada di folder
            Dim seluruhFile As IO.FileInfo() = lokasiFolder.GetFiles()
            'mengisi listbox dengan setiap nama file yang ada
            Dim namaFile As IO.FileInfo
            Dim indeks As Integer = 0
            For Each namaFile In seluruhFile
                If namaFile.Extension.Equals(".jpg") Or namaFile.Extension.Equals(".png") Or namaFile.Extension.Equals(".bmp") Then
                    Dim lokasiFile As String = FolderBrowserDialog1.SelectedPath.ToString + "\" + namaFile.ToString
                    ListBox1.Items.Add(namaFile)
                    ImageList1.Images.Add(Image.FromFile(lokasiFile))
                End If
            Next
        Else
            'gak ngapa ngapain
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
