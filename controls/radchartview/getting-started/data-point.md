---
title: Data Point
page_title: Data Point
description: Check our &quot;Data Point&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-getting-started-data-point
tags: getting, started, datapoint,data,point,categorical,scatter,pie,polar,bubble,range
published: True
position: 2
---

# {{ site.framework_name }} RadChartView Data Point

The chart data points are defined by the __DataPoint__ class and more specifically its inheritors. The different chart series types work with different class that derives from DataPoint. Each class contains common information about the data point - its layout slot, the related view model, label, selection state, parent series and more.

The chart series expose a DataPoints collection where the data point objects are placed. For more information on this, see the [Getting Started]({%slug radchartview-introduction%}) and [Create Chart With Static Data]({%slug radchartview-populating-with-data-static-data%}) help articles.

This article contains a brief information about the data point types and a reference sheet showing the DataPoint implementation used by each chart series.

The __DataContext__ of most chart templates and styles, as [ToolTipTemplate]({%slug radchartview-features-tooltip%}), [DefaultVisualStyle, PointTemplate]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}), etc., is an object of type __DataPoint__ which you can use to access the view model or other information related to the data point.

* [Series DataPoint Types](#series-datapoint-types)
* [Sampling and DataItem](#sampling-and-dataitem)
* [DataPoint](#datapoint)

## Series DataPoint Types

The following table shows which data points are being used by the corresponding series.

<table>
	<thead>
		<tr>
			<th>Cartesian Chart Data Points</th>
			<th>Pie Chart Data Points</th>
			<th>Polar Chart Data Points</th>
			<th>Funnel Chart Data Point</th>
		</tr>
	</thead>
	<tbody>
		<tr style="vertical-align:top;">
			<td>
				<strong>CategoricalDataPoint</strong>
				<ul>
					<li>LineSeries</li>
					<li>StepLineSeries</li>
					<li>SplineSeries</li>
					<li>BarSeries</li>
					<li>AreaSeries</li>
					<li>SplineAreaSeries</li>
					<li>StepAreaSeries</li>
					<li>PointSeries</li
				</ul> 
			</td>
			<td>
				<strong>PieDataPoint</strong>
				<ul>
					<li>PieSeries</li>
					<li>DoughnutSeries</li>
				</ul>
			</td>
			<td>
				<strong>PolarDataPoint</strong>
				<ul>
					<li>PolarLineSeries</li>
					<li>PolarAreaSeries</li>
					<li>PolarPointSeries</li>
					<li>RadarLineSeries</li>
					<li>RadarAreaSeries</li>
					<li>RadarPointSeries</li>
				</ul> 
			</td>
			<td>
				<strong>FunnelDataPoint</strong>
				<ul>
					<li>FunnelSeries</li>
				</ul>
			</td>
		</tr>
		<tr style="vertical-align:top;">
			<td>
				<strong>ScatterDataPoint</strong>
				<ul>
					<li>ScatterLineSeries</li>
					<li>ScatterSplineSeries</li>
					<li>ScatterAreaSeries</li>
					<li>ScatterSplineAreaSeries</li>
					<li>ScatterPointSeries</li>
				</ul> 
			</td>
			<td/>
			<td/>
			<td/>
		</tr>
		<tr style="vertical-align:top;">
			<td>
				<strong>RangeDataPoint</strong>
				<ul>
					<li>RangeSeries</li>
					<li>RangeBarSeries</li>
				</ul>
			</td>
			<td/>
			<td/>
			<td/>
		</tr>
		<tr style="vertical-align:top;">
			<td>
				<strong>OhlcDataPoint</strong>
				<ul>
					<li>OhlcSeries</li>
					<li>CandlestickSeries</li>
				</ul>
			</td>
			<td/>
			<td/>
			<td/>
		</tr>
		<tr style="vertical-align:top;">
			<td>
				<strong>BubbleDataPoint</strong>
				<ul>
					<li>BubbleSeries</li>
				</ul> 
			</td>
			<td/>
			<td/>
			<td/>
		</tr>
		<tr style="vertical-align:top;">
			<td>
				<strong>ScatterBubbleDataPoint</strong>
				<ul>
					<li>ScatterBubbleSeries</li>
				</ul>
			</td>
			<td/>
			<td/>
			<td/>
		</tr>
		<tr style="vertical-align:top;">
			<td>
				<strong>BoxPlotDataPoint</strong>
				<ul>
					<li>BoxPlotSeries</li>
				</ul>
			</td>
			<td/>
			<td/>
			<td/>
		</tr>
		<tr style="vertical-align:top;">
			<td>
				<strong>ErrorBarDataPoint</strong>
				<ul>
					<li>ErrorBarSeries</li>
				</ul>
			</td>
			<td/>
			<td/>
			<td/>
		</tr>
	</tbody>
</table>

## DataPoint

DataPoint is an abstract class used as a base by the concrete data point implementations. The class contains information related to the element plotted in the chart. There are several classes that derive from DataPoint and they all share some common properties.

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
* [FunnelDataPoint](#funneldatapoint)
* [BoxPlotDataPoint](#boxplotdatapoint)
* [ErrorBarDataPoint](#errorbardatapoint)

## CategoricalDataPoint

The __CategoricalDataPoint__ class is used by the Cartesian chart series and it exposes two additional properties that define the position of the data point in the Cartesian coordinate system.

The __Category__ property defines the category of the data point on the categorical or date-time axis. And the __Value__ property defines the value of the data point on the numeric axis.

## BubbleDataPoint

The __BubbleDataPoint__ derives from the __CategoricalDataPoint__ and extends it with an additional __BubbleSize__ property. The property defines the size of the bubble.

## RangeDataPoint

The __RangeDataPoint__ is a type of categorical data point, so it has a __Category__ property. But, instead of a single value it works with two values - high and low. The values could be get/set via the __High__ and __Low__ properties and they define the range in which the data point visual will be drawn.

## OhlcDataPoint

The __OhlcDataPoint__ is a type of categorical data point, so it has a __Category__ property. But, instead of a single value it works with few additional values accessed via the following properties: __High__, __Low__, __Open__ and __Close__. This type of data point is used in the financial series of the chart (ohlc and candlestick).

Additionally, the class exposes two properties that indicate whether the data point follows raising (bullish) or falling (bearish) trend. The properties are __IsRising__ and __IsFalling__.

## ScatterDataPoint

This data point model is used by the Cartesian chart series and it exposes two additional properties that define the position of the data point in the Cartesian coordinate system.

The __XValue__ property defines the value of the data point on the horizontal axis. And the __YValue__ property defines the value of the data point on the vertical axis.

## ScatterBubbleDataPoint

The __ScatterBubbleDataPoint__ derives from the __ScatterDataPoint__ and extends it with an additional __BubbleSize__ property. The property defines the size of the bubble.

## PieDataPoint

This data point model is used in pie and doughnut series. It is a single value data point and it exposes a __Value__ property.

The pie data point also allows you to define its offset from the center of the pie. You can do that via the __OffsetFromCenter__ property. Note that the property works with relative units between 0 and 1.

## PolarDataPoint

This data point model is used in polar chart series and it exposes two properties defining the position of the data point in the polar coordinate system.

The __Angle__ property defines the angle of the data point on the radial (circular) axis. And the __Value__ property defines the value of the data point on the polar (linear) axis. 

## FunnelDataPoint

This data point model is used in funnel chart series. To define the value of the data point the __Value__ property of the __FunnelDataPoint__ needs to be set. The funnel series data points also expose a __Label__ property which contains the associated label.

## BoxPlotDataPoint

The __BoxPlotDataPoint__ is a type of categorical data point, so it has a __Category__ property. But, instead of a single value it works with few additional values accessed via the following properties: __Minimum__, __Maximum__, __LowerQuartile__, __UpperQuartile__ and __Median__. This type of data point is used to describe a box plot element in the BoxPlotSeries.

## ErrorBarDataPoint

The __ErrorBarDataPoint__ is a type of categorical data point, so it has a __Category__ property. But, instead of a single value it works with few additional values accessed via the following properties: __Low__, __High__ and __Value__. This type of data point is used to describe an error bar visual in the ErrorBarSeries.

## Sampling and DataItem

In a sampling scenario the __DataItem__ property of the DataPoint object doesn't contain a data object from the view models collection. This is because in this case a number data items are aggregated into a single DataPoint object. In this scenario the DataItem property will contain an object of type __DataPointSamplingInfo__. See more about this in the [ChartDataSource]({%slug radchartview-populating-with-data-chartdatasource%}) help article.

## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [Series and Axes]({%slug radchartview-series-and-axes%})
* [Sampling]({%slug radchartview-populating-with-data-chartdatasource%})
