Public Class Matricula

    Dim monto As Decimal

    Public Function loadInfo()
        doQuery("select nombre from profesiones")
        While result.Read
            cmbProfesion.Items.Add(result(0).ToString())
        End While
        Recursos.command.Dispose()

        lblCredencial.Text = "Credencial: " + Pagos.credencial
        doQuery("select nombre, apellido from alumnos where idalumno = " + Pagos.credencial)
        If result.Read Then
            lblAlumno.Text = "Alumno: " + result(0) + " " + result(1)
        End If
        Recursos.command.Dispose()

        Return True
    End Function


    Private Sub cmbProfesion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProfesion.SelectedIndexChanged
        doQuery("select cstmatricula from profesiones where nombre = '" + cmbProfesion.Text + "'")
        If result.Read Then
            lblMonto.Text = "A pagar: " + result(0).ToString + " AR$"
            monto = result(0)
            btnContinuar.Enabled = True
        End If
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        doQuery("insert into pago values(''," + Pagos.credencial + ", curdate(), " + monto.ToString + ", '" + txtReferencias.Text + "')")
        doQuery("update alumnos set matriculacion = true where idalumno =" + Pagos.credencial)
        MsgBox("Alumno matriculado exitosamente", , "Aviso")
        reset()
        Me.Hide()
        frmMenuTesoreria.Show()

    End Sub

    Private Function reset()
        cmbProfesion.Text = ""
        btnContinuar.Enabled = False
        lblAlumno.Text = "Alumno:"
        lblMonto.Text = "A pagar:"
        lblCredencial.Text = "Credencial:"
        monto = 0
        Return True 'para sacar el warning
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        reset()
        Me.Hide()
        Pagos.Show()
    End Sub
End Class