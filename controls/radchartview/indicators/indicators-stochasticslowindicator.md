---
title: StochasticSlowIndicator
page_title: StochasticSlowIndicator
description: Check our &quot;StochasticSlowIndicator&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-stochasticslowindicator
tags: financial, indicators, stochasticslowindicator
publish: True
position: 18
---

# StochasticSlowIndicator

StochasticSlowIndicator shows the location of the close relative to the high/low range over a number of periods.

To set up the indicator you can set its __CategoryBinding, HighBinding, LowBinding, CloseBinding, and ItemsSource__ properties. Additionally, you can control the period (in days) over which the indicator will be applied. To do this set the __SignalPeriod__, __MainPeriod__ and __SlowingPeriod__ properties.

To display the signal period you will need to set the __SignalStroke__ property.

__Example 1: Defining StochasticSlowIndicator__
```XAML
	<telerik:RadCartesianChart.Indicators>
		<telerik:StochasticSlowIndicator MainPeriod="14" 
									     SignalPeriod="3"
									     SlowingPeriod="3"
									     SignalStroke="Black"
									     CategoryBinding="Date"                                             
									     HighBinding="High"                                           
									     LowBinding="Low"                                           
									     CloseBinding="Close"                                             
									     ItemsSource="{Binding Data}"/>
	</telerik:RadCartesianChart.Indicators>
```

#### Figure 1: StochasticSlowIndicator
<img src="images/radchartview-indicators-stochasticslowindicator-0.png" style="width: 80%;">

> __Figure 1__ shows 2 instances of RadCartesianChart. The top one shows only the candlestick series that displays the original data. The chart on the bottom shows the indicator.

>tip The indicator can be set up the same way as a normal [chart series]({%slug radchartview-series-chartseries%}). This is why you can populate it using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc, and also the ItemsSource.

## See Also
* [Indicators Overview]({%slug radchartview-indicators-overview%})
* [Getting Started]({%slug radchartview-introduction%})