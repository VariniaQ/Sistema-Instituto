<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarLocalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarLocalidad))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.dtgLocalidad = New System.Windows.Forms.DataGridView()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.btnAgregarLocalidad = New System.Windows.Forms.Button()
        CType(Me.dtgLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnVolver.TabIndex = 39
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nombre:"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(25, 35)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(356, 25)
        Me.lblLocalidad.TabIndex = 36
        Me.lblLocalidad.Text = "Ingrese el nombre de la localidad"
        '
        'dtgLocalidad
        '
        Me.dtgLocalidad.AllowUserToAddRows = False
        Me.dtgLocalidad.AllowUserToDeleteRows = False
        Me.dtgLocalidad.AllowUserToResizeColumns = False
        Me.dtgLocalidad.AllowUserToResizeRows = False
        Me.dtgLocalidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgLocalidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgLocalidad.BackgroundColor = System.Drawing.Color.White
        Me.dtgLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgLocalidad.GridColor = System.Drawing.Color.SteelBlue
        Me.dtgLocalidad.Location = New System.Drawing.Point(418, 75)
        Me.dtgLocalidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgLocalidad.Name = "dtgLocalidad"
        Me.dtgLocalidad.ReadOnly = True
        Me.dtgLocalidad.Size = New System.Drawing.Size(339, 292)
        Me.dtgLocalidad.TabIndex = 35
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.Location = New System.Drawing.Point(117, 124)
        Me.txtLocalidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(238, 27)
        Me.txtLocalidad.TabIndex = 34
        '
        'btnAgregarLocalidad
        '
        Me.btnAgregarLocalidad.BackColor = System.Drawing.Color.LightGreen
        Me.btnAgregarLocalidad.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnAgregarLocalidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAgregarLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLocalidad.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarLocalidad.Location = New System.Drawing.Point(255, 177)
        Me.btnAgregarLocalidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregarLocalidad.Name = "btnAgregarLocalidad"
        Me.btnAgregarLocalidad.Size = New System.Drawing.Size(100, 50)
        Me.btnAgregarLocalidad.TabIndex = 33
        Me.btnAgregarLocalidad.Text = "Agregar"
        Me.btnAgregarLocalidad.UseVisualStyleBackColor = False
        '
        'frmAgregarLocalidad
        '
        Me.AcceptButton = Me.btnAgregarLocalidad
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(784, 481)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.dtgLocalidad)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.btnAgregarLocalidad)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmAgregarLocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Localidad"
        CType(Me.dtgLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents dtgLocalidad As System.Windows.Forms.DataGridView
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarLocalidad As System.Windows.Forms.Button
End Class
