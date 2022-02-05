Public Class frmAdministrarTurnos

    Private Sub btnAgregarTurnoAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTurnoAlumno.Click
        Me.Hide()
        frmAgregarTurnoAlumno.Show()
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmAdministrarAlumno.Show()
    End Sub

    Private Sub btnBuscarTurnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarTurnos.Click
        Me.Hide()
        frmBuscarTurnos.Show()
    End Sub
End Class