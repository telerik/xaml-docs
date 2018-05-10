---
title: Commands
page_title: Commands
description: Commands
slug: radscheduleview-features-commands
tags: commands
published: True
position: 9
---

# Commands

__RadScheduleView__ exposes its functionality through various commands that can be executed on its behalf. All commands are placed in the static class __RadScheduleViewCommands__. The purpose of this tutorial is to show you all of the commands exposed by the __RadScheduleViewCommands__ class and how to execute them.

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

When you want to create a new appointment and show the EditAppointmentDialog, then you need to use the __CreateAppointment__ or __CreateAppointmentWithDialog__ commands. If no parameter is passed, the __SelectedSlot__ of __RadScheduleView__ will be used for the new appointment start and end dates. If you want to explicitly specify which will be the start and end date you should pass a parameter of type __IDateSpan__ (for example Slot is an __IDateSpan__).

The difference between both commands is when neither the parameter nor the __SelectedSlot__ is set. In this case only the __CreateAppointmentWithDialog__ command will show EditAppointmentDialog for the first visible slot, while __CreateAppointment__ command won’t be executed.

#### __C#__  
{{region radscheduleview-features-commands_0}}
	RadScheduleViewCommands.CreateAppointment.Execute(null, ScheduleView);
	RadScheduleViewCommands.CreateAppointmentWithDialog.Execute(null, ScheduleView);
{{endregion}}

## CreateInlineAppointment Command

Use it when you want to create a new appointment via the inline editing. If no parameter is passed, the __SelectedSlot__ of __RadScheduleView__ will be used for the new appointment start and end dates. If you want to explicitly specify which will be the start and end date you should pass a parameter of type __IDateSpan__ (for example __Slot__ is an __IDateSpan__):

#### __C#__   
{{region radscheduleview-features-commands_1}}
	RadScheduleViewCommands.CreateInlineAppointment.Execute(null, ScheduleView);
{{endregion}}

>IsInlineEditingEnabled property of the RadScheduleView should be set in order to use the command.     		

## EditAppointment Command

Use it when you want to show the edit dialog for an appointment. If no parameters are passed it uses the __SelectedAppointment__ of __RadScheduleView__. By default this command is bound to double click on appointment.

#### __C#__  
{{region radscheduleview-features-commands_2}}
	RadScheduleViewCommands.EditAppointment.Execute(null, ScheduleView);
{{endregion}}

## DeleteAppointment Command

When you want to remove an appointment from __AppointmentsSource__ collection, then you need to use the __DeleteAppointment__ command. If no parameter is passed the __SelectedAppointment__ will be used.

#### __C#__  
{{region radscheduleview-features-commands_3}}
	RadScheduleViewCommands.DeleteAppointment.Execute(null, ScheduleView);
{{endregion}}

## EditRecurrenceRule Command

When you want to open EditRecurrenceDialog, then you need to use the __EditRecurrenceRule__ command. This command is used mainly in EditAppointmentDialog. 

## DeleteRecurrenceRule Command

When you want to remove the recurrence, then you need to use __DeleteRecurrenceRule__ Command. The command is used mainly in EditRecurrenceDialo

## EditParentAppointment Command

If you want to edit the master appointment, when the user has initiated editing of an occurrence or exception from appointment's RecurrenceRule, you need to use the __EditParentAppointment__ command. This command is used mainly in EditAppointmentDialog.

## SetDayViewMode Command

Executing this command will result in setting the RadScheduleView’s __ActiveViewDefinition__ property to __DayViewDefinition__.

#### __C#__  
{{region radscheduleview-features-commands_4}}
	RadScheduleViewCommands.SetDayViewMode.Execute(null, ScheduleView);
{{endregion}}

## SetWeekViewMode Command

Executing this command will result in setting the RadScheduleView's __ActiveViewDefinition__ property to __WeekViewDefinition__.

#### __C#__  
{{region radscheduleview-features-commands_5}}
	RadScheduleViewCommands.SetWeekViewMode.Execute(null, ScheduleView);
{{endregion}}

## SetMonthViewMode Command

Executing this command will result in setting the RadScheduleView's __ActiveViewDefinition__ property to __MonthViewDefinition__.

#### __C#__  
{{region radscheduleview-features-commands_6}}
	RadScheduleViewCommands.SetMonthViewMode.Execute(null, ScheduleView);
{{endregion}}

## SetTimelineViewMode Command

Executing this command will result in setting the RadScheduleView's __ActiveViewDefinition__ property to __TimelineViewDefinition__.

#### __C#__
{{region radscheduleview-features-commands_7}}
	RadScheduleViewCommands.SetTimelineViewMode.Execute(null, ScheduleView);
{{endregion}}

## IncreaseVisibleDateLarge /  DecreaseVisibleDateLarge Commands

Increases/decreases the first visible date with n months or days, where n is the value of the __LargeChangeInterval__ property of the ActiveViewDefinition. Executing this command is equivalent to changing the displayed days using the navigation buttons.

#### __C#__
{{region radscheduleview-features-commands_8}}
	RadScheduleViewCommands.IncreaseVisibleDateLarge.Execute(null, ScheduleView);
	RadScheduleViewCommands.DecreaseVisibleDateLarge.Execute(null, ScheduleView);
{{endregion}}

## SetAppointmentImportance Command

When you want to set the Appointment's Importance property, then you need to execute the __SetAppointmentImportance__ command. This command is used primely in EditAppointmentDialog.

## GoToPreviousAppointment / GoToNextAppointment Commands

Use these commands when you want to navigate to the previous/next appointment outside the visible range:

#### __C#__  
{{region radscheduleview-features-commands_9}}
	RadScheduleViewCommands.GoToPreviousAppointment.Execute(null, ScheduleView);
	RadScheduleViewCommands.GoToNextAppointment.Execute(null, ScheduleView);
{{endregion}}

## SetToday Command

You can use the __SetToday__ command to navigate to the current day in the active view definition.

#### __C#__  
{{region radscheduleview-features-commands_10}}
	RadScheduleViewCommands.SetToday.Execute(null, ScheduleView);
{{endregion}}
