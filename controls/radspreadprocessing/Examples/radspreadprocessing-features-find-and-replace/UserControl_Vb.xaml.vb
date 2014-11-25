Public Class Default_Vb

    ' #Region radspreadsheet-features-find-and-replace_0
    Dim workbook As New Workbook()
    Dim worksheet1 As Worksheet = workbook.Worksheets.Add()
    Dim worksheet2 As Worksheet = workbook.Worksheets.Add()

        worksheet1.Cells(1, 1).SetValue("SUMMARY")
        worksheet1.Cells(1, 2).SetValue("=SUM(5, 6)")

        worksheet2.Cells(2, 2).SetValue("=SUM(4, 4)")
        worksheet2.Cells(2, 3).SetValue("SUM")

    Dim options As New FindOptions() With { _
         .StartCell = New WorksheetCellIndex(worksheet1, 0, 0), _
        .FindBy = FindBy.Rows, _
        .FindIn = FindInContentType.Formulas, _
        .FindWhat = "SUM", _
        .FindWithin = FindWithin.Workbook _
    }

    Dim findResult As FindResult = workbook.Find(options)
    Dim findResults As IEnumerable(Of FindResult) = workbook.FindAll(options)
    '#End Region

    ' #Region radspreadsheet-features-find-and-replace_1
    Dim workbook As New Workbook()
    Dim worksheet1 As Worksheet = workbook.Worksheets.Add()
    Dim worksheet2 As Worksheet = workbook.Worksheets.Add()

        worksheet1.Cells(1, 1).SetValue("SUMMARY")
        worksheet1.Cells(1, 2).SetValue("=SUM(5, 6)")

        worksheet2.Cells(2, 2).SetValue("=SUM(4, 4)")
        worksheet2.Cells(2, 3).SetValue("SUM")

    Dim options As New ReplaceOptions() With { _
        .StartCell = New WorksheetCellIndex(worksheet1, 0, 0), _
        .FindBy = FindBy.Rows, _
        .FindIn = FindInContentType.Formulas, _
        .FindWhat = "SUM", _
        .ReplaceWith = "Test", _
        .FindWithin = FindWithin.Workbook _
    }

    Dim findResult = workbook.Find(options)

        options.StartCell = findResult.FoundCell

        If workbook.Replace(options) Then
            RadWindow.Alert("Replace was successful!")
        End If

        workbook.ReplaceAll(options)
    '#End Region

End Class
