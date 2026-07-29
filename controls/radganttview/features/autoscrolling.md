---
title: AutoScrolling
page_title: AutoScrolling - GanttView WPF
description: Check our &quot;AutoScrolling&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-features-autoscrolling
tags: autoscrolling
published: True
position: 15
---

# AutoScrolling

This feature will help end users by auto scrolling the visible area of the view while dragging __GanttTasks__ in the control.

## Enabling and disabling auto scrolling

By default the auto scrolling functionality is enabled. In order to disable it you need to set the __ScrollingSettingsBehavior.IsEnabled__ attached property to false:

__Example 1: Disable AutoScrolling__

<snippet id='radganttview-features-autoscrolling-example_1_disable_autoscrolling-xaml' />


### ScrollStep

The default value that is set to the __ScrollStep__ property is equal to 5px. This value determines how many pixels will be skipped while dragging the appointments.

The next code snippet demonstrates how to change the scrolling step in order to make the auto scrolling speed two times faster than its default value:

__Example 2: Increase ScrollStep__
<snippet id='radganttview-features-autoscrolling-example_2_increase_scrollstep-xaml' />


### ScrollStepTime

__ScrollStepTime__ sets the time interval between the scroll steps of the auto scrolling feature. The default value of this property is 0.01 sec and it could be set to any TimeSpan value.

The next code snippet demonstrates how to set the scroll time interval to half a second:

__Example 3: Increase Scroll Step Time Interval__
<snippet id='radganttview-features-autoscrolling-example_3_increase_scroll_step_time_interval-xaml' />


### ScrollAreaPadding

By setting __ScrollAreaPadding__ you can customize at which point the auto scrolling functionality will start. This property could be set in the same manner as the Padding property.  Its default value is 30px.

The next example shows how to set the ScrollAreaPadding in order to achieve top/bottom padding of 50px and right/left padding of 100px:

__Example 4: Increase Scroll Area Padding__
<snippet id='radganttview-features-autoscrolling-example_4_increase_scroll_area_padding-xaml' />


## See Also

 * [Scrolling]({%slug radganttview-scrolling%})
