---
title: RadDocumentMerger
page_title: RadDocumentMerger
description: Check our &quot;RadDocumentMerger&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-merge-raddocumentmerger
tags: raddocumentmerger, merge, insert, append, documents
published: True
position: 0
---

# RadDocumentMerger Overview

**RadDocumentMerger** introduces an API that enables users to merge two RadDocument instances or append them to each other. When performing merging operations, you may encounter conflicts between the different settings of two documents. Such conflicts can be resolved/avoided by changing the settings of **RadDocumentMerger**.


## Create a RadDocumentMerger

When instantiating the **RadDocumentMerger** class, you should pass to its constructor a [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%}) instance. This parameter represents the document that is used as a target when performing the merging operations.

#### **[C#] Example 1: Create a RadDocumentMerger**

```C#
 
	RadDocumentMerger merger = new RadDocumentMerger(targetDocument);
```

>The document passed to the constructor can be obtained through the **Document property** of the RadDocumentMerger instance.

You can use the methods of the RadDocumentMerger class to [insert the content of the desired documents at the caret position]({%slug radrichtextbox-features-merge-insert-document%}) or just [append]({%slug radrichtextbox-features-merge-append-documents%}) it to the target document.

## See Also

* [Insert Document at the Caret Position]({%slug radrichtextbox-features-merge-insert-document%})
* [Append a Document]({%slug radrichtextbox-features-merge-append-documents%})