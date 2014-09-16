Public Class Default_Vb

    ' #Region radspreadsheet-features-formulas-cell-reference_0
    Dim workbook As New Workbook()
    workbook.Worksheets.Add()
    workbook.ActiveWorksheet.Cells(0, 2).SetValue("=A1+B1")
    '#End Region

    ' #Region radspreadsheet-features-formulas-cell-reference_1
        workbook.Worksheets.Add()
    Dim sheet1 As Worksheet = workbook.Worksheets(0)
    Dim samsWorksheet As Worksheet = workbook.Worksheets(1)
    samsWorksheet.Name = "Sam'sWorksheet"

    sheet1.Cells(0, 0).SetValue("='Sam''sWorksheet'!B2")
    '#End Region

    ' #Region radspreadsheet-features-formulas-cell-reference_2
    sheet1.Cells(2, 2).SetValue("=SUM(A1:B2)")
    samsWorksheet.Cells(0, 0).SetValue("=PRODUCT(D3:F5)")
    '#End Region

End Class
