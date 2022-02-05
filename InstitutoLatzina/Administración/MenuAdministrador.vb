Public Class frmMenuAdministrador

    Private Sub btnLocalidades_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        frmAgregarLocalidad.Show()
    End Sub

    Private Sub btnDocentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmMenuDocente.Show()
    End Sub

    Private Sub btnAgregarRangoD_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarRangoD.Click
        Me.Hide()
        frmAgregarRangoDirectivo.Show()
    End Sub

    Private Sub btnUsuarios_Click_1(sender As System.Object, e As System.EventArgs) Handles btnUsuarios.Click
        Me.Hide()
        frmAgregarUsuario.Show()
    End Sub

    Private Sub btnAgregarLocalidad_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarLocalidad.Click
        Me.Hide()
        frmAgregarLocalidad.Show()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenuPrincipal.Show()
    End Sub

    Private Sub btnMotivosLic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmAgregarMotivoLicencia.Show()
    End Sub

    Private Sub BtnPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pagos.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Caja.clear()
        Me.Hide()
        Caja.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmAdministrarAlumno.Show()
    End Sub
End Class