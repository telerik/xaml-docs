---
title: PointSeries
page_title: PointSeries
description: PointSeries
slug: radchartview-series-point
tags: pointseries
published: True
position: 0
---

# PointSeries

This series is visualized on the screen as separate points representing each of the __DataPoints__.      

## Declaratively defined series

You can use the following definition to display a simple PointSeries
#### XAML
{{region radchartview-pointseries}}
	<telerik:RadCartesianChart Palette="Windows8">
	<telerik:RadCartesianChart.HorizontalAxis>
		<telerik:CategoricalAxis/>
	</telerik:RadCartesianChart.HorizontalAxis>
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis />
	</telerik:RadCartesianChart.VerticalAxis>
	<telerik:RadCartesianChart.Series>
		<telerik:PointSeries>
			<telerik:PointSeries.DataPoints>
				<telerik:CategoricalDataPoint Category="January" Value="2" />
				<telerik:CategoricalDataPoint Category="February" Value="5" />
				<telerik:CategoricalDataPoint Category="March" Value="3" />
				<telerik:CategoricalDataPoint Category="April" Value="10" />
				<telerik:CategoricalDataPoint Category="May" Value="9" />
				<telerik:CategoricalDataPoint Category="June" Value="7" />
				<telerik:CategoricalDataPoint Category="July" Value="1" />
			</telerik:PointSeries.DataPoints>
		</telerik:PointSeries>
	</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}
![radchartview-series-pointseries](images/radchartview-series-pointseries.png)

# See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})