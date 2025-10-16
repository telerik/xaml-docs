---
title: How to Show Only Month in Calendar Header of RadDateTimePicker
description: Display month without year in the RadDateTimePicker and RadDatePicker controls.
page_title: Show Selected Month in Calendar Part of DateTimePicker
type: how-to
slug: kb-datetimepicker-show-only-month-in-calendar-header
position: 0
tags: calendarstyle,selection
ticketid: 497440
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadDateTimePicker for WPF</td>
	</tr>
</table>

## Description

How to show only the month of the selected date in the calendar's header of RadDateTimePicker.

## Solution

Set the MonthViewHeaderFormat property of the RadCalendar control. You can do this via the CalendarStyle property of RadDateTimePicker.


```XAML
	<telerik:RadDateTimePicker>
		<telerik:RadDateTimePicker.CalendarStyle>
			<Style TargetType="telerik:RadCalendar">
				<Setter Property="MonthViewHeaderFormat" Value="MMMM" />
			</Style>
		</telerik:RadDateTimePicker.CalendarStyle>
	</telerik:RadDatePicker>
```

![Before and after the style](images/kb-datetimepicker-show-only-month-in-calendar-header-0.png)
	
> The same approach applies to RadDatePicker.
