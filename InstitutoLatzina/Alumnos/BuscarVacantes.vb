Imports System.Data.Odbc

Public Class frmBuscarVacantes
    Dim aux As Integer
    Dim pro As Integer

    Private Sub PreinscripciónAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        doQuery("select nombre from Profesiones")

        While result.Read
            cmbProfesiones.Items.Add(result.GetString(0))
        End While

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If String.IsNullOrEmpty(cmbProfesiones.Text) Then
            If String.IsNullOrEmpty(cmbProfesiones.Text) Then
                MsgBox("Ingrese una Profesión", , "Aviso")
                cmbProfesiones.Text = ""
            End If
        Else
            doQuery("select codprofesion from profesiones where nombre = '" & cmbProfesiones.Text & "'")
            If result.Read Then
                pro = result(0)
            End If
            doQuery("select P.Nombre, C.NroClase, C.MAXCANTALUMNOS, A.cant Cantidad from clases C, profesiones P, (select NROCLASE, count(*) cant from(AlumnoClase) Group by NROCLASE) as A Where(p.CODPROFESION = c.CODPROFESION) and A.NROCLASE = C.NROCLASE and p.CODPROFESION = " & pro)
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
        frmAdministrarAlumno.Show()
    End Sub

    Function borrar()
        cmbProfesiones.Text = ""
        dtgReferencia.Text = ""
        cmbProfesiones.Items.Clear()
        Return True
    End Function

End Class