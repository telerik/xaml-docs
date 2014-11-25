---
title: StepAreaSeries
page_title: StepAreaSeries
description: StepAreaSeries
slug: radchartview-series-stepareaseries
tags: stepareaseries
published: True
position: 2
---

# StepAreaSeries

The StepAreaSeries behave like the StepLineSeries but it also allows the area between the line and the axis to be colored in an arbitrary way. By default the colors of the line and the area are the same.

## Declaratively defined series

You can use the following definition to display a simple StepAreaSeries:

#### XAML
{{region radchartview-stepareaseries}}
	<telerik:RadCartesianChart Palette="Windows8">
	<telerik:RadCartesianChart.HorizontalAxis>
		<telerik:CategoricalAxis/>
	</telerik:RadCartesianChart.HorizontalAxis>
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis />
	</telerik:RadCartesianChart.VerticalAxis>
	<telerik:RadCartesianChart.Series>
		<telerik:StepAreaSeries>
			<telerik:StepAreaSeries.DataPoints>
				<telerik:CategoricalDataPoint Category="January" Value="2" />
				<telerik:CategoricalDataPoint Category="February" Value="5" />
				<telerik:CategoricalDataPoint Category="March" Value="3" />
				<telerik:CategoricalDataPoint Category="April" Value="10" />
				<telerik:CategoricalDataPoint Category="May" Value="9" />
				<telerik:CategoricalDataPoint Category="June" Value="7" />
				<telerik:CategoricalDataPoint Category="July" Value="1" />
			</telerik:StepAreaSeries.DataPoints>
		</telerik:StepAreaSeries>
	</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}
![radchartview-series-steplineareaseries](images/radchartview-series-steplineareaseries.png)

# See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})