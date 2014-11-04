---
title: Editing the CalendarButton Style
page_title: Editing the CalendarButton Style
description: Editing the CalendarButton Style
slug: radcalendar-editing-button
tags: editing,the,calendarbutton,style
published: True
position: 1
---

# Editing the CalendarButton Style

Most of the calendar surface is taken up by the calendar buttons and most of the user interaction involves them as well.

All the buttons in the body of the calendar are actually __CalendarButtons__, though they have slightly different styles for the four modes.

The CalendarButton has the following __visual states__:

__CommonStates__ group:

* __Normal__ – The default state of the button

* __Disabled__ – Active when the button is not selectable (outside the SelectableStart/End range)

* __IsInAnotherView__ – This state is active when multiple views are present in the calendar and the given date already exists in another, more appropriate view. For example the first days of September will be visible in the month view for August, but if there is a month view for September as well, the former will be in the IsInAnotherView state.

* __IsNotFromCurrentView__– This state is active for the calendar buttons in a given calendar view that do not belong to it, for example the first days of April visible in the month view for March.

__ButtonType__ group: Suited for visual differences based on the type of the button (in which view it appears)

* __Year__ – Button that appears in the Decade view.

* __Decade__ – Button in the Century view.

* __Date__– Button that appears in the month view.

* __WeekName__ – Button that appears in the month view and is a name of a weekday

* __WeekNumber__ – Button that appears in the month view and bears a week number

* __TodayDate__ – Button that appears in the month view and is today’s date

* __Month__ – Button that appears in the year view.

__FocusStates__ group– determine whether there is keyboard focus on the control.

* __Focused__

* __Unfocused__

__SelectionStates__

* __Unselected__, the default state

* __MouseOver__, activated when the mouse is over the control

* __Selected__, Activated when the button is selected.
