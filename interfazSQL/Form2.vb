Option Strict On
Option Explicit On
Imports System.IO
Imports PdfSharp
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports MySql.Data.MySqlClient

Public Class Form2

    Private maTamaño() As Integer
    Private miTamaño As Integer = 0
    Private miPaginas As Integer = 0
    Private miPaginaActual As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.DataGridView1.AllowUserToAddRows = False
        Dim msCadenaSQL As String = "server=127.0.0.1;database=alumnos;user id=root;password=;"
        Try
            ' Configuramos una conexión con el origen de datos.
            Using loConexion As New MySqlConnection(msCadenaSQL)
                ' crear adaptadores
                Dim lDataAdapter As New MySqlDataAdapter("Select * from alumnos", loConexion)
                Dim lDataTable As New DataTable
                lDataAdapter.Fill(lDataTable)
                Me.DataGridView1.DataSource = lDataTable
                ReDim maTamaño(Me.DataGridView1.ColumnCount - 1)
                For liCiclo As Integer = 0 To Me.DataGridView1.ColumnCount - 1
                    maTamaño(liCiclo) = Me.DataGridView1.Columns(liCiclo).Width
                    miTamaño += Me.DataGridView1.Columns(liCiclo).Width
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        lP_ImprimirDGV(Me.DataGridView1)
    End Sub

    Private Sub lP_ImprimirDGV(ByRef roDGV As DataGridView)
        Dim ldSaltoLinea As Double
        ' Crea el documento Pdf
        Dim Documento As PdfDocument = New PdfDocument
        ' Crea un objeto pagina
        Dim Pagina As PdfPage
        ' Añade una pagina vacia
        Pagina = Documento.AddPage
        Pagina.Size = PageSize.A4
        ' Crea un Objeto XGraphics 
        Dim Grafico As XGraphics
        ' Asigna un Objeto XGraphics a la pagina
        Grafico = XGraphics.FromPdfPage(Pagina)
        ' Crea un Objeto LapizPDF
        Dim miBoli As New LapizPDF(Grafico)
        ' Crea la fuente
        Dim FuenteLinea As XFont = New XFont("Courier New", 10, XFontStyle.Regular)
        Dim FuenteCabecera As XFont = New XFont("Bradley Hand ITC", 12, XFontStyle.Bold)
        ldSaltoLinea = FuenteLinea.GetHeight(Grafico)
        Dim Archivo As String = Directory.GetCurrentDirectory() & "\Prueba.pdf"
        Dim liLinea As Integer = 0
        Dim liAncho As Integer
        Dim liAlto As Integer
        Dim liAltomodulo As Integer = 40
        Dim liNumLineas As Integer
        Dim miPaginaActual As Integer = 0
        If miTamaño > 570 Then
            Pagina.Orientation = PageOrientation.Portrait
            liAncho = 575
            liAlto = 820
        Else
            Pagina.Orientation = PageOrientation.Landscape
            liAncho = 820
            liAlto = 575
        End If
        liNumLineas = CInt(((liAlto - (liAltomodulo * 3)) / CInt(ldSaltoLinea)) - 3)
        If Me.DataGridView1.RowCount Mod liNumLineas = 0 Then
            miPaginas = Me.DataGridView1.RowCount \ liNumLineas
        Else
            miPaginas = (Me.DataGridView1.RowCount \ liNumLineas) + 1
        End If
        miPaginaActual += 1
        Dim miDgv As New DGVImpreso(Grafico, CInt(ldSaltoLinea), 30, 30, liAncho, liAlto, liAltomodulo, maTamaño)
        'IMPRIMIR LA CABECERA
        miDgv.Cabecera(Me.DataGridView1, miBoli, FuenteCabecera, "LISTADO DE PRUEBA")
        liLinea = 0
        'recorrer todo el datagrid
        For Each loFila As DataGridViewRow In roDGV.Rows
            If liLinea = liNumLineas Then
                miDgv.Pie(miBoli, FuenteCabecera, miPaginaActual, miPaginas)
                liLinea = 0
                ' Añade una pagina vacia
                Pagina = Documento.AddPage
                Pagina.Size = PageSize.A4
                If miTamaño > 570 Then
                    Pagina.Orientation = PageOrientation.Portrait
                Else
                    Pagina.Orientation = PageOrientation.Landscape
                End If
                ' Asigna un Objeto XGraphics a la pagina
                Grafico = XGraphics.FromPdfPage(Pagina)
                ' Asigna un Objeto LapizPDF al Grafico
                miBoli = New LapizPDF(Grafico)
                miDgv = New DGVImpreso(Grafico, CInt(ldSaltoLinea), 30, 30, liAncho, liAlto, liAltomodulo, maTamaño)
                miPaginaActual += 1
                'IMPRIMIR LA CABECERA
                miDgv.Cabecera(Me.DataGridView1, miBoli, FuenteCabecera, "LISTADO DE PRUEBA")
            End If
            'Imprimir Linea
            miDgv.Linea(loFila, miBoli, FuenteLinea)
            liLinea += 1
        Next
        miDgv.Pie(miBoli, FuenteCabecera, miPaginaActual, miPaginas)
        Try
            'si el archivo esta abierto da error, para que averiguen como saber si el archivo esta abierto y cerrarlo antes de grabar uno nuevo
            Documento.Save(Archivo)
            Process.Start(Archivo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "lP_Imprimir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End Try
    End Sub

End Class