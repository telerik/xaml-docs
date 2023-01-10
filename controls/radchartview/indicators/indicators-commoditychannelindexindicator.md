---
title: CommodityChannelIndexIndicator
page_title: CommodityChannelIndexIndicator
description: Check our &quot;CommodityChannelIndexIndicator&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-commoditychannelindexindicator
tags: financial, indicators, commoditychannelindexindicator
publish: True
position: 4
---

# {{ site.framework_name }} RadChartView CommodityChannelIndexIndicator

CommodityChannelIndexIndicator measures the current price level relative to an average price level over a specific period of time. The indicator can be used to identify overbought and oversold levels.

To set up the indicator you can set its __CategoryBinding, HighBinding, LowBinding, CloseBinding, and ItemsSource__ properties. Additionally, you can control the period (in days) over which the indicator will be applied. To do this set the __Period__ property.

#### __[XAML] Example 1: Defining CommodityChannelIndexIndicator__
{{region radchartview-indicators-commoditychannelindexindicator-0}}
	<telerik:RadCartesianChart.Indicators>
		<telerik:CommodityChannelIndexIndicator Period="5" 
											    CategoryBinding="Date" 
											    HighBinding="High"
											    LowBinding="Low"
											    CloseBinding="Close" 
											    ItemsSource="{Binding Data}"/>
	</telerik:RadCartesianChart.Indicators>
{{endregion}}

#### Figure 1: CommodityChannelIndexIndicator
<img src="images/radchartview-indicators-commoditychannelindexindicator-0.png" style="width: 80%;">

> __Figure 1__ shows 2 instances of RadCartesianChart. The top one shows only the candlestick series that displays the original data. The chart on the bottom shows the indicator.

>tip The indicator can be set up the same way as a normal [chart series]({%slug radchartview-series-chartseries%}). This is why you can populate it using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc, and also the ItemsSource.

## See Also
* [Indicators Overview]({%slug radchartview-indicators-overview%})
* [Getting Started]({%slug radchartview-introduction%})