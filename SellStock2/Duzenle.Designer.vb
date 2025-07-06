<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Duzenle
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
        Me.btnguncelle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbbarkod = New System.Windows.Forms.TextBox()
        Me.tburunadi = New System.Windows.Forms.TextBox()
        Me.tbalisfiyati = New System.Windows.Forms.TextBox()
        Me.tbsatisfiyati = New System.Windows.Forms.TextBox()
        Me.kapatbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbadet = New System.Windows.Forms.TextBox()
        Me.tbaciklama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnguncelle
        '
        Me.btnguncelle.BackColor = System.Drawing.Color.Transparent
        Me.btnguncelle.Location = New System.Drawing.Point(224, 399)
        Me.btnguncelle.Name = "btnguncelle"
        Me.btnguncelle.Size = New System.Drawing.Size(87, 47)
        Me.btnguncelle.TabIndex = 0
        Me.btnguncelle.Text = "Düzenle"
        Me.btnguncelle.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(49, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barkod No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(49, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ürün Adı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(49, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Alış Fiyatı"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(49, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Satış Fiyatı"
        '
        'tbbarkod
        '
        Me.tbbarkod.Location = New System.Drawing.Point(137, 47)
        Me.tbbarkod.Name = "tbbarkod"
        Me.tbbarkod.Size = New System.Drawing.Size(110, 22)
        Me.tbbarkod.TabIndex = 5
        '
        'tburunadi
        '
        Me.tburunadi.Location = New System.Drawing.Point(137, 95)
        Me.tburunadi.Name = "tburunadi"
        Me.tburunadi.Size = New System.Drawing.Size(110, 22)
        Me.tburunadi.TabIndex = 6
        '
        'tbalisfiyati
        '
        Me.tbalisfiyati.Location = New System.Drawing.Point(137, 153)
        Me.tbalisfiyati.Name = "tbalisfiyati"
        Me.tbalisfiyati.Size = New System.Drawing.Size(86, 22)
        Me.tbalisfiyati.TabIndex = 7
        '
        'tbsatisfiyati
        '
        Me.tbsatisfiyati.Location = New System.Drawing.Point(137, 211)
        Me.tbsatisfiyati.Name = "tbsatisfiyati"
        Me.tbsatisfiyati.Size = New System.Drawing.Size(86, 22)
        Me.tbsatisfiyati.TabIndex = 8
        '
        'kapatbtn
        '
        Me.kapatbtn.BackColor = System.Drawing.Color.Transparent
        Me.kapatbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.kapatbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kapatbtn.Location = New System.Drawing.Point(311, 12)
        Me.kapatbtn.Name = "kapatbtn"
        Me.kapatbtn.Size = New System.Drawing.Size(87, 54)
        Me.kapatbtn.TabIndex = 9
        Me.kapatbtn.Text = "Vazgeç"
        Me.kapatbtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(63, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Adet"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(50, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Açıklama"
        '
        'tbadet
        '
        Me.tbadet.Location = New System.Drawing.Point(137, 258)
        Me.tbadet.Name = "tbadet"
        Me.tbadet.Size = New System.Drawing.Size(86, 22)
        Me.tbadet.TabIndex = 12
        '
        'tbaciklama
        '
        Me.tbaciklama.Location = New System.Drawing.Point(137, 318)
        Me.tbaciklama.Multiline = True
        Me.tbaciklama.Name = "tbaciklama"
        Me.tbaciklama.Size = New System.Drawing.Size(229, 60)
        Me.tbaciklama.TabIndex = 13
        '
        'Duzenle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SellStock2.My.Resources.Resources.indir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 471)
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
        Me.Name = "Duzenle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duzenle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnguncelle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbbarkod As TextBox
    Friend WithEvents tburunadi As TextBox
    Friend WithEvents tbalisfiyati As TextBox
    Friend WithEvents tbsatisfiyati As TextBox
    Friend WithEvents kapatbtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbadet As TextBox
    Friend WithEvents tbaciklama As TextBox
End Class
