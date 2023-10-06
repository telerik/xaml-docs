---
title: Restrict the First Axis Label to be Within the RadChartView Pane Width
description: "How to restrict the first axis label to be within the Chart plot area width of CartesianChart element."
type: how-to
page_title: Avoid first axis label to be rendered outside of the plot area clip.
slug: kb-restrictfirstaxis-to-chartpanewidth
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

How to restrict the first axis label to be within the [plot area]({%slug radchartview-features-plot-area%}) width of `RadCartesianChart` element.

## Solution

Manually clip the horizontal axis based on the plot area of the chart. To do this, set the `Clip` property of the axis.

#### __[C#]__
{{region kb-icontemplate-remove-indenting}}
	private void RadCartesianChart_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		var chart = (RadCartesianChart)sender;
		RadRect plotArea = chart.PlotAreaClip;
		var clipGeometry = new RectangleGeometry(new Rect(plotArea.X + 	chart.PanOffset.X, plotArea.Bottom, plotArea.Width, 100));
		this.hAxis.Clip = clipGeometry;
	}
{{endregion}}

