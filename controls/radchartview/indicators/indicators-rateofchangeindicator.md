---
title: RateOfChangeIndicator
page_title: RateOfChangeIndicator
description: Check our &quot;RateOfChangeIndicator&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-rateofchangeindicator
tags: financial, indicators, rateofchangeindicator
publish: True
position: 13
---

# RateOfChangeIndicator

RateOfChangeIndicator measures the relative (percent) change in the values from one period to the next.

To set up the indicator you can set its __CategoryBinding, ValueBinding and ItemsSource__ properties. Additionally, you can control the period (in days) over which the indicator will be applied. To do this set the __Period__ property.

__Example 1: RateOfChangeIndicator__
```XAML
	 <telerik:RadCartesianChart.Indicators>
		<telerik:RateOfChangeIndicator Period="8" 													
									   CategoryBinding="Date"                                             
									   ValueBinding="Close"
									   ItemsSource="{Binding Data}"/>
	</telerik:RadCartesianChart.Indicators>
```

#### Figure 1: RateOfChangeIndicator
<img src="images/radchartview-indicators-rateofchangeindicator-0.png" style="width: 80%;">

> __Figure 1__ shows 2 instances of RadCartesianChart. The top one shows only the candlestick series that displays the original data. The chart on the bottom shows the indicator.

>tip The indicator can be set up the same way as a normal [chart series]({%slug radchartview-series-chartseries%}). This is why you can populate it using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc, and also the ItemsSource.

## See Also
* [Indicators Overview]({%slug radchartview-indicators-overview%})
* [Getting Started]({%slug radchartview-introduction%})