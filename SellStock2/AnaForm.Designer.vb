<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.MenuStr = New System.Windows.Forms.MenuStrip()
        Me.SatisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatisIşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokHareketleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaporToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStr.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStr
        '
        Me.MenuStr.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SatisToolStripMenuItem, Me.SatisIşlemleriToolStripMenuItem, Me.StokHareketleriToolStripMenuItem, Me.RaporToolStripMenuItem})
        Me.MenuStr.Location = New System.Drawing.Point(0, 0)
        Me.MenuStr.Name = "MenuStr"
        Me.MenuStr.Size = New System.Drawing.Size(1252, 28)
        Me.MenuStr.TabIndex = 2
        Me.MenuStr.Text = "MenuStrip1"
        '
        'SatisToolStripMenuItem
        '
        Me.SatisToolStripMenuItem.Name = "SatisToolStripMenuItem"
        Me.SatisToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.SatisToolStripMenuItem.Text = "Satış"
        '
        'SatisIşlemleriToolStripMenuItem
        '
        Me.SatisIşlemleriToolStripMenuItem.Name = "SatisIşlemleriToolStripMenuItem"
        Me.SatisIşlemleriToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.SatisIşlemleriToolStripMenuItem.Text = "Satış Geçmişi"
        '
        'StokHareketleriToolStripMenuItem
        '
        Me.StokHareketleriToolStripMenuItem.Name = "StokHareketleriToolStripMenuItem"
        Me.StokHareketleriToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.StokHareketleriToolStripMenuItem.Text = "Stok "
        '
        'RaporToolStripMenuItem
        '
        Me.RaporToolStripMenuItem.Name = "RaporToolStripMenuItem"
        Me.RaporToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.RaporToolStripMenuItem.Text = "Rapor"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 709)
        Me.Controls.Add(Me.MenuStr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStr
        Me.Name = "AnaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sell Stock"
        Me.MenuStr.ResumeLayout(False)
        Me.MenuStr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStr As MenuStrip
    Friend WithEvents SatisIşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokHareketleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaporToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SatisToolStripMenuItem As ToolStripMenuItem
End Class
