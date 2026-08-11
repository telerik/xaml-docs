---
title: BarSeries3D
page_title: BarSeries3D
description: Check our &quot;BarSeries3D&quot; documentation article for the RadChartView3D {{ site.framework_name }} control.
slug: radchartview3d-barseries3d
tags: axes, 3d, chartview, barseries, column, columnseries
published: True
position: 0
---

# BarSeries3D

The bar series visualizes three dimensional data represented by 3D bars. Each data point defines a bar that is constructed by X, Z and Y values determining its position in the plot area. 

* [Declaratively defined series](#declaratively-defined-series)
* [Data bound series](#data-bound-series)
* [Display direction](#display-direction)
* [Customizing the data point visuals](#customizing-the-data-point-visuals)

## Declaratively defined series

You can use the code from __Example 1__ to create a __BarSeries3D__. 

__Example 1: Defining series in XAML__	
<snippet id='radchartview3d-series-barseries3d-example_1_defining_series_in_xaml-xaml' />

	
#### __Figure 1: BarSeries3D__
![{{ site.framework_name }} RadChartView3D BarSeries3D](images/radchartview-3d-barseries3d-0.png)

## Data bound series

You can use the __XValueBinding__, __YValueBinding__ and __ZValueBinding__ properties of __BarSeries3D__ to bind the __XyzDataPoints__’ properties to the properties of the view models. The __ItemsSource__ property is used to pass the data collection to the series.

__Example 2: Defining a model for the data points and setting up the data context__
<snippet id='radchartview3d-series-barseries3d-example_2_defining_a_model_for_the_data_points_and_setting_up_the_data_context-cs' />


__Example 3: Setting up the series__
<snippet id='radchartview3d-series-barseries3d-example_3_setting_up_the_series-xaml' />

	
## Display direction

The display direction of the series specifies which axis determines the start (origin) and end of the bars. The bar is drawn from the origin value to the value of the bar on the corresponding axis (the display direction). The direction is defined via the __DisplayDirection__ property which is of type __Axis3DType?__ and it accepts the following values – __X__, __Y__ and __Z__. The default display direction of BarSeries3D is __Z__.

You can use the __OriginValue__ property to define the origin of the bars on the corresponding axis determined by the __DisplayDirection__ property. The default origin value is __0__.

__Example 4: Setting the origin value__
<snippet id='radchartview3d-series-barseries3d-example_4_setting_the_origin_value-xaml' />


__Figure 2__ demonstrates the result from __Example 1__ but with its OriginValue set to 15.
	
#### __Figure 2: Origin value__
![{{ site.framework_name }} RadChartView3D Origin value](images/radchartview-3d-barseries3d-1.png)

## Customizing the data point visuals

The visual elements that present the __BarSeries3D__ data points can be customized through the __DefaultVisualMaterial__ and __DefaultVisualGeometry__ properties of the series. Additionally, you can use the __DefaultVisualMaterialSelector__ and __DefaultVisualGeometrySelector__ to choose different materials and geometries based on a specific condition.
 
>For more information, see the [Customizing Cartesian Chart 3D Series]({%slug radchartview3d-customizing-cartesian-series%}) help article.

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [Axes]({%slug radchartview3d-axes%})
* [PointSeries3D]({%slug radchartview3d-pointseries3d%})
* [SurfaceSeries3D]({%slug radchartview3d-surfaceseries3d%})
* [Customizing 3D Series]({%slug radchartview3d-customizing-cartesian-series%})
