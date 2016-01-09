---
title: Selection
page_title: Selection
description: Selection
slug: raddatetimepicker-features-selection
tags: selection
published: True
position: 7
---

# Selection
<<Comment: The tags, title, description, tags and H1 should all include RadDateTimePicker for better SEO. I also think they should indicate that this article covers selecting within a specific range and restricting selections. Those are also good search scenarios that people will look for.>>
The __RadDateTimePicker__ lets you select only single values - a single date, month or year from the Calendar and/or a single time item from the Clock.
<<Comment: Why is are selections from the Calendar called values but selections from the clock are called items? Aren't clock selections values as well? The next section heading is about selecting items declaratively or programmatically, not selecting values, but in the description of the properties you discusses values not items. Later in the article when you discuss restricting to a date or time range, you refere to them as items again.  I am confused why there are different names. Is an item equal to a value? In code do they get treated differently? I think you either need to be consistent (this I prefer as your editor) or add a sentence that tells the customer that for this article, you are using the two words to mean the same thing.>>
>You can customize the selection mode in the calendar view via the __DateSelectionMode__ property. The default behavior is that you can choose from dates. [Read more here]({%slug raddatetimepicker-features-date-selection-modes%})

## Selecting an Item Declaratively and Programmatically 

The following properties hold the information about the selection in the __RadDateTimePicker__ control:

* __SelectedValue__ - gives you a __DateTime__ representation of the selected date and time or __null__ if no value has been selected.

* __SelectedDate__ - it is the __DateTime__ that corresponds to the user selected date or __null__, if no value has been selected.

* __SelectedTime__ - it is of type __TimeSpan?__ and corresponds to the selected time representation in the clock view of the control or __null__ if no time has been selected.
<<Comment: I don't think the names of types have question marks in them, so I think __TimeSpan?__ should be __TimeSpan__.>>
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

* __SelectableDateStart__ - this is the first selectable date in the __RadDateTimePicker__ calendar that a user will be able to select.

* __SelectableDateEnd__ - this is the last selectable date in the __RadDateTimePicker__ calendar that a user will be able to select.

#### __XAML__

{{region raddatetimepicker-features-selection_3}}
	<telerik:RadDateTimePicker x:Name="radDateTimePicker" 
	                           SelectableDateStart="8/10/2010"
	                           SelectableDateEnd="10/10/2010"/>
{{endregion}}

![](images/dateTimePicker_features_selection_010.png)

The date items that are after the __SelectableDateEnd__ will still be visible but the user will not be able to select them. 

>You can also decide not to display date items that cannot be selected (located after the __SelectableDateEnd__ value). You can do this via the __DisplayDateStart__ and __DisplayDateEnd__ properties. [Read more here]({%slug raddatetimepicker-features-date-items%})

## Restricting the time item's selection

In the __RadDateTimePicker's__ clock view you can restrict the selectable time items by using the __StartTime__ and __EndTime__ properties. You can even fill the Clock with a custom collection of __TimeSpan__ objects. [Read more here]({%slug raddatetimepicker-features-clock-items%})

<<Comment: Why is there a code sample showing how to restrict date but there isn't a code example showing how to restrict time?>>

## Restricting the date and time item's selection from the input box

With the Q1 2016 release of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} the __IsInputRestrictedToSelectableDates__ boolean property was introduced. By using it you could easily restrict the user from selecting a date based on the entered text inside the input area of the control. The selectable range is defined by the values set for the __SelectableDateStart__ and  __SelectableDateEnd__ properties.

#### __XAML__

{{region raddatetimepicker-features-selection_4}}
	<telerik:RadDateTimePicker x:Name="radDateTimePicker" 
	                           SelectableDateStart="8/10/2015"
	                           SelectableDateEnd="10/11/2015"
							   IsInputRestrictedToSelectableDates="True"/>
{{endregion}}
<<Comment: The heading for this section says that the customer can restrict the time selection but the code example does not show how to do that.>>
# See Also

 * [Overview]({%slug raddatetimepicker-overview%})

 * [Events]({%slug raddatetimepicker-events%})

 * [Formatting]({%slug raddatetimepicker-features-formatting%})

 * [Selection]({%slug raddatetimepicker-features-selection%})
