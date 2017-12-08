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

The purpose of this help article is to show you the key properties of __RadCalendar__ control. The topic includes the following sections:

* [Selection properties](#selection-properties)
* [Styling the different views](#styling-the-different-views)
* [Formatting header](#formatting-header)

## Selection properties

* __SelectionMode__ - this property defines how many dates can be selected at once. The possible values are __Single__, __Extended__ and __Multiple__. The default value is __Single__.  

* __SelectedDate__ - gets or sets the currently selected date. If the SelectionMode is set to Multiple or Extended, returns the first date from the SelectedDates.
* __SelectedDates__ - gets the currently selected dates. Useful when the SelectionMode is set to Multiple or Extended.  

* __SelectableDateStart__ - gets or sets the first date that can be selected.
* __SelectableDateEnd__ - gets of sets the last date that can be selected.

* __BlackoutDates__ - gets or sets a collection of dates that cannot be selected

## Styling the different views

You can apply a style to the different modes through the following properties:

* __MonthViewStyle__ - gets or sets the style for the month calendar view.
* __YearViewStyle__ - gets or sets the style for the year calendar view.
* __DecadeViewStyle__ - gets or sets the style for the decade calendar view.
* __CenturyViewStyle__ - gets or sets the style for the century calendar view.

## Formatting Header

You can apply a string format to the header of the different views through the following properties:

* __MonthViewHeaderFormat__ - gets or sets the format for the header of the month view of the calendar.
* __DecadeViewHeaderFormat__ - gets or sets the format for the header of the decade view of the calendar.
* __YearViewHeaderFormat__ - gets or sets the format for the header of the year view of the calendar.
* __CenturyViewHeaderFormat__ - gets or sets the format for the header of the century view of the calendar.

## See Also
* [Selection Modes]({%slug radcalendar-selection-modes%})
* [Visual Structure]({%slug radcalendar-structure%})
* [Editing the CalendarButton Style]({%slug radcalendar-editing-button%})
* [BlackoutDates]({%slug radcalendar-features-blackoutdates%})