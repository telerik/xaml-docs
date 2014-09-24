Public Class Default_Vb

    Public Sub ResizeRows()
        '#Region radspreadsheet-model-working-with-rows-and-columns-resizing_0
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim rowSelection As RowSelection = worksheet.Rows(5, 7)
        Dim rowsHeight As Double = rowSelection.GetHeight().Value.Value
        rowSelection.SetHeight(New RowHeight(rowsHeight + 50, True))
        '#End Region
    End Sub

    Public Sub AutoFitRowsHeight()
        '#Region radspreadsheet-model-working-with-rows-and-columns-resizing_1
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim rowSelection As RowSelection = worksheet.Rows(5, 7)
        rowSelection.AutoFitHeight()
        '#End Region
    End Sub

    Public Sub ResizeColumns()
        '#Region radspreadsheet-model-working-with-rows-and-columns-resizing_2
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim columnSelection As ColumnSelection = worksheet.Columns(5, 7)
        Dim columnWidth As Double = columnSelection.GetWidth().Value.Value
        columnSelection.SetWidth(New ColumnWidth(columnWidth + 50, True))
        '#End Region
    End Sub

    Public Sub AutoFitColumnsWidth()
        '#Region radspreadsheet-model-working-with-rows-and-columns-resizing_3
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim columnSelection As ColumnSelection = worksheet.Columns(5, 7)
        columnSelection.AutoFitWidth()
        '#End Region
    End Sub

    Public Sub ExpandToFitNumberValuesWidth()
        '#Region radspreadsheet-model-working-with-rows-and-columns-resizing_4
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim columnSelection As ColumnSelection = worksheet.Columns(5, 7)
        columnSelection.ExpandToFitNumberValuesWidth()
        '#End Region
    End Sub
End Class