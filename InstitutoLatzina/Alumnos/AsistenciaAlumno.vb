Public Class frmAsistenciaAlumno
    Dim idAlumno As Integer
    Dim ingresoValido As Boolean
    Private Sub AsistenciaAlumno_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call doQuery("select nroClase from clases")
        While result.Read
            cboNroClase.Items.Add(result(0))
        End While
    End Sub

    Private Sub cboNroClase_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboNroClase.SelectedIndexChanged
        cboAlumno.Items.Clear()
        Call doQuery("select nombre,apellido from alumnos where idalumno in (select idalumno from alumnoclase ac, clases c where ac.nroClase = c.nroClase and ac.nroclase = '" & cboNroClase.Text & "')")
        While result.Read
            cboAlumno.Items.Add(result(0) + " " + result(1))
        End While
    End Sub

    Private Sub btnAsistenciaAlumno_Click(sender As System.Object, e As System.EventArgs) Handles btnAsistenciaAlumno.Click
        validarIngreso()
        If ingresoValido Then
            Dim alumno As String() = cboAlumno.Text.Split(New Char() {" "c})
           
            doQuery("select idalumno from alumnos where nombre = '" & alumno(0) & "' and apellido = '" & alumno(1) & "'")
            If result.Read Then
                idAlumno = result(0)
            End If
            Dim estado As String
            If rdbAusente.Checked <> False Then
                estado = "Ausente"
                doQuery("insert into planilla_alumnos (nroClase, fecha, idAlumno,estado) values ('" & cboNroClase.Text & "','" & dtpFechaDocente.Text & "','" & idAlumno & "','" & estado & "')")
            End If
            If rdbPresente.Checked <> False Then
                estado = "Presente"
                doQuery("insert into planilla_alumnos (nroClase, fecha, idAlumno,estado) values ('" & cboNroClase.Text & "','" & dtpFechaDocente.Text & "','" & idAlumno & "','" & estado & "')")
            End If
            If rdbPresente.Checked <> False Then
                estado = "Tarde"
                doQuery("insert into planilla_alumnos (nroClase, fecha, idAlumno,estado) values ('" & cboNroClase.Text & "','" & dtpFechaDocente.Text & "','" & idAlumno & "','" & estado & "')")
            End If
            limpiar()
        End If
    End Sub

    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And cboAlumno.SelectedIndex <> -1 And cboNroClase.SelectedIndex <> -1 And (rdbAusente.Checked = True Or rdbPresente.Checked = True) Then
                MessageBox.Show("¡Asistencia registrada!", "Registro de Asistencia (Alumno)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ingresoValido = True
                Return ingresoValido
            ElseIf cboAlumno.SelectedIndex = -1 And cboNroClase.SelectedIndex <> -1 And (rdbAusente.Checked = True Or rdbPresente.Checked = True) Then
                MessageBox.Show("¡Error! Debe seleccionar un alumno.", "Registro de Asistencia (Alumno)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cboAlumno.SelectedIndex <> -1 And cboNroClase.SelectedIndex = -1 And (rdbAusente.Checked = True Or rdbPresente.Checked = True) Then
                MessageBox.Show("¡Error! Debe seleccionar el número de clase.", "Registro de Asistencia (Alumno)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cboAlumno.SelectedIndex <> -1 And cboNroClase.SelectedIndex <> -1 And (rdbAusente.Checked <> True Or rdbPresente.Checked <> True) Then
                MessageBox.Show("¡Error! Debe indicar si el alumno está presente o ausente.", "Registro de Asistencia (Alumno)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cboAlumno.SelectedIndex = -1 And cboNroClase.SelectedIndex = -1 And (rdbAusente.Checked <> True Or rdbPresente.Checked <> True) Then
                MessageBox.Show("¡Error! Debe completar todos los campos.", "Registro de Asistencia (Alumno)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("¡Error! Complete la información requerida.", "Registro de Asistencia (Alumno)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
        End Try
        Return False
    End Function

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        limpiar()
        Me.Hide()
        frmAdministrarAlumno.Show()
    End Sub

    Private Function limpiar()
        rdbAusente.Checked = False
        rdbPresente.Checked = False
        cboAlumno.SelectedIndex = -1
        cboNroClase.SelectedIndex = -1
        Return True
    End Function

End Class