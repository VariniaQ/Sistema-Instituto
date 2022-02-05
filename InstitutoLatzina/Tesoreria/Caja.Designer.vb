<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Caja))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMensual = New System.Windows.Forms.Button()
        Me.btnDiaria = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.ListBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Caja"
        '
        'btnMensual
        '
        Me.btnMensual.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMensual.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMensual.Location = New System.Drawing.Point(182, 51)
        Me.btnMensual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMensual.Name = "btnMensual"
        Me.btnMensual.Size = New System.Drawing.Size(100, 50)
        Me.btnMensual.TabIndex = 28
        Me.btnMensual.Text = "Mensual"
        Me.btnMensual.UseVisualStyleBackColor = False
        '
        'btnDiaria
        '
        Me.btnDiaria.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDiaria.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiaria.Location = New System.Drawing.Point(55, 51)
        Me.btnDiaria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDiaria.Name = "btnDiaria"
        Me.btnDiaria.Size = New System.Drawing.Size(100, 50)
        Me.btnDiaria.TabIndex = 29
        Me.btnDiaria.Text = "Diaria"
        Me.btnDiaria.UseVisualStyleBackColor = False
        '
        'list
        '
        Me.list.FormattingEnabled = True
        Me.list.Location = New System.Drawing.Point(12, 122)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(313, 264)
        Me.list.TabIndex = 30
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnVolver.Location = New System.Drawing.Point(12, 397)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(100, 50)
        Me.btnVolver.TabIndex = 60
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(225, 397)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 50)
        Me.btnRegistrar.TabIndex = 61
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 460)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.btnDiaria)
        Me.Controls.Add(Me.btnMensual)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMensual As System.Windows.Forms.Button
    Friend WithEvents btnDiaria As System.Windows.Forms.Button
    Friend WithEvents list As System.Windows.Forms.ListBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
End Class
