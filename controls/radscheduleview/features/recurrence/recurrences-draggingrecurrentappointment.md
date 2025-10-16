---
title: Dragging a Recurrent Appointment
page_title: Dragging a Recurrent Appointment
description: Check our &quot;Dragging a Recurrent Appointment&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-recurrences-draggingrecurrentappointment
tags: dragging,a,recurrent,appointment
published: True
position: 4
---

# Dragging a Recurrent Appointment

Using the drag-drop functionality of __RadScheduleView__, you can drag an occurrence of a recurrent appointment as well as the whole series.  This help article will explain how __RadScheduleView__ handles the case when a whole series is dragged.

First, let’s have the following recurrent appointment added to the AppointmentsSource of __RadScheduleView__ (a recurrent appointment which occurs on every Monday and Wednesday):



```C#
	var reviewApp = new Appointment()
	{
	     Subject = "Review",
	     Start = new DateTime(2013,9,30,9,0,0),
	     End = new DateTime(2013,9,30,9,30,0)
	};
	reviewApp.RecurrenceRule = new RecurrenceRule(
	     new RecurrencePattern()
	     {
	        Frequency = RecurrenceFrequency.Weekly,
	        DaysOfWeekMask = RecurrenceDays.Monday | RecurrenceDays.Wednesday,
	        MaxOccurrences = 10
	      }
	);
```

>tipYou could check [here]({%slug radscheduleview-features-recurrences-overview%}) for more details about recurrent appointments.

If the user drags and drops a single occurrence of this appointment:

![radscheduleview features recurrence 3](images/radscheduleview_features_recurrence3.png)

The following dialog pops up:

![radscheduleview features recurrence 1](images/radscheduleview_features_recurrence1.png)

* Choosing  “Edit only the selected occurrence(s)” option creates [an exception of the recurrence rule]({%slug radscheduleview-features-recurrences-recurrencerule%}):

![radscheduleview features recurrence 4](images/radscheduleview_features_recurrence4.png)

* Choosing “Drag the series” option expands the dialog with more options:

![radscheduleview features recurrence 2](images/radscheduleview_features_recurrence2.png)

>When the Recurrence pattern panel is expanded, the current recurrence days are selected, not the days where the series is dropped.

Note that when dragging the whole series, only the series Start and End times will be updated by default.

So, in this case, if you leave the recurrence pattern like this and confirm the dialog, the result will be the following:

![radscheduleview features recurrence 7](images/radscheduleview_features_recurrence7.png)

The date of the appointment is updated, however since it occurs only on Monday and Wednesday, its first occurrence is on Wednesday.

If you want to move the series with one day, so that the appointment occurs on Tuesday and Thursday instead of Monday and Wednesday, you should edit the days of the recurrence pattern as well:

![radscheduleview features recurrence 5](images/radscheduleview_features_recurrence5.png)

And here is the end result:

![radscheduleview features recurrence 6](images/radscheduleview_features_recurrence6.png)

## See Also

 * [Overview]({%slug radscheduleview-features-recurrences-overview%})

 * [RecurrencePattern]({%slug radscheduleview-features-recurrences-recurrencepattern%})

 * [RecurrenceRule]({%slug radscheduleview-features-recurrences-recurrencerule%})
