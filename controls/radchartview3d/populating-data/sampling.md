---
title: Sampling
page_title: Sampling
description: Sampling
slug: radchartview3d-populating-data-sampling
tags: sampling,3d,chartview
published: True
position: 3
---

# Sampling

>important The sampling feature is supported only in a [data binding]({%slug radchartview3d-populating-data-databinding%}) scenario.

The 3D chart supports index-based sampling. For a given set of business objects the sampling engine creates a subset of data point models (DataPoint3D). Each data point model is created by combinig a number of business objects based on the sampling threshold. The value of the combined data point is determined by the sampling function. The default aggregate function of the sampling feature is Average.

__ChartDataSource__ is the class used to apply sampling on the original data. The class exposes a __SamplingThreshold__ property that determines the number of DataPoint3D models to be created and plotted in the chart.

__ChartDataSource__ implements the IEnumerable interface which allows you to assing it to the ItemsSource property of a chart 3D series.

//ChartDataSource
//SamplingThreshold
//A description with an example with data and result after sampling
//A complete code example with a picture

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Data Binding]({%slug radchartview3d-populating-data-databinding%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [PointSeries3D]({%slug radchartview3d-pointseries3d%})
* [BarSeries3D]({%slug radchartview3d-barseries3d%})
* [SurfaceSeries3D]({%slug radchartview3d-surfaceseries3d%})

