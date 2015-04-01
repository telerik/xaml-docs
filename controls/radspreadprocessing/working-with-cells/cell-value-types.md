---
title: Cell Value Types
page_title: Cell Value Types
description: Cell Value Types
slug: radspreadprocessing-working-with-cells-cell-value-types
tags: cell,value,types
published: True
position: 4
---

# Cell Value Types



This article briefly describes how to work with the __Value__ property of the cells in the document model and focuses on the different supported types of values. It contains the following sections:
      

* [Working with the Value Property of Cells](#working-with-the-value-property-of-cells)

* [EmptyCellValue](#empty-cell-value)

* [BooleanCellValue](#boolean-cell-value)

* [NumberCellValue](#number-cell-value)

* [FormulaCellValue](#formula-cell-value)

* [TextCellValue](#text-cell-value)

## Working with the Value Property of Cells

Since cells are the atomic data units of a worksheet, their __Value__ property is used frequently. The property is of type __ICellValue__ – an interface that is implemented by all five concrete value types supported by the document model: EmptyCellValue, BooleanCellValue, NumberCellValue, FormulaCellValue and TextCellValue. The __ICellValue__ interface exposes several properties and methods:
        

* __RawValue__: Тhe property holds the string value entered by the user, opposed to the result value displayed in the cell. For example, when the user enters the string "=1+2" in a cell, the Value of the cell becomes a *FormulaCellValue* instance with result value of "3" and RawValue of "=1+2".
            

* __ValueType__ and __ResultValueType__: Тhe two properties are of type CellValueType and provide information about the type of the Value and its result. For example, the FormulaCellValue with RawValue of "=1+2" has a *Formula* ValueType and a *Number* ResultValueType. Similarly, the string "=CONCATENATE("abc", "def")" produces a FormulaCellValue with *Formula* ValueType and *Text* ResultValueType.
            

* __GetValueAsString()__ and __GetResultValueAsString()__: Тhe two methods require a CellValueFormat argument that specifies how to present the Value and the ResultValue of the ICellValue object as strings.
            

To access the Value property of cells, first you need to create a CellSelection object that designates the cell or region of cells you would like to work with. Just like all other properties of the worksheet's cells, the Value property has three methods that respectively set, get and clear its value: SetValue(), GetValue() and ClearValue().
        

The SetValue() method has multiple overloads that allow you to pass a double, a string, a Boolean value, a DateTime instance or an ICellValue object.
        

__Example 1__ sets the Value of cell A1 to "Total":
        

#### __[C#] Example 1: Set string value__

{{region radspreadprocessing-working-with-cells-cell-value-types_16}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    worksheet.Cells[0, 0].SetValue("Total");
{{endregion}}



Another option for setting the cell value is to use the Create() method of the CellValueFactory class to produce an ICellValue and then assign the value using the SetValue(ICellValue) method. Similarly to SetValue(), the method Create() has multiple overloads that allow you to enter a string, double or Boolean value.
        

__Example 2__ creates a NumberCellValue with value 3.14 and assigns it to cell A1.
        

#### __[C#] Example 2: Create NumberCellValue__

{{region radspreadprocessing-working-with-cells-cell-value-types_5}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    ICellValue value = CellValueFactory.Create(3.14);
    worksheet.Cells[0, 0].SetValue(value);
{{endregion}}



If you now retrieve the Value of cell A1, the GetValue() method will return an instance of NumberCellValue with RawValue equal to "3.14" and both ValueType and ResultValueType equal to Number.
        

__Example 3__ retrieves the value created in Example 2.
        

#### __[C#] Example 3: Retrieve cell value__

{{region radspreadprocessing-working-with-cells-cell-value-types_17}}
    RangePropertyValue<ICellValue> rangeValue = worksheet.Cells[0, 0].GetValue();
    ICellValue value = rangeValue.Value;
{{endregion}}



Note that the GetValue() method does not return an ICellValue directly, but it provides an RangePropertyValue<ICellValue> instance. The RangePropertyValue is used to determine whether the value of a region of cells is homogeneous. In other words, if you attempt to retrieve the value of the cell region A1:B2 and the values in these cells are different, the RangePropertyValue will specify that the values vary. The class exposes two properties that describe the values in the chosen cell range:
        

* __IsIndeterminate__: The Boolean property indicates whether the Value property is consistent among all cells in the specified CellSelection. If all cells have one and the same Value, __IsIndeterminate__ is set to false. However, if the Value property varies throughout the cells in the CellSelection, the IsIndetermine property is set to true and the __Value__ property of the __RangePropertyValue<ICellValue>__ instance is set to its default value – __EmptyCellValue__.
            

* __Value__: If the __IsIndeterminate__ property is set to false, __Value__ holds the ICellValue of the whole CellSelection region. If the __IsIndeterminate__ property is set to true, then the cells in the CellSelection region contain different values and the Value property is set to its default – __EmptyCellValue__.
            

## Empty Cell Value

__EmptyCellValue__ is the default cell value type. When an empty worksheet is added to the workbook, the Value property of all its cells is of type EmptyCellValue. The RawValue of an EmptyCellValue is an empty string and its ValueType is Empty.
        

If a cell already contains another value, you can set an empty value for it using the __ClearValue()__ method.
        

__Example 4__ clears the value of cell A1:
        

#### __[C#] Example 4: Clear value__

{{region radspreadprocessing-working-with-cells-cell-value-types_1}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    worksheet.Cells[0, 0].ClearValue();
{{endregion}}



## Boolean Cell Value

As its name suggests, the __BooleanCellValue__ type contains a value of type bool. The RawValue of each BooleanCellValue is either "TRUE" or "FALSE" and the ValueType is Boolean. You can easily assign to a cell a BooleanCellValue using the SetValue(bool) overload.
        

__Example 5__ sets the values of cells A1 and B1 to true and false BooleanCellValues, respectively.
        

#### __[C#] Example 5: Set boolean value__

{{region radspreadprocessing-working-with-cells-cell-value-types_2}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    worksheet.Cells[0, 0].SetValue(true);
    worksheet.Cells[0, 1].SetValue(false);
{{endregion}}



Another way to assign cells Boolean values is through using the static __Create()__ method of the __CellValueFactory__ class to produce a BooleanCellValue and then passing this cell value instance to the __SetValue()__ method.
        

__Example 6__ illustrates how to create a BooleanCellValue using the CellValueFactory class.
        

#### __[C#] Example 6: Create a BooleanCellValue using CellValueFactory__

{{region radspreadprocessing-working-with-cells-cell-value-types_3}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    ICellValue booleanCellValueTrue = CellValueFactory.Create(true);
    ICellValue booleanCellValueFalse = CellValueFactory.Create(false);
    worksheet.Cells[0, 0].SetValue(booleanCellValueTrue);
    worksheet.Cells[0, 1].SetValue(booleanCellValueFalse);
{{endregion}}



## Number Cell Value

The __NumberCellValue__ contains a value of type double. The ValueType of each NumberCellValue instance is Number and the RawValue is the string representation of the double it holds internally. Note that the RawValue of the NumberCellValue may be different from the value that appears in the cell since a cell value format may be applied. For example, if two cells present to the user "50.00%" and "5.00E-01", actually they both contain a NumberCellValue with a RawValue "0.5". The values appear differently, because percentage format has been applied to the first cell and scientific format – to the second cell. In fact, dates are also number values presented in date format. For example, 16 September 2020 is actually the number 44090. You can find detailed description of the possible number formats and examples of their automatic assigning in the [Number Formatting]({%slug radspreadprocessing-features-number-formats%}) article.
        

The __SetValue()__ method has several overloads that produce a NumberCellValue. You can use SetValue(double) and pass the double value or SetValue(DateTime) and hand in the a DateTime instance that will be internally converted to a number. Also, you can use the SetValue(string) and pass the string representation of the number you would like to set. Note that the SetValue(string) method attempts to parse the string you provide to all values and turns it into a __TextCellValue__ only if it cannot produce any of the other types of values.
        

__Example 7__ shows how to set the value of cell A1 to 1.23.
        

#### __[C#] Example 7: Set number cell value__

{{region radspreadprocessing-working-with-cells-cell-value-types_4}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    worksheet.Cells[0, 0].SetValue("1.23");
{{endregion}}



You can use the SetValue(string) method to assign dates.
        

__Example 8__ sets the value of cell A1 to 6 October 1987 (in culture "en-US"). Once set, the value of A1 is a NumberCellValue with RawValue 32056. Because the document model detects that this is a date string, a date format is automatically applied to the cell, so that the value appears as a date.
        

#### __[C#] Example 8: Set date as number cell value__

{{region radspreadprocessing-working-with-cells-cell-value-types_8}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    worksheet.Cells[0, 0].SetValue("10/06/1987");
{{endregion}}



Contained double value:   32056
        

Applied format:   m/d/yyyy
        

## Formula Cell Value

The __FormulaCellValue__ contains a value of type __RadExpression__, which represents an arithmetic expression, built-up by constants, operators, cell references and functions. The CellValueType of FormulaCellValues is Formula and their RawValue should start with an equal sign (=).
        

Again, there are a couple of approaches to set a FormulaCellValue to a cell: invoking the __Setvalue()__ method with a string and passing to the SetValue() method an ICellValue instance that is retrieved through the __Create()__ method of the __CellValueFactory__ class. Note, however, that both methods produce a FormulaCellValue only if the current CellValueFormat is not Text. If the format of the cell is Text, the SetValue() and Create() methods produce a TextCellValue. That said, if you would like to use present formula values as strings, you can set the CellValueFormat property of the specified cell before you input the values.
        

You can set a FormulaCellValue through the SetValue() method by passing a string that starts with an equal sign (=).
        

__Example 9__ shows how you can create a formula that refers to another cell.
        

#### __[C#] Example 9: Create formula referring to another cell__

{{region radspreadprocessing-working-with-cells-cell-value-types_13}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    worksheet.Cells[0, 0].SetValue("=A2");
{{endregion}}



After this code is executed the value of cell *A1* will be the same as the value of cell A2. When the value of A2 is modified, the change will be reflected in A1 automatically.
        

An expression can also contain a predefined function that performs a given calculation. The document model offers a number of built-in functions. You can read more about the available functions in the [Functions]({%slug radspreadprocessing-features-formulas-functions%}) article. Note that if the current CellValueFormat of the cell is Text ("@"), the method will produce a TextCellValue instead of a FormulaCellValue.
        

__Example 10__ illustrates the use of the SUM built-in function.
        

#### __[C#] Example 10: Use built-in function__

{{region radspreadprocessing-working-with-cells-cell-value-types_14}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    worksheet.Cells[0, 0].SetValue("=SUM(A2, 3)");
{{endregion}}



Another way of setting a FormulaCellValue is passing an __ICellValue__ object to the __SetValue()__ method. Once again, the CellValueFactory's Create() method is used. Note that unlike the BooleanCellValue and the NumberCellValue, you need to pass the Worksheet and the CellIndex instances as parameters. These two arguments are required in case the RadExpression contains references to cells in the other worksheets. Additionally, this overload of the Create() method requires the current cell value format to be passed as a parameter, and based on its value, the method provides the new cell value format value that should be applied. Note that if the current CellValueFormat is Text ("@"), the method produces a TextCellValue instead of a FormulaCellValue.
        

__Example 11__ creates a FormulaCellValue using the CellValueFactory class.
        

#### __[C#] Example 11: Create FormulaCellValue__

{{region radspreadprocessing-working-with-cells-cell-value-types_18}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    CellIndex cellIndex = new CellIndex(0, 0);

    ICellValue cellValue;
    CellValueFormat newFormatValue;
    CellValueFactory.Create("=A2 + B2", worksheet, cellIndex, CellValueFormat.GeneralFormat, out cellValue, out newFormatValue);
    worksheet.Cells[cellIndex].SetValue(cellValue);
{{endregion}}


Using the __SetValue()__ method executes internal checks for the current cell value type using the current format and other conditions. If you are sure that the passed value is a formula, you can use the __SetValueAsFormula(string text)__ method directly which will improve the performance.


__Example 12__ shows how you can use the method.


#### __[C#] Example 12: Create FormulaCellValue through SetValueAsFormula()__
{{region radspreadprocessing-working-with-cells-cell-value-types_22}}
	Workbook workbook = new Workbook();
	Worksheet worksheet = workbook.Worksheets.Add();
	CellIndex cellIndex = new CellIndex(0, 0);
	
	worksheet.Cells[cellIndex].SetValueAsFormula("=B1+B2");
{{endregion}}



## Text Cell Value

As its name suggests, the __TextCellValue__ contains a value of type string and its ValueType is Text.
        

You can set a TextCellValue using the __SetValue(string)__ method. Note that before producing a TextCellValue, the SetValue() method attempts to parse the incoming string to all other cell value types. That said, if you pass the string "true", the cell will be assigned a BooleanCellValue. If you would like the cell to contain the string "true", pass the SetValue(string) method the string "=true".
        

__Example 13__ sets the value of cell A1 to the string "some test":
        

#### __[C#] Example 13: Set TextCellValue__

{{region radspreadprocessing-working-with-cells-cell-value-types_19}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    worksheet.Cells[0, 0].SetValue("some text");
{{endregion}}



If you would like to avoid the default parsing of the input string and always produce a TextCellValue, you need to set the CellValueFormat of the cells to Text ("@") and then enter the values.
          

__Example 14__ enters the string "=1+2" into a cell, however, because of the applied cell value format, the cell is assigned a TextCellValue instead of a FormulaCellValue.
        

#### __[C#] Example 14: Explicitly apply text value type__

{{region radspreadprocessing-working-with-cells-cell-value-types_20}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    worksheet.Cells[0, 0].SetFormat(new CellValueFormat("@"));
    worksheet.Cells[0, 0].SetValue("=1+2");
{{endregion}}



The same result could be achieved using the __Create()__ method of the __CellValueFactory__ class:
        

__Example 15__ enters the string "=1+2" into a cell and applies cell value format.
        

#### __[C#] Example 15: Creates TextCellValue__

{{region radspreadprocessing-working-with-cells-cell-value-types_21}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
    CellIndex cellIndex = new CellIndex(0, 0);

    ICellValue cellValue;
    CellValueFormat newFormatValue;
    CellValueFactory.Create("=1 + 2", worksheet, cellIndex, new CellValueFormat("@"), out cellValue, out newFormatValue);
    worksheet.Cells[cellIndex].SetValue(cellValue);
{{endregion}}


If you are sure that the value is a string and need to create a text cell value, you can use the __SetValueAsText(string text)__ method directly. This would avoid the internal checks and parsing that are usually executed and improve the performance.


__Example 16__ shows how to utilize the __SetValueAsText()__ method.

#### __[C#] Example 16: Creates TextCellValue through SetValueAsText__
{{region radspreadprocessing-working-with-cells-cell-value-types_23}}
	Workbook workbook = new Workbook();
	Worksheet worksheet = workbook.Worksheets.Add();
	CellIndex cellIndex = new CellIndex(0, 0);
	
	worksheet.Cells[cellIndex].SetValueAsText("This is most certainly a text.");
{{endregion}}



# See Also

 * [Accessing Cells of a Worksheet]({%slug radspreadprocessing-working-with-cells-accessing-cells-of-worksheet%})
