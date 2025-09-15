---
title: Get Clicked Data Point in RadChartView 
description: Click data point visual in RadCartesianChart BarSeries.
page_title: Execute action on mouse down on chart data point element 
type: how-to
slug: kb-chartview-howto-get-clicked-data-point
position: 0
tags: clicked, datapoint, chart
ticketid: 1470708
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.513</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadChartView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to get the clicked data point in RadCartesianChart.

## Solution

To get the clicked data point, you can use the MouseLeftButtonDown event of RadCartesianChart. In the event handler, get the mouse position and check if the LayoutSlot property of any [DataPoint]({%slug radchartview-getting-started-data-point%}) object contains the position. 

The following example shows this approach with BarSeries, but you can apply this with any series that has its default visual element shown.


```C#
	private void RadCartesianChart_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
	{
		var chart = (RadCartesianChart)sender;
		CategoricalDataPoint clickedDataPoint = null;
		var mousePosition = e.GetPosition(chart);
		foreach (BarSeries series in chart.Series)
		{
			foreach (var dp in series.DataPoints)
			{
				if (dp.LayoutSlot.Contains(mousePosition.X, mousePosition.Y))
				{
					clickedDataPoint = dp;
				}
			}
		}

		if (clickedDataPoint != null)
		{
			var clickedDataItem = clickedDataPoint.DataItem;
			var clickedDataPointSeries = (BarSeries)clickedDataPoint.Presenter;
			var clickedVisual = clickedDataPointSeries.GetDataPointVisual(clickedDataPoint);
		}        
	}
```
