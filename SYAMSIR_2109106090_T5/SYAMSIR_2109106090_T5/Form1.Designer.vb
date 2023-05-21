<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbrBackground = New System.Windows.Forms.PictureBox()
        Me.gbrBarcode = New System.Windows.Forms.PictureBox()
        Me.gbrHealthy = New System.Windows.Forms.PictureBox()
        Me.gbrGaruda = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbProvinsiAlamat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbKotaAlamat = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbKecamatan = New System.Windows.Forms.ComboBox()
        Me.cbKelurahan = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.labelWaktu = New System.Windows.Forms.Label()
        Me.cbFaskes = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.tbNamaJalan = New SYAMSIR_2109106090_T5.Watermark()
        Me.tbNamaLengkap = New SYAMSIR_2109106090_T5.Watermark()
        Me.tbNIK = New SYAMSIR_2109106090_T5.Watermark()
        Me.Panel1.SuspendLayout()
        CType(Me.gbrBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrHealthy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrGaruda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Black
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(329, 106)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(121, 42)
        Me.btnCetak.TabIndex = 0
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(598, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(202, 48)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.Black
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.White
        Me.btnNo.Location = New System.Drawing.Point(710, 0)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(90, 48)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        Me.btnNo.Visible = False
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.Black
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.White
        Me.btnYes.Location = New System.Drawing.Point(598, 0)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(90, 48)
        Me.btnYes.TabIndex = 3
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        Me.btnYes.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel1.Controls.Add(Me.gbrBackground)
        Me.Panel1.Controls.Add(Me.gbrBarcode)
        Me.Panel1.Controls.Add(Me.gbrHealthy)
        Me.Panel1.Controls.Add(Me.gbrGaruda)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 62)
        Me.Panel1.TabIndex = 4
        '
        'gbrBackground
        '
        Me.gbrBackground.Enabled = False
        Me.gbrBackground.Image = CType(resources.GetObject("gbrBackground.Image"), System.Drawing.Image)
        Me.gbrBackground.Location = New System.Drawing.Point(185, 16)
        Me.gbrBackground.Name = "gbrBackground"
        Me.gbrBackground.Size = New System.Drawing.Size(36, 40)
        Me.gbrBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrBackground.TabIndex = 18
        Me.gbrBackground.TabStop = False
        Me.gbrBackground.Visible = False
        '
        'gbrBarcode
        '
        Me.gbrBarcode.Enabled = False
        Me.gbrBarcode.Image = CType(resources.GetObject("gbrBarcode.Image"), System.Drawing.Image)
        Me.gbrBarcode.Location = New System.Drawing.Point(143, 14)
        Me.gbrBarcode.Name = "gbrBarcode"
        Me.gbrBarcode.Size = New System.Drawing.Size(36, 40)
        Me.gbrBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrBarcode.TabIndex = 17
        Me.gbrBarcode.TabStop = False
        Me.gbrBarcode.Visible = False
        '
        'gbrHealthy
        '
        Me.gbrHealthy.Enabled = False
        Me.gbrHealthy.Image = CType(resources.GetObject("gbrHealthy.Image"), System.Drawing.Image)
        Me.gbrHealthy.Location = New System.Drawing.Point(101, 14)
        Me.gbrHealthy.Name = "gbrHealthy"
        Me.gbrHealthy.Size = New System.Drawing.Size(36, 40)
        Me.gbrHealthy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrHealthy.TabIndex = 16
        Me.gbrHealthy.TabStop = False
        Me.gbrHealthy.Visible = False
        '
        'gbrGaruda
        '
        Me.gbrGaruda.Enabled = False
        Me.gbrGaruda.Image = CType(resources.GetObject("gbrGaruda.Image"), System.Drawing.Image)
        Me.gbrGaruda.Location = New System.Drawing.Point(58, 14)
        Me.gbrGaruda.Name = "gbrGaruda"
        Me.gbrGaruda.Size = New System.Drawing.Size(36, 40)
        Me.gbrGaruda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gbrGaruda.TabIndex = 15
        Me.gbrGaruda.TabStop = False
        Me.gbrGaruda.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(199, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(539, 40)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "FORMULIR PENCETAKAN KARTU BPJS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnNo)
        Me.Panel2.Controls.Add(Me.btnYes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 676)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 48)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nomor Induk Kependudukan"
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.CalendarFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(444, 76)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggalLahir.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 37)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 45)
        Me.Panel3.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(329, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 40)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "IDENTITAS PESERTA BPJS"
        '
        'cbProvinsiAlamat
        '
        Me.cbProvinsiAlamat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProvinsiAlamat.FormattingEnabled = True
        Me.cbProvinsiAlamat.Items.AddRange(New Object() {"Kalimantan Timur"})
        Me.cbProvinsiAlamat.Location = New System.Drawing.Point(444, 17)
        Me.cbProvinsiAlamat.Name = "cbProvinsiAlamat"
        Me.cbProvinsiAlamat.Size = New System.Drawing.Size(200, 29)
        Me.cbProvinsiAlamat.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 37)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Provinsi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 37)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Kota / Kabupaten"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(27, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 37)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Kecamatan"
        '
        'cbKotaAlamat
        '
        Me.cbKotaAlamat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKotaAlamat.FormattingEnabled = True
        Me.cbKotaAlamat.Location = New System.Drawing.Point(444, 47)
        Me.cbKotaAlamat.Name = "cbKotaAlamat"
        Me.cbKotaAlamat.Size = New System.Drawing.Size(200, 29)
        Me.cbKotaAlamat.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(27, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 37)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Kelurahan / Desa"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 222)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 45)
        Me.Panel4.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(329, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(315, 40)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "ALAMAT PESERTA BPJS"
        '
        'cbKecamatan
        '
        Me.cbKecamatan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKecamatan.FormattingEnabled = True
        Me.cbKecamatan.Location = New System.Drawing.Point(444, 77)
        Me.cbKecamatan.Name = "cbKecamatan"
        Me.cbKecamatan.Size = New System.Drawing.Size(200, 29)
        Me.cbKecamatan.TabIndex = 22
        '
        'cbKelurahan
        '
        Me.cbKelurahan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKelurahan.FormattingEnabled = True
        Me.cbKelurahan.Location = New System.Drawing.Point(444, 107)
        Me.cbKelurahan.Name = "cbKelurahan"
        Me.cbKelurahan.Size = New System.Drawing.Size(200, 29)
        Me.cbKelurahan.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 465)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(800, 45)
        Me.Panel5.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(329, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(310, 40)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "FASILITAS KESEHATAN"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.tbNamaLengkap)
        Me.Panel6.Controls.Add(Me.tbNIK)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.dtpTanggalLahir)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 107)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(800, 115)
        Me.Panel6.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(404, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 37)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(404, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 37)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(404, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 37)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = ":"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(728, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(23, 37)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(404, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 37)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(404, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(23, 37)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(404, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 37)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(404, -3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 37)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = ":"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.tbNamaJalan)
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.Controls.Add(Me.Label25)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Controls.Add(Me.cbKecamatan)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.cbProvinsiAlamat)
        Me.Panel7.Controls.Add(Me.cbKelurahan)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.cbKotaAlamat)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 267)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(800, 198)
        Me.Panel7.TabIndex = 25
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(27, 136)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(101, 37)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Alamat"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(404, 146)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(23, 37)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = ":"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.cbFaskes)
        Me.Panel8.Controls.Add(Me.Label24)
        Me.Panel8.Controls.Add(Me.btnCetak)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 510)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(800, 167)
        Me.Panel8.TabIndex = 26
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.labelTime)
        Me.Panel9.Controls.Add(Me.labelWaktu)
        Me.Panel9.Location = New System.Drawing.Point(571, 70)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(229, 97)
        Me.Panel9.TabIndex = 26
        '
        'labelTime
        '
        Me.labelTime.AutoSize = True
        Me.labelTime.BackColor = System.Drawing.Color.DimGray
        Me.labelTime.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.labelTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTime.Location = New System.Drawing.Point(3, 51)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(159, 37)
        Me.labelTime.TabIndex = 20
        Me.labelTime.Text = "adsadadasd"
        '
        'labelWaktu
        '
        Me.labelWaktu.AutoSize = True
        Me.labelWaktu.BackColor = System.Drawing.Color.DimGray
        Me.labelWaktu.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.labelWaktu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelWaktu.Location = New System.Drawing.Point(3, 5)
        Me.labelWaktu.Name = "labelWaktu"
        Me.labelWaktu.Size = New System.Drawing.Size(196, 46)
        Me.labelWaktu.TabIndex = 19
        Me.labelWaktu.Text = "adsadadasd"
        '
        'cbFaskes
        '
        Me.cbFaskes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFaskes.FormattingEnabled = True
        Me.cbFaskes.Location = New System.Drawing.Point(444, 70)
        Me.cbFaskes.Name = "cbFaskes"
        Me.cbFaskes.Size = New System.Drawing.Size(200, 29)
        Me.cbFaskes.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(27, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(210, 37)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Faskes Tingkat 1"
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'tbNamaJalan
        '
        Me.tbNamaJalan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNamaJalan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaJalan.Location = New System.Drawing.Point(444, 146)
        Me.tbNamaJalan.MaxLength = 16
        Me.tbNamaJalan.Name = "tbNamaJalan"
        Me.tbNamaJalan.Size = New System.Drawing.Size(200, 29)
        Me.tbNamaJalan.TabIndex = 19
        Me.tbNamaJalan.WatermarkColor = System.Drawing.Color.Gray
        Me.tbNamaJalan.WatermarkText = "Alamat Lengkap"
        '
        'tbNamaLengkap
        '
        Me.tbNamaLengkap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNamaLengkap.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaLengkap.Location = New System.Drawing.Point(444, 41)
        Me.tbNamaLengkap.MaxLength = 16
        Me.tbNamaLengkap.Name = "tbNamaLengkap"
        Me.tbNamaLengkap.Size = New System.Drawing.Size(200, 29)
        Me.tbNamaLengkap.TabIndex = 18
        Me.tbNamaLengkap.WatermarkColor = System.Drawing.Color.Gray
        Me.tbNamaLengkap.WatermarkText = "Nama Lengkap"
        '
        'tbNIK
        '
        Me.tbNIK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNIK.Location = New System.Drawing.Point(444, 6)
        Me.tbNIK.MaxLength = 16
        Me.tbNIK.Name = "tbNIK"
        Me.tbNIK.Size = New System.Drawing.Size(200, 29)
        Me.tbNIK.TabIndex = 17
        Me.tbNIK.WatermarkColor = System.Drawing.Color.Gray
        Me.tbNIK.WatermarkText = "NIK (16 Digit)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(800, 724)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gbrBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrHealthy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrGaruda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnCetak As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cbProvinsiAlamat As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbKotaAlamat As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents cbKecamatan As ComboBox
    Friend WithEvents cbKelurahan As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cbFaskes As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents gbrGaruda As PictureBox
    Friend WithEvents gbrBackground As PictureBox
    Friend WithEvents gbrBarcode As PictureBox
    Friend WithEvents gbrHealthy As PictureBox
    Friend WithEvents tbNIK As Watermark
    Friend WithEvents tbNamaLengkap As Watermark
    Friend WithEvents tbNamaJalan As Watermark
    Friend WithEvents labelWaktu As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel9 As Panel
    Friend WithEvents labelTime As Label
End Class
