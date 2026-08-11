---
title: Style Exported Html
page_title: Style Exported Html
description: Learn how to export data in HTML format and to style the exported HTML when working with RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-export-html
tags: exportformat.html
published: True
position: 5
---

# Style Exported Html

You can use the ExportFormat.Html to export RadGridView in HTML format.

>important As of __Q3 2013 GridViewElementExportingEventArgs__ exposes a new argument __VisualParameters__. The value of the property depends on the export format. Please note that it is only valid when exporting with __ExportFormat.ExcelML__ and __ExportFormat.Html__.
        
## Set Exported Element's VisualParameters 

When using the ElementExporting event, the type of the VisualParameters property for this format is __GridViewHtmlVisualExportParameters__. It has the following properties:
        
* *Background*
* *FontFamily*
* *FontSize*
* *FontWeight* 
* *Foreground*
* *Height*
* *TextAlignment*
* *VerticalAlignment*
* *Width*

For example:
        

__Example 1: Set the properties of the VisualParameters:__

<snippet id='radgridview-export-how-to-style-exported-html-documents-example_1_set_the_properties_of_the_visualparameters-cs' />


You can read more about the export events [here]({%slug gridview-export-events%}).

## See Also

* [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%})
* [ExportToXlsx]({%slug gridview-export-xlsx%})
* [ExportToPdf]({%slug gridview-export-pdf%})
