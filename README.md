# JToolPrintService PDF 列印服務

因為公司要求用 Visual Basic.NET，需要 C# 版本請自行修改

使用 Windows API 取得本機預設印表機名稱

只要讓 User 修改 Windows 預設印表機，JToolPrintService 就能抓預設印表機來列印

## 引用PDFtoPrinter 套件列印 https://github.com/svishnevsky/PDFtoPrinter

安裝服務請記得將 Windows 登入帳號設密碼，然後在 Windows >> 服務 裡面指定登入的帳號、密碼

## 使用情境

如果 Web 要直接列印到印表機，不想透過 Browser ，就可以使用這個專案，

Web 可以使用 localhost ，將這個服務修改成 HttpListener，等待 Web 呼叫。

## 使用問題

有任何問題可以建立 Issue 通知我
