<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuota))
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.lblCredencial = New System.Windows.Forms.Label()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.lblCuotas = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.cmbCant = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReferencias = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(65, 221)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(58, 16)
        Me.lblMonto.TabIndex = 13
        Me.lblMonto.Text = "A pagar:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightCoral
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(150, 250)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 50)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContinuar.Enabled = False
        Me.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(34, 250)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(100, 50)
        Me.btnContinuar.TabIndex = 11
        Me.btnContinuar.Text = "Confirmar"
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'lblCredencial
        '
        Me.lblCredencial.AutoSize = True
        Me.lblCredencial.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredencial.Location = New System.Drawing.Point(12, 34)
        Me.lblCredencial.Name = "lblCredencial"
        Me.lblCredencial.Size = New System.Drawing.Size(73, 16)
        Me.lblCredencial.TabIndex = 10
        Me.lblCredencial.Text = "Credencial:"
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumno.Location = New System.Drawing.Point(12, 9)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(55, 16)
        Me.lblAlumno.TabIndex = 9
        Me.lblAlumno.Text = "Alumno:"
        '
        'lblCuotas
        '
        Me.lblCuotas.AutoSize = True
        Me.lblCuotas.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuotas.Location = New System.Drawing.Point(12, 57)
        Me.lblCuotas.Name = "lblCuotas"
        Me.lblCuotas.Size = New System.Drawing.Size(111, 16)
        Me.lblCuotas.TabIndex = 14
        Me.lblCuotas.Text = "Cuotas Restantes:"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(51, 196)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(126, 16)
        Me.lblCant.TabIndex = 15
        Me.lblCant.Text = "Cantidad de Cuotas:"
        '
        'cmbCant
        '
        Me.cmbCant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCant.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCant.FormattingEnabled = True
        Me.cmbCant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbCant.Location = New System.Drawing.Point(183, 193)
        Me.cmbCant.Name = "cmbCant"
        Me.cmbCant.Size = New System.Drawing.Size(50, 24)
        Me.cmbCant.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Referencias"
        '
        'txtReferencias
        '
        Me.txtReferencias.Location = New System.Drawing.Point(33, 105)
        Me.txtReferencias.Multiline = True
        Me.txtReferencias.Name = "txtReferencias"
        Me.txtReferencias.Size = New System.Drawing.Size(218, 79)
        Me.txtReferencias.TabIndex = 17
        '
        'Cuota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReferencias)
        Me.Controls.Add(Me.cmbCant)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.lblCuotas)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.lblCredencial)
        Me.Controls.Add(Me.lblAlumno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Cuota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents lblCredencial As System.Windows.Forms.Label
    Friend WithEvents lblAlumno As System.Windows.Forms.Label
    Friend WithEvents lblCuotas As System.Windows.Forms.Label
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents cmbCant As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReferencias As System.Windows.Forms.TextBox
End Class
