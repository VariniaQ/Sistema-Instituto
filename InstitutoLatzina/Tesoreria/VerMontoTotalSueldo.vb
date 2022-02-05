Public Class frmVerMontoTotalSueldo

    Private Sub frmVerMontoTotalSueldo_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        cboDniDocente.SelectedIndex = -1
        dtgMontoTotal.Visible = False
    End Sub

    Private Sub VerMontoTotalSueldo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call doQuery("select distinct dni from docente d, recibo r, recibodlle rd where rd.codrecibo=r.codrecibo and r.iddocente=d.iddocente")
        While result.Read
            cboDniDocente.Items.Add(result(0))
        End While
    End Sub

    Private Sub cboDniDocente_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboDniDocente.SelectedValueChanged
        dtgMontoTotal.Visible = True

        Call insertarEnGrilla("select * from recibo where iddocente= (select iddocente from docente where dni = '" & cboDniDocente.Text & "')", "reciboDlle")
        Me.dtgMontoTotal.DataSource = ds.Tables("reciboDlle")
        ds.Tables.Remove("reciboDlle")

    End Sub
    Private Sub btnRegresarMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresarMenu.Click
        Me.Hide()
        frmMenuTesoreria.Show()
    End Sub

End Class