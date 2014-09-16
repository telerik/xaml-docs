---
title: Model
page_title: Model
description: Model
slug: radpdfprocessing-model
tags: model
published: True
position: 3
---

# Model



This article explains the structure of __RadPdfProcessing__'s document model.
      

## DocumentElements

[RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%}) is the root element of all document elements. All document elements inherit from the __FixedDocumentElementBase__ abstract class. The diagram below describes the hierarchy in the __RadPdfProcessing__.
        ![Rad Pdf Processing Model 01](images/RadPdfProcessing_Model_01.png)

## Composition of Document Elements

__RadFixedDocument__ represents a tree of [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%}) where the fixed content is hosted. The diagram below describes the composition of the fixed content. The document elements are denoted in black and collections - in orange.
        ![Rad Pdf Processing Model 02](images/RadPdfProcessing_Model_02.png)

# See Also

 * [RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%})

 * [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})
