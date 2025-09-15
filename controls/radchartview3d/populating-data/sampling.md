---
title: Sampling
page_title: Sampling
description: Check our &quot;Sampling&quot; documentation article for the RadChartView3D {{ site.framework_name }} control.
slug: radchartview3d-populating-data-sampling
tags: sampling,3d,chartview
published: True
position: 3
---

# Sampling

>important The sampling feature is supported only in a [data binding]({%slug radchartview3d-populating-data-databinding%}) scenario.

The 3D chart supports index-based sampling. For a given set of business objects the sampling engine creates a subset of data point models (DataPoint3D). Each data point model is created by combining a number of business objects based on the sampling threshold. The value of the created data point is determined by the sampling function. The default aggregate function of the sampling feature is Average.

__ChartDataSource__ is the class used to apply sampling on the original data. The class exposes a __SamplingThreshold__ property that determines the minimum number of business objects in the ItemsSource required to apply sampling. 

__ChartDataSource__ implements the IEnumerable interface which allows you to assing it to the ItemsSource property of a chart 3D series.

__Example 1: Setting ChartDataSource__
```XAML	
	<Grid>
		<telerik:ChartDataSource x:Name="chartDataSource" ItemsSource="{Binding Items}" SamplingThreshold="10" />
		<telerik:RadCartesianChart3D>		
			<telerik:RadCartesianChart3D.Series>
				<telerik:BarSeries3D XValueBinding="XValue"                              
									 YValueBinding="YValue"                              
									 ZValueBinding="ZValue"
									 ItemsSource="{Binding ElementName=chartDataSource}"/>
			</telerik:RadCartesianChart3D.Series>
		</telerik:RadCartesianChart3D>
	</Grid>
```

Let's say that the original set of data from __Example 1__ called "Items" contains 100 items. With SamplingThreshold set to 10, the chart will try to create 10 DataPoint3D models and add them to the DataPoints collection of the series.

The ChartDataSource class exposes also SamplingUnit and SamplingUnitInterval properties. They are not supported by the 3D chart series. Also, currently the sampling works with average function which means that the sampling is supported only in scenarios with numeric axes (LinearAxis3D). 

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Data Binding]({%slug radchartview3d-populating-data-databinding%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [PointSeries3D]({%slug radchartview3d-pointseries3d%})
* [BarSeries3D]({%slug radchartview3d-barseries3d%})
* [SurfaceSeries3D]({%slug radchartview3d-surfaceseries3d%})

