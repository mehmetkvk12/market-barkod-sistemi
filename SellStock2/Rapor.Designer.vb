<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rapor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rapor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpbaslangic = New System.Windows.Forms.DateTimePicker()
        Me.dtpbitis = New System.Windows.Forms.DateTimePicker()
        Me.gosterbtn = New System.Windows.Forms.Button()
        Me.dgvgoster = New System.Windows.Forms.DataGridView()
        Me.btnrapor = New System.Windows.Forms.Button()
        Me.yazdirr = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvgoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(69, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Başlangıç Tarihi Seçin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(90, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bitiş Tarihi Seçin"
        '
        'dtpbaslangic
        '
        Me.dtpbaslangic.Location = New System.Drawing.Point(230, 55)
        Me.dtpbaslangic.Name = "dtpbaslangic"
        Me.dtpbaslangic.Size = New System.Drawing.Size(200, 22)
        Me.dtpbaslangic.TabIndex = 2
        '
        'dtpbitis
        '
        Me.dtpbitis.Location = New System.Drawing.Point(230, 101)
        Me.dtpbitis.Name = "dtpbitis"
        Me.dtpbitis.Size = New System.Drawing.Size(200, 22)
        Me.dtpbitis.TabIndex = 3
        '
        'gosterbtn
        '
        Me.gosterbtn.BackColor = System.Drawing.Color.Transparent
        Me.gosterbtn.Location = New System.Drawing.Point(502, 67)
        Me.gosterbtn.Name = "gosterbtn"
        Me.gosterbtn.Size = New System.Drawing.Size(81, 41)
        Me.gosterbtn.TabIndex = 4
        Me.gosterbtn.Text = "Göster"
        Me.gosterbtn.UseVisualStyleBackColor = False
        '
        'dgvgoster
        '
        Me.dgvgoster.AllowUserToAddRows = False
        Me.dgvgoster.AllowUserToDeleteRows = False
        Me.dgvgoster.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dgvgoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgoster.Location = New System.Drawing.Point(24, 151)
        Me.dgvgoster.Name = "dgvgoster"
        Me.dgvgoster.ReadOnly = True
        Me.dgvgoster.RowHeadersWidth = 51
        Me.dgvgoster.RowTemplate.Height = 24
        Me.dgvgoster.Size = New System.Drawing.Size(976, 458)
        Me.dgvgoster.TabIndex = 6
        '
        'btnrapor
        '
        Me.btnrapor.BackColor = System.Drawing.Color.Transparent
        Me.btnrapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnrapor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnrapor.Location = New System.Drawing.Point(921, 60)
        Me.btnrapor.Name = "btnrapor"
        Me.btnrapor.Size = New System.Drawing.Size(146, 62)
        Me.btnrapor.TabIndex = 7
        Me.btnrapor.Text = "Yazdır"
        Me.btnrapor.UseVisualStyleBackColor = False
        '
        'yazdirr
        '
        '
        'Rapor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SellStock2.My.Resources.Resources.indir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1181, 668)
        Me.Controls.Add(Me.btnrapor)
        Me.Controls.Add(Me.dgvgoster)
        Me.Controls.Add(Me.gosterbtn)
        Me.Controls.Add(Me.dtpbitis)
        Me.Controls.Add(Me.dtpbaslangic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rapor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rapor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvgoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpbaslangic As DateTimePicker
    Friend WithEvents dtpbitis As DateTimePicker
    Friend WithEvents gosterbtn As Button
    Friend WithEvents dgvgoster As DataGridView
    Friend WithEvents btnrapor As Button
    Friend WithEvents yazdirr As Printing.PrintDocument
End Class
