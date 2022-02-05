Public Class frmAgregarLicencias
    Dim ingresado As Boolean
    Dim limiteExcedido As Boolean

    Public Function cargarInfo()

        Call doQuery("select motivo from motivolicencia")
        cboMotivoLicencia.Items.Clear()
        Dim motivo As String
        While result.Read
            motivo = result(0)
            cboMotivoLicencia.Items.Add(motivo)
        End While

        doQuery("select iddocente, apellido, nombre from docente")
        While result.Read
            cboDocentes.Items.Add(result(0).ToString & " | " & result(1).ToString & ", " & result(2).ToString())
        End While

        Return True
    End Function

    Private Sub frmAgregarLicencias_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        dtpFechaLicencia.Format = DateTimePickerFormat.Custom
        dtpFechaLicencia.CustomFormat = "yyyy/MM/dd"
        cargarInfo()
        nudDuracion.Select()

    End Sub

    Private Sub btnLicencia_Click(sender As System.Object, e As System.EventArgs) Handles btnLicencia.Click
        If cboDocentes.SelectedIndex = -1 Then
            validarIngreso()
        Else
            doQuery("select iddocente from docente where iddocente ='" & cboDocentes.Text.Substring(0, 1) & "'")
            If result.Read Then
                idDocente = result(0)
            End If
            doQuery("select count(*) from licencia l, docente d where l.iddocente = d.iddocente and l.iddocente =(select iddocente from docente where iddocente ='" & idDocente & "')")
            If result.Read Then
                If (result(0) >= 2) Then
                    limiteExcedido = True
                    validarIngreso()
                Else
                    validarIngreso()

                    If ingresado Then

                        Call doQuery("select iddocente from docente where iddocente ='" & idDocente & "'")

                        If result.Read Then
                            idDocente = result(0)
                        End If

                        Dim duracion As String
                        duracion = (nudDuracion.Value).ToString + " " + cboTemporalidad.Text

                        Call doQuery("select codmotivo from MotivoLicencia where motivo ='" & cboMotivoLicencia.Text & "'")

                        If result.Read Then
                            codMotivo = result(0)
                        End If

                        Call doQuery("insert into licencia (idDocente,fechaEmision,duracion,codmotivo) values('" & idDocente & "','" & dtpFechaLicencia.Text & "','" & duracion & "','" & codMotivo & "')")

                    End If
                End If
            End If
        End If


        limpiar()
    End Sub

    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click
        limpiar()
        Me.Hide()
        frmMenuDocente.Show()
    End Sub

    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And cboTemporalidad.SelectedIndex <> -1 And nudDuracion.Value <> 0 And cboMotivoLicencia.SelectedIndex <> -1 And limiteExcedido <> True And cboDocentes.SelectedIndex <> -1 Then
                ingresado = True
                MessageBox.Show("¡La información ha sido ingresada correctamente!.", "Registro de Licencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return ingresado
            ElseIf nudDuracion.Value = 0 And cboTemporalidad.SelectedIndex <> -1 And cboMotivoLicencia.SelectedIndex <> -1 And limiteExcedido <> True Then
                MessageBox.Show("¡Error! Debe ingresar un número mayor a 0.", "Registro de Licencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                nudDuracion.Value = 0
                cboTemporalidad.SelectedIndex = -1
                cboMotivoLicencia.SelectedIndex = -1
            ElseIf limiteExcedido And cboTemporalidad.SelectedIndex <> -1 And cboMotivoLicencia.SelectedIndex <> -1 And nudDuracion.Value <> 0 Then
                limpiar()
                MessageBox.Show("¡Error! No puede cargar más de 2 licencias.", "Registro de Licencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("¡Error! Debe completar los campos.", "Registro de Licencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiar()
            End If

        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub nudDuracion_LostFocus(sender As Object, e As System.EventArgs) Handles nudDuracion.LostFocus
        If nudDuracion.Value = 1 Then
            cboTemporalidad.Items.Clear()
            cboTemporalidad.Items.Add("dia")
            cboTemporalidad.Items.Add("semana")
            cboTemporalidad.Items.Add("mes")
        Else
            cboTemporalidad.Items.Clear()
            cboTemporalidad.Items.Add("dias")
            cboTemporalidad.Items.Add("semanas")
            cboTemporalidad.Items.Add("meses")
        End If
    End Sub

    Public Function limpiar()
        nudDuracion.Value = 0
        cboTemporalidad.SelectedIndex = -1
        cboMotivoLicencia.SelectedIndex = -1
        cboDocentes.SelectedIndex = -1
        nudDuracion.Select()
        Return True
    End Function
End Class