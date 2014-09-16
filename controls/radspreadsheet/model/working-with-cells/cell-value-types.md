---
title: Cell Value Types
page_title: Cell Value Types
description: Cell Value Types
slug: radspreadsheet-model-working-with-cells-cell-value-types
tags: cell,value,types
publish: False
position: 4
---

# Cell Value Types



The current article briefly describes how to work with the __Value__ property of __RadSpreadsheet__'s cells
        and focuses on the different types of values supported by the document model. It contains the following sections:
      

* [Working with the Value Property of Cells](#working-with-the-value-property-of-cells)

* [EmptyCellValue](#empty-cell-value)

* [BooleanCellValue](#boolean-cell-value)

* [NumberCellValue](#number-cell-value)

* [FormulaCellValue](#formula-cell-value)

* [TextCellValue](#text-cell-value)

## Working with the Value Property of Cells

Since cells are the atomic data units of a worksheet, their __Value__ property is used frequently. The property is of type
          __ICellValue__ – an interface that is implemented by all five concrete value types supported by the document model: EmptyCellValue,
          BooleanCellValue, NumberCellValue, FormulaCellValue and TextCellValue. The __ICellValue__ interface exposes several properties and methods:
        

* __RawValue__ – the property holds the string value entered by the user, opposed to the result value displayed in the cell.
              For example, when the user enters the string "=1+2" in a cell, the Value of the cell becomes a FormulaCellValue instance with result value
              of "3" and RawValue of "=1+2".
            

* __ValueType__ and __ResultValueType__ – the two properties are of type CellValueType and provide information
              about the type of the Value and its result. For example, the FormulaCellValue with RawValue of "=1+2" has a Formula ValueType and a Number
              ResultValueType. Similarly, the string "=CONCATENATE("abc", "def")" produces a FormulaCellValue with Formula ValueType
              and Text ResultValueType.
            

* __GetValueAsString()__ and __GetResultValueAsString()__ – the two methods require a CellValueFormat argument
              that specifies how to present the Value and the ResultValue of the ICellValue object as strings.
            

To access the Value property of cells, first you need to create a CellSelection object that designates the cell or region of cells you would like to work
          with. Just like all other properties of the worksheet’s cells, the Value property has three methods that respectively set, get and clear its value:
          SetValue(), GetValue() and ClearValue().
        

The SetValue() method has multiple overloads that allow you to pass a double, a string, a Boolean value, a DateTime instance or an ICellValue object.
          For example, the next snippet sets the Value of cell A1 to "Total":
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_16}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            worksheet.Cells[0, 0].SetValue("Total");
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_16}}
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



Another option for setting the cell value is to use the Create() method of the CellValueFactory class to produce an ICellValue and then assign the value using the
          SetValue(ICellValue) method. Similarly to SetValue(), the method Create() has multiple overloads that allow you to enter a string, double or Boolean value. The
          following example creates a NumberCellValue with value 3.14 and assigns it to cell A1.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_5}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            ICellValue value = CellValueFactory.Create(3.14);
	            worksheet.Cells[0, 0].SetValue(value);
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_5}}
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



If you now retrieve the Value of cell A1, the GetValue() method will return an instance of NumberCellValue with RawValue equal to "3.14" and both ValueType
          and ResultValueType equal to Number.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_17}}
	            RangePropertyValue<ICellValue> rangeValue = worksheet.Cells[0, 0].GetValue();
	            ICellValue value = rangeValue.Value;
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_17}}
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



Note that the GetValue() method does not return an ICellValue directly, but it provides an RangePropertyValue<ICellValue> instance. The RangePropertyValue is
          used to determine whether the value of a region of cells is homogeneous. In other words, if you attempt to retrieve the value of the cell region A1:B2 and the values
          in these cells are different, the RangePropertyValue will specify that the values vary. The class exposes two properties that describe the values in the chosen cell
          range:
        

* __IsIndeterminate__ - the Boolean property indicates whether the Value property is consistent among all cells in the specified CellSelection.
              If all cells have one and the same Value, __IsIndeterminate__ is set to false. However, if the Value property varies throughout the cells in
              the CellSelection, the IsIndetermine property is set to true and the __Value__ property of the __RangePropertyValue<ICellValue>__
              instance is set to its default value – EmptyCellValue.
            

