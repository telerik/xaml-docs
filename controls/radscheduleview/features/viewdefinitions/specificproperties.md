---
title: View Specific Properties
page_title: View Specific Properties
description: This article lists and explains the properties which are specific for a particular ViewDefinition.
slug: radscheduleview-viewdefinitions-specificproperties
tags: view,specific,properties
published: True
position: 2
---

# View Specific Properties

>You can check the [Configuration]({%slug radscheduleview-viewdefinitions-configuration%}) article for more information about the properties that are common for all views.              

## DayView and WeekView Specific Properties

Some ViewDefinitions have specific properties. Here is a list of specific properties for DayView and WeekView:       

* __EnableSmallAppointmentRendering__: Gets or sets whether appointments with duration smaller than MinorTickLength will be rounded to MinorTickLength. 

>When __EnableSmallAppointmentRendering__ is enabled, RadScheduleView will display the appointments with zero duration inside DayViewDefinition and WeekViewDefinition.

* __ShowWeekGroupHeaders__: Gets or sets whether the WeekHeaders should be visible.

* __WeekGroupHeaderStringFormat__: Gets or sets the format that will be applied to the WeekHeaders. After setting the __ShowWeekGroupHeaders__ to __True__ you can customize the string format of the week numbers displayed in the Header.        

	The following code snippet shows how to set the __ShowWeekGroupHeaders__ and __WeekGroupHeaderStringFormat__ property in WeekView:        

	```XAML
		<telerik:RadScheduleView x:Name="scheduleView" AppointmentsSource="{Binding Appointments}">
			<telerik:RadScheduleView.ViewDefinitions>
				<telerik:WeekViewDefinition ShowWeekGroupHeaders="True" WeekGroupHeaderStringFormat="Week number {0}, {1:D}" />
			</telerik:RadScheduleView.ViewDefinitions>
		</telerik:RadScheduleView>
	```

	```C#
		weekDefinition.ShowWeekGroupHeaders = true;
		weekDefinition.WeekGroupHeaderStringFormat = "Week number {0}, {1:D}";
	```

	![RadScheduleView with Week Headers](images/scheduleview_features_specific_properties_1.png)

* __ShowAllDayArea__: Gets or sets a value indicating whether the all-day area is visible or not. This area displays appointments which have their **IsAllDayEvent** property set to **True**.

	![RadScheduleView AllDayArea](images/scheduleview_features_specific_properties_4.png)

## MonthView specific properties

The MonthView has a single specific property:

__AllowCustomAppointmentSize__ (available as of Q2 2014 in UI for WPF – sets whether the appointments with custom size can be displayed in the MonthViewDefinition. By default __AllowCustomAppointmentSize__ is set to __False__.

![radscheduleview set appointment size](images/radscheduleview_how_to_set_custom_appointment_heights.png)

>You can check the [Set Custom Appointment Height]({%slug radscheduleview-howto-set-custom-appointment-height%}) article for more details on how to implement appointments with custom height in MonthViewDefinition.

## TimelineView specific properties

Here is a list of the properties that are specific for TimelineView:

* [StretchAppointments](#stretchappointments)

* [ApplyStartEndTimeToEachDay](#applystartendtimetoeachday)

* [TimeRulerGroupStringFormat](#timerulergroupstringformat)

### StretchAppointments

It sets whether the appointments will be stretched to fill all available space in the TimeSlot - by default it is set to __False__.

```XAML
	<telerik:RadScheduleView x:Name="scheduleView" AppointmentsSource="{Binding Appointments}">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:TimelineViewDefinition StretchAppointments="True" />
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
```

![scheduleview features specific properties 2](images/scheduleview_features_specific_properties_2.png)

### ApplyStartEndTimeToEachDay

When the __DayStartTime__ and __DayEndTime__ properties are set to the TimelineViewDefinition, the __DayStartTime__ property gets applied only for the first day of the displayed range of days, while the __DayEndTime__ only for the last one. In order to apply them for each day of the VisibleDays range, the __ApplyStartEndTimeToEachDay__ property (introduced in Q1 2016 of UI for WPF needs to be set to __True__. The __ApplyStartEndTimeToEachDay__ is of type bool - its default value is __False__.

The following example illustrates how to set the DayStartTime, DayEndTime and ApplyStartEndTimeToEachDay for the TimelineView:

```XAML
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:TimelineViewDefinition DayStartTime="13:00:00" DayEndTime="14:30:00" ApplyStartEndTimeToEachDay="True"/>
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
```

```C#
	timelineDefinition.DayStartTime = new TimeSpan(13, 00, 0);
	timelineDefinition.DayEndTime = new TimeSpan(14, 30, 0);
	timelineDefinition.ApplyStartEndTimeToEachDay = true;
```
```VB
	timelineDefinition.DayStartTime = New TimeSpan(13, 0, 0)
	timelineDefinition.DayEndTime = New TimeSpan(14, 30, 0)
	timelineDefinition.ApplyStartEndTimeToEachDay = True
```


>important Please notice that the __DayStartTime__ property should always be set to a time earlier than the __DayEndTime__, otherwise the start and end times won't be applied for each day.

The final result is shown on the snapshot below:

![scheduleview features specific properties 3](images/scheduleview_features_specific_properties_3.png)

### TimeRulerGroupStringFormat

It sets the format applied on the __TimeRulerGroupItem__.
