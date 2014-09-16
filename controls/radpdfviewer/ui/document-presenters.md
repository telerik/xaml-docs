---
title: Document Presenters
page_title: Document Presenters
description: Document Presenters
slug: radpdfviewer-ui-document-presenters
tags: document,presenters
publish: True
position: 6
---

# Document Presenters



This article will help you get familiar with the concept of a document presenter in __RadPDFViewer__.

In this article the following topics are concerned:
      

* [What Is a Document Presenter](#what-is-a-document-presenter)

* [Using FixedDocumentPagesPresenter](#using-fixeddocumentpagespresenter)

* [Using FixedDocumentSinglePageViewPresenter](#using-fixeddocumentsinglepageviewpresenter)

## What Is a Document Presenter

The document presenter is responsible for displaying the pages of the document, navigating in it, managing the selection markers, conversion between view coordinates and document location coordinates, plus proper response to mouse and touch events.
        

__RadPdfViewer__ provides two presenters out of the box:
        

* __FixedDocumentPagesPresenter__

* __FixedDocumentSinglePageViewPresenter__

Both of those presenters inherit the abstract __Telerik.Windows.Documents.UI.FixedDocumentPresenterBase__ class, which implements the __Telerik.Windows.Documents.UI.IFixedDocumentPresenter__ interface.
        

You can access the document presenter in __RadPdfViewer__ by accessing the __FixedDocumentPresenter__ property. 
        

## Using FixedDocumentPagesPresenter

This document presenter displays the pages in a vertical order and is used by default by __RadPdfViewer__. There is a fixed margin between the pages, and each pages is centered horizontally inside the __RadPdfViewer__ viewport. The next snippet shows how to set it as the currently used presenter:
        

#### __C#__

{{region radpdfviewer-ui-document-presenters_0}}
			this.radPdfViewer.FixedDocumentPresenter = this.viewer.GetRegisteredPresenter(FixedDocumentPresenterNames.FixedDocumentPagesPresenter);
	{{endregion}}



And here is the result:        
        ![Rad Pdf Viewer Ui Document Presenters 01](images/RadPdfViewer_Ui_Document_Presenters_01.png)

## Using FixedDocumentSinglePageViewPresenter

This document presenter displays a single page inside the viewport. The page is vertically and horizontally centered. The next snippet shows how to set the __FixedDocumentSinglePageViewPresenter__ as the currently used presenter:        
        

#### __C#__

{{region radpdfviewer-ui-document-presenters_1}}
			this.radPdfViewer.FixedDocumentPresenter = this.viewer.GetRegisteredPresenter(FixedDocumentPresenterNames.FixedDocumentSinglePageViewPresenter);
	{{endregion}}



The result is as follows:    
        ![Rad Pdf Viewer Ui Document Presenters 02](images/RadPdfViewer_Ui_Document_Presenters_02.png)

# See Also

 * [Rotation]({%slug radpdfviewer-rotation%})

 * [Custom Document Presenter]({%slug radpdfviewer-customization-and-extensibility-custom-document-presenter%})
