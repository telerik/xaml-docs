---
title: WeightedMovingAverageIndicator
page_title: WeightedMovingAverageIndicator
description: Check our &quot;WeightedMovingAverageIndicator&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-weightedmovingaverageindicator
tags: financial, indicators, weightedmovingaverageindicator
publish: True
position: 23
---

# WeightedMovingAverageIndicator

WeightedMovingAverageIndicator measures and shows the simple average for a period of past data using heavier weighting, thus smoothing the data to form a trend following.

To set up the indicator you can set its __CategoryBinding, ValueBinding and ItemsSource__ properties. Additionally, you can control the period (in days) over which the indicator will be applied. To do this set the __Period__ property.

__Example 1: WeightedMovingAverageIndicator__
```XAML
	 <telerik:RadCartesianChart.Indicators>
		<telerik:WeightedMovingAverageIndicator Period="5"
												CategoryBinding="Date"                                             
												ValueBinding="Close"
												ItemsSource="{Binding Data}"/>
	</telerik:RadCartesianChart.Indicators>
```

#### Figure 1: WeightedMovingAverageIndicator
<img src="images/radchartview-indicators-weightedmovingaverageindicator-0.png" style="width: 80%;">

>tip The indicator can be set up the same way as a normal [chart series]({%slug radchartview-series-chartseries%}). This is why you can populate it using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc, and also the ItemsSource.

## See Also
* [Indicators Overview]({%slug radchartview-indicators-overview%})
* [Getting Started]({%slug radchartview-introduction%})