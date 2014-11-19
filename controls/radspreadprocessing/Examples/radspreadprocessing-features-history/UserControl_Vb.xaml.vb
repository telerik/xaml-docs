Public Class Default_Vb
    Private Sub New()
    End Sub
    Public Shared Sub UndoRedo()
        '#Region radspreadsheet-model-features-history_0
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue("First cell value")
        worksheet.Cells(0, 0).SetValue("Second cell value")

        workbook.History.Undo()
        workbook.History.Redo()
        '#End Region
    End Sub

    Public Shared Sub IterateCellsAndWorksheetsInWorkbookUndoGroup()
        '#Region radspreadsheet-model-features-history_1
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        workbook.History.BeginUndoGroup()

        worksheet.Cells(0, 0).SetValue(15)
        worksheet.Cells(0, 0).SetFormat(New CellValueFormat("0.00"))

        workbook.History.EndUndoGroup()

        workbook.History.Undo()
        workbook.History.Redo()
        '#End Region
    End Sub

    Public Shared Sub DisableHistory()
        '#Region radspreadsheet-model-features-history_2
        Dim workbook As New Workbook()
        workbook.History.IsEnabled = False
        '#End Region
    End Sub


    Public Shared Sub ClearHistory()
        '#Region radspreadsheet-model-features-history_3
        Dim workbook As New Workbook()
        workbook.History.Clear()
        '#End Region
    End Sub

End Class
