---
title: View specific properties
page_title: View specific properties
description: View specific properties
slug: radscheduleview-viewdefinitions-specificproperties
tags: view,specific,properties
published: True
position: 2
---

# View specific properties
<<Comment: For better SEO, the title, description, tags and H1 should all include RadScheduleView.>>
>You can check the [Configuration]({%slug radscheduleview-viewdefinitions-configuration%}) article for more information about the properties that are common for all views.        

## DayView and WeekView specific properties

Some  the ViewDefinitions have specific properties. Here is a list of specific properties for DayView and WeekView:        

* __ShowWeekGroupHeaders__ – get or sets whether the WeekHeaders should be visible.

* __WeekGroupHeaderStringFormat__ – gets or sets the format that will be applied to the WeekHeaders. After setting the __ShowWeekGroupHeaders__ to __True__ you can customize the string format of the week numbers displayed in the Header.        

The following code snippet shows how to set the __ShowWeekGroupHeaders__ and __WeekGroupHeaderStringFormat__ property in WeekView:        

#### __XAML__
{{region radscheduleview-viewdefinition-specificproperties_1}}
	<telerik:RadScheduleView x:Name="scheduleView" AppointmentsSource="{Binding Appointments}">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:WeekViewDefinition ShowWeekGroupHeaders="True" WeekGroupHeaderStringFormat="Week number {0}, {1:D}" />
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
{{endregion}}

#### __C#__
{{region radscheduleview-viewdefinition-specificproperties_2}}
	weekDefinition.ShowWeekGroupHeaders = true;
	weekDefinition.WeekGroupHeaderStringFormat = "Week number {0}, {1:D}";
{{endregion}}

Here is the end result:

![scheduleview features specific properties 1](images/scheduleview_features_specific_properties_1.png)

## MonthView specific properties

Here is a list of the properties that are specific for MonthView:

* __AllowCustomAppointmentSize__ (available with Q2 2014 version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}) – sets whether the appointments with custom size can be displayed in the MonthViewDefinition. By default __AllowCustomAppointmentSize__ is set to False.
<<Comment: In the WeekGroupHeaderStringFormat description you show a value as __True_ and here you just use False. Please pick a standard for the whole article and it the same everywhere. Check with your team which style to use. I have also edited articles today for your team that used **True** and false. >>
![radscheduleview how to set custom appointment heights](images/radscheduleview_how to_set_custom_appointment_heights.png)

>You can check the [Set Custom Appointment Height]({%slug radscheduleview-howto-set-custom-appointment-height%}) article for more details on how to implement appointments with custom height in MonthViewDefinition.

## TimelineView specific properties

Here is a list of the properties that are specific for TimelineView:

* [StretchAppointments](#stretchappointments)

* [ApplyStartEndTimeToEachDay](#applystartendtimetoeachday)

* [TimeRulerGroupStringFormat](#timerulergroupstringformat)

### StretchAppointments

It sets whether the appointments will be stretched to fill all available space in the TimeSlot - by default it is set to False.

#### __XAML__

{{region radscheduleview-viewdefinition-specificproperties_2}}
	<telerik:RadScheduleView x:Name="scheduleView" AppointmentsSource="{Binding Appointments}">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:TimelineViewDefinition StretchAppointments="True" />
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
{{endregion}}

![scheduleview features specific properties 2](images/scheduleview_features_specific_properties_2.png)

### ApplyStartEndTimeToEachDay

When the __DayStartTime__ and __DayEndTime__ properties are set to the TimelineViewDefinition, the __DayStartTime__ property gets applied only for the first day of the displayed range of days, while the __DayEndTime__ only for the last one. In order to apply them for each day of the VisibleDays range the __ApplyStartEndTimeToEachDay__ property (introduced with Q1 2016 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}) needs to be set to True. The __ApplyStartEndTimeToEachDay__ is of type bool - its default value is False.

The following example illustrates how to set the DayStartTime, DayEndTime and ApplyStartEndTimeToEachDay for the TimelineView:

#### __XAML__

{{region radscheduleview-viewdefinitions-configuration_3}}
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:TimelineViewDefinition DayStartTime="13:00:00" DayEndTime="14:30:00" ApplyStartEndTimeToEachDay="True"/>
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
{{endregion}}

#### __C#__

{{region radscheduleview-viewdefinition-configuration_3}}
	timelineDefinition.DayStartTime = new TimeSpan(13, 00, 0);
	timelineDefinition.DayEndTime = new TimeSpan(14, 30, 0);
	timelineDefinition.ApplyStartEndTimeToEachDay = true;
{{endregion}}

#### __VB__

{{region radscheduleview-viewdefinition-configuration_0}}
	timelineDefinition.DayStartTime = New TimeSpan(13, 0, 0)
	timelineDefinition.DayEndTime = New TimeSpan(14, 30, 0)
	timelineDefinition.ApplyStartEndTimeToEachDay = True
{{endregion}}


>important Please notice that the __DayStartTime__ property should always be set to a time earlier than the __DayEndTime__, otherwise the start and end times won't be applied for each day.

The final result is shown on the snapshot below:

![scheduleview features specific properties 3](images/scheduleview_features_specific_properties_3.png)

### TimeRulerGroupStringFormat

It sets the format applied on TimeRulerGroupItem.
<<Comment: This definition doesn't make sense to me. Please provide more explanation.>>
