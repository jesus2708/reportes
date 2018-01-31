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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(206, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(403, 291)
        Me.DataGridView1.TabIndex = 0
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(31, 180)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(108, 38)
        Me.btnbuscar.TabIndex = 1
        Me.btnbuscar.Text = "Mostrar / Actualizar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(337, 76)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(208, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar:"
        '
        'btnprimero
        '
        Me.btnprimero.Location = New System.Drawing.Point(267, 31)
        Me.btnprimero.Name = "btnprimero"
        Me.btnprimero.Size = New System.Drawing.Size(53, 23)
        Me.btnprimero.TabIndex = 4
        Me.btnprimero.Text = "<"
        Me.ToolTip1.SetToolTip(Me.btnprimero, "Mover al primer registro")
        Me.btnprimero.UseVisualStyleBackColor = True
        '
        'btnanterior
        '
        Me.btnanterior.Location = New System.Drawing.Point(326, 31)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(53, 23)
        Me.btnanterior.TabIndex = 5
        Me.btnanterior.Text = "<<"
        Me.ToolTip1.SetToolTip(Me.btnanterior, "mover al registro anterior")
        Me.btnanterior.UseVisualStyleBackColor = True
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Location = New System.Drawing.Point(385, 31)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(53, 23)
        Me.btnsiguiente.TabIndex = 6
        Me.btnsiguiente.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.btnsiguiente, "mover al siguiente registro")
        Me.btnsiguiente.UseVisualStyleBackColor = True
        '
        'btnultimo
        '
        Me.btnultimo.Location = New System.Drawing.Point(444, 31)
        Me.btnultimo.Name = "btnultimo"
        Me.btnultimo.Size = New System.Drawing.Size(53, 23)
        Me.btnultimo.TabIndex = 7
        Me.btnultimo.Text = ">"
        Me.ToolTip1.SetToolTip(Me.btnultimo, "mover al ultimo registro")
        Me.btnultimo.UseVisualStyleBackColor = True
        '
        'btninsertar
        '
        Me.btninsertar.Location = New System.Drawing.Point(31, 224)
        Me.btninsertar.Name = "btninsertar"
        Me.btninsertar.Size = New System.Drawing.Size(108, 39)
        Me.btninsertar.TabIndex = 8
        Me.btninsertar.Text = "Insertar"
        Me.btninsertar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(31, 269)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(108, 43)
        Me.btnborrar.TabIndex = 9
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(31, 319)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(108, 53)
        Me.btnmodificar.TabIndex = 10
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(83, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(83, 107)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Puesto:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 43)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 473)
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

End Class
