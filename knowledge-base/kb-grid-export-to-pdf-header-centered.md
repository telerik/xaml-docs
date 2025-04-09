---
title: Exporting RadGridView to PDF with Header, Footer, and Repositioning
description: Learn how to export RadGridView content to a PDF document, including adding headers, footers, and centering the grid horizontally using RadFixedDocument.
type: how-to
page_title: How to Export RadGridView to PDF with Custom Headers and Footers in WPF
slug: export-radgridview-to-pdf-wpf
tags: radgridview, wpf, export, pdf, radfixeddocument, header, footer
res_type: kb
ticketid: 1684164
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadGridView for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2025.1.211</td>
</tr>
</tbody>
</table>

## Description

When trying to export the content of a RadGridView component to a PDF document, adding additional information such as headers and footers, as well as centering the table horizontally, can enhance the document's appearance and usefulness. This knowledge base article also answers the following questions:
- How to add a header and footer when exporting RadGridView to PDF?
- How to center a RadGridView horizontally in a PDF document?
- How to customize the PDF export of RadGridView in WPF?

## Solution

To achieve the export of RadGridView content to a PDF document with headers, footers, and proper positioning, you can utilize the RadFixedDocument component. However, a more straightforward approach involves exporting the document to a Spreadsheet and then to PDF. This method allows easy setting of page options and inserting headers and footers without manually drawing the content.

The steps below outline this process:

1. Export the RadGridView content to a Spreadsheet document.
2. Use the Spreadsheet document's page setup options to insert headers and footers.
3. Export the Spreadsheet document to a PDF file.

Here is an example code snippet demonstrating how you can implement this solution:

```csharp
private static RadFixedDocument CreateDocument(RadGridView gridView)
{ 
    var workbook = gridView.ExportToWorkbook(new GridViewDocumentExportOptions
    {
        ShowColumnHeaders = true,
        ShowGroupFooters = true,
        AutoFitColumnsWidth = true,
        ShowGroupRows = true,
        ShowGroupHeaderRowAggregates = false,
    });

    WorksheetPageSetup pageSetup = workbook.Worksheets[0].WorksheetPageSetup;
     
    pageSetup.CenterHorizontally = true; 

    var spreadPdfProvider = new Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf.PdfFormatProvider();
    spreadPdfProvider.ExportSettings = new Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf.Export.PdfExportSettings(ExportWhat.EntireWorkbook, false);

    var worksheet = workbook.Worksheets[0];

    HeaderFooterSettings settings = worksheet.WorksheetPageSetup.HeaderFooterSettings;
    settings.Header.RightSection.Text = "Printed by Telerik";
    settings.Footer.CenterSection.Text = "RadSpreadProcessing";

    var gridDocument = spreadPdfProvider.ExportToFixedDocument(workbook, null);

    return gridDocument;
}

```

Remember to adjust the `ExportGridViewToWorksheet` method to correctly transfer data from your RadGridView to the Spreadsheet's worksheet.

### See Also

- [Worksheet Page Setup Properties](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/worksheetpagesetup#worksheetpagesetup-properties)
- [Headers and Footers in RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/headers-and-footers)