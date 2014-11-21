---
title: BarSeries
page_title: BarSeries
description: BarSeries
slug: radchartview-series-barseries
tags: barseries
published: True
position: 0
---

# BarSeries

This series is visualized on the screen as separate rectangles representing each of the __DataPoints__.      

## Declaratively defined series

You can use the following definition to display a simple BarSeries

#### XAML
{{region radchartview-barseries}}
	<telerik:RadCartesianChart Palette="Windows8">
	<telerik:RadCartesianChart.HorizontalAxis>
		<telerik:CategoricalAxis/>
	</telerik:RadCartesianChart.HorizontalAxis>
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis />
	</telerik:RadCartesianChart.VerticalAxis>
	<telerik:RadCartesianChart.Series>
		<telerik:BarSeries>
			<telerik:BarSeries.DataPoints>
				<telerik:CategoricalDataPoint Category="January" Value="2" />
				<telerik:CategoricalDataPoint Category="February" Value="5" />
				<telerik:CategoricalDataPoint Category="March" Value="3" />
				<telerik:CategoricalDataPoint Category="April" Value="10" />
				<telerik:CategoricalDataPoint Category="May" Value="9" />
				<telerik:CategoricalDataPoint Category="June" Value="7" />
				<telerik:CategoricalDataPoint Category="July" Value="1" />
			</telerik:BarSeries.DataPoints>
		</telerik:BarSeries>
	</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}
![radchartview-series-barseries](images/radchartview-series-barseries.png)

# See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})