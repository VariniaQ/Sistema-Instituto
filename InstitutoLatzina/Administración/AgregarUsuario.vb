Public Class frmAgregarUsuario
    Dim ingresado As Boolean

    Private Sub frmAgregarUsuario_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txtDni.Select()
    End Sub

    Private Sub frmAgregarUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtDni.Select()

        Call insertarEnGrilla("select * from usuario", "usuario")
        Me.dtgUsuarios.DataSource = ds.Tables("usuario")
        ds.Tables.Remove("usuario")
    End Sub

    Private Sub btnAgregarUsuario_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAgregarUsuario.Click
        Call validarIngreso()

        If ingresado = True Then

            doQuery("insert into usuario (dni,contrasenia) values ('" & CInt(txtDni.Text) & "','" & txtContraseña.Text & "')")

            Call insertarEnGrilla("select * from usuario", "usuario")
            Me.dtgUsuarios.DataSource = ds.Tables("usuario")
            ds.Tables.Remove("usuario")

            txtDni.Text = ""
            txtContraseña.Text = ""
        End If
    End Sub

    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And txtDni.Text <> String.Empty And txtContraseña.Text <> String.Empty And txtDni.Text.Length = 8 And (Val(txtDni.Text) <> 0 Or Val(txtDni.Text) < 99999999) Then
                MessageBox.Show("¡Datos ingresados correctamente!", "Registro usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ingresado = True

                Return ingresado
            ElseIf txtDni.Text = String.Empty And txtContraseña.Text = String.Empty Then
                MessageBox.Show("¡Error! Debe completar los campos.", "Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDni.Select()
                ingresado = False
            ElseIf (txtDni.Text.Length <> 8) And (txtDni.Text = "00000000" Or Val(txtDni.Text) > 99999999) Then
                MessageBox.Show("¡Error! El DNI no es válido", "Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ingresado = False
                txtDni.Text = ""
                txtContraseña.Text = ""
            Else
                MessageBox.Show("¡Error! Debe ingresar la información correctamente", "Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ingresado = False
                txtDni.Text = ""
                txtContraseña.Text = ""
            End If
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub btnVolver_Click_1(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        txtDni.Text = ""
        txtContraseña.Text = ""
        Me.Hide()
        frmMenuAdministrador.Show()
    End Sub



    Private Sub lblLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLocalidad.Click

    End Sub

End Class