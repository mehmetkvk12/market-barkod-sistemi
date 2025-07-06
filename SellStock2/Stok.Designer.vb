<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stok
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stok))
        Me.dgvUrunleriGoster = New System.Windows.Forms.DataGridView()
        Me.cmsmen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DuzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuncelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.yeniUrunbtn = New System.Windows.Forms.Button()
        Me.tbara = New System.Windows.Forms.TextBox()
        CType(Me.dgvUrunleriGoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsmen.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUrunleriGoster
        '
        Me.dgvUrunleriGoster.AllowUserToAddRows = False
        Me.dgvUrunleriGoster.AllowUserToDeleteRows = False
        Me.dgvUrunleriGoster.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUrunleriGoster.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUrunleriGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUrunleriGoster.ContextMenuStrip = Me.cmsmen
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUrunleriGoster.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUrunleriGoster.Location = New System.Drawing.Point(77, 87)
        Me.dgvUrunleriGoster.Name = "dgvUrunleriGoster"
        Me.dgvUrunleriGoster.ReadOnly = True
        Me.dgvUrunleriGoster.RowHeadersWidth = 51
        Me.dgvUrunleriGoster.RowTemplate.Height = 24
        Me.dgvUrunleriGoster.Size = New System.Drawing.Size(1007, 473)
        Me.dgvUrunleriGoster.TabIndex = 0
        '
        'cmsmen
        '
        Me.cmsmen.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsmen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuzenleToolStripMenuItem, Me.GuncelleToolStripMenuItem})
        Me.cmsmen.Name = "ContextMenuStrip1"
        Me.cmsmen.Size = New System.Drawing.Size(136, 52)
        '
        'DuzenleToolStripMenuItem
        '
        Me.DuzenleToolStripMenuItem.Name = "DuzenleToolStripMenuItem"
        Me.DuzenleToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.DuzenleToolStripMenuItem.Text = "Düzenle"
        '
        'GuncelleToolStripMenuItem
        '
        Me.GuncelleToolStripMenuItem.Name = "GuncelleToolStripMenuItem"
        Me.GuncelleToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.GuncelleToolStripMenuItem.Text = "Güncelle"
        '
        'yeniUrunbtn
        '
        Me.yeniUrunbtn.Location = New System.Drawing.Point(938, 25)
        Me.yeniUrunbtn.Name = "yeniUrunbtn"
        Me.yeniUrunbtn.Size = New System.Drawing.Size(146, 43)
        Me.yeniUrunbtn.TabIndex = 1
        Me.yeniUrunbtn.Text = "Yeni Ürün Ekle"
        Me.yeniUrunbtn.UseVisualStyleBackColor = True
        '
        'tbara
        '
        Me.tbara.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tbara.Location = New System.Drawing.Point(257, 38)
        Me.tbara.Multiline = True
        Me.tbara.Name = "tbara"
        Me.tbara.Size = New System.Drawing.Size(198, 30)
        Me.tbara.TabIndex = 2
        '
        'Stok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SellStock2.My.Resources.Resources.indir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1181, 668)
        Me.Controls.Add(Me.tbara)
        Me.Controls.Add(Me.yeniUrunbtn)
        Me.Controls.Add(Me.dgvUrunleriGoster)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvUrunleriGoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsmen.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUrunleriGoster As DataGridView
    Friend WithEvents yeniUrunbtn As Button
    Friend WithEvents cmsmen As ContextMenuStrip
    Friend WithEvents DuzenleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbara As TextBox
    Friend WithEvents GuncelleToolStripMenuItem As ToolStripMenuItem
End Class
