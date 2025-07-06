Imports System.Data.SqlClient
Public Class SatisIslemleri



    Private Sub VeriDoldur()
        Dim sorgu As String = "Select SatisID, SatisTarihi, KulAdSo, OdemeTuru, ToplamTutar from Satis"
        SatislariListeledgv.DataSource = VtIslem.VeriGetir(sorgu)

    End Sub

    Private Sub BaslikGoster()
        SatislariListeledgv.Columns(0).HeaderText = "ID"

        SatislariListeledgv.Columns(1).HeaderText = "Satış Tarihi"
        SatislariListeledgv.Columns(1).Width = 150

        SatislariListeledgv.Columns(2).HeaderText = "Satışı Yapan"
        SatislariListeledgv.Columns(2).Width = 180

        SatislariListeledgv.Columns(3).HeaderText = "Ödeme Türü"
        SatislariListeledgv.Columns(3).Width = 150
        SatislariListeledgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        SatislariListeledgv.Columns(4).HeaderText = "Toplam Tutar"
        SatislariListeledgv.Columns(4).Width = 165

    End Sub

    Private Sub SatisIslemleri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VeriDoldur()
        BaslikGoster()
        SatislariListeledgv.Sort(SatislariListeledgv.Columns(1), System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Private Sub Ayrintilar_Click(sender As Object, e As EventArgs) Handles Ayrintilar.Click
        sIslemAyrinti.ShowDialog(Me)
    End Sub

    Private Sub SatislariListeledgv_MouseDown(sender As Object, e As MouseEventArgs) Handles SatislariListeledgv.MouseDown

        If e.Button = MouseButtons.Right Then
            Dim hitTest As DataGridView.HitTestInfo = SatislariListeledgv.HitTest(e.X, e.Y)

            ' SADECE hücrelerde çalışsın, sütun başlığına sağ tıklama olmasın
            If hitTest.Type = DataGridViewHitTestType.Cell Then
                SatislariListeledgv.ClearSelection()
                SatislariListeledgv.Rows(hitTest.RowIndex).Selected = True
                SatislariListeledgv.CurrentCell = SatislariListeledgv.Rows(hitTest.RowIndex).Cells(hitTest.ColumnIndex)
                menu.Show(SatislariListeledgv, e.Location)
            End If
        End If
    End Sub
End Class