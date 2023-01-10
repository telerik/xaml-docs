---
title: ExponentialMovingAverageIndicator
page_title: ExponentialMovingAverageIndicator
description: Check our &quot;ExponentialMovingAverageIndicator&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-modifiedexponentialmovingaverageindicator
tags: financial, indicators, modifiedexponentialmovingaverageindicator
publish: True
position: 8
---

# {{ site.framework_name }} RadChartView ModifiedExponentialMovingAverageIndicator

ModifiedExponentialMovingAverageIndicator acts as a moving average indicator, therefore it is smoothing the data to form a trend following. In addition to this, the indicator gives weight to the recent data and reacts faster to changes in the data.

To set up the indicator you can set its __CategoryBinding, ValueBinding and ItemsSource__ properties. Additionally, you can control the period (in days) over which the indicator will be applied. To do this set the __Period__ property.

#### __[XAML] Example 1: Defining ModifiedExponentialMovingAverageIndicator__
{{region radchartview-indicators-modifiedexponentialmovingaverageindicator-0}}
	 <telerik:RadCartesianChart.Indicators>
		<telerik:ModifiedExponentialMovingAverageIndicator Period="5" 													
														   CategoryBinding="Date"                                             
														   ValueBinding="Close"
														   ItemsSource="{Binding Data}"/>
	</telerik:RadCartesianChart.Indicators>
{{endregion}}

#### Figure 1: ModifiedExponentialMovingAverageIndicator
<img src="images/radchartview-indicators-modifiedexponentialmovingaverageindicator-0.png" style="width: 80%;">

>tip The indicator can be set up the same way as a normal [chart series]({%slug radchartview-series-chartseries%}). This is why you can populate it using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc, and also the ItemsSource.

## See Also
* [Indicators Overview]({%slug radchartview-indicators-overview%})
* [Getting Started]({%slug radchartview-introduction%})