---
title: Recurrence Dialog Not Shown When SelectedAppointment Is Bound
description: The edit recurrence dialog is not shown on the selected appointment, for which a recurrence rule has been applied.
page_title: Recurrence Dialog is Not Displayed When SelectedAppointment Is Bound
type: troubleshooting
slug: scheduleview-selected-appointment-recurrence
position: 0
tags: scheduleview, recurrence, dialog, selected, appointment
ticketid: 1698811
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2025.3.813</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadScheduleView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The recurrence dialog is not displayed after an appointment has been made recurrent when the `SelectedAppointment` property of `RadScheduleView` is bound.

## Solution

The `SelectedAppointment` property needs to be bound to a property of the type of `IOCcurrence`, in order for the RadScheduleView's dialogs to be opened.

#### __[C#] Setting up the property that will be bound to the SelectedAppointment property__
{{region scheduleview-selected-appointment-recurrence-0}}
    private IOccurrence selectedAppointment;
    public IOccurrence SelectedAppointment
    {
        get { return selectedAppointment; }
        set
        {
            if (value != selectedAppointment)
            {
                selectedAppointment = value;
                OnPropertyChanged(() => this.SelectedAppointment);
            }
        }
    }
{{endregion}}

#### __[XAML] Binding the property to the SelectedAppointment property of RadScheduleView__
{{region scheduleview-selected-appointment-recurrence-1}}
    <telerik:RadScheduleView SelectedAppointment="{Binding SelectedAppointment}"/>
{{endregion}}