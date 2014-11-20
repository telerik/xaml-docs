Public Class Default_Vb

    Public Sub MergeA1B2()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_0

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim A1Cell As New CellIndex(0, 0)
        Dim B2Cell As New CellIndex(1, 1)

        worksheet.Cells(A1Cell, B2Cell).Merge()

        '#End Region
    End Sub

    Public Sub MergeAcrossA1B2()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_1

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim A1Cell As New CellIndex(0, 0)
        Dim B2Cell As New CellIndex(1, 1)
        worksheet.Cells(A1Cell, B2Cell).MergeAcross()

        '#End Region
    End Sub

    Public Sub MergeB2C3()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_2

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim B2Cell As New CellIndex(1, 1)
        Dim C3Cell As New CellIndex(2, 2)
        worksheet.Cells(B2Cell, C3Cell).Merge()

        '#End Region
    End Sub

    Public Sub CheckA1IsMerged()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_3

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim A1CellIndex As New CellIndex(0, 0)
        Dim isA1merged As Boolean = worksheet.Cells.GetIsMerged(A1CellIndex)

        '#End Region
    End Sub

    Public Sub GetContainingMergedRangeForCellA1()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_4

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim A1CellIndex As New CellIndex(0, 0)
        Dim mergedCellRange As CellRange
        Dim canGetContainingMergedCellRange As Boolean = worksheet.Cells.TryGetContainingMergedRange(A1CellIndex, mergedCellRange)

        '#End Region
    End Sub

    Public Sub GetAllContainingMergedRangesInRange()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_5

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim A1CellIndex As New CellIndex(0, 0)
        Dim N33CellIndex As New CellIndex(32, 13)
        Dim A1N33CellRange As New CellRange(A1CellIndex, N33CellIndex)
        Dim containingMergedCellRanges As IEnumerable(Of CellRange) = worksheet.Cells.GetContainingMergedRanges(A1N33CellRange)

        '#End Region
    End Sub

    Public Sub GetAllMergedCells()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_6

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim mergedCellRanges As IEnumerable(Of CellRange) = worksheet.Cells.GetMergedCellRanges()

        '#End Region
    End Sub

    Public Sub UnmergeCells()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_7

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim B2CellIndex As New CellIndex(1, 1)
        Dim D4CellIndex As New CellIndex(3, 3)
        Dim B2D4CellSelection As New CellRange(B2CellIndex, D4CellIndex)
        worksheet.Cells(B2D4CellSelection).Unmerge()

        '#End Region
    End Sub

    Public Sub StartingPoint()
        '#Region radspreadsheet-model-features-merge-and-unmerge-cells_8
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("A1")
        worksheet.Cells(1, 0).SetValue("A2")
        worksheet.Cells(0, 1).SetValue("B1")
        worksheet.Cells(1, 1).SetValue("B2")
        '#End Region
    End Sub

    End Class
