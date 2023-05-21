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
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.tbGajiPokok = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cbBulan = New System.Windows.Forms.ComboBox()
        Me.tbHariKerja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbSakit = New System.Windows.Forms.TextBox()
        Me.tbTanpaKeterangan = New System.Windows.Forms.TextBox()
        Me.tbIzin = New System.Windows.Forms.TextBox()
        Me.tbTunjangan = New System.Windows.Forms.TextBox()
        Me.tbGajiBersih = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(319, 352)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(121, 23)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(192, 387)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(121, 23)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'tbGajiPokok
        '
        Me.tbGajiPokok.Location = New System.Drawing.Point(192, 33)
        Me.tbGajiPokok.Name = "tbGajiPokok"
        Me.tbGajiPokok.Size = New System.Drawing.Size(121, 20)
        Me.tbGajiPokok.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(446, 32)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(378, 378)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'cbBulan
        '
        Me.cbBulan.FormattingEnabled = True
        Me.cbBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cbBulan.Location = New System.Drawing.Point(192, 68)
        Me.cbBulan.Name = "cbBulan"
        Me.cbBulan.Size = New System.Drawing.Size(121, 21)
        Me.cbBulan.TabIndex = 5
        '
        'tbHariKerja
        '
        Me.tbHariKerja.BackColor = System.Drawing.SystemColors.Window
        Me.tbHariKerja.Location = New System.Drawing.Point(192, 106)
        Me.tbHariKerja.Name = "tbHariKerja"
        Me.tbHariKerja.ReadOnly = True
        Me.tbHariKerja.Size = New System.Drawing.Size(121, 20)
        Me.tbHariKerja.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Gaji Pokok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Bulan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hari Kerja"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sakit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tanpa Keterangan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Izin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tunjangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Gaji Bersih"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tbSakit
        '
        Me.tbSakit.Location = New System.Drawing.Point(192, 143)
        Me.tbSakit.Name = "tbSakit"
        Me.tbSakit.Size = New System.Drawing.Size(121, 20)
        Me.tbSakit.TabIndex = 16
        '
        'tbTanpaKeterangan
        '
        Me.tbTanpaKeterangan.Location = New System.Drawing.Point(192, 183)
        Me.tbTanpaKeterangan.Name = "tbTanpaKeterangan"
        Me.tbTanpaKeterangan.Size = New System.Drawing.Size(121, 20)
        Me.tbTanpaKeterangan.TabIndex = 17
        '
        'tbIzin
        '
        Me.tbIzin.Location = New System.Drawing.Point(192, 226)
        Me.tbIzin.Name = "tbIzin"
        Me.tbIzin.Size = New System.Drawing.Size(121, 20)
        Me.tbIzin.TabIndex = 18
        '
        'tbTunjangan
        '
        Me.tbTunjangan.BackColor = System.Drawing.SystemColors.Window
        Me.tbTunjangan.Location = New System.Drawing.Point(192, 269)
        Me.tbTunjangan.Name = "tbTunjangan"
        Me.tbTunjangan.ReadOnly = True
        Me.tbTunjangan.Size = New System.Drawing.Size(121, 20)
        Me.tbTunjangan.TabIndex = 19
        '
        'tbGajiBersih
        '
        Me.tbGajiBersih.BackColor = System.Drawing.SystemColors.Window
        Me.tbGajiBersih.Location = New System.Drawing.Point(192, 310)
        Me.tbGajiBersih.Name = "tbGajiBersih"
        Me.tbGajiBersih.ReadOnly = True
        Me.tbGajiBersih.Size = New System.Drawing.Size(121, 20)
        Me.tbGajiBersih.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 435)
        Me.Controls.Add(Me.tbGajiBersih)
        Me.Controls.Add(Me.tbTunjangan)
        Me.Controls.Add(Me.tbIzin)
        Me.Controls.Add(Me.tbTanpaKeterangan)
        Me.Controls.Add(Me.tbSakit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbHariKerja)
        Me.Controls.Add(Me.cbBulan)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.tbGajiPokok)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "Form1"
        Me.Text = "Kalkulasi Gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents tbGajiPokok As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents cbBulan As ComboBox
    Friend WithEvents tbHariKerja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents tbSakit As TextBox
    Friend WithEvents tbTanpaKeterangan As TextBox
    Friend WithEvents tbIzin As TextBox
    Friend WithEvents tbTunjangan As TextBox
    Friend WithEvents tbGajiBersih As TextBox
End Class
