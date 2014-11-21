---
title: ScatterAreaSeries
page_title: ScatterAreaSeries
description: ScatterAreaSeries
slug: radchartview-series-scatterareaseries
tags: scatterareaseries
published: True
position: 3
---

# ScatterAreaSeries

The ScatterAreaSeries behave like the ScatterLineSeries but it also allows the area between the line and the axis to be colored in an arbitrary way. By default the colors of the line and the area are the same. As all scatter series, this one also requires the RadCartesianChart to define two LinearAxis.

## Declaratively defined series

You can use the following definition to display a simple ScatterAreaSeries:

#### XAML
{{region radchartview-scatterseries}}	
	<telerik:RadCartesianChart Palette="Windows8">
	<telerik:RadCartesianChart.HorizontalAxis>
		<telerik:LinearAxis />
	</telerik:RadCartesianChart.HorizontalAxis>
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis />
	</telerik:RadCartesianChart.VerticalAxis>
	<telerik:RadCartesianChart.Series>
		<telerik:ScatterAreaSeries>
			<telerik:ScatterAreaSeries.DataPoints>
				<telerik:ScatterDataPoint XValue="0" YValue="2" />
				<telerik:ScatterDataPoint XValue="1" YValue="5" />
				<telerik:ScatterDataPoint XValue="2" YValue="3" />
				<telerik:ScatterDataPoint XValue="3" YValue="10" />
				<telerik:ScatterDataPoint XValue="4" YValue="9" />
				<telerik:ScatterDataPoint XValue="5" YValue="7" />
				<telerik:ScatterDataPoint XValue="6" YValue="1" />
			</telerik:ScatterAreaSeries.DataPoints>
		</telerik:ScatterAreaSeries>
	</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}

![radchartview-series-scatterlineareaseries](images/radchartview-series-scatterlineareaseries.png)

# See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})