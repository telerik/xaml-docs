---
title: Using PdfFormatProvider
page_title: Using PdfFormatProvider
description: Using PdfFormatProvider
slug: radspreadprocessing-formats-and-conversion-pdf-pdfformatprovider
tags: using,pdfformatprovider
publish: True
position: 1
---

# Using PdfFormatProvider



__PdfFormatProvider__ is part of SpreadProcessing which allows export to PDF format.
      

## Using PdfFormatProvider

__PdfFormatProvider__ makes it easy to export a Workbook to a PDF format. Each Worksheet exported to PDF is being divided into pages according to its WorksheetPageSetup. More information about paging a Worksheet is available in the [Worksheet Page Setup]({%slug radspreadprocessing-features-worksheetpagesetup%}) documentation article.
        

## Prerequisites

In order to use __PdfFormatProvider__ you need to add references to the assemblies listed below:
        

* Telerik.Windows.Documents.Spreadsheet.dll
            

* Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf.dll
            

## Export

__Example 1__ shows how to use __PdfFormatProvider__ to export a Workbook to a file.
        

#### __[C#] Example 1: PdfFormatProvider Export Example__

{{region radspreadprocessing-formats-and-conversion-pdf-pdfformatprovider_0}}
	                PdfFormatProvider pdfFormatProvider = new PdfFormatProvider();
	                using (Stream output = GetFileStream())
	                {
	                    Workbook workbook = CreateSampleWorkbook();
	                    pdfFormatProvider.Export(workbook, output);
	                }
	{{endregion}}



The result from the export method is a document that can be opened in any application that supports PDF documents.
        
