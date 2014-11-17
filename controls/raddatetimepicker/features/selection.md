---
title: Selection
page_title: Selection
description: Selection
slug: raddatetimepicker-features-selection
tags: selection
published: True
position: 6
---

# Selection

The __RadDateTimePicker__ lets you select only single values - a single date, month or year from the Calendar and/or a single time item from the Clock.

>You can customize the selection mode in the calendar view via the __DateSelectionMode__ property. The default behavior is that you can choose from dates. [Read more here]({%slug raddatetimepicker-features-date-selection-modes%})

## Selecting an Item Declaratively and Programmatically 

The following properties hold the information about the selection in the __RadDateTimePicker__ control:

* __SelectedValue__ - gives you a __DateTime__ representation of the selected date and time or __null__ if no value has been selected.

* __SelectedDate__ - it is the __DateTime__ that corresponds to the user selected date or __null__, if no value has been selected.

* __SelectedTime__ - it is of type __TimeSpan?__ and corresponds to the selected time representation in the clock view of the control or __null__ if no time has been selected.

#### __XAML__

{{region raddatetimepicker-features-selection_0}}
	<telerik:RadDateTimePicker x:Name="radDateTimePicker"
	                           SelectedDate="11/15/2010"
	                           SelectedTime="10:00"/>
{{endregion}}

#### __C#__

{{region raddatetimepicker-features-selection_1}}
	this.radDateTimePicker.SelectedValue = new DateTime( 2010, 1, 5, 10, 0, 0 );
{{endregion}}

#### __VB.NET__

{{region raddatetimepicker-features-selection_2}}
	Me.radDateTimePicker.SelectedValue = New DateTime(2010, 1, 5, 10, 0, 0)
{{endregion}}

## Restricting the date item's selection

In the __RadDateTimePicker's__ calendar you can restrict the selectable items by using the following properties:

* __SelectableDateStart__ - this is the first date in the calendar which you will be able to select.

* __SelectableDateEnd__ - this is the last selectable date in the __RadDateTimePicker's__ calendar view.

#### __XAML__

{{region raddatetimepicker-features-selection_3}}
	<telerik:RadDateTimePicker x:Name="radDateTimePicker" 
	                           SelectableDateStart="8/10/2010"
	                           SelectableDateEnd="10/10/2010"/>
{{endregion}}

![](images/dateTimePicker_features_selection_010.png)

The date items which are after the __SelectableDateEnd__ will still be visible but you will not be able to select any of them. 

>You can also decide not to display date items which cannot be selected (located after the __SelectableDateEnd__ value). You can do this via the __DisplayDateStart__ and __DisplayDateEnd__ properties. [Read more here]({%slug raddatetimepicker-features-date-items%})

## Restricting the time item's selection

In the __RadDateTimePicker's__ clock view you can restrict the selectable time items by using the __StartTime__ and __EndTime__ properties. You can even fill the Clock with a custom collection of __TimeSpan__ objects. [Read more here]({%slug raddatetimepicker-features-clock-items%})

# See Also

 * [Overview]({%slug raddatetimepicker-overview%})

 * [Events]({%slug raddatetimepicker-events%})

 * [Formatting]({%slug raddatetimepicker-features-formatting%})

 * [Selection]({%slug raddatetimepicker-features-selection%})
