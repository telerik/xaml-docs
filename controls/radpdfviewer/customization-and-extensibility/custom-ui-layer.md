---
title: Custom UI Layer
page_title: Custom UI Layer
description: Check our &quot;Custom UI Layer&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-customization-and-extensibility-custom-ui-layer
tags: custom,ui,layer
published: True
position: 1
---

# Custom UI Layer

The `RadPdfViewer` control comes with predefined UI layers that provide various functionalities, such as displaying pages, annotations, selection, and others. Additionally, it provides the ability to introduce custom UI layers that can be added to the control's functionality. To do so, you can create a new class that implements the `IUILayer` interface.

The IUILayer interface provides the following API:

* `UIElement`&mdash;Gets the `Canvas` panel that represents the UI layer.
* `Name`&mdash;Gets the name of the UI layer.
* `Initialize(UILayerInitializeContext context)`&mdash;This method is raised when the UI layer is initialized. The parameter of the type of `UILayerInitializeContext` provides the following API:
    * `Document`&mdash;Gets the document of the RadPdfViewer, which is of the type of `RadFixedDocument`.
    * `Owner`&mdash;Gets the owner of the UI layer, which is of the type of `IUILayerContainer`.
    * `Page`&mdash;Gets the page of the type of `RadFixedPage`.
    * `Presenter`&mdash;Gets the presenter of the type of `IFixedDocumentPresenter`.
* `Update(UILayerUpdateContext context)`&mdash;This method is raised when the UI layer is updated. The parameter of the type of `UILayerUpdateContext` provides the following API:
    * `ShouldShowSelectionMarkers`&mdash;Gets or sets whether selection markers should be shown.
    * `Viewport`&mdash;Gets the current viewport, in the type of `Rect`.
* `Clear()`&mdash; This method is raised when the pages of the RadPdfViewer are removed. For example, when updating the control updates the currently visible pages. It provides the ability to clear elements from the UI layer.

__Creating a custom UI layer__
```C#
    public class AddTextUILayer : IUILayer
    {
    	public Canvas UIElement => throw new NotImplementedException();
    
    	public string Name => throw new NotImplementedException();
    
    	public void Clear()
    	{
    		throw new NotImplementedException();
    	}
    
    	public void Initialize(UILayerInitializeContext context)
    	{
    		throw new NotImplementedException();
    	}
    
    	public void Update(UILayerUpdateContext context)
    	{
    		throw new NotImplementedException();
    	}
    }
```

## Registering the custom UI layer

All of the UI layers of the RadPdfViewer control are managed by the `UILayersBuilder` class. To register the custom UI layers, derive from this class and override the `BuildUILayersOverride` method. The parameter will be of the type of `IUILayerContainer` that provides information about the registered UI layers.

__Registering the custom UI layer__
```C#
    public class CustomUILayersBuilder : UILayersBuilder
    {
        protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
        {
            base.BuildUILayersOverride(uiLayerContainer);

            uiLayerContainer.UILayers.AddAfter(DefaultUILayers.ContentElementsUILayer, new AddTextUILayer());
        }
    }
```

## Registering the custom UILayersBuilder

To use the custom UILayersBuilder in the RadPdfViewer control, create a new instance of it, and pass it to the `ExtensibilityManager.RegisterLayersBuilder` static method.

__Registering the custom UILayersBuilder__
```C#
    public class MainWindow : Window
    {
        public MainWindow()
        {
            ExtensibilityManager.RegisterLayersBuilder(new CustomUILayersBuilder());

            InitializeComponent();
        }
    }
```

>tip To download a runnable project with the example from this article, visit [our SDK repository](https://github.com/telerik/xaml-sdk/). You can find the example in the __PdfViewer/AddDocumentContent__ folder.

## See Also

* [Custom Document Presenter]({%slug radpdfviewer-customization-and-extensibility-custom-document-presenter%})
* [Customize PDF Rendering]({%slug radpdfviewer-customize-pdf-rendering%})
