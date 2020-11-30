---
title: Drag RadChartView Annotation
page_title: Move RadCartesianChart GridLineAnnotation with Mouse
description: Drag RadCartesianChart annotations, like line or area, using the mouse and Conversion API.
type: how-to
slug: kb-chartview-drag-annotation
position: 0
tags: chartview, annotation, sdk
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

How to drag chart [annotations]({%slug radchartview-annotations-getting-started%}).

## Solution

To drag annotations through the chart plot area, you can use the chart mouse events in combination with the [Conversion API]({%slug radchartview-features-conversion%}). The mouse event (MouseLeftButtonDown, MouseMove, etc.) will give information about the mouse position. Then, you can use the Conversion API to convert the mouse position to coordinates on the axes and use those values to the update the annotation.

You can find a runnable example showing this approach in the [DragChartAnnotation](https://github.com/telerik/xaml-sdk/tree/master/ChartView/WPF/DragChartAnnotation) SDK example.
