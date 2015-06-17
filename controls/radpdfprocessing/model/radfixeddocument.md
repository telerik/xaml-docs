---
title: RadFixedDocument
page_title: RadFixedDocument
description: RadFixedDocument
slug: radpdfprocessing-model-radfixeddocument
tags: radfixeddocument
published: True
position: 1
---

# RadFixedDocument



__RadFixedDocument__ hosts fixed document content and is the root element in the document elements tree. It holds a collection of [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})  elements.
      

This article will get you familiar with the basics of __RadFixedDocument__. It contains the following sections:
      

* [What Is RadFixedDocument](#what-is-radfixeddocument)
* [Operating with RadFixedDocument](#operating-with-radfixeddocument)
* [Document Information](#document-information)

## What Is RadFixedDocument

__RadFixedDocument__ is the root that contains all other elements in the __RadPdfProcessing__ model. It exposes the following properties:
        

* __Pages__: The pages collection that contains all __RadFixedPages__ in the document.
* __Annotations__: A read-only collection that contains all [Annotations]({%slug radpdfprocessing-model-annotations-and-destinations%}) in the document.
* __Destinations__: A collection that contains all [Destinations]({%slug radpdfprocessing-model-annotations-and-destinations%}) in the document.
* __DocumentInfo__: Contains additional meta information about the document like author, title, etc. 
            

__Example 1__ shows how you can create a new __RadFixedDocument__ instance.
        
<a name="example1"><a/>

#### __[C#] Example 1: Create RadFixedDocument__

{{region radpdfprocessing-model-radfixeddocument_0}}
    RadFixedDocument document = new RadFixedDocument();
{{endregion}}



## Operating with RadFixedDocument

There are different actions which you can execute with the help of a __RadFixedDocument__. For example, you can add a __RadFixedPage__ to an existing document.
        

__Example 2__ adds a page to the document created in [__Example 1__](#example1).
        

#### __[C#] Example 2: Add page to RadFixedDocument__

{{region radpdfprocessing-model-radfixeddocument_1}}
    RadFixedPage page = document.Pages.AddPage();
{{endregion}}



Alternatively, you can create new __RadFixedPage__ and add it to the __Pages__ collection of a document.
        

__Example 3__ creates a page and adds it to the document created in [__Example 1__](#example1).
        

#### __[C#] Example 3: Create and add a page to RadFixedDocument__

{{region radpdfprocessing-model-radfixeddocument_2}}
    RadFixedPage page = new RadFixedPage();
    document.Pages.Add(page);
{{endregion}}


Since Q2 2015 you can merge PDF documents out-of-the-box with the Merge() method of __RadFixedDocument__. This method appends the source document to the current instance of __RadFixedDocument__.

#### __[C#] Example 4: Merge Documents__

{{region radpdfprocessing-model-radfixeddocument_3}}
	document.Merge(source);
{{endregion}}

The code from __Example 4__ will merge the document created in [__Example 1__](#example1) with another __RadFixedDocument__.

## Document Information

__RadFixedDocument__ exposes a __DocumentInfo__ property of type __RadFixedDocumentInfo__, intended to hold additional information about the document. The __RadFixedDocumentInfo__ class allows to set the following properties:

* __Auto__: The author of the document.
* __Title__: The title of the document.
* __Description__: Text that describes the content of the document.

#### __[C#] Example 5: Set DocumentInfo__

{{region radpdfprocessing-model-radfixeddocument_3}}
	document.DocumentInfo.Author = "Jane Doe";
	document.DocumentInfo.Title = "RadFixedDocument";
	document.DocumentInfo.Description = "This document is intended to explain the RadFixedDocument class from the RadPdfProcessing library";
{{endregion}}

>Currently the DocumentInfo property is for export purposes only and meta information about documents is stripped when importing.

# See Also

* [RadFixedDocument API Reference](http://www.telerik.com/help/silverlight/t_telerik_windows_documents_fixed_model_radfixeddocument.html)

* [Model]({%slug radpdfprocessing-model-general-information%})

* [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})

* [Annotations and Destinations]({%slug radpdfprocessing-model-annotations-and-destinations%})
