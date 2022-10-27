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

#### __[XAML] Example 1: Disable AutoScrolling__

{{region xaml-radganttview-features-autoscrolling-1}}
	<telerik:RadGanttView telerik:ScrollingSettingsBehavior.IsEnabled="False">
		...
	</telerik:RadGanttView>
{{endregion}}

### ScrollStep

The default value that is set to the __ScrollStep__ property is equal to 5px. This value determines how many pixels will be skipped while dragging the appointments.

The next code snippet demonstrates how to change the scrolling step in order to make the auto scrolling speed two times faster than its default value:

#### __[XAML] Example 2: Increase ScrollStep__
{{region xaml-radganttview-features-autoscrolling-2}}
	<telerik:RadGanttView telerik:ScrollingSettingsBehavior.ScrollStep="10">
		…
	</telerik:RadGanttView>
{{endregion}}

### ScrollStepTime

__ScrollStepTime__ sets the time interval between the scroll steps of the auto scrolling feature. The default value of this property is 0.01 sec and it could be set to any TimeSpan value.

The next code snippet demonstrates how to set the scroll time interval to half a second:

#### __[XAML] Example 3: Increase Scroll Step Time Interval__
{{region xaml-radganttview-features-autoscrolling-3}}
	<telerik:RadGanttView telerik:ScrollingSettingsBehavior.ScrollStepTime="00:00:00.5">
		…
	</telerik:RadGanttView>
{{endregion}}

### ScrollAreaPadding

By setting __ScrollAreaPadding__ you can customize at which point the auto scrolling functionality will start. This property could be set in the same manner as the Padding property.  Its default value is 30px.

The next example shows how to set the ScrollAreaPadding in order to achieve top/bottom padding of 50px and right/left padding of 100px:

#### __[XAML] Example 4: Increase Scroll Area Padding__
{{region xaml-radganttview-features-autoscrolling-4}}
	<telerik:RadGanttView telerik:ScrollingSettingsBehavior.ScrollAreaPadding="100, 50, 100, 50">
		…
	</telerik:RadGanttView>
{{endregion}}

## See Also

 * [Scrolling]({%slug radganttview-scrolling%})
