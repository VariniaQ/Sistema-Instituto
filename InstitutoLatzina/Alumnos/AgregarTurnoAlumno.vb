Public Class frmAgregarTurnoAlumno
    Dim pro As Integer
    Private Sub frmAgregarTurnoAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        doQuery("select nombre from PROFESIONES")

        While result.Read
            cmbProfesiones.Items.Add(result.GetString(0))
        End While
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtTelefono.Text) Or String.IsNullOrEmpty(txtDNI.Text) Or String.IsNullOrEmpty(cmbProfesiones.Text) Then
            If String.IsNullOrEmpty(txtApellido.Text) Then
                MsgBox("Ingrese un Apellido", , "Aviso")
                txtApellido.Text = ""
            End If
            If String.IsNullOrEmpty(txtNombre.Text) Then
                MsgBox("Ingrese un Nombre", , "Aviso")
                txtNombre.Text = ""
            End If
            If String.IsNullOrEmpty(txtDNI.Text) Then
                MsgBox("Ingrese un DNI", , "Aviso")
                txtDNI.Text = ""
            End If
            If String.IsNullOrEmpty(txtTelefono.Text) Then
                MsgBox("Ingrese un Número de Teléfono", , "Aviso")
                txtTelefono.Text = ""
            End If
            If String.IsNullOrEmpty(cmbProfesiones.Text) Then
                MsgBox("Ingrese una Profesión", , "Aviso")
                cmbProfesiones.Text = ""
            End If
        Else
            doQuery("select codprofesion from profesiones where nombre = '" & cmbProfesiones.Text & "'")
            If result.Read Then
                pro = result(0)
            End If
            doQuery("insert into TrnINSCRIPCIONES values ( '','" & dtpFecha.Value & "', '" & dtpHora.Text & "', " & CInt(txtDNI.Text) & ", '" & txtApellido.Text & "', '" & txtNombre.Text & "',  " & CInt(txtTelefono.Text) & ",  '" & pro & "' )")
            MsgBox("El Turno ha sido Ingresado", , "Aviso")
            borrar()
        End If
    End Sub

    Function borrar()
        txtApellido.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtDNI.Text = ""
        cmbProfesiones.Items.Clear()
        Return True
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Hide()
        frmAdministrarTurnos.Show()
        borrar()
    End Sub
End Class