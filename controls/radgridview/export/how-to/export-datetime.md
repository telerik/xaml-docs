---
title: Export DateTime Value
page_title: Export DateTime Value
description: Read this article to learn how to export DateTime values from Telerik's DataGrid without having the values appear as numbers.
slug: gridview-export-datetime
tags: export, datetime, value
published: True
position: 5
---

# Export DateTime Value

__PROBLEM__

1) When exporting DateTime values without a specified __DataFormatString__ to Excel, the values appear as numbers as shown in the below image:

__Exporting DateTime values without specified DataFormatString__

![Telerik UI for {{ site.framework_name }} RadGridView DateTime values exported to Excel as raw numbers without a data format string](images/gridview-export-datetime-as-number.png)

2) When exporting DateTime values with specified __DataFormatString__ to Excel, the values appear as strings as shown in the next image:

__Exporting DateTime values with specified DataFormatString__

![Telerik UI for {{ site.framework_name }} RadGridView DateTime values exported to Excel as strings when a data format string is applied](images/gridview-export-datetime-as-string.png)

__CAUSE__

1) In most modern programming environments, dates are stored as real numbers. The integer part of the number is the number of days since some agreed-upon date in the past, called the epoch. In Excel, June 16, 2006, for example, is stored as 38884, counting days where January 1st, 1900 is 1.

2) When a DataFormatString has been specified for a given column, RadGridView exports the string representation of the values in that column.

__SOLUTIONs__

## Export via the Built-In RadGridView Export Methods

When an element is exported through the [ExportToXlsx]({%slug gridview-export-xlsx%}), [ExportToPdf]({%slug gridview-export-pdf%}) or [ExportToWorkbook]({%slug gridview-export-workbook%}) or methods, the arguments of the [ElementExportingToDocument]({%slug gridview-export-events-elementexporting-elementexported-todocument%}) event can be used to modify the visual appearance of the exported values and specify how they should be [formatted](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/format-codes#date-and-time-formatting) in Excel. This is achieved through the  `VisualParameters` property of the `GridViewCellExportingEventArgs`.

__Exporting DateTime Values to Excel__
<snippet id='radgridview-export-how-to-export-datetime-exporting_datetime_values_to_excel-cs' />

<snippet id='radgridview-export-how-to-export-datetime-exporting_datetime_values_to_excel-vb' />


__Exporting DateTime values with ElementExportingToDocument__

![Telerik UI for {{ site.framework_name }} RadGridView DateTime values exported to Excel with correct date formatting through ElementExportingToDocument](images/gridview-export-datetime-as-datetime.png)

## Export via the GridViewSpreadStreamExport Class

When exporting the RadGridView with the [GridViewSpreadStreamExport class]({%slug gridview-export-spreadsheetstreamingexport%}), the event arguments of `ElementExportingToDocument` event will be of the type of `GridViewSpreadStreamElementExportingEventArgs`. To format the number value, create a new `SpreadCellFormat` instance and set the `NumberFormat` property. To apply the formatting, create a new SpreadStreamCellStyle instance, set the created `SpreadCellFormat` to its `CellFormat` property, and apply it to the `e.Style` property of the event arguments. 

__Specify a format when exporting with the GridViewSpreadStreamExport class__
<snippet id='radgridview-export-how-to-export-datetime-specify_a_format_when_exporting_with_the_gridviewspreadstreamexport_class-cs' />

<snippet id='radgridview-export-how-to-export-datetime-specify_a_format_when_exporting_with_the_gridviewspreadstreamexport_class-vb' />


## See Also

* [Export String Value]({%slug gridview-export-troubleshooting-export-string%})

* [Export Numeric Value]({%slug gridview-export-numeric-values%})

* [Format Codes](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/format-codes)

* [Number Formatting](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/number-formats)
