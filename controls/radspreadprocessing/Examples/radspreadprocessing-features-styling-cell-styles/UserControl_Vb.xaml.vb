Public Class Default_Vb
    Public Sub IncludeNumberGroup()
        '#Region radspreadsheet-model-features-styling-cell-styles_0
        Dim workbook As New Workbook()
        Dim tempStyle As CellStyle = workbook.Styles("Bad")
        tempStyle.IncludeNumber = True
        '#End Region
    End Sub

    Public Sub CreateCellStyle()
        '#Region radspreadsheet-model-features-styling-cell-styles_1
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()

        Dim cellStyle As CellStyle = workbook.Styles.Add("My style", CellStyleCategory.[Custom])

        cellStyle.BeginUpdate()

        Dim border As New CellBorder(CellBorderStyle.DashDotDot, New ThemableColor(Colors.Red))
        cellStyle.LeftBorder = border
        cellStyle.TopBorder = border
        cellStyle.RightBorder = border
        cellStyle.BottomBorder = border

        Dim patternColor As New ThemableColor(ThemeColorType.Accent1)

        Dim shadeType As System.Nullable(Of ColorShadeType)
        shadeType = ColorShadeType.Shade2
        Dim backgroundColor As New ThemableColor(ThemeColorType.Accent5, shadeType)

        Dim fill As IFill = New PatternFill(PatternType.Gray75Percent, patternColor, backgroundColor)
        cellStyle.Fill = fill

        cellStyle.HorizontalAlignment = RadHorizontalAlignment.Left
        cellStyle.VerticalAlignment = RadVerticalAlignment.Center

        cellStyle.EndUpdate()

        workbook.ActiveWorksheet.Cells(0, 0).SetStyleName("My style")
        '#End Region
    End Sub

    Public Sub ModifyCellStyle()
        '#Region radspreadsheet-model-features-styling-cell-styles_2
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()

        Dim style As CellStyle = workbook.Styles("Bad")

        style.BeginUpdate()

        style.Fill = New PatternFill(PatternType.DiagonalCrosshatch, Colors.Red, Colors.Transparent)
        style.FontSize = UnitHelper.PointToDip(20)
        style.ForeColor = New ThemableColor(Colors.Black)

        style.EndUpdate()
        '#End Region
    End Sub

    Public Sub RemoveCellStyle()
        '#Region  radspreadsheet-model-features-styling-cell-styles_3
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()

        If workbook.Styles.Remove("Bad") Then
            Debug.WriteLine("Style removed")
        Else
            Debug.WriteLine("The style do not exist")
        End If
        '#End Region
    End Sub

End Class
