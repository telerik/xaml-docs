---
title: How to Hide the Horizontal/Vertical Scrollbar of RadCartesianChart Axis
description: Hide the PanZoomBar (scrollbar) element of the RadChartView axis by changing its visibility.
type: how-to
page_title: How to Hide the PanZoomBar ScrollBar of RadChartView axis
slug: kb-chartview-hide-axis-scrollbar
position: 0
tags: style,setter,panzoombar,scrollviewer,visibility
ticketid: 1404933
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1 408</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadChartView for WPF</td>
	</tr>
</table>

## Description

How to hide the horizontal/vertical scrollbar (the PanZoomBar) of RadCartesianChart axis.

## Solution

Define a Style that targets the PanZoomBar control and set it to the `PanZoomBarStyle` property of the corresponding chart axis.


```XAML
	<telerik:RadCartesianChart.HorizontalAxis>
		<telerik:CategoricalAxis>
			<telerik:CategoricalAxis.PanZoomBarStyle>
				<Style TargetType="telerik:PanZoomBar">
					<Setter Property="Visibility" Value="Collapsed"/>
				</Style>
			</telerik:CategoricalAxis.PanZoomBarStyle>
		</telerik:CategoricalAxis>
	</telerik:RadCartesianChart.HorizontalAxis>
```

## See Also
* [Axis]({%slug radchartview-axes-axis%})
