Public Class Default_Vb

    '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_2

    Public Class CustomCsvFormatProvider
        Inherits CsvFormatProvider
        Public Overrides ReadOnly Property Settings() As CsvSettings
            Get
                Return New CsvSettings() With { _
                    .Delimiter = ";"c _
                }
            End Get
        End Property
    End Class

    '#End Region

    Public Class WpfCsvFormatProvider
        Private Sub ImportCsv()
            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_0
            Dim fileName As String = "FileName.csv"
            If Not File.Exists(fileName) Then
                Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
            End If

            Dim workbook As Workbook
            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()

            Using input As New FileStream(fileName, FileMode.Open)
                workbook = formatProvider.Import(input)
            End Using
            '#End Region
        End Sub

        Private Sub ExportCsv()
            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_1
            Dim workbook As New Workbook()
            workbook.Worksheets.Add()

            Dim fileName As String = "SampleFile.csv"
            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()

            Using output As New FileStream(fileName, FileMode.Create)
                formatProvider.Export(workbook, output)
            End Using
            '#End Region
        End Sub

        Private Sub ImportCsvCustomDelimiter()
            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_3
            Dim fileName As String = "FileName.csv"
            If Not File.Exists(fileName) Then
                Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
            End If

            Dim workbook As Workbook
            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()

            Using input As New FileStream(fileName, FileMode.Open)
                workbook = formatProvider.Import(input)
            End Using
            '#End Region
        End Sub

        Private Sub ExportCsvCustomDelimiter()
            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_4
            Dim workbook As New Workbook()
            workbook.Worksheets.Add()

            Dim fileName As String = "SampleFile.csv"
            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()

            Using output As New FileStream(fileName, FileMode.Create)
                formatProvider.Export(workbook, output)
            End Using
            '#End Region
        End Sub
    End Class


End Class
