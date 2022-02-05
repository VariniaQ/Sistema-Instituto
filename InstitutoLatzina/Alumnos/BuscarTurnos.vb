Imports System.Data.Odbc

Public Class frmBuscarTurnos
    Dim num As Integer
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtNTurno.Text) Then
            If String.IsNullOrEmpty(txtNTurno.Text) Then
                MsgBox("Ingrese el Número de Turno", , "Aviso")
                txtNTurno.Text = ""
            End If
        Else
            num = CInt(txtNTurno.Text)
            doQuery("select Nombre, Apellido, DNI from TrnINSCRIPCIONES where CODTURNO = " & CInt(txtNTurno.Text) & " ")
            ds.Tables.Add("XX")
            adp = New OdbcDataAdapter(query, connection)
            adp.Fill(ds.Tables("XX"))
            dtgReferencia.DataSource = ds.Tables("XX")
            ds.Tables.Remove("XX")
            command.Dispose()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        borrar()
        Me.Hide()
        frmAdministrarTurnos.Show()
    End Sub

    Function borrar()
        txtNTurno.Text = ""
        Return True
    End Function
End Class