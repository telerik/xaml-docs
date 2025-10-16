---
title: How to export the RadChartView without the pan and zoom scrollbars
description: Create an image of the chart without scrollbars.
page_title: Remove scrollbars when exporting RadCartesianChart
type: how-to
slug: kb-chartview-howto-export-without-panzoom-scrollbars
position: 0
tags: export, chart, remove, scrollbar, cartesianchart
ticketid: 1459771
res_type: kb
---

## Environment
<table>
    <tr>
        <td>Product</td>
        <td>RadChartView for WPF</td>
    </tr>
</table>

## Description

How to remove the pan and zoom scrollbars when exporting the RadChartView.  

## Solution

Set the __PanMode__ and __ZoomMode__ properties of the ChartPanAndZoomBehavior to __None__ and make sure the chart is redrawn. 

__Example 1: Exporting the chart without scrollbars__
```C#

	var zoomModeCache = this.panZoomBehavior.ZoomMode;
	var panModeCache = this.panZoomBehavior.PanMode;
	this.panZoomBehavior.ZoomMode = ChartPanZoomMode.None;
	this.panZoomBehavior.PanMode = ChartPanZoomMode.None;

    // This forces the chart to be redrawn
	var size = this.chart.RenderSize;
	this.chart.Measure(Size.Empty);
	this.chart.Measure(size);
	this.chart.Arrange(new Rect(size));
	this.chart.UpdateLayout();

	string filename = "../../ExportedChart.png";
	using (Stream fileStream = File.Open(filename, FileMode.OpenOrCreate))
	{
		Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(this.chart, fileStream, new PngBitmapEncoder());
	}

	this.panZoomBehavior.ZoomMode = zoomModeCache;
	this.panZoomBehavior.PanMode = panModeCache;
```

## See Also

* [Scroll and Zoom]({%slug radchartview-features-panzoom%})
* [Export Support]({%slug common-export-support%})
