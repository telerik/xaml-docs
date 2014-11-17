---
title: Using PdfFormatProvider
page_title: Using PdfFormatProvider
description: Using PdfFormatProvider
slug: radpdfprocessing-formats-and-conversion-pdf-pdfformatprovider
tags: using,pdfformatprovider
published: True
position: 1
---

# Using PdfFormatProvider



__PdfFormatProvider__ makes it easy to import and export a RadFixedDocument from/to PDF format, preserving the entire document structure and formatting.
      

In order to use the format provider you need to add references to the following assemblies

* Telerik.Windows.Documens.Core.dll
          

* Telerik.Windows.Documents.Fixed.dll
          

* Telerik.Windows.Zip.dll
          

## Import

To import a PDF document you need to use the __Import()__ method of __PdfFormatprovider__.
        

__Example 1__ shows how to use PdfFormatProvider to import a PDF document form a file.
        

#### __[C#] Example 1: Import PDF File__

{{region radpdfprocessing-formats-and-conversion-pdf-pdfformatprovider_0}}
	            PdfFormatProvider provider = new PdfFormatProvider();
	            using (Stream input = File.OpenRead("Sample.pdf"))
	            {
	                RadFixedDocument document = provider.Import(input);
	            }
	{{endregion}}



The result from the import method is a RadFixedDocument which can be used like any code-generated document.
        

>Import support is limited to the features that are supported by the export so it is possible that you cannot import all of your custom PDF documents.
          

## Export

__Example 2__ shows how to use the __Export()__ method of PdfFormatProvider to export RadFixedDocument to a file.
        

#### __[C#] Example 2: Export PDF File__

{{region radpdfprocessing-formats-and-conversion-pdf-pdfformatprovider_1}}
	            PdfFormatProvider provider = new PdfFormatProvider();
	            using (Stream output = File.OpenWrite("sample.pdf"))
	            {
	                RadFixedDocument document = CreateRadFixedDocument();
	                provider.Export(document, output);
	            }
	{{endregion}}



The resulting document can be opened in any application which supports PDF documents.
        
