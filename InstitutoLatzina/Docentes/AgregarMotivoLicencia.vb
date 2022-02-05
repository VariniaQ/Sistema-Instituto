Public Class frmAgregarMotivoLicencia
    Dim ingresado As Boolean

    Private Sub frmAgregarMotivoLicencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtMotivoLicencia.Select()

        Call insertarEnGrilla("select * from MotivoLicencia", "motivoL")
        Me.dtgMotivo.DataSource = ds.Tables("motivoL")
        ds.Tables.Remove("motivoL")
    End Sub

    Private Sub btnAgregarMotivo_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarMotivo.Click
        Call validarIngreso()
       
        If (ingresado) Then
            If codMotivo = 0 Then
                codMotivo = 1
            End If

            Call doQuery("insert into MotivoLicencia (motivo) values('" & txtMotivoLicencia.Text & "')")

            Call insertarEnGrilla("select * from MotivoLicencia", "motivoL")
            Me.dtgMotivo.DataSource = ds.Tables("motivoL")

            txtMotivoLicencia.Text = ""

        End If
    End Sub

    Private Sub btnVolver_Click_1(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenuDocente.Show()
    End Sub

    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And txtMotivoLicencia.Text <> String.Empty Then
                MessageBox.Show("¡Datos ingresados correctamente!", "Registro de Motivos de Licencias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ingresado = True
                Return ingresado
            Else
                MessageBox.Show("¡Error! Debe completar los campos.", "Registro de Motivos de Licencias", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMotivoLicencia.Text = ""
            End If

        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try

        Return False
    End Function

End Class