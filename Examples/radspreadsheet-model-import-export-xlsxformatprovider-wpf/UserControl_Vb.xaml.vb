Public Class Default_Vb

    Private Sub ImportXlsx()
        '#Region radspreadsheet-model-import-export-xlsxformatprovider-wpf_0
        Dim fileName As String = "SampleFile.xlsx"
        If Not File.Exists(fileName) Then
            Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
        End If

        Dim workbook As Workbook
        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()

        Using input As New FileStream(fileName, FileMode.Open)
            workbook = formatProvider.Import(input)
        End Using
        '#End Region
    End Sub

    Private Sub ExportXlsx()
        '#Region radspreadsheet-model-import-export-xlsxformatprovider-wpf_1
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()
        Dim fileName As String = "SampleFile.xlsx"

        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()

        Using output As New FileStream(fileName, FileMode.Create)
            formatProvider.Export(workbook, output)
        End Using
        '#End Region
    End Sub

End Class
