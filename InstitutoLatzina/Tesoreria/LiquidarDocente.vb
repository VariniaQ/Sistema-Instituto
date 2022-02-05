Public Class frmLiquidarDocente
    Dim ingresoValido As Boolean
    Dim codRecibo As Integer
    Dim existe As Boolean
    Dim fecha
    Dim finalizarCarga As Boolean

    Private Sub frmSueldoDocente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "yyyy/MM/dd"
        cboDocenteDni.Select()

        Call doQuery("select dni from docente")
        While result.Read
            cboDocenteDni.Items.Add(result(0))
        End While
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        If String.IsNullOrEmpty(cboDocenteDni.Text) Then
            Call validarIngreso()
        Else
            'busca si existe alguna fecha de recibo que coincida con el dni seleccionado,tenga la misma fecha y que haya sido ingresado anteriormente
            doQuery("select fecha,r.iddocente from recibo r, docente d where d.idDocente=r.iddocente and r.iddocente =(select iddocente from docente where dni='" & cboDocenteDni.Text & "')")
            If result.Read Then
                fecha = result(0)
                idDocente = result(1)
                ' compara con la fecha del nuevo recibo
                If CBool(DateTime.Compare(CDate(fecha), dtpFecha.Value)) Then
                    'si son iguales, guarda el codrecibo de ese recibo 
                    doQuery("select codrecibo from recibo r, docente d where d.idDocente=r.iddocente and r.iddocente=(select iddocente from docente where dni='" & cboDocenteDni.Text & "')")
                    If result.Read Then
                        codRecibo = CInt(result(0))
                    End If
                    'la fecha es de un mes anterior, pero los días coinciden
                ElseIf (fecha.Month.CompareTo(dtpFecha.Value.Month + 1)) And (dtpFecha.Value.Day.CompareTo(fecha.Day)) Then
                    doQuery("insert into recibo (idDocente,fecha,hora,periodoPago) values('" & idDocente & "','" & dtpFecha.Text & "','" & dtpHora.Text & "','" & lblPeriodoPago.Text & "')")
                    doQuery("select codRecibo from recibo where fecha = '" & dtpFecha.Text & "' and hora = '" & dtpHora.Text & "'")
                    If result.Read Then
                        codRecibo = CInt(result(0))
                    End If
                End If

                If dtpFecha.Value.Month.CompareTo(fecha.Month) And (dtpFecha.Value.Day > (fecha.Day)) Then
                    MessageBox.Show("No puede realizarse el ingreso de datos. La liquidación debe realizarse mensualmente", "Liquidación de sueldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                existe = True
                doQuery("insert into recibodlle (codRecibo,referencia,subtotal) values('" & codRecibo & "','" & txtReferencia.Text & "','" & CInt(txtSubTotal.Text) & "')")
                Call validarIngreso()
                finalizarCarga = False
                cboDocenteDni.SelectedIndex = -1
                txtReferencia.Text = ""
                txtSubTotal.Text = ""
            Else
                Call validarIngreso()
                If ingresoValido Then
                    doQuery("select iddocente from docente where dni='" & CInt(cboDocenteDni.Text) & "'")
                    If result.Read Then
                        idDocente = CInt(result(0))
                    End If
                    'verifica si la existencia de un recibo con la misma fecha y idDocente. En ambos, almacena el codRecibo
                    doQuery("select codRecibo from recibo where fecha = '" & dtpFecha.Text & "' and idDocente = '" & idDocente & "'")
                    If result.Read Then
                        codRecibo = CInt(result(0))
                    Else
                        'Si no hay uno igual, se creo un nuevo recibo
                        doQuery("insert into recibo (idDocente,fecha,hora,periodoPago) values('" & idDocente & "','" & dtpFecha.Text & "','" & dtpHora.Text & "','" & lblPeriodoPago.Text & "')")
                        doQuery("select codRecibo from recibo where fecha = '" & dtpFecha.Text & "' and idDocente = '" & idDocente & "'")
                        If result.Read Then
                            codRecibo = CInt(result(0))
                        End If
                    End If

                    doQuery("insert into recibodlle (codRecibo,referencia,subtotal) values('" & codRecibo & "','" & txtReferencia.Text & "','" & CInt(txtSubTotal.Text) & "')")
                    finalizarCarga = False
                    cboDocenteDni.SelectedIndex = -1
                    txtReferencia.Text = ""
                    txtSubTotal.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As System.Object, e As System.EventArgs) Handles btnFinalizar.Click
        finalizarCarga = True
        MessageBox.Show("Si desea ver el monto total, regresé al menú y haga click en: 'Mostrar Monto Total' ", "Liquidación de sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim montoTotal As Integer
        doQuery("select subtotal from recibodlle where codRecibo='" & codRecibo & "'")

        While result.Read
            montoTotal += result(0)
        End While

        doQuery("select sueldobase from sueldo where codRangoDir = (select codRangoDir from docente where idDocente = '" & idDocente & "') ")

        If result.Read Then
            montoTotal += result(0)
        End If

        Dim sueldoBase
        doQuery("select sueldobase from sueldo s, docente d where d.codrangodir = s.codrangodir and iddocente='" & idDocente & "'")
        If result.Read Then
            sueldoBase = result(0)

            doQuery("select  count(*) from planilladlle where iddocente='" & idDocente & "' and estado='ausente' ")

            If result.Read Then
                Dim cantAusencias = result(0)
                montoTotal -= cantAusencias * ((sueldoBase / 30)) * 2
                MsgBox(montoTotal)
                'si se ha ausentado, deberá contarse la cantidad de días ausente y descontarlo del sueldo
            Else
                doQuery("select count(*) from licencia l, recibo r, docente d where l.iddocente = d.iddocente and r.iddocente = d.iddocente and month(l.fecha)=month(r.fecha) and fechaemision < fecha")
                If result.Read Then
                    Dim cantLicencias = result(0)
                    'si tiene ausencias justificadas ->  se descuenta presentismo de ese día.
                    montoTotal -= ((sueldoBase * 0.2) / 30) * cantLicencias
                    MsgBox(montoTotal)
                    MsgBox("Se le descuenta presentismo por tener '" & cantLicencias & "' faltas justificadas")
                Else
                    'si no se ha ausentado, se le dara +20% de presentismo
                    montoTotal += sueldoBase * 0.2
                    MsgBox("Se otorga +20% por presentismo")
                End If

            End If
            ' descontar del montototal -3% (OS), -11%(jubilacion)
            montoTotal -= sueldoBase * 0.14

        End If
        doQuery("update recibo set montoTotal = '" & montoTotal & "'  where codRecibo = '" & codRecibo & "'")

        existe = False

        cboDocenteDni.SelectedIndex = -1
        txtReferencia.Text = ""
        txtSubTotal.Text = ""
    End Sub
   
    Public Function validarIngreso()
        Try
            If cboDocenteDni.Text <> String.Empty And txtReferencia.Text <> String.Empty And txtSubTotal.Text <> String.Empty Then
                MessageBox.Show("¡Datos ingresados correctamente!", "Liquidación de sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ingresoValido = True
                Return ingresoValido
            ElseIf cboDocenteDni.Text = String.Empty And txtReferencia.Text = String.Empty And txtSubTotal.Text = String.Empty Then
                MessageBox.Show("¡Error! Debe completar los campos.", "Liquidación de sueldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboDocenteDni.Select()
            Else
                MessageBox.Show("Debe ingresar todos los campos", "Liquidación de sueldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try

        Return False
    End Function

    Private Sub btnRegresarMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresarMenu.Click
        doQuery("select count(*) from recibo")
        If (finalizarCarga <> False And result.Read) Or result.Read <> True Then
            cboDocenteDni.SelectedIndex = -1
            txtReferencia.Text = ""
            txtSubTotal.Text = ""
            Me.Hide()
            frmMenuTesoreria.Show()
        Else
            MessageBox.Show("Debe presionar el bóton 'Finalizar Carga' antes de salir ", "Liquidación de sueldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class