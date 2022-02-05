Public Class frmMenuTesoreria

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenuPrincipal.Show()
    End Sub

    Private Sub BtnPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPagos.Click
        Me.Hide()
        Pagos.Show()
    End Sub

    Private Sub BtnCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCajas.Click
        Me.Hide()
        Caja.Show()
    End Sub

    Private Sub btnVerMontoSueldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerMontoSueldo.Click
        Me.Hide()
        frmVerMontoTotalSueldo.Show()
    End Sub

    Private Sub btnLiquidarProfesor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiquidarProfesor.Click
        Me.Hide()
        frmLiquidarDocente.Show()
    End Sub
End Class