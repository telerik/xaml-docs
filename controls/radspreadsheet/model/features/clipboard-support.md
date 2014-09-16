---
title: Clipboard Support
page_title: Clipboard Support
description: Clipboard Support
slug: radspreadsheet-clipboard-support
tags: clipboard,support
publish: False
position: 5
---

# Clipboard Support



The document model of __RadSpreadsheet__ offers an easy way to copy and paste multiple values. The control provides flexible API
        that allows you to choose the content and formatting that gets included in the pasted region. This article demonstrates how to copy and paste data with
        different paste options.
      

## Copy

In order to copy values that appear in your worksheet, create a __CellSelection__ for the desired cell region and invoke its
          __Copy()__ method. The method returns a __WorksheetFragment__ instance that holds only the values you copied.
          The __WorksheetFragment__ is a piece of worksheet designed to keep the data you copy and its properties. You can later pass the
          worksheet fragment to the __Paste()__ method in order to get the values pasted in another worksheet.
        

The following example creates a new workbook with a single worksheet and assigns some sample values to the A1:B3 region. Further, the code creates a
          selection for the cell region and calls its __Copy()__ method. The returned __WorksheetFragment__ can later
          be used for pasting operation.
        

#### __C#__

{{region radspreadsheet-clipboard-support_0}}
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



#### __VB__

{{region radspreadsheet-clipboard-support_0}}
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



## Paste

__RadSpreadsheet__ provides control over the content and the formatting included in the pasted region. The
          __Paste()__ method requires two arguments: a __WorksheetFragment__ that contains the values to be pasted
          and a __PasteOptions__ instance that determines the type of information that will be pasted from the fragment. The
          __PasteOptions__ class introduces a __PasteType__ property that indicates the type of the paste.
          Currently, __RadSpreadsheet__ supports the following paste types:
        

* __All__ - Pastes everything, including text, numbers, formulas and their formatting.
            

* __Formulas__ - Pastes text, numbers and formulas. However, this option ignores cells formatting.
            

* __Formulas and Number Formatting__ - Pastes text, numbers and formulas, and applies formatting of the copied cells to the pasted cells.
            

* __Column Widths__ - Pastes text, numbers and formulas, and applies the column widths of the copied cells to the pasted cells.
            

* __Values__ - Pastes the calculated result of the formulas, ignoring formatting and column width.
            

* __Values and Number Formatting__ - Pastes the calculated results of any formula and the formatting of the copied cells to the pasted cells.
            

* __Formatting__ - Pastes only the formatting of the copied cells to the pasted cells.
            

The sample snippet below creates a new workbook with an empty worksheet. Further, the example sets the __Value__ of cell 
          *A1* to =CONCATENATE("Rad" ,"Spreadsheet") and its __ForeColor__ to green. 
          The code copies the contents of *A1* and pastes it in *A2* using __All__ PasteType.
        

#### __C#__

{{region radspreadsheet-clipboard-support_1}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            worksheet.Cells[0, 0].SetValue("=CONCATENATE(\"Rad\", \"Spreadsheet\")");
	            worksheet.Cells[0, 0].SetForeColor(new ThemableColor(Colors.Green));
	
	            WorksheetFragment worksheetFragment = worksheet.Cells[0, 0].Copy();
	
	            PasteOptions pasteOptions = new PasteOptions(PasteType.All);
	            worksheet.Cells[1, 0].Paste(worksheetFragment, pasteOptions);
	{{endregion}}



#### __VB__

{{region radspreadsheet-clipboard-support_1}}
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



Using different __PasteType__, however, produces different output. For example, pasting the contents of *A1* 
          with __Values__ PasteType will result in a value "RadSpreadsheet" instead of =CONCATENATE("Rad" ,"Spreadsheet") 
          and default __ForeColor__ instead of green:
        

#### __C#__

{{region radspreadsheet-clipboard-support_2}}
	            PasteOptions pasteOptionsValues = new PasteOptions(PasteType.Values);
	            worksheet.Cells[2, 0].Paste(worksheetFragment, pasteOptionsValues);
	{{endregion}}



#### __VB__

{{region radspreadsheet-clipboard-support_2}}
	    Dim pasteOptionsValues As New PasteOptions(PasteType.Values)
	    worksheet.Cells(2, 0).Paste(worksheetFragment, pasteOptionsValues)
	    '#End Region
	
	    ' #Region radspreadsheet-clipboard-support_3
	    Dim valuesAndFormatting As New PasteOptions(PasteType.Formulas Or PasteType.Formats)
	    worksheet.Cells(3, 0).Paste(worksheetFragment, valuesAndFormatting)
	    '#End Region
	
	End Class



If you would like to paste the formula contained in *A1*, not only its result, and keep its formatting, combine the 
          __Values__ and __Formats__ paste types:
        

#### __C#__

{{region radspreadsheet-clipboard-support_3}}
	            PasteOptions valuesAndFormatting = new PasteOptions(PasteType.Formulas | PasteType.Formats);
	            worksheet.Cells[3, 0].Paste(worksheetFragment, valuesAndFormatting);
	{{endregion}}



#### __VB__

{{region radspreadsheet-clipboard-support_3}}
	    Dim valuesAndFormatting As New PasteOptions(PasteType.Formulas Or PasteType.Formats)
	    worksheet.Cells(3, 0).Paste(worksheetFragment, valuesAndFormatting)
	    '#End Region
	
	End Class



# See Also
