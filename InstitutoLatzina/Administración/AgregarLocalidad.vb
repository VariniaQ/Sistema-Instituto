Public Class frmAgregarLocalidad
    Dim ingresado As Boolean

    Private Sub frmAgregarLocalidad_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txtLocalidad.Select()
    End Sub

    Private Sub frmAgregarLocalidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtLocalidad.Select()

        Call insertarEnGrilla("select * from localidad", "localidad")
        Me.dtgLocalidad.DataSource = ds.Tables("localidad")
        ds.Tables.Remove("localidad")
    End Sub


    Private Sub btnAgregarLocalidad_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarLocalidad.Click
        Call validarIngreso()

        If ingresado = True Then
          
            Call doQuery("insert into localidad (nombre) values('" & txtLocalidad.Text & "')")

            Call insertarEnGrilla("select * from localidad", "localidad")
            Me.dtgLocalidad.DataSource = ds.Tables("localidad")
            ds.Tables.Remove("localidad")

            txtLocalidad.Text = ""
            txtLocalidad.Select()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        txtLocalidad.Text = ""
        Me.Hide()
        frmMenuAdministrador.Show()
    End Sub

    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And txtLocalidad.Text <> String.Empty Then
                MessageBox.Show("¡Datos ingresados correctamente!", "Registro de Localidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ingresado = True
                Return ingresado
            Else
                MessageBox.Show("¡Error! Debe completar los campos.", "Registro de Localidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLocalidad.Text = ""
                txtLocalidad.Select()
            End If

        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try

        Return False
    End Function

End Class