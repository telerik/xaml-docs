---
title: Clipboard Support
page_title: Clipboard Support
description: Clipboard Support
slug: radspreadprocessing-features-clipboard-support
tags: clipboard,support
published: True
position: 4
---

# Clipboard Support



The document model offers an easy way to copy and paste multiple values. The control provides flexible API that allows you to choose the content and formatting that gets included in the pasted region. This article demonstrates how to copy and paste data with different paste options.
      

## Copy

In order to copy values that appear in your worksheet, create a __CellSelection__ for the desired cell region and invoke its __Copy()__ method. The method returns a __WorksheetFragment__ instance that holds only the values you copied. The __WorksheetFragment__ is a piece of worksheet designed to keep the data you copy and its properties. You can later pass the worksheet fragment to the __Paste()__ method in order to get the values pasted in another worksheet.
        

__Example 1__ creates a new workbook with a single worksheet and assigns some sample values to the A1:B3 region. Further, the code creates a selection for the cell region and calls its __Copy()__ method. The returned __WorksheetFragment__ can later be used for pasting operation.
        

#### __[C#] Example 1: Copy Selected Cells__

{{region radspreadprocessing-features-clipboard-support_0}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    worksheet.Cells[0, 0].SetValue("Product");
    worksheet.Cells[1, 0].SetValue("Service");
    worksheet.Cells[0, 1].SetValue(17.4);
    worksheet.Cells[1, 1].SetValue(12.9);
    worksheet.Cells[2, 0].SetValue("Total");
    worksheet.Cells[2, 1].SetValue("=SUM(A1:B1)");

    CellRange copiedCellRange = new CellRange(0, 0, 2, 1);
    WorksheetFragment worksheetFragment = worksheet.Cells[copiedCellRange].Copy();
{{endregion}}



## Paste

The document model provides control over the content and the formatting included in the pasted region. The __Paste()__ method requires two arguments: a __WorksheetFragment__ that contains the values to be pasted and a __PasteOptions__ instance that determines the type of information that will be pasted from the fragment. The __PasteOptions__ class introduces a __PasteType__ property that indicates the type of the paste. These are the supported paste types:
        

* __All__: Pastes everything, including text, numbers, formulas and their formatting.
            

* __Formulas__: Pastes text, numbers and formulas. However, this option ignores cells formatting.
            

* __Formulas and Number Formatting__: Pastes text, numbers and formulas, and applies formatting of the copied cells to the pasted cells.
            

* __Column Widths__: Pastes text, numbers and formulas, and applies the column widths of the copied cells to the pasted cells.
            

* __Values__: Pastes the calculated result of the formulas, ignoring formatting and column width.
            

* __Values and Number Formatting__: Pastes the calculated results of any formula and the formatting of the copied cells to the pasted cells.
            

* __Formatting__: Pastes only the formatting of the copied cells to the pasted cells.
            

__Example 2__ creates a new workbook with an empty worksheet. Further, the example sets the __Value__ of cell *A1* to =CONCATENATE("Rad" ,"Spreadsheet") and its __ForeColor__ to green. The code copies the contents of *A1* and pastes it in *A2* using __All__ PasteType.
        

#### __[C#] Copy All__

{{region radspreadprocessing-features-clipboard-support_1}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();

    worksheet.Cells[0, 0].SetValue("=CONCATENATE(\"Rad\", \"Spreadsheet\")");
    worksheet.Cells[0, 0].SetForeColor(new ThemableColor(Colors.Green));

    WorksheetFragment worksheetFragment = worksheet.Cells[0, 0].Copy();

    PasteOptions pasteOptions = new PasteOptions(PasteType.All);
    worksheet.Cells[1, 0].Paste(worksheetFragment, pasteOptions);
{{endregion}}



Using different __PasteType__, however, produces different output. __Example 3__ pastes the contents of *A1* with __Values__ PasteType which results in a value "RadSpreadsheet" instead of =CONCATENATE("Rad" ,"Spreadsheet") and default __ForeColor__ instead of green:
        

#### __[C#] Example 3: Paste Values__

{{region radspreadprocessing-features-clipboard-support_2}}
    PasteOptions pasteOptionsValues = new PasteOptions(PasteType.Values);
    worksheet.Cells[2, 0].Paste(worksheetFragment, pasteOptionsValues);
{{endregion}}



If you would like to paste the formula contained in *A1*, not only its result, and keep its formatting, combine the __Values__ and __Formats__ paste types:
        

__Example 4__ combines the Value and Formats paste types and preserves both the contents and formatting of the copied cell selection.
        

#### __[C#] Example 4: Combine Values and Formats PasteType__

{{region radspreadprocessing-features-clipboard-support_3}}
    PasteOptions valuesAndFormatting = new PasteOptions(PasteType.Formulas | PasteType.Formats);
    worksheet.Cells[3, 0].Paste(worksheetFragment, valuesAndFormatting);
{{endregion}}



# See Also

 * [CellSelection]({%slug radspreadprocessing-working-with-cells-accessing-cells-of-worksheet%})
