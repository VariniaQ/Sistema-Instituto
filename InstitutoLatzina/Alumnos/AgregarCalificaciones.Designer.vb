<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCalificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarCalificaciones))
        Me.lblNombreT = New System.Windows.Forms.Label()
        Me.lblProfesion = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.cmbProfesiones = New System.Windows.Forms.ComboBox()
        Me.txtNCredencial = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombreT = New System.Windows.Forms.TextBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombreT
        '
        Me.lblNombreT.AutoSize = True
        Me.lblNombreT.Location = New System.Drawing.Point(18, 160)
        Me.lblNombreT.Name = "lblNombreT"
        Me.lblNombreT.Size = New System.Drawing.Size(94, 13)
        Me.lblNombreT.TabIndex = 0
        Me.lblNombreT.Text = "Nombre del Tema:"
        '
        'lblProfesion
        '
        Me.lblProfesion.AutoSize = True
        Me.lblProfesion.Location = New System.Drawing.Point(58, 192)
        Me.lblProfesion.Name = "lblProfesion"
        Me.lblProfesion.Size = New System.Drawing.Size(54, 13)
        Me.lblProfesion.TabIndex = 1
        Me.lblProfesion.Text = "Profesión:"
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Location = New System.Drawing.Point(79, 222)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(33, 13)
        Me.lblNota.TabIndex = 2
        Me.lblNota.Text = "Nota:"
        '
        'cmbProfesiones
        '
        Me.cmbProfesiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProfesiones.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProfesiones.FormattingEnabled = True
        Me.cmbProfesiones.Location = New System.Drawing.Point(118, 187)
        Me.cmbProfesiones.Name = "cmbProfesiones"
        Me.cmbProfesiones.Size = New System.Drawing.Size(127, 24)
        Me.cmbProfesiones.TabIndex = 3
        '
        'txtNCredencial
        '
        Me.txtNCredencial.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCredencial.Location = New System.Drawing.Point(118, 49)
        Me.txtNCredencial.Name = "txtNCredencial"
        Me.txtNCredencial.Size = New System.Drawing.Size(127, 26)
        Me.txtNCredencial.TabIndex = 47
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(118, 82)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(127, 47)
        Me.btnBuscar.TabIndex = 48
        Me.btnBuscar.Text = "Buscar Número de Credencial"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNombreT
        '
        Me.txtNombreT.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreT.Location = New System.Drawing.Point(118, 155)
        Me.txtNombreT.Name = "txtNombreT"
        Me.txtNombreT.Size = New System.Drawing.Size(127, 26)
        Me.txtNombreT.TabIndex = 49
        '
        'txtNota
        '
        Me.txtNota.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(118, 217)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(127, 26)
        Me.txtNota.TabIndex = 50
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFinalizar.Enabled = False
        Me.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Location = New System.Drawing.Point(258, 270)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(100, 50)
        Me.btnFinalizar.TabIndex = 57
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        Me.btnFinalizar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightCoral
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(12, 270)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 50)
        Me.btnCancelar.TabIndex = 56
        Me.btnCancelar.Text = "Volver"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 23)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Buscar Alumno"
        '
        'frmAgregarCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(370, 332)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.txtNombreT)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNCredencial)
        Me.Controls.Add(Me.cmbProfesiones)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.lblProfesion)
        Me.Controls.Add(Me.lblNombreT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAgregarCalificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Calificaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreT As System.Windows.Forms.Label
    Friend WithEvents lblProfesion As System.Windows.Forms.Label
    Friend WithEvents lblNota As System.Windows.Forms.Label
    Friend WithEvents cmbProfesiones As System.Windows.Forms.ComboBox
    Friend WithEvents txtNCredencial As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNombreT As System.Windows.Forms.TextBox
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
