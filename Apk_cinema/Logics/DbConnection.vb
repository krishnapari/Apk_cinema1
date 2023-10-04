Imports System.Data
Imports System.Data.SqlClient
Public Class DbConnection
    Private Shared dbconn As New SqlConnection()

    Public Shared Function ConnectToServer() As Boolean

        Return True
    End Function
End Class
