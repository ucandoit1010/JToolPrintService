Imports System.IO

Public Class FileHelper

    Private Const filePath As String = "C:\"

    Public Shared Function WriteFile(content As String)

        Dim fullPath As String = Path.Combine(filePath, Date.Now.ToString("yyyyMMdd"))

        Using writer As StreamWriter = New StreamWriter(fullPath, True)
            writer.WriteLine(content)
            writer.WriteLine(Environment.NewLine)
        End Using

    End Function


End Class
