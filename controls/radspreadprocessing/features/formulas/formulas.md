---
title: General Information
page_title: General Information
description: General Information
slug: radspreadprocessing-features-formulas-general-information
tags: formulas
published: True
position: 0
---

# General Information



A formula is an algebraic expression that contains values, operators, functions, and references to cells. The following list takes a closer look to the compound parts of formulas:
      

* __Values__: Expressions can contain numbers, booleans, strings, arrays. For example, all of the following formulas represent valid expressions that contain values of different type: *=3+4, ="Rad"&"Spreadsheet", =AND(TRUE, FALSE), =SUM({1, 2; 3, 4})*.
          

* __Operators__: Formulas can include arithmetic, comparison, cell reference, and text operators. Examples of expressions that use operators are:*=-1+2, =B1<=4, =SUM(A1:B4), ="Rad"&"Spreadsheet"*. More information about the supported operators can be found in the [Operator]({%slug radspreadprocessing-features-formulas-operators%}) article.
          

* __Cell references__: Formulas can contain references to cells or ranges of cells. For example, the expression *=B1+B2* adds the values of cells B1 and B2 of the current worksheet, while the formula *=SUM(B1:B5)* sums up the values of all cells between B1 and B5. Further information about cell references is available in the [Cell References]({%slug radspreadprocessing-features-formulas-cell-references%}) article.
          

* __Built-in functions__: You can take advantage of a large set of predefined functions that can be directly included in expressions. Examples of formulas that use built-in functions are: *=ABS(-5), =COS(PI()), =AND(B1, B2)<>OR(C1, C2)*. You can find the full list in the [Functions]({%slug radspreadprocessing-features-formulas-functions%}) article.
          

## Get and set formulas in cells

In order to set the value of a cell to a formula use the __SetValue()__ method of the [CellSelection]({%slug radspreadprocessing-working-with-cells-accessing-cells-of-worksheet%}) class and pass the formula string as an argument. In order to produce a formula value the string you enter should start with either __=__ (equal) or __–__ (minus) sign, otherwise, the method treats the input as plain text.
        

__Example 1__ creates a workbook from scratch and adds a worksheet. Further, the code assigns the value =3+4 to cell A1.
        

#### __[C#] Example 1: Set formula__

{{region radspreadprocessing-features-formulas_0}}
    Workbook workbook = new Workbook();
    workbook.Worksheets.Add();
    workbook.ActiveWorksheet.Cells[0, 0].SetValue("=3+4");
{{endregion}}



Additionally to entering formulas in cells, you can retrieve and inspect formula values. If you get the value of Cell[0, 0], the result will be an object of type __FormulaCellValue__. Just like other cell values, the __FormulaCellValue__ class inherits from __CellValueBase__ class and conforms to the __ICellValue__ interface. Thus, the class exposes several important properties and useful methods that allow you to get information about both the entered value and its result value.
        

A closer look at the value of cell A1 will reveal that the two methods __GetValueAsString()__ and __GetResultValueAsString()__ return the original string of the expression and string of the computed result, respectively. Similarly, the __FormulaCellValue__ offers information about the __CellValueType__ of its value and result value through the __ValueType__ and __ResultValueType__ properties.
        

#### __[C#] Example 2: Get formula value__

{{region radspreadprocessing-features-formulas_1}}
    FormulaCellValue formulaCellValue = workbook.ActiveWorksheet.Cells[0, 0].GetValue().Value as FormulaCellValue;
    if (formulaCellValue != null)
    {
        RadExpression expression = formulaCellValue.Value;
        //expression is AdditionExpression with operands 3 and 4

        CellValueFormat format = workbook.ActiveWorksheet.Cells[0, 0].GetFormat().Value;
        string valueAsString = formulaCellValue.GetValueAsString(format);
        //valueAsString = "=3+4"

        string resultValueAsString = formulaCellValue.GetResultValueAsString(format);
        //resultAsString = "7"

        CellValueType valueType = formulaCellValue.ValueType;
        //valueType = Formula

        CellValueType resultValueType = formulaCellValue.ResultValueType;
        //resultValueType = Number
    }
{{endregion}}



# See Also

 * [Accessing Cells of a Worksheet]({%slug radspreadprocessing-working-with-cells-accessing-cells-of-worksheet%})

 * [Get, Set and Clear Cell Properties]({%slug radspreadprocessing-working-with-cells-get-set-clear-properties%})
