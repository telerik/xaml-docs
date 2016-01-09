---
title: Keyboard Support
page_title: Keyboard Support
description: Keyboard Support
slug: raddatetimepicker-features-keyboard-support
tags: keyboard,support
published: True
position: 8
---

# Keyboard Support
<<Comment: I think RadDateTimePicker should appear in the H1 for the article for better SEO.>>
Using the keyboard you can perform some of the most common tasks. This section describes the keyboard shortcuts used by __RadDateTimePicker__.

## Navigation between Calendar part and Clock part

When the user opens the DateTimePicker, the keyboard focus goes automatically to the Calendar in it. At this point, there is a full TAB cycle in the dropdown of the control, namely:

* TAB goes to Clock part of the control;

* TAB again navigates to the Close button;

* The next TAB moves the focus to the Calendar again;

* SHIFT+TAB returns to the previous element in the TAB cycle.
<<Comment: I removed Clicking because I think one clicks a button on a screen with a mouse but one presses a TAB key on a keyboard. Clicking TAB (as you had it) didn't seem right to me so I removed it.>>
![date Time Picker features keyboard support 01](images/dateTimePicker_features_keyboard_support_01.png)

## Navigation inside the Calendar

When the focus is in the Calendar, you can use the following keyboard shortcuts to navigate between the dates and the Views:

* __Arrow Keys__ - navigate in all directions inside the Calendar;

* __Home/End__ - navigate to the first/last day of the month;            

* __PageUp/PageDown__ - navigate to the next or previous month;            

* __Ctrl & +/- or Ctrl + ArrowUp/ArrowDown__ - navigate between the Views in the Calendar (ZoomIn and ZoomOut functionality).            

* __Enter__ - selects the currently focused date and closes the dropdown.            

## Navigation inside the TimePicker

When the focus is in the TimePicker, you can use the following keyboard shortcuts to navigate inside TimePicker:

* __Arrow Keys__ - navigate in all directions inside the TimePicker.

* __Home/End__ - navigate to the first/last item.
<<Comment: What is the first or last item in a TimePicker? Is the first value 00:00:00 and is the last value 23:59:59? Are those called items elsewhere in the documentation for TimePicker? The description you wrote doesn't seem specific enough to me to describe a TimePicker control.>>
* __Enter__ - selects the currently focused time and closes the dropdown.
