Public Class Default_Vb

    Public Sub SetValueMethod()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_0
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue(String.Empty)
        '#End Region
    End Sub

    Public Sub ClearMethod()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_1
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).ClearValue()
        '#End Region
    End Sub

    Public Sub SetBooleanValueUsingString()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_2
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells[0, 0].SetValue(true)
		worksheet.Cells[0, 1].SetValue(false)
        '#End Region
    End Sub

    Public Sub SetBooleanValueUsingICellValue()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_3
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim booleanCellValueTrue As ICellValue = CellValueFactory.Create(True)
        Dim booleanCellValueFalse As ICellValue = CellValueFactory.Create(False)
        worksheet.Cells(0, 0).SetValue(booleanCellValueTrue)
        worksheet.Cells(0,1).SetValue(booleanCellValueFalse)
        '#End Region
    End Sub

    Public Sub SetNumberCellValueUsingString()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_4
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("1.23")
        '#End Region
    End Sub

    Public Sub SetNumberCelllValueUsingICellValue()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_5
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
		
        Dim value As ICellValue = CellValueFactory.Create(3.14)
        worksheet.Cells(0, 0).SetValue(value)
        '#End Region
    End Sub

    Public Sub SetNunmberCellValueWithFormat()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_6
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("1,234.5678")
        '#End Region
    End Sub

    Public Sub SetNunmberCellValueWithCurrencyFormat()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_7
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("$123")
        '#End Region
    End SubPublic Sub SetNunmberCellValueWithDateFormat()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_8
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("10/06/1987")
        '#End Region
    End Sub

    Public Sub SetNunmberCellValueWithTimeFormat()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_9
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("13:30:45")
        '#End Region
    End Sub

    Public Sub SetNunmberCellValueWithPercentageFormat()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_10
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("13%")
        '#End Region
    End Sub

    Public Sub SetNunmberCellValueWithFractionFormat()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_11
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("1 13/67")
        '#End Region
    End Sub

    Public Sub SetNunmberCellValueWithScientificFormat()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_12
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("1.24E+05")
        '#End Region
    End Sub

    Public Sub SetFormulaCellValueUsingString()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_13
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("=A2")
        '#End Region
    End Sub

    Public Sub SetFormulaCellValueUsingPredefinedFormulaString()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_14
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Cells(0, 0).SetValue("=SUM(A2, 3)")
        '#End Region
    End Sub

    Public Sub SetFormulaCellValueUsingICellValue()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_15
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        Dim cellIndex As New CellIndex(0, 0)

        Dim expression As RadExpression
        If RadExpression.TryParse("=B1", worksheet, cellIndex, expression) Then
            worksheet.Cells(cellIndex).SetValue(expression.ToCellValue())
        End If
        '#End Region
    End Sub

    Public Sub SetTextCellValueUsingString()
        '#Region radspreadsheet-model-working-with-cells-cell-value-types_16
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
		
        worksheet.Cells(0, 0).SetValue("Total")
        '#End Region
		
		'#Region radspreadsheet-model-working-with-cells-cell-value-types_17
		Dim rangeValue As RangePropertyValue(Of ICellValue) = worksheet.Cells(0, 0).GetValue()
		Dim value As ICellValue = rangeValue.Value
        '#End Region
    End Sub
	
	Public Sub SetFormulaCellValueUsingPredefinedFormula()
	'#Region "radspreadsheet-model-working-with-cells-cell-value-types_18"
	Dim workbook As New Workbook()
	Dim worksheet As Worksheet = workbook.Worksheets.Add()
	Dim cellIndex As New CellIndex(0, 0)

	Dim cellValue As ICellValue
	Dim newFormatValue As CellValueFormat
	CellValueFactory.Create("=A2 + B2", worksheet, cellIndex, CellValueFormat.GeneralFormat, cellValue, newFormatValue)
	worksheet.Cells(cellIndex).SetValue(cellValue)
	'#End Region
End Sub

Public Sub SetTextCellValueUsingString()
	'#Region "radspreadsheet-model-working-with-cells-cell-value-types_19"
	Dim workbook As New Workbook()
	Dim worksheet As Worksheet = workbook.Worksheets.Add()
	worksheet.Cells(0, 0).SetValue("some text")
	'#End Region
End Sub

Public Sub SetTextCellValueUsingFormulaString()
	'#Region "radspreadsheet-model-working-with-cells-cell-value-types_20"
	Dim workbook As New Workbook()
	Dim worksheet As Worksheet = workbook.Worksheets.Add()
	worksheet.Cells(0, 0).SetFormat(New CellValueFormat("@"))
	worksheet.Cells(0, 0).SetValue("=1+2")
	'#End Region
End Sub

Public Sub SetTextCellValueUsingFormulaStringCellValueFactory()
	'#Region "radspreadsheet-model-working-with-cells-cell-value-types_21"
	Dim workbook As New Workbook()
	Dim worksheet As Worksheet = workbook.Worksheets.Add()
	Dim cellIndex As New CellIndex(0, 0)

	Dim cellValue As ICellValue
	Dim newFormatValue As CellValueFormat
	CellValueFactory.Create("=1 + 2", worksheet, cellIndex, New CellValueFormat("@"), cellValue, newFormatValue)
	worksheet.Cells(cellIndex).SetValue(cellValue)
	'#End Region
End Sub

End Class
