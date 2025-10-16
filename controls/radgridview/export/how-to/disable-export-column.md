---
title: Disable the Export of a Particular Column
page_title: Disable Export of a Column
description: Read this article to learn how to disable the export of a particular column within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-troubleshooting-disable-column-export
tags: column, disable, export,
published: True
position: 1
---

# Disable Export of a Column 

When exporting with __ExportToXlsx__ or __ExportToPdf__ methods you can choose which columns to export by setting the __ExcludedColumns__ property for the __GridViewDocumentExportOptions__. The property was introduced in __Q3 2015 SP1__. When a given column is added to this collection, it will not be exported.

__Example 4: Disabling the export of a particular column:__
```C#
	var opt = new GridViewDocumentExportOptions()
	{
    	ShowColumnHeaders = true,
	};
	opt.ExcludedColumns.Add(grid.Columns[0]);

	gridViewExport.ExportToPdf(stream, opt);
```
```VB.NET
	Dim opt = New GridViewDocumentExportOptions() With { _
		Key .ShowColumnHeaders = True _
	}
	opt.ExcludedColumns.Add(grid.Columns(0))
	
	gridViewExport.ExportToPdf(stream, opt)
```
