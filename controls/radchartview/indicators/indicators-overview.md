---
title: Indicators Overview
page_title: Indicators Overview
description: Check our &quot;Indicators Overview&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-indicators-overview
tags: financial, indicators
publish: True
position: 0
---

# Indicators Overview

RadChartView provides a rich set of __financial indicators__ which can be used to display a certain overlay on the data. The indicators are used to measure and visualize summarised information or a trend based on the provided data.

> The financial indicators are applicable only in the context of __RadCartesianChart__.

#### __Figure 1: Financial indicators__
<img src="images/radchartview-indicators-overview-0.png" style="width: 80%;">

## Setting Up an Indicator

The indicator itself is a [chart series]({%slug radchartview-series-chartseries%}) but with some additional sampling applied over the data before it gets plotted on the chart. The indicators are added in the __Indicators__ collection of RadCartesianChart.

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

The indicator is populate using the same approach as shown in the [Data Bind to Data-Object]({%slug radchartview-series-databinding%}) article. You can set the corresponding value binding properties - for example, ValueBinding, CategoryBinding, HighBinding, CloseBinding, etc. Additionally, you can apply different options based on the concrete indicator's implementation. 

>tip See the __Financial__ and __Stock Series/Indicators__ examples in the [demos application]() for a demonstration of the indicators.

## List of Indicators 

This section provides a full list with the chart's indicators.

* [AverageTrueRangeIndicator]({%slug radchartview-indicators-averagetruerangeindicator%})
* [AdaptiveMovingAverageKaufmanIndicator]({%slug radchartview-indicators-adaptivemovingaveragekaufmanindicator%})
* [BollingerBandsIndicator]({%slug radchartview-indicators-bollingerbandsindicator%})
* [CommodityChannelIndexIndicator]({%slug radchartview-indicators-commoditychannelindexindicator%})
* [ExponentialMovingAverageIndicator]({%slug radchartview-indicators-exponentialmovingaverageindicator%})
* [MacdhIndicator]({%slug radchartview-indicators-macdhindicator%})
* [MacdIndicator]({%slug radchartview-indicators-macdhindicator%})
* [ModifiedExponentialMovingAverageIndicator]({%slug radchartview-indicators-modifiedexponentialmovingaverageindicator%})
* [ModifiedMovingAverageIndicator]({%slug radchartview-indicators-modifiedmovingaverageindicator%})
* [MomentumIndicator]({%slug radchartview-indicators-momentumindicator%})
* [MovingAverageIndicator]({%slug radchartview-indicators-movingaverageindicator%})
* [OscillatorIndicator]({%slug radchartview-indicators-oscillatorindicator%})
* [RateOfChangeIndicator]({%slug radchartview-indicators-rateofchangeindicator%})
* [RaviIndicator]({%slug radchartview-indicators-raviindicator%})
* [RelativeMomentumIndexIndicator]({%slug radchartview-indicators-relativemomentumindexindicator%})
* [RelativeStrengthIndexIndicator]({%slug radchartview-indicators-relativestrengthindexindicator%})
* [StochasticFastIndicator]({%slug radchartview-indicators-stochasticfastindicator%})
* [StochasticSlowIndicator]({%slug radchartview-indicators-stochasticslowindicator%})
* [TrixIndicator]({%slug radchartview-indicators-trixindicator%})
* [TrueRangeIndicator]({%slug radchartview-indicators-truerangeindicator%})
* [UltimateOscillatorIndicator]({%slug radchartview-indicators-ultimateoscillatorindicator%})
* [WeightedMovingAverageIndicator]({%slug radchartview-indicators-weightedmovingaverageindicator%})

## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [ChartSelectionBehaviors]({%slug radchartview-features-selection%})
* [AnnotationsProvider]({%slug radchartview-annotations-annotationsprovider%})
* [Dynamic Number Of Series]({%slug radchartview-features-chartseriesprovider%})
