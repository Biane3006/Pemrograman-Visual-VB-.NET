<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMakanan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMinuman = New System.Windows.Forms.DataGridView()
        Me.noMinuman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaMinuman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargaMinuman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambarMinuman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambahMakanan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTambahMinuman = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fotoMakanan = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNamaPemesan = New System.Windows.Forms.TextBox()
        Me.cbMejaPemesan = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fotoMinuman = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNoPesanan = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.tbTotalPesanan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvPesanan = New System.Windows.Forms.DataGridView()
        Me.noPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargaSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBatal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.noMakanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaMakanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargaMakanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambarMakanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvMakanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMinuman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fotoMakanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fotoMinuman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMakanan
        '
        Me.dgvMakanan.AllowUserToAddRows = False
        Me.dgvMakanan.AllowUserToResizeColumns = False
        Me.dgvMakanan.AllowUserToResizeRows = False
        Me.dgvMakanan.Anchor = System.Windows.Forms.AnchorStyles.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMakanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMakanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noMakanan, Me.namaMakanan, Me.hargaMakanan, Me.gambarMakanan})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMakanan.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMakanan.Location = New System.Drawing.Point(25, 56)
        Me.dgvMakanan.MultiSelect = False
        Me.dgvMakanan.Name = "dgvMakanan"
        Me.dgvMakanan.RowHeadersVisible = False
        Me.dgvMakanan.Size = New System.Drawing.Size(343, 265)
        Me.dgvMakanan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Restoran Samarinda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvMinuman
        '
        Me.dgvMinuman.AllowUserToAddRows = False
        Me.dgvMinuman.AllowUserToResizeColumns = False
        Me.dgvMinuman.AllowUserToResizeRows = False
        Me.dgvMinuman.Anchor = System.Windows.Forms.AnchorStyles.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMinuman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMinuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMinuman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noMinuman, Me.namaMinuman, Me.hargaMinuman, Me.gambarMinuman})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMinuman.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMinuman.Location = New System.Drawing.Point(25, 56)
        Me.dgvMinuman.Name = "dgvMinuman"
        Me.dgvMinuman.RowHeadersVisible = False
        Me.dgvMinuman.Size = New System.Drawing.Size(343, 265)
        Me.dgvMinuman.TabIndex = 2
        '
        'noMinuman
        '
        Me.noMinuman.HeaderText = "No"
        Me.noMinuman.Name = "noMinuman"
        Me.noMinuman.ReadOnly = True
        Me.noMinuman.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.noMinuman.Width = 40
        '
        'namaMinuman
        '
        Me.namaMinuman.HeaderText = "Minuman"
        Me.namaMinuman.Name = "namaMinuman"
        Me.namaMinuman.ReadOnly = True
        Me.namaMinuman.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.namaMinuman.Width = 200
        '
        'hargaMinuman
        '
        Me.hargaMinuman.HeaderText = "Harga"
        Me.hargaMinuman.Name = "hargaMinuman"
        Me.hargaMinuman.ReadOnly = True
        Me.hargaMinuman.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'gambarMinuman
        '
        Me.gambarMinuman.HeaderText = "Lokasi Gambar"
        Me.gambarMinuman.Name = "gambarMinuman"
        Me.gambarMinuman.ReadOnly = True
        Me.gambarMinuman.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gambarMinuman.Visible = False
        '
        'btnTambahMakanan
        '
        Me.btnTambahMakanan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTambahMakanan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahMakanan.Location = New System.Drawing.Point(455, 283)
        Me.btnTambahMakanan.Name = "btnTambahMakanan"
        Me.btnTambahMakanan.Size = New System.Drawing.Size(133, 29)
        Me.btnTambahMakanan.TabIndex = 3
        Me.btnTambahMakanan.Text = "Tambah Makanan"
        Me.btnTambahMakanan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Menu Makanan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Menu Minuman"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTambahMinuman
        '
        Me.btnTambahMinuman.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTambahMinuman.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahMinuman.Location = New System.Drawing.Point(455, 283)
        Me.btnTambahMinuman.Name = "btnTambahMinuman"
        Me.btnTambahMinuman.Size = New System.Drawing.Size(133, 29)
        Me.btnTambahMinuman.TabIndex = 6
        Me.btnTambahMinuman.Text = "Tambah Minuman"
        Me.btnTambahMinuman.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.fotoMakanan)
        Me.GroupBox1.Controls.Add(Me.dgvMakanan)
        Me.GroupBox1.Controls.Add(Me.btnTambahMakanan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 337)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'fotoMakanan
        '
        Me.fotoMakanan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fotoMakanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fotoMakanan.Location = New System.Drawing.Point(393, 56)
        Me.fotoMakanan.Name = "fotoMakanan"
        Me.fotoMakanan.Size = New System.Drawing.Size(250, 200)
        Me.fotoMakanan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoMakanan.TabIndex = 5
        Me.fotoMakanan.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(209, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nama   :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(209, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Meja     :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbNamaPemesan
        '
        Me.tbNamaPemesan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbNamaPemesan.BackColor = System.Drawing.Color.SandyBrown
        Me.tbNamaPemesan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaPemesan.Location = New System.Drawing.Point(282, 57)
        Me.tbNamaPemesan.Name = "tbNamaPemesan"
        Me.tbNamaPemesan.Size = New System.Drawing.Size(207, 22)
        Me.tbNamaPemesan.TabIndex = 10
        '
        'cbMejaPemesan
        '
        Me.cbMejaPemesan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbMejaPemesan.BackColor = System.Drawing.Color.SandyBrown
        Me.cbMejaPemesan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMejaPemesan.FormattingEnabled = True
        Me.cbMejaPemesan.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10"})
        Me.cbMejaPemesan.Location = New System.Drawing.Point(282, 85)
        Me.cbMejaPemesan.Name = "cbMejaPemesan"
        Me.cbMejaPemesan.Size = New System.Drawing.Size(95, 21)
        Me.cbMejaPemesan.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.fotoMinuman)
        Me.GroupBox2.Controls.Add(Me.btnTambahMinuman)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dgvMinuman)
        Me.GroupBox2.Location = New System.Drawing.Point(674, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 337)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'fotoMinuman
        '
        Me.fotoMinuman.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fotoMinuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fotoMinuman.Location = New System.Drawing.Point(393, 56)
        Me.fotoMinuman.Name = "fotoMinuman"
        Me.fotoMinuman.Size = New System.Drawing.Size(250, 200)
        Me.fotoMinuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoMinuman.TabIndex = 6
        Me.fotoMinuman.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1005, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "No Pesanan   :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbNoPesanan
        '
        Me.tbNoPesanan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbNoPesanan.BackColor = System.Drawing.Color.SandyBrown
        Me.tbNoPesanan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoPesanan.Location = New System.Drawing.Point(1129, 53)
        Me.tbNoPesanan.Name = "tbNoPesanan"
        Me.tbNoPesanan.ReadOnly = True
        Me.tbNoPesanan.Size = New System.Drawing.Size(207, 25)
        Me.tbNoPesanan.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Controls.Add(Me.tbTotalPesanan)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.dgvPesanan)
        Me.GroupBox3.Location = New System.Drawing.Point(255, 476)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(828, 242)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(695, 166)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(127, 29)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "Simpan Pesanan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'tbTotalPesanan
        '
        Me.tbTotalPesanan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbTotalPesanan.BackColor = System.Drawing.Color.SandyBrown
        Me.tbTotalPesanan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalPesanan.Location = New System.Drawing.Point(695, 117)
        Me.tbTotalPesanan.Name = "tbTotalPesanan"
        Me.tbTotalPesanan.ReadOnly = True
        Me.tbTotalPesanan.Size = New System.Drawing.Size(127, 25)
        Me.tbTotalPesanan.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(576, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total Pesanan :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPesanan
        '
        Me.dgvPesanan.AllowUserToAddRows = False
        Me.dgvPesanan.AllowUserToResizeColumns = False
        Me.dgvPesanan.AllowUserToResizeRows = False
        Me.dgvPesanan.Anchor = System.Windows.Forms.AnchorStyles.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPesanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noPesanan, Me.namaPesanan, Me.jumlahPesanan, Me.hargaSatuan, Me.totalPesanan, Me.btnBatal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPesanan.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPesanan.Location = New System.Drawing.Point(34, 19)
        Me.dgvPesanan.Name = "dgvPesanan"
        Me.dgvPesanan.RowHeadersVisible = False
        Me.dgvPesanan.Size = New System.Drawing.Size(542, 217)
        Me.dgvPesanan.TabIndex = 0
        '
        'noPesanan
        '
        Me.noPesanan.Frozen = True
        Me.noPesanan.HeaderText = "No"
        Me.noPesanan.Name = "noPesanan"
        Me.noPesanan.ReadOnly = True
        Me.noPesanan.Width = 40
        '
        'namaPesanan
        '
        Me.namaPesanan.Frozen = True
        Me.namaPesanan.HeaderText = "Pesanan"
        Me.namaPesanan.Name = "namaPesanan"
        Me.namaPesanan.ReadOnly = True
        Me.namaPesanan.Width = 200
        '
        'jumlahPesanan
        '
        Me.jumlahPesanan.Frozen = True
        Me.jumlahPesanan.HeaderText = "Jumlah"
        Me.jumlahPesanan.Name = "jumlahPesanan"
        Me.jumlahPesanan.Width = 50
        '
        'hargaSatuan
        '
        Me.hargaSatuan.Frozen = True
        Me.hargaSatuan.HeaderText = "Harga Satuan"
        Me.hargaSatuan.Name = "hargaSatuan"
        Me.hargaSatuan.ReadOnly = True
        '
        'totalPesanan
        '
        Me.totalPesanan.Frozen = True
        Me.totalPesanan.HeaderText = "Total"
        Me.totalPesanan.Name = "totalPesanan"
        Me.totalPesanan.ReadOnly = True
        '
        'btnBatal
        '
        Me.btnBatal.Frozen = True
        Me.btnBatal.HeaderText = "Batal"
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.ReadOnly = True
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseColumnTextForButtonValue = True
        Me.btnBatal.Width = 50
        '
        'noMakanan
        '
        Me.noMakanan.HeaderText = "No"
        Me.noMakanan.Name = "noMakanan"
        Me.noMakanan.ReadOnly = True
        Me.noMakanan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.noMakanan.Width = 40
        '
        'namaMakanan
        '
        Me.namaMakanan.HeaderText = "Makanan"
        Me.namaMakanan.Name = "namaMakanan"
        Me.namaMakanan.ReadOnly = True
        Me.namaMakanan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.namaMakanan.Width = 200
        '
        'hargaMakanan
        '
        Me.hargaMakanan.HeaderText = "Harga"
        Me.hargaMakanan.Name = "hargaMakanan"
        Me.hargaMakanan.ReadOnly = True
        Me.hargaMakanan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'gambarMakanan
        '
        Me.gambarMakanan.HeaderText = "Lokasi Gambar"
        Me.gambarMakanan.Name = "gambarMakanan"
        Me.gambarMakanan.ReadOnly = True
        Me.gambarMakanan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gambarMakanan.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tbNoPesanan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbMejaPemesan)
        Me.Controls.Add(Me.tbNamaPemesan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Restoran Samarinda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvMakanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMinuman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fotoMakanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fotoMinuman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMakanan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvMinuman As DataGridView
    Friend WithEvents btnTambahMakanan As Button
    Friend WithEvents noMinuman As DataGridViewTextBoxColumn
    Friend WithEvents namaMinuman As DataGridViewTextBoxColumn
    Friend WithEvents hargaMinuman As DataGridViewTextBoxColumn
    Friend WithEvents gambarMinuman As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambahMinuman As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fotoMakanan As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNamaPemesan As TextBox
    Friend WithEvents cbMejaPemesan As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents fotoMinuman As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNoPesanan As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents tbTotalPesanan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents noPesanan As DataGridViewTextBoxColumn
    Friend WithEvents namaPesanan As DataGridViewTextBoxColumn
    Friend WithEvents jumlahPesanan As DataGridViewTextBoxColumn
    Friend WithEvents hargaSatuan As DataGridViewTextBoxColumn
    Friend WithEvents totalPesanan As DataGridViewTextBoxColumn
    Friend WithEvents btnBatal As DataGridViewButtonColumn
    Friend WithEvents btnSimpan As Button
    Friend WithEvents noMakanan As DataGridViewTextBoxColumn
    Friend WithEvents namaMakanan As DataGridViewTextBoxColumn
    Friend WithEvents hargaMakanan As DataGridViewTextBoxColumn
    Friend WithEvents gambarMakanan As DataGridViewTextBoxColumn
End Class
