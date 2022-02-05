<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrarDatosdeAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrarDatosdeAlumnos))
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnBuscarTurnos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInscribirAlumno = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.btnMenu.Location = New System.Drawing.Point(117, 218)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(100, 50)
        Me.btnMenu.TabIndex = 75
        Me.btnMenu.Text = "Volver"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnBuscarTurnos
        '
        Me.btnBuscarTurnos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBuscarTurnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnBuscarTurnos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscarTurnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBuscarTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTurnos.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarTurnos.Location = New System.Drawing.Point(180, 123)
        Me.btnBuscarTurnos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscarTurnos.Name = "btnBuscarTurnos"
        Me.btnBuscarTurnos.Size = New System.Drawing.Size(102, 52)
        Me.btnBuscarTurnos.TabIndex = 74
        Me.btnBuscarTurnos.Text = "Reinscribir Alumno"
        Me.btnBuscarTurnos.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 34)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Elija una opción:"
        '
        'btnInscribirAlumno
        '
        Me.btnInscribirAlumno.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnInscribirAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnInscribirAlumno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInscribirAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInscribirAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInscribirAlumno.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInscribirAlumno.Location = New System.Drawing.Point(53, 123)
        Me.btnInscribirAlumno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInscribirAlumno.Name = "btnInscribirAlumno"
        Me.btnInscribirAlumno.Size = New System.Drawing.Size(102, 52)
        Me.btnInscribirAlumno.TabIndex = 72
        Me.btnInscribirAlumno.Text = "Inscribir Alumno"
        Me.btnInscribirAlumno.UseVisualStyleBackColor = False
        '
        'frmAdministrarDatosdeAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(328, 304)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnBuscarTurnos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnInscribirAlumno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdministrarDatosdeAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Datos de Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnBuscarTurnos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnInscribirAlumno As System.Windows.Forms.Button
End Class
