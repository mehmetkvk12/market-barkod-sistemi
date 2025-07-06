Imports System.Data.SqlClient


Public Class GirisFormu

    Dim KullaniciTablo As New DataTable()

    Public Yokmu As Boolean = False
    Private Sub VeriDoldur()
        Dim sorgu As String = "Select KullaniciAdi, Sifre From Kullanici"
        KullaniciTablo = VtIslem.VeriGetir(sorgu)

        If KullaniciTablo.Rows.Count <= 0 Then
            MessageBox.Show("Sistemde Kayýtlý Kullanýcý Bulunamadý!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        AnaForm.Dispose()
    End Sub

    Private Sub GirisFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbkuladi.Select()
        VeriDoldur()

    End Sub

    Private kapat As Boolean = False
    Private Sub GirisFormu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If kapat = False Then
            e.Cancel = True
            Me.Hide()

        End If
    End Sub

    Private Sub btngiris_Click(sender As Object, e As EventArgs) Handles btngiris.Click

        Parametre.GirisDurumu = False
        Parametre.KapatmaDurumu = False

        For Each satir As DataRow In KullaniciTablo.Rows
            If satir("KullaniciAdi").ToString() = tbkuladi.Text AndAlso
               satir("Sifre").ToString() = tbsifre.Text Then


                Parametre.GirisDurumu = True
                Parametre.KapatmaDurumu = True
                Exit For
            End If
        Next

        If Parametre.GirisDurumu Then
            GirisYapanKullanici = tbkuladi.Text
            Me.Close()
            AnaForm.Show()
        Else
            MessageBox.Show("Girilen Verileri " & vbCrLf & " Kontrol Ediniz ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbkuladi.Clear()
            tbsifre.Clear()
            tbkuladi.Focus()
        End If
    End Sub

End Class
