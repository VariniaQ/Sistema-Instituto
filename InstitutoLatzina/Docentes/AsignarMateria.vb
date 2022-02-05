Public Class AsignarMateria

    Function loadInfo()
        lstAsignaturas.Items.Clear()
        lstProfesores.Items.Clear()
        doQuery("select nroclase,nombre from clases c,profesiones p where c.iddocente is null and c.codprofesion = p.codprofesion")
        While result.Read
            lstAsignaturas.Items.Add(result(0) & " | " & result(1))
        End While
        Return True
    End Function

    Function updateProfesores(ByVal codProfesion)
        lstProfesores.Items.Clear()
        doQuery("select apellido from docente where codprofesion = " & codProfesion)
        While result.Read
            lstProfesores.Items.Add(result(0))
        End While
        Return True
    End Function

    Private Sub lstAsignaturas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAsignaturas.SelectedIndexChanged
        Dim nroclase As Integer
        nroclase = lstAsignaturas.SelectedItem.ToString().Substring(0, 1)
        doQuery("select codprofesion from clases where nroclase =" & nroclase)
        If result.Read Then
            updateProfesores(result(0))
        End If
    End Sub

    Private Sub lstProfesores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProfesores.SelectedIndexChanged
        btnAsignar.Enabled = True
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Dim iddocente As Integer
        Try
            doQuery("select iddocente from docente where apellido = '" & lstProfesores.SelectedItem.ToString & "'")
            If result.Read Then
                iddocente = result(0)
                Dim nroclase As Integer
                nroclase = lstAsignaturas.SelectedItem.ToString().Substring(0, 1)
                doQuery("update clases set iddocente =" & iddocente & " where nroclase =" & nroclase)
                MsgBox("Profesor/a " & lstProfesores.SelectedItem.ToString & " asignado/a la clase " & nroclase, , "Confirmacion")
                loadInfo()
                btnAsignar.Enabled = False
            End If
        Catch
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Hide()
        frmMenuDocente.Show()
    End Sub
End Class