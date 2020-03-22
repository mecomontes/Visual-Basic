<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Buttonpuntajes = New System.Windows.Forms.Button()
        Me.TextBoxequipos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Buttonequipos = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVnombres = New System.Windows.Forms.DataGridView()
        Me.Buttonmarcadores = New System.Windows.Forms.Button()
        Me.DGVposiciones = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVnombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVposiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttonpuntajes
        '
        Me.Buttonpuntajes.Location = New System.Drawing.Point(280, 12)
        Me.Buttonpuntajes.Name = "Buttonpuntajes"
        Me.Buttonpuntajes.Size = New System.Drawing.Size(82, 23)
        Me.Buttonpuntajes.TabIndex = 1
        Me.Buttonpuntajes.Text = "PUNTAJES"
        Me.Buttonpuntajes.UseVisualStyleBackColor = True
        '
        'TextBoxequipos
        '
        Me.TextBoxequipos.Location = New System.Drawing.Point(115, 15)
        Me.TextBoxequipos.Name = "TextBoxequipos"
        Me.TextBoxequipos.Size = New System.Drawing.Size(24, 20)
        Me.TextBoxequipos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "numero de equipos"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(181, 74)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(558, 210)
        Me.DGV.TabIndex = 4
        '
        'Buttonequipos
        '
        Me.Buttonequipos.Location = New System.Drawing.Point(181, 12)
        Me.Buttonequipos.Name = "Buttonequipos"
        Me.Buttonequipos.Size = New System.Drawing.Size(82, 23)
        Me.Buttonequipos.TabIndex = 0
        Me.Buttonequipos.Text = "EQUIPOS"
        Me.Buttonequipos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "nombre de los equipos"
        '
        'DGVnombres
        '
        Me.DGVnombres.AllowUserToAddRows = False
        Me.DGVnombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVnombres.Location = New System.Drawing.Point(12, 66)
        Me.DGVnombres.Name = "DGVnombres"
        Me.DGVnombres.Size = New System.Drawing.Size(113, 146)
        Me.DGVnombres.TabIndex = 6
        '
        'Buttonmarcadores
        '
        Me.Buttonmarcadores.Location = New System.Drawing.Point(181, 45)
        Me.Buttonmarcadores.Name = "Buttonmarcadores"
        Me.Buttonmarcadores.Size = New System.Drawing.Size(82, 23)
        Me.Buttonmarcadores.TabIndex = 7
        Me.Buttonmarcadores.Text = "MARCADORES"
        Me.Buttonmarcadores.UseVisualStyleBackColor = True
        '
        'DGVposiciones
        '
        Me.DGVposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVposiciones.Location = New System.Drawing.Point(181, 309)
        Me.DGVposiciones.Name = "DGVposiciones"
        Me.DGVposiciones.Size = New System.Drawing.Size(558, 205)
        Me.DGVposiciones.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(432, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(46, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "media"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 526)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DGVposiciones)
        Me.Controls.Add(Me.Buttonmarcadores)
        Me.Controls.Add(Me.DGVnombres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxequipos)
        Me.Controls.Add(Me.Buttonpuntajes)
        Me.Controls.Add(Me.Buttonequipos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVnombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVposiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Buttonpuntajes As System.Windows.Forms.Button
    Friend WithEvents TextBoxequipos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Buttonequipos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGVnombres As System.Windows.Forms.DataGridView
    Friend WithEvents Buttonmarcadores As System.Windows.Forms.Button
    Friend WithEvents DGVposiciones As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
