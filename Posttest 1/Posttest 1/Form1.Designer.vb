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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Konversi = New System.Windows.Forms.Button()
        Me.SatuanInput = New System.Windows.Forms.ComboBox()
        Me.LblSatuanInput = New System.Windows.Forms.Label()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SatuanHasil = New System.Windows.Forms.ComboBox()
        Me.TextBoxHasil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 69)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Konversi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SatuanInput)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblSatuanInput)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxInput)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SatuanHasil)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxHasil)
        Me.SplitContainer1.Size = New System.Drawing.Size(620, 168)
        Me.SplitContainer1.SplitterDistance = 305
        Me.SplitContainer1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Masukkan Angka  :"
        '
        'Konversi
        '
        Me.Konversi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Konversi.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Konversi.Location = New System.Drawing.Point(186, 127)
        Me.Konversi.Name = "Konversi"
        Me.Konversi.Size = New System.Drawing.Size(94, 28)
        Me.Konversi.TabIndex = 19
        Me.Konversi.Text = "Konversi"
        Me.Konversi.UseVisualStyleBackColor = True
        '
        'SatuanInput
        '
        Me.SatuanInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SatuanInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SatuanInput.FormattingEnabled = True
        Me.SatuanInput.Items.AddRange(New Object() {"Kilometer (Km)", "Hektometer (Hm)", "Dekameter (Dam)", "Meter (M)", "Desimeter (Dm)", "Centimeter (Cm)", "Milimeter (Mm)"})
        Me.SatuanInput.Location = New System.Drawing.Point(186, 81)
        Me.SatuanInput.Name = "SatuanInput"
        Me.SatuanInput.Size = New System.Drawing.Size(100, 21)
        Me.SatuanInput.TabIndex = 8
        '
        'LblSatuanInput
        '
        Me.LblSatuanInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSatuanInput.AutoSize = True
        Me.LblSatuanInput.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSatuanInput.Location = New System.Drawing.Point(11, 80)
        Me.LblSatuanInput.Name = "LblSatuanInput"
        Me.LblSatuanInput.Size = New System.Drawing.Size(153, 22)
        Me.LblSatuanInput.TabIndex = 10
        Me.LblSatuanInput.Text = "Pilih Satuan          :"
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInput.Location = New System.Drawing.Point(186, 28)
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxInput.TabIndex = 9
        Me.TextBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Pilih Satuan       :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hasil Konversi   :"
        '
        'SatuanHasil
        '
        Me.SatuanHasil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SatuanHasil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SatuanHasil.FormattingEnabled = True
        Me.SatuanHasil.Items.AddRange(New Object() {"Kilometer (Km)", "Hektometer (Hm)", "Dekameter (Dam)", "Meter (M)", "Desimeter (Dm)", "Centimeter (Cm)", "Milimeter (Mm)"})
        Me.SatuanHasil.Location = New System.Drawing.Point(181, 82)
        Me.SatuanHasil.Name = "SatuanHasil"
        Me.SatuanHasil.Size = New System.Drawing.Size(100, 21)
        Me.SatuanHasil.TabIndex = 10
        '
        'TextBoxHasil
        '
        Me.TextBoxHasil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxHasil.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxHasil.Location = New System.Drawing.Point(181, 31)
        Me.TextBoxHasil.Name = "TextBoxHasil"
        Me.TextBoxHasil.ReadOnly = True
        Me.TextBoxHasil.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHasil.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 27)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Konversi Satuan Panjang"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(671, 263)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Konversi Panjang"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents SatuanInput As ComboBox
    Friend WithEvents LblSatuanInput As Label
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SatuanHasil As ComboBox
    Friend WithEvents TextBoxHasil As TextBox
    Friend WithEvents Konversi As Button
    Friend WithEvents Label4 As Label
End Class
