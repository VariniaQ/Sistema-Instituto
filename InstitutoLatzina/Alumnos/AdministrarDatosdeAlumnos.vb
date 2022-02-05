Public Class frmAdministrarDatosdeAlumnos

    Private Sub btnInscribirAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInscribirAlumno.Click
        Me.Hide()
        frmInscribirAlumno.Show()
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmAdministrarAlumno.Show()
    End Sub

    Private Sub btnBuscarTurnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarTurnos.Click
        Me.Hide()
        frmReinscribirAlumno.Show()
    End Sub
End Class