Public Class frmEditarMateriaAsignada

    Function reset()
        lstAsignadas.Items.Clear()
        lstClases.Items.Clear()
        cmbDocente.Items.Clear()
        lblAsignatura.Text = ""
        doQuery("select apellido from docente")
        While result.Read
            cmbDocente.Items.Add(result(0))
        End While
        Return True
    End Function

    Private Sub AsignarMateria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Function updateLists()
        lstAsignadas.Items.Clear()
        lstClases.Items.Clear()
        doQuery("select iddocente from docente where apellido = '" & cmbDocente.Text & "'")
        If result.Read Then
            Dim iddocente As Integer = result(0)
            doQuery("select nroclase,nombre from clases c,profesiones p where c.iddocente != " & iddocente & " and c.codprofesion = p.codprofesion")
            While result.Read
                lstClases.Items.Add(result(0) & " | " & result(1))
            End While
            doQuery("select nroclase,nombre from clases c,profesiones p where c.iddocente is null and c.codprofesion = p.codprofesion")
            While result.Read
                lstClases.Items.Add(result(0) & " | " & result(1) & " | SIN DOCENTE")
            End While
            doQuery("select nroclase,nombre from clases c,profesiones p where c.iddocente = " & iddocente & " and c.codprofesion = p.codprofesion")
            While result.Read
                lstAsignadas.Items.Add(result(0) & " | " & result(1))
            End While
            doQuery("select p.nombre from docente d, profesiones p where d.codprofesion = p.codprofesion")
            If result.Read Then
                lblAsignatura.Text = result(0)
            End If
        End If
        Return True
    End Function

    Private Sub cmbDocente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDocente.SelectedIndexChanged
        updateLists()
    End Sub

    Private Sub lstAsignadas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAsignadas.SelectedIndexChanged
        Try
            lstClases.ClearSelected()
            Dim nroclase As Integer
            Dim iddocente As Integer
            nroclase = lstAsignadas.SelectedItem.ToString().Substring(0, 1)
            doQuery("select iddocente from docente where apellido = '" & cmbDocente.Text & "'")
            If result.Read Then
                iddocente = result(0)
                doQuery("update clases set iddocente = null where nroclase = " & nroclase)
                updateLists()
            End If
        Catch
        End Try
    End Sub

    Private Sub lstClases_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstClases.SelectedIndexChanged
        Try
            lstAsignadas.ClearSelected()
            Dim nroclase As Integer = lstClases.SelectedItem.ToString().Substring(0, 1)
            Dim iddocente As Integer
            doQuery("select iddocente from docente where apellido = '" & cmbDocente.Text & "'")
            If result.Read Then
                iddocente = result(0)
                doQuery("update clases set iddocente = " & iddocente & " where nroclase = " & nroclase)
                updateLists()
            End If
        Catch
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Hide()
        frmMenuDocente.Show()
    End Sub
End Class