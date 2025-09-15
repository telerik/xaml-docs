---
title: Key Properties
page_title: Key Properties
description: Check our &quot;Key Properties&quot; documentation article for the RadCalendar {{ site.framework_name }} control.
slug: radcalendar-key-properties
tags: key,properties
published: True
position: 0
---

# Key Properties

The purpose of this help article is to show you the key properties of the `RadCalendar` control. The topic includes the following sections:

* [Selection Properties](#selection-properties)
* [Styling the Different Views](#styling-the-different-views)
* [Formatting the Headers](#formatting-the-headers)

## Selection Properties

* `SelectionMode`&mdash;This property defines how many dates can be selected at once. The possible values are `Single`, `Extended` and `Multiple`. The default value is `Single`.  
* `SelectedDate`&mdash;Gets or sets the currently selected date. If the SelectionMode is set to Multiple or Extended, returns the first date from the SelectedDates.
* `SelectedDates`&mdash;Gets the currently selected dates. Useful when the SelectionMode is set to Multiple or Extended.  
* `SelectableDateStart`&mdash;Gets or sets the first date that can be selected.
* `SelectableDateEnd`&mdash;Gets of sets the last date that can be selected.
* `BlackoutDates`&mdash;Gets or sets a collection of dates that cannot be selected.

## Setting the Current Display Date

The `DisplayDate` property allows you to set the current visible date. This is the date which will be displayed when you show the calendar.

__Setting DisplayDate__
```XAML
	<telerik:RadCalendar DisplayDate="4/1/2018"/>
```

> DisplayDate is different from SelectedDate. The DisplayDate points out just the default month and year visible when the calendar first pops up.

## Styling the Different Views

You can apply a style to the different modes through the following properties:

* `MonthViewStyle`&mdash;Gets or sets the style for the month calendar view.
* `YearViewStyle`&mdash;Gets or sets the style for the year calendar view.
* `DecadeViewStyle`&mdash;Gets or sets the style for the decade calendar view.
* `CenturyViewStyle`&mdash;Gets or sets the style for the century calendar view.

## Formatting the Headers

You can apply a string format to the header of the different views through the following properties:

* `MonthViewHeaderFormat`&mdash;Gets or sets the format for the header of the month view of the calendar.
* `DecadeViewHeaderFormat`&mdash;Gets or sets the format for the header of the decade view of the calendar.
* `YearViewHeaderFormat`&mdash;Gets or sets the format for the header of the year view of the calendar.
* `CenturyViewHeaderFormat`&mdash;Gets or sets the format for the header of the century view of the calendar.

__Setting MonthViewHeaderFormat__
```XAML
	<telerik:RadCalendar MonthViewHeaderFormat="MMMM" />
```

> Check out the [Custom date and time format strings](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings) article to learn about the possible format strings. 

## Controling the MoveRight and MoveLeft Buttons Visibility

* `PreviousButtonVisibility`&mdash;Gets or sets the visibility of the __MoveLeft__ button.
* `NextButtonVisibility`&mdash;Gets or sets the visibility of the __MoveRight__ button.

## Controling the Highlighting of the Today's Date

The `IsTodayHighlighted` property allows you to control if the today's date is highlighted. Its default value is __true__. Setting this property to __false__ will remove the highlight border that is displayed on today's date.

__Removing the highlight of today's date__
```XAML
	<telerik:RadCalendar IsTodayHighlighted="False"/>
```

## See Also
* [Selection Modes]({%slug radcalendar-selection-modes%})
* [Visual Structure]({%slug radcalendar-structure%})
* [Editing the CalendarButton Style]({%slug radcalendar-editing-button%})
* [BlackoutDates]({%slug radcalendar-features-blackoutdates%})
