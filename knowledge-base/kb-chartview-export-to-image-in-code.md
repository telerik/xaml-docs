---
title: Export RadChartView with SeriesProvider in Code
page_title: Save RadCartesianChart to Image Without Adding it to View
description: How to export RadChartView with series provider to picture without adding it to the visual tree.
type: how-to
slug: kb-chartview-export-to-image-in-code
position: 
tags: 
ticketid: 1417033
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.618</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadChartView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to export RadChartView with a dynamic number of series (SeriesProvider) to a picture without adding it to the visual tree.

## Solution

Set the Width and Height of the chart and then manually measure and arrange it. If the chart is hosted in a UserControl you will need to measure and arrange it as well.

Then use the __ExportExtensions.ExportToImage__ method to export the chart.


```C#
	private void ExportChartToImage()
	{
		var chartUserControl = new ChartUserControl(); // this UserControl is the view where the RadCartesianChart control is defined.
		PrepareElementForExport(chartUserControl);
		
		using (Stream fileStream = File.Open("../../myChartPicture.png", FileMode.OpenOrCreate))
		{
			Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(chartUserControl, fileStream, new PngBitmapEncoder());
		}

	}

	private static void PrepareElementForExport(ChartControl userControl)
	{
		var measureSize = new Size(500, 500);
		userControl.Measure(measureSize);
		userControl.Arrange(new Rect(measureSize));
		userControl.UpdateLayout();
	 
		var chart = userControl.ChildrenOfType<RadCartesianChart>().FirstOrDefault();
		if (chart != null)
		{
			chart.Width = chart.RenderSize.Width;
			chart.Height = chart.RenderSize.Height;
			chart.OnApplyTemplate();
			chart.UpdateLayout();
		}
	}
```