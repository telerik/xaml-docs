---
title: Exporting Fixed Page to Image
page_title: Exporting Fixed Page to Image
description: Check our &quot;Exporting Fixed Page to Image&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-exporting-fixedpage-to-image
tags: save,saving,exporting,radfixedpage,image,export,to
published: True
position: 4
---

# Exporting Fixed Page to Image

RadPdfViewer provides an API for exporting a PDF document page to an image. This can be done with the __ThumbnailFactory__ class. The class exposes a single method - __CreateThumbnail__ - which accepts objects of type __RadFixedPage__ and __Size__, and returns an __ImageSource__ object.

__Example 1: Using the ThumbnailFactory's method__  
```C#
	ThumbnailFactory thumbnailFactory = new ThumbnailFactory();
	ImageSource imageSource = thumbnailFactory.CreateThumbnail(radFixedPageInstance, new Size(150, 250));
```

The __ThumbnailFactory__ class is defined in the __Telerik.Windows.Documents.UI__ namespace.

## ThumbnailsConverter

The __ThumbnailsConverter__ class is a standard converter that implements the native [IValueConverter](https://msdn.microsoft.com/en-us/library/system.windows.data.ivalueconverter(v=vs.110).aspx). It accepts a __RadFixedDocument__ as a value and returns a __ThumbnailsCollection__ object. The items in the collection are of type __Thumbnail__ and they expose information about the converted __RadFixedPage__ and the image result. You can find a runnable example demonstrating the ThumbnailsConverter in the [PdfViewer/Thumbnails](https://github.com/telerik/xaml-sdk/blob/master/PdfViewer/Thumbnails) SDK example in GitHub.

The converter is defined in the __Telerik.Windows.Documents.Converters__ namespace.

## See Also

* [Getting Started]({%slug radpdfviewer-getting-started%})
* [Viewer Modes]({%slug radpdfviewer-viewer-modes%})
* {% if site.site_name == 'Silverlight' %}[Thumbnail class](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.ui.thumbnail){% endif %}{% if site.site_name == 'WPF' %}[Thumbnail class](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.ui.thumbnail){% endif %}
