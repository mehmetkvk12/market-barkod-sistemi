Imports System.Data.SqlClient
Public Class deneme



    Private Sub Satis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DataGridView Kolonları Oluşturuluyor
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("BarkodNo", "Barkod No")
        DataGridView1.Columns.Add("UrunAdi", "Ürün Adı")
        DataGridView1.Columns.Add("SatisFiyati", "Fiyat")
        DataGridView1.Columns.Add("Adet", "Adet")
        DataGridView1.Columns.Add("Toplam", "Toplam")

        ' Tüm sütunları salt okunur yap
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.ReadOnly = True
        Next

        ' SADECE "Adet" sütunu düzenlenebilir olsun
        DataGridView1.Columns("Adet").ReadOnly = False

        Button1.Enabled = False
    End Sub

    ' Barkod girildiğinde çalışır
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 13 Then
            Try
                If Conn.State = ConnectionState.Closed Then Conn.Open()

                Dim komut As New SqlCommand("SELECT * FROM Urunler WHERE BarkodNo = @barkod", Conn)
                komut.Parameters.AddWithValue("@barkod", TextBox1.Text.Trim())

                Dim dt As New DataTable()
                Dim adp As New SqlDataAdapter(komut)
                adp.Fill(dt)

                If dt.Rows.Count > 0 Then
                    ' Zaten eklenmişse sadece adet artır
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If Not row.IsNewRow AndAlso row.Cells("BarkodNo").Value.ToString() = TextBox1.Text Then
                            row.Cells("Adet").Value = Convert.ToInt32(row.Cells("Adet").Value) + 1
                            row.Cells("Toplam").Value = Convert.ToDecimal(row.Cells("Adet").Value) * Convert.ToDecimal(row.Cells("SatisFiyati").Value)
                            ToplamFiyatiGuncelle()
                            TextBox1.Clear()
                            Exit Sub
                        End If
                    Next

                    ' Yeni ürün ekle
                    Dim barkod As String = dt.Rows(0)("BarkodNo").ToString()
                    Dim urunAdi As String = dt.Rows(0)("UrunAdi").ToString()
                    Dim fiyati As Decimal = Convert.ToDecimal(dt.Rows(0)("SatisFiyati"))
                    UrunEkle(barkod, urunAdi, fiyati)
                Else
                    MessageBox.Show("Ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message)
            Finally
                Conn.Close()
                TextBox1.Clear()
            End Try
        End If
    End Sub

    ' Ürün satıra ekleniyor
    Private Sub UrunEkle(barkod As String, urunAdi As String, fiyati As Decimal)
        Dim adet As Integer = 1
        Dim toplam As Decimal = adet * fiyati
        DataGridView1.Rows.Add(barkod, urunAdi, fiyati, adet, toplam)
        ToplamFiyatiGuncelle()
    End Sub

    ' Toplam tutar güncelleniyor
    Private Sub ToplamFiyatiGuncelle()
        Dim toplamfiyat As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                toplamfiyat += Convert.ToDecimal(row.Cells("Toplam").Value)
            End If
        Next
        tbtoplamtutar.Text = toplamfiyat.ToString("C2")
    End Sub

    ' Adet değiştirildiğinde otomatik olarak toplam güncellenir
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.ColumnIndex = DataGridView1.Columns("Adet").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim row = DataGridView1.Rows(e.RowIndex)
                Dim adet = Convert.ToInt32(row.Cells("Adet").Value)
                Dim fiyat = Convert.ToDecimal(row.Cells("SatisFiyati").Value)
                row.Cells("Toplam").Value = adet * fiyat

                ToplamFiyatiGuncelle()
            Catch ex As Exception
                MessageBox.Show("Hatalı değer girildi. Adet sadece sayı olmalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    ' Adet sadece rakam girilsin
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Adet").Index Then
            Dim tb As TextBox = CType(e.Control, TextBox)
            RemoveHandler tb.KeyPress, AddressOf OnlyDigits
            AddHandler tb.KeyPress, AddressOf OnlyDigits
        End If
    End Sub

    Private Sub OnlyDigits(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Sağ tıkla silme
    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            DataGridView1.ClearSelection()
            DataGridView1.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            ToplamFiyatiGuncelle()
        End If
    End Sub


End Class