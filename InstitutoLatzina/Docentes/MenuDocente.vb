Public Class frmMenuDocente

    Private Sub btnLicencia_Click(sender As System.Object, e As System.EventArgs) Handles btnLicencia.Click
        Me.Hide()
        frmAgregarLicencias.Show()
        frmAgregarLicencias.cargarInfo()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        frmMenuPrincipal.Show()
    End Sub

    Private Sub btnAgregarLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLocalidad.Click
        Me.Hide()
        frmAgregarDocentes.Show()
    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click
        Me.Hide()
        AsignarMateria.Show()
        AsignarMateria.loadInfo()
    End Sub

    Private Sub btnMatricularAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatricularAlumno.Click
        Me.Hide()
        frmEditarMateriaAsignada.Show()
        frmEditarMateriaAsignada.reset()
    End Sub

    Private Sub btnClalificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClalificaciones.Click
        Me.Hide()
        frmEditarAsistenciaDocente.Show()
    End Sub

    Private Sub btnAgregarRangoD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRangoD.Click
        Me.Hide()
        frmAsistenciaDocente.Show()
        frmAsistenciaDocente.cargarInfo()
    End Sub
End Class