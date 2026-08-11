---
title: Export
page_title: Export
description: Check our &quot;Export&quot; documentation article for the RadPivotGrid WPF control.
slug: radpivotgrid-features-export
tags: export
published: True
position: 2
---

# Export

`RadPivotGrid` allows you to export data to different formats using the `GenerateExport` method. In this article you will learn how to export RadPivotGrid to the following formats: __XLSX__ (Microsoft Excel), __DOCX__ (Microsoft Word), __PDF__ and __HTML__.

## GenerateExport Method

RadPivotGrid's GenerateExport method returns an object of type `PivotExportModel`, which describes each cell of the control and can be used to export the control's data to the aforementioned formats. Through the PivotExportModel you can access the following properties:

* `Cells`&mdash;The collection cells to be exported. This is an `IEnumeration<PivotExportCellInfo>` and each object holds information about various appearance settings such as `Background`, `TextAlignment` and `Indent`. The `PivotExportCellInfo` class also exposes the cell's `Column`, `Row` and `Value`.
* `ColumnCount`&mdash;The number of columns to be exported.
* `RowCount`&mdash;The number of rows to be exported.

>To export RadPivotGrid with all colors and fonts applied, you have to set the [QuickStyle]({%slug radpivotgrid-styles-and-templates-quickstyles%}) property. It is set to default value when RadPivotGrid is loaded, so if you have not set it, you must show the pivot at least once before exporting it.   

The GenerateExport method has two overloads:

* `public PivotExportModel GenerateExport()`&mdash;This overload will call the second overload with __False__ as a value for the __ignoreCollapsedGroups__ parameter, which means that all groups' items will be exported, no matter if some of them are collapsed.
* `public PivotExportModel GenerateExport(bool ignoreCollapsedGroups, bool includeValueFormatting = true)`&mdash;By passing __False__ as the __ignoreCollapsedGroups__ parameter, all groups' items will be exported, no matter if some of them are collapsed. Passing __True__ will ignore the collapsed groups. The second parameter, __includeValueFormatting__, is used to determine whether the formatted value of the cell or the raw value of the cell will be exported. By default, it is set to __True__, which means that the formatted value will be exported. If you set it to __False__, the raw value will be exported.

## Export to Excel

In order to use Export to xlsx (Excel) format, you will have to add reference to the following assemblies:

* __Telerik.Windows.Documents.Core__
* __Telerik.Windows.Documents.Spreadsheet__
* __Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml__

In order to export RadPivotGrid to xlsx format (Excel file), you have to use `XlsxFormatProvider` from *Telerik.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx* namespace. The XlsxFormatProvider has `Export` method, which has two arguments - first one is a `Workbook` that has to be exported and the second one is the output stream. In our case we'll create a simple Workbook (instance of *Telerik.Documents.Spreadsheet.Model.Workbook*) with a single Worksheet (instance of *Telerik.Documents.Spreadsheet.Model.Workbook*) in it.        

Our first task is to get needed information from RadPivotGrid by using Export method. After that we'll create a new Workbook and new Stylesheet. By using the information from the Export method, we'll set the cells in the stylesheet and we'll set the FontSize, FontFamily, Fill, Indent, Value, Borders, etc. The final step is to use the XlsxFormatProvider and its Export method, which will help us to create the xlsx file.        

>You can use the method below and call it on a click of a button for example. By using it, RadPivotGrid will be exported with the same fonts and colors as it is in your application. You can remove the properties, which you do not want to export (for example fill, indent or alignment).         

__Generating the exported workbook__

<snippet id='radpivotgrid-features-export-block_1-cs' />
<snippet id='radpivotgrid-features-export-block_1-vb' />

## Export to Word, Pdf and HTML

In order to Export to docx, pdf or HTML format, you will have to add reference to the following assemblies:

* __Telerik.Windows.Documents__
* __Telerik.Windows.Documents.Core__ 

Based on the format you have selected, you have to add reference to one more assembly. More information is available in the sections below.

No matter which of these three formats you have chosen, you will have to create a new `RadDocument`, which will hold the content, that will be exported. After that, you have to set this RadDocument instance to the `Document` property of RadRichTextBox. This RadRichTextBox must be visualized in order to be able to export its data. To generate RadDocument you can use the code below:        

>tip You can put RadRichTextBox as a content of a `RadWindow` and use the window as PrintPreview dialog. You can check a full implementation of this solution in our [Export](https://demos.telerik.com/wpf/) demo. If you do not want to show PrintPreview dialog, you can set the visibility of the window to collapsed.          

__Generating the exported document__

<snippet id='radpivotgrid-features-export-block_2-cs' />
<snippet id='radpivotgrid-features-export-block_2-vb' />

Here is a simple method, that will export the document to the specified file stream. This method is used in all of the below cases.        

__Method for exporting the generated document__

<snippet id='radpivotgrid-features-export-block_3-cs' />
<snippet id='radpivotgrid-features-export-block_3-vb' />

### Export To Word

>In order to use Export to Word functionality, you will have to add reference to the __Telerik.Windows.Documents.FormatProviders.OpenXml__ assembly.                

After you've generated the document (instance of RadDocument) you have to set the `Document` property of RadRichTextBox. Note that RadRichTextBox should be visible in order to create the document based on Document property.
              
__Exporting the generated document as DOCX__

<snippet id='radpivotgrid-features-export-block_4-cs' />
<snippet id='radpivotgrid-features-export-block_4-vb' />

### Export To Pdf

>In order to use Export to pdf functionality, you will have to add reference to the __Telerik.Windows.Documents.FormatProviders.Pdf__ assembly.                

After you've generated the document (instance of RadDocument) you have to set the `Document` property of RadRichTextBox. Note that RadRichTextBox should be visible in order to create the document based on Document property.              

__Exporting the generated document as PDF__

<snippet id='radpivotgrid-features-export-block_5-cs' />
<snippet id='radpivotgrid-features-export-block_5-vb' />

> The [ExportPivotGrid](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/ExportPivotGrid) example shows how the RadPivotGrid can be exported to PDF via the [PdfProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/overview) library. The approach that is used is similar to the one from the [ExportUIElement](https://github.com/telerik/document-processing-sdk/tree/master/PdfProcessing/ExportUIElement) example.  

### Export To HTML

>In order to use Export to HTML functionality, you will have to add reference to the __Telerik.Windows.Documents.FormatProviders.Html__ assembly.

After you've generated the document (instance of RadDocument) you have to set the `Document` property of RadRichTextBox. Note that RadRichTextBox should be visible in order to create the document based on Document property.              

__Exporting the generated document as HTML__

<snippet id='radpivotgrid-features-export-block_6-cs' />
<snippet id='radpivotgrid-features-export-block_6-vb' />

>A working version of this example is also available in the [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/), titled __Export PivotGrid__.

## See Also

 * [RadPivotGrid Getting Started]({%slug radpivotgrid-getting-started%})
 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})
 * [Features]({%slug radpivotgrid-features%})