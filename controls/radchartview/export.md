---
title: Export
page_title: Export
description: Export to PDF.
slug: radchartview-export
tags: export, pdf, radchartview, chartview
published: True
position: 4
---

# Export 

The __RadChartView__ suite does not have a built-in functionality for exporting the chart, but there are several ways that you can utilize to achieve that. 

## Export RadChartView to PDF

You can export the charting components using the __ExportUIElement__ example which implements exporting of UIElements with the [Document Processing Libraries]({%slug document-processing-libraries-overview%}) library. You can read about the example in the [Export Support]({%slug common-export-support %}) common article.

>You can find a runnable example in our [GitHub](https://github.com/telerik/document-processing-sdk) repository: [Export UI Element to PDF](https://github.com/telerik/document-processing-sdk/tree/master/PdfProcessing/ExportUIElement).

## Export RadChartView to Image

You can export the chart to an image using the __Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage()__ method.

The following code snippets demonstrate how to use the ExportToImage() method.

#### __XAML__
```XAML
	<telerik:RadCartesianChart x:Name="chart" />
```

#### __C#__
```C#
	string filename = "ExportedChart.png"; 
	using (Stream fileStream = File.Open(filename, FileMode.OpenOrCreate))
	{
		Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(this.chart, fileStream, new PngBitmapEncoder());
	}
```

>tip The ExportToImage() method expects that the UI element which will be exported is __measured and arranged__ - otherwise, an exception will be thrown.

## See Also
* [Overview]({%slug radchartview-overview %})
* [Getting Started]({%slug radchartview-introduction %})
* [SDK Examples]({%slug radchartview-sdk-examples %})
* [Export Support]({%slug common-export-support %})
* [Document Processing Libraries]({%slug document-processing-libraries-overview%})
