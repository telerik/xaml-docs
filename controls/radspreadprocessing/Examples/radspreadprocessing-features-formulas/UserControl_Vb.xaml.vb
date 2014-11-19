Public Class Default_Vb
    Public Sub ExportWorkbookToCsvWPF()
        ' #Region radspreadsheet-features-formulas_0
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()
        workbook.ActiveWorksheet.Cells(0, 0).SetValue("=3+4")
        '#End Region

        '#Region radspreadsheet-features-formulas_1
        Dim formulaCellValue As FormulaCellValue = TryCast(workbook.ActiveWorksheet.Cells(0, 0).GetValue().Value, FormulaCellValue)
        If formulaCellValue IsNot Nothing Then
            Dim expression As RadExpression = formulaCellValue.Value
            'expression is AdditionExpression with operands 3 and 4

            Dim format As CellValueFormat = workbook.ActiveWorksheet.Cells(0, 0).GetFormat().Value
            Dim valueAsString As String = formulaCellValue.GetValueAsString(format)
            'valueAsString = "=3+4"

            Dim resultValueAsString As String = formulaCellValue.GetResultValueAsString(format)
            'resultAsString = "7"

            Dim valueType As CellValueType = formulaCellValue.ValueType
            'valueType = Formula

            'resultValueType = Number
            Dim resultValueType As CellValueType = formulaCellValue.ResultValueType
        End If
        '#End Region
    End Sub
End Class
