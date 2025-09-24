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

* [CreateAppointment / CreateAppointmentWithDialog Commands](#createappointment--createappointmentwithdialog-commands)

* [CreateInlineAppointment Command](#createinlineappointment-command)

* [EditAppointment Command](#editappointment-command)

* [DeleteAppointment Command](#deleteappointment-command)

* [EditRecurrenceRule Command](#editrecurrencerule-command)

* [DeleteRecurrenceRule Command](#deleterecurrencerule-command)

* [EditParentAppointment Command](#editparentappointment-command)

* [SetDayViewMode Command](#setdayviewmode-command)

* [SetWeekViewMode Command](#setweekviewmode-command)

* [SetMonthViewMode Command](#setmonthviewmode-command)

* [SetTimelineViewMode Command](#settimelineviewmode-command)

* [IncreaseVisibleDateLarge /  DecreaseVisibleDateLarge Commands](#increasevisibledatelarge---decreasevisibledatelarge-commands)

* [SetAppointmentImportance Command](#setappointmentimportance-command)

* [GoToPreviousAppointment / GoToNextAppointment Commands](#gotopreviousappointment--gotonextappointment-commands)

* [SetToday Command](#settoday-command)

## CreateAppointment / CreateAppointmentWithDialog Commands

When you want to create a new appointment and show the EditAppointmentDialog, then you need to use the `CreateAppointment` or `CreateAppointmentWithDialog` commands. If no parameter is passed, the `SelectedSlot` of `RadScheduleView` will be used for the new appointment start and end dates. If you want to explicitly specify which will be the start and end date you should pass a parameter of type `IDateSpan` (for example Slot is an IDateSpan).

The difference between both commands is when neither the parameter nor the `SelectedSlot` is set. In this case only the `CreateAppointmentWithDialog` command will show EditAppointmentDialog for the first visible slot, while `CreateAppointment` command won’t be executed.

  
```C#
	RadScheduleViewCommands.CreateAppointment.Execute(null, ScheduleView);
	RadScheduleViewCommands.CreateAppointmentWithDialog.Execute(null, ScheduleView);
```

## CreateInlineAppointment Command

Use it when you want to create a new appointment via the inline editing. If no parameter is passed, the `SelectedSlot` of `RadScheduleView` will be used for the new appointment start and end dates. If you want to explicitly specify which will be the start and end date you should pass a parameter of type `IDateSpan` (for example `Slot` is an IDateSpan):

   
```C#
	RadScheduleViewCommands.CreateInlineAppointment.Execute(null, ScheduleView);
```

>IsInlineEditingEnabled property of the RadScheduleView should be set in order to use the command.     		

## EditAppointment Command

Use it when you want to show the edit dialog for an appointment. If no parameters are passed it uses the `SelectedAppointment` of `RadScheduleView`. By default this command is bound to double click on appointment.

  
```C#
	RadScheduleViewCommands.EditAppointment.Execute(null, ScheduleView);
```

## DeleteAppointment Command

When you want to remove an appointment from `AppointmentsSource` collection, then you need to use the `DeleteAppointment` command. If no parameter is passed the `SelectedAppointment` will be used.

  
```C#
	RadScheduleViewCommands.DeleteAppointment.Execute(null, ScheduleView);
```

## EditRecurrenceRule Command

When you want to open EditRecurrenceDialog, then you need to use the `EditRecurrenceRule` command. This command is used mainly in EditAppointmentDialog. 

## DeleteRecurrenceRule Command

When you want to remove the recurrence, then you need to use `DeleteRecurrenceRule` Command. The command is used mainly in EditRecurrenceDialo

## EditParentAppointment Command

If you want to edit the master appointment, when the user has initiated editing of an occurrence or exception from appointment's RecurrenceRule, you need to use the `EditParentAppointment` command. This command is used mainly in EditAppointmentDialog.

## SetDayViewMode Command

Executing this command will result in setting the RadScheduleView’s `ActiveViewDefinition` property to `DayViewDefinition`.

  
```C#
	RadScheduleViewCommands.SetDayViewMode.Execute(null, ScheduleView);
```

## SetWeekViewMode Command

Executing this command will result in setting the RadScheduleView's `ActiveViewDefinition` property to `WeekViewDefinition`.

  
```C#
	RadScheduleViewCommands.SetWeekViewMode.Execute(null, ScheduleView);
```

## SetMonthViewMode Command

Executing this command will result in setting the RadScheduleView's `ActiveViewDefinition` property to `MonthViewDefinition`.

  
```C#
	RadScheduleViewCommands.SetMonthViewMode.Execute(null, ScheduleView);
```

## SetTimelineViewMode Command

Executing this command will result in setting the RadScheduleView's `ActiveViewDefinition` property to `TimelineViewDefinition`.


```C#
	RadScheduleViewCommands.SetTimelineViewMode.Execute(null, ScheduleView);
```

## IncreaseVisibleDateLarge /  DecreaseVisibleDateLarge Commands

Increases/decreases the first visible date with n months or days, where n is the value of the `LargeChangeInterval` property of the ActiveViewDefinition. Executing this command is equivalent to changing the displayed days using the navigation buttons.


```C#
	RadScheduleViewCommands.IncreaseVisibleDateLarge.Execute(null, ScheduleView);
	RadScheduleViewCommands.DecreaseVisibleDateLarge.Execute(null, ScheduleView);
```

## SetAppointmentImportance Command

When you want to set the Appointment's Importance property, then you need to execute the `SetAppointmentImportance` command. This command is used primely in EditAppointmentDialog.

## GoToPreviousAppointment / GoToNextAppointment Commands

Use these commands when you want to navigate to the previous/next appointment outside the visible range:

  
```C#
	RadScheduleViewCommands.GoToPreviousAppointment.Execute(null, ScheduleView);
	RadScheduleViewCommands.GoToNextAppointment.Execute(null, ScheduleView);
```

## SetToday Command

You can use the `SetToday` command to navigate to the current day in the active view definition.

  
```C#
	RadScheduleViewCommands.SetToday.Execute(null, ScheduleView);
```

## RestoreOriginalOccurrence Command

You can use the `RestoreOriginalOccurrence` command to revert the exception to the original occurrence.

## SetAgendaViewMode Command

Executing this command will result in setting the RadScheduleView's `ActiveViewDefinition` property to `AgendaViewDefinition`.

## CommitEditAppointment Command

The `CommitEditAppointment` command allows you to commit the currently edited appointment.


```C#
	RadScheduleViewCommands.CommitEditAppointment.Execute(appointment, ScheduleView);
```

## BeginEditAppointment Command

You can use the `BeginEditAppointment` command to begin an editing proccess of an appointment.


```C#
	RadScheduleViewCommands.BeginEditAppointment.Execute(appointment, ScheduleView);
```

## BeginInlineEditing Command

The `BeginInlineEditing` command starts an inline editing process of an appointment.


```C#
	RadScheduleViewCommands.BeginInlineEditing.Execute(appointment, ScheduleView);
```

## CancelEditAppointment Command

The `CancelEditAppointment` allows you to cancel the editting of the current appointment and revert the applied changes.


```C#
	RadScheduleViewCommands.CancelEditAppointment.Execute(appointment, ScheduleView);
```