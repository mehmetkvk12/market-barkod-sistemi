Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Module AyarlarModule
    Public Function SqlBaglantiCumlesi() As String
        Dim SqlBaglantiCunlesiOlusturucu As New SqlConnectionStringBuilder
        SqlBaglantiCunlesiOlusturucu.DataSource = "localhost"
        SqlBaglantiCunlesiOlusturucu.InitialCatalog = "SellStock"
        SqlBaglantiCunlesiOlusturucu.IntegratedSecurity = True
        Return SqlBaglantiCunlesiOlusturucu.ConnectionString
    End Function


    Public Function SifreKontrol(Sifre As String) As Boolean
        Dim regex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$")
        Return regex.IsMatch(Sifre)
    End Function

End Module
