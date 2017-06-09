---
title: How to Set the First Day of the Week
page_title: How to Set the First Day of the Week
description: How to Set the First Day of the Week
slug: raddatetimepicker-how-to-set-first-day-calendar
tags: how,to,set,the,first,day,of,the,week
published: True
position: 2
---

# How to Set the First Day of the Week

The purpose of this tutorial is to show you how to modify the default order of the days in the calendar view of your __RadDateTimePicker__ control. There are two ways to do this, respectively:

* [Through the CultureInfo.DateTimeFormat property](#through-the-cultureinfodatetimeformat-property)
* [Through the CalendarStyle property](#through-the-calendarstyle-property)

## Through the CultureInfo.DateTimeFormat property

Let's assume you've defined RadDateTimePicker as shown in **Example 1**.

#### __[XAML] Example 1: RadDateTimePicker definition__

{{region xaml-raddatetimepicker-how-to-set-first-day-calendar_0}}
	<telerik:RadDateTimePicker x:Name="radDateTimePicker"/>
{{endregion}}

You can then set the **FirstDayOfWeek** property of the current culture's **DateTimeFormat** as demonstrated in **Example 2**.

#### __[C#] Example 2: Setting FirstDayOfWeek__

{{region cs-raddatetimepicker-how-to-set-first-day-calendar_1}}
	CultureInfo cultureInfo = new CultureInfo("en-US");
	cultureInfo.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Friday;
	this.radDateTimePicker.Culture = cultureInfo;
{{endregion}}

#### __[VB.NET] Example 2: Setting FirstDayOfWeek__

{{region vb-raddatetimepicker-how-to-set-first-day-calendar_2}}
	Dim cultureInfo As New CultureInfo("en-US")
	cultureInfo.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Friday
	Me.radDateTimePicker.Culture = cultureInfo
{{endregion}}

## Through the CalendarStyle property

Another way to achieve the same result is to define a style targeting the **RadCalendar** control and add a setter for the **FirstDayOfWeek** property. **Example 3** demonstrates such a style.

#### __[XAML] Example 3: Defining a custom RadCalendar style__

{{region xaml-raddatetimepicker-how-to-set-first-day-calendar_3}}
	<Style x:Key="CalendarStyle" TargetType="telerik:RadCalendar">
		<Setter Property="FirstDayOfWeek" Value="Friday" />
	</Style>
{{endregion}}

>If you're using [implicit styles]({%slug implicit-styles-styling-the-controls%}), you should base your style on the __RadCalendarStyle__.

You can then use this style implicitly or set it for a single RadDateTimePicker instance through the control's **CalendarStyle** property as shown in **Example 4** and **Example 5**.

#### __[XAML] Example 4: Defining an implicit style__

{{region xaml-raddatetimepicker-how-to-set-first-day-calendar_4}}
	<Style TargetType="telerik:RadDateTimePicker">
		<Setter Property="CalendarStyle" Value="{StaticResource CalendarStyle}" />
	</Style>
{{endregion}}

>If you're using [implicit styles]({%slug implicit-styles-styling-the-controls%}), you should base your style on the __RadDateTimePickerStyle__.

#### __[XAML] Example 5: Setting an individual calendar's CalendarStyle property__

{{region xaml-raddatetimepicker-how-to-set-first-day-calendar_5}}
	<telerik:RadDateTimePicker CalendarStyle="{StaticResource CalendarStyle}" />
{{endregion}}

**Figure 1** shows the final result.

#### __Figure 1: RadDateTimePicker with week starting from Friday__

![RadDateTimePicker with week starting from Friday](images/dateTimePicker_how_to_set_first_week_day_calendar_010.png)

## See Also

 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})

 * [Formatting]({%slug raddatetimepicker-features-formatting%})

 * [Date Items]({%slug raddatetimepicker-features-date-items%})

 * [How to create a select-only RadDateTimePicker]({%slug raddatetimepicker-how-to-select-only-picker%})
