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

<snippet id='radgridview-export-how-to-export-number-formatstring-example_1_handling_the_elementexportingtodocument_event-cs' />

<snippet id='radgridview-export-how-to-export-number-formatstring-example_1_handling_the_elementexportingtodocument_event-vb' />


__SOLUTION 2__

If you're exporting RadGridView's data with the [Export]({%slug gridview-export%}) method, you need to handle the [ElementExporting]({%slug gridview-export-events-elementexporting-elementexported%}) event instead as shown in **Example 2**.

__Example 2: Handling the ElementExporting event__

<snippet id='radgridview-export-how-to-export-number-formatstring-example_2_handling_the_elementexporting_event-cs' />

<snippet id='radgridview-export-how-to-export-number-formatstring-example_2_handling_the_elementexporting_event-vb' />


## See Also

* [ExportToXlsx]({%slug gridview-export-xlsx%})
* [ExportToWorkbook]({%slug gridview-export-workbook%})
* [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%})
* [ElementExportingToDocument]({%slug gridview-export-events-elementexporting-elementexported-todocument%})
* [Export]({%slug gridview-export%})
* [ElementExporting]({%slug gridview-export-events-elementexporting-elementexported%})
