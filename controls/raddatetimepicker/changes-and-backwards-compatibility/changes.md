---
title: Changes
page_title: Changes
description: Changes
slug: raddatetimepicker-changes
tags: changes
published: True
position: 0
---

# Changes

This article describes the release history of the control.

For the complete Release History of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} go to {% if site.site_name == 'Silverlight' %}[What's New Section](http://www.telerik.com/products/silverlight/whats-new.aspx){% endif %}{% if site.site_name == 'WPF' %}[What's New Section](http://www.telerik.com/products/wpf/whats-new.aspx){% endif %}.      

## Q1 2014
### What's Fixed

* PopupPlacementTarget in RadDateTimePicker is not respected when FlowDirection is RTL  

* When IsDropDownOpen is set to True the designer in VS2012 crashes

* DateTimePicker throws ArgumentOutOfRangeException when ShortDatePattern = "MM/yyyy" and AllowParsingWithoutSeparator="True"

* After changing the culture, the ErrorTooltipContent and the DateTimeWatermarkContent does not localize their value.

* DateTimePicker throws exception when the Close button is not present in the ControlTemplate

* DateTimeWatermarkContent cannot be set to null.

* When Culture is set to Korean and the time part is changed it is wrongly parsed

{% if site.site_name == 'WPF' %}
* When setting the AreWeekNumbersVisible property of the Calendar to False,  DateTimePicker only shows the last row of numbers   

* The ToolTip is shown in the right corner of the DateTimePicker instead of the left one

* TimePicker loses focus when a different value is selected from the dropdown
{% endif %}

## Q3 2013
### What's New

* Extend the parsing mechanism of the control to support military date and time parsing                

### What's Fixed

* Incorrect parsing when inputing only 2 or 3 digits

* The Year is not parsed correctly when "yyyy" format is set and one number is typed

* There is a Border next to the Image for the Button in DateTimePicker in Windows8 theme which can be clicked and causes issues with the focus

* When 30th is selected and "Feb" is typed in the DatePicker, and exception is thrown

* The dropdown is closing when you try to zoom in when in Month, Year or Decade view in Touch

* The current year does not look focused when DateSelectionMode = "Year"

* AccessViolationException in RadDateTimePicker when using JAWS in Month/Year selection mode

* Bug when parsing Time entered without separators and with seconds

* DateTimePicker parses incorrectly time when the entered string ends with colon when in Time InputMode

* Exception is thrown when 29th February is used and user inserts a value from a non-leap year

* When Numeric and DateTimePicker are put in a ScrollView with IsTabStop=False set, the application hangs

* If in a RadWindow the first elements are two consecutive DateTimePicker controls and that Window is focused the application hangs

* When the theme is switched at runtime the TextBox in the DateTimePicker loses the text

## Q2 2013
### What's New

* Keyboard navigation improvements

### What's Fixed

* The drop down of the RadDatePicker is not closed when date selected with touch

* ErrorTooltip is visible out of the frame if its content is big enough

* The extension popup does not disappear when user move the window that contains the RadDatePicker

* The name of the RadDropDownButton in the RadDateTimePicker in Expression_Dark theme is " DP" instead of "PART_DropDownButton"

* SelectedValue doesn't clear after clearing the text in the RadDateTimePicker

{% if site.site_name == 'Silverlight' %}
* When the control is placed in RadGridView's column, editing it only with keyboard places the second entered digit before the first one
{% endif %}

## Q1 2013
### What's New

* Implement military date/time parsing. Check [here]({%slug raddatetimepicker-features-militaryparsing%}) for more details.                

### What's Fixed

* Fixed disabled state of RadDateTimePicker and RadWaterMarkTextBox

* Clock layout is not updated when ClockItemSource is changed

* A double line appears in Calendar Control when AreWeekNamesVisible="False" and ViewsHeaderVisibility="Visible"

* RadDateTimePicker doesn't focus its textbox part after selecting a value from the calendar

* RadDateTimePicker leaks when popup is opened

* Closing Dropdown by clicking on other control outside the RadDateTimePicker doesn't release the focus

* The drop down of the DatePicker is not closed when date selected with touch 
