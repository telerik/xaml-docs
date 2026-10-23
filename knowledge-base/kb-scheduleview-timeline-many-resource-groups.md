---
title: Configure Timeline With Many Resource Groups
description: Choose group header virtualization, row sizing, filtering, and appointment loading settings for a WPF RadScheduleView Timeline with many resources.
type: how-to
page_title: Configure WPF ScheduleView Timeline With Thousands of Resource Groups
components: ["scheduleview"]
slug: kb-scheduleview-timeline-many-resource-groups
position: 0
tags: radscheduleview,timeline,virtualization,resources,groups,row-height,performance
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.3.1007| RadScheduleView |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

Configure a RadScheduleView Timeline with thousands of resource groups. Choose between uniform virtualized rows and content-dependent row sizes, control empty row space, and distinguish resource filtering from appointment loading.

## Solution

For a Timeline view with thousands of resource groups, distinguish the number of groups from the number of appointments. Appointment virtualization does not enable group header virtualization. Loading fewer appointments does not, by itself, reduce the number of resource groups.

Choose the group header virtualization setting according to the required row layout:

| Required layout | Group header virtualization | Sizing constraint |
|---|---|---|
| Uniform resource rows with viewport-based header generation | Set `IsGroupHeadersVirtualizationEnabled` to `True`. | Keep top-level group headers equal in size. Unequal sizes are not supported by this virtualization mode. |
| Resource rows that grow according to their overlapping appointments | Set `IsGroupHeadersVirtualizationEnabled` to `False`. | The nonvirtualized layout calculates group sizes from appointment overlap counts and header size requirements. Appointment virtualization remains enabled, but all group headers are generated. |

Disabling group header virtualization allows content-dependent row sizing, but does not guarantee fast rendering for thousands of groups. Keep header templates lightweight and consider whether users need all resource groups displayed at once.

### Controlling Empty Row Space

Check `StretchGroupHeaders` on the `TimelineViewDefinition`. When this property is `True`, the control distributes unused space among groups. Set it to `False` to avoid that extra space distribution. See the [group header stretching configuration]({%slug radscheduleview-viewdefinitions-configuration%}#stretchgroupheaders).

`StretchAppointments` controls whether appointments fill their available slot space. It does not control group header stretching. See the [Timeline appointment stretching settings]({%slug radscheduleview-viewdefinitions-specificproperties%}#stretchappointments). `MinAppointmentHeight` sets a minimum appointment height, not a fixed height for each resource row. These settings do not remove the equal-size requirement of group header virtualization.

If empty resources do not need to remain visible, use the view definition's [GroupFilter]({%slug radscheduleview-viewdefinitions-configuration%}#groupfilter) to exclude them. Provide a predicate that selects the resources your application needs to display. The control does not automatically hide empty groups. The ScheduleView Grouping and Filtering demo demonstrates resource selection through this predicate. Hiding an empty group removes its row rather than keeping a shorter row available for scheduling.

### Separating Group Count From Appointment Loading

Use [appointment loading by visible date range]({%slug scheduleview-features-loadondemand%}) when the appointment data set is large. `VisibleRangeChanged` and `VisibleRangeChangedCommand` let the application update `AppointmentsSource` for that date range. They do not provide resource-row data virtualization or automatically filter `ResourceTypesSource` as users scroll through groups.

For a Timeline starting point, refer to the ScheduleView `ResourcesUIVirtualization` demo. It enables group header virtualization and supplies 1,000 resources with appointments and special slots. Treat the demo as a configuration example, not a performance guarantee for a larger data set. Measure your application with its actual resource count, appointment overlaps, grouping depth, and templates.

If you need both independently sized resource rows and group header virtualization, the equal-size constraint prevents that combination. Do not rely on forced redraws to make unequal virtualized row sizes supported.

## See Also

* [ScheduleView UI virtualization]({%slug radscheduleview-ui-virtualization%})