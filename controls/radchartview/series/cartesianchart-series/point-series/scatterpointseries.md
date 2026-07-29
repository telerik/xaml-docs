---
title: ScatterPointSeries
page_title: ScatterPointSeries
description: Check our &quot;ScatterPointSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-scatterpointseries
tags: scatterpointseries
published: True
position: 1
---

# ScatterPointSeries

This series is visualized on the screen as separate points representing each of the data points. As all scatter series, this one also requires the RadCartesianChart to define two LinearAxis as a vertical and horizontal axis.

* [Declaratively Defined Series](#declaratively-defined-series)
* [Properties](#properties)
* [Data Binding](#data-binding)
* [Styling the Series](#styling-the-series)

## Declaratively defined series

You can use the following definition to display a simple ScatterPointSeries

__Example 1: Declaring an ScatterPointSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-point-series-scatterpointseries-example_1_declaring_an_scatterpointseries_in_xaml-xaml' />


#### __Figure 1: ScatterPointSeries visual appearance__
![radchartview-series-scatterpointseries](images/radchartview-series-scatterpointseries.png)

## Properties
* __CategoryBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the category value of the data point.
* __ValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the value of the data point.
* __PointSize__: A property of type __Size__ that get or sets the size of the points. This property will be ignored if __PointTemplate__ property is set. 

## Data Binding

You can use the __YValueBinding__ and __XValueBinding__ properties of the ScatterPointSeries to bind the DataPoints’ properties to the properties from your view models.

__Example 2: Defining the view model__

<snippet id='radchartview-series-cartesianchart-series-point-series-scatterpointseries-example_2_defining_the_view_model-cs' />


__Example 3: Specify a ScatterPointSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-point-series-scatterpointseries-example_3_specify_a_scatterpointseries_in_xaml-xaml' />


>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.

## Styling the Series

You can see how to style the series using different properties in the [ScatterPointSeries section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the Customizing CartesianChart Series help article.

Additionally, you can use the Palette property of the chart to change the colors of the ScatterPointSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Line Series Overview]({%slug radchartview-series-lineseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
