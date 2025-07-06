<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SatisIslemleri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SatisIslemleri))
        Me.SatislariListeledgv = New System.Windows.Forms.DataGridView()
        Me.menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Ayrintilar = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SatislariListeledgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SatislariListeledgv
        '
        Me.SatislariListeledgv.AllowUserToAddRows = False
        Me.SatislariListeledgv.AllowUserToDeleteRows = False
        Me.SatislariListeledgv.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SatislariListeledgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SatislariListeledgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SatislariListeledgv.ContextMenuStrip = Me.menu
        Me.SatislariListeledgv.Location = New System.Drawing.Point(28, 59)
        Me.SatislariListeledgv.Name = "SatislariListeledgv"
        Me.SatislariListeledgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SatislariListeledgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SatislariListeledgv.RowHeadersWidth = 51
        Me.SatislariListeledgv.RowTemplate.Height = 24
        Me.SatislariListeledgv.Size = New System.Drawing.Size(1062, 536)
        Me.SatislariListeledgv.TabIndex = 0
        '
        'menu
        '
        Me.menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ayrintilar})
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(139, 28)
        '
        'Ayrintilar
        '
        Me.Ayrintilar.Name = "Ayrintilar"
        Me.Ayrintilar.Size = New System.Drawing.Size(138, 24)
        Me.Ayrintilar.Text = "Ayrıntılar"
        '
        'SatisIslemleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SellStock2.My.Resources.Resources.indir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1181, 668)
        Me.Controls.Add(Me.SatislariListeledgv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SatisIslemleri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satış Geçmişi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SatislariListeledgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SatislariListeledgv As DataGridView
    Friend WithEvents menu As ContextMenuStrip
    Friend WithEvents Ayrintilar As ToolStripMenuItem
End Class
