---
title: Export DateTime Value
page_title: Export DateTime Value
description: Read this article to learn how to export DateTime values from Telerik's {{ site.framework_name }} DataGrid without having the values appear as numbers.
slug: gridview-export-datetime
tags: export, datetime, value
published: True
position: 5
---

# {{ site.framework_name }} RadGridView Export DateTime Value

__PROBLEM__

1) When exporting DateTime values without a specified **DataFormatString** to Excel, the values appear as numbers as shown in **Figure 1**:

#### __Figure 1: Exporting DateTime values without specified DataFormatString__

![Telerik {{ site.framework_name }} DataGrid-export-datetime-as-number](images/gridview-export-datetime-as-number.png)

2) When exporting DateTime values with specified **DataFormatString** to Excel, the values appear as strings as shown in **Figure 2**:

#### __Figure 2: Exporting DateTime values with specified DataFormatString__

![Telerik {{ site.framework_name }} DataGrid-export-datetime-as-string](images/gridview-export-datetime-as-string.png)

__CAUSE__

1) In most modern programming environments, dates are stored as real numbers. The integer part of the number is the number of days since some agreed-upon date in the past, called the epoch. In Excel, June 16, 2006, for example, is stored as 38884, counting days where January 1st, 1900 is 1.

2) When a DataFormatString has been specified for a given column, RadGridView exports the string representation of the values in that column.

__SOLUTION__

When an element is exported through the [ExportToXlsx]({%slug gridview-export-xlsx%}), [ExportToPdf]({%slug gridview-export-pdf%}), [ExportToWorkbook]({%slug gridview-export-workbook%}) or [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%}) methods, the arguments of the [ElementExportingToDocument]({%slug gridview-export-events-elementexporting-elementexported-todocument%}) event can be used to modify the visual appearance of the exported values and specify how they should be [formatted](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/format-codes#date-and-time-formatting) in Excel. This is achieved through the  **VisualParameters** property of the **GridViewCellExportingEventArgs**.

#### __[C#] Example 1: Exporting DateTime Values to Excel__

{{region cs-gridview-export-how-to-export-datetime-1}}
	this.radGridView.ElementExportingToDocument += (s, e) =>
	{
	    if (e.Element == ExportElement.Cell)
	    {
	        var cellExportingArgs = e as GridViewCellExportingEventArgs;
	        if ((cellExportingArgs.Column as GridViewDataColumn) == this.radGridView.Columns[1])
	        {
	            var parameters = cellExportingArgs.VisualParameters as GridViewDocumentVisualExportParameters;
	            parameters.Style = new CellSelectionStyle()
	            {
	                Format = new CellValueFormat("m/d/yyyy")
	            };
	        }
	    }
	};
{{endregion}}

#### __[VB.NET] Example 1: Exporting DateTime Values to Excel__

{{region vb-gridview-export-how-to-export-datetime-2}}
	AddHandler Me.radGridView.ElementExportingToDocument, Sub(s, e)
	                                                          If e.Element = ExportElement.Cell Then
	                                                              Dim cellExportingArgs = TryCast(e, GridViewCellExportingEventArgs)
	                                                              If (TryCast(cellExportingArgs.Column, GridViewDataColumn)) Is Me.radGridView.Columns(1) Then
	                                                                  Dim parameters = TryCast(cellExportingArgs.VisualParameters, GridViewDocumentVisualExportParameters)
	                                                                  parameters.Style = New CellSelectionStyle() With {.Format = New CellValueFormat("m/d/yyyy")}
	                                                              End If
	                                                          End If
	                                                      End Sub
{{endregion}}

#### __Figure 3: Exporting DateTime values with ElementExportingToDocument__

![Telerik {{ site.framework_name }} DataGrid-export-datetime-as-datetime](images/gridview-export-datetime-as-datetime.png)

## See Also

* [Export String Value]({%slug gridview-export-troubleshooting-export-string%})

* [Export Numeric Value]({%slug gridview-export-numeric-values%})

* [Format Codes](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/format-codes)

* [Number Formatting](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/number-formats)
