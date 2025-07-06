<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guncelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guncelle))
        Me.tbaciklama = New System.Windows.Forms.TextBox()
        Me.tbadet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kapatbtn = New System.Windows.Forms.Button()
        Me.tbsatisfiyati = New System.Windows.Forms.TextBox()
        Me.tbalisfiyati = New System.Windows.Forms.TextBox()
        Me.tburunadi = New System.Windows.Forms.TextBox()
        Me.tbbarkod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnguncelle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbaciklama
        '
        Me.tbaciklama.Location = New System.Drawing.Point(141, 334)
        Me.tbaciklama.Multiline = True
        Me.tbaciklama.Name = "tbaciklama"
        Me.tbaciklama.Size = New System.Drawing.Size(229, 60)
        Me.tbaciklama.TabIndex = 27
        '
        'tbadet
        '
        Me.tbadet.Location = New System.Drawing.Point(141, 274)
        Me.tbadet.Name = "tbadet"
        Me.tbadet.Size = New System.Drawing.Size(86, 22)
        Me.tbadet.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(54, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Açıklama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(67, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Adet"
        '
        'kapatbtn
        '
        Me.kapatbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kapatbtn.Location = New System.Drawing.Point(315, 28)
        Me.kapatbtn.Name = "kapatbtn"
        Me.kapatbtn.Size = New System.Drawing.Size(87, 54)
        Me.kapatbtn.TabIndex = 23
        Me.kapatbtn.Text = "Vazgeç"
        Me.kapatbtn.UseVisualStyleBackColor = True
        '
        'tbsatisfiyati
        '
        Me.tbsatisfiyati.Location = New System.Drawing.Point(141, 227)
        Me.tbsatisfiyati.Name = "tbsatisfiyati"
        Me.tbsatisfiyati.Size = New System.Drawing.Size(86, 22)
        Me.tbsatisfiyati.TabIndex = 22
        '
        'tbalisfiyati
        '
        Me.tbalisfiyati.Location = New System.Drawing.Point(141, 169)
        Me.tbalisfiyati.Name = "tbalisfiyati"
        Me.tbalisfiyati.Size = New System.Drawing.Size(86, 22)
        Me.tbalisfiyati.TabIndex = 21
        '
        'tburunadi
        '
        Me.tburunadi.Location = New System.Drawing.Point(141, 111)
        Me.tburunadi.Name = "tburunadi"
        Me.tburunadi.Size = New System.Drawing.Size(110, 22)
        Me.tburunadi.TabIndex = 20
        '
        'tbbarkod
        '
        Me.tbbarkod.Location = New System.Drawing.Point(141, 63)
        Me.tbbarkod.Name = "tbbarkod"
        Me.tbbarkod.Size = New System.Drawing.Size(110, 22)
        Me.tbbarkod.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(53, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Satış Fiyatı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(53, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Alış Fiyatı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(53, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ürün Adı"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(53, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Barkod No"
        '
        'btnguncelle
        '
        Me.btnguncelle.Location = New System.Drawing.Point(228, 415)
        Me.btnguncelle.Name = "btnguncelle"
        Me.btnguncelle.Size = New System.Drawing.Size(87, 47)
        Me.btnguncelle.TabIndex = 14
        Me.btnguncelle.Text = "Güncelle"
        Me.btnguncelle.UseVisualStyleBackColor = True
        '
        'Guncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SellStock2.My.Resources.Resources.indir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(463, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbaciklama)
        Me.Controls.Add(Me.tbadet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.kapatbtn)
        Me.Controls.Add(Me.tbsatisfiyati)
        Me.Controls.Add(Me.tbalisfiyati)
        Me.Controls.Add(Me.tburunadi)
        Me.Controls.Add(Me.tbbarkod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnguncelle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Guncelle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Güncelle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbaciklama As TextBox
    Friend WithEvents tbadet As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents kapatbtn As Button
    Friend WithEvents tbsatisfiyati As TextBox
    Friend WithEvents tbalisfiyati As TextBox
    Friend WithEvents tburunadi As TextBox
    Friend WithEvents tbbarkod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnguncelle As Button
End Class
