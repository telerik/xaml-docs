---
title: Gap Length
page_title: Gap Length
description: This article describe the GapLength property of the CategoricalSeries.
slug: radchartview-axes-gap-length
tags: axis, gaplength
published: True
position: 0
---

# Gap Length

The __CategoricalAxis__ and the __DateTime axes (DateTimeCategoricalAxis and DateTimeContinuousAxis)__ expose a __GapLength__ property which can be used to define what type of fraction of the category slot will be filled with the visual representation of the data point. This property expects a relative value between 0 and 1. For the purpose of this tutorial we will use BarSeries as the gap length can be easily observed.

__Example 1__ demonstrates that setting the __GapLength__ to __0.90__ value tells the gap to take __90%__ of the available space in the category slot. The other __10%__ will be taken by the bar visuals of the series.

__Example 1: Setting the GapLength property__
<snippet id='radchartview-axes-gap-length-example_1_setting_the_gaplength_property-xaml' />


![Telerik UI for WPF RadChartView with Custom Gap Length Between Categorical Axis Items](images/radchartview-axes-gap-length.png)
	
## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [Events]({%slug radchartview-events%})
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
