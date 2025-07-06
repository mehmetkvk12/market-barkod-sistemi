Imports System.Data.SqlClient

Public Class Stok


    Private Sub Stok_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim sorgu As String = "Select * From Urunler"

        dgvUrunleriGoster.DataSource = VtIslem.VeriGetir(sorgu)

        dgvUrunleriGoster.Columns(5).Width = 202

    End Sub


    Private Sub yeniUrunbtn_Click(sender As Object, e As EventArgs) Handles yeniUrunbtn.Click
        YeniUrunEkle.Show(Me)
    End Sub



    Private Sub tbara_TextChanged(sender As Object, e As EventArgs) Handles tbara.TextChanged

        Dim komut As New SqlCommand("SELECT * FROM Urunler WHERE UrunAdi LIKE @UrunAdi OR BarkodNo LIKE @UrunAdi", Conn)
        komut.Parameters.AddWithValue("@UrunAdi", "%" & tbara.Text.Trim() & "%")

        Dim dt As New DataTable()
        Dim adp As New SqlDataAdapter(komut)
        adp.Fill(dt)
        dgvUrunleriGoster.DataSource = dt
    End Sub

    Private Sub DuzenleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuzenleToolStripMenuItem.Click
        Dim satir As DataGridViewRow = dgvUrunleriGoster.SelectedRows(0)

        With Duzenle
            .tbbarkod.Text = satir.Cells("BarkodNo").Value.ToString()
            .tburunadi.Text = satir.Cells("UrunAdi").Value.ToString()
            .tbalisfiyati.Text = satir.Cells("AlisFiyati").Value.ToString()
            .tbsatisfiyati.Text = satir.Cells("SatisFiyati").Value.ToString()
            .tbadet.Text = satir.Cells("Adet").Value.ToString()
            .tbaciklama.Text = satir.Cells("Aciklama").Value.ToString()
            .ShowDialog(Me)

        End With
        Dim sorgu As String = "Select * From Urunler"
        dgvUrunleriGoster.DataSource = VtIslem.VeriGetir(sorgu)


    End Sub

    Private Sub GuncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuncelleToolStripMenuItem.Click
        Dim satir As DataGridViewRow = dgvUrunleriGoster.SelectedRows(0)

        With Guncelle
            .tbbarkod.Text = satir.Cells("BarkodNo").Value.ToString()
            .tburunadi.Text = satir.Cells("UrunAdi").Value.ToString()
            .tbalisfiyati.Text = satir.Cells("AlisFiyati").Value.ToString()
            .tbsatisfiyati.Text = satir.Cells("SatisFiyati").Value.ToString()
            .tbadet.Text = "0"
            .tbaciklama.Text = satir.Cells("Aciklama").Value.ToString()
            .ShowDialog(Me)

        End With
        Dim sorgu As String = "Select * From Urunler"
        dgvUrunleriGoster.DataSource = VtIslem.VeriGetir(sorgu)

    End Sub
End Class