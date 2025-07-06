<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Satis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Satis))
        Me.btnonay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbtoplamtutar = New System.Windows.Forms.TextBox()
        Me.tbbarkod = New System.Windows.Forms.TextBox()
        Me.dgvEkUrunGoster = New System.Windows.Forms.DataGridView()
        Me.Cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbsecim = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvEkUrunGoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnonay
        '
        Me.btnonay.BackColor = System.Drawing.Color.Transparent
        Me.btnonay.BackgroundImage = Global.SellStock2.My.Resources.Resources.tik
        Me.btnonay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnonay.Location = New System.Drawing.Point(1013, 578)
        Me.btnonay.Margin = New System.Windows.Forms.Padding(0)
        Me.btnonay.Name = "btnonay"
        Me.btnonay.Padding = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.btnonay.Size = New System.Drawing.Size(81, 77)
        Me.btnonay.TabIndex = 15
        Me.btnonay.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 611)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Toplam Tutar"
        '
        'tbtoplamtutar
        '
        Me.tbtoplamtutar.Enabled = False
        Me.tbtoplamtutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tbtoplamtutar.Location = New System.Drawing.Point(537, 600)
        Me.tbtoplamtutar.Multiline = True
        Me.tbtoplamtutar.Name = "tbtoplamtutar"
        Me.tbtoplamtutar.Size = New System.Drawing.Size(156, 36)
        Me.tbtoplamtutar.TabIndex = 13
        '
        'tbbarkod
        '
        Me.tbbarkod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tbbarkod.Location = New System.Drawing.Point(12, 225)
        Me.tbbarkod.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.tbbarkod.MaxLength = 13
        Me.tbbarkod.Multiline = True
        Me.tbbarkod.Name = "tbbarkod"
        Me.tbbarkod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbbarkod.Size = New System.Drawing.Size(209, 38)
        Me.tbbarkod.TabIndex = 11
        Me.tbbarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvEkUrunGoster
        '
        Me.dgvEkUrunGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEkUrunGoster.ContextMenuStrip = Me.Cms
        Me.dgvEkUrunGoster.Location = New System.Drawing.Point(292, 147)
        Me.dgvEkUrunGoster.Name = "dgvEkUrunGoster"
        Me.dgvEkUrunGoster.RowHeadersWidth = 51
        Me.dgvEkUrunGoster.RowTemplate.Height = 24
        Me.dgvEkUrunGoster.Size = New System.Drawing.Size(850, 400)
        Me.dgvEkUrunGoster.TabIndex = 10
        '
        'Cms
        '
        Me.Cms.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SilToolStripMenuItem})
        Me.Cms.Name = "Cms"
        Me.Cms.Size = New System.Drawing.Size(93, 28)
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.SilToolStripMenuItem.Text = "sil"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(413, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 56)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SELL STOCK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbsecim
        '
        Me.cmbsecim.FormattingEnabled = True
        Me.cmbsecim.Items.AddRange(New Object() {"Nakit", "Kredi"})
        Me.cmbsecim.Location = New System.Drawing.Point(799, 619)
        Me.cmbsecim.Name = "cmbsecim"
        Me.cmbsecim.Size = New System.Drawing.Size(155, 24)
        Me.cmbsecim.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(794, 574)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Ödeme Türü"
        '
        'Satis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SellStock2.My.Resources.Resources.indir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 684)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbsecim)
        Me.Controls.Add(Me.btnonay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbtoplamtutar)
        Me.Controls.Add(Me.tbbarkod)
        Me.Controls.Add(Me.dgvEkUrunGoster)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Satis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvEkUrunGoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cms.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnonay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbtoplamtutar As TextBox
    Friend WithEvents tbbarkod As TextBox
    Friend WithEvents dgvEkUrunGoster As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbsecim As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cms As ContextMenuStrip
    Friend WithEvents SilToolStripMenuItem As ToolStripMenuItem
End Class
