---
title: AdaptiveMovingAverageKaufmanIndicator
page_title: AdaptiveMovingAverageKaufmanIndicator
description: Check our &quot;AdaptiveMovingAverageKaufmanIndicator&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-adaptivemovingaveragekaufmanindicator
tags: financial, indicators, adaptivemovingaveragekaufmanindicator
publish: True
position: 2
---

# AdaptiveMovingAverageKaufmanIndicator

AdaptiveMovingAverageKaufmanIndicator acts as a moving average indicator, therefore it is smoothing the data to form a trend following. In addition to this, the indicator tracks the degree of noise in the trend and adjusts based on it.

To set up the indicator you can set its __CategoryBinding, ValueBinding and ItemsSource__ properties. Additionally, you can control the period (in days) over which the indicator will be applied. To do this set the __Period__, __SlowPeriod__ and __FastPeriod__ properties.

__Example 1: Defining AdaptiveMovingAverageKaufmanIndicator__
```XAML
	 <telerik:RadCartesianChart.Indicators>
		<telerik:AdaptiveMovingAverageKaufmanIndicator Period="5" 
													   SlowPeriod="10"
													   FastPeriod="4"
													   CategoryBinding="Date"                                             
													   ValueBinding="Close"
													   ItemsSource="{Binding Data}"/>
	</telerik:RadCartesianChart.Indicators>
```

#### Figure 1: AdaptiveMovingAverageKaufmanIndicator
<img src="images/radchartview-indicators-adaptivemovingaveragekaufmanindicator-0.png" style="width: 80%;">

>tip The indicator can be set up the same way as a normal [chart series]({%slug radchartview-series-chartseries%}). This is why you can populate it using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc, and also the ItemsSource.

## See Also
* [Indicators Overview]({%slug radchartview-indicators-overview%})
* [Getting Started]({%slug radchartview-introduction%})