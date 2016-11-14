---
title: PointSeries3D
page_title: PointSeries3D
description: PointSeries3D
slug: radchartview3d-pointseries3d
tags: axes, 3d, chartview, pointseries, sphere
published: True
position: 1
---

# PointSeries3D

The point series visualizes three dimensional data represented by ellipsoid shapes (spheres by default). Each data point is defined by X, Z and Y values which determines its position in the plot area. The size of the shapes is defined via the __PointSize__ property of the series.

* [Declaratively defined series](#declaratively-defined-series)
* [Data bound series](#data-bound-series)
* [Customizing the data point visuals](#customizing-the-data-point-visuals)

## Declaratively defined series

You can use the code from __Example 1__ to create a __PointSeries3D__. 

#### __[XAML] Example 1: Defining series in XAML__	
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
			<telerik:PointSeries3D PointSize="100 100 100">
				<telerik:PointSeries3D.DataPoints>
					<telerik:XyzDataPoint3D XValue="R1" YValue="2013" ZValue="40" />
					<telerik:XyzDataPoint3D XValue="R1" YValue="2014" ZValue="50" />
					<telerik:XyzDataPoint3D XValue="R1" YValue="2015" ZValue="60" />
					<telerik:XyzDataPoint3D XValue="R2" YValue="2013" ZValue="30" />
					<telerik:XyzDataPoint3D XValue="R2" YValue="2014" ZValue="40" />
					<telerik:XyzDataPoint3D XValue="R2" YValue="2015" ZValue="50" />
					<telerik:XyzDataPoint3D XValue="R3" YValue="2013" ZValue="20" />
					<telerik:XyzDataPoint3D XValue="R3" YValue="2014" ZValue="30" />
					<telerik:XyzDataPoint3D XValue="R3" YValue="2015" ZValue="40" />
				</telerik:PointSeries3D.DataPoints>
			</telerik:PointSeries3D>
		</telerik:RadCartesianChart3D.Series>
		<telerik:RadCartesianChart3D.Grid>
			<telerik:CartesianChart3DGrid />
		</telerik:RadCartesianChart3D.Grid>
	</telerik:RadCartesianChart3D>
	
#### __Figure 1: PointSeries3D__
![](images/radchartview-3d-pointseries3d-0.png)

## Data bound series

You can use the __XValueBinding__, __YValueBinding__ and __ZValueBinding__ properties of __PointSeries3D__ to bind the __XyzDataPoints__’ properties to the properties of the view models. The __ItemsSource__ property is used to pass the data collection to the series.

#### __[C#] Example 2: Defining a model for the data points and setting up the data context__
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

#### __[XAML] Example 3: Setting up the series__
	<telerik:PointSeries3D XValueBinding="XValue"  YValueBinding="YValue" ZValueBinding=”ZValue” ItemsSource="{Binding}"/>

## Customizing the data point visuals

You can change the size of the data points using the __PointSize__ property.

#### __[XAML] Example 4: Setting point size in XAML__  
	<telerik:PointSeries3D PointSize="60 60 60">

#### __[C#] Example 5: Setting point size in code__  
	pointSeries.PointSize = new Size3D(60, 60, 60);

The visual elements that represent the __PointSeries3D__ data points can be customized through the __DefaultVisualMaterial__ and __DefaultVisualGeometry__ properties of the series. Additionally, you can use the __DefaultVisualMaterialSelector__ and __DefaultVisualGeometrySelector__ to choose different materials and geometries based on a specific condition.
 
>For more information, see the [Customizing Cartesian Chart 3D Series]({%slug radchartview3d-customizing-cartesian-series%}) help article.

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [Axes]({%slug radchartview3d-axes%})
* [SurfaceSeries3D]({%slug radchartview3d-surfaceseries3d%})
* [BarSeries3D]({%slug radchartview3d-barseries3d%})
* [Customizing 3D Series]({%slug radchartview3d-customizing-cartesian-series%})