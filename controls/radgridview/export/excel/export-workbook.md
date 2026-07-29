---
title: ExportToWorkbook
page_title: ExportToWorkbook
description: Read about the ExportToWorkbook functionality of Telerik's {{ site.framework_name }} DataGrid used to modify the content of the exported grid and avoid styling the document manually.
slug: gridview-export-workbook
tags: gridview,export,workbook
published: True
position: 3
---

# ExportToWorkbook

In __R1 2016__ we introduced a new extension method related to the exporting of RadGridView - *ExportToWorkbook()*. You can use it if you need to modify the content of the exported RadGridView and avoid styling the document manually.

## Assembly References

__ExportToWorkbook__ uses additional libraries so you need to add references to the following assemblies:

* Telerik.Windows.Controls.GridView.Export.dll
* Telerik.Windows.Documents.Core.dll
* Telerik.Windows.Documents.Spreadsheet.dll 
* Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll

## Usage

This method exports the associated RadGridView to a [Workbook](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/working-with-workbooks/working-with-workbooks-what-is-workbook) object. **Examples 1 and 2** show how you can modify that object before exporting.

__Example 1: Export RadGridView to a Workbook and modify cell style:__
<snippet id='radgridview-export-excel-export-workbook-example_1_export_radgridview_to_a_workbook_and_modify_cell_style-cs' />


>As of **R3 2020**, you can also export the workbook to an **XLS** file using the [XlsFormatProvider](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/formats-and-conversion/xls/xlsformatprovider) similarly to the XlsxFormatProvider. For the purpose, you need to add a reference to the **Telerik.Windows.Documents.Spreadsheet.FormatProviders.Xls.dll** assembly and change the extension of the exported file.

__Example 2: Double the width of the exported columns:__
<snippet id='radgridview-export-excel-export-workbook-example_2_double_the_width_of_the_exported_columns-cs' />


## GridViewDocumentExportOptions

The method can be overloaded and take __GridViewDocumentExportOptions__ as a parameter. You can use it to set the following export options:

* Culture
* Items
* ShowColumnFooters
* ShowGroupFooters
* ShowColumnHeaders
* ExportDefaultStyles  

>important The __ExportToWorkbook__ method utilizes the **SpreadProcessing library**. You can check the respective [documentation](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) for more information on how to use the library.

## See Also

* [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%})
* [ExportToXlsx]({%slug gridview-export-xlsx%})
* [ExportToPdf]({%slug gridview-export-pdf%})
