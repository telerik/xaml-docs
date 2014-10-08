---
title: Changes
page_title: Changes
description: Changes
slug: radscheduleview-changes
tags: changes
published: True
position: 1
---

# Changes

This article describes the release history of the control.

For the complete Release History of RadControls for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} go to {% if site.site_name == 'Silverlight' %}[What's New Section](http://www.telerik.com/products/silverlight/whats-new.aspx){% endif %}{% if site.site_name == 'WPF' %}[What's New Section](http://www.telerik.com/products/wpf/whats-new.aspx){% endif %}.

## Q1 2014

### What's New

* Make property to remove easily the delete button from the appointment

### What's Fixed

* DialogClosing event is fired more than once

{% if site.site_name == 'Silverlight' %}
* Cancel deletion for recurrent tasks in some themes doesn't work
{% endif %}

## Q3 2013

### What's New

* Provide way to change the recurrent pattern when dragging appointment or a notification message that this can't be done this way                

### What's Fixed

* Allow to set ToolTips on SpecialSlots in RadScheduleView                

* Unable to use DatePicker's keyboard navigation in ScheduleView                

* AppointmentSaving event is fired when opening the EditAppointmentDialog, if previously in AppointmentSaving the e.Cancel = true                

* Special slots tooltip is not visible in Windows8Touch theme                

* When used the constructor with Null set to DaysOfMonth property and get the iCal after this, the rule line end with "BYMONTHDAY=".                

* Weekly recurring appointment series do not update correctly when they are dragged/resized.

* Exception is thrown in the VS 2010 designer.                

* If the RecurrencePattern's DaysOfMonth is set to null upon opening the edit recurrence dialog a NullReferenceException is thrown                

## Q2 2013

### What's New

* Make the new constructor of the AppointmentDialogViewModel public                

* Delete obsoleted InvertedBooleanConverter from RadScheduleView                

* The delete button is showing on selection in order to be clickable with touch                

### What's Fixed

* When the user tries to drag an appointment inside a read-only slot, RadScheduleView does not accept any drop from external source anymore                

* PropertyChanged event of the RecurrencePattern is not fired when its properties are changed                

* When the DayStartTime and DayEndTime properties of the TimelineViewDefinition are changed dynamically the slots are not measured properly                

* The application hangs when resizing it                

* OccurrenceFilter property is not updating the view of RadScheduleView if it is changed at run-time                

* NavigationHeader has wrong Height in Windows8 theme                

* An ArgumentOutOfRangeException is thrown when the CurrentDate is set to MinValue and you click on the empty group header                

* Border is missing on today slot in the Windows8Touch theme of RadScheduleView                

* Adding a Slot with End = DateTime MaxValue to the SpecialSlotsSource collection of the ScheduleView raises an exception                

## Q1 2013

### What's New

* Add OccurrenceFilter property

* Add ToolTipStyle property

* Provide a way to make the row expand automatically in MonthViewDefinition when there are more appointments 

### What's Fixed

* ScheduleView should not use the Local time zone for its internal calculations

* When adding an appointment with Start = End, the appointment is added to the appointment source, but it is not displayed on the ScheduleView

* When importing all day recurring appointments they are not displayed in DayView and WeekView

* The ICal importer throws DateTimeParse exception for recurrent all day appointments exported by Google Calendar 

* When the FirstVisibleGroup property is set to a group with no TimeZone set, an exception is thrown 

* VisibleRangeChanged event is triggered more times when initially loading the control and have ActiveViewDefinitionIndex set

* When changing Start/End time of an appointment in EditRecurrenceDialog, these properties are not updated in EditAppointmentDialog 

* Inconsistency between DAILY and BYDAY attributes when importing ICal appointments 

* Dragging 2 appointments from different resources adds both resources to one of the appointments 

* Appointments are not displayed when changing the theme runtime in TimelineViewDefinition

* CustomAppointmentItemTemplate is not applied when changing from DayView to other Views 

* When the start time of the day in DayView is bigger than the start time of the all day appointment, the appointment is missing 

* When increasing the start time of an appointment in the EditAppointmentDialog, the end time should be automatically increased

* RadScheduleView raises ArgumentException in TimelineViewDefinition when VisibleDays="1" and the day duration is shorter than the DayStartTime

* When the Focus in the control clicking on a Hyperlink causes InvalidOperationException 

* ScrollTimeRuler method does not behave as expected when changing from MonthView to Day/WeekView 

* Delete obsoleted InvertedBooleanConverter from ScheduleView 

* Error when recurrence appointment start is equal to start time of view