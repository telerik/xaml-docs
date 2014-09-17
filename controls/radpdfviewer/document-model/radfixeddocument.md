---
title: RadFixedDocument
page_title: RadFixedDocument
description: RadFixedDocument
slug: radpdfviewer-document-model-radfixeddocument
tags: radfixeddocument
published: True
position: 0
---

# RadFixedDocument



__RadFixedDocument__ is the document that is used in __RadPdfViewer__. 

## Creation

An instance of __RadFixedDocument__ can be created using __PdfFormatProvider__ 
        and assigned to __RadPdfViewer__ in the following way:

#### __C#__

{{region radpdfviewer-document-model-radfixeddocument_0}}
		Stream stream = Application.GetResourceStream(new Uri("PdfViewerDemo;component/SampleData/test.pdf", UriKind.Relative)).Stream;
		RadFixedDocument document = new PdfFormatProvider(stream, FormatProviderSettings.ReadOnDemand).Import();
		this.pdfViewer.Document = document;
	{{endregion}}



>The __PdfFormatProvider__ of __RadPdfViewer__
        must not be confused with that of __RadRichTextBox__.Telerik.Windows.Documents.__Fixed__.FormatProviders.Pdf.PdfFormatProvider is the provider that 
		__RadPdfViewer__ uses to import files. 
		It is located in the __Telerik.Windows.Documents.Fixed__ assembly.For reference, the Telerik.Windows.Documents.FormatProviders.Pdf.PdfFormatProvider
		of __RadRichTextBox__ is included in the __Telerik.Windows.Documents.FormatProviders.Pdf__ assembly,
		in a namespace with the same name. The latter can be used only to export __RadDocument__ to PDF.

As you can see, the PdfFormatProvider accepts two parameters 
        – stream with the contents of the PDF file and format provider settings 
        specifying the loading mode. 

## Members

The members that RadFixedDocument exposes are:

* __Pages__ - a collection of RadFixedPage items created for the current document in the viewer;

* __Selection__ - information about the current selection in the document. [Read more..]({%slug radpdfviewer-text-text-selection%})

* __Annotations__ - a collection of all annotations (such as links) in the current document. [Read more..]({%slug radpdfviewer-document-model-annotations%})

* __Destinations__ - a collection of all destinations (roughly said “bookmarks”) in the document that have links to them. [Read more..]({%slug radpdfviewer-document-model-annotations%})

* __CaretPosition__ – the current position of the caret.[ Read more..]({%slug radpdfviewer-text-text-position%})

# See Also
