---
title: Restrict the First Axis Label to be Within the RadChartView Pane Width
description: "How to restrict the first axis label to be within the plot area width of CartesianChart element."
type: how-to
page_title: Avoid First Axis Label to be Rendered Outside of the Plot Area Clip of RadChartView.
slug: kb-chartview-clip-first-label-to-plotarea
position: 0
tags: axis, chart pane, label, cartesianchart
ticketid: 1620645
res_type: kb
---

## Environment

<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2023.2.718</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>RadChartView for WPF</td>
        </tr>
    </tbody>
</table>

## Description

How to clip the first axis label so that it is within the [plot area clip]({%slug radchartview-features-plot-area%}) of `RadCartesianChart`.

## Solution

Manually clip the horizontal axis based on the plot area of the chart. To do this, set the `Clip` property of the axis.


```C#
	private void RadCartesianChart_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		var chart = (RadCartesianChart)sender;
		RadRect plotArea = chart.PlotAreaClip;
		var clipGeometry = new RectangleGeometry(new Rect(plotArea.X + 	chart.PanOffset.X, plotArea.Bottom, plotArea.Width, 100));
		this.hAxis.Clip = clipGeometry;
	}
```

