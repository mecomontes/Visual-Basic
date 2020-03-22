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
        Me.ESFUERZOS = New System.Windows.Forms.Button()
        Me.DEFORMACIONES = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.Rigidez = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Elasticidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Poisson = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Vonda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Zapata = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RelacionBd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PesoE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nodosd = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Limpiar = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ESFUERZOS
        '
        Me.ESFUERZOS.Location = New System.Drawing.Point(809, 346)
        Me.ESFUERZOS.Name = "ESFUERZOS"
        Me.ESFUERZOS.Size = New System.Drawing.Size(118, 41)
        Me.ESFUERZOS.TabIndex = 0
        Me.ESFUERZOS.Text = "Esfuerzos Planos"
        Me.ESFUERZOS.UseVisualStyleBackColor = True
        '
        'DEFORMACIONES
        '
        Me.DEFORMACIONES.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DEFORMACIONES.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DEFORMACIONES.Location = New System.Drawing.Point(809, 393)
        Me.DEFORMACIONES.Name = "DEFORMACIONES"
        Me.DEFORMACIONES.Size = New System.Drawing.Size(117, 41)
        Me.DEFORMACIONES.TabIndex = 1
        Me.DEFORMACIONES.Text = "Deformaciones Planas"
        Me.DEFORMACIONES.UseVisualStyleBackColor = False
        '
        'SALIR
        '
        Me.SALIR.Location = New System.Drawing.Point(809, 440)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(117, 41)
        Me.SALIR.TabIndex = 2
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'Rigidez
        '
        Me.Rigidez.Location = New System.Drawing.Point(877, 34)
        Me.Rigidez.Name = "Rigidez"
        Me.Rigidez.Size = New System.Drawing.Size(48, 20)
        Me.Rigidez.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(782, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Módulo de Young"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(764, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Módulo de Elasticidad"
        '
        'Elasticidad
        '
        Me.Elasticidad.Location = New System.Drawing.Point(877, 60)
        Me.Elasticidad.Name = "Elasticidad"
        Me.Elasticidad.Size = New System.Drawing.Size(48, 20)
        Me.Elasticidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(776, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Módulo de Poisson"
        '
        'Poisson
        '
        Me.Poisson.Location = New System.Drawing.Point(877, 86)
        Me.Poisson.Name = "Poisson"
        Me.Poisson.Size = New System.Drawing.Size(48, 20)
        Me.Poisson.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(776, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Velocidad de Onda"
        '
        'Vonda
        '
        Me.Vonda.Location = New System.Drawing.Point(877, 112)
        Me.Vonda.Name = "Vonda"
        Me.Vonda.Size = New System.Drawing.Size(48, 20)
        Me.Vonda.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(774, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ancho de la Zapata"
        '
        'Zapata
        '
        Me.Zapata.Location = New System.Drawing.Point(877, 138)
        Me.Zapata.Name = "Zapata"
        Me.Zapata.Size = New System.Drawing.Size(48, 20)
        Me.Zapata.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(800, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Relación B/d"
        '
        'RelacionBd
        '
        Me.RelacionBd.Location = New System.Drawing.Point(877, 164)
        Me.RelacionBd.Name = "RelacionBd"
        Me.RelacionBd.Size = New System.Drawing.Size(48, 20)
        Me.RelacionBd.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(783, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Peso Espacífico"
        '
        'PesoE
        '
        Me.PesoE.Location = New System.Drawing.Point(878, 215)
        Me.PesoE.Name = "PesoE"
        Me.PesoE.Size = New System.Drawing.Size(48, 20)
        Me.PesoE.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(808, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Nodos en d"
        '
        'Nodosd
        '
        Me.Nodosd.Location = New System.Drawing.Point(878, 189)
        Me.Nodosd.Name = "Nodosd"
        Me.Nodosd.Size = New System.Drawing.Size(48, 20)
        Me.Nodosd.TabIndex = 17
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(683, 474)
        Me.DGV.TabIndex = 19
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(809, 295)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(115, 40)
        Me.Limpiar.TabIndex = 20
        Me.Limpiar.Text = "LIMPIAR"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 525)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Nodosd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PesoE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RelacionBd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Zapata)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Vonda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Poisson)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Elasticidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Rigidez)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.DEFORMACIONES)
        Me.Controls.Add(Me.ESFUERZOS)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ESFUERZOS As System.Windows.Forms.Button
    Friend WithEvents DEFORMACIONES As System.Windows.Forms.Button
    Friend WithEvents SALIR As System.Windows.Forms.Button
    Friend WithEvents Rigidez As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Elasticidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Poisson As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Vonda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Zapata As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RelacionBd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PesoE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Nodosd As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Limpiar As System.Windows.Forms.Button

End Class
