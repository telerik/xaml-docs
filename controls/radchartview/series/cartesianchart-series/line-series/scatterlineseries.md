---
title: ScatterLineSeries
page_title: ScatterLineSeries
description: Check our &quot;ScatterLineSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-scatterlineseries
tags: scatterlineseries
published: True
position: 3
---

# ScatterLineSeries

This series is visualized on the screen as a straight line connecting all data points. As all scatter series, this one also requires the RadCartesianChart to define two LinearAxis as vertical and horizontal axis.
  
* [Declaratively Defined Series](#declaratively-defined-series)
* [Properties](#properties)
* [Data Binding](#data-binding)
* [Styling the Series](#styling-the-series)  

## Declaratively defined series

You can use the following definition to display a simple ScatterLineSeries

__Example 1: Declaring a ScatterLineSeries in XAML__
```XAML
	<telerik:RadCartesianChart Palette="Windows8">
	<telerik:RadCartesianChart.HorizontalAxis>
		<telerik:LinearAxis/>
	</telerik:RadCartesianChart.HorizontalAxis>
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis />
	</telerik:RadCartesianChart.VerticalAxis>
	<telerik:RadCartesianChart.Series>
		<telerik:ScatterLineSeries>
			<telerik:ScatterLineSeries.DataPoints>
				<telerik:ScatterDataPoint XValue="0" YValue="2" />
				<telerik:ScatterDataPoint XValue="1" YValue="5" />
				<telerik:ScatterDataPoint XValue="2" YValue="3" />
				<telerik:ScatterDataPoint XValue="3" YValue="10" />
				<telerik:ScatterDataPoint XValue="4" YValue="9" />
				<telerik:ScatterDataPoint XValue="5" YValue="7" />
				<telerik:ScatterDataPoint XValue="6" YValue="1" />
			</telerik:ScatterLineSeries.DataPoints>
		</telerik:ScatterLineSeries>
	</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
```

#### __Figure 1: ScatterLineSeries visual appearance__
![radchartview-series-scatterlineseries](images/radchartview-series-scatterlineseries.png)

## Properties

* __YValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the Y value of the data point.
* __XValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the X value of the data point.
* __DashArray__: A property of type __DoubleCollection__ that gets or sets the dash pattern applied to the scatter line series itself.
* __Stroke__: A property of type __Brush__ that gets or sets the stroke of the scatter line series.
* __StrokeShapeStyle__: A property of type __Style__ that gets or sets the style of the stroke of the scatter line series. The property accepts a style that targets an object of type Path.

## Data Binding

You can use the __YValueBinding__ and __XValueBinding__ properties of the ScatterLineSeries to bind the DataPoints’ properties to the properties from your view models.

__Example 2: Defining the view model__

```C#
	public class PlotInfo
    {
        public double XValue { get; set; }
        public double YValue { get; set; }
    }

	//.......
	this.DataContext = new ObservableCollection<PlotInfo>
	{
		new PlotInfo() { XValue = 0, YValue = 2},
		//....
	};
```		

__Example 3: Specify a ScatterLineSeries in XAML__
```XAML
	<telerik:ScatterLineSeries ItemsSource="{Binding}" YValueBinding="YValue" XValueBinding="XValue"/>
```	

>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.
	
## Styling the Series

You can see how to style the scatter line series using different properties in the [ScatterLineSeries section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the Customizing CartesianChart Series help article.

Additionally, you can use the Palette property of the chart to change the colors of the ScatterLineSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
