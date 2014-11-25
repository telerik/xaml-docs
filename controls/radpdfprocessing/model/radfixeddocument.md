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

## What Is RadFixedDocument

__RadFixedDocument__ is the root that contains all other elements in the __RadPdfProcessing__ model. It exposes the following properties:
        

* __Pages__: The pages collection that contains all __RadFixedPages__ in the document.
            

* __Annotations__: A read-only collection that contains all [Annotations]({%slug radpdfprocessing-model-annotations-and-destinations%}) in the document.
            

* __Destinations__: A collection that contains all [Destinations]({%slug radpdfprocessing-model-annotations-and-destinations%}) in the document.
            

__Example 1__ shows how you can create a new __RadFixedDocument__ instance.
        

#### __[C#] Example 1: Create RadFixedDocument__

{{region radpdfprocessing-model-radfixeddocument_0}}
    RadFixedDocument document = new RadFixedDocument();
{{endregion}}



## Operating with RadFixedDocument

There are different actions which you can execute with the help of a __RadFixedDocument__. For example, you can add a __RadFixedPage__ to an existing document.
        

__Example 2__ adds a page to the document created in __Example 1__.
        

#### __[C#] Example 2: Add page to RadFixedDocument__

{{region radpdfprocessing-model-radfixeddocument_1}}
    RadFixedPage page = document.Pages.AddPage();
{{endregion}}



Alternatively, you can create new __RadFixedPage__ and add it to the __Pages__ collection of a document.
        

__Example 3__ creates a page and adds it to the document created in __Example 1__.
        

#### __[C#] Example 3: Create and add a page to RadFixedDocument__

{{region radpdfprocessing-model-radfixeddocument_2}}
    RadFixedPage page = new RadFixedPage();
    document.Pages.Add(page);
{{endregion}}



# See Also

* [RadFixedDocument API Reference](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_documents_fixed_model_radfixeddocument.html)

* [Model]({%slug radpdfprocessing-model-general-information%})

* [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})

* [Annotations and Destinations]({%slug radpdfprocessing-model-annotations-and-destinations%})
