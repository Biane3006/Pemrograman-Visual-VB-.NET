<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.txtKodeBuku = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbKodeJenis = New System.Windows.Forms.ComboBox()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeskrip = New System.Windows.Forms.TextBox()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(451, 348)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(94, 44)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(580, 348)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(89, 44)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(328, 348)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(92, 44)
        Me.btnUbah.TabIndex = 10
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(187, 348)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(115, 44)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(221, 102)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(655, 22)
        Me.txtJudul.TabIndex = 16
        '
        'txtKodeBuku
        '
        Me.txtKodeBuku.Location = New System.Drawing.Point(221, 49)
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.Size = New System.Drawing.Size(106, 22)
        Me.txtKodeBuku.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Judul"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Kode Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Jenis"
        '
        'cbKodeJenis
        '
        Me.cbKodeJenis.FormattingEnabled = True
        Me.cbKodeJenis.Location = New System.Drawing.Point(460, 50)
        Me.cbKodeJenis.Name = "cbKodeJenis"
        Me.cbKodeJenis.Size = New System.Drawing.Size(175, 24)
        Me.cbKodeJenis.TabIndex = 18
        '
        'txtJenis
        '
        Me.txtJenis.Location = New System.Drawing.Point(656, 50)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.ReadOnly = True
        Me.txtJenis.Size = New System.Drawing.Size(220, 22)
        Me.txtJenis.TabIndex = 19
        '
        'txtPengarang
        '
        Me.txtPengarang.Location = New System.Drawing.Point(221, 157)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.Size = New System.Drawing.Size(355, 22)
        Me.txtPengarang.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Pengarang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(617, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Deskripsi"
        '
        'txtDeskrip
        '
        Me.txtDeskrip.Location = New System.Drawing.Point(622, 181)
        Me.txtDeskrip.Multiline = True
        Me.txtDeskrip.Name = "txtDeskrip"
        Me.txtDeskrip.Size = New System.Drawing.Size(254, 131)
        Me.txtDeskrip.TabIndex = 23
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(221, 217)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(355, 22)
        Me.txtPenerbit.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Penerbit"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(221, 273)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(106, 22)
        Me.txtJumlah.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(75, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Jumlah Buku"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(470, 273)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(106, 22)
        Me.txtHarga.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(399, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 25)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Harga"
        '
        'btnTutup
        '
        Me.btnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutup.Location = New System.Drawing.Point(715, 348)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(89, 44)
        Me.btnTutup.TabIndex = 30
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 471)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(796, 318)
        Me.DataGridView1.TabIndex = 31
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(150, 425)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(654, 22)
        Me.txtCari.TabIndex = 32
        '
        'DataBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 823)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPenerbit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDeskrip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPengarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJenis)
        Me.Controls.Add(Me.cbKodeJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.txtKodeBuku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Name = "DataBuku"
        Me.Text = "DataBuku"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbKodeJenis As ComboBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDeskrip As TextBox
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnTutup As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCari As TextBox
End Class
