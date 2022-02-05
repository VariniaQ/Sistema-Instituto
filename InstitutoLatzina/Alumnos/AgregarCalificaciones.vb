Public Class frmAgregarCalificaciones
    Dim Num As Integer
    Dim Cla As Integer

    Function borrar()
        txtNCredencial.Text = ""
        txtNombreT.Text = ""
        cmbProfesiones.Text = ""
        txtNota.Text = ""
        lblNombreT.Visible = False
        lblProfesion.Visible = False
        lblNota.Visible = False
        txtNombreT.Visible = False
        cmbProfesiones.Visible = False
        txtNota.Visible = False
        btnFinalizar.Visible = False
        cmbProfesiones.Items.Clear()
        Return True
    End Function

    Function aparecer()
        lblNombreT.Visible = True
        lblProfesion.Visible = True
        lblNota.Visible = True
        txtNombreT.Visible = True
        cmbProfesiones.Visible = True
        txtNota.Visible = True
        btnFinalizar.Visible = True
        btnFinalizar.Enabled = True
        Return True
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtNCredencial.Text) Then
            If String.IsNullOrEmpty(txtNCredencial.Text) Then
                MsgBox("Ingrese un Número de Credencial", , "Aviso")
                txtNCredencial.Text = ""
            End If
        Else
            Num = CInt(txtNCredencial.Text)
            doQuery("select P.Nombre from clases C, profesiones P, ALUMNOCLASE A Where p.CODPROFESION = c.CODPROFESION and A.NROCLASE = C.NROCLASE and A.IDALUMNO = " & CInt(txtNCredencial.Text) & "")

            While result.Read
                cmbProfesiones.Items.Add(result.GetString(0))
            End While
            aparecer()
        End If
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        If String.IsNullOrEmpty(txtNombreT.Text) Or String.IsNullOrEmpty(cmbProfesiones.Text) Or String.IsNullOrEmpty(txtNota.Text) Then
            If String.IsNullOrEmpty(txtNombreT.Text) Then
                MsgBox("Ingrese un Nombre", , "Aviso")
                txtNombreT.Text = ""
            End If
            If String.IsNullOrEmpty(cmbProfesiones.Text) Then
                MsgBox("Ingrese una Profesión", , "Aviso")
                cmbProfesiones.Text = ""
            End If
            If String.IsNullOrEmpty(txtNota.Text) Then
                MsgBox("Ingrese una Nota", , "Aviso")
                txtNota.Text = ""
            End If
        Else
            doQuery("select NROClase from profesiones p, Clases c where p.CODPROFESION = c.CODPROFESION And nombre = '" & cmbProfesiones.Text & "'")
            If result.Read Then
                Cla = result(0)
            End If
            doQuery("insert into Calificaciones values ( '','" & CInt(Cla) & "','" & Num & "', '" & txtNombreT.Text & "', " & CInt(txtNota.Text) & " )")
            MsgBox("Calificación Ingresada", , "Aviso")
            borrar()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        borrar()
        Me.Hide()
        frmAdministrarAlumno.Show()
    End Sub
End Class