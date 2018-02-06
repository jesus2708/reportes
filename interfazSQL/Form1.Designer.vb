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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnprimero = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnultimo = New System.Windows.Forms.Button()
        Me.btninsertar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(275, 132)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(537, 358)
        Me.DataGridView1.TabIndex = 0
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(41, 222)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(144, 47)
        Me.btnbuscar.TabIndex = 1
        Me.btnbuscar.Text = "Mostrar / Actualizar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(449, 94)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(276, 22)
        Me.txtbuscar.TabIndex = 2
        Me.txtbuscar.Text = "5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar:"
        '
        'btnprimero
        '
        Me.btnprimero.Location = New System.Drawing.Point(356, 38)
        Me.btnprimero.Margin = New System.Windows.Forms.Padding(4)
        Me.btnprimero.Name = "btnprimero"
        Me.btnprimero.Size = New System.Drawing.Size(71, 28)
        Me.btnprimero.TabIndex = 4
        Me.btnprimero.Text = "<"
        Me.ToolTip1.SetToolTip(Me.btnprimero, "Mover al primer registro")
        Me.btnprimero.UseVisualStyleBackColor = True
        '
        'btnanterior
        '
        Me.btnanterior.Location = New System.Drawing.Point(435, 38)
        Me.btnanterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(71, 28)
        Me.btnanterior.TabIndex = 5
        Me.btnanterior.Text = "<<"
        Me.ToolTip1.SetToolTip(Me.btnanterior, "mover al registro anterior")
        Me.btnanterior.UseVisualStyleBackColor = True
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Location = New System.Drawing.Point(513, 38)
        Me.btnsiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(71, 28)
        Me.btnsiguiente.TabIndex = 6
        Me.btnsiguiente.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.btnsiguiente, "mover al siguiente registro")
        Me.btnsiguiente.UseVisualStyleBackColor = True
        '
        'btnultimo
        '
        Me.btnultimo.Location = New System.Drawing.Point(592, 38)
        Me.btnultimo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnultimo.Name = "btnultimo"
        Me.btnultimo.Size = New System.Drawing.Size(71, 28)
        Me.btnultimo.TabIndex = 7
        Me.btnultimo.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnultimo, "mover al ultimo registro")
        Me.btnultimo.UseVisualStyleBackColor = True
        '
        'btninsertar
        '
        Me.btninsertar.Location = New System.Drawing.Point(41, 276)
        Me.btninsertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(144, 48)
        Me.btninsertar.TabIndex = 8
        Me.btninsertar.Text = "Insertar"
        Me.btninsertar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(41, 331)
        Me.btnborrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(144, 53)
        Me.btnborrar.TabIndex = 9
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(41, 393)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(144, 65)
        Me.btnmodificar.TabIndex = 10
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 62)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(111, 94)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(111, 132)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Puesto:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 465)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 53)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(419, 509)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(244, 46)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "generar reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 582)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btninsertar)
        Me.Controls.Add(Me.btnultimo)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.btnanterior)
        Me.Controls.Add(Me.btnprimero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnprimero As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnultimo As System.Windows.Forms.Button
    Friend WithEvents btninsertar As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
End Class
