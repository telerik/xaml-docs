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

>You can check [Configuration]({%slug radscheduleview-viewdefinitions-configuration%}) article for more information about the common for all views properties.        

## DayView and WeekView specific properties

Except all the common properties some of the ViewDefinitions have specific properties. Here is a list of such kind of properties for DayView and WeekView:        

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

Here is the list of the properties which are specific for MonthView:

* __AllowCustomAppointmentSize__ (available with Q2 2014 version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}) – sets whether the appointments with custom size can be displayed in the MonthViewDefinition. By default __AllowCustomAppointmentSize__ is set to False.

![radscheduleview how to set custom appointment heights](images/radscheduleview_how to_set_custom_appointment_heights.png)

>You can check the [Set Custom Appointment Height]({%slug radscheduleview-howto-set-custom-appointment-height%}) article for more details on how to impelement appointments with custom height in MonthViewDefinition.

## TimelineView specific properties

There are certain properties which are specific for TimelineView. Here is the list of those properties:

* __StretchAppointments__ – sets whether the appointments will be stretched to fill all available space in the TimeSlot. By default __StretchAppointments__ is set to False.

#### __XAML__

{{region radscheduleview-viewdefinition-specificproperties_2}}
	<telerik:RadScheduleView x:Name="scheduleView" AppointmentsSource="{Binding Appointments}">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:TimelineViewDefinition StretchAppointments="True" />
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
{{endregion}}

![scheduleview features specific properties 2](images/scheduleview_features_specific_properties_2.png)

__TimeRulerGroupStringFormat__ – sets the format applied on TimeRulerGroupItem.
