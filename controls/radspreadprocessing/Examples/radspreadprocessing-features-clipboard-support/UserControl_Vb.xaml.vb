Public Class Default_Vb

    ' #Region radspreadsheet-clipboard-support_0
    Dim workbook As New Workbook()
    Dim worksheet As Worksheet = workbook.Worksheets.Add()

        worksheet.Cells(0, 0).SetValue("Product")
        worksheet.Cells(1, 0).SetValue("Service")
        worksheet.Cells(0, 1).SetValue(17.4)
        worksheet.Cells(1, 1).SetValue(12.9)
        worksheet.Cells(2, 0).SetValue("Total")
        worksheet.Cells(2, 1).SetValue("=SUM(A1:B1)")

    Dim copiedCellRange As New CellRange(0, 0, 2, 1)
    Dim worksheetFragment As WorksheetFragment = worksheet.Cells(copiedCellRange).Copy()
    '#End Region

    ' #Region radspreadsheet-clipboard-support_1
    Dim workbook As New Workbook()
    Dim worksheet As Worksheet = workbook.Worksheets.Add()

    worksheet.Cells(0, 0).SetValue("=CONCATENATE(""Rad"", ""Spreadsheet"")")
    worksheet.Cells(0, 0).SetForeColor(New ThemableColor(Colors.Green))

    Dim worksheetFragment As WorksheetFragment = worksheet.Cells(0, 0).Copy()

    Dim pasteOptions As New PasteOptions(PasteType.All)
    worksheet.Cells(1, 0).Paste(worksheetFragment, pasteOptions)
    '#End Region

    ' #Region radspreadsheet-clipboard-support_2
    Dim pasteOptionsValues As New PasteOptions(PasteType.Values)
    worksheet.Cells(2, 0).Paste(worksheetFragment, pasteOptionsValues)
    '#End Region

    ' #Region radspreadsheet-clipboard-support_3
    Dim valuesAndFormatting As New PasteOptions(PasteType.Formulas Or PasteType.Formats)
    worksheet.Cells(3, 0).Paste(worksheetFragment, valuesAndFormatting)
    '#End Region

End Class
