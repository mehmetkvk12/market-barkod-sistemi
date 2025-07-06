Imports System.Runtime.InteropServices

Public NotInheritable Class AcilisEkrani

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
        ByVal nLeftRect As Integer,
        ByVal nTopRect As Integer,
        ByVal nRightRect As Integer,
        ByVal nBottomRect As Integer,
        ByVal nWidthEllipse As Integer,
        ByVal nHeightEllipse As Integer) As IntPtr
    End Function
    Private Sub AcilisEkrani_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim radius As Integer = 35 ' Ovalin ne kadar yuvarlak olacağını ayarlar
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))



        Me.Opacity = 0
        FadeTimer.Interval = 50
        FadeTimer.Start()

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 40
        ProgressBar1.Value = 0
        Timer1.Interval = 100
        Timer1.Start()
        Me.Opacity = 0
        FadeTimer.Interval = 50
        FadeTimer.Start()

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 40
        ProgressBar1.Value = 0
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = "%" & (ProgressBar1.Value * 100 \ ProgressBar1.Maximum)


        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
        Else
            Timer1.Stop()
            FadeOut()
        End If
    End Sub

    Private Sub FadeTimer_Tick(sender As Object, e As EventArgs) Handles FadeTimer.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            FadeTimer.Stop()
        End If
    End Sub


    Private Sub FadeOut()
        Dim fadeOutTimer As New Timer()
        fadeOutTimer.Interval = 50
        AddHandler fadeOutTimer.Tick, Sub(sender, e)

                                          If Me.Opacity > 0 Then
                                              Me.Opacity -= 0.5
                                          Else
                                              CType(sender, Timer).Stop()
                                              Me.Hide()
                                              AnaForm.Show()



                                          End If
                                      End Sub
        fadeOutTimer.Start()
    End Sub

End Class
