<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class GirisFormu
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents tbkuladi As System.Windows.Forms.TextBox
    Friend WithEvents tbsifre As System.Windows.Forms.TextBox
    Friend WithEvents btngiris As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.tbkuladi = New System.Windows.Forms.TextBox()
        Me.tbsifre = New System.Windows.Forms.TextBox()
        Me.btngiris = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Location = New System.Drawing.Point(39, 12)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(275, 32)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Kullanıcı Adı"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Location = New System.Drawing.Point(39, 91)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(275, 32)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Şifre"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbkuladi
        '
        Me.tbkuladi.Location = New System.Drawing.Point(41, 40)
        Me.tbkuladi.Margin = New System.Windows.Forms.Padding(4)
        Me.tbkuladi.Name = "tbkuladi"
        Me.tbkuladi.Size = New System.Drawing.Size(242, 28)
        Me.tbkuladi.TabIndex = 1
        '
        'tbsifre
        '
        Me.tbsifre.Location = New System.Drawing.Point(41, 118)
        Me.tbsifre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbsifre.Name = "tbsifre"
        Me.tbsifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbsifre.Size = New System.Drawing.Size(242, 28)
        Me.tbsifre.TabIndex = 3
        '
        'btngiris
        '
        Me.btngiris.Location = New System.Drawing.Point(22, 192)
        Me.btngiris.Margin = New System.Windows.Forms.Padding(4)
        Me.btngiris.Name = "btngiris"
        Me.btngiris.Size = New System.Drawing.Size(118, 52)
        Me.btngiris.TabIndex = 4
        Me.btngiris.Text = "&Giriş Yap"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(165, 192)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(118, 52)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Vazgeç"
        '
        'GirisFormu
        '
        Me.AcceptButton = Me.btngiris
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = Global.SellStock2.My.Resources.Resources.indir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(314, 284)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btngiris)
        Me.Controls.Add(Me.tbsifre)
        Me.Controls.Add(Me.tbkuladi)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GirisFormu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
