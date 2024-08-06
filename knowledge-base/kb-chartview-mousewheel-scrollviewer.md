---
title: How to Prevent Scrolling the Parent ScrollViewer When Using the Zoom Functionality of RadCartesianChart.
description: This article shows how you can prevent the parent ScrollViewer from scrolling when zooming in/out on/of RadCartesianChart.
page_title: Handle Scrolling of the Parent ScrollViewer When Zooming In and Out of the RadCartesianChart.
type: how-to
slug: kb-chartview-mousewheel-scrollviewer
position: 0
tags: wpf, chartview, cartesianchart, chart, scroll, mouse wheel, wheel, zoom, zooming
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2024.2.514</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadChartView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Prevent the parent `ScrollViewer` element from scrolling when using the zoom functionality of RadCartesianChart.

## Solution

Subscribe to the `MouseWheel` event of the `RadCartesianChart` instance. In the event handler, set the `e.Handled` property to __True__.

>important Do not handle the `PreviewMouseWheel` event as it will disable the zoom functionality of the control.

#### __[C#] Subscribing to the MouseWheel event and setting the e.Handled property to True__
{{region kb-chartview-mousewheel-scrollviewer-0}}
    private void RadCartesianChart_MouseWheel(object sender, MouseWheelEventArgs e)
    {
        e.Handled = true;
    }
{{endregion}}