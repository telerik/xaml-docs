---
title: Export Numeric Values
page_title: Export Numeric Values
description: Learn how to handle the ElementExportingToDocument and ElementExporting event in Telerik's {{ site.framework_name }} DataGrid in order to parse an exported value back to a numeric type.
slug: gridview-export-numeric-values
tags: export,string,values
published: True
position: 4
---

# Export Numeric Values

__PROBLEM__

When exporting a RadGridView to Excel, if you have applied a **DataFormatString** for a certain column of a numeric type, the values are exported as strings.

__CAUSE__

The content of each cell within the column is treated as string due to the formatting that was applied.

__SOLUTION 1__

When an element is exported through the [ExportToXlsx]({%slug gridview-export-xlsx%}), [ExportToWorkbook]({%slug gridview-export-workbook%}) or [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%}) methods, the arguments of the [ElementExportingToDocument]({%slug gridview-export-events-elementexporting-elementexported-todocument%}) event can be used to modify the visual appearance of the exported values and specify how they should be [formatted](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/format-codes) in Excel. This is achieved through the **VisualParameters** property of the **GridViewCellExportingEventArgs**.

**Example 1** illustrates the approach:

__Example 1: Handling the ElementExportingToDocument event__

```C#
	private void Grid_ElementExportingToDocument(object sender, GridViewElementExportingToDocumentEventArgs e)
	{
		if (e.Element == ExportElement.Cell)
		{
			var cellExportingArgs = e as GridViewCellExportingEventArgs;
			if (cellExportingArgs?.Value == null)
				return;

			var tryDouble = double.TryParse(cellExportingArgs.Value.ToString(), out var d);
			if (tryDouble)
			{
				var parameters = cellExportingArgs.VisualParameters as GridViewDocumentVisualExportParameters;
				parameters.Style = new CellSelectionStyle()
				{
					Format = new CellValueFormat("0.00")
				};
				cellExportingArgs.Value = d;
				return;
			}

			var tryInt = int.TryParse(cellExportingArgs.Value.ToString(), out var i);
			if (tryInt)
			{
				var parameters = cellExportingArgs.VisualParameters as GridViewDocumentVisualExportParameters;
				parameters.Style = new CellSelectionStyle()
				{
					Format = new CellValueFormat("0")
				};
				cellExportingArgs.Value = i;
				return;
			}
		}
	}
```
```VB.NET
	Private Sub Grid_ElementExportingToDocument(ByVal sender As Object, ByVal e As GridViewElementExportingToDocumentEventArgs)
		If e.Element = ExportElement.Cell Then
			Dim cellExportingArgs = TryCast(e, GridViewCellExportingEventArgs)
			If cellExportingArgs?.Value Is Nothing Then
				Return
			End If

			Dim tryDouble = Double.TryParse(cellExportingArgs.Value.ToString(), var d)
			If tryDouble Then
				Dim parameters = TryCast(cellExportingArgs.VisualParameters, GridViewDocumentVisualExportParameters)
				parameters.Style = New CellSelectionStyle() With {.Format = New CellValueFormat("0.00")}
				cellExportingArgs.Value = d
				Return
			End If

			Dim tryInt = Integer.TryParse(cellExportingArgs.Value.ToString(), var i)
			If tryInt Then
				Dim parameters = TryCast(cellExportingArgs.VisualParameters, GridViewDocumentVisualExportParameters)
				parameters.Style = New CellSelectionStyle() With {.Format = New CellValueFormat("0")}
				cellExportingArgs.Value = i
				Return
			End If
		End If
	End Sub
```

__SOLUTION 2__

If you're exporting RadGridView's data with the [Export]({%slug gridview-export%}) method, you need to handle the [ElementExporting]({%slug gridview-export-events-elementexporting-elementexported%}) event instead as shown in **Example 2**.

__Example 2: Handling the ElementExporting event__

```C#
	private void Grid_ElementExporting(object sender, GridViewElementExportingEventArgs e)
	{
		if (e.Element == ExportElement.Cell)
		{
			var tryInt = int.TryParse(e.Value.ToString().Replace(",", ""), out var i);
			if (tryInt)
			{
				e.Value = i;
			}

			var tryDouble = double.TryParse(e.Value.ToString().Replace(",", ""), out var d);
			if (tryDouble)
			{
				e.Value = d;
			}
		}
	}
```
```VB.NET
	Private Sub Grid_ElementExporting(ByVal sender As Object, ByVal e As GridViewElementExportingEventArgs)
		If e.Element = ExportElement.Cell Then
			Dim tryInt = Integer.TryParse(e.Value.ToString().Replace(",", ""), var i)
			If tryInt Then
				e.Value = i
			End If

			Dim tryDouble = Double.TryParse(e.Value.ToString().Replace(",", ""), var d)
			If tryDouble Then
				e.Value = d
			End If
		End If
	End Sub
```

## See Also

* [ExportToXlsx]({%slug gridview-export-xlsx%})
* [ExportToWorkbook]({%slug gridview-export-workbook%})
* [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%})
* [ElementExportingToDocument]({%slug gridview-export-events-elementexporting-elementexported-todocument%})
* [Export]({%slug gridview-export%})
* [ElementExporting]({%slug gridview-export-events-elementexporting-elementexported%})
