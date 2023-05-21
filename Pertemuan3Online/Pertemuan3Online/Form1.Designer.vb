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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.tbNim = New System.Windows.Forms.TextBox()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbProdi = New System.Windows.Forms.ComboBox()
        Me.ChckBoxMakan = New System.Windows.Forms.CheckBox()
        Me.ChckBoxTidur = New System.Windows.Forms.CheckBox()
        Me.ChckBoxJalan = New System.Windows.Forms.CheckBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.tbListData = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nim"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Prodi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hobi"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(114, 85)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(100, 20)
        Me.tbNama.TabIndex = 7
        '
        'tbNim
        '
        Me.tbNim.Location = New System.Drawing.Point(114, 122)
        Me.tbNim.Name = "tbNim"
        Me.tbNim.Size = New System.Drawing.Size(100, 20)
        Me.tbNim.TabIndex = 8
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(6, 19)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(68, 17)
        Me.rbLaki.TabIndex = 9
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(115, 19)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbPerempuan.TabIndex = 10
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPerempuan)
        Me.GroupBox1.Controls.Add(Me.rbLaki)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 60)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 267)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'cbProdi
        '
        Me.cbProdi.FormattingEnabled = True
        Me.cbProdi.Location = New System.Drawing.Point(120, 314)
        Me.cbProdi.Name = "cbProdi"
        Me.cbProdi.Size = New System.Drawing.Size(121, 21)
        Me.cbProdi.TabIndex = 13
        '
        'ChckBoxMakan
        '
        Me.ChckBoxMakan.AutoSize = True
        Me.ChckBoxMakan.Location = New System.Drawing.Point(120, 362)
        Me.ChckBoxMakan.Name = "ChckBoxMakan"
        Me.ChckBoxMakan.Size = New System.Drawing.Size(59, 17)
        Me.ChckBoxMakan.TabIndex = 14
        Me.ChckBoxMakan.Text = "Makan"
        Me.ChckBoxMakan.UseVisualStyleBackColor = True
        '
        'ChckBoxTidur
        '
        Me.ChckBoxTidur.AutoSize = True
        Me.ChckBoxTidur.Location = New System.Drawing.Point(120, 394)
        Me.ChckBoxTidur.Name = "ChckBoxTidur"
        Me.ChckBoxTidur.Size = New System.Drawing.Size(50, 17)
        Me.ChckBoxTidur.TabIndex = 15
        Me.ChckBoxTidur.Text = "Tidur"
        Me.ChckBoxTidur.UseVisualStyleBackColor = True
        '
        'ChckBoxJalan
        '
        Me.ChckBoxJalan.AutoSize = True
        Me.ChckBoxJalan.Location = New System.Drawing.Point(120, 421)
        Me.ChckBoxJalan.Name = "ChckBoxJalan"
        Me.ChckBoxJalan.Size = New System.Drawing.Size(51, 17)
        Me.ChckBoxJalan.TabIndex = 16
        Me.ChckBoxJalan.Text = "Jalan"
        Me.ChckBoxJalan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(217, 394)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 17
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(262, 83)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'tbListData
        '
        Me.tbListData.Location = New System.Drawing.Point(343, 200)
        Me.tbListData.Multiline = True
        Me.tbListData.Name = "tbListData"
        Me.tbListData.Size = New System.Drawing.Size(445, 238)
        Me.tbListData.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox1.Location = New System.Drawing.Point(343, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 182)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbListData)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.ChckBoxJalan)
        Me.Controls.Add(Me.ChckBoxTidur)
        Me.Controls.Add(Me.ChckBoxMakan)
        Me.Controls.Add(Me.cbProdi)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbNim)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents tbNim As TextBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbProdi As ComboBox
    Friend WithEvents ChckBoxMakan As CheckBox
    Friend WithEvents ChckBoxTidur As CheckBox
    Friend WithEvents ChckBoxJalan As CheckBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents tbListData As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
