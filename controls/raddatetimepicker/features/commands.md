---
title: Commands
page_title: Commands
description: Check our &quot;Commands&quot; documentation article for the RadDateTimePicker {{ site.framework_name }} control.
slug: raddatetimepicker-commands
tags: commands, close, today
published: True
position: 8
---

# Commands

This article provides an information about the following commands that __RadDateTimePicker__ exposes through  the __RadDateTimePickerCommands__ static class:

* [SetToday Command](#settoday)

* [Close Command](#close)

## SetToday Command

Using the __SetToday__ command the current date of __RadDateTimePicker__ could be set to the current date (today).

In __Example 1__ a __Button__ is linked to the __RadDateTimePickerCommands.SetToday__ command after whose execution the date will be set to the current day:

__Example 1: SetToday command__

```XAML
	<telerik:RadDateTimePicker x:Name="dateTimePicker1" />
	<telerik:RadButton Command="{x:Static telerik:RadDateTimePickerCommands.SetToday}" 
					   CommandTarget="{Binding ElementName=dateTimePicker1}" 
					   Content="Set Today"/>
```

## Close Command

The __Close__ command closes the drop down part of __RadDateTimePicker__ if it is opened.

__Example 2__ demonstrates how to close the drop down of __RadDateTimePicker__ by executing the __Close__ command:

__Example 2: Close command__

```C#
	RadDateTimePickerCommands.Close.Execute(null, this.dateTimePicker1);
```

## See Also

 * [Date Selection Modes]({%slug raddatetimepicker-features-date-selection-modes%})

 * [Selection]({%slug raddatetimepicker-features-selection%})
 
 * [TodayButton]({%slug raddatetimepicker-todaybutton%})
