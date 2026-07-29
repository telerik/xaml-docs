---
title: Export String Value
page_title: Export String Value
description: Read this article to learn how to export string values to Excel from RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-export-troubleshooting-export-string
tags: export,string,value
published: True
position: 5
---

# Export String Value

__PROBLEM__

When exporting a RadGridView to Excel using __ExportFormat.HTML__, the string values that can be converted to numbers, are opened in Excel as numbers.
        

>tip This behavior does not occur when exporting using __ExportFormat.ExcelML__.


__CAUSE__

When using the HTML format, the RadGridView actually saves data in an Excel readable html format.


__SOLUTION__

You will need to format the exported string column appropriately so that the Excel file interprets it as a string.

Here is a small sample code:
        

__Example 1: Handling the ElementExporting event:__

<snippet id='radgridview-export-how-to-export-string-example_1_handling_the_elementexporting_event-cs' />

<snippet id='radgridview-export-how-to-export-string-example_1_handling_the_elementexporting_event-vb' />





