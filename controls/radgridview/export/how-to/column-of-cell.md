---
title: Get the Column of the Corresponding Cell
page_title: Get the Column of the Corresponding Cell
description: Read this article to learn how to access the column of the corresponding cell when exporting data from RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-troubleshooting-cell-column
tags: column, corresponding, cell,
published: True
position: 2
---

# Get the Column of The Corresponding Cell

When a cell(header cell, cell, footer cell, group footer cells) is exported through the __ExportToXlsx__ or __ExportToPdf__ methods , the arguments of the __ElementExportingToDocument__ event can be cast to __GridViewCellExportingEventArgs__. Thus, the column of the corresponding cell can be accessed. 

The following example illustrates the approach:
__Example 3: Getting the Column of the Corresponding Cell__
```C#
	this.gridViewExport.ElementExportingToDocument += (s, e) =>
	{
	    if (e.Element == ExportElement.Cell)
	    {
	        var cellExportingArgs = e as GridViewCellExportingEventArgs;
	        if (cellExportingArgs.Column == this.gridViewExport.Columns[2])
	        {
	            (cellExportingArgs.VisualParameters as GridViewDocumentVisualExportParameters).Style = cellStyle;
	        }
	    }
	};
```

#### [VB.NET] Example 3: Getting the Column of the Corresponding Cell
```VB.NET
	Me.gridViewExport.ElementExportingToDocument += Function(s, e) 
	    If e.Element = ExportElement.Cell Then
	        Dim cellExportingArgs = TryCast(e, GridViewCellExportingEventArgs)
	            If cellExportingArgs.Column = Me.gridViewExport.Columns(2) Then
	                TryCast(cellExportingArgs.VisualParameters, GridViewDocumentVisualExportParameters).Style = cellStyle
	            End If
	    End If
	End Function
```
