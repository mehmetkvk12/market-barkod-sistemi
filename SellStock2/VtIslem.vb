

Imports System.Data.SqlClient
Module VtIslem
    Public Conn As New SqlConnection(AyarlarModule.SqlBaglantiCumlesi)
    'Public Adp As SqlDataAdapter
    Public Cmd As New SqlCommand()

    Public IslemDurumu As New Integer



    Public Function VeriGetir(ByVal sorgu As String) As DataTable

        Dim SellStockTablo As New DataTable()

        Try

            Dim Adp As New SqlDataAdapter(sorgu, Conn)
            Adp.Fill(SellStockTablo)
            Return SellStockTablo
        Catch ex As Exception
            MessageBox.Show("Hata VeriGetirde: " & ex.Message)
        End Try

        Return SellStockTablo
    End Function

    Public Sub KomutCalistir(komut As SqlCommand)
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
            komut.Connection = Conn
            komut.ExecuteNonQuery()
            'Cmd.CommandText = komut
            'Cmd.Connection = Conn
            'IslemDurumu = Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Hata VtİşlemDe" & ex.Message, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'Finally
            '    If Conn.State = ConnectionState.Open Then
            '        Conn.Close()
            '    End If
        End Try
    End Sub
End Module
