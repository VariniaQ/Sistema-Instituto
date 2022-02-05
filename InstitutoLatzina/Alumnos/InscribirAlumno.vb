Imports System.Data.Odbc

Public Class frmInscribirAlumno
    Dim sexo As String
    Dim loc As Integer
    Dim pro As Integer
    Dim cla As Integer
    Dim ida As Integer

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click

        If rdbMasculino.Checked = False And rdbFemenino.Checked = False Or String.IsNullOrEmpty(txtApellido.Text) Or String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(cmbLocalidad.Text) Or String.IsNullOrEmpty(txtDomicilio.Text) Or String.IsNullOrEmpty(txtTelefono.Text) Or String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtDNI.Text) Or String.IsNullOrEmpty(txtEstado.Text) Or String.IsNullOrEmpty(cmbProfesiones.Text) Then
            If String.IsNullOrEmpty(txtApellido.Text) Then
                MsgBox("Ingrese un Apellido", , "Aviso")
                txtApellido.Text = ""
            End If
            If String.IsNullOrEmpty(txtNombre.Text) Then
                MsgBox("Ingrese un Nombre", , "Aviso")
                txtNombre.Text = ""
            End If
            If String.IsNullOrEmpty(cmbLocalidad.Text) Then
                MsgBox("Ingrese una Localidad", , "Aviso")
                cmbLocalidad.Text = ""
            End If
            If String.IsNullOrEmpty(txtDomicilio.Text) Then
                MsgBox("Ingrese un Domicilio", , "Aviso")
                txtDomicilio.Text = ""
            End If
            If String.IsNullOrEmpty(txtTelefono.Text) Then
                MsgBox("Ingrese un Número de Teléfono", , "Aviso")
                txtTelefono.Text = ""
            End If
            If String.IsNullOrEmpty(txtEmail.Text) Then
                MsgBox("Ingrese un Correo Electrónico", , "Aviso")
                txtEmail.Text = ""
            End If
            If String.IsNullOrEmpty(txtDNI.Text) Then
                MsgBox("Ingrese un DNI", , "Aviso")
                txtDNI.Text = ""
            End If
            If rdbMasculino.Checked = False And rdbFemenino.Checked = False Then
                MsgBox("Elija su Genero", , "Aviso")
            End If
            If String.IsNullOrEmpty(txtEstado.Text) Then
                MsgBox("Elija un Estado", , "Aviso")
                txtEstado.Text = ""
            End If
            If String.IsNullOrEmpty(cmbProfesiones.Text) Then
                MsgBox("Ingrese una Profesión", , "Aviso")
                cmbProfesiones.Text = ""
            End If
        Else
            If rdbMasculino.Checked Then
                sexo = "Masculino"
            End If
            If rdbFemenino.Checked Then
                sexo = "Femenino"
            End If
            doQuery("select codlocalidad from localidad where nombre = '" & cmbLocalidad.Text & "'")
            If result.Read Then
                loc = result(0)
            End If
            doQuery("select codprofesion from profesiones where nombre = '" & cmbProfesiones.Text & "'")
            If result.Read Then
                pro = result(0)
            End If
            doQuery("select NROCLASE from clases where codprofesion = '" & pro & "'")
            If result.Read Then
                cla = result(0)
            End If
            doQuery("insert into alumnos values ( '','" & txtApellido.Text & "', '" & txtNombre.Text & "', '" & loc & "', '" & txtDomicilio.Text & "',  " & CInt(txtTelefono.Text) & " , '" & txtEmail.Text & "', " & CInt(txtDNI.Text) & ", '" & sexo & "', '" & txtEstado.Text & "', false, null, null, null )")
            doQuery("select idalumno from alumnos where DNI = " & CInt(txtDNI.Text) & " And nombre = '" & txtNombre.Text & "' And Apellido = '" & txtApellido.Text & "'")
            If result.Read Then
                ida = result(0)
            End If
            doQuery("insert alumnoclase values( '" & cla & "', '" & ida & "' )")
            MsgBox("Datos Ingresados", , "Aviso")
            borrar()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        borrar()
        Me.Hide()
        frmAdministrarDatosdeAlumnos.Show()
    End Sub

    Function borrar()
        txtApellido.Text = ""
        txtNombre.Text = ""
        cmbLocalidad.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtDNI.Text = ""
        rdbMasculino.Checked = False
        rdbFemenino.Checked = False
        txtEstado.Text = ""
        cmbProfesiones.Items.Clear()
        Return True
    End Function

    Private Sub frmInscribirAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        doQuery("select nombre from Profesiones")

        While result.Read
            cmbProfesiones.Items.Add(result.GetString(0))
        End While

        doQuery("select nombre from Localidad")

        While result.Read
            cmbLocalidad.Items.Add(result.GetString(0))
        End While
    End Sub
End Class