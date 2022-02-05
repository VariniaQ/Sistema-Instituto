<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistenciaAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsistenciaAlumno))
        Me.rdbAusente = New System.Windows.Forms.RadioButton()
        Me.rdbPresente = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAlumno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAsistenciaAlumno = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.dtpFechaDocente = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboNroClase = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbTarde = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'rdbAusente
        '
        Me.rdbAusente.AutoSize = True
        Me.rdbAusente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAusente.Location = New System.Drawing.Point(408, 229)
        Me.rdbAusente.Name = "rdbAusente"
        Me.rdbAusente.Size = New System.Drawing.Size(77, 20)
        Me.rdbAusente.TabIndex = 97
        Me.rdbAusente.TabStop = True
        Me.rdbAusente.Text = "Ausente"
        Me.rdbAusente.UseVisualStyleBackColor = True
        '
        'rdbPresente
        '
        Me.rdbPresente.AutoSize = True
        Me.rdbPresente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPresente.Location = New System.Drawing.Point(321, 229)
        Me.rdbPresente.Name = "rdbPresente"
        Me.rdbPresente.Size = New System.Drawing.Size(79, 20)
        Me.rdbPresente.TabIndex = 96
        Me.rdbPresente.TabStop = True
        Me.rdbPresente.Text = "Presente"
        Me.rdbPresente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Estado:"
        '
        'cboAlumno
        '
        Me.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlumno.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlumno.FormattingEnabled = True
        Me.cboAlumno.Location = New System.Drawing.Point(315, 182)
        Me.cboAlumno.Name = "cboAlumno"
        Me.cboAlumno.Size = New System.Drawing.Size(243, 24)
        Me.cboAlumno.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(241, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Alumnos:"
        '
        'btnAsistenciaAlumno
        '
        Me.btnAsistenciaAlumno.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAsistenciaAlumno.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnAsistenciaAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAsistenciaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistenciaAlumno.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistenciaAlumno.Location = New System.Drawing.Point(414, 300)
        Me.btnAsistenciaAlumno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAsistenciaAlumno.Name = "btnAsistenciaAlumno"
        Me.btnAsistenciaAlumno.Size = New System.Drawing.Size(100, 50)
        Me.btnAsistenciaAlumno.TabIndex = 91
        Me.btnAsistenciaAlumno.Text = "Aceptar"
        Me.btnAsistenciaAlumno.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.LightCoral
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnVolver.FlatAppearance.BorderSize = 2
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(271, 300)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(100, 50)
        Me.btnVolver.TabIndex = 90
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'dtpFechaDocente
        '
        Me.dtpFechaDocente.Enabled = False
        Me.dtpFechaDocente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDocente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDocente.Location = New System.Drawing.Point(97, 76)
        Me.dtpFechaDocente.Name = "dtpFechaDocente"
        Me.dtpFechaDocente.Size = New System.Drawing.Size(116, 27)
        Me.dtpFechaDocente.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 34)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Asistencia del Alumno"
        '
        'cboNroClase
        '
        Me.cboNroClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNroClase.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNroClase.FormattingEnabled = True
        Me.cboNroClase.Location = New System.Drawing.Point(315, 134)
        Me.cboNroClase.Name = "cboNroClase"
        Me.cboNroClase.Size = New System.Drawing.Size(148, 24)
        Me.cboNroClase.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "N° de Clase:"
        '
        'rdbTarde
        '
        Me.rdbTarde.AutoSize = True
        Me.rdbTarde.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTarde.Location = New System.Drawing.Point(493, 229)
        Me.rdbTarde.Name = "rdbTarde"
        Me.rdbTarde.Size = New System.Drawing.Size(61, 20)
        Me.rdbTarde.TabIndex = 100
        Me.rdbTarde.TabStop = True
        Me.rdbTarde.Text = "Tarde"
        Me.rdbTarde.UseVisualStyleBackColor = True
        '
        'frmAsistenciaAlumno
        '
        Me.AcceptButton = Me.btnAsistenciaAlumno
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnVolver
        Me.ClientSize = New System.Drawing.Size(784, 377)
        Me.Controls.Add(Me.rdbTarde)
        Me.Controls.Add(Me.cboNroClase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdbAusente)
        Me.Controls.Add(Me.rdbPresente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboAlumno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAsistenciaAlumno)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dtpFechaDocente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAsistenciaAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencia del Alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbAusente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPresente As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboAlumno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAsistenciaAlumno As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents dtpFechaDocente As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboNroClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdbTarde As System.Windows.Forms.RadioButton
End Class
