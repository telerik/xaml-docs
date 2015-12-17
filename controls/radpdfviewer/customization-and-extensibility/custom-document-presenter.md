---
title: Custom Document Presenter
page_title: Custom Document Presenter
description: Custom Document Presenter
slug: radpdfviewer-customization-and-extensibility-custom-document-presenter
tags: custom,document,presenter
published: True
position: 2
---

# Custom Document Presenter



Document presenters in __RadPdfViewer__ are responsible for displaying the pages of a PDF document, as well as navigating the file and manipulating it. There are two presenters that come out-of-the-box and you can find more information about them  [here]({%slug radpdfviewer-ui-document-presenters%}).
      

Additionally, __RadPDFViewer__ offers the ability to create your own custom document presenter which would help you design the presentational functionality of the document at your will.
      

This article covers the following topics:
      

* [Implementing the IFixedDocumentPresenter Interface](#implementing-the-ifixeddocumentpresenter-interface)

* [Inheriting FixedDocumentPresenterBase](#inheriting-fixeddocumentpresenterbase)

* [Creating a Custom Presenter](#creating-a-custom-presenter)

## Implementing the IFixedDocumentPresenter Interface

Implementing this interface allows you to create a fully functioning document presenter in __RadPdfViewer__. The interface contains the following members:
        

* __Owner:__Тhis property is of type __Telerik.Windows.Documents.UI.IFixedDocumentViewer__ and is implemented by __RadPdfViewer__. The owner of your document presenter is the instance of __RadPdfViewer__ that uses the presenter.
            

* __PointerHandlersController:__ This property is of type  __Telerik.Windows.Documents.Fixed.UI.PointerHandlers.PointerHandlersController__ and the member is responsible for the behavior of __RadPdfViewer__ after mouse or touch events.
            

* __CurrentPage:__ The property gets the current RadFixedPage.
            

* __ShowSelectionMarkers():__ The method shows the selection markers.
            

* __HideSelectionMarkers():__ The method hides the selection markers.
            

* __GetLocationFromViewPoint(Point viewpoint, out RadFixedPage page, out Point location):__ Obtains the page and document location from the provided view point.
            

* __GetViewPointFromLocation(RadFixedPage page, Point location, out Point viewpoint):__ Obtains the view point from the provided page and document location.
            

* __PageUp():__ Navigates to the previous page.
            

* __PageDown():__ Navigates to the next page.
            

* __GoToPage (int pageNumber):__ Navigates to the provided page number.
            

* __GoToDestination(Destination destination):__ Navigates to the provided destination.
            

* __InvalidateMeasure():__ Invalidates the measurement state.
            

* __InvalidateArrange():__ Invalidates the arrangement state.
            

* __UpdatePresenterLayout():__ Updates the presenter layout.
            

* __Initialize(IFixedDocumentViewer owner):__ Initializes the document presenter with the provided owner.
            

* __Initialize(IFixedDocumentViewer owner, IFixedDocumentPresenter presenter):__ Initializes the document presenter with the provided owner and another document presenter.
            

* __Release():__ Releases the resources used by the document presenter.
            

* __CurrentPageChanged:__ This event is fired when the current page is changed.
            

## Inheriting FixedDocumentPresenterBase

The __FixedDocumentPresenterBase__ class implements all the members from __IFixedDocumentPresenter__ but also allows the inheriting class to override those members with custom functionality. Some members of this class are abstract and need to be overridden in the inheriting classes:
        

* __PagesLayoutManager:__ The property is of type __Telerik.Windows.Documents.Fixed.Layout.PagesLayoutManagerBase__  and is responsible for the way pages are laid out in the document.
            

* __CurrentNo:__ The number of the current page.
            

* __VisiblePages:__ A collection of the currently visible pages in the view port of __RadPdfViewer__.
            

* __GetLocationFromViewPoint(Point viewpoint, out RadFixedPage page, out Point location):__ Obtains the document location from the provided view point.
            

* __UpdateScrollOffsetFromPosition(TextPosition position):__ Updates the scroll offset from the provided position.
            

__PagesLayoutManagerBase__ is an abstract class that is responsible for the layout of the document pages. The class provides the following abstract members:
        

* __UpdateLayout(Size viewportSize):__ This method updates the pages layout based on the provided view port.
            

* __GetPagesLayoutInfos():__ Returns a collection of the layout info for all the pages in the document.
            

* __Release():__ Releases the resources of the layout manager.
            

## Creating a Custom Presenter

The following six steps illustrate what you need to do in order to create and register a custom presenter:
        

__Step 1:__ Create a class responsible for the page layout which inherits the abstract __FixedPageLayoutInfo__ class. It should hold the information about how to visualize a single page. Implement the base constructor and add your preferences.
        

#### __C#__

{{region radpdfviewer-customization-and-extensibility-custom-document-presenter_0}}
	    public class SinglePageInfo: FixedPageLayoutInfo
	    {
	        public SinglePageInfo(Telerik.Windows.Documents.Fixed.Model.RadFixedPage page, System.Windows.Rect positionInView) : base(page, positionInView)
	        {
	        ...
	        }
	    }
{{endregion}}


__Step 2:__ Add a new class for your custom presenter that inherits the abstract __FixedDocumentPresenterBase__ class which on its hand inherits the __IFixedDocumentPresenter__ interface.
        

__Step 3:__ Implement all members of the __FixedDocumentPresenterBase__ class to create a fully functional document presenter. Some members of this class are abstract and need to be overridden with custom functionality.
        

#### __C#__

{{region radpdfviewer-customization-and-extensibility-custom-document-presenter_1}}
	    public class CustomSinglePagePresenter : FixedDocumentPresenterBase
	    {
	        protected override int CurrentPageNo
	        {
	            get 
	            { 
	                ...
	            }
	        }
	
	        public override bool GetLocationFromViewPoint(Point viewPoint, out RadFixedPage page, out Point location)
	        {
	            ...
	        }
	
	        protected override PagesLayoutManagerBase PagesLayoutManager
	        {
	          get 
	            { 
	                ...
	            }
	        }
	
	        protected override void UpdateScrollOffsetFromPosition(TextPosition position)
	        {
	            ...
	        }
	
	        protected override IEnumerable<FixedPageLayoutInfo> VisiblePages
	        {
	          get 
	            { 
	                ...
	            }
	        }
	    }
{{endregion}}



__Step 4:__ Create a class which inherits the abstract __PagesLayoutManagerBase__ class which is responsible for the layout of the document pages. Implement all abstract members of this class and override them for your desired scenario.
        

#### __C#__

{{region radpdfviewer-customization-and-extensibility-custom-document-presenter_2}}
	    public class SinglePageLayoutManager : PagesLayoutManagerBase
	    {
	        public override void UpdateLayout(Size viewportSize)
	        {
	            ...
	        }
	
	        public override void Release()
	        {
	            ...
	        }
	
	        protected override List<FixedPageLayoutInfo> GetPagesLayoutInfos()
	        {
	            ...
	        }
	    }
{{endregion}}



__Step 5:__ Override the __PagesLayoutManagerBase__ property and set its field to be of a type of the above created single page information class (see step 1.).
        

#### __C#__

{{region radpdfviewer-customization-and-extensibility-custom-document-presenter_3}}
	        private SinglePageInfo visiblePage;
	        private readonly List<SinglePageInfo> pageLayoutInfos;
	
	        public SinglePageLayoutManager(IFixedDocumentPresenter presenter)
	            : base(presenter)
	        {
	            this.pageLayoutInfos = new List<SinglePageInfo>();
	        }
{{endregion}}



__Step 6:__ Register the custom document presenter like in the following code-snippet:
        

#### __C#__

{{region radpdfviewer-customization-and-extensibility-custom-document-presenter_4}}
	        this.pdfViewer.RegisterPresenter("CustomPresenterName", new CustomSinglePagePresenter());
{{endregion}}



An example demonstrating how to create and register a custom document presenter could be downloaded at our SDK repository [here](https://github.com/telerik/xaml-sdk).
        

# See Also

 * [Document Presenter]({%slug radpdfviewer-ui-document-presenters%})
