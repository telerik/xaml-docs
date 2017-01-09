---
title: Export String Value
page_title: Export String Value
description: Export String Value
slug: gridview-export-troubleshooting-export-string
tags: export,string,value
published: True
position: 5
---

# Export String Value

__PROBLEM__

When exporting a RadGridView to Excel using __ExportFormat.HTML__, the string values that can be converted to numbers, are opened in Excel as numbers.
        

>tipThis behavior does not occur when exporting using __ExportFormat.ExcelML__.


__CAUSE__

When using the HTML format, the RadGridView actually saves data in an Excel readable html format.


__SOLUTION__

You will need to format the exported string column appropriately so that the Excel file interprets it as a string.

Here is a small sample code:
        

#### __[C#]Example 1: Handling the ElementExporting event:__

{{region cs-gridview-export-troubleshooting-export-string_0}}
	private void clubsGrid_ElementExporting(object sender, GridViewElementExportingEventArgs e)
	{
	    if (e.Element == ExportElement.Cell)
	    {
	        var column = e.Context as GridViewDataColumn;
	        if (column.Header.ToString() == "My String Column")
	        {
	            e.Value = string.Format(@"=T(""{0}"")", e.Value);
	        }
	    }
	}
{{endregion}}

#### __[VB.NET]Example 2: Handling the ElementExporting event:__

{{region vb-gridview-export-troubleshooting-export-string_1}}
	Private Sub clubsGrid_ElementExporting(sender As Object, e As GridViewElementExportingEventArgs)
	    Dim column = TryCast(e.Context, GridViewDataColumn)
	    If e.Element = ExportElement.Cell Then
	        If column.Header.ToString() = "My String Column" Then
	            e.Value = String.Format("=T(""{0}"")", e.Value)
	        End If
	    End If
	End Sub
{{endregion}}




