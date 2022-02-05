Public Class frmEditarAsistenciaDocente
    Dim codPlanillaDlle As Integer
    Dim horarioCompleto As Boolean
    Dim clickGrid As Boolean
    Private Sub frmEditarAsistenciaDocente_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        cboDniDocente.Items.Clear()
        Call doQuery("select distinct d.dni from docente d, planilladlle pl where d.iddocente=pl.iddocente and horaretiro is NULL and estado = 'presente'")
        Dim dniDocente As Integer
        While result.Read
            horarioCompleto = False
            dniDocente = result(0)
            cboDniDocente.Items.Add(dniDocente)
        End While
    End Sub

    Private Sub cboDniDocente_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboDniDocente.SelectedIndexChanged
        insertarEnGrilla("select  CODPLANILLADLLE, PL.IDDOCENTE, HORALLEGADA, HORARETIRO, ESTADO from planilladlle pl, docente d where pl.iddocente=d.iddocente and pl.iddocente= (select iddocente from docente where dni='" & cboDniDocente.Text & "') and horaretiro is NULL and estado = 'presente' ", "planilladlle")
        Me.dtgLicencias.DataSource = ds.Tables("planilladlle")
        ds.Tables.Remove("planilladlle")
        'muestra las horas de retiro que tengan valor nulo y sean de un docente presente
        doQuery("select horaretiro from planilladlle pl, docente d where horaretiro is NULL and pl.iddocente=d.iddocente and pl.iddocente= (select iddocente from docente where dni='" & cboDniDocente.Text & "') and horaretiro is NULL and estado = 'presente'")
        If result.Read Then
            Label3.Visible = True
            Label4.Visible = True
            lblApellido.Visible = True
            lblNombre.Visible = True
            dtgLicencias.Visible = True
            dtpHorarioSalida.Visible = True
            btnEditar.Visible = True

            doQuery("select apellido, nombre from planilladlle pl, docente d where pl.iddocente=d.iddocente and horaretiro is NULL and pl.iddocente= (select iddocente from docente where dni='" & cboDniDocente.Text & "') and horaretiro is NULL and estado = 'presente'")
            If result.Read Then
                lblApellido.Text = result(0)
                lblNombre.Text = result(1)
            End If

            insertarEnGrilla("select CODPLANILLADLLE, HORALLEGADA, HORARETIRO, ESTADO from planilladlle pl, docente d where pl.iddocente=d.iddocente and pl.iddocente= (select iddocente from docente where dni='" & cboDniDocente.Text & "') and horaretiro is NULL and estado = 'presente' ", "planilladlle")
            Me.dtgLicencias.DataSource = ds.Tables("planilladlle")
            ds.Tables.Remove("planilladlle")

        End If
    End Sub

    Private Sub dtgLicencias_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgLicencias.CellClick
        Dim incorrecto As Boolean
        clickGrid = False
        Do
            Try
                incorrecto = False
                Dim columnIndex = dtgLicencias.CurrentCell.ColumnIndex
                If (dtgLicencias.Columns(columnIndex).Name <> "CODPLANILLADLLE") Then
                    MessageBox.Show("Debe seleccionar algún elemento de la columna 'CODPLANILLADLLE'", "Editar hora de retiro (Docente)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    incorrecto = True
                End If
                If (dtgLicencias.SelectedCells.Count = 1) And dtgLicencias.Columns(columnIndex).Name = "CODPLANILLADLLE" Then
                    codPlanillaDlle = dtgLicencias.CurrentRow.Cells(0).Value
                    incorrecto = False
                    clickGrid = True
                End If
                incorrecto = False
            Catch ex As Exception
                MsgBox("Columna incorrecta")
            End Try
        Loop While (incorrecto)
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        If clickGrid Then
            doQuery("update planillaDlle set horaRetiro = '" & dtpHorarioSalida.Value.TimeOfDay.ToString & "' where codPlanillaDlle = '" & codPlanillaDlle & "'")
            MessageBox.Show("La hora de retiro del Docente ha sido actualizada éxitosamente.", "Editar hora de retiro (Docente)", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
        Else
            MessageBox.Show("Debe seleccionar algún elemento de la columna 'CODPLANILLADLLE'", "Editar hora de retiro (Docente)", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        limpiar()
        Me.Hide()
        frmMenuDocente.Show()
    End Sub
    Public Function limpiar()
        dtpHorarioSalida.Text = ""
        dtgLicencias.Visible = False
        dtpHorarioSalida.Visible = False
        btnEditar.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        lblApellido.Text = ""
        lblNombre.Text = ""
        lblApellido.Visible = False
        lblNombre.Visible = False
        Return True
    End Function
End Class