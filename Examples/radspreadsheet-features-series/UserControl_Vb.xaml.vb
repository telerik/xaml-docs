Public Class Default_Vb

    Public Sub FillSeriesLinear()
        '#Region radspreadsheet-features-series_0

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue(1)
        worksheet.Cells(0, 1).SetValue(3)

        Dim range As New CellRange(0, 0, 0, 5)
        worksheet.Cells(range).FillDataSeriesLinear(CellOrientation.Horizontal, 2)

        '#End Region
    End Sub

    Public Sub FillSeriesLinearTrend()
        '#Region radspreadsheet-features-series_1

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue(1)
        worksheet.Cells(0, 1).SetValue(8)
        worksheet.Cells(0, 2).SetValue(3)
        worksheet.Cells(0, 3).SetValue(10)
        worksheet.Cells(0, 4).SetValue(5)

        Dim range As New CellRange(0, 0, 0, 9)
        worksheet.Cells(range).FillDataSeriesLinearTrend(CellOrientation.Horizontal)

        '#End Region
    End Sub

    Public Sub FillSeriesExponential()
        '#Region radspreadsheet-features-series_2

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue(1)
        worksheet.Cells(0, 1).SetValue(3)

        Dim range As New CellRange(0, 0, 0, 5)
        worksheet.Cells(range).FillDataSeriesExponential(CellOrientation.Horizontal, 4)

        '#End Region
    End Sub

    Public Sub FillSeriesExponentialTrend()
        '#Region radspreadsheet-features-series_3

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue(1)
        worksheet.Cells(0, 1).SetValue(5)
        worksheet.Cells(0, 2).SetValue(2)
        worksheet.Cells(0, 3).SetValue(9)

        Dim range As New CellRange(0, 0, 0, 5)
        worksheet.Cells(range).FillDataSeriesExponentialTrend(CellOrientation.Horizontal)

        '#End Region
    End Sub

    Public Sub FillSeriesDate()
        '#Region radspreadsheet-features-series_4

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue(New DateTime(2013, 5, 28))

        Dim range As New CellRange(0, 0, 0, 9)
        worksheet.Cells(range).FillDataSeriesDate(CellOrientation.Horizontal, DateUnitType.Weekday, 2)

        '#End Region
    End Sub

    Public Sub FillSeriesAuto1()
        '#Region radspreadsheet-features-series_5

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue("1st")

        Dim range As New CellRange(0, 0, 0, 5)
        worksheet.Cells(range).FillDataSeriesAuto(CellOrientation.Horizontal, True)

        '#End Region
    End Sub

    Public Sub FillSeriesAuto2()
        '#Region radspreadsheet-features-series_6

        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 5).SetValue("6th")

        Dim range As New CellRange(0, 5, 0, 0)
        worksheet.Cells(range).FillDataSeriesAuto(CellOrientation.Horizontal, True)

        '#End Region
    End Sub

End Class
