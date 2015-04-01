---
title: Using PdfFormatProvider
page_title: Using PdfFormatProvider
description: Using PdfFormatProvider
slug: radwordsprocessing-formats-and-conversion-pdf-pdfformatprovider
tags: using,pdfformatprovider
published: True
position: 2
---

# Using PdfFormatProvider



__PdfFormatProvider__ makes it easy to import and export __RadFlowDocument__ to PDF format, preserving the entire document structure and formatting.
      

All you have to do in order to use __PdfFormatProvider__ is add references to the assemblies listed below:
      

* Telerik.Windows.Documents.Core.dll

* Telerik.Windows.Documents.Flow.dll

* Telerik.Windows.Zip.dll

* Telerik.Windows.Documents.Flow.FormatProviders.Pdf.dll

* Telerik.Windows.Documents.Fixed.dll


## Export

In order to export a document to PDF you need to use the __Export()__ method of __PdfFormatProvider__.
        

The code snippet in __Example 1__ shows how to create a __PdfFormatProvider__ instance and use it to export __RadFlowDocument__ to a file.
        

#### __[C#] Example 1: Export to PDF File__
{{region  radwordsprocessing-formats-and-conversion-pdf-pdfformatprovider_0}}
	PdfFormatProvider provider = new PdfFormatProvider();
	using (Stream output = File.OpenWrite("sample.pdf"))
	{
	    RadFlowDocument document = CreateRadFlowDocument();
	    provider.Export(document, output);
	}
{{endregion}}


The result from the method is a document that can be opened in any application that supports PDF documents.
        

__Example 2__ demonstrates how to export the contents of a __RadFlowDocument__ to a __RadFIxedDocument__. 


#### __[C#] Example 2: Export to RadFixedDocument__
{{region  radwordsprocessing-formats-and-conversion-pdf-pdfformatprovider_1}}
    RadFlowDocument document = CreateRadFlowDocument();

    PdfFormatProvider provider = new PdfFormatProvider();
    RadFixedDocument fixedDocument = provider.ExportToFixedDocument(document);
{{endregion}}


>tip __RadFixedDocument__ is the base class of the __RadPdfProcessing__ library. Additional information on the library and its functionality can be found [here]({%slug radpdfprocessing-overview%}).