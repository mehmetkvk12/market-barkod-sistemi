Imports System.Data.SqlClient
Public Class YeniUrunEkle
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Try
            Dim komut As New SqlCommand("INSERT into Urunler (BarkodNo, UrunAdi, AlisFiyati, SatisFiyati, Adet, Aciklama)
                VALUES(@barkodno, @urunadi, @alisfiyati, @satisfiyati, @adet, @aciklama) ")

            komut.Parameters.AddWithValue("@barkodno", tbbarkod.Text)
            komut.Parameters.AddWithValue("@urunadi", tburunadi.Text)
            komut.Parameters.AddWithValue("@alisfiyati", Convert.ToDecimal(tbAlis.Text))
            komut.Parameters.AddWithValue("@satisfiyati", Convert.ToDecimal(TbSatis.Text))
            komut.Parameters.AddWithValue("@adet", Convert.ToInt16(TbAdet.Text))
            komut.Parameters.AddWithValue("@aciklama", tbAciklama.Text)

            If tbbarkod.Text.Length = 13 Then
                VtIslem.KomutCalistir(komut)
                MessageBox.Show("Ürün Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                MessageBox.Show("Barkod Numarası Hatalı ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Stok.Refresh()
        Catch ex As Exception
            MessageBox.Show("Hata Btn de: " & ex.Message)
        Finally
            tbbarkod.Clear()
            tbAciklama.Clear()
            tbAlis.Clear()
            tburunadi.Clear()
            TbAdet.Clear()
            TbSatis.Clear()

            Me.Close()
        End Try
    End Sub

    Private Sub tbbarkod_TextChanged(sender As Object, e As EventArgs) Handles tbbarkod.TextChanged


    End Sub
End Class