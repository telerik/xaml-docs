---
title: Export Support
page_title: Export Support
description: Check our &quot;Export Support&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-export-support
tags: export,support,image,screenshot,picture,save,stream
published: True
position: 0
---

# {{ site.framework_name }} RadMap Export Support

The __RadMap__ control has a built-in export to image support.

## Export RadMap to Image

To save the map control as an image you can use its __ExportToImage()__ method. The method has two overloads. One that allows you to export directly to the file system by only passing a file path аnd another one for exporting the image to a stream.

#### __[C#] Example 1: Save the image using a string path__
{{region cs-radmap-features-export-0}}
	radMap.ExportToImage("../../map-image.png");
{{endregion}}

#### __[C#] Example 2: Save the image using a stream__
{{region cs-radmap-features-export-1}}
	using (var stream = File.Create("../../map-image.png"))
	{
		radMap.ExportToImage(stream);
	}   
{{endregion}}

>important Only the current viewport of the map will be exported. Also, the navigation controls won't be included in the saved image.

By default the objects defined in the map layers (VisualizatioLayer or InformationLayer) like map objects and FrameworkElements won't be exported. In order to export them you will need to set the first optional parameter (__includeMapObjects__) of the ExportToImage() method to __True__.

#### __[C#] Example 3: Save map objects__
{{region cs-radmap-features-export-2}}
	radMap.ExportToImage("../../map-image.png", includeMapObjects: true);
{{endregion}}

The last optional parameter (__encoder__) of the method allows you to specify a __BitmapEncoder__.

#### __[C#] Example 4: Set an encoder__
{{region cs-radmap-features-export-3}}
	radMap.ExportToImage("../../map-image.png", encoder: new PngBitmapEncoder());
{{endregion}}

By default the export uses __PngBitmapEncoder__.

> The exporting will work only if the map is properly measured and arranged - otherwise, an exception will be thrown.
	
## See Also
 * [Getting Started] ({%slug radmap-getting-started%})
 * [Visualization Layer] ({%slug radmap-visualization-layer-introduction%})
 * [Export Support (common)] ({%slug common-export-support%})
 * [Export UI Element to PDF - SDK Example](https://github.com/telerik/xaml-sdk/tree/master/PdfProcessing/ExportUIElement).
