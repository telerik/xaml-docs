---
title: Annotations
page_title: Annotations
description: Annotations
slug: radpdfviewer-document-model-annotations
tags: annotations
published: True
position: 2
---

# Annotations



RadPdfViewer supports Link annotations, which means that if you open a PDF file that includes hyperlinks to absolute URIs, you can click them and have a window open, navigated to the respective address. In addition, if there are links pointing to bookmarks in the same document, the view port will be scrolled to the destination specified in the link.

## 

The current API includes the following members, which allow customization of the default behavior or implementing custom logic:

* __AnnotationClicked__ event of __RadPdfViewer__:This event is fired when you click on an annotation such as a hyperlink.  It comes handy when you want to detect or even cancel the opening of a web page. The __AnnotationEventArgs__ contain the Annotation as property and the Link itself has information of its Action, i.e. if it is a UriAction. Handling the event in the following manner will not only show the Uri of each clicked link as the text of a MessageBox, but will also cancel the default behavior.

#### __C#__

{{region radpdfviewer-document-model-annotations_0}}
	private void viewer_AnnotationClicked(object sender, AnnotationEventArgs e)
	{
	    Link l = e.Annotation as Link;
	    if (l == null)
	    {
	        return;
	    }
	    UriAction a = l.Action as UriAction;
	    if (a == null)
	    {
	        return;
	    }
	    MessageBox.Show(a.Uri.ToString());
	    e.Handled = true;
	}       
{{endregion}}



* __Annotations__ property of __RadFixedDocument__ – a collection which returns all annotations in the document. For example you can retrieve all links using the following code:

#### __C#__

{{region radpdfviewer-document-model-annotations_1}}
	private IEnumerable<Link> GetAllLinks(RadFixedDocument document) 
	{ 
	    foreach (Annotation a in document.Annotations) 
	    { 
	        Link l = a as Link; 
	        if (l != null) 
	        { 
	            yield return l; 
	        } 
	    } 
	} 
{{endregion}}

The bookmarks in terms of “docx bookmarks” are not explicitly saved in PDF files. They are persisted only if there are Link annotations to them, so you can use the snippet below to retrieve all destinations that have links to them:

#### __C#__

{{region radpdfviewer-document-model-annotations_2}}
	private IEnumerable<Destination> GetAllBookmarks(RadFixedDocument document) 
	{ 
	    foreach (Annotation a in document.Annotations) 
	    { 
	        Link l = a as Link; 
	        if (l != null && l.Destination != null) 
	        { 
	            yield return l.Destination; 
	        } 
	    } 
	}
{{endregion}}

In this way it would be possible to create some UI that contains all bookmarks. Then, you could implement the same action as the one being executed when a hyperlink is clicked, i.e. scroll the document to the specific place in the document where the destination of the link is placed. The following code can be used for this purpose – navigating to a specific destination:

#### __C#__

{{region radpdfviewer-document-model-annotations_3}}
	private void GoToDestination(Destination destination) 
	{ 
	    this.pdfViewer.GoToDestination(destination); 
	}
{{endregion}}

This scenario is additionally extended by the option to create your own Destination items, passing a RadFixedPage, horizontal and vertical offsets:

#### __C#__

{{region radpdfviewer-document-model-annotations_4}}
	Destination myDestination = new Location() { Page = this.pdfViewer.Document.Pages[2], Left = 0, Top = 0, Zoom = 1 };
{{endregion}}

If you invoke the method GoToDestination with parameter *myDestination*, this will scroll the document to bring the third page (indexing starts at 0) into view. The same scenario can be implemented using the GoToPage(int pageNumber) when pageNumber = 2, but with Destinations you have finer control in terms of the horizontal and vertical offsets.
        	 

# See Also

 * [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%})
