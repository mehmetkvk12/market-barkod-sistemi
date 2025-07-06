Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Rapor
    Private Sub gosterbtn_Click(sender As Object, e As EventArgs) Handles gosterbtn.Click
        Dim baslangictarih As Date = dtpbaslangic.Value.Date
        Dim bitistarih As Date = dtpbitis.Value.Date.AddDays(1).AddSeconds(-1)

        Try
            Dim sorgu As String = "Select * from Satis Where SatisTarihi Between @baslangic and @bitis"
            Dim komut As New SqlCommand(sorgu, Conn)

            komut.Parameters.AddWithValue("@baslangic", baslangictarih)
            komut.Parameters.AddWithValue("@bitis", bitistarih)



            Dim da As New SqlDataAdapter(komut)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvgoster.DataSource = dt

            BaslikGoster()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BaslikGoster()
        dgvgoster.Columns(0).HeaderText = "Satış ID"
        dgvgoster.Columns(1).HeaderText = "Satış Tarihi"
        dgvgoster.Columns(2).HeaderText = "Toplam Tutar"
        dgvgoster.Columns(3).HeaderText = "Ödeme Türü"
        dgvgoster.Columns(4).HeaderText = "Satışı Yapan"
    End Sub
    Private Sub Rapor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpbaslangic.MaxDate = Date.Today

        dtpbitis.MaxDate = Date.Today

    End Sub



    Private Sub btnrapor_Click(sender As Object, e As EventArgs) Handles btnrapor.Click
        Dim yazdirDialog As New PrintDialog()
        yazdirDialog.Document = yazdirr

        If yazdirDialog.ShowDialog() = DialogResult.OK Then
            dgvgoster.Sort(dgvgoster.Columns(1), System.ComponentModel.ListSortDirection.Descending)

            yazdirr.Print()
        End If
    End Sub

    Private Sub yazdirr_PrintPage_1(sender As Object, e As PrintPageEventArgs) Handles yazdirr.PrintPage
        Dim toplamTutar As Decimal = 0
        Dim font As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim x As Integer
        Dim y As Integer = 100

        Dim kolonGenislikleri() As Integer = {80, 150, 100, 100, 150} ' Sütun genişlikleri
        Dim toplamKolon As Integer = dgvgoster.Columns.Count

        ' Sıralama: 2. sütun (indeks 1) tarih ise, yeniden eskiye sırala
        dgvgoster.Sort(dgvgoster.Columns(1), ComponentModel.ListSortDirection.Descending)

        ' --- Başlıklar ---
        x = 100
        For i As Integer = 0 To toplamKolon - 1
            e.Graphics.DrawString(dgvgoster.Columns(i).HeaderText, font, brush, x, y)
            x += kolonGenislikleri(i)
        Next

        y += 30

        ' --- Satırlar ---
        For i As Integer = 0 To dgvgoster.Rows.Count - 1
            If Not dgvgoster.Rows(i).IsNewRow Then
                x = 100
                For j As Integer = 0 To toplamKolon - 1
                    Dim value As String = dgvgoster.Rows(i).Cells(j).Value?.ToString()
                    e.Graphics.DrawString(value, font, brush, x, y)
                    x += kolonGenislikleri(j)
                Next

                ' 3. sütun (indeks 2) toplam tutar alanıysa:
                Dim tutarObj = dgvgoster.Rows(i).Cells(2).Value
                If IsNumeric(tutarObj) Then
                    toplamTutar += Convert.ToDecimal(tutarObj)
                End If

                y += 30
            End If
        Next

        ' --- Toplam Tutar ---
        e.Graphics.DrawString("Toplam Tutar: " & toplamTutar.ToString("C2", New Globalization.CultureInfo("tr-TR")), font, brush, x - 400, y + 20)
    End Sub

End Class