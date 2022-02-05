Public Class Cuota

    Dim cuotasRestantes As Integer 'se usa para hacer la query una sola vez.
    Dim valorCuota As Decimal

    Public Function loadInfo()
        lblCredencial.Text = "Credencial: " + Pagos.credencial
        doQuery("select nombre, apellido from alumnos where idalumno = " + Pagos.credencial)
        If result.Read Then
            lblAlumno.Text = "Alumno: " + result(0) + " " + result(1)
        End If
        Recursos.command.Dispose()

        doQuery("select cuotasrestantes from alumnos where idalumno = " + Pagos.credencial)
        If result.Read Then
            lblCuotas.Text = "Cuotas restantes: " + result(0).ToString
            cuotasRestantes = CInt(result(0))
            For i As Double = 1 To result(0)
                cmbCant.Items.Add(i)
            Next
        End If
        Return True
    End Function

    Private Sub Cuota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbCant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCant.SelectedIndexChanged
        doQuery("select valorxcta from profesiones, clases, alumnos where alumnos.nroclase = clases.nroclase and clases.codprofesion = profesiones.codprofesion and alumnos.idalumno = 5;")
        If result.Read Then
            valorCuota = result(0)
            lblMonto.Text = "A pagar: " + ((result(0) * CInt(cmbCant.Text))).ToString + " AR$"
        End If
        btnContinuar.Enabled = True
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        doQuery("update alumnos set cuotasrestantes = " + (cuotasRestantes - CInt(cmbCant.Text)).ToString + " where idalumno = " + Pagos.credencial)
        doQuery("insert into pago values(''," + Pagos.credencial + ", curdate(), " + ((valorCuota * CInt(cmbCant.Text))).ToString + ", '" + txtReferencias.Text + "')")
        doQuery("select cuotaspagadas from alumnos where idalumno = " + Pagos.credencial)
        If result.Read Then
            doQuery("update alumnos set cuotaspagadas = " + (result(0) + CInt(cmbCant.Text)).ToString + " where idalumno = " + Pagos.credencial)
        End If

        MsgBox(cmbCant.Text.ToString + " cuota(s) pagada(s) exitosamente.", , "Aviso")
        reset()
        Me.Hide()
        frmMenuTesoreria.Show()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        reset()
        Me.Hide()
        Pagos.Show()
    End Sub

    Private Function reset()
        btnContinuar.Enabled = False
        cmbCant.Text = ""
        lblAlumno.Text = "Alumno:"
        lblCredencial.Text = "Credencial:"
        lblCuotas.Text = "Cuotas Restantes:"
        lblMonto.Text = "A pagar:"
        cmbCant.Items.Clear()

        valorCuota = 0
        cuotasRestantes = 0

        Return True
    End Function

    Private Sub lblMonto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMonto.Click

    End Sub

    Private Sub lblCant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCant.Click

    End Sub
End Class