---
title: Appointment Extensions
page_title: Appointment Extensions
description: Appointment Extensions
slug: radscheduleview-features-appointment-extensions
tags: appointment,extensions
published: True
position: 2
---

# Appointment Extensions

The **AppointmentExtensions** class in the **Telerik.Windows.Controls.ScheduleView** namespace provides you with a number of useful extension methods for working with appointments. Here's a list of them:

* **GetOccurrences(this IAppointment appointment, DateTime from, DateTime to)**: Gets the occurances of an appointment for a given interval.

* **GetOccurrencesWithoutExceptionsFromDateTimeRange(this IAppointment appointment, DateTime from, DateTime to)**: Gets the occurances of an appointment for a given interval without the exceptions from the recurrence rule.

* **IsAllDay(this IAppointment appointment)**: Determines whether the specified appointment is an all-day appointment.

* **GetOccurences(this IEnumerable<IAppointment> source, IDateSpan span)**: Returns a collection of occurrences from a set of appointments for a given interval with all exceptions from the recurrence rule. The final collection of occurences is sorted by their **Start** property.

## See Also

 * [Custom Appointment]({%slug radscheduleview-features-appointments-custom-appointment%})
 * [Implementing View-ViewModel]({%slug radscheduleview-populating-with-data-implementing-view-model%})