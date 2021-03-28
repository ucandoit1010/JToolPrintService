Imports PDFtoPrinter

Public Class Service1

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' 在此加入啟動服務的程式碼。這個方法必須設定已啟動的
        ' 事項，否則可能導致服務無法工作。


        Dim dftPrinterName = DefaultPrinterHelper.GetDefaultPrinterName()

        FileHelper.WriteFile(String.Format("Printer name = {0}", dftPrinterName))

        Dim printer As New PDFtoPrinterPrinter
        printer.Print(New PrintingOptions(dftPrinterName, "C:\abc.pdf"))

    End Sub

    Protected Overrides Sub OnStop()
        ' 在此加入停止服務所需執行的終止程式碼。
    End Sub

End Class
