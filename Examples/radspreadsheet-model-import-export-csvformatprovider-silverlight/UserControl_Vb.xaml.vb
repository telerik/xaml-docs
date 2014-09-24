Public Class Default_Vb

    '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_3

    Public Class CustomCsvFormatProvider
        Inherits CsvFormatProvider
        Public Overrides ReadOnly Property Settings() As CsvSettings
            Get
                Return New CsvSettings() With {.Delimiter = ";"c}
            End Get
        End Property
    End Class

    '#End Region

    Public Class SilverlightCsvFormatProvider
        '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_0
        Public Sub ImportWorkbookFromCsv(fileName As String)
            Dim filePath As String = String.Format("http://localhost:54352/Files/{0}", fileName)
            Dim webClient As New WebClient()

            AddHandler webClient.OpenReadCompleted, AddressOf webClient_OpenReadCompleted
            webClient.OpenReadAsync(New Uri(filePath))
        End Sub

        Private Sub webClient_OpenReadCompleted(sender As Object, e As OpenReadCompletedEventArgs)
            Dim formatProvider As New CsvFormatProvider()
            Dim workbook As Workbook = formatProvider.Import(e.Result)
        End Sub
        '#End Region

        Private Sub ImportWorkbookFromCsvUsingOpenFileDialog()
            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_1
            Dim workbook As Workbook

            Dim openFileDialog As New OpenFileDialog()
            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"

            If openFileDialog.ShowDialog() = True Then
                Using input As Stream = openFileDialog.File.OpenRead()
                    workbook = formatProvider.Import(input)
                End Using
            End If
            '#End Region
        End Sub

        Public Sub ExportWorkbookToCsv()
            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_2
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

        Private Sub ImportWorkbookFromCsvUsingOpenFileDialogCuctomDelimiter()
            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_4
            Dim workbook As Workbook

            Dim openFileDialog As New OpenFileDialog()
            Dim formatProvider As New CustomCsvFormatProvider()
            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"

            If openFileDialog.ShowDialog() = True Then
                Using input As Stream = openFileDialog.File.OpenRead()
                    workbook = formatProvider.Import(input)
                End Using
            End If
            '#End Region
        End Sub

        Public Sub ExportWorkbookToCsvCustomDelimiter()
            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_5
            Dim workbook As New Workbook()
            workbook.Worksheets.Add()

            Dim saveFileDialog As New SaveFileDialog()
            Dim formatProvider As New CustomCsvFormatProvider()
            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"

            If saveFileDialog.ShowDialog() = True Then
                Using output As Stream = saveFileDialog.OpenFile()
                    formatProvider.Export(workbook, output)
                End Using
            End If
            '#End Region
        End Sub

    End Class
