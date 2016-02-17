---
title: ExportFormat.Xlsx
page_title: ExportFormat.Xlsx
description: ExportFormat.Xlsx
slug: gridview-export-xlsx
tags: exportformat.xlsx
published: True
position: 4
---

# ExportFormat.Xlsx

As of __Q1 2015__ RadGridView exposes a new method – __ExportToXlsx__ which allows exporting to Xlsx format without the need to integrate RadGridView with RadSpreadProcessing.

* [Export Default Styles](#export-default-styles)

* [Events](#events)

* [Disable the Export of a Particular Column](#disable-the-export-of-a-particular-column)


>tip You can read more about the export events [here]({%slug gridview-export-events%}).

__Assembly References__
ExportFormat.Xlsx method uses additional libraries so you need to add references to the following assemblies:

* Telerik.Windows.Documents.Core.dll
* Telerik.Windows.Documents.SpreadSheet.dll 
* Telerik.Windows.Documents.SpreadSheet.FormatProviders.OpenXml.dll
* Telerik.Windows.Zip.dll
* Telerik.Windows.Controls.GridView.Export.dll

>  __Telerik.Windows.Controls.GridView.Export.dll__ is a new binary introduced in __Q1 SP of 2015__. It delimits the exporting to __Xlsx__ functionality from __Telerik.Windows.Controls.GridView.dll__, so in order to use __ExportToXlsx__ method, the new dll should also be added.

The method is overloaded:

1. ExportToXlsx(Stream stream) - Expects the specified stream to which you are exporting data to.

2. ExportToXlsx(Stream stream, GridViewDocumentExportOptions options) - Expects the specified stream to which you are exporting data to and parameter of type GridViewDocumentExportOptions. The latter is used to set the following export options:

* Culture
* Items
* ShowColumnFooters
* ShowGroupFooters
* ShowColumnHeaders
* ExportDefaultStyles  


The following example shows how to use the method on a button click:

#### __[C#] Example 1: Usage of Method ExportToXlsx__
	private void btnExport_Click(object sender, RoutedEventArgs e)
	{
	    string extension = "xlsx";
	
	    SaveFileDialog dialog = new SaveFileDialog()
	    {
	        DefaultExt = extension,
	        Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
	        FilterIndex = 1
	    };
	
	    if (dialog.ShowDialog() == true)
	    {
	        using (Stream stream = dialog.OpenFile())
	        {
	            gridViewExport.ExportToXlsx(stream,
	                new GridViewDocumentExportOptions()
	                {
	                    ShowColumnFooters = true,
	                    ShowColumnHeaders = true,
	                    ShowGroupFooters = true
	                });
	        }
	    }
	}


## Export Default Styles

>To export the Default Styles of RadGridView in grouped state, at least one row must be expanded, so that the exporting engine can get the styles.

RadGridView can be exported with its default styles by setting the ExportDefaultStyles property to “true”

By default the ExportDefaultStyles property is set to false. You can see the result (Figure 1)

__Figure 1__: Exporting with ExportDefaultStyles set to “false” (default)
![ExportDefaultStyles false](images/exportdefaultstyles.png)

You can set the __ExportDefaultStyles value to “true”__ and see the result (Figure 2)

#### __[C#] Example 2: Configuring ExportDefaultStyles Setting__

	gridViewExport.ExportToXlsx(stream,
	    new GridViewDocumentExportOptions()
		{
	    ShowColumnHeaders = true,
	    ShowColumnFooters = true,
	    ShowGroupFooters = true,
	    ExportDefaultStyles = true
		});   

__Figure 2__: Exporting with ExportDefaultStyles set to “true”
![ExportDefaultStyles false](images/exportdefaultstyles2.png)

## Events

You can read more about export events below.

### ElementExportingToDocument
The event handler expects __GridViewElementExportingToDocumentEventArgs__ arguments that have the following methods and properties:
* Element - the export element
* Cancel - the event is cancelable 
* DataContext - the DataContext of the corresponding visual element. For example the DataContext of a row is its corresponding data item.
* Value - the value to be exported
* VisualParameters - they are of type GridViewDocumentVisualExportParameters and have a property Style which is of type CellSelectionStyle. It provides the ability to set the FontSize, Fill and etc. for the exported document.

### ElementExportedToDocument

The event handler expects __GridViewElementExportedToDocumentEventArgs__ arguments that have the following methods and properties

* Element - the export Element
* DataContext - the DataContext of the corresponding visual element.

### Getting the Column of the Corresponding Cell

When a cell is exported (header cell, cell, footer cell, group footer cells), the arguments of the ElementExportingToDocument event can be cast to GridViewCellExportingEventArgs. Thus, the column of the corresponding cell can be accessed. 

The following example illustrates the approach:
#### __[C#] Example 3: Getting the Column of the Corresponding Cell__
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

#### [VB.NET] Example 3: Getting the Column of the Corresponding Cell
	Me.gridViewExport.ElementExportingToDocument += Function(s, e) 
	    If e.Element = ExportElement.Cell Then
	        Dim cellExportingArgs = TryCast(e, GridViewCellExportingEventArgs)
	            If cellExportingArgs.Column = Me.gridViewExport.Columns(2) Then
	                TryCast(cellExportingArgs.VisualParameters, GridViewDocumentVisualExportParameters).Style = cellStyle
	            End If
	    End If
	End Function


## Disable the Export of a Particular Column 

As of __Q3 2015 SP1__,  __GridViewDocumentExportOptions__ expose a new property- __ExcludedColumns__. When a given column is added to this collection, it will not be exported.

#### __[C#] Example 4: Disabling the export of a particular column__
	var opt = new GridViewDocumentExportOptions()
	{
    	ShowColumnHeaders = true,
	};
	opt.ExcludedColumns.Add(grid.Columns[0]);

	gridViewExport.ExportToXlsx(stream, opt);

#### __[VB.NET] Example 4: Disabling the export of a particular column__

	Dim opt = New GridViewDocumentExportOptions() With { _
		Key .ShowColumnHeaders = True _
	}
	opt.ExcludedColumns.Add(grid.Columns(0))
	
	gridViewExport.ExportToXlsx(stream, opt)


## See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Export]({%slug gridview-export%})

 * [Export Async]({%slug gridview-export-async%})

 * [Export Events]({%slug gridview-export-events%})
