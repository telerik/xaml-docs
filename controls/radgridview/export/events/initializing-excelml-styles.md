---
title: InitializingExcelMLStyles
page_title:  InitializingExcelMLStyles
description:  Check out our examples of defining a style and applying it before exporting data when the InitializingExcelMLStyles event of Telerik's {{ site.framework_name }} DataGRid is raised.
slug: gridview-export-events-initializing-excelml-styles
tags: grid,export,events,initializing,excelml,styles
published: True
position: 4
---

# InitializingExcelMLStyles

>tip This event will be only raised when exporting with __ExportFormat.ExcelML__

You can define a Style when __InitializingExcelMLStyles__ event is raised.
For example:
        
__Example 1: Define a style:__

```C#
	ExcelMLStyle style = new ExcelMLStyle("0");
	style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
	e.Styles.Add(style);
```

You can find a list of the properties that could be set for __ExcelMLStyle__:
        
__Alignment:__

- Horizontal - you can choose a specific alignment through ExcelMLHorizontalAlignment enumeration.
1. Vertical - you can choose a specific alignment through ExcelMLVerticalAlignment enumeration.
1. Indent   
1. Rotate   
1. ShrinkToFit
1. VerticalText
1. WrapText
              
__Font:__

- Bold    
1. Color 
1. FontName
1. Italic
1. Outline (only for Mac)
1. Size
1. StrikeThrough
1. Underline - you can choose a specific underline through ExcelMLUnderline
              

__Interior:__

- Color - You must also set Pattern in order to be applied Interior.Color
1. Pattern - you can choose a specific pattern through ExcelMLPattern
1. PatternColor - You must also set Pattern in order to be applied Interior.PatternColor
              

__NumberFormat:__

- Format


__Example 7: Apply a style before exporting:__

```C#
	private void clubsGrid_InitializingExcelMLStyles_1(object sender, ExcelMLStylesEventArgs e)
	{
	    ExcelMLStyle style = new ExcelMLStyle("0");
	
	    // Alignment
	    style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
	    style.Alignment.Vertical = ExcelMLVerticalAlignment.Top;
	    style.Alignment.Indent = 5;
	    style.Alignment.Rotate = 0;
	    style.Alignment.ShrinkToFit = true;
	    style.Alignment.VerticalText = true;
	    style.Alignment.WrapText = true;
	
	    // Font
	    style.Font.Bold = true;
	    style.Font.Color = "Beige";
	    style.Font.FontName = "Calibri";
	    style.Font.Italic = true;
	    style.Font.Outline = true;
	    style.Font.Shadow = true;
	    style.Font.Size = 10;
	    style.Font.StrikeThrough = true;
	    style.Font.Underline = ExcelMLUnderline.Double;
	
	    // Interior
	    style.Interior.Color = "Green";
	    style.Interior.Pattern = ExcelMLPattern.Solid;
	    style.Interior.PatternColor = "#FF0000";
	
	    // NumberFormat
	    style.NumberFormat.Format = "00.00";
	
	    e.Styles.Add(style);
	}
```
        
## See Also

 * [Grid Async Export]({%slug gridview-export-async%})

 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})

 * [ExportFormat.Html]({%slug gridview-export-html%})
 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%})
 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})
 
 * [Online Demo - Exporting to various formats](https://demos.telerik.com/silverlight/#GridView/Exporting)
 
 * [Online Demo - Exporting Row Details](https://demos.telerik.com/silverlight/#GridView/ExportingRowDetails)
