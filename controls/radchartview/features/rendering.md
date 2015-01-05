---
title: Rendering
page_title: Rendering
description: Rendering
slug: radchartview-features-rendering
tags: rendering
published: True
position: 3
---

# Rendering

The __RadChartView__ components allow you to specify the series rendering surface. This feature also provides you with the ability to adjust the overall performance of the charting components. In order to select any of the available rendering modes, you can use the __RenderOptions__ property of the series. It is of type ChartRenderOptions and it can be set to any of the following built-in __ChartRenderOptions__:

* __Direct2DRenderOptions__
* __XamlRenderOptions__
* __BitmapRenderOptions__

It is important to have in mind that the rendering feature affects only the default visual components of the series. If a custom PointTemplate is applied on the series, the charting component will create separate content presenters for each data point and the rendering options will not be able to affect the rendering of these points.

## Direct 2D Rendering

Direct 2D is hardware accelerated two dimensional graphics API, designed by Microsoft to support the most demanding and visually rich desktop applications with the best possible performance. Now the RadChartView components now can also benefit from this API to further extend and optimize their rendering capabilities and performance.

>important In order to enable this API in your project, you need to make sure that your GPU supports at least Direct3D 10.1 Feature Level 9.1. You can use the __Boolean Direct2DRenderOptions.IsHardwareDeviceAvailable()__ method to check if the necessary hardware is available on your system. If it returns __True__, you will be able to use the __Direct2D__ rendering option, otherwise you should use one of the other available rendering options. You can perform this check right after the call to __InitializeComponent()__ method in your main view.

In order to use the Direct2DRenderOptions, you will need to reference the following binaries in your project:
* __SharpDX.dll (version 2.5.0)__
* __SharpDX.Direct2D1.dll (version 2.5.0)__
* __SharpDX.Direct3D10.dll (version 2.5.0)__
* __SharpDX.Direct3D9.dll (version 2.5.0)__
* __SharpDX.DXGI.dll (version 2.5.0)__
* __Telerik.Windows.Controls.Chart.Direct2D.dll__

>The SharpDX binaries can be found under the SharpDX folder of your Telerik's installation directory.

After referencing those binaries, you will be able to set the RenderOptions property of the series like this:

#### __XAML__
	<telerik:RadCartesianChart.Series>
	  <telerik:LineSeries>
		  <telerik:LineSeries.RenderOptions>
			  <telerik:Direct2DRenderOptions/>
		  </telerik:LineSeries.RenderOptions>
	  </telerik:LineSeries>
	</telerik:RadCartesianChart.Series>

The Direct2DRenderOptions class exposes the following properties:

* __AntialiasMode__ - this is an enumeration property that controls how the series will be rendered. Setting it to PerPrimitive turns the [anti-aliasing](http://msdn.microsoft.com/en-us/library/9t6sa8s9%28v=vs.110%29.aspx) on. Alternatively, you can set the property to Aliased to render the primitives as aliased.

* __DefaultVisualsRenderMode__ - this is an enumeration property that controls the number of components that will be created to visualize the data points of the series. When this property is set to __Separate__, the __RadChartView__ component will create a separate visual component for each data point. Alternatively, this property can be set to Batch to make the charting control use one visual element to render all data points.

>If only one visual component is used for all data points, the same style will be applied to all of the points. If you need to apply different style for any (or all) of the data points you need to set this property to __Separate__.

## XAML Rendering

The XAML rendering is the default rendering mode for all series. If this mode is applied, the __RadChartView__ will use native components to draw the series. For more information about the components used by the series you can take a look at the Controlling Series Appearance article.

This rendering mode exposes the following properties:

* __EdgeMode__ - gets or sets if the anti-aliasing for the series is turned on. The default value of this property is [Unspecified](http://msdn.microsoft.com/en-us/library/system.windows.media.edgemode%28v=vs.110%29.aspx).

* __GeometryType__ - gets or sets the type of the geometry used by the charting component. The default value of this property is [PathGeometry](http://msdn.microsoft.com/en-us/library/system.windows.media.pathgeometry%28v=vs.110%29.aspx), but it can also be set to [StreamGeometry](http://msdn.microsoft.com/en-us/library/system.windows.media.streamgeometry%28v=vs.110%29.aspx).

* __DefaultVisualsRenderMode__ - this is an enumeration property that controls the number of components that will be created to visualize the data points of the series. When this property is set to __Separate__, the __RadChartView__ component will create a separate visual component for each data point. Alternatively, this property can be set to __Batch__ to make the charting control use one visual element to render all data points.

>If only one visual component is used for all data points, the same style will be applied to all of the points. If you need to apply different style for any (or all) of the data points you need to set this property to __Separate__.

## Bitmap Rendering

Using this rendering mode, the __RadChartView__ will create one Bitmap image and each of the series will be drawn on top of that image in code. Please note that this mode doesn’t support stroke thickness higher than __1px__ and [anti-aliasing](http://msdn.microsoft.com/en-us/library/9t6sa8s9%28v=vs.110%29.aspx).

You can enable this rendering mode with the following code:

#### __XAML__
	<telerik:RadCartesianChart.Series>
		<telerik:LineSeries>
			<telerik:LineSeries.RenderOptions>
				<telerik:BitmapRenderOptions/>
			</telerik:LineSeries.RenderOptions>
		</telerik:LineSeries>
	</telerik:RadCartesianChart.Series>

You can control the number of components created to visualize the data points in this rendering mode through the __DefaultVisualsRenderMode__ property. As an enumeration of style __DefaultVisualsRenderModeand__ it provides the following options:

* __Separate__ - the __RadChartView__ component will create a separate visual component for each data point.
* __Barch__ - the charting control will use one visual element to render all data points.

# See Also
* [Chart Series Overview]({%slug radchartview-series-chartseries%})
* [Customizing Series Apperance]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%})