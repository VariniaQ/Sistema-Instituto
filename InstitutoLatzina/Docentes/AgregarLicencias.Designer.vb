<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarLicencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarLicencias))
        Me.cboTemporalidad = New System.Windows.Forms.ComboBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnLicencia = New System.Windows.Forms.Button()
        Me.cboMotivoLicencia = New System.Windows.Forms.ComboBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaLicencia = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.nudDuracion = New System.Windows.Forms.NumericUpDown()
        Me.cboDocentes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTemporalidad
        '
        Me.cboTemporalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTemporalidad.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTemporalidad.FormattingEnabled = True
        Me.cboTemporalidad.Location = New System.Drawing.Point(358, 146)
        Me.cboTemporalidad.Name = "cboTemporalidad"
        Me.cboTemporalidad.Size = New System.Drawing.Size(166, 24)
        Me.cboTemporalidad.TabIndex = 44
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.LightCoral
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnMenu.FlatAppearance.BorderSize = 2
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMenu.Location = New System.Drawing.Point(159, 260)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(100, 50)
        Me.btnMenu.TabIndex = 42
        Me.btnMenu.Text = "Volver"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnLicencia
        '
        Me.btnLicencia.BackColor = System.Drawing.Color.LightGreen
        Me.btnLicencia.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnLicencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLicencia.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLicencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLicencia.Location = New System.Drawing.Point(335, 260)
        Me.btnLicencia.Name = "btnLicencia"
        Me.btnLicencia.Size = New System.Drawing.Size(100, 50)
        Me.btnLicencia.TabIndex = 41
        Me.btnLicencia.Text = "Aceptar"
        Me.btnLicencia.UseVisualStyleBackColor = False
        '
        'cboMotivoLicencia
        '
        Me.cboMotivoLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotivoLicencia.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMotivoLicencia.FormattingEnabled = True
        Me.cboMotivoLicencia.Location = New System.Drawing.Point(208, 201)
        Me.cboMotivoLicencia.Name = "cboMotivoLicencia"
        Me.cboMotivoLicencia.Size = New System.Drawing.Size(292, 24)
        Me.cboMotivoLicencia.TabIndex = 40
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMotivo.Location = New System.Drawing.Point(95, 204)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(107, 16)
        Me.lblMotivo.TabIndex = 39
        Me.lblMotivo.Text = "Motivo licencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(71, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Duración de la licencia:"
        '
        'dtpFechaLicencia
        '
        Me.dtpFechaLicencia.Enabled = False
        Me.dtpFechaLicencia.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaLicencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaLicencia.Location = New System.Drawing.Point(436, 91)
        Me.dtpFechaLicencia.Name = "dtpFechaLicencia"
        Me.dtpFechaLicencia.Size = New System.Drawing.Size(116, 27)
        Me.dtpFechaLicencia.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(298, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Fecha de emisión:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitulo.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitulo.Location = New System.Drawing.Point(245, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(105, 25)
        Me.lblTitulo.TabIndex = 35
        Me.lblTitulo.Text = "Licencias"
        '
        'nudDuracion
        '
        Me.nudDuracion.Location = New System.Drawing.Point(232, 146)
        Me.nudDuracion.Name = "nudDuracion"
        Me.nudDuracion.Size = New System.Drawing.Size(120, 26)
        Me.nudDuracion.TabIndex = 45
        '
        'cboDocentes
        '
        Me.cboDocentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocentes.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocentes.FormattingEnabled = True
        Me.cboDocentes.Location = New System.Drawing.Point(112, 95)
        Me.cboDocentes.Name = "cboDocentes"
        Me.cboDocentes.Size = New System.Drawing.Size(162, 24)
        Me.cboDocentes.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(42, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Docente:"
        '
        'frmAgregarLicencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 346)
        Me.Controls.Add(Me.cboDocentes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudDuracion)
        Me.Controls.Add(Me.cboTemporalidad)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnLicencia)
        Me.Controls.Add(Me.cboMotivoLicencia)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaLicencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAgregarLicencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licencias"
        CType(Me.nudDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTemporalidad As System.Windows.Forms.ComboBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnLicencia As System.Windows.Forms.Button
    Friend WithEvents cboMotivoLicencia As System.Windows.Forms.ComboBox
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaLicencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents nudDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboDocentes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
