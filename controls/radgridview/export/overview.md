---
title: Overview
page_title:  Overview
description:  Overview
slug: gridview-export-overview
tags: grid,export,overview
published: True
position: 0
---

# Overview

__RadGridView__ provides built-in methods for exporting its data to various formats. Underneath, the control utilizes the [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) and [RadSpreadStreamProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/overview) libraries for handling these operations. 

## Export to Excel

As of R1, though the new **GridViewSpreadStreamExport** class which utilizes the **RadSpreadStreamProcessing** library, you can export larger data sets more quickly. Asynchroneous export is supported as well. More information about this recommended approach of exporting the RadGridView control can be found [here]({%slug gridview-export-spreadsheetstreamingexport%}).

Exporting to the __XLSX__  format can also be achieved by using the following two extension methods:

- [ExportToXlsx]({%slug gridview-export-xlsx%})
- [ExportToWorkbook]({%slug gridview-export-workbook%})

## Export to Pdf

To export the control to the __PDF__  format you can use the following two extension methods:

- [ExportToPdf]({%slug gridview-export-xlsx%})
- [ExportToRadFixedDocument]({%slug gridview-export-workbook%})

## Export to Other Formats

Exporting to **ExcelML**, **HTML**, **CSV**, and **plain text** is also supported by using the [Export]({%slug gridview-export%}) and [ExportAsync]({%slug gridview-export-async%}) methods and specifying the **ExportFormat**.

The control also provides the **ToExcelML**, **ToHtml**, **ToCsv** and **ToText** extension methods each of which returns a string of the exported data.

## Customizing the Export

You can modify and style the exported data by utilizing the [export events]({%slug gridview-export-events-elementexporting-elementexported-todocument%}).

Alternatively, you can use the [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) library and export the data manually. Thus, heavier customizations such as adding or removing visual elements from the exported data can be applied. Such implementation is demonstrated in the {% if site.site_name == 'WPF' %} [RadGridView Integration](https://demos.telerik.com/wpf/) {% else %} [RadGridView Integration](https://demos.telerik.com/silverlight/#SpreadProcessing/RadGridViewIntegration) {% endif %} example.

## See Also

 * [Grid Export]({#slug gridview-export})
 * [Grid Async Export]({%slug gridview-export-async%})
 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})
 * [ExportFormat.Html]({%slug gridview-export-html%}) 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%}) 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})
