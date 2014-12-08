---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radpdfprocessing-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started



This article will get you started in using the __RadPdfProcessing__ library. It contains the following sections:
      

* [Assembly References](#assembly-references)

* [Creating a Document](#creating-a-document)

* [Exporting to PDF](#exporting-to-pdf)

## Assembly References

In order to use the __RadPdfProcessing__ library in your project you need to add references to the following assemblies:
        

* Telerik.Windows.Documents.Core.dll
            

* Telerik.Windows.Documents.Fixed.dll
            

* Telerik.Windows.Zip.dll
            

## Creating a Document

[RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%}) is the root element in the library. It consists of [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%}) objects and instructions for annotations and destinations in the document. __Example 1__ shows how to create a document and add a page to it.
        

#### __[C#] Example 1: Create Document__

{{region radpdfprocessing-getting-started_0}}
    RadFixedDocument document = new RadFixedDocument();
    RadFixedPage page = document.Pages.AddPage();
{{endregion}}



The page can then be edited through a [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%}) instance. __Example 2__ creates an editor and adds a [TextFragment]({%slug radpdfprocessing-model-textfragment%}) to the page object created in __Example 1__.
        

#### __[C#] Example 2: Add Text__

{{region radpdfprocessing-getting-started_1}}
    FixedContentEditor editor = new FixedContentEditor(page);
    editor.DrawText("Hello RadPdfProcessing!");
{{endregion}}



## Exporting to PDF

Exporting to PDF format can be achieved with the __PdfFormatProvider__ class. __Example 3__ shows how to export the __RadFixedDocument__ we created in __Examples 1 and 2__ to a file.
        

#### __[C#] Example 3: Export to PDF__

{{region radpdfprocessing-getting-started_2}}
    PdfFormatProvider provider = new PdfFormatProvider();
    using (Stream output = File.OpenWrite("Hello.pdf"))
    {
        provider.Export(document, output);
    }
{{endregion}}



# See Also

 * [RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%})

 * [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})

 * [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%})

 * [TextFragment]({%slug radpdfprocessing-model-textfragment%})

 * [PDF Format]({%slug radpdfprocessing-formats-and-conversion-pdf-pdf%})
