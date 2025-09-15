---
title: Gap Length
page_title: Gap Length
description: This article describe the GapLength property of the CategoricalSeries.
slug: radchartview-axes-gap-length
tags: axis, gaplength
published: True
position: 0
---

# Gap Length

The __CategoricalAxis__ and the __DateTime axes (DateTimeCategoricalAxis and DateTimeContinuousAxis)__ expose a __GapLength__ property which can be used to define what type of fraction of the category slot will be filled with the visual representation of the data point. This property expects a relative value between 0 and 1. For the purpose of this tutorial we will use BarSeries as the gap length can be easily observed.

__Example 1__ demonstrates that setting the __GapLength__ to __0.90__ value tells the gap to take __90%__ of the available space in the category slot. The other __10%__ will be taken by the bar visuals of the series.

__Example 1: Setting the GapLength property__
```XAML
	<telerik:RadCartesianChart Palette="Windows8">
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis GapLength="0.90"/>
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis />
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.Series>
			<telerik:BarSeries>
				<telerik:BarSeries.DataPoints>
					<telerik:CategoricalDataPoint Category="January" Value="2" />
					<telerik:CategoricalDataPoint Category="February" Value="5" />
					<telerik:CategoricalDataPoint Category="March" Value="3" />
					<telerik:CategoricalDataPoint Category="April" Value="10" />
					<telerik:CategoricalDataPoint Category="May" Value="9" />
					<telerik:CategoricalDataPoint Category="June" Value="7" />
					<telerik:CategoricalDataPoint Category="July" Value="1" />
				</telerik:BarSeries.DataPoints>
			</telerik:BarSeries>
		</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
```

![{{ site.framework_name }} RadChartView Gap Length](images/radchartview-axes-gap-length.png)
	
## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [Events]({%slug radchartview-events%})
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
