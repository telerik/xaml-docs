---
title: Using PdfFormatProvider
page_title: Using PdfFormatProvider
description: Using PdfFormatProvider
slug: radrichtextbox-import-export-pdf-pdfformatprovider
tags: using-pdfFormatProvider
published: True
position: 0
---

# Using PdfFormatProvider

__PdfFormatProvider__ makes it easy to import and export __RadDocument__ to PDF format, preserving the entire document structure and formatting.
      

All you have to do in order to use __PdfFormatProvider__ is add references to the assemblies listed below:
      

* __Telerik.Windows.Documents.FormatProviders.Pdf__
* __Telerik.Windows.Zip__

## Export

In order to export a document to PDF you need to use the __Export()__ method of __PdfFormatProvider__.
        

The code snippet in __Example 1__ shows how to create a __PdfFormatProvider__ instance and use it to export __RadDocument__ to a file.
        
>The PdfFormatProvider class of RadRichTextBox is located in the **Telerik.Windows.Documents.Flow.FormatProviders.Pdf namespace**.

#### __[C#] Example 1: Export to PDF file__
{{region cs-radrichtextbox-import-export-pdf-pdfformatprovider_0}}
	PdfFormatProvider provider = new PdfFormatProvider();
	using (Stream output = File.OpenWrite("sample.pdf"))
	{
	    RadDocument document = CreateRadDocument();
	    provider.Export(document, output);
	}
{{endregion}}


The result from the method is a document that can be opened in any application that supports PDF documents.
        

__Example 2__ demonstrates how to export the contents of a __RadDocument__ to a __RadFIxedDocument__. 


#### __[C#] Example 2: Export to RadFixedDocument__
{{region cs-radrichtextbox-import-export-pdf-pdfformatprovider_1}}
    RadDocument document = CreateRadDocument();

    PdfFormatProvider provider = new PdfFormatProvider();
    RadFixedDocument fixedDocument = provider.ExportToFixedDocument(document);
{{endregion}}


>tip __RadFixedDocument__ is the base class of the __RadPdfProcessing__ library. Additional information on the library and its functionality can be found [here]({%slug radpdfprocessing-overview%}).

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings]({%slug radrichtextbox-import-export-pdf-settings%})