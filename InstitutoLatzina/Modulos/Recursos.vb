Imports System.Data.Odbc
Imports System.Globalization

Module Recursos
    Public cambio As New Globalization.CultureInfo("es-ES")

    Public command As OdbcCommand
    Public result As OdbcDataReader

    Public adp As OdbcDataAdapter

    Public query As String

    Public Function doQuery(ByVal queryString As String)
        query = queryString
        command = New OdbcCommand(query, OdbcConexion.connection)
        command.CommandType = CommandType.Text
        Try
            result = command.ExecuteReader()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Query rechazada")
            Return False
        End Try
    End Function

    Public ds As New DataSet

    '-------primary y foreign key que forman parte de las consultas---------
    Public codLocalidad As Integer
    Public codRangoDir As Integer
    Public codUsuario As Integer
    Public idDocente As Integer
    Public codMotivo As Integer
    Public codLicencia As Integer
    Public dniDocente As String

    Public max As String

    Public Function darFormato()
        cambio.NumberFormat.NumberDecimalSeparator = (".")
        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
        Return True
    End Function

    Public Function insertarEnGrilla(ByVal sql As String, ByVal table As String)
        ds.Tables.Add(table)

        adp = New OdbcDataAdapter(sql, OdbcConexion.connection)
        adp.Fill(ds.Tables(table))
        Return True
    End Function

    Public Function GetProfesor(ByVal texto As String)
        Dim ID As Integer = texto.Substring(0, 1) 'No hace falta tenerlo en recursos.
        Return ID
    End Function

End Module


