Public Class frmAgregarDocentes
    Public idDocente As Integer
    Public codRangoDir As Integer
    Public codprofesion As Integer
    Dim nombreProfesion As String
    Dim ingresar As Boolean
    Dim genero As String
    Dim existe As Boolean

    Private Sub frmAgregarDocentes_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txtApellidoDocente.Select()
    End Sub


    Private Sub AgregarDocentes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpIngresoDocente.Format = DateTimePickerFormat.Custom
        dtpIngresoDocente.CustomFormat = "yyyy/MM/dd"

        txtApellidoDocente.Select()
        'agrega el nombre de la localidad al comboBox
        Dim localidad As String

        Call doQuery("select nombre from localidad")
        While result.Read
            localidad = result(0).ToString
            cboLocalidad.Items.Add(localidad)
        End While
        'agrega el nombre de la rangoDirectivo al comboBox
        Dim rangoD As String
        Call doQuery("select nombre from rangodirectivo")
        While result.Read
            rangoD = result(0)
            cboRangoDirectivo.Items.Add(rangoD)
        End While
        'agrega el nombre de las profesiones al comboBox
        Call doQuery("select nombre from profesiones")
        While result.Read
            nombreProfesion = result(0)
            cboProfesiones.Items.Add(nombreProfesion)
        End While
    End Sub

    Private Sub btnAgregarDocente_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarDocente.Click
        ingresar = False

        If rdbFemenino.Checked = True Then
            genero = "femenino"
        ElseIf rdbMasculino.Checked = True Then
            genero = "masculino"
        End If
        'verifica si el dni ingresado ya existe
        doQuery("select dni from usuario where dni='" & CInt(txtDni.Text) & "'")
        If result.Read Then
            existe = True
        End If

        validarIngreso()
        'el ingreso es valido
        If ingresar = True Then
            Call doQuery("select codLocalidad from localidad where nombre = '" & cboLocalidad.Text & "'")
            'guarda el codigo de localidad segun el nombre
            If result.Read Then
                codLocalidad = result(0)
            End If

            Call doQuery("select codprofesion from profesiones where nombre = '" & cboProfesiones.Text & "'")
            'guarda el codigo de profesion segun el nombre
            If result.Read Then
                codprofesion = result(0)
            End If

            Call doQuery("select codrangodir from rangodirectivo where nombre = '" & cboRangoDirectivo.Text & "'")
            'guarda el codigo de rangoDirectivo segun el nombre
            If result.Read Then
                codRangoDir = result(0)
            End If
            'inserta los datos ingresados
            Call doQuery("insert into docente (apellido, nombre, codLocalidad,domicilio,tel,email,dni,genero,fechaIng,codprofesion,codrangodir) values('" & txtApellidoDocente.Text & "','" & txtNombreDocente.Text & "','" & codLocalidad & "','" & txtDomicilio.Text & "','" & CInt(txtTelefono.Text) & "','" & txtEmail.Text & "','" & CInt(txtDni.Text) & "','" & genero & "','" & dtpIngresoDocente.Text & "','" & codprofesion & "','" & codRangoDir & "')")
            Call doQuery("insert into usuario (dni,contrasenia) values ('" & dniDocente & "','" & dniDocente & "' )")
            limpiar()
        End If
    End Sub

    Public Function validarIngreso()
        Try
            If Me.ValidateChildren And txtApellidoDocente.Text <> String.Empty And txtNombreDocente.Text <> String.Empty And cboLocalidad.Text <> String.Empty And txtDomicilio.Text <> String.Empty And txtTelefono.Text <> String.Empty And txtEmail.Text <> String.Empty And genero <> String.Empty And dtpIngresoDocente.Text <> String.Empty And cboProfesiones.Text <> String.Empty And cboRangoDirectivo.Text <> String.Empty And txtDni.Text <> String.Empty And txtEmail.Text.Contains("@") And existe = False Then
                MessageBox.Show("¡Docente registrado correctamente!", "Registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ingresar = True
                Return ingresar
            ElseIf txtApellidoDocente.Text = String.Empty And txtNombreDocente.Text = String.Empty And cboLocalidad.Text = String.Empty And txtDomicilio.Text = String.Empty And txtTelefono.Text = String.Empty And txtEmail.Text = String.Empty And genero = String.Empty And cboProfesiones.Text = String.Empty And cboRangoDirectivo.Text = String.Empty And txtDni.Text = String.Empty Then
                MessageBox.Show("¡Error! Debe completar los campos.", "Registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtApellidoDocente.Select()
            ElseIf (txtTelefono.Text.Length > 0) And txtApellidoDocente.Text <> String.Empty And txtNombreDocente.Text <> String.Empty And cboLocalidad.Text <> String.Empty And txtDomicilio.Text <> String.Empty And txtEmail.Text <> String.Empty And genero <> String.Empty And dtpIngresoDocente.Text <> String.Empty And cboProfesiones.Text <> String.Empty And cboRangoDirectivo.Text <> String.Empty And txtDni.Text.Length = 8 And txtEmail.Text.Contains("@") Then
                MessageBox.Show("¡Error! El teléfono no es válido", "Registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTelefono.Text = ""
                txtTelefono.Select()
            ElseIf (txtDni.Text.Length > 0) And txtApellidoDocente.Text <> String.Empty And txtNombreDocente.Text <> String.Empty And cboLocalidad.Text <> String.Empty And txtDomicilio.Text <> String.Empty And txtTelefono.Text <> String.Empty And txtEmail.Text <> String.Empty And genero <> String.Empty And dtpIngresoDocente.Text <> String.Empty And cboProfesiones.Text <> String.Empty And cboRangoDirectivo.Text <> String.Empty And txtEmail.Text.Contains("@") And txtTelefono.Text.Length = 10 Then
                MessageBox.Show("¡Error! El DNI no es válido", "Registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDni.Text = ""
                txtDni.Select()
            ElseIf existe And txtApellidoDocente.Text <> String.Empty And txtNombreDocente.Text <> String.Empty And cboLocalidad.Text <> String.Empty And txtDomicilio.Text <> String.Empty And txtEmail.Text <> String.Empty And genero <> String.Empty And dtpIngresoDocente.Text <> String.Empty And cboProfesiones.Text <> String.Empty And cboRangoDirectivo.Text <> String.Empty And txtDni.Text.Length = 8 And txtEmail.Text.Contains("@") Then
                MessageBox.Show("¡Error! El DNI ya está registrado", "Registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDni.Text = ""
                txtDni.Select()
            ElseIf (txtEmail.Text.Contains("@") = False) And txtApellidoDocente.Text <> String.Empty And txtNombreDocente.Text <> String.Empty And cboLocalidad.Text <> String.Empty And txtDomicilio.Text <> String.Empty And txtTelefono.Text <> String.Empty And genero <> String.Empty And dtpIngresoDocente.Text <> String.Empty And cboProfesiones.Text <> String.Empty And cboRangoDirectivo.Text <> String.Empty And txtDni.Text <> String.Empty And txtTelefono.Text.Length = 10 Then
                MessageBox.Show("¡Error! El mail no es válido", "Registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Text = ""
                txtEmail.Select()
            Else
                MessageBox.Show("¡Error! Debe ingresar la información correctamente", "Registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                limpiar()
            End If
        Catch ex As Exception
            limpiar()
            Return MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function limpiar()
        txtApellidoDocente.Select()
        txtApellidoDocente.Text = ""
        txtNombreDocente.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtDni.Text = ""
        rdbFemenino.Checked = False
        rdbMasculino.Checked = False
        dtpIngresoDocente.Text = ""
        cboLocalidad.SelectedIndex = -1
        cboProfesiones.SelectedIndex = -1
        cboRangoDirectivo.SelectedIndex = -1
        Return True
    End Function

    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click
        limpiar()
        Me.Hide()
        frmMenuDocente.Show()
    End Sub
End Class