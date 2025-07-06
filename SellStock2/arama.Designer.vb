<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arama
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
        Me.dgvara = New System.Windows.Forms.DataGridView()
        Me.tbara = New System.Windows.Forms.TextBox()
        Me.kapatbtn = New System.Windows.Forms.Button()
        CType(Me.dgvara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvara
        '
        Me.dgvara.AllowUserToAddRows = False
        Me.dgvara.AllowUserToDeleteRows = False
        Me.dgvara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvara.Location = New System.Drawing.Point(29, 94)
        Me.dgvara.Name = "dgvara"
        Me.dgvara.ReadOnly = True
        Me.dgvara.RowHeadersWidth = 51
        Me.dgvara.RowTemplate.Height = 24
        Me.dgvara.Size = New System.Drawing.Size(751, 367)
        Me.dgvara.TabIndex = 0
        '
        'tbara
        '
        Me.tbara.Location = New System.Drawing.Point(280, 50)
        Me.tbara.Name = "tbara"
        Me.tbara.Size = New System.Drawing.Size(184, 22)
        Me.tbara.TabIndex = 1
        '
        'kapatbtn
        '
        Me.kapatbtn.Location = New System.Drawing.Point(692, 31)
        Me.kapatbtn.Name = "kapatbtn"
        Me.kapatbtn.Size = New System.Drawing.Size(88, 41)
        Me.kapatbtn.TabIndex = 2
        Me.kapatbtn.Text = "Kapat"
        Me.kapatbtn.UseVisualStyleBackColor = True
        '
        'arama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(831, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.kapatbtn)
        Me.Controls.Add(Me.tbara)
        Me.Controls.Add(Me.dgvara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "arama"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "arama"
        CType(Me.dgvara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvara As DataGridView
    Friend WithEvents tbara As TextBox
    Friend WithEvents kapatbtn As Button
End Class
