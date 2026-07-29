---
title: Controlling Axis Range
page_title: Controlling Axis Range
description: This article describes how to control the axis range in RadChartView for WPF.
slug: radchartview-axis-range
tags: axis,range,majorstep,step,interval
published: True
position: 1
---

# Controlling Axis Range

The chart continuous axes have a notion of range which, by default, is calculated automatically based on the plotted data. The RadChartView axes allow to access information about the range or adjust the range manually.

Continuous axes are `LinearAxis`, `LogarithmicAxis` and `DateTimeContinuousAxis`. The `CategoricalAxis` and `DateTimeCategoricalAxis` don't have notion of range and the following information is not relevant for them.
The examples in the article work mostly with numeric values, but if you use the `DateTimeContinuousAxis` you will need to use `DateTime`.

## Actual Range

The actual range is a read-only information that tells what are the real minimum and maximum properties of the axis. This concept exists to ensure that the axis range can be accessed regardless if it is calcuilated automatically or set manually.

To get the actual range, use the `ActualRange` property of the axis.

To get the actual range when the axis is zoom-in, use the `ActualVisibleRange` property of the axis. This gives information about the currently visible minimum and maximum.

To get the actual major step, use the `ActualMajorStep` property of the axis.

__Getting the actual range of a LinearAxis__
<snippet id='radchartview-axes-axis-range-getting_the_actual_range_of_a_linearaxis-cs' />


The axis also provides a couple of __events raised when the range changes__.

* `ActualRangeChanged`
* `ActualVisibleRangeChanged`
* `ActualMajorStepChanged`

__Actual range and step changed event handlers__
<snippet id='radchartview-axes-axis-range-actual_range_and_step_changed_event_handlers-cs' />


## Setting the Range Manually

The axis range can be adjusted manually by setting the `Minimum` and `Maximum` properties of the axis.

__Setting axis range in XAML__
<snippet id='radchartview-axes-axis-range-setting_axis_range_in_xaml-xaml' />


__Setting axis range in C#__
<snippet id='radchartview-axes-axis-range-setting_axis_range_in_c-xaml' />


![WPF ChartView Axis Range Setting](images/radchartview-axis-range-0.png)

## Setting the Step

The chart axes allow you to manually set the major and minor step, which determines the value distance between two adjacent ticks.

To set the major step, use the `MajorStep` property of the axis.

__Setting major step__
<snippet id='radchartview-axes-axis-range-setting_major_step-xaml' />


![WPF ChartView Axis Major Step Setting](images/radchartview-axis-range-1.png)

To get the actual major step, use the `ActualMajorStep` property of the axis. This is helpful if you don't assign the `MajorStep` property and rely on the automatically calculated one.

The minor step can be set with the `MinorTicksPerMajor` property of the axis. This determines how many minor ticks should be drawn between two adjacent major ticks. Read more about this feature in the [Minor Ticks and Strips]({%slug radchartview-minor-ticks-and-stripes%}) article.

The step in the `DateTimeContinuousAxis` works with two properties - the `MajorStep` and the `MajorStepUnit` which determines the time interval of the step. Read more in the [Date Time Axes]({%slug radchartview-axes-datetimeaxes%}) article.

The first major tick can be offset by setting the `MajorTickOffset` property of the axis. This determines which tick (by index) should be shown first. For example, setting the offset to 3 will skip three ticks before start rendering the ticks.

## Setting the Tick Origin

The tick origin determines the value where the ticks originate. The positions of the ticks are determined based on the combination of the major step and tick origin values. 

To set the origin, use the `TickOrigin` property of the axis (available in `LinearAxis` and `DateTimeContinuousAxis`).

__Setting major step__
<snippet id='radchartview-axes-axis-range-setting_major_step-xaml' />


![WPF ChartView Axis Tick Origin Setting](images/radchartview-axis-range-2.png)

## Setting the Desired Ticks Count

The axis allows you to set the desired tick count via the `DesiredTickCount` property. The axis will try to calculate a proper step based on the axis range and the desired number of ticks. Note, that the actual number of ticks may be slightly higher or lower since the automatic range calculation takes into account different factors and it tries to display a reasonable step between the ticks. For example, if the `DesiredTickCount` is 7, then 6 or 8 ticks may be drawn, depending on the range of the axis.

__Setting desired number of ticks__
<snippet id='radchartview-axes-axis-range-setting_desired_number_of_ticks-xaml' />


![WPF ChartView Axis Desired Tick Count Setting](images/radchartview-axis-range-3.png)
	
## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [Events]({%slug radchartview-events%})
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
