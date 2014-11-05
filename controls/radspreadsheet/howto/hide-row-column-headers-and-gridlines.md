---
title: Hide Row and Column Headers and Gridlines
page_title: Hide Row and Column Headers and Gridlines
description: Hide Row and Column Headers and Gridlines
slug: radspreadsheet-howto-hide-row-column-headers-and-gridlines
tags: hide,row,and,column,headers,and,gridlines
published: True
position: 2
---

# Hide Row and Column Headers and Gridlines



Row and Column headings, as well as worksheet gridlines, are handy when creating or editing a document in __RadSpreadsheet__. However, at times you would want to hide them in order to make the spreadsheet more clean and presentable. This article will teach you about the options provided by RadSpreadsheet that allow you to achieve this.
      

## Show or Hide Row and Column Headings

The __RadWorksheetEditor__ exposes a Boolean property __ShowRowColumnHeadings__. Its default value is true and this makes the row and column headings visible. Setting the property to false as demonstrated in __Example 1__ hides them.
        

#### __[C#] Example 1: Hide Row and Column Headers__

{{region radspreadsheet-howto-hide-row-column-headers-and-gridlines_0}}
	            this.radSpreadsheet.ActiveWorksheetEditor.ShowRowColumnHeadings = false;
{{endregion}}


## Show or Hide Gridlines

If you want to show or hide the gridlines of __RadSpreadsheet__ just set the __ShowGridlines__ Boolean property of __RadWorksheetEditor__ to true for showing the gridlines or false for hiding them. __Example 2__ shows how you can disable the gridlines.
        

#### __[C#] Example 2: Hide Gridlines__

{{region radspreadsheet-howto-hide-row-column-headers-and-gridlines_1}}
	            this.radSpreadsheet.ActiveWorksheetEditor.ShowGridlines = false;
{{endregion}}



>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk), the example is listed as __Spreadsheet / CustomRowAndColumnHeadings__.
          

# See Also

 * [Customize Row and Column Headers]({%slug radspreadsheet-howto-customize-row-column-headers%})