* __Value__ - if the __IsIndeterminate__ property is set to false, __Value__ holds the ICellValue
              of the whole CellSelection region. If the __IsIndeterminate__ property is set to true, then the cells in the CellSelection region contain
              different values and the Value property is set to its default – EmptyCellValue.
            

## Empty Cell Value

__EmptyCellValue__ is the default cell value type in __RadSpreadsheet__. When an empty worksheet is added to the workbook,
          the Value property of all its cells is of type EmptyCellValue. The RawValue of an EmptyCellValue is an empty string and its ValueType is Empty.
        

If a cell already contains another value, you can set an empty value for it using the __ClearValue()__ method. The next snippet clears the value
          of cell A1:
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_1}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Cells[0, 0].ClearValue();
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_1}}
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



## Boolean Cell Value

As its name suggests, the __BooleanCellValue__ type contains a value of type bool. The RawValue of each BooleanCellValue is either "TRUE" 
          or "FALSE" and the ValueType is Boolean. You can easily assign to a cell a BooleanCellValue using the SetValue(bool) overload. The following snippet sets 
          the values of cells A1 and B1 to true and false BooleanCellValues, respectively.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_2}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Cells[0, 0].SetValue(true);
	            worksheet.Cells[0, 1].SetValue(false);
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_2}}
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



Another way to assign cells Boolean values is through using the static __Create()__ method of the CellValueFactory class to produce a 
          __BooleanCellValue__ and then passing the this cell value instance to the __SetValue()__ method. The next example 
          illustrates this approach.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_3}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            ICellValue booleanCellValueTrue = CellValueFactory.Create(true);
	            ICellValue booleanCellValueFalse = CellValueFactory.Create(false);
	            worksheet.Cells[0, 0].SetValue(booleanCellValueTrue);
	            worksheet.Cells[0, 1].SetValue(booleanCellValueFalse);
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_3}}
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



## Number Cell Value

The __NumberCellValue__ contains a value of type double. The ValueType of each NumberCellValue instance is Number and the RawValue is the string 
          representation of the double it holds internally. Note that the RawValue of the NumberCellValue may be different from the value that appears in the cell since a cell 
          value format may be applied. For example, if two cells present to the user "50.00%" and "5.00E-01", actually they both contain a NumberCellValue 
          with a RawValue "0.5". The values appear differently, because percentage format has been applied to the first cell and scientific format – to the second cell. 
          In fact, dates in RadSpreadsheet are also number values presented in date format. For example, 16 September 2020 is actually the number 44090. You can find detailed 
          description of the possible number formats and examples of their automatic assigning in the Number Formatting article.
        

The __SetValue()__ method has several overloads that produce a NumberCellValue. You can use SetValue(double) and pass the double value or 
          SetValue(DateTime) and hand in the a DateTime instance that will be internally converted to a number. Also, you can use the SetValue(string) and pass the string 
          representation of the number you would like to set. Note that the SetValue(string) method attempts to parse the string you provide to all values and turns it into a 
          __TextCellValue__ only if it cannot produce any of the other types of values. The following snippet shows how to set the value of cell A1 to 1.23.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_4}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Cells[0, 0].SetValue("1.23");
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_4}}
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



You can use the SetValue(string) method to assign dates. The next example sets the value of cell A1 to 6 October 1987 (in culture "en-US"). Once set, the 
          value of A1 is a NumberCellValue with RawValue 32056. Because the document model detects that this is a date string, a date format is automatically applied to the 
          cell, so that the value appears as a date.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_8}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Cells[0, 0].SetValue("10/06/1987");
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_8}}
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



Contained double value:   32056
        

Applied format:   m/d/yyyy
        

## Formula Cell Value

The __FormulaCellValue__ contains a value of type __RadExpression__, which represents an arithmetic expression, built-up 
          by constants, operators, cell references and functions. The CellValueType of FormulaCellValues is Formula and their RawValue should start with an equal sign (=).
        

