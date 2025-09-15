---
title: Performance
page_title: Performance
description: Check our &quot;Performance&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-performance
tags: performance
published: True
position: 15
---

# Performance

When developing __RadRichTextBox__, we try to optimize the operations being executed as much as possible. Nevertheless, with the large amount of available features it cannot be helped that there might be performance diminishment in specific cases. 

This article lists some of the known factors that have negative impact on the time that common operations usually take and the overall responsiveness of the UI and provides some tips.      

* [Container](#container)

* [Initial Loading Time](#initial-loading-time)

* [Editing Documents Programmatically](#editing-documents-programmatically)

* [Subscribing to Events](#subscribing-to-events)

* [Document Content](#document-content)

## Container

One of the factors that influence the behavior of the editor is the type of container it is in. The control uses [UI Virtualization]({%slug radrichtextbox-features-ui-virtualization%}) by creating UI elements only for the parts of the document currently visible in the view port. In order to be able to calculate which fragments are shown on screen, __RadRichTextBox__ should *not* be measured in infinity.

Containers that measure their children in infinity are for example __StackPanel__, __ScrollViewer__ and __Grid__ (if the *Height* of the row is *Auto*). Note that if you put __RadRichTextBox__ in a Grid row with fixed height or __Height="*"__, there will be no problem for the control to draw only the visible UI elements used to show the content of the document.

__Avodid placing RadRichTextBox in containers measuring their children with infinity.__

## Initial Loading Time

The control's use of MEF is a big factor for the performance of __RadRichTextBox__. More about this framework and how to reduce the initial loading of the control is described in [this article]({%slug radrichtextbox-mef%}).


## Editing Documents Programmatically

Making changes in a document triggers updates in its layout which, especially for big documents, can be time-consuming. 

Normally, user interaction with a document will trigger actions slower compared to executing the same actions programmatically. This can potentially lead to triggering many updates in a document when manipulating it from code. To avoid this, you can combine several actions in a single undo group using the __BeginUndoGroup()__ and __EndUndoGroup()__ methods of [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}).

>tip Combine programtic changes over a document in a single undo group.

## Subscribing to Events

__RadRichTextBox__ exposes plenty of events that allow you to capture document changes or command executions. While this can be very convenient when you need to handle user interaction, it is highly recommended to avoid placing complex logic in events that are raised often. Examples for such are __DocumentContentChanged__, __CommandExecuting__ and __CommandExecuted__.

__Avoid executing time-consuming actions in `DocumentContentChanged` event handler.__

## Document Content

The type of the document content also influences the performance. This is only natural, as showing and editing heavily formatted documents takes a bigger toll than just previewing plain text.

The performance can be hindered by the following factors:        

### Large Paragraphs and Words

Large paragraphs can be a hindrance to the overall performance because paragraphs are the main unit of the measure and layout cycle. This means that most of the operations concerning changes in the document (e.g. when you insert, delete or format parts of the document) require an invalidation of the layout of the current paragraph. Therefore, the larger the paragraphs in the document, the worse the performance.        

Documents with such big paragraphs are sometimes created when one uses line breaks instead of new paragraphs. In MS Word and __RadRichTextBox__ pressing Enter creates a new paragraph, while Shift + Enter inserts a line break. More often than not documents with line-breaks instead of new paragraphs are a result of incorrect code-behind generation of the document and can be easily avoided.

In addition, words that are longer than one line can also hinder the performance. This is so because processing documents containing such words often results in invalidating large portions of the document. This type of performance issue can be observed when using languages where the words are not separated by intervals, e.g. Japanese, Chinese, etc.

>tip Avoid showing documents containing large paragraphs splitted into lines with line breaks.

### Tables

Tables are one of the most complex elements which can be included in a __RadDocument__. Their behavior in general cases is pretty good, however when a table is extremely large (1000 rows or more) the scrolling/editing experience is diminished.

The performance in versions *prior Q1 2014* was also hindered by the [UI layer]({%slug radrichtextbox-features-custom-ui-layers%}) responsible for re-sizing table borders. This can be worked around by removing the layer:        

#### __C#__  
```C#
    class MyCustomUILayerBuilder : UILayersBuilder
    {
        protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
        {
            base.BuildUILayersOverride(uiLayerContainer);
            uiLayerContainer.UILayers.Remove(DefaultUILayers.TableCellBordersResizeLayer);
        }
    }
```

### Annotations

The term "annotations" stands for anything deriving from AnnotationMarkerBase (see [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})), which includes both “native” and user-defined annotations. This comprises Bookmarks, Hyperlinks, Fields, Comments, Permission and ReadOnly Ranges and Floating Images.

The reason for the impact on the performance is that these elements are kept in special caches in order to enable the specific action that they implement. The more the annotations, the larger the caches, hence the negative effect on the performance.        

### Headers and Footers, Notes and Comments

It is possible to add [headers and footers]({%slug radrichtextbox-features-headers-and-footers%}) for each section in the document. The same is also true for [Endnotes and Footnotes]({%slug radrichtextbox-features-footnotes-endnotes%}), as well as [Comments]({%slug radrichtextbox-features-comments%}). This provides the means for creating even richer documents, but all this additional content is shown in separate instances of __RadRichTextBox__. Furthermore, the contents of the documents of the headers and footers have to be copied across all pages of the section, which may cause performance hindrance with large documents.

## See Also  
* [MEF]({%slug radrichtextbox-mef%})
* [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})