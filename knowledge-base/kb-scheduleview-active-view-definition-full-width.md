---
title: Stretching Content Size to Maximum Width in RadScheduleView DayViewDefinition
description: Learn how to extend the active view definition's width to use the full-screen width in RadScheduleView for WPF.
type: how-to
page_title: How to Use Full-Screen Width in RadScheduleView DayViewDefinition for WPF
slug: kb-scheduleview-dayviewdefinition-full-width
tags: scheduleview, wpf, dayviewdefinition, stretch, full width
res_type: kb
ticketid: 1671345
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadScheduleView for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2024.4.1111</td>
</tr>
</tbody>
</table>

## Description

How to stretch the view definition to fill the available space of the RadScheduleView control.

## Solution

To extend the content size of the RadScheduleView's active view definition, you can set its `MinTimeRulerExtent` property. This property allows you to set the minimum width of the `TimeRuler` in pixels when the active view definition's `Orientation` property is set to __Horizontal__. This ensures that the view utilizes the entire width.

Here is an example code snippet to achieve the desired behavior:


```XAML
    <telerik:RadScheduleView x:Name="scheduleView" DataContext="{StaticResource MyViewModel}" AppointmentsSource="{Binding MyAppointments}">
        <telerik:RadScheduleView.ViewDefinitions>
            <telerik:DayViewDefinition MinTimeRulerExtent="{Binding ElementName=scheduleView, Path=ActualWidth}"/>
        </telerik:RadScheduleView.ViewDefinitions>
    </telerik:RadScheduleView>
```

For more details on configuring the TimeRuler, refer to the [WPF ScheduleView - TimeRuler Configuration](https://docs.telerik.com/devtools/wpf/controls/radscheduleview/end-user-capabilities/timerulerconfiguration) documentation.

## See Also
- [RadScheduleView Overview](https://docs.telerik.com/devtools/wpf/controls/radscheduleview/overview)
- [RadScheduleView End-User Capabilities](https://docs.telerik.com/devtools/wpf/controls/radscheduleview/end-user-capabilities/overview)
