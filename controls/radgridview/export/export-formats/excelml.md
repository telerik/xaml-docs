---
title: ExportFormat.ExcelML
page_title: ExportFormat.ExcelML
description: ExportFormat.ExcelML
slug: gridview-export-excelml
tags: exportformat.excelml
published: True
position: 3
---

# ExportFormat.ExcelML

You can use the ExportFormat.ExcelML to export RadGridView's content to a "xls" file. An example is available in the [Grid Export]({%slug gridview-export%}) article.

     
## Set Exported Element's VisualParameters 


>important You can utilize the __ElementExporting__ event as of __Q3 2013__ GridViewElementExportingEventArgs  exposes a new argument __VisualParameters__. Please note that it is only valid when exporting with __ExportFormat.ExcelML__ and __ExportFormat.Html__. 
    
The __VisualParameters__ property for this format is of type __GridViewExcelMLVisualExportParameters__. It has three public properties:
         

* __StyleId__

* __DataType:__

	1. ExcelMLDataType.DateTime - in order to have a DateTime column exported, you must also set a valid ExcelMLStyle specifying a correct format
	                
	1. ExcelMLDataType.Boolean
	                
	
	1. ExcelMLDataType.String
	                
	
	1. ExcelMLDataType.Number
                

* __RowHeight__

>Please note that you should first have set a valid Style in order to assign it when the ElementExporting event is raised.
            

>The __RowHeight__ property applies when the exported element is __Row__. The __DataType__ property applies when exported element is __Cell__.
            

For example:

#### __[C#]Example 1: Set the style of the exported element__

{{region cs-gridview-export-async_2}}
	private void clubsGrid_ElementExporting(object sender, GridViewElementExportingEventArgs e)
	{
	    if (e.Element == ExportElement.Cell)
	    {
	        var column = e.Context as GridViewDataColumn;
	        if (column.Header.ToString() == "Name")
	        {
	            (e.VisualParameters as GridViewExcelMLVisualExportParameters).StyleId = "someStyle";
	        }
	    }
	}
{{endregion}}

You can define the Style when __InitializingExcelMLStyles__ event is raised. For example:
          

#### __[C#]Example 2: Define a style:__

{{region cs-gridview-export-async_4}}
	private void clubsGrid_InitializingExcelMLStyles(object sender, ExcelMLStylesEventArgs e)
	{
	    ExcelMLStyle style = new ExcelMLStyle("someStyle");
	    style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
	    style.Font.Size = 15;
	    style.Font.Italic = true;
	    e.Styles.Add(style);
	}
{{endregion}}

You can check the [Export Events]({%slug gridview-export-events%}) article for more information on how to define an ExcelMLStyle. 
          

>important __InitializingExcelMLStyles__ event will be only raised when exporting with ExportFormat.ExcelML

            

## See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Export]({%slug gridview-export%})

 * [Export Async]({%slug gridview-export-async%})

 * [Export Events]({%slug gridview-export-events%})
