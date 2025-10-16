---
title: UltimateOscillatorIndicator
page_title: UltimateOscillatorIndicator
description: Check our &quot;UltimateOscillatorIndicator&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-ultimateoscillatorindicator
tags: financial, indicators, ultimateoscillatorindicator
publish: True
position: 21
---

# UltimateOscillatorIndicator

UltimateOscillatorIndicator measures momentum across three timeframes. The indicators has less volatility and trade signals compared to other single timeframed indicators.

To set up the indicator you can set its __CategoryBinding, HighBinding, LowBinding, CloseBinding, and ItemsSource__ properties. Additionally, you can control the period (in days) over which the indicator will be applied. To do this set the __Period__, __Period2__ and __Period3__ properties.

__Example 1: Defining UltimateOscillatorIndicator__
```XAML
	<telerik:RadCartesianChart.Indicators>
	    <telerik:UltimateOscillatorIndicator Period="6" 
                                             Period2="9"
                                             Period3="12"
                                             CategoryBinding="Date"                                             
                                             HighBinding="High"                                           
                                             LowBinding="Low"                                           
                                             CloseBinding="Close"                                                      
                                             ItemsSource="{Binding Data}"/>
	</telerik:RadCartesianChart.Indicators>
```

#### Figure 1: UltimateOscillatorIndicator
<img src="images/radchartview-indicators-ultimateoscillatorindicator-0.png" style="width: 80%;">

> __Figure 1__ shows 2 instances of RadCartesianChart. The top one shows only the candlestick series that displays the original data. The chart on the bottom shows the indicator.

>tip The indicator can be set up the same way as a normal [chart series]({%slug radchartview-series-chartseries%}). This is why you can populate it using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc, and also the ItemsSource.

## See Also
* [Indicators Overview]({%slug radchartview-indicators-overview%})
* [Getting Started]({%slug radchartview-introduction%})