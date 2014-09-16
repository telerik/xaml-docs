---
title: Parsing Without Separators
page_title: Parsing Without Separators
description: Parsing Without Separators
slug: raddatetimepicker-features-parsing-without-separators
tags: parsing,without,separators
publish: True
position: 10
---

# Parsing Without Separators



With the Q3 2013 release of RadControls __RadDateTimePicker__ provides new parsing logic which will allow the end users to enter dates in the input field directly without separators - the entered date will be parsed following the same rules as in a [military format]({%slug raddatetimepicker-features-militaryparsing%}).

This feature can be enabled by setting __AllowParsingWithoutSeparator__ property of the control to __True__:

#### __XAML__

{{region raddatetimepicker-features-parsing-without-separators_0}}
	<telerik:RadDateTimePicker x:Name="radDateTimePicker" AllowParsingWithoutSeparator="True" />
	{{endregion}}



#### __C#__

{{region raddatetimepicker-features-parsing-without-separators_1}}
	this.radDateTimePicker.AllowParsingWithoutSeparator = true;
	{{endregion}}



>The default value of __AllowParsingWithoutSeparator__ is __False__.

Check below how the entered text is handled in both cases:![datetimeparsing allowparsing](images/datetimeparsing_allowparsing.png)

*in the first case the text is parsed as a month and day while in the second case - as a year as no separators are entered.

## Parsing the Date part

The following table lists the rules applied when using parsing without separators:
<table><th><tr><td>Input</td><td>Output</td></tr></th><tr><td>“1”  or “12”</td><td>
              sets the day in the month and year of the SelectedDate  ( if SelectedDate is null, the current month and current year are set ). Here is how it looks with different formats:
              ![datetimepicker parsing 1](images/datetimepicker_parsing1.png)</td></tr><tr><td>“120”</td><td>
              depending on the format, it will try to parse it as a day and month in the year of the SelectedDate ( if SelectedDate is null, current year is used ).
              ![datetimepicker parsing 4](images/datetimepicker_parsing4.png)

The parser works from right to left, in the first case it tries to parse Month=20,  as this returns false, it switches to the default parser and parses it as a year.  In both the second and third case the parsed date is January 20, current year.
              </td></tr><tr><td>“1205”</td><td>
              again, depending on the format, it will try to parse it as a day and a month in the year of the SelectedDate (or current year if SelectedDate is null).
              ![datetimepicker parsing 2](images/datetimepicker_parsing2.png)

In the first case the parsed date is May 12, while in the second and third cases it is December  5.</td></tr><tr><td>“12051”</td><td>False, until it fulfills the format’s length.</td></tr><tr><td>“120511”</td><td>
              it should be parsed according to the set format:
              ![datetimepicker parsing 3](images/datetimepicker_parsing3.png)

In the first case the entered string has not reached the format's length, that's why it returns False.
              

Note that in the second case the parsed date is May 11, 2012, while in the third case it is - December 5, 2011.
              </td></tr><tr><td>“Jan”</td><td>sets the year and day of the SelectedDate and the month parsed.</td></tr><tr><td>“Jan21”</td><td>sets the year of the SelectedDate and the day and month parsed.</td></tr></table>

>The DateTimePicker should match first the short abbreviations of the month names:
          Jan, Feb, Mar, Apr, May, June, July, Aug, Sept, Oct, Nov, Dec.And then the whole word of the month - in between an error will be displayed. The date which is going to be set once the month is recognized will be the first day of the month the currently selected year.
          

## Parsing the Time part

If the user enters digits inside the TextBox after the DatePart or in the TimePicker alone, they should be parsed as the hour part.
<table><th><tr><td>Input</td><td>Output</td></tr></th><tr><td>“1”  or “3”</td><td>
              parses it as an hour.
              ![datetimepicker parsing 5](images/datetimepicker_parsing5.png)</td></tr><tr><td>“14” or “34”</td><td>
              again, tries to parse it as an hour.  If it doesn’t fit for the hour part, for example is greater than 24,   the first digit is used as an hour with added 0 in front and the second one as minutes.
              ![datetimepicker parsing 6](images/datetimepicker_parsing6.png)</td></tr><tr><td>“144” or “344”</td><td>
              parses it as an hour and minutes until reaches the set Time format.
              ![datetimepicker parsing 7](images/datetimepicker_parsing7.png)</td></tr></table>{% if site.site_name == 'WPF' %}

Check out the RadDateTimePicker Configurator online demo at [http://demos.telerik.com/wpf/](http://demos.telerik.com/wpf/) to see __AllowParsingWithoutSeparator__ in action.
          {% endif %}{% if site.site_name == 'Silverlight' %}

Check out the [RadDateTimePicker Configurator online demo ](http://demos.telerik.com/silverlight/#DateTimePicker/Configurator) to see __AllowParsingWithoutSeparator__ in action.
          {% endif %}

# See Also

 * [Formatting]({%slug raddatetimepicker-features-formatting%})

 * [Military DateTime Parsing]({%slug raddatetimepicker-features-militaryparsing%})
