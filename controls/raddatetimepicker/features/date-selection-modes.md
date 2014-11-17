---
title: Date Selection Modes
page_title: Date Selection Modes
description: Date Selection Modes
slug: raddatetimepicker-features-date-selection-modes
tags: date,selection,modes
published: True
position: 1
---

# Date Selection Modes

If you want to modify the representation of the items located in the Calendar view of your __RadDateTimePicker__ control you can use the __DateSelectionMode__ property. 

The __DateSelectionMode__ specifies whether the calendar in the __RadDateTimePicker__ control will select days, months or years. The possible values are correspondingly:

* __Day__ - this is the default value and will let you select a day. Using this selection mode you can still browse the calendar - selecting the month you will go into another view where you can directly select another month. The behavior is the same for years, too. 

* __Month__ - lets you select a specific month. Using this selection mode you will limit the input to a single month only. This means that you will not be able to browse through a specific month's days.

* __Year__ - lets you select a year. This selection mode limits the input to years only, i.e. you will not be able to browse months and days.

>These date selection modes are only for the control's Calendar view and don't refer in any way to the Clock view. The default __RadDateTimePicker__ control will include both of the views and if you prefer to have only one of them you can do that by changing the control's input mode. [Read more here.]({%slug raddatetimepicker-features-input-modes%})

You can change the value of the __DateSelectionMode__ property in XAML as shown in this snippet:

#### __XAML__

{{region raddatetimepicker-features-date-selection-modes_0}}
	<telerik:RadDateTimePicker InputMode="DatePicker" DateSelectionMode="Month"/>
{{endregion}}

This example will achieve the following:

* Remove the clock view by explicitly changing the __RadDateTimePicker's__ default input mode to DatePicker.

* Modify the date item's representation in the calendar.

Here is the result:

![](images/dateTimePicker_features_date_selection_modes_010.png)

# See Also

 * [Overview]({%slug raddatetimepicker-overview%})

 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})

 * [Input Modes]({%slug raddatetimepicker-features-input-modes%})

 * [Selection]({%slug raddatetimepicker-features-selection%})

 * [Formatting]({%slug raddatetimepicker-features-formatting%})
