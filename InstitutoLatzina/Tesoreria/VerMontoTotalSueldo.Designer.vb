<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerMontoTotalSueldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerMontoTotalSueldo))
        Me.dtgMontoTotal = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDniDocente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegresarMenu = New System.Windows.Forms.Button()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        CType(Me.dtgMontoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgMontoTotal
        '
        Me.dtgMontoTotal.AllowUserToAddRows = False
        Me.dtgMontoTotal.AllowUserToDeleteRows = False
        Me.dtgMontoTotal.AllowUserToResizeColumns = False
        Me.dtgMontoTotal.AllowUserToResizeRows = False
        Me.dtgMontoTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgMontoTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgMontoTotal.BackgroundColor = System.Drawing.Color.White
        Me.dtgMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgMontoTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMontoTotal.GridColor = System.Drawing.Color.SteelBlue
        Me.dtgMontoTotal.Location = New System.Drawing.Point(336, 107)
        Me.dtgMontoTotal.Name = "dtgMontoTotal"
        Me.dtgMontoTotal.ReadOnly = True
        Me.dtgMontoTotal.RowHeadersVisible = False
        Me.dtgMontoTotal.Size = New System.Drawing.Size(422, 122)
        Me.dtgMontoTotal.TabIndex = 69
        Me.dtgMontoTotal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(27, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "DNI del docente:"
        '
        'cboDniDocente
        '
        Me.cboDniDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDniDocente.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDniDocente.FormattingEnabled = True
        Me.cboDniDocente.Location = New System.Drawing.Point(146, 127)
        Me.cboDniDocente.Name = "cboDniDocente"
        Me.cboDniDocente.Size = New System.Drawing.Size(141, 24)
        Me.cboDniDocente.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 34)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Seleccione un DNI"
        '
        'btnRegresarMenu
        '
        Me.btnRegresarMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRegresarMenu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnRegresarMenu.FlatAppearance.BorderSize = 2
        Me.btnRegresarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnRegresarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresarMenu.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegresarMenu.Location = New System.Drawing.Point(30, 403)
        Me.btnRegresarMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegresarMenu.Name = "btnRegresarMenu"
        Me.btnRegresarMenu.Size = New System.Drawing.Size(100, 50)
        Me.btnRegresarMenu.TabIndex = 71
        Me.btnRegresarMenu.Text = "Volver"
        Me.btnRegresarMenu.UseVisualStyleBackColor = False
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(564, 423)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(88, 16)
        Me.lblMonto.TabIndex = 72
        Me.lblMonto.Text = "Monto Total:"
        Me.lblMonto.Visible = False
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Enabled = False
        Me.txtMontoTotal.Location = New System.Drawing.Point(658, 417)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(100, 27)
        Me.txtMontoTotal.TabIndex = 73
        Me.txtMontoTotal.Visible = False
        '
        'frmVerMontoTotalSueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 481)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.btnRegresarMenu)
        Me.Controls.Add(Me.dtgMontoTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDniDocente)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVerMontoTotalSueldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mostrar Monto Total (Sueldo)"
        CType(Me.dtgMontoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgMontoTotal As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDniDocente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegresarMenu As System.Windows.Forms.Button
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMontoTotal As System.Windows.Forms.TextBox
End Class
