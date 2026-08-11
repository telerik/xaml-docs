---
title: ScatterSplineSeries
page_title: ScatterSplineSeries
description: Check our &quot;ScatterSplineSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-scattersplineseries
tags: scattersplineseries
published: True
position: 4
---

# ScatterSplineSeries

This series is visualized on the screen as a smooth line connecting all data points. As all scatter series, this one also requires the RadCartesianChart to define two LinearAxis as vertical and horizontal axis.
      
* [Declaratively Defined Series](#declaratively-defined-series)
* [Properties](#properties)
* [Data Binding](#data-binding)
* [Styling the Series](#styling-the-series)
	  
## Declaratively defined series

You can use the following definition to display a simple ScatterSplineSeries

__Example 1: Declaring a ScatterSplineSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-line-series-scattersplineseries-example_1_declaring_a_scattersplineseries_in_xaml-xaml' />


#### __Figure 1: ScatterSplineSeries visual appearance__
![Telerik UI for WPF RadChartView ScatterSplineSeries visual appearance](images/radchartview-series-scattersplineseries.png)

## Properties

* __YValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the Y value of the data point.
* __XValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the X value of the data point.
* __DashArray__: A property of type __DoubleCollection__ that gets or sets the dash pattern applied to the scatter spline series itself.
* __Stroke__: A property of type __Brush__ that gets or sets the stroke of the scatter spline series.
* __StrokeShapeStyle__: A property of type __Style__ that gets or sets the style of the stroke of the scatter spline series. The property accepts a style that targets an object of type Path.

## Data Binding

You can use the __YValueBinding__ and __XValueBinding__ properties of the ScatterSplineSeries to bind the DataPoints’ properties to the properties from your view models.

__Example 2: Defining the view model__

<snippet id='radchartview-series-cartesianchart-series-line-series-scattersplineseries-example_2_defining_the_view_model-cs' />


__Example 3: Specify a ScatterSplineSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-line-series-scattersplineseries-example_3_specify_a_scattersplineseries_in_xaml-xaml' />


## Spline Tension

The spline-type series provide two properties allowing to control the additional points calculated for the spline of the line. The tension is controlled via the `SplineTension` property. The tension works with relative values between 0 and 1. The defualt tension is set to `0.5d`.

__Example 4: Setting SplineTension__
<snippet id='radchartview-series-cartesianchart-series-line-series-scattersplineseries-example_4_setting_splinetension-xaml' />


__Spline tension 0.8 (left) and 0.4 (right)__

![Telerik UI for WPF RadChartView ScatterSplineSeries with Spline Tension 0.8 on the Left and 0.4 on the Right](images/splineseries-spline-tension.png)

Additionally, you can control the smoothness of the spline using the `SplinePointsDistanceFactor` property. The property controls the distance between the additionally calcuated spline points. The bigger the factor is the less points will be created, thus the line will become less smooth. The property works with values between 0 and 0.35. The default value is `0.03d`.

__Example 5: Setting SplinePointsDistanceFactor__
<snippet id='radchartview-series-cartesianchart-series-line-series-scattersplineseries-example_5_setting_splinepointsdistancefactor-xaml' />


__SplinePointsDistanceFactor set to 0.18__

![Telerik UI for WPF RadChartView ScatterSplineSeries with SplinePointsDistanceFactor Set to 0.18](images/splineseries-spline-points-distance-factor.png)

## Styling the Series

You can see how to style the scatter spline series using different properties in the [ScatterSplineSeries section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the Customizing CartesianChart Series help article.

Additionally, you can use the Palette property of the chart to change the colors of the ScatterSplineSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
