---
title: Grid Async Export
page_title: Grid Async Export
description: Grid Async Export
slug: gridview-export-async
tags: grid,async,export
published: True
position: 1
---

# Grid Async Export

You can use RadGridView`s __ExportAsync__ method in order to export data asynchronously. The method was introduced in __Q3 2013__.    As in the synchronous [Export]({%slug gridview-export%}) functionality, the method expects two parameters:

1. __Stream__ - usually the file stream which you are exporting data to.
     

2. __GridViewExportOptions__ or __GridViewCsvExportOptions__ object - you can use it to set exporting options. You can check the [Export]({%slug gridview-export%})  method documentation for more information on how to configure the export options.
     
>As of version __2015 Q1 SP__ we have introduced an __overload of the ExportAsync__ method that exposes "finished callback": __Action exportFinishedCallback__.

The ExportAsync method can be used similar to the Export method: 

#### __[C#]Example 1: Save RadGridView`s conteint in a Excel file__

{{region cs-gridview-export-async_0}}
	string extension = "xls";
	SaveFileDialog dialog = new SaveFileDialog()
	{
	    DefaultExt = extension,
	    Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
	    FilterIndex = 1
	};
	if (dialog.ShowDialog() == true)
	{
	    Stream stream = dialog.OpenFile();
	    clubsGrid.ExportAsync(stream,
	    new GridViewExportOptions()
	    {
	        Format = ExportFormat.ExcelML,
	        ShowColumnHeaders = true,
	        ShowColumnFooters = true,
	        ShowGroupFooters = false,
	    }, true);
	}
	        }
{{endregion}}



>Please note that you should specify a __True__ value for the __shouldDisposeStream__ parameter. That way the used resources will be disposed. Prior to version 2015 Q1 SP, the parameter is called __shouldDisposeString__.
          
You can read more about the export events [here]({%slug gridview-export-events%}).

# See Also
 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Export]({%slug gridview-export%})

 * [Export Events]({%slug gridview-export-events%})
