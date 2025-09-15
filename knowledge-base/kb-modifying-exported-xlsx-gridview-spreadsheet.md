---
title: Modifying GridView Exported XLSX Spreadsheet
description: Apply custom changes to the spreadsheet document when exporting GridView to Excel xlsx.
type: how-to
page_title: Customize Excel XLSX Spreadsheet When Exporting From RadGridView
slug: kb-gridview-modifying-exported-xlsx-spreadsheet
position: 0
tags: WPF, GridView, RadGridView, Export, Exporting, Excel, Spreadsheet, xlsx, Customizing
res_type: kb
---

## Environment

<table>
	<tr>
		<td>Product Version</td>
		<td>2019.3.1023</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

There are several ways to export the RadGridView as a spreadsheet. This article shows you how to leverage the RadGridView's `ExportToWorkbook` method to make changes to the spreadsheet before saving as Excel xlsx file.

This article will show you how to add an extra row at the top of the speadsheet and insert a title.

## Solution

The first step is to invoke the GridView's **ExportToWorkbook** method, optionally passing a `GridViewDocumentExportOptions` parameter.


```C#
	var exportOptions = new GridViewDocumentExportOptions()
	{
    		ShowColumnFooters = true,
    		ShowColumnHeaders = true,
       		ShowGroupFooters = true,
		ShowGroupHeaderRowAggregates = true
	};
	Workbook workbook = MyGridView.ExportToWorkbook(exportOptions);
```

With the `Workbook` exported, you can now use the features of the Telerik Document Processing Libraries' **RadSpreadProcessing** to modify the document. 

In this example, we are inserting a new row above the exported data to add a title.


```C#
	// Step 1. Get the first worksheet
	Worksheet worksheet = workbook.ActiveWorksheet;

	// Step 2. Insert a new row at the top
	worksheet.Rows.Insert(0);

	// Step 3. Select the worksheet's **A4** cell
	CellSelection selection = worksheet.Cells[0, 4];

	// Step 4. Insert the text "GridView Export" into the selected cell
	selection.SetValue("GridView Export");
```

Finally, we can now save it as an xlsx file using the `XlsxFormatProvider`.


```C#
	var dialog = new SaveFileDialog
	{
	    DefaultExt = "xlsx",
	    Filter = $"Excel files (.xlsx)|.xlsx|All files (.)|.",
	    FilterIndex = 1,
	    FileName = "GridView Export"
	};

	if (dialog.ShowDialog() == true)
	{
	    using (var output = dialog.OpenFile())
	    {
		new XlsxFormatProvider().Export(workbook, output);
	    }
	}
```

## Resources

For more information, visit the following documentation articles:

 * [GridView ExportToWorkbook](https://docs.telerik.com/devtools/wpf/controls/radgridview/export/excel/export-workbook)
 * [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/)
 * [What is a Workbook?](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/working-with-workbooks/working-wtih-workbooks-what-is-workbook)
 * [What is a Worksheet?](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/working-with-worksheets/what-is-worksheet)
 * [Get, Set and Clear Cell Properties](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/working-with-cells/get-set-clear-properties)
