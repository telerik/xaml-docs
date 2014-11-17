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



## 
          ExportFormat.ExcelML
      

As of __Q3 2013 GridViewElementExportingEventArgs__ exposes a new argument __VisualParameters__. The value of the property depends on the export format. Please note that it is only valid when exporting with __ExportFormat.ExcelML__ and __ExportFormat.Html__.
        

>You can read more about the export events [here]({%slug gridview-export-events%}).
          

The type of the property for this format is __GridViewExcelMLVisualExportParameters__.
          

It has three properties:
          

* __StyleId__

* __DataType:__

1. 
                  ExcelMLDataType.DateTime - in order to have a DateTime column exported, you must also set a valid ExcelMLStyle specifying a correct format
                

1. 
                  ExcelMLDataType.Boolean
                

1. 
                  ExcelMLDataType.String
                

1. 
                  ExcelMLDataType.Number
                

* __RowHeight__

>Please note that you should first have set a valid Style in order to assign it when the ElementExporting event is raised.
            

>The __RowHeight__ property applies when ExportedElement is __GridViewRow__. The __DataType__ property applies when ExportedElement is __GridViewCell__.
            

For example:

#### __C#__

{{region gridview-export-async_2}}
	(e.VisualParameters as GridViewExcelMLVisualExportParameters).StyleId = "0";
	{{endregion}}



You can define the Style when __InitializingExcelMLStyles__ event is raised. For example:
          

#### __C#__

{{region gridview-export-async_4}}
	ExcelMLStyle style = new ExcelMLStyle("0");            
	style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
	e.Styles.Add(style);
	
	{{endregion}}



You can check the [article](74308197-B2E6-4A20-9390-04937F1D845E#InitializingExcelMLStyles) for more information on how to define an ExcelMLStyle.
          

>__InitializingExcelMLStyles__ event will be only raised when exporting with ExportFormat.ExcelML
            

# See Also

 * [
        RadGridView Overview
      ]({%slug gridview-overview2%})

 * [
        Export
      ]({%slug gridview-export%})

 * [
        Export Async
      ]({%slug gridview-export-async%})

 * [Export Events]({%slug gridview-export-events%})
