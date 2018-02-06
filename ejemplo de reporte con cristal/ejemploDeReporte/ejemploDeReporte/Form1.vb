Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()
        BindData()
    End Sub
    Private Sub BindData()
        Dim dt As New DataTable()
        Using con As New MySqlConnection("server=127.0.0.1;database=alumnos;user id=root;password=;")
            con.Open()
            Dim cmd As New MySqlCommand("Select * from alumnos", con)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            con.Close()
        End Using
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindData()
        Dim ds As New DataSet()
        Dim dt As New DataTable()
        dt.Columns.Add("UserId", GetType(Int16))
        dt.Columns.Add("UserName", GetType(String))
        dt.Columns.Add("FirstName", GetType(String))
        dt.Columns.Add("LastName", GetType(String))
        For Each dgr As DataGridViewRow In DataGridView1.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value)
        Next
        ds.Tables.Add(dt)
        ds.WriteXmlSchema("Sample.xml")

        Dim cr = New CrystalReport1()
        cr.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Refresh()
    End Sub
    Public modo As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ObjReporte As New CrystalReport1
        Dim ObjReporte2 As New CrystalReport2
        If modo = 1 Then
            CrystalReportViewer1.ReportSource = ObjReporte
        End If
        If modo = 2 Then
            CrystalReportViewer1.ReportSource = ObjReporte2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New Form1
        f.modo = 1
        f.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New Form1
        f.modo = 2
        f.ShowDialog()
    End Sub
End Class
