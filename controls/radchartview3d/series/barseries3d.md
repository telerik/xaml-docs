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
```XAML
	<telerik:RadCartesianChart3D>
		<telerik:RadCartesianChart3D.XAxis>
			<telerik:CategoricalAxis3D />
		</telerik:RadCartesianChart3D.XAxis>
		<telerik:RadCartesianChart3D.YAxis>
			<telerik:CategoricalAxis3D />
		</telerik:RadCartesianChart3D.YAxis>
		<telerik:RadCartesianChart3D.ZAxis>
			<telerik:LinearAxis3D />
		</telerik:RadCartesianChart3D.ZAxis>
		<telerik:RadCartesianChart3D.Series>
			<telerik:BarSeries3D>
				<telerik:BarSeries3D.DataPoints>
					<telerik:XyzDataPoint3D XValue="R1" YValue="2013" ZValue="40" />
					<telerik:XyzDataPoint3D XValue="R1" YValue="2014" ZValue="50" />
					<telerik:XyzDataPoint3D XValue="R1" YValue="2015" ZValue="60" />
					<telerik:XyzDataPoint3D XValue="R2" YValue="2013" ZValue="30" />
					<telerik:XyzDataPoint3D XValue="R2" YValue="2014" ZValue="40" />
					<telerik:XyzDataPoint3D XValue="R2" YValue="2015" ZValue="50" />
					<telerik:XyzDataPoint3D XValue="R3" YValue="2013" ZValue="20" />
					<telerik:XyzDataPoint3D XValue="R3" YValue="2014" ZValue="30" />
					<telerik:XyzDataPoint3D XValue="R3" YValue="2015" ZValue="40" />
				</telerik:BarSeries3D.DataPoints>
			</telerik:BarSeries3D>
		</telerik:RadCartesianChart3D.Series>
		<telerik:RadCartesianChart3D.Grid>
			<telerik:CartesianChart3DGrid />
		</telerik:RadCartesianChart3D.Grid>
	</telerik:RadCartesianChart3D>
```
	
#### __Figure 1: BarSeries3D__
![{{ site.framework_name }} RadChartView3D BarSeries3D](images/radchartview-3d-barseries3d-0.png)

## Data bound series

You can use the __XValueBinding__, __YValueBinding__ and __ZValueBinding__ properties of __BarSeries3D__ to bind the __XyzDataPoints__’ properties to the properties of the view models. The __ItemsSource__ property is used to pass the data collection to the series.

__Example 2: Defining a model for the data points and setting up the data context__
```C#
	public class PlotInfo
	{
		public double XValue { get; set; }
		public double YValue { get; set; }
		public double ZValue { get; set; }
	}

	//.......
	this.DataContext = new ObservableCollection<PlotInfo>
	{
		new PlotInfo { XValue = 10, YValue = 20, ZValue = 150, },
		//....
	};
```

__Example 3: Setting up the series__
```XAML
	<telerik:BarSeries3D XValueBinding="XValue"  YValueBinding="YValue" ZValueBinding=”ZValue” ItemsSource="{Binding}"/>
```
	
## Display direction

The display direction of the series specifies which axis determines the start (origin) and end of the bars. The bar is drawn from the origin value to the value of the bar on the corresponding axis (the display direction). The direction is defined via the __DisplayDirection__ property which is of type __Axis3DType?__ and it accepts the following values – __X__, __Y__ and __Z__. The default display direction of BarSeries3D is __Z__.

You can use the __OriginValue__ property to define the origin of the bars on the corresponding axis determined by the __DisplayDirection__ property. The default origin value is __0__.

__Example 4: Setting the origin value__
```XAML
	<telerik:BarSeries3D OriginValue="15">
```

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
