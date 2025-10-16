---
title: Hide the Week Numbers in RadDateTimePicker
description: How to hide the week numbers in the calendar of RadDateTimePicker.
type: how-to
page_title: Change the Visibility of the Week Numbers in DateTimePicker's Calendar  
slug: kb-datetimepicker-hide-week-numbers
position: 0
tags: raddatetimepicker, week, numbers, areweeknumbersvisible
ticketid: 0
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.511</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDateTimePicker for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to hide the week numbers in the calendar of RadDateTimePicker.

## Solution

To hide the week numbers, set the __AreWeekNumbersVisible__ property of the RadCalendar control hosted in the RadDateTimePicker. You can do this using the **CalendarStyle** property of RadDateTimePicker.


```XAML
	<telerik:RadDateTimePicker InputMode="DatePicker">
		<telerik:RadDateTimePicker.CalendarStyle>
			<!-- if you use NoXaml dlls set the following property to the Style: BasedOn="{StaticResource RadCalendarStyle}" -->
			<Style TargetType="telerik:RadCalendar">
				<Setter Property="AreWeekNumbersVisible" Value="False" />
			</Style>
		</telerik:RadDateTimePicker.CalendarStyle>
	</telerik:RadDateTimePicker>
```
