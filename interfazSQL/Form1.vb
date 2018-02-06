Imports System.Data
Imports MySql.Data.MySqlClient


Public Class Form1

    Private dv As New DataView

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        Dim cnn As New MySqlConnection("server=127.0.0.1;database=alumnos;user id=root;password=;")
        Dim da As New MySqlDataAdapter("Select * from alumnos where Materia = '" & Me.txtbuscar.Text & "'", cnn)
        Dim ds As New DataSet

        da.Fill(ds)
        dv.Table = ds.Tables(0)
        DataGridView1.DataSource = dv


    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged

        dv.RowFilter = String.Format("Nombre like '{0}%'", txtbuscar.Text)

    End Sub

    Private Sub btnprimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprimero.Click

        'Si la fila no es la fila de nuevos registros...
        If (Not (DataGridView1.Rows(0).IsNewRow)) Then
            '... nos posicionamos en la primera celda de la primera fila
            DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        End If

    End Sub


    Private Sub btnultimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnultimo.Click


        'Posicionarse al ultimo registro del datagrid
        Dim Celda As DataGridViewCell = DataGridView1.CurrentCell
        Celda = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(0)
        DataGridView1.CurrentCell = Celda

    End Sub

    Private Sub btnsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click

        'Posicionarse en el siguiente registro del datagrid
        Dim Celda As DataGridViewCell = DataGridView1.CurrentCell
        Dim fila As Int32 = Celda.RowIndex
        fila += 1
        If fila > DataGridView1.RowCount - 1 Then fila = DataGridView1.RowCount - 1
        Celda = DataGridView1.Rows(fila).Cells(0)
        DataGridView1.CurrentCell = Celda
    End Sub

    Private Sub btnanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanterior.Click

        'posicionarse en el registro anterior del datagrid
        Dim Celda As DataGridViewCell = DataGridView1.CurrentCell
        Dim Fila As Int32 = Celda.RowIndex
        Fila -= 1
        If Fila < 0 Then Fila = 0
        Celda = DataGridView1.Rows(Fila).Cells(0)
        DataGridView1.CurrentCell = Celda


    End Sub


    Private Sub btninsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsertar.Click

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "debe ingresar datos")
        ElseIf TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "debe ingresar datos")
        ElseIf TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "debe ingresar datos")
        Else


            Try
                Dim conex As New MySqlConnection("data source = RICARDO-HP\SQLEXPRESS; Initial catalog = EMPLEADOS; integrated security = SSPI;")
                Dim cmd As New MySqlCommand("insertarempleado", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Clave", MySqlDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = TextBox2.Text
                cmd.Parameters.Add("@Puesto", MySqlDbType.VarChar).Value = TextBox3.Text

                TextBox1.Clear() : TextBox2.Clear() : TextBox3.Clear()
                conex.Open()
                cmd.ExecuteNonQuery()
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "debe ingresar datos")
        ElseIf TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "debe ingresar datos")
        ElseIf TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "debe ingresar datos")
        Else

            Try
                Dim conex As New MySqlConnection("data source = RICARDO-HP\SQLEXPRESS; Initial catalog = EMPLEADOS; integrated security = SSPI;")
                Dim cmd As New MySqlCommand("borrarempleado", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Clave", MySqlDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = TextBox2.Text
                cmd.Parameters.Add("@Puesto", MySqlDbType.VarChar).Value = TextBox3.Text

                TextBox1.Clear() : TextBox2.Clear() : TextBox3.Clear()
                conex.Open()
                cmd.ExecuteNonQuery()
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click


        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "debe ingresar datos")
        ElseIf TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "debe ingresar datos")
        ElseIf TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "debe ingresar datos")
        Else
            Try
                Dim conex As New MySqlConnection("data source = RICARDO-HP\SQLEXPRESS; Initial catalog = EMPLEADOS; integrated security = SSPI;")
                Dim cmd As New MySqlCommand("modificarempleado", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Clave", MySqlDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = TextBox2.Text
                cmd.Parameters.Add("@Puesto", MySqlDbType.VarChar).Value = TextBox3.Text

                TextBox1.Clear() : TextBox2.Clear() : TextBox3.Clear()
                conex.Open()
                cmd.ExecuteNonQuery()
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        TextBox1.MaxLength = 2
        ErrorProvider1.Clear()

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        TextBox2.MaxLength = 50
        ErrorProvider1.Clear()

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 50
        ErrorProvider1.Clear()

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
