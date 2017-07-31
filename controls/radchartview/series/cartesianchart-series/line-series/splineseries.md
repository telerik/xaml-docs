---
title: SplineSeries
page_title: SplineSeries
description: SplineSeries
slug: radchartview-series-splineseries
tags: splineseries
published: True
position: 1
---

# SplineSeries

This series is visualized on the screen as a smooth line connecting all data points.        

* [Declaratively Defined Series](#declaratively-defined-series)
* [Properties](#properties)
* [Data Binding](#data-binding)
* [Styling the Series](#styling-the-series)

## Declaratively defined series

You can use the following definition to display a simple SplineSeries

#### __[XAML] Example 1: Declaring a SplineSeries in XAML__
{{region radchartview-series-splineseries_0}}
	<telerik:RadCartesianChart Palette="Windows8">
	<telerik:RadCartesianChart.HorizontalAxis>
		<telerik:CategoricalAxis/>
	</telerik:RadCartesianChart.HorizontalAxis>
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis />
	</telerik:RadCartesianChart.VerticalAxis>
	<telerik:RadCartesianChart.Series>
		<telerik:SplineSeries>
			<telerik:SplineSeries.DataPoints>
				<telerik:CategoricalDataPoint Category="January" Value="2" />
				<telerik:CategoricalDataPoint Category="February" Value="5" />
				<telerik:CategoricalDataPoint Category="March" Value="3" />
				<telerik:CategoricalDataPoint Category="April" Value="10" />
				<telerik:CategoricalDataPoint Category="May" Value="9" />
				<telerik:CategoricalDataPoint Category="June" Value="7" />
				<telerik:CategoricalDataPoint Category="July" Value="1" />
			</telerik:SplineSeries.DataPoints>
		</telerik:SplineSeries>
	</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}

#### __Figure 1: SplineSeries visual appearance__
![radchartview-series-splineseries](images/radchartview-series-splineseries.png)

## Properties

* __CategoryBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the category value of the data point.
* __ValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the value of the data point.
* __DashArray__: A property of type __DoubleCollection__ that gets or sets the dash pattern applied to the spline series itself.
* __Stroke__: A property of type __Brush__ that gets or sets the stroke of the spline series.
* __StrokeShapeStyle__: A property of type __Style__ that gets or sets the style of the stroke of the spline series. The property accepts a style that targets an object of type Path.

## Data Binding

You can use the ValueBinding and CategoryBinding properties of the LineSeries to bind the DataPoints’ properties to the properties from your view models.

#### __[C#] Example 2: Defining the view model__

{{region radchartview-series-splineseries_1}}
	public class PlotInfo
    {
        public string Category { get; set; }
        public double Value { get; set; }
    }

	//.......
	this.DataContext = new ObservableCollection<PlotInfo>
	{
		new PlotInfo() { Category = "January", Value = 2},
		//....
	};
{{endregion}}	

#### __[XAML] Example 3: Specify a SplineSeries in XAML__
{{region radchartview-series-splineseries_2}}	
	<telerik:SplineSeries ItemsSource="{Binding}" CategoryBinding="Category" ValueBinding="Value" />
{{endregion}}

>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.


## Styling the Series

You can see how to style area series using different properties in the [SplineSeries section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the Customizing CartesianChart Series help article.

Additionally, you can use the Palette property of the chart to change the colors of the SplineSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})