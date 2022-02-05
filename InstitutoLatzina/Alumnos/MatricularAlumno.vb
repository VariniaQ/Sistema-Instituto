Imports System.Data.Odbc

Public Class frmMatricularAlumno
    Dim Num As Integer
    Dim bol As Integer
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        borrar()
        Me.Hide()
        frmAdministrarAlumno.Show()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtNCredencial.Text) Then
            If String.IsNullOrEmpty(txtNCredencial.Text) Then
                MsgBox("Ingrese un Número de Credencial", , "Aviso")
                txtNCredencial.Text = ""
                borrar()
            End If
        Else
            Num = CInt(txtNCredencial.Text)
            doQuery("select MATRICULACION from alumnos where idalumno = " & CInt(txtNCredencial.Text) & " ")
            If result.Read Then
                bol = result(0)
            End If

            If bol = 1 Then
                MsgBox("El Alumno ya Tiene Paga la Matriculación", , "Aviso")
                txtNCredencial.Text = ""
            Else
                doQuery("select a.Apellido from PAGO p, alumnos a where a.idalumno = p.idalumno And a.idalumno = " & CInt(txtNCredencial.Text) & " ")
                If result.Read Then
                    txtApellido.Text = ""
                    txtApellido.Visible = True
                    txtApellido.Text = result(0)
                End If
                doQuery("select a.Nombre from PAGO p, alumnos a where a.idalumno = p.idalumno And a.idalumno = " & CInt(txtNCredencial.Text) & " ")
                If result.Read Then
                    txtNombre.Text = ""
                    txtNombre.Visible = True
                    txtNombre.Text = result(0)
                End If
                doQuery("select p.Monto from PAGO p, alumnos a where a.idalumno = p.idalumno And a.idalumno = " & CInt(txtNCredencial.Text) & " ")
                If result.Read Then
                    txtMonto.Text = ""
                    txtMonto.Visible = True
                    txtMonto.Text = result(0)
                End If
                If String.IsNullOrEmpty(txtApellido.Text) Or txtApellido.Text = "." Then
                    MsgBox("El Alumno no fue Encontrado", , "Aviso")
                    borrar()
                Else
                    txtMonto.Visible = True
                    btnPagar.Enabled = True
                    btnPagar.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
            doQuery("Update ALUMNOS Set MATRICULACION = true where idalumno = '" & Num & "'")
            MsgBox("La Matriculación ha sido Pagada", , "Aviso")
            borrar()

    End Sub

    Function borrar()
        txtNCredencial.Text = ""
        txtApellido.Text = ""
        txtMonto.Text = ""
        txtNombre.Text = ""
        btnPagar.Enabled = False
        btnPagar.Visible = False
        txtApellido.Visible = False
        txtMonto.Visible = False
        txtNombre.Visible = False
        Return True
    End Function
End Class