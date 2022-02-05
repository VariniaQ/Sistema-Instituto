Public Class frmAdministrarAlumno

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Hide()
        frmMenuPrincipal.Show()
    End Sub

    Private Sub btnTomarAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTomarAsistencia.Click
        Me.Hide()
        frmBuscarVacantes.Show()
    End Sub

    Private Sub AdministrarAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OdbcConexion.connect("Instituto")
    End Sub

    Private Sub btnMatricularAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatricularAlumno.Click
        Me.Hide()
        frmMatricularAlumno.Show()
    End Sub

    Private Sub btnTurnosdePreinscripción_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministrarTurnos.Click
        frmAdministrarTurnos.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmAdministrarDatosdeAlumnos.Show()
    End Sub

    Private Sub btnClalificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClalificaciones.Click
        Me.Hide()
        frmAgregarCalificaciones.Show()
    End Sub

    Private Sub btnAsistencia_Click(sender As System.Object, e As System.EventArgs) Handles btnAsistencia.Click
        Me.Hide()
        frmAsistenciaAlumno.Show()
    End Sub
End Class