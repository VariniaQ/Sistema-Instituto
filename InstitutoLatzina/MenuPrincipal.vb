Public Class frmMenuPrincipal

    Private Sub btnDocentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocentes.Click
        frmAdministrarAlumno.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click
        Me.Hide()
        frmMenuDocente.Show()
    End Sub

    Private Sub btnAgregarRangoD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRangoD.Click
        Me.Hide()
        frmMenuTesoreria.Show()
    End Sub

    Private Sub BtnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfig.Click
        Me.Hide()
        frmMenuAdministrador.Show()
    End Sub
End Class