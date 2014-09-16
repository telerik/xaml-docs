Public Class Default_Vb

    Public Sub InsertCells()
        '#Region radspreadprocessing-working-with-cells-insert-remove-cells_0

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim range As New CellRange(1, 1, 10, 10)
        Dim selection As CellSelection = worksheet.Cells(range)

        If selection.CanInsertOrRemove(range, ShiftType.Right) Then
            selection.Insert(InsertShiftType.Right)
        End If

        '#End Region
    End Sub

    Public Sub RemoveCells()
        '#Region radspreadprocessing-working-with-cells-insert-remove-cells_1

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim range As New CellRange(1, 1, 10, 10)
        Dim selection As CellSelection = worksheet.Cells(range)

        If selection.CanInsertOrRemove(range, ShiftType.Up) Then
            selection.Remove(RemoveShiftType.Up)
        End If

        '#End Region
    End Sub

End Class
