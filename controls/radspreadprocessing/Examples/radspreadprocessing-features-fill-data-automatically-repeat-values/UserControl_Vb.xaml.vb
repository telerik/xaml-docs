Public Class Default_Vb
    Public Shared Sub RepeatValuesRight()
        '#Region radspreadsheet-features-auto-fill_0
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue(5)
        worksheet.Cells(1, 0).SetValue(8)
        worksheet.Cells(2, 0).SetValue(13)
        worksheet.Cells(3, 0).SetValue(21)

        Dim range As New CellRange(0, 0, 3, 3)
        worksheet.Cells(range).FillData(FillDirection.Right)
        '#End Region
    End Sub

    Public Shared Sub RepeatValuesDown()
        '#Region radspreadsheet-features-auto-fill_1
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(1, 1).SetValue(34)
        worksheet.Cells(1, 2).SetValue(55)
        worksheet.Cells(1, 3).SetValue(89)

        Dim range As New CellRange(1, 1, 3, 3)
        worksheet.Cells(range).FillData(FillDirection.Down)
        '#End Region
    End Sub

End Class
