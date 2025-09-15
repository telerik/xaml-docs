---
title: TrueRangeIndicator
page_title: TrueRangeIndicator
description: Check our &quot;TrueRangeIndicator&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-truerangeindicator
tags: financial, indicators, truerangeindicator
publish: True
position: 20
---

# TrueRangeIndicator

TrueRangeIndicator measures the daily range with addition to any gap from the closing price of the preceding day.

To set up the indicator you can set its __CategoryBinding, HighBinding, LowBinding, CloseBinding, and ItemsSource__ properties. 

__Example 1: Defining TrueRangeIndicator__
```XAML
	<telerik:RadCartesianChart.Indicators>
		<telerik:TrueRangeIndicator CategoryBinding="Date" 
                                    HighBinding="High"
                                    LowBinding="Low"
                                    CloseBinding="Close" 
									ItemsSource="{Binding Data}"/>
	</telerik:RadCartesianChart.Indicators>
```

#### Figure 1: TrueRangeIndicator
<img src="images/radchartview-indicators-truerangeindicator-0.png" style="width: 80%;">

> __Figure 1__ shows 2 instances of RadCartesianChart. The top one shows only the candlestick series that displays the original data. The chart on the bottom shows the indicator.

>tip The indicator can be set up the same way as a normal [chart series]({%slug radchartview-series-chartseries%}). This is why you can populate it using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc, and also the ItemsSource.

## See Also
* [Indicators Overview]({%slug radchartview-indicators-overview%})
* [Getting Started]({%slug radchartview-introduction%})