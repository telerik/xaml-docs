Public Class Default_Vb
    '#Region radspreadsheet-features-number-formats_0
    Public Sub ApplyFormat()
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim cellSelectionA1 As CellSelection = worksheet.Cells(New CellIndex(0, 0))
        Dim scientificFormat As New CellValueFormat("0.00E+00")
        cellSelectionA1.SetFormat(scientificFormat)

        Dim cellSelectionA2B3 As CellSelection = worksheet.Cells(New CellRange(New CellIndex(1, 0), New CellIndex(2, 1)))
        Dim percentageFormat As New CellValueFormat("0.00%")
        cellSelectionA2B3.SetFormat(percentageFormat)
    End Sub

    '#End Region


    '#Region radspreadsheet-features-number-formats_1
    Public Sub GetFormat()
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim cellSelectionA1 As CellSelection = worksheet.Cells(New CellIndex(0, 0))
        Dim cellSelectionA2B3 As CellSelection = worksheet.Cells(New CellRange(New CellIndex(1, 0), New CellIndex(2, 1)))

        Dim cellSelectioA1Format As CellValueFormat = cellSelectionA1.GetFormat().Value
        Dim cellSelectioA2Format As CellValueFormat = cellSelectionA2B3.GetFormat().Value
    End Sub
    '#End Region


End Class
