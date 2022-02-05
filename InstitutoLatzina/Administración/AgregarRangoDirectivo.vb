Public Class frmAgregarRangoDirectivo

    Dim ingresado As Boolean

    Private Sub frmAgregarRangoDirectivo_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txtRangoDirectivo.Select()
    End Sub

    Private Sub frmAgregarRangoDirectivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtRangoDirectivo.Select()

        Call insertarEnGrilla("select * from rangodirectivo", "rangoD")
        Me.dtgRangoD.DataSource = ds.Tables("rangoD")
        ds.Tables.Remove("rangoD")
    End Sub

    Private Sub btnAgregarRango_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarRango.Click
        Call validarIngreso()
        
        If ingresado = True Then
            
            Call doQuery("insert into rangodirectivo (nombre) values('" & txtRangoDirectivo.Text & "')")

            Call insertarEnGrilla("select * from rangodirectivo", "rangoD")
            Me.dtgRangoD.DataSource = ds.Tables("rangoD")
            ds.Tables.Remove("rangoD")
            txtRangoDirectivo.Text = ""
            txtRangoDirectivo.Select()
        End If
    End Sub

    Private Sub btnVolver_Click_1(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        txtRangoDirectivo.Text = ""
        Me.Hide()
        frmMenuAdministrador.Show()
    End Sub
    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And txtRangoDirectivo.Text <> String.Empty Then
                MessageBox.Show("¡Datos ingresados correctamente!", "Registro de Rangos Directivos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ingresado = True
                Return ingresado
            Else
                MessageBox.Show("¡Error! Debe completar los campos.", "Registro de Rangos Directivos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRangoDirectivo.Text = ""
                txtRangoDirectivo.Select()
            End If

        Catch ex As Exception
            txtRangoDirectivo.Select()
            Return MsgBox(ex.Message)
        End Try
        Return False
    End Function

End Class