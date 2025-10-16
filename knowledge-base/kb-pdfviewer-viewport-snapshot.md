---
title: Creating a Viewport snapshot in RadPdfViewer
description: Create a snapshot of the visible part of a PDF document in RadPdfViewer for WPF.
type: how-to
page_title: How to create a Viewport snapshot in RadPdfViewer
slug: kb-pdfviewer-viewport-snapshot
position: 0
tags: pdf, pdfviewer, viewport, snapshot, image
ticketid: 1512091
res_type: kb
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2021.1.319</td>
	    </tr>
	    <tr>
            <td>Product</td>
            <td>RadPDFViewer for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to create a snapshot of the visible part (viewport) of a **PDF** document loaded in the **RadPdfViewer**.

## Solution

The first step is to create a custom [IUILayer](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.fixed.ui.layers.iuilayer), which will help us to obtain the Viewport and store it in the _VisiblePagesToViewport_ dictionary.

__Example 1: Creating the custom IUILayer__
```C#

    public class ViewportUILayer : IUILayer
    {
        private RadFixedPage page;
        private readonly Canvas canvas;

        public ViewportUILayer()
        {
            this.canvas = new Canvas();
            this.canvas.Background = Brushes.Transparent;
        }

        public Canvas UIElement => this.canvas;

        public string Name => "ViewportUILayer";

        public void Clear()
        {
            MainWindow.VisiblePagesToViewport.Remove(this.page);
            this.page = null;
        }

        public void Initialize(UILayerInitializeContext context)
        {
            this.page = context.Page;
        }

        public void Update(UILayerUpdateContext context)
        {
            MainWindow.VisiblePagesToViewport[this.page] = context.Viewport;
        }
    }

```

The next step is to create a custom [UILayersBuilder](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.fixed.ui.layers.uilayersbuilder), which will help us to include the newly created ViewportUILayer into the [IUILayerContainer](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.fixed.ui.layers.iuilayercontainer).

__Example 2: Creating the custom UILayersBuilder__
```C#

    public class CustomLayersBuilder : UILayersBuilder
    {
        protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
        {
            base.BuildUILayersOverride(uiLayerContainer);

            uiLayerContainer.UILayers.AddLast(new ViewportUILayer());
        }
    }

```

Using the ExtensibilityManager`s [RegisterLayersBuilder()](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.fixed.ui.extensibility.extensibilitymanager#collapsible-Telerik_Windows_Documents_Fixed_UI_Extensibility_ExtensibilityManager_RegisterLayersBuilder_Telerik_Windows_Documents_Fixed_UI_Layers_UILayersBuilder_) method we will register the CustomLayersBuilder.

__Example 3: Registering the custom UILayersBuilder__
```C#

    public RadFixedDocument document;

    public MainWindow()
    {
        this.InitializeComponent();
        
        CustomLayersBuilder uILayersBuilder = new CustomLayersBuilder();
        ExtensibilityManager.RegisterLayersBuilder(uILayersBuilder);

        PdfFormatProvider pdfFormatProvider = new PdfFormatProvider();
        using (FileStream stream = File.OpenRead("SampleData/SampleDocument.pdf"))
        {
            this.pdfViewer.Document = pdfFormatProvider.Import(stream);
        }
    }

    static MainWindow()
    {
        VisiblePagesToViewport = new Dictionary<RadFixedPage, Rect>();
    }

    public static Dictionary<RadFixedPage, Rect> VisiblePagesToViewport { get; set; }

    private void CreateSnapshot(object sender, RoutedEventArgs e)
    {
        // Implemented in Example 4
    }
		
```

Now when we have the _VisiblePagesToViewport_, we can iterate its pages and export the snapshots to the desired image format using the [ThumbnailFactory](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.ui.thumbnailfactory) class. For the purpose of the example, we will generate a TIFF image.

__Example 4: Exporting the images using the ThumbnailFactory__
```C#

    private void CreateSnapshot(object sender, RoutedEventArgs e)
    {
        ThumbnailFactory thumbnailFactory = new ThumbnailFactory();
        foreach (KeyValuePair<RadFixedPage, Rect> pair in VisiblePagesToViewport.ToList())
        {
            RadFixedPage page = pair.Key;
            Rect viewport = pair.Value;

            Rect saved = page.CropBox;
            page.CropBox = viewport;
            Size size = PageLayoutHelper.GetVisibleContentBox(page).Size;
            ImageSource imageSource = thumbnailFactory.CreateThumbnail(page, size);
            page.CropBox = saved;

            Image image = new Image();
            image.Source = imageSource;

            Grid container = new Grid();
            container.Background = Brushes.White;
            container.Children.Add(image);
            container.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            container.Arrange(new Rect(new Point(0, 0), container.DesiredSize));

            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)size.Width, (int)size.Height, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(container);

            int pageNumber = (page.Parent as RadFixedDocument).Pages.IndexOf(page) + 1;
            string exportedFileName = $"Page_{pageNumber}.tiff";
            using (FileStream fileStream = new FileStream(exportedFileName, FileMode.Create))
            {
                BitmapEncoder encoder = new TiffBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmap));
                encoder.Save(fileStream);
            }

            Process.Start(exportedFileName);
        }
    }

```
