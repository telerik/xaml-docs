---
title: StepLineSeries
page_title: StepLineSeries
description: This article describes the StepLineSeries component from the RadChartView suite.
slug: radchartview-series-steplineseries
tags: steplineseries
published: True
position: 2
---

# StepLineSeries

This series is visualized on the screen as a horizontal and vertical line instead of straight line which connects all data points. This series changes its value with a step.

## Declaratively defined series

You can use the following definition to display a simple StepLineSeries

__Example 1: Declaring a StepLineSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-line-series-steplineseries-example_1_declaring_a_steplineseries_in_xaml-xaml' />


#### __Figure 1: StepLineSeries visual appearance__
![Telerik UI for WPF RadChartView StepLineSeries visual appearance](images/radchartview-series-steplineseries.png)

## Properties

* __CategoryBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the category value of the data point.
* __ValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the value of the data point.
* __DashArray__: A property of type __DoubleCollection__ that gets or sets the dash pattern applied to the line series itself.
* __Stroke__: A property of type __Brush__ that gets or sets the stroke of the line series.
* __StrokeShapeStyle__: A property of type __Style__ that gets or sets the style of the stroke of the line series. The property accepts a style that targets an object of type Path.
* __RisersPosition__: A property of type __StepSeriesRisersPosition__ that gets or sets the mode that determines where the risers of the step line series should be positioned. The risers position is an enumeration and it allows the following values:  
	* __Default__: The risers position depends on the plot mode of the axes.
	* __OnTicks__: The risers will be plotted over each tick.
	* __BetweenTicks__: The risers are plotted in the middle of the range, defined between each two ticks.

#### __Figure 2: BetweenTicks and OnTicks RisersPosition values based on Example 1__
![Telerik UI for WPF RadChartView StepLineSeries with BetweenTicks and OnTicks riser positions](images/radchartview-series-risersposition.png)

## Data Binding

You can use the ValueBinding and CategoryBinding properties of the StepLineSeries to bind the DataPoints’ properties to the properties from your view models.

__Example 2: Defining the view model__

<snippet id='radchartview-series-cartesianchart-series-line-series-steplineseries-example_2_defining_the_view_model-cs' />


__Example 3: Specify a StepLineSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-line-series-steplineseries-example_3_specify_a_steplineseries_in_xaml-xaml' />


>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.

## Styling the Series

You can see how to style the series using different properties in the [StepLineSeries section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the Customizing CartesianChart Series help article.

Additionally, you can use the Palette property of the chart to change the colors of the StepLineSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
