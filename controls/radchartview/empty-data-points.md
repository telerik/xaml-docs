---
title: Empty Data Points
page_title: Empty Data Points
description: This article describes how to add empty data points to the chart and display gaps in the data.
slug: radchartview-empty-data-points
tags: radchartview, chartview, empty, data, points, gap
published: True
position: 5
---

# Empty Data Points

The `RadCartesianChart` control allows you to show gaps in the data without removing the associated data item. This is done by setting the value property of the corresponding [data point]({%slug radchartview-getting-started-data-point%}) to `null`. This is useful in different scenarios, like adding gaps in the line visualization or an empty bar for a specific category.

#### __[XAML] Adding an empty data point in LineSeries__
{{region radchartview-empty-data-points-0}}
	<telerik:RadCartesianChart>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis />
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis PlotMode="OnTicksPadded" />
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:LineSeries>
			<telerik:LineSeries.DefaultVisualStyle>
				<Style TargetType="Path">
					<Setter Property="Width" Value="8"/>
					<Setter Property="Height" Value="8"/>
					<Setter Property="Fill" Value="#27C106"/>
				</Style>
			</telerik:LineSeries.DefaultVisualStyle>
			<telerik:LineSeries.DataPoints>
				<telerik:CategoricalDataPoint Category="C1" Value="10" />
				<telerik:CategoricalDataPoint Category="C2" Value="5" />
				<telerik:CategoricalDataPoint Category="C3" Value="8" />
				<telerik:CategoricalDataPoint Category="C4" Value="{x:Null}" />
				<telerik:CategoricalDataPoint Category="C5" Value="10" />
				<telerik:CategoricalDataPoint Category="C6" Value="4" />
				<telerik:CategoricalDataPoint Category="C7" Value="10" />
				<telerik:CategoricalDataPoint Category="C8" Value="3" />
				<telerik:CategoricalDataPoint Category="C9" Value="8" />
				<telerik:CategoricalDataPoint Category="C10" Value="2" />
			</telerik:LineSeries.DataPoints>
		</telerik:LineSeries>
	</telerik:RadCartesianChart>
{{endregion}}

![Picture showing gaps in the chart created with an empty data point](images/radchartview-empty-data-points-0.png)

The following example shows how to assign the value of the data point in code.

#### __[C#] Creating an empty data point in code__
{{region radchartview-empty-data-points-1}}
	this.lineSeries.DataPoints.Add(new CategoricalDataPoint() { Category = "C4", Value = null };
	
	this.scatterLineSeries.DataPoints.Add(new ScatterDataPoint() { XValue = 4, YValue = null };
{{endregion}}

## Data Binding Setup

When the chart series is data-bound via its ItemsSource property, the assignment of the null value is implemented in the data point models.

#### __[C#] Defining the data point model__
{{region radchartview-empty-data-points-2}}
	public class PlotInfo
	{
		public string Category { get; set; }
		public double? Value { get; set; }
	}
{{endregion}}

#### __[C#] Populating with data__
{{region radchartview-empty-data-points-3}}
	var dataItems = new ObservableCollection<PlotInfo>();
	// add other data points here
	dataItems.Add(new PlotInfo() { Category = "Category 4", Value = null };
	// add other data points here
{{endregion}}

#### __[XAML] Setting up chart series in data binding scenario__
{{region radchartview-empty-data-points-4}}
	<telerik:LineSeries CategoryBinding="Category" ValueBinding="Value" ItemsSource="{Binding MyDataItems}" />
{{endregion}}
