Imports System.Data.SqlClient
Public Class arama
    'Private Sub UrunleriGoster(Optional ByVal filtre As String = "")

    '    Dim sorgu As String = "Select BarkodNo, UrunAdi, Aciklama From Urunler"
    '    If filtre <> "" Then
    '        sorgu &= "Where UrunAdi LIKE @filtre OR Aciklama LIKE @filtre"
    '    End If
    '    dgvara.DataSource = VtIslem.VeriGetir(sorgu)
    'End Sub
    'Private Sub BaslikGoster()
    '    dgvara.Columns.Clear()
    '    dgvara.Columns(0).HeaderText = "Barkod No"
    '    dgvara.Columns(1).HeaderText = "Ürün Adı"
    '    dgvara.Columns(2).HeaderText = "Açıklama"

    'End Sub
    'Private Sub kapatbtn_Click(sender As Object, e As EventArgs) Handles kapatbtn.Click
    '    Me.Close()
    'End Sub

    'Private Sub arama_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    '    UrunleriGoster()
    'End Sub

    'Private Sub tbara_TextChanged(sender As Object, e As EventArgs) Handles tbara.TextChanged
    '    UrunleriGoster(tbara.Text)
    'End Sub

    'Private Sub dgvara_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvara.CellDoubleClick
    '    If e.RowIndex > 0 Then
    '        Dim satir As DataGridView = dgvara.Rows(e.RowIndex)

    '        With Satis.dgvEkUrunGoster
    '            .Rows.Add(
    '            s
    '            )
    '    End If
    'End Sub
End Class