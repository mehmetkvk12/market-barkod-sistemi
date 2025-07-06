Public Class sIslemAyrinti

    Private Sub BaslikGoster()
        dgvayrinti.Columns(0).HeaderText = "Satış ID"

        dgvayrinti.Columns(1).HeaderText = "Barkod No"

        dgvayrinti.Columns(2).HeaderText = "Satılan Miktar"

        dgvayrinti.Columns(3).HeaderText = "Birim Fiyatı"

        dgvayrinti.Columns(4).HeaderText = "Toplam Fiyatı"
    End Sub
    Private Sub VeriGetir()
        Dim secilenID As String = SatisIslemleri.SatislariListeledgv.SelectedRows(0).Cells("SatisID").Value.ToString()
        Dim sorgu As String = "SELECT SatisID, BarkodNo, SatMiktar, BirimFiyat, ToplamFiyat FROM SatisDetay WHERE SatisID = '" & secilenID & "'"


        dgvayrinti.DataSource = VtIslem.VeriGetir(sorgu)
    End Sub
    Private Sub sIslemAyrinti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VeriGetir()
        BaslikGoster()
    End Sub


End Class