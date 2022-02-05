Public Class frmAsistenciaDocente
    Dim valido As Boolean

    Public Function cargarInfo()

        doQuery("select iddocente,apellido,nombre from docente")

        While result.Read
            cboDocente.Items.Clear()
            cboDocente.Items.Add(result(0) & " | " & result(1) & ", " & result(2))
        End While

        Return True
    End Function

    Private Sub frmAsistenciaDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        dtpFechaDocente.Format = DateTimePickerFormat.Custom
        dtpFechaDocente.CustomFormat = "yyyy/MM/dd"

        cboTurno.Items.Add("Matutino")
        cboTurno.Items.Add("Vespertino")
        cboTurno.Items.Add("Nocturno")

    End Sub

    Private Sub btnAsistenciaDocente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'se valida el ingreso de los datos
        Call validarIngreso()
        'es valido
        If valido Then
            Dim codPlanilla As Integer
            Dim fecha
            Dim estado As String
            idDocente = cboDocente.Text.Substring(0, 1)
            'guardamos la fecha y el turno de la planilla
            doQuery("select fecha,turno from planilla where fecha='" & dtpFechaDocente.Text & "' and turno = '" & cboTurno.Text & "'")
            If result.Read Then
                fecha = result(0)
                doQuery("select codplanilla from planilla where fecha='" & fecha & "'")
                If result.Read Then
                    codPlanilla = result(0)
                End If
            Else
                'no existe una planilla con esos datos
                'creamos una planilla con los datos cargados
                doQuery("insert into planilla (fecha,turno) values('" & dtpFechaDocente.Text & "','" & cboTurno.Text & "')")
                doQuery("select codplanilla from planilla where fecha='" & dtpFechaDocente.Text & "' and turno = '" & cboTurno.Text & "'")
                If result.Read Then
                    codPlanilla = result(0)
                End If
            End If

            If rdbPresente.Checked = True Then
                estado = "presente"
                doQuery("insert into planillaDlle (codPlanilla,idDocente,horaLlegada,estado) values ('" & codPlanilla & "','" & idDocente & "','" & dtpHoraEntrada.Text & "','" & estado & "')")
            Else : rdbAusente.Checked = True
                estado = "ausente"
                doQuery("insert into planillaDlle (codPlanilla,idDocente,estado) values ('" & codPlanilla & "','" & idDocente & "','" & estado & "')")
            End If

        End If
        limpiar()
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        Me.Hide()
        frmMenuDocente.Show()
    End Sub

    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And cboDocente.Text <> String.Empty And cboTurno.Text <> String.Empty And (rdbPresente.Checked = True Or rdbAusente.Checked = True) And dtpHoraEntrada.Text <> String.Empty Then
                MessageBox.Show("¡La asistencia ha sido registrado correctamente!", "Registro de asistencia (Docentes)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                valido = True
                Return valido
            Else
                MessageBox.Show("¡Error! Debe ingresar la información correctamente", "Registro de asistencia (Docentes)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try
        Return False
    End Function
    Public Function limpiar()
        cboDocente.SelectedIndex = -1
        cboTurno.SelectedIndex = -1
        dtpFechaDocente.Text = ""
        dtpHoraDocente.Text = ""
        dtpHoraEntrada.Text = ""
        rdbAusente.Checked = False
        rdbPresente.Checked = False
        Return True
    End Function

    Private Sub rdbAusente_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdbAusente.CheckedChanged
        dtpHoraEntrada.Enabled = False
    End Sub

    Private Sub rdbPresente_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdbPresente.CheckedChanged
        dtpHoraEntrada.Enabled = True
    End Sub
End Class