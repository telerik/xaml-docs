---
title: Axis Smart Labels
page_title: Axis Smart Labels
description: Axis Smart Labels
slug: radchartview-features-axis-smart-labels
tags: smart,labels,axis,mode,smartlabelsmode,issteprecalculationonzoomenabled
published: True
position: 1
---

# Axis Smart Labels

The RadChartView suite supports couple smart mechanisms which control the axis labels generation.
* __SmartLabelsMode__: If enabled this feature tells the chart to recalculate the actual step of its axis automatically in order to prevent the axis' labels from overlapping one another. The recalculation logic is executed on update of the chart's layout (like resizing).
* __IsStepRecalculationOnZoomEnabled__: If enabled this feature controls if the axis should recalculate the actual step it uses when the chart gets zoomed. 

>important By default both mechanisms are disabled. 

## Using the Smart Labels Mode

You can enable the smart labels mode by setting the __SmartLabelsMode__ property of the axis.

#### __XAML__
{{region radchartview-features-axis-smart-labels-0}}
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis SmartLabelsMode="SmartStep"/>
	</telerik:RadCartesianChart.VerticalAxis>
{{endregion}}

The SmartLabelMode property is of type AxisSmartLabelsMode enum and it defines the algorithm which should be used for generating the labels. The enumeration expose the following properties:
* __None__ (default value): Do not attempt to avoid overlapping labels
* __SmartStep__: The axis will choose a step (or a tick interval) in such a way that labels don’t overlap
* __SmartStepAndRange__: The axis will choose a step and range in such a way that labels don’t overlap
	
	>important This mode is supported only by the __LinearAxis__ and the __LogarithmicAxis__.
	
The following picture demonstrates the different modes.

![radchartview-features-axis-smart-labels](images/radchartview-features-axis-smart-labels-01.png)

## Enable Step Recalculation on Zoom

You can enable the automatic recalculation of the axis labels when you zoom in/out the chart by setting the __IsStepRecalculationOnZoomEnabled__ property to __True__.

#### __XAML__
{{region radchartview-features-axis-smart-labels-0}}
	<telerik:RadCartesianChart.VerticalAxis>
		<telerik:LinearAxis IsStepRecalculationOnZoomEnabled="True"/>
	</telerik:RadCartesianChart.VerticalAxis>
{{endregion}}

The following picture demonstrates this feature:

![radchartview-features-axis-smart-labels](images/radchartview-features-axis-smart-labels-02.png)

>This mechanism is supported only by the chart's numeric axes.

## See Also
* [Overview]({%slug radchartview-overview %})
* [Getting Started]({%slug radchartview-introduction %})
* [Axis]({%slug radchartview-axes-axis %})