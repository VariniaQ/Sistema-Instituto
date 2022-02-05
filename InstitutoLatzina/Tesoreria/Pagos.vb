Public Class Pagos

    Public credencial As String 'Es más fácil de manipular como string que como int. Dejenlo así.

    Private Sub rdbMatricula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMatricula.CheckedChanged
        doQuery("select * from alumnos")
        result.Read()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Hide()
        frmMenuTesoreria.Show()
        reset()
    End Sub

    Private Sub gpbPago_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpbPago.Enter
        btnContinuar.Enabled = True
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        credencial = txtCredencial.Text
        If verificarCredencial(credencial) Then
            If rdbCuota.Checked Then
                doQuery("select cuotasrestantes from alumnos where idalumno = " + credencial)
                If result.Read Then
                    If result(0) > 0 Then
                        Me.Hide()
                        reset()
                        Cuota.loadInfo()
                        Cuota.Show()
                    Else
                        MsgBox("Este alumno ya pagó todas las cuotas", , "Aviso")
                    End If
                End If
            Else
                doQuery("select matriculacion from alumnos where idalumno = " + credencial)
                If result.Read Then
                    If result(0) = False Then
                        Me.Hide()
                        reset()
                        Matricula.loadInfo()
                        Matricula.Show()
                    Else
                        MsgBox("Este alumno ya está matriculado", , "Aviso")
                    End If
                End If


            End If
        Else
            MsgBox("Credencial inválida.", , "Aviso")
        End If
    End Sub


    Private Function reset()
        btnContinuar.Enabled = False
        rdbCuota.Checked = False
        rdbMatricula.Checked = False
        Return True
    End Function

    Private Function verificarCredencial(ByVal inputCredencial)
        doQuery("select idalumno from alumnos")
        Dim valido As Boolean = False
        While result.Read
            If result(0).ToString = inputCredencial Then
                valido = True
            End If
        End While
        Recursos.command.Dispose()

        Return valido

    End Function
End Class