---
title: Using PdfFormatProvider
page_title: Using PdfFormatProvider
description: Check our &quot;Using PdfFormatProvider&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-pdf-pdfformatprovider
tags: using-pdfFormatProvider
published: True
position: 0
---

# Using PdfFormatProvider

__PdfFormatProvider__ makes it easy to export __RadDocument__ to PDF format, preserving the entire document structure and formatting.
  
All you have to do in order to use __PdfFormatProvider__ is add a reference to `Telerik.Windows.Documents.FormatProviders.Pdf.dll`.

## Export

In order to export a document to PDF you need to use the __Export()__ method of __PdfFormatProvider__.

The code snippet in __Example 1__ shows how to create a __PdfFormatProvider__ instance and use it to export the document to PDF.
        
>The PdfFormatProvider class of RadRichTextBox is located in the **Telerik.Windows.Documents.FormatProviders.Pdf namespace**.

#### __[C#] Export to PDF file__
{{region cs-radrichtextbox-import-export-pdf-pdfformatprovider_0}}
	PdfFormatProvider provider = new PdfFormatProvider();
	using (Stream output = File.OpenWrite("sample.pdf"))
	{
	    RadDocument document = CreateRadDocument();
	    provider.Export(document, output);
	}
{{endregion}}

The result from the method is a document that can be opened in any application that supports PDF documents.

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings]({%slug radrichtextbox-import-export-pdf-settings%})
