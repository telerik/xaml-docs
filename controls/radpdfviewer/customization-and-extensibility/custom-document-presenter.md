---
title: Custom Document Presenter
page_title: Custom Document Presenter
description: Check our &quot;Custom Document Presenter&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-customization-and-extensibility-custom-document-presenter
tags: custom,document,presenter
published: True
position: 2
---

# Custom Document Presenter

Document presenters in __RadPdfViewer__ are responsible for displaying the pages of a PDF document, as well as navigating the file and manipulating it. There are two presenters that come out-of-the-box and you can find more information about them  [here]({%slug radpdfviewer-ui-document-presenters%}).      

Additionally, __RadPDFViewer__ offers you the ability to create your own document presenter, which helps you design the presentational functionality of the document as you want.      

This article covers the following topics:

* [Implementing the IFixedDocumentPresenter Interface](#implementing-the-ifixeddocumentpresenter-interface)

* [Inheriting FixedDocumentPresenterBase](#inheriting-fixeddocumentpresenterbase)

* [Creating a Custom Presenter](#creating-a-custom-presenter)

## Implementing the IFixedDocumentPresenter Interface

Implementing this interface allows you to create a fully functioning document presenter in __RadPdfViewer__. The interface contains the following members:
        

* __Owner__: Тhis property is of type __Telerik.Windows.Documents.UI.IFixedDocumentViewer__ and is implemented by __RadPdfViewer__. The owner of your document presenter is the instance of __RadPdfViewer__ that uses the presenter.
            

* __PointerHandlersController:__ This property is of type  __Telerik.Windows.Documents.Fixed.UI.PointerHandlers.PointerHandlersController__ and the member is responsible for the behavior of __RadPdfViewer__ after mouse or touch events.
            

* __CurrentPage:__ The property gets the current RadFixedPage.
            

* __ShowSelectionMarkers():__ The method shows the selection markers.
            

* __HideSelectionMarkers():__ The method hides the selection markers.
            

* __GetLocationFromViewPoint(Point viewpoint, out RadFixedPage page, out Point location):__ This method obtains the page and document location from the provided view point.
            

* __GetViewPointFromLocation(RadFixedPage page, Point location, out Point viewpoint):__ This method obtains the view point from the provided page and document location.
            

* __PageUp():__ This method navigates to the previous page.
            

* __PageDown():__ This method navigates to the next page.
            

* __GoToPage (int pageNumber):__ This method navigates to the provided page number.
            

* __GoToDestination(Destination destination):__ This method navigates to the provided destination.
            

* __InvalidateMeasure():__ This method invalidates the measurement state.
            

* __InvalidateArrange():__ This method invalidates the arrangement state.
            

* __UpdatePresenterLayout():__ This method updates the presenter layout.
            

* __Initialize(IFixedDocumentViewer owner):__ This method initializes the document presenter with the provided owner.
            

* __Initialize(IFixedDocumentViewer owner, IFixedDocumentPresenter presenter):__ This method initializes the document presenter with the provided owner and another document presenter.
            

* __Release():__ This method releases the resources used by the document presenter.
            

* __CurrentPageChanged:__ This event is fired when the current page is changed.
            

## Inheriting FixedDocumentPresenterBase

The [__FixedDocumentPresenterBase__](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.ui.fixeddocumentpresenterbase) class implements all the members from [__IFixedDocumentPresenter__](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.ui.ifixeddocumentpresenter) but it allows the inheriting class to override those members with custom functionality. Some members of this class are abstract and need to be overridden in the inheriting classes:
        

* __PagesLayoutManager:__ The property is of type __Telerik.Windows.Documents.Fixed.Layout.PagesLayoutManagerBase__  and is responsible for the way pages are laid out in the document.
            

* __CurrentNo:__ The number of the current page.
            

* __GetLocationFromViewPoint(Point viewpoint, out RadFixedPage page, out Point location):__ This method obtains the document location from the provided view point.
            

* __UpdateScrollOffsetFromPosition(TextPosition position):__ This method updates the scroll offset from the provided position.
            

__PagesLayoutManagerBase__ is an abstract class responsible for the layout of the document pages. The class provides the following abstract members:
        

* __UpdateLayout(Size viewportSize):__ This method updates the page layout based on the provided view port.
            

* __GetPagesLayoutInfos():__ This method returns a collection of the layout information for all the pages in the document.
            

* __Release():__ This method releases the resources of the layout manager.
            

## Creating a Custom Presenter

The following steps illustrate what you need to do to create and register a custom document presenter:
        

__Step 1:__ Create a class that inherits the abstract [__FixedPageLayoutInfo__](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.fixed.layout.fixedpagelayoutinfo) class. This class is responsible for the page layout and should hold information about how to visualize a single page. Implement the base constructor and add your preferences.
        

__Example 1: Implement FixedPageLayoutInfo__

```C#
	public class SinglePageInfo : FixedPageLayoutInfo
	{
	    public SinglePageInfo(Telerik.Windows.Documents.Fixed.Model.RadFixedPage page, System.Windows.Rect positionInView)
	        : base(page, positionInView)
	    {
	        //...
	    }
	}
```

__Step 2:__ Create a class that inherits the abstract [__PagesLayoutManagerBase__](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.fixed.layout.pageslayoutmanagerbase) class, and will be responsible for the layout of the document pages. Implement all abstract members of the class and override them according to your scenario.
       

__Example 2: Implement PagesLayoutManagerBase__

```C#
    public class SinglePageLayoutManager : PagesLayoutManagerBase
    {
        private SinglePageInfo visiblePage;
        private readonly List<SinglePageInfo> pageLayoutInfos;

        public SinglePageLayoutManager(IFixedDocumentPresenter presenter)
            : base(presenter)
        {
            this.pageLayoutInfos = new List<SinglePageInfo>();
        }

        protected override List<FixedPageLayoutInfo> GetPagesLayoutInfos()
        {
            List<FixedPageLayoutInfo> result = new List<FixedPageLayoutInfo>();
            foreach (var info in this.pageLayoutInfos)
            {
                result.Add(info);
            }

            return result;
        }

        public override void Release()
        {
            // Release pageLayoutInfos here.
        }

        public override void UpdateLayout(Size viewportSize)
        {
            // Update pageLayoutInfos here.
        }
    }
``` 

__Step 3:__ Add a new class for your custom presenter that inherits the abstract [__FixedDocumentPresenterBase__](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.ui.fixeddocumentpresenterbase) class which, in turn, inherits the __IFixedDocumentPresenter__ interface.
        

__Step 4:__ Implement all the members of the __FixedDocumentPresenterBase__ class to create a fully functional document presenter. Some members of the FixedDocumentPresenterBase class are abstract and need to be overridden with custom functionality.

>To ensure that the content is loaded, verify that the **VisiblePages** property of FixedDocumentPresenterBase is set every time the visible pages in the presenter are changed.

__Step 5:__ Register the custom document presenter as demonstrated in **Example 3**.        

__Example 3: Register a custom document presenter__

```C#
	this.pdfViewer.RegisterPresenter("CustomPresenterName", new CustomSinglePagePresenter());
```



>tip You can download an example that demonstrates how to create and register a custom document presenter from  [our SDK repository on GitHub](https://github.com/telerik/xaml-sdk/blob/master/PdfViewer/CustomPresenter).
        

## See Also

 * [Document Presenter]({%slug radpdfviewer-ui-document-presenters%})