Again, there are a couple of approaches to set a FormulaCellValue to a cell: invoking the __Setvalue()__ method with a string and passing to 
          the SetValue() method an ICellValue instance that is retrieved through the __Create()__ method of the __CellValueFactory__ 
          class. Note, however, that both methods will produce a FormulaCellValue only if the current CellValueFormat is not Text. If the format of the cell is Text, the 
          SetValue() and Create() will produce a TextCellValue. That said, if you would like to use present formula values as strings, you can set the CellValueFormat property 
          of the specified cell before you input the values.
        

You can set a FormulaCellValue through the SetValue() method by passing a string that starts with an equal sign (=). Here is, for example, how you can create a 
          formula that refers to another cell.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_13}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Cells[0, 0].SetValue("=A2");
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_13}}
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



After this code is executed the value of cell *A1* will be the same as the value of cell A2.
          When the value of A2 is modified, the change will be reflected in A1 automatically.
        

An expression can also contain a predefined function that performs a given calculation. The document model of RadSpreadsheet offers a number of built-in functions. 
          You can read more about the available functions in RadSpreadsheet in the Functions article. Note that if the current CellValueFormat of the cell is Text 
          ("@"), the method will produce a TextCellValue instead of a FormulaCellValue.
        

The following example illustrates the use of the SUM built-in function.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_14}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Cells[0, 0].SetValue("=SUM(A2, 3)");
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_14}}
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



Another way of setting a FormulaCellValue is passing an __ICellValue__ object to the __SetValue()__ method. Once again, the 
          CellValueFactory’s Create() method is used. Note that unlike the BooleanCellValue and the NumberCellValue, you will need to pass the Worksheet and the CellIndex 
          instances as parameters. These two arguments are required in case the RadExpression contains references to cells in the other worksheets. Additionally, this 
          overload of the Create() method requires the current cell value format to be passed as a parameter, and based on its value, the method provides the new cell value 
          format value that should be applied. Note that if the current CellValueFormat is Text ("@"), the method will produce a TextCellValue instead of a 
          FormulaCellValue.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_18}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            CellIndex cellIndex = new CellIndex(0, 0);
	
	            ICellValue cellValue;
	            CellValueFormat newFormatValue;
	            CellValueFactory.Create("=A2 + B2", worksheet, cellIndex, CellValueFormat.GeneralFormat, out cellValue, out newFormatValue);
	            worksheet.Cells[cellIndex].SetValue(cellValue);
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_18}}
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



## Text Cell Value

As its name suggests, the __TextCellValue__ contains a value of type string and its ValueType is Text.
        

You can set a TextCellValue using the __SetValue(string)__ method. Note that before producing a TextCellValue, the SetValue() method attempt to 
          parse the incoming string to all other cell value types. That said, if you pass the string "true", the cell will be assigned a BooleanCellValue. If you 
          would like the cell to contain the string "true", pass the SetValue(string) method the string ="true".
        

The following snippet sets the value of cell A1 to the string "some test":
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_19}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Cells[0, 0].SetValue("some text");
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_19}}
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



If you would like to avoid the default parsing of the input string and always produce a TextCellValue, you need to set the CellValueFormat of the cells to Text 
          ("@") and then enter the values. The following example enters the string "=1+2" into a cell, however, because of the applied cell value format, 
          the cell is assigned a TextCellValue instead of a FormulaCellValue.
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_20}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Cells[0, 0].SetFormat(new CellValueFormat("@"));
	            worksheet.Cells[0, 0].SetValue("=1+2");
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_20}}
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



The same result could be achieved using the __Create()__ method of the __CellValueFactory__ class:
        

#### __C#__

{{region radspreadsheet-model-working-with-cells-cell-value-types_21}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            CellIndex cellIndex = new CellIndex(0, 0);
	
	            ICellValue cellValue;
	            CellValueFormat newFormatValue;
	            CellValueFactory.Create("=1 + 2", worksheet, cellIndex, new CellValueFormat("@"), out cellValue, out newFormatValue);
	            worksheet.Cells[cellIndex].SetValue(cellValue);
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-cells-cell-value-types_21}}
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



# See Also
