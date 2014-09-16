Public Class Default_Vb

    Public Sub Demo()
        '#Region radspreadsheet-features-formatting-cells_0
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim selection As CellSelection = worksheet.Cells(0, 0, 5, 5)
        '#End Region
    End Sub

    Public Sub GetSetClearIsBold()
        '#Region radspreadsheet-features-formatting-cells_1
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim selection As CellSelection = worksheet.Cells(0, 0, 5, 5)

        selection.SetIsBold(True)
        Dim isBold As Boolean = selection.GetIsBold().Value
        selection.ClearIsBold()
        '#End Region
    End Sub

    Public Sub GetSetCellValue()
        '#Region radspreadsheet-features-formatting-cells_7
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim selection As CellSelection = worksheet.Cells(1, 1)

        Dim cellValue As ICellValue = selection.GetValue().Value
        '#End Region

        '#Region radspreadsheet-features-formatting-cells_2
        ' set DateTime value
        selection.SetValue(DateTime.Now)

        ' set double value
        selection.SetValue(51.345)

        ' set ICellValue
        Dim value As ICellValue = worksheet.Cells(5, 5).GetValue().Value
        selection.SetValue(value)

        ' set string value
        selection.SetValue("Total")

        ' set formula value
        selection.SetValue("=C1+C10")
        '#End Region
    End Sub

    Public Sub GetSetCellBorders()
        '#Region radspreadsheet-features-formatting-cells_3
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim purple As New ThemableColor(Color.FromRgb(155, 89, 182))
        Dim darkBlue As New ThemableColor(Color.FromRgb(44, 62, 80))

        Dim purpleBorders As New CellBorders(New CellBorder(CellBorderStyle.Dotted, purple))
        worksheet.Cells(1, 1, 2, 2).SetBorders(purpleBorders)

       
        Dim darkBlueBorders As New CellBorders(New CellBorder(CellBorderStyle.Medium, darkBlue), _ 
                                               New CellBorder(CellBorderStyle.Medium, darkBlue), _
                                               New CellBorder(CellBorderStyle.Medium, darkBlue), _
                                               New CellBorder(CellBorderStyle.Medium, darkBlue), _
                                               New CellBorder(CellBorderStyle.Thin, purple), _
                                               New CellBorder(CellBorderStyle.Thin, purple), _
                                               New CellBorder(CellBorderStyle.None, darkBlue), _
                                               New CellBorder(CellBorderStyle.None, darkBlue))

        worksheet.Cells(1, 4, 2, 5).SetBorders(darkBlueBorders)
        '#End Region
    End Sub

    Public Sub SetPatternFill()
        '#Region radspreadsheet-features-formatting-cells_4
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim diagonalStripePatternFill As New PatternFill(PatternType.DiagonalStripe, Color.FromRgb(231, 76, 60), Color.FromRgb(241, 196, 15))
        worksheet.Cells(0, 0, 0, 5).SetFill(diagonalStripePatternFill)

        Dim solidPatternFill As New PatternFill(PatternType.Solid, Color.FromRgb(46, 204, 113), Colors.Transparent)
        worksheet.Cells(1, 0, 5, 5).SetFill(solidPatternFill)
        '#End Region
    End Sub

    Public Sub SetGradientFill()
        '#Region radspreadsheet-features-formatting-cells_5
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Rows(0).SetHeight(New RowHeight(50, True))

        Dim greenGradientFill As New GradientFill(GradientType.Horizontal, Color.FromRgb(46, 204, 113), Color.FromRgb(0, 134, 56))
        worksheet.Cells(0, 0, 0, 5).SetFill(greenGradientFill)
        '#End Region
    End Sub

    Public Sub IncreaseDecreaseIndent()
        '#Region radspreadsheet-features-formatting-cells_6
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim selection As CellSelection = worksheet.Cells(0, 0, 5, 5)

        selection.IncreaseIndent()
        selection.DecreaseIndent()
        '#End Region
    End Sub

    Public Sub IsIndeterminateExample()
        '#Region "IsIndeterminateDemo"

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetStyleName("Good")
        worksheet.Cells(0, 1).SetStyleName("Bad")

        Dim cell00Value As RangePropertyValue(Of String) = worksheet.Cells(0, 0).GetStyleName()
        'cell at [0, 0] cell00Value.IsIndeterminate is False, cell00Value.Value is Good

        Dim cell01Value As RangePropertyValue(Of String) = worksheet.Cells(0, 1).GetStyleName()
        'cell at [0, 0] cell01Value.IsIndeterminate is False, cell01Value.Value is Bad

        Dim twoCellsValue As RangePropertyValue(Of String) = worksheet.Cells(0, 0, 0, 1).GetStyleName()
        'cells at [0, 0, 0, 1] twoCellsValue.IsIndeterminate is True, twoCellsValue.Value is Normal

        '#End Region
    End Sub

End Class
