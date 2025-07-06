<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sIslemAyrinti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sIslemAyrinti))
        Me.dgvayrinti = New System.Windows.Forms.DataGridView()
        CType(Me.dgvayrinti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvayrinti
        '
        Me.dgvayrinti.AllowUserToAddRows = False
        Me.dgvayrinti.AllowUserToDeleteRows = False
        Me.dgvayrinti.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.dgvayrinti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvayrinti.Location = New System.Drawing.Point(12, 58)
        Me.dgvayrinti.Name = "dgvayrinti"
        Me.dgvayrinti.ReadOnly = True
        Me.dgvayrinti.RowHeadersWidth = 51
        Me.dgvayrinti.RowTemplate.Height = 24
        Me.dgvayrinti.Size = New System.Drawing.Size(735, 308)
        Me.dgvayrinti.TabIndex = 0
        '
        'sIslemAyrinti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SellStock2.My.Resources.Resources.indir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 448)
        Me.Controls.Add(Me.dgvayrinti)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sIslemAyrinti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayrintilar"
        CType(Me.dgvayrinti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvayrinti As DataGridView
End Class
