Public Class frmReinscribirAlumno
    Dim Num As Integer
    Dim ida As Integer
    Dim pro As Integer
    Dim cla As Integer
    Function borrar()
        txtNCredencial.Text = ""
        cmbProfesiones.Visible = False
        cmbProfesiones.Enabled = False
        btnActualizar.Visible = False
        btnActualizar.Enabled = False
        cmbProfesiones.Items.Clear()
        Return True
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtNCredencial.Text) Then
            If String.IsNullOrEmpty(txtNCredencial.Text) Then
                MsgBox("Ingrese un Número de Credencial", , "Aviso")
                txtNCredencial.Text = ""
            End If
        Else
            doQuery("select idalumno from alumnoclase where idalumno = " & CInt(txtNCredencial.Text) & " ")
            If result.Read Then
                ida = result(0)
            End If
            cmbProfesiones.Visible = True
            cmbProfesiones.Enabled = True
            btnActualizar.Visible = True
            btnActualizar.Enabled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        borrar()
        Me.Hide()
        frmAdministrarDatosdeAlumnos.Show()
    End Sub

    Private Sub frmReinscribirAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        doQuery("select nombre from Profesiones")

        While result.Read
            cmbProfesiones.Items.Add(result.GetString(0))
        End While

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        doQuery("select codprofesion from profesiones where nombre = '" & cmbProfesiones.Text & "'")
        If result.Read Then
            pro = result(0)
        End If
        doQuery("select NROCLASE from clases where codprofesion = '" & pro & "'")
        If result.Read Then
            cla = result(0)
        End If
        doQuery("Delete from alumnoclase where idalumno = '" & ida & "'")
        doQuery("insert alumnoclase values( '" & cla & "', '" & ida & "' )")
        MsgBox("Datos Actualizados", , "Aviso")
        borrar()
    End Sub
End Class