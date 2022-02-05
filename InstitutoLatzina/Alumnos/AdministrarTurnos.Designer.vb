<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrarTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrarTurnos))
        Me.btnBuscarTurnos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregarTurnoAlumno = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBuscarTurnos
        '
        Me.btnBuscarTurnos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscarTurnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnBuscarTurnos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscarTurnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscarTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTurnos.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarTurnos.Location = New System.Drawing.Point(191, 128)
        Me.btnBuscarTurnos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscarTurnos.Name = "btnBuscarTurnos"
        Me.btnBuscarTurnos.Size = New System.Drawing.Size(102, 52)
        Me.btnBuscarTurnos.TabIndex = 70
        Me.btnBuscarTurnos.Text = "Buscar Turnos"
        Me.btnBuscarTurnos.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 34)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Elija una opción:"
        '
        'btnAgregarTurnoAlumno
        '
        Me.btnAgregarTurnoAlumno.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAgregarTurnoAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAgregarTurnoAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarTurnoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTurnoAlumno.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTurnoAlumno.Location = New System.Drawing.Point(64, 128)
        Me.btnAgregarTurnoAlumno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregarTurnoAlumno.Name = "btnAgregarTurnoAlumno"
        Me.btnAgregarTurnoAlumno.Size = New System.Drawing.Size(102, 52)
        Me.btnAgregarTurnoAlumno.TabIndex = 68
        Me.btnAgregarTurnoAlumno.Text = "Agregar Turno Alumno"
        Me.btnAgregarTurnoAlumno.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMenu.BackColor = System.Drawing.Color.LightCoral
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMenu.Location = New System.Drawing.Point(128, 223)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(100, 50)
        Me.btnMenu.TabIndex = 71
        Me.btnMenu.Text = "Volver"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'frmAdministrarTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 314)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnBuscarTurnos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregarTurnoAlumno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdministrarTurnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Turnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarTurnos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarTurnoAlumno As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
End Class
