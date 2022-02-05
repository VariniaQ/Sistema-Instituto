Public Class Caja

    Function clear()
        list.Items.Clear()

        Return True
    End Function

    Private Sub btnDiaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiaria.Click
        doQuery("select codpagom, fecha, monto from pagomatricula where fecha = curdate()")
        While result.Read
            list.Items.Add("MATRICULA | " & result(0) & " | " & result(1).ToString & " | " & result(2) & "$")
        End While
        doQuery("select codpagom, fecha, monto from pagomatricula where fecha = curdate()")
        While result.Read
            list.Items.Add("MATRICULA | " & result(0) & " | " & result(1).ToString & " | " & result(2) & "$")
        End While
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenuTesoreria.Show()
    End Sub
End Class