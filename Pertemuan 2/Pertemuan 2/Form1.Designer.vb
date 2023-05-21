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
        Me.BtnH = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KB = New System.Windows.Forms.TextBox()
        Me.NB = New System.Windows.Forms.TextBox()
        Me.S = New System.Windows.Forms.TextBox()
        Me.HS = New System.Windows.Forms.TextBox()
        Me.J = New System.Windows.Forms.TextBox()
        Me.TH = New System.Windows.Forms.TextBox()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.BtnE = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang  :"
        '
        'BtnH
        '
        Me.BtnH.Location = New System.Drawing.Point(3, 254)
        Me.BtnH.Name = "BtnH"
        Me.BtnH.Size = New System.Drawing.Size(75, 23)
        Me.BtnH.TabIndex = 1
        Me.BtnH.Text = "Hitung"
        Me.BtnH.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Satuan        :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga Satuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total Harga"
        '
        'KB
        '
        Me.KB.Location = New System.Drawing.Point(87, 8)
        Me.KB.Name = "KB"
        Me.KB.Size = New System.Drawing.Size(100, 20)
        Me.KB.TabIndex = 7
        '
        'NB
        '
        Me.NB.Location = New System.Drawing.Point(87, 39)
        Me.NB.Name = "NB"
        Me.NB.Size = New System.Drawing.Size(100, 20)
        Me.NB.TabIndex = 8
        '
        'S
        '
        Me.S.Location = New System.Drawing.Point(87, 72)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(100, 20)
        Me.S.TabIndex = 9
        '
        'HS
        '
        Me.HS.Location = New System.Drawing.Point(87, 100)
        Me.HS.Name = "HS"
        Me.HS.Size = New System.Drawing.Size(100, 20)
        Me.HS.TabIndex = 10
        '
        'J
        '
        Me.J.Location = New System.Drawing.Point(87, 136)
        Me.J.Name = "J"
        Me.J.Size = New System.Drawing.Size(100, 20)
        Me.J.TabIndex = 11
        '
        'TH
        '
        Me.TH.BackColor = System.Drawing.SystemColors.Window
        Me.TH.Location = New System.Drawing.Point(87, 171)
        Me.TH.Name = "TH"
        Me.TH.ReadOnly = True
        Me.TH.Size = New System.Drawing.Size(100, 20)
        Me.TH.TabIndex = 12
        '
        'BtnC
        '
        Me.BtnC.Location = New System.Drawing.Point(101, 254)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(75, 23)
        Me.BtnC.TabIndex = 13
        Me.BtnC.Text = "Clear"
        Me.BtnC.UseVisualStyleBackColor = True
        '
        'BtnE
        '
        Me.BtnE.Location = New System.Drawing.Point(199, 254)
        Me.BtnE.Name = "BtnE"
        Me.BtnE.Size = New System.Drawing.Size(75, 23)
        Me.BtnE.TabIndex = 14
        Me.BtnE.Text = "Exit"
        Me.BtnE.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(295, 45)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(493, 280)
        Me.ListView1.TabIndex = 15
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnE)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnC)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BtnH)
        Me.Panel1.Controls.Add(Me.TH)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.J)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.HS)
        Me.Panel1.Controls.Add(Me.KB)
        Me.Panel1.Controls.Add(Me.S)
        Me.Panel1.Controls.Add(Me.NB)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 280)
        Me.Panel1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnH As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents KB As TextBox
    Friend WithEvents NB As TextBox
    Friend WithEvents S As TextBox
    Friend WithEvents HS As TextBox
    Friend WithEvents J As TextBox
    Friend WithEvents TH As TextBox
    Friend WithEvents BtnC As Button
    Friend WithEvents BtnE As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel1 As Panel
End Class
