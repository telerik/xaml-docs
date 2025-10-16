---
title: RadFixedDocument
page_title: RadFixedDocument
description: Check our &quot;RadFixedDocument&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-document-model-radfixeddocument
tags: radfixeddocument
published: True
position: 0
---

# RadFixedDocument

__RadFixedDocument__ is the class representing a PDF document inside __RadPdfViewer__. 

>important Since R3 2020 RadPdfViewer uses [PdfProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/overview) and its [RadFixedDocument](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/model/radfixeddocument) as a model.

## Creation

You can create a PDF document with the API of PdfProcessing and directly assing it to RadPdfViewer.

#### [C#] Example 1: Create a PDF document and show it  
```C#
    RadFixedDocument document = new RadFixedDocument();
    using (RadFixedDocumentEditor editor = new RadFixedDocumentEditor(document))
    {
        editor.InsertRun("Hello PDF!");
    }
    
    this.pdfViewer.Document = document;
```

For an existing PDF document, an instance of __RadFixedDocument__ can be created using __PdfFormatProvider__  and assigned to __RadPdfViewer__ in the following way:

#### [C#] Example 2: Import a PDF document

```C#

    Stream stream = System.Windows.Application.GetResourceStream(new Uri("PdfViewerDemo;component/SampleData/test.pdf", UriKind.Relative)).Stream;
    
    Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider pdfFormatProvider = new Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider();
    pdfFormatProvider.ImportSettings = Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Import.PdfImportSettings.ReadOnDemand;
    
    RadFixedDocument document = pdfFormatProvider.Import(stream, null);
    this.pdfViewer.Document = document;
```

>The __PdfFormatProvider__ of __RadPdfViewer__ must not be confused with that of __RadRichTextBox__. Telerik.Windows.Documents.__Fixed__.FormatProviders.Pdf.PdfFormatProvider is the provider that __RadPdfViewer__ uses to import files. It is located in the __Telerik.Windows.Documents.Fixed__ assembly.For reference, the Telerik.Windows.Documents.FormatProviders.Pdf.PdfFormatProvider of __RadRichTextBox__ is included in the __Telerik.Windows.Documents.FormatProviders.Pdf__ assembly, in a namespace with the same name. The latter can be used only to export __RadDocument__ to PDF.

As you can see, the Import() method of PdfFormatProvider accepts two parameters  – stream with the contents of the PDF file and format provider settings specifying the loading mode. 

For details about the model used by PdfViewer and the members of [RadFixedDocument](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/model/radfixeddocument), check the documentation of [PdfProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/overview).

## See Also 

* [PdfProcessing Documentation](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/overview) 
