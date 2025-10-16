---
title: Allow Line Selection in RadChartView LineSeries
description: How to implement custom RadChartView LineSeries selection that happens on line click instead of data point click.
type: how-to
page_title: Enable Selection on Click Over the LineSeries of RadCartesianChart
slug: kb-chartview-line-series-selection
tags: radchartview, wpf, click,selection,series
res_type: kb
category: knowledge-base
---

## Environment

| Product         | Version    |
|-----------------|------------|
| RadChartView for WPF | 2024.1.423 |

## Description

The [built-in selection feature]({%slug radchartview-features-selection%}) of RadChartView allows you to select data points in the chart by clicking the corresponding data point visuals.

This article describes how to implement custom selection logic activated on clicking over the LineSeries' line. The selection will highlight the series with a different `Stroke` setting.

## Solution

The chart's LineSeries already has a selection infrastructure that can be used to mark the line as selected. To do that, set the `AllowSelect` and `IsSelected` properties of the series to `true`.

The selection state can be toggled in the `MouseLeftButtonDown` event of the chart.

The highlighting of the series can be implemented either in the mouse event handler or with a trigger (as shown in this example) or another WPF method. Basically, on mouse click, the `Stroke` property of the corresponding `LineSeries` should be updated.

The following example shows how to combine these suggestions.

__Defining the chart and setting up the highlighting__
```XAML
	<telerik:RadCartesianChart MouseLeftButtonDown="RadCartesianChart_MouseLeftButtonDown">
		<telerik:RadCartesianChart.Resources>
			<!-- in case the NoXaml dlls are used, add the following setting to the Style object -->
			<!-- BasedOn="{StaticResource LineSeriesStyle}" -->
			<Style TargetType="telerik:LineSeries">
				<Setter Property="AllowSelect" Value="True"/>
				<Setter Property="Cursor" Value="Hand" />
				<Setter Property="Stroke" Value="#95C74C" />
				<Setter Property="StrokeThickness" Value="3" />
				<Style.Triggers>
					<Trigger Property="IsSelected" Value="True">
						<Setter Property="Stroke" Value="#3c5c0d" />
					</Trigger>
				</Style.Triggers>
			</Style>
		</telerik:RadCartesianChart.Resources>
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis/>
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis />
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.Series>
			<telerik:LineSeries>
				<telerik:LineSeries.DataPoints>
					<telerik:CategoricalDataPoint Category="January" Value="2" />
					<telerik:CategoricalDataPoint Category="February" Value="5" />
					<telerik:CategoricalDataPoint Category="March" Value="3" />
					<telerik:CategoricalDataPoint Category="April" Value="10" />
					<telerik:CategoricalDataPoint Category="May" Value="9" />
					<telerik:CategoricalDataPoint Category="June" Value="7" />
					<telerik:CategoricalDataPoint Category="July" Value="1" />
				</telerik:LineSeries.DataPoints>
			</telerik:LineSeries>
			<telerik:LineSeries>
				<telerik:LineSeries.DataPoints>
					<telerik:CategoricalDataPoint Category="January" Value="4" />
					<telerik:CategoricalDataPoint Category="February" Value="4" />
					<telerik:CategoricalDataPoint Category="March" Value="4" />
					<telerik:CategoricalDataPoint Category="April" Value="2" />
					<telerik:CategoricalDataPoint Category="May" Value="5" />
					<telerik:CategoricalDataPoint Category="June" Value="5" />
					<telerik:CategoricalDataPoint Category="July" Value="8" />
				</telerik:LineSeries.DataPoints>
			</telerik:LineSeries>
		</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
```

__Implementing the MouseLeftButtonDown handler__
```C#
	private void RadCartesianChart_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		var chart = (RadCartesianChart)sender;
		var lineSeries = chart.Series.OfType<LineSeries>();

		if (lineSeries.Any(x => x.IsMouseOver))
		{
			foreach (var series in lineSeries)
			{
				series.IsSelected = series.IsMouseOver ? (series.IsSelected ^ true) : false;                    
			}
		}		
	}
```
