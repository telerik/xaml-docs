Public Class Default_Vb

    Public Sub GetActiveWorksheet()
        '#Region "Get Active Worksheet"

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        '#End Region
    End Sub

    Public Sub CreateSelection1()
        '#Region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_0
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim cellIndex As New CellIndex(0, 5)
        Dim selection1 As CellSelection = worksheet.Cells(cellIndex)
        '#End Region
    End Sub

    Public Sub CreateSelection2()
        '#Region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_1
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim cellRange As New CellRange(0, 0, 5, 5)
        Dim selection2 As CellSelection = worksheet.Cells(cellRange)
        '#End Region
    End Sub

    Public Sub CreateSelection3()
        '#Region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_2
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim ranges As New List(Of CellRange)()
        ranges.Add(New CellRange(0, 0, 5, 5))
        ranges.Add(New CellRange(0, 10, 5, 15))
        Dim selection3 As CellSelection = worksheet.Cells(ranges)
        '#End Region
    End Sub

    Public Sub CreateSelection4()
        '#Region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_3
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim fromIndex As New CellIndex(0, 0)
        Dim toIndex As New CellIndex(5, 5)
        Dim selection4 As CellSelection = worksheet.Cells(fromIndex, toIndex)
        '#End Region
    End Sub

    Public Sub CreateSelection5()
        '#Region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_4

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim selection5 As CellSelection = worksheet.Cells(0, 5)
        '#End Region
    End Sub

    Public Sub CreateSelection6()
        '#Region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_5
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim selection6 As CellSelection = worksheet.Cells(0, 0, 5, 5)
        '#End Region
    End Sub

End Class
