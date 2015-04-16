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

As of __Q3 2013__ RadGridView has a new method - __ExportAsync__ which allows asynchronous export of data.
      

The method expects two parameters:

1. __Stream__ - usually the file stream which you are exporting data to.
      

2. __GridViewExportOptions__ or __GridViewCsvExportOptions__ object - you can use it to set exporting options. You can check this [help article]({%slug gridview-export%}) for more information on how to configure the export options.
      
>As of version __2015 Q1 SP__ we have introduced an __overload of the ExportAsync__ method that exposes "finished callback": __Action exportFinishedCallback__.

## How to use the new method

The ExportAsync() method can be used similar to the Export() method

#### __C#__

{{region gridview-export-async_0}}

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
{{endregion}}



>Please note you should specify a __True__ value for the __shouldDisposeStream__ parameter. That way the used resources will be disposed. 
>Prior to version 2015 Q1 SP, the parameter is __shouldDisposeString__.
          

You can read more about the export events [here]({%slug gridview-export-events%}).
        

As of __Q3 2013__ we have improved the export when exporting with [ExportFormat.ExcelML]({%slug gridview-export-excelml%}) and [ExportFormat.Html]({%slug gridview-export-html%}). You can find more information in the relevant topics.
        

# See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Export]({%slug gridview-export%})

 * [Export Events]({%slug gridview-export-events%})
