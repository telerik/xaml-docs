---
title: How to change an appointment property during runtime
description: Dynamically update appointment in RadScheduleView.
type: how-to
page_title: Change the property of an appointment during runtime
slug: kb-scheduleview-howto-update-appointment-runtime
position: 0
tags: cannot, update, change, appointment, property, radscheduleview
ticketid: 1457064
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadScheduleView for WPF</td>
	</tr>
</table>

## Description

How to update an appointment when it is in the AppointmentSource of the RadScheduleView. 

## Solution

There are two possible approaches:

Calling the __BeginEdit__ method of RadScheduleView before editing and the __Commit__ method after the properties of the appointment are changed.

__Example 1: Updating an appointment via BeginEdit and Commit__
```C#

	this.scheduleView.BeginEdit(appointment);
    appointment.Start = appointment.Start.AddHours(1);
    appointment.End = appointment.End.AddHours(1);
    this.scheduleView.Commit();
```

Manually removing the appointment from the AppointmentsSource before changing its properties and then adding it back.

__Example 2: Updating an appointment via Remove and Add__
```C#

	this.source.Remove(appointment);
    appointment.Start = appointment.Start.AddHours(1);
    appointment.End = appointment.End.AddHours(1);
    this.source.Add(appointment);
```

## See Also  

* [Edit Appointment]({%slug radscheduleview-end-user-capabilities-edit-appointment%})
