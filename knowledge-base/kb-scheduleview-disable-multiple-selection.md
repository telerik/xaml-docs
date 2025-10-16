---
title: Disable Multiple Appointments Selection in RadScheduleView
description: Allow selecting only a single appointment in RadScheduleView with a custom AppointmentSelectionBehavior.
page_title: Cancel Multiselection Appointments in ScheduleView
type: how-to
slug: kb-scheduleview-disable-multiple-selection
position: 0
tags: getselectedappointments,appointmentselectionbehavior
ticketid: 1457125
res_type: kb
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.3.917</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadScheduleView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

Disable multiple appointments selection in RadScheduleView using a custom AppointmentSelectionBehavior.

## Solution

To allow only a single appointment to be selected you can create a custom [AppointmentSelectionBehavior]({%slug radscheduleview-features-appointment-selection-behavior%}) and override its __GetSelectedAppointments__ method.


```C#
	public class CustomAppointmentSelectionBehavior : AppointmentSelectionBehavior
	{
		protected override IEnumerable<IOccurrence> GetSelectedAppointments(AppointmentSelectionState state, IOccurrence target)
		{
			var originalSelection = base.GetSelectedAppointments(state, target);
			if (originalSelection.Count() > 1)
			{
				var lastSelected = originalSelection.Last();
				return new List<IOccurrence>() { lastSelected };
			}
			return originalSelection;
		}
	}
```
