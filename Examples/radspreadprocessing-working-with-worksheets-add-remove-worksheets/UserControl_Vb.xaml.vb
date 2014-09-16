Public Class Default_Vb

    Public Sub AddWorksheet()
        '#Region radspreadprocessing-working-with-worksheets-add-remove-worksheets_0
        Dim workbook As New Workbook()
        Dim newWorksheet As Worksheet = workbook.Worksheets.Add()
        '#End Region
    End Sub

    Public Sub RemoveWorksheet()
        '#Region radspreadprocessing-working-with-worksheets-add-remove-worksheets_1
        Dim workbook As New Workbook()
        workbook.Worksheets.Add() ' Sheet1
        Dim secondWorksheet As Worksheet = workbook.Worksheets.Add() ' Sheet2
        workbook.Worksheets.Add() ' Sheet3
        workbook.Worksheets.Add() ' Sheet4
        workbook.Worksheets.RemoveAt(3) ' Removed Sheet4
        workbook.Worksheets.Remove("Sheet1") ' Removed Sheet1
        workbook.Worksheets.Remove(secondWorksheet) ' Removed Sheet2
        ' the only worksheet left is Sheet3
        '#End Region
    End Sub

End Class