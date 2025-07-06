
Public Class AnaForm

    Private Sub FormKapat()

        For Each frm As Form In Me.MdiChildren

            frm.Close()

        Next
    End Sub
    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GirisFormu.ShowDialog()
        If Parametre.GirisDurumu = True Then
            Satis.MdiParent = Me
            Satis.Show()
        ElseIf Parametre.KapatmaDurumu = False Then
            FormKapat()
            AcilisEkrani.Close()
        Else
            Me.Close()
        End If

    End Sub


    Private Sub SatisIşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatisIşlemleriToolStripMenuItem.Click
        FormKapat()
        SatisIslemleri.MdiParent = Me
        SatisIslemleri.Refresh()
        SatisIslemleri.Show()
    End Sub

    Private Sub StokHareketleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokHareketleriToolStripMenuItem.Click
        FormKapat()
        Stok.MdiParent = Me
        Stok.Show()
    End Sub

    Private Sub RaporToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaporToolStripMenuItem.Click
        FormKapat()
        Rapor.MdiParent = Me
        Rapor.Refresh()
        Rapor.Show()

    End Sub

    Private Sub SatisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatisToolStripMenuItem.Click
        FormKapat()
        Satis.MdiParent = Me
        Satis.Refresh()
        Satis.Show()
    End Sub

    Private Sub DenemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormKapat()
        deneme.Show()

    End Sub

    Private Sub AnaForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub
End Class
