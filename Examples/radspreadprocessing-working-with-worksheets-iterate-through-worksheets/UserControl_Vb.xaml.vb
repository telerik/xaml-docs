Public Class Default_Vb

    Public Sub UseIndexers()
        '#Region radspreadprocessing-working-with-worksheets-iterate-through-worksheets_0
        Dim workbook As New Workbook()

        Dim worksheets As WorksheetCollection = workbook.Worksheets
        worksheets.Add()
        worksheets.Add()

        Dim firstWorksheet As Worksheet = worksheets(0)
        Dim secondWorksheet As Worksheet = worksheets("Sheet2")
        '#End Region
    End Sub

    Public Sub IterateWorksheets()
        '#Region radspreadprocessing-working-with-worksheets-iterate-through-worksheets_1
        Dim workbook As New Workbook()

        For i As Integer = 0 To 9
            workbook.Worksheets.Add()
        Next

        Dim foregroundColor As New ThemableColor(Colors.Red)
        Dim backgroundColor As Color = Colors.Green
        Dim backgroundFill As IFill = New PatternFill(PatternType.Solid, backgroundColor, backgroundColor)

        For Each worksheet As Worksheet In workbook.Worksheets
            Dim cell As CellSelection = worksheet.Cells(0, 0)
            cell.SetValue("The name of this worksheet is: " + worksheet.Name)
            cell.SetForeColor(foregroundColor)
            cell.SetFill(backgroundFill)
        Next
        '#End Region
    End Sub

End Class