---
title: LineSeries
page_title: LineSeries
description: Check our &quot;LineSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-lineseries
tags: lineseries
published: True
position: 0
---

# LineSeries

This series is visualized on the screen as a straight line connecting all data points.

* [Declaratively Defined Series](#declaratively-defined-series)
* [Properties](#properties)
* [Data Binding](#data-binding)
* [Styling the Series](#styling-the-series)

## Declaratively defined series

You can use the following definition to display a simple LineSeries

__Example 1: Declaring a LineSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-line-series-lineseries-example_1_declaring_a_lineseries_in_xaml-xaml' />


#### __Figure 1: LineSeries visual appearance__
![radchartview-series-lineseries](images/radchartview-series-lineseries.png)

## Properties

* __CategoryBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the category value of the data point.
* __ValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the value of the data point.
* __DashArray__: A property of type [DoubleCollection](https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.doublecollection?view=netframework-4.8) that gets or sets the dash pattern applied to the line series itself.
* __Stroke__: A property of type __Brush__ that gets or sets the stroke of the line series.
* __StrokeShapeStyle__: A property of type __Style__ that gets or sets the style of the stroke of the line series. The property accepts a style that targets an object of type Path.

## Data Binding

You can use the ValueBinding and CategoryBinding properties of the LineSeries to bind the DataPoints’ properties to the properties from your view models.

__Example 2: Defining the view model__

<snippet id='radchartview-series-cartesianchart-series-line-series-lineseries-example_2_defining_the_view_model-cs' />


__Example 3: Specify a LineSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-line-series-lineseries-example_3_specify_a_lineseries_in_xaml-xaml' />


>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.

## Styling the Series

You can see how to style the line series using different properties, in the [LineSeries section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the Customizing CartesianChart Series help article.

Additionally, you can use the Palette property of the chart to change the colors of the LineSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
