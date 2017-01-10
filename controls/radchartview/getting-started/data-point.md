---
title: Data Point
page_title: Data Point
description: Data Point
slug: radchartview-getting-started-data-point
tags: getting, started, datapoint,data,point,categorical,scatter,pie,polar,bubble,range
published: True
position: 2
---

# Data Point

The chart data points are defined by the __DataPoint__ class and more specifically its inheritors. The different chart series types work with different class that derives from DataPoint. Each class contains common information about the data point - its layout slot, the related view model, label, selection state, parent series and more.

The chart series expose a DataPoints collection where the data point objects are placed. For more information on this, see the [Getting Started]({%slug radchartview-introduction%}) and [Create Chart With Static Data]({%slug radchartview-populating-with-data-static-data%}) help articles.

This article contains a brief information about the data point types and a reference sheet showing the DataPoint implementation used by each chart series.

The __DataContext__ of most chart templates and styles, as [ToolTipTemplate]({%slug radchartview-features-tooltip%}), [DefaultVisualStyle, PointTemplate]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}), etc., is an object of type __DataPoint__ which you can use to access the view model or other information related to the data point.

* [Series DataPoint Types](#series-datapoint-types)
* [Sampling and DataItem](#sampling-and-dataitem)
* [DataPoint](#datapoint)

## Series DataPoint Types

The following table shows which data points are being used by the corresponding series.

| Cartesian Chart Data Points | Pie Chart Data Points | Polar Chart Data Points |
| --- | --- | --- |
| __CategoricalDataPoint__<ul><li>LineSeries</li><li>StepLineSeries</li><li>SplineSeries</li><li>BarSeries</li><li>AreaSeries</li><li>SplineAreaSeries</li><li>StepAreaSeries</li><li>PointSeries</li</ul> | __PieDataPoint__<ul><li>PieSeries</li><li>DoughnutSeries</li></ul> | __PolarDataPoint__<ul><li>PolarLineSeries</li><li>PolarAreaSeries</li><li>PolarPointSeries</li><li>RadarLineSeries</li><li>RadarAreaSeries</li><li>RadarPointSeries</li></ul> |
| __ScatterDataPoint__<ul><li>ScatterLineSeries</li><li>ScatterSplineSeries</li><li>ScatterAreaSeries</li><li>ScatterSplineAreaSeries</li><li>ScatterPointSeries</li></ul> |
| __RangeDataPoint__<ul><li>RangeSeries</li><li>RangeBarSeries</li></ul> |
| __OhlcDataPoint__<ul><li>OhlcSeries</li><li>CandlestickSeries</li></ul> |
| __BubbleDataPoint__<ul><li>BubbleSeries</li></ul> |
| __BubbleScatterDataPoint__<ul><li>ScatterBubbleSeries</li></ul> |

## DataPoint

DataPoint is an abstract class used as a base by the concerete data point impelementations. The class contains information related to the element plotted in the chart. There are several classes that derive from DataPoint and they all share some common properties.

* __Presenter__: A property of type __IChartElementPresenter__ that holds a reference to the parent series where the data point is visualized.

* __LayoutSlot__: A property of type __RadRect__ that holds the rectangle where the data point is visualized. You can use it to get the size and the screen coordinates of the visual element representing the point.

* __DataItem__: A property of type __object__ that holds a reference to the view model of the data point. This property is valid only in a [data-bound]({%slug radchartview-populating-with-data-chartdatasource%}) scenario. In a sampling scenario the property holds an object of type [DataPointSamplingInfo](#sampling-and-dataitem) instead of the view model (the data item).
	
* __IsSelected__: A property of type __bool__ that indicates if the data point is selected. For more information, see the [Selection]({%slug radchartview-features-selection%}) help article.

* __IsInPlotRange__: A property of type __bool__ that indicates whether the data point's visual is in the plot area range. This is the actual range of the axes.

* __Label__: A property of type __object__ that contains the label associated with the data point.

Each different DataPoint inheritor implements properties that define the values used to plot it in the chart.

* [CategoricalDataPoint](#categoricaldatapoint)
* [BubbleDataPoint](#bubbledatapoint)
* [RangeDataPoint](#rangedatapoint)
* [OhlcDataPoint](#ohlcdatapoint)
* [ScatterDataPoint](#scatterdatapoint)
* [ScatterBubbleDataPoint](#scatterbubbledatapoint)
* [PieDataPoint](#piedatapoint)
* [PolarDataPoint](#polardatapoint)

## CategoricalDataPoint

The __CategoricalDataPoint__ class is used by the Cartesian chart series and it exposes two additional properties that define the position of the data point in the Cartesian coordinate system.

The __Category__ property defines the category of the data point on the categorical or date-time axis. And the __Value__ property defines the value of the data point on the numeric axis.

## BubbleDataPoint

The __BubbleDataPoint__ derives from the __CategoricalDataPoint__ and extends it with an additional __BubbleSize__ property. The property defines the size of the bubble.

## RangeDataPoint

The __RangeDataPoint__ is a type of categorical data point, so it has a __Category__ property. But, instead of a single value it works with two values - high and low. The values could be get/set via the __High__ and __Low__ properties and they define the range in which the data point visual will be drawn.

## OhlcDataPoint

The __OhlcDataPoint__ is a type of categorical data point, so it has a __Category__ property. But, instead of a single value it works with few additional values accessed via the following properties: __High__, __Low__, __Open__ and __Close__. This type of data point is used in the financial series of the chart (ohlc and candlestick).

Additionaly, the class exposes two properties that indicate whether the data point follows rasising (bullish) or falling (bearish) trend. The properties are __IsRising__ and __IsFalling__.

## ScatterDataPoint

This data point model is used by the Cartesian chart series and it exposes two additional properties that define the position of the data point in the Cartesian coordinate system.

The __XValue__ property defines the value of the data point on the horizontal axis. And the __YValue__ property defines the value of the data point on the vertical axis.

## ScatterBubbleDataPoint

The __ScatterBubbleDataPoint__ derives from the __ScatterDataPoint__ and extends it with an additional __BubbleSize__ property. The property defines the size of the bubble.

## PieDataPoint

This data point model is used in pie and doughnut series. It is a single value data point and it exposes a __Value__ property.

The pie data point also allows you to define its offset from the center of the pie. You can do that via the __OffsetFromCenter__ property. Note that the property works with relative units between 0 and 1.

## PolarDataPoint

This data point model is used in polar chart series and it exposes two properties defining the position of the data point in the polar cooridnate system.

The __Angle__ property defines the angle of the data point on the radial (circular) axis. And the __Value__ property defines the value of the data point on the polar (linear) axis. 

## Sampling and DataItem

In a sampling scenario the __DataItem__ property of the DataPoint object doesn't contain a data object from the view models collection. This is because in this case a number data items are aggregated into a single DataPoint object. In this scenario the DataItem property will contain an object of type __DataPointSamplingInfo__. See more about this in the [ChartDataSource]({%slug radchartview-populating-with-data-chartdatasource%}) help article.

## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [Series and Axes]({%slug radchartview-series-and-axes%})
* [Sampling]({%slug radchartview-populating-with-data-chartdatasource%})
