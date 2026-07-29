---
title: Annotations
page_title: Annotations
description: Check our &quot;Annotations&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-document-model-annotations
tags: annotations
published: True
position: 2
---

# Annotations

RadPdfViewer supports link annotations, which means that if you open a PDF file that includes hyperlinks to absolute URIs, you can click them and have a window open, navigated to the respective address. In addition, if there are links pointing to bookmarks in the same document, the viewport will be scrolled to the destination specified in the link.

## Annotation and Hyperlink Click Events

* `AnnotationClicked` event of `RadPdfViewer`&mdash;This event is fired when you click on an annotation such as a hyperlink.  It comes in handy when you want to detect or even cancel the opening of a web page. The `AnnotationEventArgs` contains the `Annotation` and `Link` objects. The action of the clicked annotation can be determined by the `Action` property of the event args. Handling the event in the following manner will not only show the URI of each clicked link as the text of a MessageBox, but will also cancel the default navigation behavior.

	__Defining the AnnotationClicked event handler__
	<snippet id='radpdfviewer-document-model-annotations-block_1-cs' />

* `HyperlinkClicked` event of `RadPdfViewer`&mdash;This event is similar to `AnnotationClicked`, but it is raised only when you click on the __hyperlink__ type annotations. It allows you to cancel the navigation to the associated URI or to modify the click action. The `HyperlinkClickedEventArgs` gives access to the URL, which can be manually checked if it is trusted. In case the navigation should be canceled, set the `Handled` property of the event args to `true` or the `IsTrustedUrl` property to `false`.

	__Using the HyperlinkClicked event to ask the customer if wants to open the hyperlink__
	<snippet id='radpdfviewer-document-model-annotations-block_2-cs' />


## Accessing the Annotations Collection

The `Annotations` collection property of `RadFixedDocument` provides access to all annotations in the document.

__Accessing all annotations in the document__ 
<snippet id='radpdfviewer-document-model-annotations-block_3-cs' />

## Working with Bookmarks

The bookmarks in terms of “docx bookmarks” are not explicitly saved in PDF files. They are persisted only if there are link annotations assigned to them. The following example shows how to retrieve all bookmark destinations that have links anchored to them.

__Accessing annotations containing bookmarks__
<snippet id='radpdfviewer-document-model-annotations-block_4-cs' />

The following example shows how to manually navigate to a bookmark. This idea can be used to implement external auto-[scrolling]({%slug radpdfviewer-scrolling%}) logic (like a table of content UI).

__Using the GoToDestination method__
<snippet id='radpdfviewer-document-model-annotations-block_5-cs' />

It is not necessary for the `Destination` object to be existing. You can create one and manually adjust the scroll position.

__Creating a Destination object manually__
<snippet id='radpdfviewer-document-model-annotations-block_6-cs' />

The code above will scroll the document to bring the top-left corner of the third page (indexing starts at 0) into view. The same scenario can be implemented using the `GoToPage(int pageNumber)` when pageNumber = 2, but when using `Destination` objects you have more control in terms of the horizontal and vertical offsets.        	 

## See Also  
 * [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%})