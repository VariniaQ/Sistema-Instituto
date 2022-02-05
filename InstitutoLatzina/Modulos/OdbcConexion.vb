Imports System.Data.Odbc

Module OdbcConexion
    Public connection As OdbcConnection

    Public Function connect(ByVal name)
        Try
            connection = New OdbcConnection("DSN=" + name)
            connection.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "La conexión ha fallado.")
            Return False
        End Try
    End Function
End Module
