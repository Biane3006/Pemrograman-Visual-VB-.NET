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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TambahBarang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxQty = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomorKolom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNmBrng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnUbah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnSimpan = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ComboBoxNmBrng = New System.Windows.Forms.ComboBox()
        Me.QtyAqua = New System.Windows.Forms.TextBox()
        Me.QtySabun = New System.Windows.Forms.TextBox()
        Me.QtyPastaGigi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TambahBarang
        '
        Me.TambahBarang.Location = New System.Drawing.Point(126, 150)
        Me.TambahBarang.Name = "TambahBarang"
        Me.TambahBarang.Size = New System.Drawing.Size(87, 23)
        Me.TambahBarang.TabIndex = 1
        Me.TambahBarang.Text = "Tambah"
        Me.TambahBarang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama Barang   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity           :"
        '
        'TxtBoxQty
        '
        Me.TxtBoxQty.Location = New System.Drawing.Point(126, 111)
        Me.TxtBoxQty.Name = "TxtBoxQty"
        Me.TxtBoxQty.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxQty.TabIndex = 5
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomorKolom, Me.ColumnNmBrng, Me.ColumnQty, Me.BtnUbah, Me.BtnSimpan, Me.BtnHapus})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 190)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(393, 250)
        Me.DataGridView1.TabIndex = 6
        '
        'NomorKolom
        '
        Me.NomorKolom.Frozen = True
        Me.NomorKolom.HeaderText = "No"
        Me.NomorKolom.Name = "NomorKolom"
        Me.NomorKolom.ReadOnly = True
        Me.NomorKolom.Width = 40
        '
        'ColumnNmBrng
        '
        Me.ColumnNmBrng.Frozen = True
        Me.ColumnNmBrng.HeaderText = "Nama Barang"
        Me.ColumnNmBrng.Name = "ColumnNmBrng"
        Me.ColumnNmBrng.ReadOnly = True
        Me.ColumnNmBrng.Width = 150
        '
        'ColumnQty
        '
        Me.ColumnQty.Frozen = True
        Me.ColumnQty.HeaderText = "Quantity"
        Me.ColumnQty.Name = "ColumnQty"
        Me.ColumnQty.ReadOnly = True
        Me.ColumnQty.Width = 50
        '
        'BtnUbah
        '
        Me.BtnUbah.Frozen = True
        Me.BtnUbah.HeaderText = "Ubah"
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseColumnTextForButtonValue = True
        Me.BtnUbah.Width = 50
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Frozen = True
        Me.BtnSimpan.HeaderText = "Simpan"
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BtnSimpan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseColumnTextForButtonValue = True
        Me.BtnSimpan.Width = 50
        '
        'BtnHapus
        '
        Me.BtnHapus.Frozen = True
        Me.BtnHapus.HeaderText = "Hapus"
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseColumnTextForButtonValue = True
        Me.BtnHapus.Width = 50
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(519, 67)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(509, 373)
        Me.Chart1.TabIndex = 7
        Me.Chart1.Text = "Chart1"
        '
        'ComboBoxNmBrng
        '
        Me.ComboBoxNmBrng.FormattingEnabled = True
        Me.ComboBoxNmBrng.Items.AddRange(New Object() {"Aqua", "Sabun", "Pasta Gigi"})
        Me.ComboBoxNmBrng.Location = New System.Drawing.Point(126, 68)
        Me.ComboBoxNmBrng.Name = "ComboBoxNmBrng"
        Me.ComboBoxNmBrng.Size = New System.Drawing.Size(176, 21)
        Me.ComboBoxNmBrng.TabIndex = 8
        '
        'QtyAqua
        '
        Me.QtyAqua.Location = New System.Drawing.Point(447, 68)
        Me.QtyAqua.Name = "QtyAqua"
        Me.QtyAqua.ReadOnly = True
        Me.QtyAqua.Size = New System.Drawing.Size(66, 20)
        Me.QtyAqua.TabIndex = 9
        '
        'QtySabun
        '
        Me.QtySabun.Location = New System.Drawing.Point(447, 94)
        Me.QtySabun.Name = "QtySabun"
        Me.QtySabun.ReadOnly = True
        Me.QtySabun.Size = New System.Drawing.Size(66, 20)
        Me.QtySabun.TabIndex = 10
        '
        'QtyPastaGigi
        '
        Me.QtyPastaGigi.Location = New System.Drawing.Point(447, 119)
        Me.QtyPastaGigi.Name = "QtyPastaGigi"
        Me.QtyPastaGigi.ReadOnly = True
        Me.QtyPastaGigi.Size = New System.Drawing.Size(66, 20)
        Me.QtyPastaGigi.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Jumlah Aqua :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Jumlah Sabun :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(327, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Jumlah Pasta Gigi :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 462)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.QtyPastaGigi)
        Me.Controls.Add(Me.QtySabun)
        Me.Controls.Add(Me.QtyAqua)
        Me.Controls.Add(Me.ComboBoxNmBrng)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtBoxQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TambahBarang)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TambahBarang As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxQty As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NomorKolom As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNmBrng As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQty As DataGridViewTextBoxColumn
    Friend WithEvents BtnUbah As DataGridViewButtonColumn
    Friend WithEvents BtnSimpan As DataGridViewButtonColumn
    Friend WithEvents BtnHapus As DataGridViewButtonColumn
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ComboBoxNmBrng As ComboBox
    Friend WithEvents QtyAqua As TextBox
    Friend WithEvents QtySabun As TextBox
    Friend WithEvents QtyPastaGigi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
