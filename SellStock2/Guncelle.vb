Imports System.Data.SqlClient

Public Class Guncelle
    Private Sub kapatbtn_Click(sender As Object, e As EventArgs) Handles kapatbtn.Click
        Me.Close()
    End Sub

    Private Sub btnguncelle_Click(sender As Object, e As EventArgs) Handles btnguncelle.Click
        Dim komut As New SqlCommand("UPDATE Urunler SET BarkodNo=@BarkodNo, UrunAdi=@UrunAdi, AlisFiyati=@AlisFiyati, SatisFiyati=@SatisFiyati, Adet= Adet + @EklenecekAdet, Aciklama=@Aciklama WHERE BarkodNo=@BarkodNo", Conn)




        komut.Parameters.AddWithValue("@BarkodNo", tbbarkod.Text)
        komut.Parameters.AddWithValue("@UrunAdi", tburunadi.Text.Trim())
        komut.Parameters.AddWithValue("@AlisFiyati", Convert.ToDecimal(tbalisfiyati.Text))
        komut.Parameters.AddWithValue("@SatisFiyati", Convert.ToDecimal(tbsatisfiyati.Text))
        komut.Parameters.AddWithValue("@EklenecekAdet", Convert.ToDecimal(tbadet.Text))
        komut.Parameters.AddWithValue("@Aciklama", tbaciklama.Text.Trim())

        Try
            Conn.Open()
            komut.ExecuteNonQuery()
            MessageBox.Show("Ürün Başarıyla Güncellendi")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Hataaa: " & ex.Message)

        Finally
            Conn.Close()
        End Try


    End Sub

    Private Sub Guncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbaciklama.Enabled = False
        tbbarkod.Enabled = False
        tburunadi.Enabled = False
    End Sub
End Class