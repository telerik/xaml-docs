---
title: SurfaceSeries3D
page_title: SurfaceSeries3D
description: This article describes the SurfaceSeries3D of RadChartView3D.
slug: radchartview3d-surfaceseries3d
tags: axes, 3d, chartview, surface, surfaceseries3d
published: True
position: 2
---

# SurfaceSeries3D

__SurfaceSeries3D__ visualizes three-dimensional data represented by a surface. Each data point is defined by X, Z and Y values which determines its position in the plot area.

>tip The algorithm that connects the SurfaceSeries3D points into a surface expects that the X and Y values of the plotted data will form a grid-like layout. Otherwise, there may be points that are not connected. If your data requires a different setup you can implement custom logic that connects the points and creates triangles as shown in the [Customizing surface triangulation](#customizing-surface-triangulation) section of this article.

## Declaratively defined series

You can use the code from __Example 1__ to create a __SurfaceSeries3D__. 

__Example 1: Defining series in XAML__	
<snippet id='radchartview3d-series-surfaceseries3d-example_1_defining_series_in_xaml-xaml' />

	
#### __Figure 1: SurfaceSeries3D__
![{{ site.framework_name }} RadChartView3D SurfaceSeries3D](images/radchartview-3d-surfaceseries3d-0.png)

## Data bound series

You can use the __XValueBinding__, __YValueBinding__ and __ZValueBinding__ properties of __SurfaceSeries3D__ to bind the __SurfaceDataPoint3D__ properties to the properties of the view models. The __ItemsSource__ property is used to pass the data collection to the series.

__Example 2: Defining a model for the data points and setting up the data context__
<snippet id='radchartview3d-series-surfaceseries3d-example_2_defining_a_model_for_the_data_points_and_setting_up_the_data_context-cs' />


__Example 3: Setting up the series__
<snippet id='radchartview3d-series-surfaceseries3d-example_3_setting_up_the_series-xaml' />


## Colorizers
	
The __SurfaceSeries3D__ colorizer determines the color appearance of the surface. The series supports two colorizers - __SurfaceSeries3DValueGradientColorizer__ and __SurfaceSeries3DValueGradientColorizer__.

* __SurfaceSeries3DValueGradientColorizer__

	This colorizer uses a collection of __GradientStop__ objects and creates a gradient texture based on the gradient stops colors and offsets. The texture is applied on the surface.

	The colorizer works with relative offsets (between 0 and 1) by default. You can change this and work with absolute offsets by setting the __IsAbsolute__ property to __True__. 

	__Example 4: Setting the IsAbsolute property__  
	<snippet id='radchartview3d-series-surfaceseries3d-example_4_setting_the_isabsolute_property-xaml' />

	
	The gradient stops are stored in the __GradientStops__ collection.

	__Example 5: Setting the gradient stops__  
	<snippet id='radchartview3d-series-surfaceseries3d-example_5_setting_the_gradient_stops-xaml' />

		
	#### __Figure 2: SurfaceSeries3DValueGradientColorizer__	![{{ site.framework_name }} RadChartView3D SurfaceSeries3DValueGradientColorizer](images/radchartview-3d-surfaceseries3d-1.png)

* __SurfaceSeries3DDataPointColorizer__

	This colorizer uses colors obtained from the plotted data points and based on them creates a gradient texture which is applied on the surface. By default the __SurfaceSeries3DDataPointColorizer__ works only in a data binding scenario. The colorizer requires each data point to define a color in its model. You can bind the color from the point's model to the colorizer via the __ColorBinding__ property. The property expects a path to a property of type __Color__ in the model of the data point.  
	
	The color of a point will be blend with the colors of its neighbour points, thus forming a gradient texture applied to the part of the surface that is formed between the points.

	__Examples 6, 7 and 8__ demonstrate how to use the colorizer in a data binding scenario.

	__Example 6: Setting up the view__
	<snippet id='radchartview3d-series-surfaceseries3d-example_6_setting_up_the_view-xaml' />


	__Example 7: Defining the view model of the data points__  
	<snippet id='radchartview3d-series-surfaceseries3d-example_7_defining_the_view_model_of_the_data_points-cs' />

		
	__Example 8: Setting up the DataContext__  
	<snippet id='radchartview3d-series-surfaceseries3d-example_8_setting_up_the_datacontext-cs' />

		
	#### __Figure 3: SurfaceSeries3DDataPointColorizer with default blending colorization mode__  	![{{ site.framework_name }} RadChartView3D SurfaceSeries3DDataPointColorizer with default blending colorization mode](images/radchartview-3d-surfaceseries3d-2.png)
	
	The __SurfaceSeries3DDataPointColorizer__ supports two colorization modes which determine the appearance of the surface. You can change the mode via the __ColorizationMode__ property of the colorizer. This property accepts the following values:
	
	* __Blend__: The surface is divided into triangles determined by the original data points centers. The pixels in each triangle are color blends between the three colors determined by the data points (see __Figure 3__). This is the default colorization mode.
	* __Tiles__: Each data point is presented by a tile with a solid color (see __Figure 4__).
	
	__Example 9: Setting colorization mode__  
	<snippet id='radchartview3d-series-surfaceseries3d-example_9_setting_colorization_mode-xaml' />

	
	#### __Figure 4: SurfaceSeries3DDataPointColorizer with ColorizationMode set to Tiles__  	![{{ site.framework_name }} RadChartView3D SurfaceSeries3DDataPointColorizer with ColorizationMode set to Tiles](images/radchartview-3d-surfaceseries3d-3.png)
	
## Display direction

The display direction specifies how the 3D points are connected, thus how the surface is displayed. The points are connected in a way to respect their 2D position on the plane which is perpendicular to the display direction. For example, if the display direction is the Z axis, then the points are connected so that their 2D position in the XY plane is respected.

__Example 10: Setting display direction__  
<snippet id='radchartview3d-series-surfaceseries3d-example_10_setting_display_direction-xaml' />

	
## Customizing surface triangulation	

__SurfaceSeries3D__ allows you define a custom collection of triangle indices used to create the triangles which form the surface. The indices collection will be set to the __MeshGeometry3D__ object that presents the surface. To pass the custom triangulation you can use the __TriangleIndices__ collection of __SurfaceSeries3D__. When the collection is null, the chart calculates the triangle indices automatically.

__Example 11: Setting display direction__  
<snippet id='radchartview3d-series-surfaceseries3d-example_11_setting_display_direction-cs' />


## Customizing the data point visuals

By default the data points of the series are not visible and only the surface can be seen. You can display the data point visuals by setting the __PointSize__ property. 

__Example 12: Setting point size in XAML__  
<snippet id='radchartview3d-series-surfaceseries3d-example_12_setting_point_size_in_xaml-xaml' />


__Example 13: Setting point size in code__  
<snippet id='radchartview3d-series-surfaceseries3d-example_13_setting_point_size_in_code-cs' />


#### __Figure 5: SurfaceSeries3D default point visuals__  
![{{ site.framework_name }} RadChartView3D SurfaceSeries3D default point visuals](images/radchartview-3d-surfaceseries3d-4.png)
	
To customize the geometry and the material of the visual elements that represent the __SurfaceSeries3D__ data points you can use the __DefaultVisualMaterial__ and __DefaultVisualGeometry__ properties of the series. Additionally, you can use the __DefaultVisualMaterialSelector__ and __DefaultVisualGeometrySelector__ to choose different materials and geometries based on a specific condition.
 
>For more information, see the [Customizing Cartesian Chart 3D Series]({%slug radchartview3d-customizing-cartesian-series%}) help article.

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [Axes]({%slug radchartview3d-axes%})
* [PointSeries3D]({%slug radchartview3d-pointseries3d%})
* [BarSeries3D]({%slug radchartview3d-barseries3d%})
* [Customizing 3D Series]({%slug radchartview3d-customizing-cartesian-series%})
