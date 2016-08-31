---
title: Commands
page_title: Commands
description: Commands
slug: raddatetimepicker-commands
tags: commands, close, today
published: True
position: 8
---

# Commands

This article provides an information about the following commands that __RadDateTimePicker__ exposes through  the __RadDateTimePickerCommands__ static class:

* [SetToday Command](#settoday)

* [Close Command](#close)

## SetToday

Using the __SetToday__ command the current date of __RadDateTimePicker__ could be set to today.

In __Example 1__ a __Button__ is linked to the __RadDateTimePickerCommands.SetToday__ command - after execution the date of __RadDateTimePicker__ will be set to today date:

#### __[XAML] Example 1: SetToday command__

{{region xaml-raddatetimepicker-commands_0}}
	<telerik:RadDateTimePicker x:Name="dateTimePicker1" />
	<telerik:RadButton Command="{x:Static telerik:RadDateTimePickerCommands.SetToday}" 
					   CommandTarget="{Binding ElementName=dateTimePicker1}" 
					   Content="Set Today"/>
{{endregion}}

## Close

The __Close__ command closes the drop down part of __RadDateTimePicker__ if it is opened.

__Example 2__ demonstrates how to close the drop down of __RadDateTimePicker__ by executing the __Close__ command:

#### __[C#] Example 2: Close command__

{{region cs-raddatetimepicker-commands_1}}
	RadDateTimePickerCommands.Close.Execute(null, this.dateTimePicker1);
{{endregion}}

# See Also

 * [Date Selection Modes]({%slug raddatetimepicker-features-date-selection-modes%})

 * [Selection]({%slug raddatetimepicker-features-selection%})
 
 * [TodayButton]({%slug raddatetimepicker-todaybutton%})
