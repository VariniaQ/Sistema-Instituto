<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistenciaDocente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsistenciaDocente))
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDocente = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpHoraDocente = New System.Windows.Forms.DateTimePicker()
        Me.lblHorarioEnt = New System.Windows.Forms.Label()
        Me.cboTurno = New System.Windows.Forms.ComboBox()
        Me.cmoTurno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAsistenciaDocente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDocente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbPresente = New System.Windows.Forms.RadioButton()
        Me.rdbAusente = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.LightCoral
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnMenu.FlatAppearance.BorderSize = 2
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(271, 296)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(100, 50)
        Me.btnMenu.TabIndex = 53
        Me.btnMenu.Text = "Volver"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.CustomFormat = ""
        Me.dtpHoraEntrada.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(309, 235)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.ShowUpDown = True
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(167, 27)
        Me.dtpHoraEntrada.TabIndex = 51
        '
        'dtpFechaDocente
        '
        Me.dtpFechaDocente.Enabled = False
        Me.dtpFechaDocente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDocente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDocente.Location = New System.Drawing.Point(371, 75)
        Me.dtpFechaDocente.Name = "dtpFechaDocente"
        Me.dtpFechaDocente.Size = New System.Drawing.Size(116, 27)
        Me.dtpFechaDocente.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(305, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Fecha:"
        '
        'dtpHoraDocente
        '
        Me.dtpHoraDocente.CustomFormat = ""
        Me.dtpHoraDocente.Enabled = False
        Me.dtpHoraDocente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraDocente.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraDocente.Location = New System.Drawing.Point(565, 75)
        Me.dtpHoraDocente.Name = "dtpHoraDocente"
        Me.dtpHoraDocente.ShowUpDown = True
        Me.dtpHoraDocente.Size = New System.Drawing.Size(121, 27)
        Me.dtpHoraDocente.TabIndex = 47
        '
        'lblHorarioEnt
        '
        Me.lblHorarioEnt.AutoSize = True
        Me.lblHorarioEnt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorarioEnt.Location = New System.Drawing.Point(174, 242)
        Me.lblHorarioEnt.Name = "lblHorarioEnt"
        Me.lblHorarioEnt.Size = New System.Drawing.Size(129, 16)
        Me.lblHorarioEnt.TabIndex = 45
        Me.lblHorarioEnt.Text = "Horario de entrada:"
        '
        'cboTurno
        '
        Me.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTurno.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTurno.FormattingEnabled = True
        Me.cboTurno.Location = New System.Drawing.Point(166, 75)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(121, 24)
        Me.cboTurno.TabIndex = 40
        '
        'cmoTurno
        '
        Me.cmoTurno.AutoSize = True
        Me.cmoTurno.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmoTurno.Location = New System.Drawing.Point(99, 80)
        Me.cmoTurno.Name = "cmoTurno"
        Me.cmoTurno.Size = New System.Drawing.Size(49, 16)
        Me.cmoTurno.TabIndex = 38
        Me.cmoTurno.Text = "Turno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 34)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Asistencia de docente"
        '
        'btnAsistenciaDocente
        '
        Me.btnAsistenciaDocente.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAsistenciaDocente.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnAsistenciaDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAsistenciaDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistenciaDocente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistenciaDocente.Location = New System.Drawing.Point(414, 296)
        Me.btnAsistenciaDocente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAsistenciaDocente.Name = "btnAsistenciaDocente"
        Me.btnAsistenciaDocente.Size = New System.Drawing.Size(100, 50)
        Me.btnAsistenciaDocente.TabIndex = 57
        Me.btnAsistenciaDocente.Text = "Aceptar"
        Me.btnAsistenciaDocente.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(505, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Hora:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(233, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Docente:"
        '
        'cboDocente
        '
        Me.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocente.FormattingEnabled = True
        Me.cboDocente.Location = New System.Drawing.Point(308, 141)
        Me.cboDocente.Name = "cboDocente"
        Me.cboDocente.Size = New System.Drawing.Size(167, 24)
        Me.cboDocente.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(243, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Estado:"
        '
        'rdbPresente
        '
        Me.rdbPresente.AutoSize = True
        Me.rdbPresente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPresente.Location = New System.Drawing.Point(308, 189)
        Me.rdbPresente.Name = "rdbPresente"
        Me.rdbPresente.Size = New System.Drawing.Size(79, 20)
        Me.rdbPresente.TabIndex = 63
        Me.rdbPresente.TabStop = True
        Me.rdbPresente.Text = "Presente"
        Me.rdbPresente.UseVisualStyleBackColor = True
        '
        'rdbAusente
        '
        Me.rdbAusente.AutoSize = True
        Me.rdbAusente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAusente.Location = New System.Drawing.Point(398, 189)
        Me.rdbAusente.Name = "rdbAusente"
        Me.rdbAusente.Size = New System.Drawing.Size(77, 20)
        Me.rdbAusente.TabIndex = 64
        Me.rdbAusente.TabStop = True
        Me.rdbAusente.Text = "Ausente"
        Me.rdbAusente.UseVisualStyleBackColor = True
        '
        'frmAsistenciaDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 371)
        Me.Controls.Add(Me.rdbAusente)
        Me.Controls.Add(Me.rdbPresente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboDocente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAsistenciaDocente)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.dtpHoraEntrada)
        Me.Controls.Add(Me.dtpFechaDocente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpHoraDocente)
        Me.Controls.Add(Me.lblHorarioEnt)
        Me.Controls.Add(Me.cboTurno)
        Me.Controls.Add(Me.cmoTurno)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAsistenciaDocente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Asistencia del Docente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents dtpHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDocente As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpHoraDocente As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHorarioEnt As System.Windows.Forms.Label
    Friend WithEvents cboTurno As System.Windows.Forms.ComboBox
    Friend WithEvents cmoTurno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAsistenciaDocente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDocente As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbPresente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAusente As System.Windows.Forms.RadioButton
End Class
