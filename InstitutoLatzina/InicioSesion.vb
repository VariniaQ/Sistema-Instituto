Public Class frmLogin

    Dim ingresado As Boolean
    Dim existe As Boolean
    Dim eleccion As Integer

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtDni.Select()
        Call OdbcConexion.connect("Instituto")
    End Sub

    Private Sub btnIniciarSesion_Click_1(sender As System.Object, e As System.EventArgs) Handles btnIniciarSesion.Click
        existe = False

        If String.IsNullOrEmpty(txtDni.Text) Then
            Call validarIngreso()
        Else
            dniDocente = CInt(txtDni.Text)
            Call doQuery("select dni from usuario where dni= '" & dniDocente & "' and contrasenia= '" & txtContraseña.Text & "'")

            If result.Read Then
                existe = True
            End If

            Call validarIngreso()
        End If

        If ingresado And existe Then
            frmMenuPrincipal.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub rdbAdmin_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtDni.Select()
    End Sub

    Private Sub rdbAlumno_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtDni.Select()
    End Sub

    Private Sub rdbDocente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtDni.Select()
    End Sub

    Private Sub btnSalir_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And txtDni.Text <> String.Empty And txtContraseña.Text <> String.Empty And txtDni.Text.Length > 0 And existe = True Then
                ingresado = True
                txtDni.Text = ""
                txtContraseña.Text = ""
                Return ingresado
            ElseIf Me.ValidateChildren And (txtDni.Text = String.Empty And txtContraseña.Text = String.Empty) Or (txtDni.Text <> String.Empty And txtContraseña.Text = String.Empty) Or (txtDni.Text = String.Empty And txtContraseña.Text <> String.Empty) And ingresado = False Then
                MessageBox.Show("¡Error! Debe completar los campos.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If txtDni.Text = String.Empty Then
                    txtDni.Select()
                Else
                    txtContraseña.Select()
                End If
            ElseIf existe = False Then
                MessageBox.Show("¡Error! Datos incorrectos. Vuelva a ingresar", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDni.Select()
                txtDni.Text = ""
                txtContraseña.Text = ""
            End If

        Catch ex As Exception
        End Try
        Return False
    End Function

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
