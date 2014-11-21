---
title: CandlesticSeries
page_title: CandlesticSeries
description: CandlesticSeries
slug: radchartview-series-candlestickseries
tags: candlesticseries
published: True
position: 1
---

# CandlesticSeries

This is a typical financial series that can be used to visualize the state of a market for a period of time. This kind of series require one CategoricalAxis and one LinearAxis.

## Declaratively defined series

You can use the following definition to display a simple CandlestickSeries

#### XAML
{{region radchartview-candlestickseries}}
	<telerik:RadCartesianChart Palette="Windows8">
	<telerik:RadCartesianChart.HorizontalAxis>
		<telerik:CategoricalAxis/>
	</telerik:RadCartesianChart.HorizontalAxis>
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis />
	</telerik:RadCartesianChart.VerticalAxis>
	<telerik:RadCartesianChart.Series>
		<telerik:CandlestickSeries>
			<telerik:CandlestickSeries.DataPoints>
				<telerik:OhlcDataPoint Category="Monday" Open="5" Close="4" Low="2" High="10" />
				<telerik:OhlcDataPoint Category="Tuseday" Open="10" Close="8" Low="7" High="12"/>
				<telerik:OhlcDataPoint Category="Wednesday" Open="6" Close="8" Low="5" High="9"/>
				<telerik:OhlcDataPoint Category="Thursday" Open="3" Close="7" Low="3" High="8"/>
				<telerik:OhlcDataPoint Category="Friday" Open="5" Close="6" Low="4" High="7"/>
			</telerik:CandlestickSeries.DataPoints>
		</telerik:CandlestickSeries>
	</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
{{endregion}}
![radchartview-series-candlestickseries](images/radchartview-series-candlestickseries.png)

# See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})