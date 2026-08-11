---
title: Commands
page_title: Commands
description: Check our &quot;Commands&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-commands
tags: commands
published: True
position: 9
---

# Commands

`RadScheduleView` exposes its functionality through various commands that can be executed on its behalf. All commands are placed in the static class `RadScheduleViewCommands`. The purpose of this tutorial is to show you all of the commands exposed by the RadScheduleViewCommands class and how to execute them.

* `CreateAppointment / CreateAppointmentWithDialog Commands`
* `CreateInlineAppointment Command`
* `EditAppointment Command`
* `DeleteAppointment Command`
* `EditRecurrenceRule Command`
* `DeleteRecurrenceRule Command`
* `EditParentAppointment Command`
* `SetDayViewMode Command`
* `SetWeekViewMode Command`
* `SetMonthViewMode Command`
* `SetTimelineViewMode Command`
* `IncreaseVisibleDateLarge /  DecreaseVisibleDateLarge Commands`
* `SetAppointmentImportance Command`
* `GoToPreviousAppointment / GoToNextAppointment Commands`
* `SetToday Command`

## CreateAppointment / CreateAppointmentWithDialog Commands

When you want to create a new appointment and show the EditAppointmentDialog, then you need to use the `CreateAppointment` or `CreateAppointmentWithDialog` commands. If no parameter is passed, the `SelectedSlot` of `RadScheduleView` will be used for the new appointment start and end dates. If you want to explicitly specify which will be the start and end date you should pass a parameter of type `IDateSpan` (for example Slot is an IDateSpan).

The difference between both commands is when neither the parameter nor the `SelectedSlot` is set. In this case only the `CreateAppointmentWithDialog` command will show EditAppointmentDialog for the first visible slot, while `CreateAppointment` command won’t be executed.

  
<snippet id='radscheduleview-features-commands-block_1-cs' />

## CreateInlineAppointment Command

Use it when you want to create a new appointment via the inline editing. If no parameter is passed, the `SelectedSlot` of `RadScheduleView` will be used for the new appointment start and end dates. If you want to explicitly specify which will be the start and end date you should pass a parameter of type `IDateSpan` (for example `Slot` is an IDateSpan):

   
<snippet id='radscheduleview-features-commands-block_2-cs' />

>IsInlineEditingEnabled property of the RadScheduleView should be set in order to use the command.     		

## EditAppointment Command

Use it when you want to show the edit dialog for an appointment. If no parameters are passed it uses the `SelectedAppointment` of `RadScheduleView`. By default this command is bound to double click on appointment.

  
<snippet id='radscheduleview-features-commands-block_3-cs' />

## DeleteAppointment Command

When you want to remove an appointment from `AppointmentsSource` collection, then you need to use the `DeleteAppointment` command. If no parameter is passed the `SelectedAppointment` will be used.

  
<snippet id='radscheduleview-features-commands-block_4-cs' />

## EditRecurrenceRule Command

When you want to open EditRecurrenceDialog, then you need to use the `EditRecurrenceRule` command. This command is used mainly in EditAppointmentDialog. 

## DeleteRecurrenceRule Command

When you want to remove the recurrence, then you need to use `DeleteRecurrenceRule` Command. The command is used mainly in EditRecurrenceDialo

## EditParentAppointment Command

If you want to edit the master appointment, when the user has initiated editing of an occurrence or exception from appointment's RecurrenceRule, you need to use the `EditParentAppointment` command. This command is used mainly in EditAppointmentDialog.

## SetDayViewMode Command

Executing this command will result in setting the RadScheduleView’s `ActiveViewDefinition` property to `DayViewDefinition`.

  
<snippet id='radscheduleview-features-commands-block_5-cs' />

## SetWeekViewMode Command

Executing this command will result in setting the RadScheduleView's `ActiveViewDefinition` property to `WeekViewDefinition`.

  
<snippet id='radscheduleview-features-commands-block_6-cs' />

## SetMonthViewMode Command

Executing this command will result in setting the RadScheduleView's `ActiveViewDefinition` property to `MonthViewDefinition`.

  
<snippet id='radscheduleview-features-commands-block_7-cs' />

## SetTimelineViewMode Command

Executing this command will result in setting the RadScheduleView's `ActiveViewDefinition` property to `TimelineViewDefinition`.


<snippet id='radscheduleview-features-commands-block_8-cs' />

## IncreaseVisibleDateLarge /  DecreaseVisibleDateLarge Commands

Increases/decreases the first visible date with n months or days, where n is the value of the `LargeChangeInterval` property of the ActiveViewDefinition. Executing this command is equivalent to changing the displayed days using the navigation buttons.


<snippet id='radscheduleview-features-commands-block_9-cs' />

## SetAppointmentImportance Command

When you want to set the Appointment's Importance property, then you need to execute the `SetAppointmentImportance` command. This command is used primely in EditAppointmentDialog.

## GoToPreviousAppointment / GoToNextAppointment Commands

Use these commands when you want to navigate to the previous/next appointment outside the visible range:

  
<snippet id='radscheduleview-features-commands-block_10-cs' />

## SetToday Command

You can use the `SetToday` command to navigate to the current day in the active view definition.

  
<snippet id='radscheduleview-features-commands-block_11-cs' />

## RestoreOriginalOccurrence Command

You can use the `RestoreOriginalOccurrence` command to revert the exception to the original occurrence.

## SetAgendaViewMode Command

Executing this command will result in setting the RadScheduleView's `ActiveViewDefinition` property to `AgendaViewDefinition`.

## CommitEditAppointment Command

The `CommitEditAppointment` command allows you to commit the currently edited appointment.


<snippet id='radscheduleview-features-commands-block_12-cs' />

## BeginEditAppointment Command

You can use the `BeginEditAppointment` command to begin an editing proccess of an appointment.


<snippet id='radscheduleview-features-commands-block_13-cs' />

## BeginInlineEditing Command

The `BeginInlineEditing` command starts an inline editing process of an appointment.


<snippet id='radscheduleview-features-commands-block_14-cs' />

## CancelEditAppointment Command

The `CancelEditAppointment` allows you to cancel the editting of the current appointment and revert the applied changes.


<snippet id='radscheduleview-features-commands-block_15-cs' />