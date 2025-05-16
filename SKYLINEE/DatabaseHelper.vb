Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    ' Sesuaikan dengan host, user, password, dan nama database kamu
    Private connectionString As String = "server=localhost;userid=root;password=;database=db_skyline;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        Return conn
    End Function
End Class
