---
title: Key Properties
page_title: Key Properties
description: Key Properties
slug: radcalendar-key-properties
tags: key,properties
published: True
position: 0
---

# Key Properties

The purpose of this help article is to show you the key properties of the __RadCalendar__ control. The topic includes the following sections:

* [Selection Properties](#selection-properties)
* [Styling the Different Views](#styling-the-different-views)
* [Formatting the Headers](#formatting-the-headers)

## Selection Properties

* __SelectionMode__: This property defines how many dates can be selected at once. The possible values are __Single__, __Extended__ and __Multiple__. The default value is __Single__.  

* __SelectedDate__: Gets or sets the currently selected date. If the SelectionMode is set to Multiple or Extended, returns the first date from the SelectedDates.
* __SelectedDates__: Gets the currently selected dates. Useful when the SelectionMode is set to Multiple or Extended.  

* __SelectableDateStart__: Gets or sets the first date that can be selected.
* __SelectableDateEnd__: Gets of sets the last date that can be selected.

* __BlackoutDates__: Gets or sets a collection of dates that cannot be selected

## Setting the Current Display Date

* __DisplayDate__: The property allows you to set the current visible date. This is date which will be displayed when you show the calendar.

#### __[XAML] Example 1: Setting DisplayDate__
{{region radcalendar-keyproperties-0}}
	<telerik:RadCalendar DisplayDate="4/1/2018"/>
{{endregion}}

> DisplayDate is different from SelectedDate. The DisplayDate points out just the default month and year visible when the calendar first pops up.

## Styling the Different Views

You can apply a style to the different modes through the following properties:

* __MonthViewStyle__: Gets or sets the style for the month calendar view.
* __YearViewStyle__: Gets or sets the style for the year calendar view.
* __DecadeViewStyle__: Gets or sets the style for the decade calendar view.
* __CenturyViewStyle__: Gets or sets the style for the century calendar view.

## Formatting the Headers

You can apply a string format to the header of the different views through the following properties:

* __MonthViewHeaderFormat__: Gets or sets the format for the header of the month view of the calendar.
* __DecadeViewHeaderFormat__: Gets or sets the format for the header of the decade view of the calendar.
* __YearViewHeaderFormat__: Gets or sets the format for the header of the year view of the calendar.
* __CenturyViewHeaderFormat__: Gets or sets the format for the header of the century view of the calendar.

## See Also
* [Selection Modes]({%slug radcalendar-selection-modes%})
* [Visual Structure]({%slug radcalendar-structure%})
* [Editing the CalendarButton Style]({%slug radcalendar-editing-button%})
* [BlackoutDates]({%slug radcalendar-features-blackoutdates%})
