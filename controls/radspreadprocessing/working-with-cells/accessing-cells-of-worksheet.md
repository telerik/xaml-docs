---
title: Accessing Cells of a Worksheet
page_title: Accessing Cells of a Worksheet
description: Accessing Cells of a Worksheet
slug: radspreadprocessing-working-with-cells-accessing-cells-of-worksheet
tags: accessing,cells,of,a,worksheet
published: True
position: 2
---

# Accessing Cells of a Worksheet



Each worksheet consists of cells organized in rows and columns. In order to manipulate the data and properties of the cells, you need to create and use an instance of the __CellSelection__ class.
      

## 

As a worksheet contains a considerable number of rows and columns, it is unusual to perform an operation to the whole range of cells. Typically, you would like to set the value of a single cell or, for example, apply formatting to a range of cells. In order to perform an operation on a specified range of cells you need to create a __CellSelection__ object that holds the desired cell region and then invoke the appropriate action for this __CellSelection__ instance. This class exposes a rich API that allows you to get, set and clear cell's value, colors, borders and style.
        

The document model offers multiple ways to create a __CellSelection__ object. The following list contains all approaches you can use to retrieve a __CellSelection__ instance. Note that each example creates a new workbook, adds one worksheet and creates a selection for its cells.
        

* __Example 1__ Create CellSelection using CellIndex
            

#### __C# Example 1__

{{region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_0}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    CellIndex cellIndex = new CellIndex(0, 5);
    CellSelection selection1 = worksheet.Cells[cellIndex];
{{endregion}}



* __Example 2__ Create CellSelection using CellRange
            

#### __C# Example 2__

{{region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_1}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    CellRange cellRange = new CellRange(0, 0, 5, 5);
    CellSelection selection2 = worksheet.Cells[cellRange];
{{endregion}}



* __Example 3__ Create CellSelection using multiple CellRange objects
            

#### __C# Example 3__

{{region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_2}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    List<CellRange> ranges = new List<CellRange>();
    ranges.Add(new CellRange(0, 0, 5, 5));
    ranges.Add(new CellRange(0, 10, 5, 15));
    CellSelection selection3 = worksheet.Cells[ranges];
{{endregion}}



* __Example 4__ Create CellSelection using two CellIndex instances that specify a CellRange
            

#### __C# Example 4__

{{region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_3}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    CellIndex fromIndex = new CellIndex(0, 0);
    CellIndex toIndex = new CellIndex(5, 5);
    CellSelection selection4 = worksheet.Cells[fromIndex, toIndex];
{{endregion}}



* __Example 5__ Create CellSelection using two integers that indicate the CellIndex
            

#### __C# Example 5__

{{region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_4}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    CellSelection selection5 = worksheet.Cells[0, 5];
{{endregion}}



* __Example 6__ Create CellSelection using four integers that specify the CellRange
            

#### __C# Example 6__

{{region radspreadprocessing-working-with-cells-accessing-cells-of-worksheet_5}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    CellSelection selection6 = worksheet.Cells[0, 0, 5, 5];
{{endregion}}



Once you have a __CellSelection__ object you can get, set and clear the properties of the selected cells. More information about cell properties is available in the [Get, Set and Clear Cell Properties]({%slug radspreadprocessing-working-with-cells-get-set-clear-properties%}) article.
        
