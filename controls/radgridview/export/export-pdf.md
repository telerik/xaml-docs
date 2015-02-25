---
title: ExportFormat.Pdf
page_title: ExportFormat.Pdf
description: ExportFormat.Pdf
slug: gridview-export-pdf
tags: exportformat.pdf
published: True
position: 5
---

# ExportFormat.Pdf

As of Q1 2015 RadGridView exposes a new method – __ExportToPdf__ which allows exporting to Pdf format without the need to integrate RadGridView with RadSpreadProcessing.


>You can read more about the export events [here]({%slug gridview-export-events%}).

__Assembly References__
ExportFormat.Pdf method uses additional libraries so you need to add references to the following assemblies:

* Telerik.Windows.Documents.Core.dll
* Telerik.Windows.Documents.SpreadSheet.dll 
* Telerik.Windows.Documents.SpreadSheet.FormatProviders.Pdf.dll
* Telerik.Windows.Documents.Fixed.dll
* Telerik.Windows.Zip.dll

The method is overloaded:

1. ExportToPdf(Stream stream) - Expects the specified stream to which you are exporting data to.

2. ExportToPdf (Stream stream, GridViewPdfExportOptions options) - Expects the specified stream to which you are exporting data to and parameter of type GridViewPdfExportOptions. The latter is used to set the following export options:

* Culture
* Items
* ShowColumnFooters
* ShowGroupFooters
* ShowColumnHeaders
* ExportDefaultStyles  


The following example shows how to use the method on a button click:

#### __C#__
	private void btnExport_Click(object sender, RoutedEventArgs e)
	{
	    string extension = "pdf";
	
	    SaveFileDialog dialog = new SaveFileDialog()
	    {
	        DefaultExt = extension,
	        Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Pdf"),
	        FilterIndex = 1
	    };
	
	    if (dialog.ShowDialog() == true)
	    {
	        using (Stream stream = dialog.OpenFile())
	        {
	            gridViewExport.ExportToPdf(stream,
	                new GridViewDocumentExportOptions()
	                {
	                    ShowColumnFooters = true,
	                    ShowColumnHeaders = true,
	                    ShowGroupFooters = true,
			      PageOrientation = PageOrientation.Landscape
	                });
	        }
	    }
	}


## ExportDefaultStyles  ##

>note: To export the default styles of RadGridView in grouped state, at least one row must be expanded, so that the exporting engine can get the styles.

RadGridView can be exported with its default styles by setting the ExportDefaultStyles property to “true”

By default the ExportDefaultStyles property is set to false. You can see the result (Figure 1)

__Figure 1__: Exporting with ExportDefaultStyles set to “false” (default)
![ExportDefaultStyles false](images/exportdefaultstyles3.png)

You can set the __ExportDefaultStyles value to “true”__ and see the result (Figure 2)

#### __C#__

	gridViewExport.ExportToPdf(stream,
    new GridViewDocumentExportOptions()
	{
	    ShowColumnHeaders = true,
	    ShowColumnFooters = true,
	    ShowGroupFooters = true,
	    ExportDefaultStyles = true
	});   

__Figure 2__: Exporting with ExportDefaultStyles set to “true”
![ExportDefaultStyles false](images/exportdefaultstyles4.png)

## Events ##

You can read more about export events below.

### ElementExportingToDocument ###

The event handler expects __GridViewElementExportingToDocumentEventArgs__ arguments that have the following methods and properties:
* Element - the export element
* Cancel - the event is cancelable 
* DataContext - the DataContext of the corresponding visual element. For example the DataContext of a row is its corresponding data item.
* Value - the value to be exported
* VisualParameters - they are of type GridViewDocumentVisualExportParameters and have a property Style which is of type CellSelectionStyle. It provides the ability to set the FontSize, Fill and etc. for the exported document.

### ElementExportedToDocument ###

The event handler expects __GridViewElementExportedToDocumentEventArgs__ arguments that have the following methods and properties

* Element - the export Element
* DataContext - the DataContext of the corresponding visual element.

### Getting the column of the corresponding cell###

When a cell is exported (header cell, cell, footer cell, group footer cells), the arguments of the ElementExportingToDocument event can be cast to GridViewCellExportingEventArgs. Thus, the column of the corresponding cell can be accessed. 

The following example illustrates the approach:
#### __C#__
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


#### __VB.NET__
	Me.gridViewExport.ElementExportingToDocument += Function(s, e) 
	    If e.Element = ExportElement.Cell Then
	        Dim cellExportingArgs = TryCast(e, GridViewCellExportingEventArgs)
	            If cellExportingArgs.Column = Me.gridViewExport.Columns(2) Then
	                TryCast(cellExportingArgs.VisualParameters, GridViewDocumentVisualExportParameters).Style = cellStyle
	            End If
	    End If
	End Function
