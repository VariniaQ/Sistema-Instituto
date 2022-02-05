<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCredencial = New System.Windows.Forms.TextBox()
        Me.gpbPago = New System.Windows.Forms.GroupBox()
        Me.rdbMatricula = New System.Windows.Forms.RadioButton()
        Me.rdbCuota = New System.Windows.Forms.RadioButton()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpbPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Credencial:"
        '
        'txtCredencial
        '
        Me.txtCredencial.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredencial.Location = New System.Drawing.Point(91, 3)
        Me.txtCredencial.Name = "txtCredencial"
        Me.txtCredencial.Size = New System.Drawing.Size(139, 26)
        Me.txtCredencial.TabIndex = 1
        '
        'gpbPago
        '
        Me.gpbPago.Controls.Add(Me.rdbMatricula)
        Me.gpbPago.Controls.Add(Me.rdbCuota)
        Me.gpbPago.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPago.Location = New System.Drawing.Point(15, 32)
        Me.gpbPago.Name = "gpbPago"
        Me.gpbPago.Size = New System.Drawing.Size(215, 52)
        Me.gpbPago.TabIndex = 2
        Me.gpbPago.TabStop = False
        Me.gpbPago.Text = "Pago"
        '
        'rdbMatricula
        '
        Me.rdbMatricula.AutoSize = True
        Me.rdbMatricula.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMatricula.Location = New System.Drawing.Point(115, 19)
        Me.rdbMatricula.Name = "rdbMatricula"
        Me.rdbMatricula.Size = New System.Drawing.Size(78, 20)
        Me.rdbMatricula.TabIndex = 1
        Me.rdbMatricula.TabStop = True
        Me.rdbMatricula.Text = "Matricula"
        Me.rdbMatricula.UseVisualStyleBackColor = True
        '
        'rdbCuota
        '
        Me.rdbCuota.AutoSize = True
        Me.rdbCuota.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCuota.Location = New System.Drawing.Point(11, 19)
        Me.rdbCuota.Name = "rdbCuota"
        Me.rdbCuota.Size = New System.Drawing.Size(59, 20)
        Me.rdbCuota.TabIndex = 0
        Me.rdbCuota.TabStop = True
        Me.rdbCuota.Text = "Cuota"
        Me.rdbCuota.UseVisualStyleBackColor = True
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnContinuar.Enabled = False
        Me.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(132, 99)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(100, 50)
        Me.btnContinuar.TabIndex = 3
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightCoral
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(12, 99)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 50)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(244, 161)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.gpbPago)
        Me.Controls.Add(Me.txtCredencial)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.gpbPago.ResumeLayout(False)
        Me.gpbPago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCredencial As System.Windows.Forms.TextBox
    Friend WithEvents gpbPago As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMatricula As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCuota As System.Windows.Forms.RadioButton
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
