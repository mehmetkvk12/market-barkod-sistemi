
Imports System.Data.SqlClient

Public Class Satis
    Private Sub Satis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbbarkod.Select()
        dgvEkUrunGoster.Columns.Clear()
        dgvEkUrunGoster.Columns.Add("BarkodNo", "Barkod No")
        dgvEkUrunGoster.Columns.Add("UrunAdi", "Ürün Adı")
        dgvEkUrunGoster.Columns(1).Width = 185
        dgvEkUrunGoster.Columns.Add("SatisFiyati", "Fiyat")
        dgvEkUrunGoster.Columns.Add("Adet", "Adet")
        dgvEkUrunGoster.Columns.Add("Toplam", "Toplam")

        For Each column As DataGridViewColumn In dgvEkUrunGoster.Columns
            column.ReadOnly = True
        Next

        dgvEkUrunGoster.Columns("Adet").ReadOnly = False

        btnonay.Enabled = False
    End Sub


    Private Sub tbbarkod_TextChanged(sender As Object, e As EventArgs) Handles tbbarkod.TextChanged
        If tbbarkod.Text.Length = 13 Then
            Try
                If Conn.State = ConnectionState.Closed Then Conn.Open()

                Dim komut As New SqlCommand("SELECT * FROM Urunler WHERE BarkodNo = @barkod", Conn)
                komut.Parameters.AddWithValue("@barkod", tbbarkod.Text.Trim())

                Dim dt As New DataTable()
                Dim adp As New SqlDataAdapter(komut)
                adp.Fill(dt)

                If dt.Rows.Count > 0 Then

                    For Each row As DataGridViewRow In dgvEkUrunGoster.Rows
                        If Not row.IsNewRow AndAlso row.Cells("BarkodNo").Value.ToString() = tbbarkod.Text Then
                            row.Cells("Adet").Value = Convert.ToInt32(row.Cells("Adet").Value) + 1
                            row.Cells("Toplam").Value = Convert.ToDecimal(row.Cells("Adet").Value) * Convert.ToDecimal(row.Cells("SatisFiyati").Value)
                            ToplamFiyatiGuncelle()
                            tbbarkod.Clear()
                            Exit Sub
                        End If
                    Next


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
                tbbarkod.Clear()
            End Try
        End If
    End Sub

    Private Sub UrunEkle(barkod As String, urunAdi As String, fiyati As Decimal)
        Dim adet As Integer = 1
        Dim toplam As Decimal = adet * fiyati
        dgvEkUrunGoster.Rows.Add(barkod, urunAdi, fiyati, adet, toplam)
        ToplamFiyatiGuncelle()
    End Sub

    Private Sub ToplamFiyatiGuncelle()
        Dim toplamfiyat As Decimal = 0
        For Each row As DataGridViewRow In dgvEkUrunGoster.Rows
            If Not row.IsNewRow Then
                toplamfiyat += Convert.ToDecimal(row.Cells("Toplam").Value)
            End If
        Next
        tbtoplamtutar.Text = toplamfiyat.ToString("C2") + " TL"
    End Sub


    Private Sub dgvEkUrunGoster_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEkUrunGoster.CellValueChanged
        If e.ColumnIndex = dgvEkUrunGoster.Columns("Adet").Index AndAlso e.RowIndex >= 0 Then
            Try
                Dim row = dgvEkUrunGoster.Rows(e.RowIndex)
                Dim adet = Convert.ToInt32(row.Cells("Adet").Value)
                Dim fiyat = Convert.ToDecimal(row.Cells("SatisFiyati").Value)
                row.Cells("Toplam").Value = adet * fiyat

                ToplamFiyatiGuncelle()
            Catch ex As Exception
                MessageBox.Show("Hatalı değer girildi. Adet sadece sayı olmalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub


    Private Sub OnlyDigits(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvEkUrunGoster_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEkUrunGoster.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            dgvEkUrunGoster.ClearSelection()
            dgvEkUrunGoster.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub SilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilToolStripMenuItem.Click
        If dgvEkUrunGoster.SelectedRows.Count > 0 Then
            dgvEkUrunGoster.Rows.Remove(dgvEkUrunGoster.SelectedRows(0))
            ToplamFiyatiGuncelle()
        End If
    End Sub

    Private Sub btnonay_Click(sender As Object, e As EventArgs) Handles btnonay.Click

        If cmbsecim.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen Ödeme Türünü Seçiniz")
            Exit Sub
        End If

        Try
            Conn.Open()
            Dim trans As SqlTransaction = Conn.BeginTransaction()


            Dim toplamTutarText As String = tbtoplamtutar.Text.Replace("TL", "").Trim()
            Dim toplamTutar As Decimal
            If Not Decimal.TryParse(toplamTutarText, Globalization.NumberStyles.Any,
                                 New Globalization.CultureInfo("tr-TR"), toplamTutar) Then
                MessageBox.Show("Toplam tutar sayıya çevrilemedi.")
                Conn.Close()
                Exit Sub
            End If


            Dim cmdsatis As New SqlCommand("INSERT INTO Satis (SatisTarihi, ToplamTutar, OdemeTuru, KulAdSo)
                                        VALUES (@tarih, @toplam, @odeme, @kuladso); SELECT SCOPE_IDENTITY()", Conn, trans)

            cmdsatis.Parameters.AddWithValue("@tarih", DateTime.Now)
            cmdsatis.Parameters.AddWithValue("@toplam", toplamTutar)
            cmdsatis.Parameters.AddWithValue("@odeme", cmbsecim.SelectedItem.ToString())
            cmdsatis.Parameters.AddWithValue("@kuladso", GirisYapanKullanici)

            Dim satisid As Integer = Convert.ToInt32(cmdsatis.ExecuteScalar())


            For Each row As DataGridViewRow In dgvEkUrunGoster.Rows
                If Not row.IsNewRow Then
                    Dim barkod As String = row.Cells("BarkodNo").Value.ToString()
                    Dim miktar As Integer = Convert.ToInt32(row.Cells("Adet").Value)
                    Dim birimfiyat As Decimal = Convert.ToDecimal(row.Cells("SatisFiyati").Value)
                    Dim toplamfiyat As Decimal = Convert.ToDecimal(row.Cells("Toplam").Value)


                    Dim cmdDetay As New SqlCommand("INSERT INTO SatisDetay 
                                                (SatisID, BarkodNo, SatMiktar, BirimFiyat, ToplamFiyat) 
                                                VALUES (@sid, @barkod, @miktar, @bfiyat, @tfiyat)", Conn, trans)

                    cmdDetay.Parameters.AddWithValue("@sid", satisid)
                    cmdDetay.Parameters.AddWithValue("@barkod", barkod)
                    cmdDetay.Parameters.AddWithValue("@miktar", miktar)
                    cmdDetay.Parameters.AddWithValue("@bfiyat", birimfiyat)
                    cmdDetay.Parameters.AddWithValue("@tfiyat", toplamfiyat)

                    cmdDetay.ExecuteNonQuery()

                    ' Stok Güncelleme işlemi
                    Dim StokGuncelle As New SqlCommand("UPDATE Urunler SET Adet = Adet - @miktar WHERE BarkodNo = @barkod ", Conn, trans)
                    StokGuncelle.Parameters.AddWithValue("@miktar", miktar)
                    StokGuncelle.Parameters.AddWithValue("@barkod", barkod)
                    StokGuncelle.ExecuteNonQuery()
                End If
            Next

            trans.Commit()
            MessageBox.Show("Satış başarıyla gerçekleşti.")

        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " & ex.Message)
        Finally
            dgvEkUrunGoster.Columns.Clear()
            cmbsecim.Text = ""
            If Conn.State = ConnectionState.Open Then Conn.Close()

        End Try
    End Sub


    Private Sub cmbsecim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsecim.SelectedIndexChanged
        If cmbsecim.SelectedIndex <> -1 Then
            btnonay.Enabled = True
        Else
            btnonay.Enabled = False
        End If
    End Sub
End Class