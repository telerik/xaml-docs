---
title: Load on Demand
page_title: Load on Demand
description: This article demonstrates how to load only the appointments in the visible range of the RadScheduleView {{ site.framework_name }} control.
slug: scheduleview-features-loadondemand
tags: load,on,demand,with,radscheduleview
published: True
position: 2
---

# Load on Demand

This article demonstrates how you can load the appointments in RadScheduleView depending on the current visible range of the control. This can be very useful in scenarios where the number of appointments is very large.

There are two possible approaches to accomplish this:

**1.** Using the __VisibleRangeChanged__ event.

**2.** Using the __VisibleRangeChangedCommand__ and __VisibleRangeChangedCommandParameter__ properties. This approach is effective if you wish to load the visible appointments in an MVVM-friendly manner.

## Using the VisibleRangeChanged Event

To accomplish this approach, you only need to handle the VisibleRangeChanged and create a helper method to get the appointments for a particular **DateSpan**. Please note that you need to start with an initial collection of appointments.

__Example 1: Handling the VisibleRangeChanged event__

<snippet id='radscheduleview-features-scheduleview-loadondemand-block_1-cs' />
<snippet id='radscheduleview-features-scheduleview-loadondemand-block_2-vb' />

## Using the VisibleRangeChangedCommand

Alternatively, if you want to follow the MVVM pattern, you can create an appropriate command in your viewmodel and set it as the **VisibleRangeChangedCommand** of the RadScheduleView control.

For example, you can define your viewmodel as shown in **Example 2**.

__Example 2: The ViewModel class__

<snippet id='radscheduleview-features-scheduleview-loadondemand-block_3-cs' />
<snippet id='radscheduleview-features-scheduleview-loadondemand-block_4-vb' />

You can now bind the __VisibleRangeChangedCommand__ and __VisibleRangeChangedCommandParameter__ properties as demonstrated in **Example 3**.

__Example 3: Binding the VisibleRangeChangedCommand and VisibleRangeChangedCommandParameter properties__

<snippet id='radscheduleview-features-scheduleview-loadondemand-block_5-xaml' />

## See Also

* [Events]({%slug radscheduleview-events-overview%})
* [Implementing View-ViewModel]({%slug radscheduleview-populating-with-data-implementing-view-model%})