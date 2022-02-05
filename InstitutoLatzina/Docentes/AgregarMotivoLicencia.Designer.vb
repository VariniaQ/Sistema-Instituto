<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarMotivoLicencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarMotivoLicencia))
        Me.dtgMotivo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMotivoLicencia = New System.Windows.Forms.TextBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.btnAgregarMotivo = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dtgMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgMotivo
        '
        Me.dtgMotivo.AllowUserToResizeColumns = False
        Me.dtgMotivo.AllowUserToResizeRows = False
        Me.dtgMotivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgMotivo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgMotivo.BackgroundColor = System.Drawing.Color.White
        Me.dtgMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgMotivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMotivo.GridColor = System.Drawing.Color.SteelBlue
        Me.dtgMotivo.Location = New System.Drawing.Point(418, 75)
        Me.dtgMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgMotivo.Name = "dtgMotivo"
        Me.dtgMotivo.ReadOnly = True
        Me.dtgMotivo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtgMotivo.Size = New System.Drawing.Size(322, 297)
        Me.dtgMotivo.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Nombre:"
        '
        'txtMotivoLicencia
        '
        Me.txtMotivoLicencia.Location = New System.Drawing.Point(98, 119)
        Me.txtMotivoLicencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMotivoLicencia.Multiline = True
        Me.txtMotivoLicencia.Name = "txtMotivoLicencia"
        Me.txtMotivoLicencia.Size = New System.Drawing.Size(282, 79)
        Me.txtMotivoLicencia.TabIndex = 40
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(28, 31)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(384, 25)
        Me.lblLocalidad.TabIndex = 42
        Me.lblLocalidad.Text = "Ingrese un nuevo motivo de licencia"
        '
        'btnAgregarMotivo
        '
        Me.btnAgregarMotivo.BackColor = System.Drawing.Color.LightGreen
        Me.btnAgregarMotivo.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnAgregarMotivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAgregarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarMotivo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMotivo.Location = New System.Drawing.Point(280, 229)
        Me.btnAgregarMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregarMotivo.Name = "btnAgregarMotivo"
        Me.btnAgregarMotivo.Size = New System.Drawing.Size(100, 50)
        Me.btnAgregarMotivo.TabIndex = 43
        Me.btnAgregarMotivo.Text = "Agregar"
        Me.btnAgregarMotivo.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.LightCoral
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnVolver.FlatAppearance.BorderSize = 2
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnVolver.Location = New System.Drawing.Point(30, 403)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(100, 50)
        Me.btnVolver.TabIndex = 44
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmAgregarMotivoLicencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 481)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregarMotivo)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMotivoLicencia)
        Me.Controls.Add(Me.dtgMotivo)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmAgregarMotivoLicencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Motivo Licencia"
        CType(Me.dtgMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgMotivo As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMotivoLicencia As System.Windows.Forms.TextBox
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents btnAgregarMotivo As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
