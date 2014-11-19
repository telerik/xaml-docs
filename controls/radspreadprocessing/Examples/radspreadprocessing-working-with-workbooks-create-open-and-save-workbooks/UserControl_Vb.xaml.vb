Public Class Default_Vb

    Private Sub CreateNewWorkbook()
        '#Region radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks_0
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        '#End Region
    End Sub

    Public Sub ImportWorkbookFromXlsx()
        '#Region radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks_1
        Const FilePath As String = "http://localhost:54352/Resourses/SampleFile.xlsx"
        Dim webClient As New WebClient()

        webClient.OpenReadCompleted += Function(sender, eventArgs)
                                           Dim formatProvider As New XlsxFormatProvider()
                                           Dim workbook As Workbook = formatProvider.Import(eventArgs.Result)

                                       End Function

        webClient.OpenReadAsync(New Uri(FilePath))
        '#End Region
    End Sub

    Public Sub ExportWorkbookToCsvSL()
        '#Region radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks_2
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()

        Dim saveFileDialog As New SaveFileDialog()
        Dim formatProvider As New CsvFormatProvider()
        saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"

        If saveFileDialog.ShowDialog() = True Then
            Using output As Stream = saveFileDialog.OpenFile()
                formatProvider.Export(workbook, output)
            End Using
        End If
        '#End Region
    End Sub

    Public Sub ExportWorkbookToCsvWPF()
        '#Region radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks_3
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()

        Dim fileName As String = "SampleFile.csv"
        Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()

        Using output As New FileStream(fileName, FileMode.Create)
            formatProvider.Export(workbook, output)
        End Using
        '#End Region
    End Sub

End Class
