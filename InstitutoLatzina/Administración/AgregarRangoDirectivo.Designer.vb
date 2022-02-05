<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarRangoDirectivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarRangoDirectivo))
        Me.lblRangoD = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.dtgRangoD = New System.Windows.Forms.DataGridView()
        Me.txtRangoDirectivo = New System.Windows.Forms.TextBox()
        Me.btnAgregarRango = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dtgRangoD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRangoD
        '
        Me.lblRangoD.AutoSize = True
        Me.lblRangoD.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRangoD.Location = New System.Drawing.Point(34, 142)
        Me.lblRangoD.Name = "lblRangoD"
        Me.lblRangoD.Size = New System.Drawing.Size(62, 16)
        Me.lblRangoD.TabIndex = 45
        Me.lblRangoD.Text = "Nombre:"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(30, 31)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(353, 25)
        Me.lblLocalidad.TabIndex = 44
        Me.lblLocalidad.Text = "Ingrese un nuevo rango directivo"
        '
        'dtgRangoD
        '
        Me.dtgRangoD.AllowUserToAddRows = False
        Me.dtgRangoD.AllowUserToDeleteRows = False
        Me.dtgRangoD.AllowUserToResizeColumns = False
        Me.dtgRangoD.AllowUserToResizeRows = False
        Me.dtgRangoD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgRangoD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgRangoD.BackgroundColor = System.Drawing.Color.White
        Me.dtgRangoD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgRangoD.GridColor = System.Drawing.Color.SteelBlue
        Me.dtgRangoD.Location = New System.Drawing.Point(399, 75)
        Me.dtgRangoD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgRangoD.Name = "dtgRangoD"
        Me.dtgRangoD.ReadOnly = True
        Me.dtgRangoD.Size = New System.Drawing.Size(343, 304)
        Me.dtgRangoD.TabIndex = 43
        '
        'txtRangoDirectivo
        '
        Me.txtRangoDirectivo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRangoDirectivo.Location = New System.Drawing.Point(111, 136)
        Me.txtRangoDirectivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRangoDirectivo.Name = "txtRangoDirectivo"
        Me.txtRangoDirectivo.Size = New System.Drawing.Size(240, 27)
        Me.txtRangoDirectivo.TabIndex = 42
        '
        'btnAgregarRango
        '
        Me.btnAgregarRango.BackColor = System.Drawing.Color.LightGreen
        Me.btnAgregarRango.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnAgregarRango.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAgregarRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarRango.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRango.Location = New System.Drawing.Point(251, 189)
        Me.btnAgregarRango.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregarRango.Name = "btnAgregarRango"
        Me.btnAgregarRango.Size = New System.Drawing.Size(100, 50)
        Me.btnAgregarRango.TabIndex = 48
        Me.btnAgregarRango.Text = "Agregar"
        Me.btnAgregarRango.UseVisualStyleBackColor = False
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
        Me.btnVolver.TabIndex = 49
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmAgregarRangoDirectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 481)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregarRango)
        Me.Controls.Add(Me.lblRangoD)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.dtgRangoD)
        Me.Controls.Add(Me.txtRangoDirectivo)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmAgregarRangoDirectivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar rangos directivos"
        CType(Me.dtgRangoD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRangoD As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents dtgRangoD As System.Windows.Forms.DataGridView
    Friend WithEvents txtRangoDirectivo As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarRango As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
