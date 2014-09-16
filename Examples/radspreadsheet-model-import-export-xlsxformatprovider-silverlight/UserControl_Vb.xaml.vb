Public Class Default_Vb

    '#Region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_0
    Public Sub ImportWorkbookFromXlsx(fileName As String)
        Dim filePath As String = String.Format("http://localhost:54352/Files/{0}", fileName)
        Dim webClient As New WebClient()

        AddHandler webClient.OpenReadCompleted, AddressOf webClient_OpenReadCompleted
        webClient.OpenReadAsync(New Uri(filePath))
    End Sub

    Private Sub webClient_OpenReadCompleted(sender As Object, e As OpenReadCompletedEventArgs)
        Dim formatProvider As New XlsxFormatProvider()

        Dim workbook As Workbook = formatProvider.Import(e.Result)
    End Sub
    '#End Region


    Private Sub ImportWorkbookFromXlsxUsingOpenFileDialog()
        '#Region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_1
        Dim workbook As Workbook

        Dim openFileDialog As New OpenFileDialog()
        Dim formatProvider As New XlsxFormatProvider()
        openFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*"

        If openFileDialog.ShowDialog() = True Then
            Using input As Stream = openFileDialog.File.OpenRead()
                workbook = formatProvider.Import(input)
            End Using
        End If
        '#End Region
    End Sub

    Public Sub ExportWorkbookToXlsx()
        '#Region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_2
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()

        Dim saveFileDialog As New SaveFileDialog()
        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()
        saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*"

        If saveFileDialog.ShowDialog() = True Then
            Using output As Stream = saveFileDialog.OpenFile()
                formatProvider.Export(workbook, output)
            End Using
        End If
        '#End Region
    End Sub

End Class
