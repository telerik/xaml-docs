---
title: How to Set the First Day of the Week
page_title: How to Set the First Day of the Week
description: Check our &quot;How to Set the First Day of the Week&quot; documentation article for the RadDateTimePicker {{ site.framework_name }} control.
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

__Example 1: RadDateTimePicker definition__

```XAML
	<telerik:RadDateTimePicker x:Name="radDateTimePicker"/>
```

You can then set the **FirstDayOfWeek** property of the current culture's **DateTimeFormat** as demonstrated in **Example 2**.

__Example 2: Setting FirstDayOfWeek__

```C#
	CultureInfo cultureInfo = new CultureInfo("en-US");
	cultureInfo.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Friday;
	this.radDateTimePicker.Culture = cultureInfo;
```
```VB.NET
	Dim cultureInfo As New CultureInfo("en-US")
	cultureInfo.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Friday
	Me.radDateTimePicker.Culture = cultureInfo
```

## Through the CalendarStyle property

Another way to achieve the same result is to define a style targeting the **RadCalendar** control and add a setter for the **FirstDayOfWeek** property. **Example 3** demonstrates such a style.

__Example 3: Defining a custom RadCalendar style__

```XAML
	<Style x:Key="CalendarStyle" TargetType="telerik:RadCalendar">
		<Setter Property="FirstDayOfWeek" Value="Friday" />
	</Style>
```

>If you're using [implicit styles]({%slug implicit-styles-styling-the-controls%}), you should base your style on the __RadCalendarStyle__.

You can then use this style implicitly or set it for a single RadDateTimePicker instance through the control's **CalendarStyle** property as shown in **Example 4** and **Example 5**.

__Example 4: Defining an implicit style__

```XAML
	<Style TargetType="telerik:RadDateTimePicker">
		<Setter Property="CalendarStyle" Value="{StaticResource CalendarStyle}" />
	</Style>
```

>If you're using [implicit styles]({%slug implicit-styles-styling-the-controls%}), you should base your style on the __RadDateTimePickerStyle__.

__Example 5: Setting an individual calendar's CalendarStyle property__

```XAML
	<telerik:RadDateTimePicker CalendarStyle="{StaticResource CalendarStyle}" />
```

**Figure 1** shows the final result.

#### __Figure 1: RadDateTimePicker with week starting from Friday__

![RadDateTimePicker with week starting from Friday](images/dateTimePicker_how_to_set_first_week_day_calendar_010.png)

## See Also

 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})

 * [Formatting]({%slug raddatetimepicker-features-formatting%})

 * [Date Items]({%slug raddatetimepicker-features-date-items%})

 * [How to create a select-only RadDateTimePicker]({%slug raddatetimepicker-how-to-select-only-picker%})
