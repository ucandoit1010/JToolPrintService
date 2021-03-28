Imports System.Runtime.InteropServices
Imports System.Text

Public Class DefaultPrinterHelper

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetDefaultPrinter(ByVal pszBuffer As StringBuilder, ByRef size As Integer) As Boolean


    End Function


    Public Shared Function GetDefaultPrinterName() As String
        Dim pszBuffer As StringBuilder = New StringBuilder(256)
        pszBuffer.Length = 256

        Dim pcchBuffer As Integer = pszBuffer.Length
        Dim retVal As Boolean = GetDefaultPrinter(pszBuffer, pcchBuffer)

        Return pszBuffer.ToString().Trim()
    End Function

End Class
