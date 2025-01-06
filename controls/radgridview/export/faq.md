---
title: Useful Tips
page_title: Useful DataGrid Export Tips
description: Check out the FAQ about exporting data from Telerik's {{ site.framework_name }} DataGrid and learn how to export paged data, how to modify the exported value and much more.
slug: gridview-export-faq
tags: export,faq
published: True
position: 7
---

# Useful Export Tips

For a general example on how to Export the data, you can check the Exporting examples of RadGridView in the [WPF Demos](https://demos.telerik.com/wpf/) application.

## How to Export Paged Data

1. Cache the PageSize and the PageIndex of the associated RadDataPager in variables.
2. Set the PageSize of RadDataPager to 0. This will ensure that all items of the GridView are within the current data view.
3. Export the data (you can use the (IEnumerable) dataPager.PagedSource as GridViewExportOptions.Items).
4. Restore the cached PageSize and the PageIndex.

See this approach in the [ExportPagedDataExcel](https://github.com/telerik/xaml-sdk/tree/master/GridView/ExportPagedDataExcel) SDK example.

## How to avoid error warning when exporting and 'xls' extension

The alert is a new security feature in Excel 2007 called Extension Hardening, which ensures that the file content being opened matches the extension type specified in the shell command that is attempting to open the file. In order to avoid getting this warning, you should export to ExcelML format with XML extension. You can also refer to the [following help article]({%slug gridview-troubleshooting-warning-message-excel%}) for additional information.            

## How to Export Data to `xlsx` Format

As of Q1 2015 a new method is introduced: [ExportToXlsx]({%slug gridview-export-xlsx%}). This exporting functionality is demonstrated in the [Exporting to Xlsx and Pdf](https://demos.telerik.com/wpf/) demo.

##  How to Export Data to `pdf` Format

As of Q1 2015 a new method is introduced: [ExportToPdf]({%slug gridview-export-pdf%}). This exporting functionality is demonstrated in the [Exporting to Xlsx and Pdf](https://demos.telerik.com/wpf/) demo.

## Some Columns are Exported With a Minimum Width

RadGridView exports the respective header cells with the minimum width value (which is 20 by default) if they have not been measured by the layout mechanism at the time the exporting operation takes place.To get all the columns exported with their actual width, you should first assure that they have been realized.As an alternative solution, if you do not have that much columns, you can set EnableColumnVirtualization="False" for __RadGridView__.            

## Avoid Exporting Specific Columns

You can subscribe for the `ElementExporting` event of RadGridView to control which columns will be exported.  Once the event is raised, you can cancel the export (by setting `e.Cancel = true`) when the column of the currently exported element is a column you would like to skip.            
            
## How to Modify the Exported Value

You could subscribe for the __ElementExporting__ event of RadGridView and change the __e.Value__ to be exported.
            
## Export Data on Multiple Worksheets of the Same Workbook

You can export data on different worksheets with [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview), which model is completely independent from UI. You can also check the [Export with RadSpreadProcessing](https://demos.telerik.com/wpf/) demo which shows how to export multiple worksheets.
            
## Why OutOfMemoryException May Occur

All the data to be exported is saved in memory, so the exporting capacity are limitted by the memory available for the associated .NET process. For heavier scenarios, you consider using our [Reporting tools](http://www.telerik.com/products/reporting.aspx) built to suit various exporting scenarios. 

You can also export data with the __RadSpreadProcessing__ library. See the [Export with RadSpreadProcessing](https://demos.telerik.com/wpf/) demo which shows how to export the RadGridView data using the library.

Additionally, when it comes to export, you can check the [RadSpreadStreamProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/overview) library which allows you to write directly in the file, instead of holding the complete document model in memory. 

## See Also  
 * [Grid Export]({%slug gridview-export%})
 * [Grid Async Export]({%slug gridview-export-async%})
