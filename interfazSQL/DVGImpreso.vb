Option Explicit On
Option Strict On
Imports System.IO
Imports PdfSharp
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports PdfSharp.Drawing
Imports PdfSharp.Drawing.Layout

Public Class DGVImpreso
    Private mGrafico As XGraphics
    Private mSaltoLinea As Double
    Private mPosX As Integer
    Private mPosY As Integer
    Private mAncho As Integer
    Private mAlto As Integer
    Private mAltoModulo As Integer
    Private maTamaño() As Integer
    Private Const cPosXIni As Integer = 7
    Private Const cPosYIni As Integer = 7

    Public Sub New(ByVal vGrafico As XGraphics, ByVal vSaltoLinea As Integer, ByVal vPosX As Integer, ByVal vPosY As Integer, ByVal vAncho As Integer, ByVal vAlto As Integer, ByVal vAltoModulo As Integer, ByRef raTamaño() As Integer)
        mGrafico = vGrafico
        mSaltoLinea = vSaltoLinea
        mPosX = vPosX
        mPosY = vPosY
        mAncho = vAncho
        mAlto = vAlto
        mAltoModulo = vAltoModulo
        maTamaño = raTamaño
    End Sub

    Public Sub Cabecera(ByRef DGV As DataGridView, ByRef Boli As LapizPDF, ByVal vFuente As XFont, ByVal vTexto As String)
        Boli.CuadroRedondo(cPosXIni, cPosYIni, mAncho, mAlto, 3)
        Boli.CuadroRedondo(cPosXIni, cPosYIni, mAncho, mAltoModulo * 2, 0, True)
        Boli.TextoFormateado(vTexto, vFuente, XBrushes.Black, 10, CInt(mAltoModulo / 2), mAncho, 10, XParagraphAlignment.Center)
        Boli.TextoFormateado("Fecha: " & CStr(Date.Today), vFuente, XBrushes.Black, 10, CInt(mAltoModulo / 2), (mAncho - cPosXIni), cPosXIni, XParagraphAlignment.Right)
        Boli.LineaH(cPosXIni, mAltoModulo + cPosYIni, mAncho, 1)
        mPosX = 30
        mPosY = mAltoModulo + 40
        'Dim liLineaV As Integer = 0
        For liCiclo As Integer = 0 To DGV.ColumnCount - 1
            Boli.Texto(vbNullString & DGV.Columns(liCiclo).Name, vFuente, XBrushes.Black, mPosX, mPosY)
            If liCiclo < DGV.ColumnCount - 1 Then
                mPosX += maTamaño(liCiclo)
                'liLineaV += 1
                'If liLineaV <= mColVisibles Then
                Boli.LineaV((mPosX - 5), mAltoModulo + cPosYIni, mAlto + cPosYIni - (mAltoModulo * 2), 1)
                'End If
            End If
        Next
        mPosY = CInt((mAltoModulo * 2) + (mSaltoLinea * 3))
    End Sub

    Public Sub Linea(ByRef Fila As DataGridViewRow, ByRef Boli As LapizPDF, ByVal vFuente As XFont)
        mPosX = 30
        For liCiclo As Integer = 0 To Fila.Cells.Count - 1
            'If Fila.Cells(liCiclo).Visible = True Then
            Boli.Texto(vbNullString & Fila.Cells(liCiclo).Value.ToString, vFuente, XBrushes.Black, mPosX, mPosY)
            If liCiclo < Fila.Cells.Count - 1 Then
                mPosX += maTamaño(liCiclo)
            End If
            'End If
        Next
        mPosY += CInt(mSaltoLinea)
    End Sub

    Public Sub Pie(ByRef Boli As LapizPDF, ByVal vFuente As XFont, ByVal vPagina As Integer, ByVal vPaginas As Integer)
        mPosX = 20
        mPosY = CInt(mAlto - mAltoModulo) + cPosYIni
        Boli.LineaH(10, mPosY, mAncho, 1)
        Boli.CuadroRedondo(cPosXIni, mPosY, mAncho, mAltoModulo, 0, True)
        Boli.TextoFormateado("Pie de pagina", vFuente, XBrushes.Black, mPosX, mPosY + 20, (mAncho - 2 * mPosX), mAltoModulo, XParagraphAlignment.Left)
        Boli.TextoFormateado("Pagina: " & CStr(vPagina) & " de " & vPaginas, vFuente, XBrushes.Black, mPosX, mPosY + 20, (mAncho - mPosX), mAltoModulo, XParagraphAlignment.Right)
    End Sub
End Class
