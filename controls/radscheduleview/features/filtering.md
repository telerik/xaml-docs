---
title: Filtering
page_title: Filtering
description: Check our &quot;Filtering&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-filtering
tags: filtrering
published: True
position: 10
---

# Filtering

The RadScheduleView control enables you to filter its appointments and individual occurrences by passing a predicate to a view definition's **AppointmentFilter** and **OccurrenceFilter** properties. While the AppointmentFilter will filter out the appointments which fulfil the predicate's condition, the OccurrenceFilter will check each individual occurence (including exceptions) of an recurring appointment.

## AppointmentFilter

The following filter will exclude all appointments whose start date is not today.

#### [C#] Example 1: Define the appointments filter predicate

<snippet id='radscheduleview-features-filtering-block_1-cs' />

#### [XAML] Example 2: Set a definition's AppointmentFilter property

<snippet id='radscheduleview-features-filtering-block_2-xaml' />

## OccurenceFilter

The filter demonstrated in **examples 3 and 4** will exclude all occurences whose total duration is more than one hour.

>The OccurenceFilter is useful when you need to exclude only certain occurrences/exceptions of any recurring appointment.

#### [C#] Example 3: Define the occurences filter predicate

<snippet id='radscheduleview-features-filtering-block_3-cs' />

#### [XAML] Example 4: Set a definition's AppointmentFilter property

<snippet id='radscheduleview-features-filtering-block_4-xaml' />

## See Also

* [Understanding Appointments]({%slug radscheduleview-getting-started-add-edit-delete-appointment%})
* [Recurrence]({%slug radscheduleview-features-recurrences-overview%})
* [Custom Appointments]({%slug radscheduleview-features-appointments-custom-appointment%})