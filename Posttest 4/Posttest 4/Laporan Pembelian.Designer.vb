﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laporan_Pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan_Pembelian))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbCariLaporanPembelian = New MetroFramework.Controls.MetroTextBox()
        Me.btnPrint = New MetroFramework.Controls.MetroButton()
        Me.dgvLaporanPembelian = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvLaporanPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tbCariLaporanPembelian)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.dgvLaporanPembelian)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 640)
        Me.Panel1.TabIndex = 0
        '
        'tbCariLaporanPembelian
        '
        Me.tbCariLaporanPembelian.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCariLaporanPembelian.Icon = CType(resources.GetObject("tbCariLaporanPembelian.Icon"), System.Drawing.Image)
        Me.tbCariLaporanPembelian.IconRight = True
        Me.tbCariLaporanPembelian.Lines = New String(-1) {}
        Me.tbCariLaporanPembelian.Location = New System.Drawing.Point(153, 234)
        Me.tbCariLaporanPembelian.MaxLength = 32767
        Me.tbCariLaporanPembelian.Name = "tbCariLaporanPembelian"
        Me.tbCariLaporanPembelian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCariLaporanPembelian.PromptText = "Cari..."
        Me.tbCariLaporanPembelian.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCariLaporanPembelian.SelectedText = ""
        Me.tbCariLaporanPembelian.Size = New System.Drawing.Size(200, 35)
        Me.tbCariLaporanPembelian.TabIndex = 19
        Me.tbCariLaporanPembelian.UseSelectable = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrint.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnPrint.Location = New System.Drawing.Point(47, 234)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 35)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Cetak"
        Me.btnPrint.UseSelectable = True
        '
        'dgvLaporanPembelian
        '
        Me.dgvLaporanPembelian.AllowUserToAddRows = False
        Me.dgvLaporanPembelian.AllowUserToDeleteRows = False
        Me.dgvLaporanPembelian.AllowUserToResizeColumns = False
        Me.dgvLaporanPembelian.AllowUserToResizeRows = False
        Me.dgvLaporanPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLaporanPembelian.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLaporanPembelian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLaporanPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLaporanPembelian.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLaporanPembelian.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLaporanPembelian.Location = New System.Drawing.Point(47, 275)
        Me.dgvLaporanPembelian.MultiSelect = False
        Me.dgvLaporanPembelian.Name = "dgvLaporanPembelian"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLaporanPembelian.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLaporanPembelian.RowHeadersVisible = False
        Me.dgvLaporanPembelian.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLaporanPembelian.Size = New System.Drawing.Size(943, 306)
        Me.dgvLaporanPembelian.TabIndex = 0
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
        'PrintDocument1
        '
        '
        'Laporan_Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Laporan_Pembelian"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvLaporanPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvLaporanPembelian As DataGridView
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroButton
    Friend WithEvents tbCariLaporanPembelian As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
