---
title: Military DateTime Parsing
page_title: Military DateTime Parsing
description: Military DateTime Parsing
slug: raddatetimepicker-features-militaryparsing
tags: military,datetime,parsing
publish: True
position: 11
---

# Military DateTime Parsing



With the Q1 2013 release __RadDateTimePicker__ provides the option to parse the entered DateTime in a military format.

The ShortDatePattern and ShortTimePattern DateTimeFormats should be set in order for the military parsing to work. 

The possible Date formats are:

>tipWhere MMM is the month with abbreviated name: MAR, JAN, FEB, etc.

The only possible Time format is:

So, let's have the following RadDateTimePicker:

#### __XAML__

{{region raddatetimepicker-features-militaryparsing_0}}
	<telerik:RadDateTimePicker x:Name="radDateTimePicker" Width="200" />
	{{endregion}}



Here is how the military parsing can be set:

#### __C#__

{{region raddatetimepicker-features-militaryparsing_1}}
	this.radDateTimePicker.Culture = new System.Globalization.CultureInfo("en-US");
	this.radDateTimePicker.Culture.DateTimeFormat.ShortDatePattern = "ddMMyyyy";
	this.radDateTimePicker.Culture.DateTimeFormat.ShortTimePattern = "HHmm";
	{{endregion}}



and the result is:![datetimepicker militaryparsing](images/datetimepicker_militaryparsing.png)

Here is in more details how the military parsing works according to the entered text:
<table><th><tr><td>Input</td><td>Output</td></tr></th><tr><td>"1"</td><td>False - the parsing expects at least 2 symbols.</td></tr><tr><td>"12"</td><td>
						 True - sets the day in the current month and year. Here is how it looks with different ShortDate formats:
						 ![datetimepicker militaryparsing 1](images/datetimepicker_militaryparsing_1.png)</td></tr><tr><td>"120"</td><td>
						 Depending on the format, it will try to parse it as day and month in the current year:
						 ![datetimepicker militaryparsing 2](images/datetimepicker_militaryparsing_2.png)

The parser works from right to left, that is why in the first two cases the result is false - it tries to parse Month=20. In the third case Day=20, so the parsing is successful.</td></tr><tr><td>"1205"</td><td>
						Again, depending on the format, it will try to parse it as day and month in the current year:
						![datetimepicker militaryparsing 3](images/datetimepicker_militaryparsing_3.png)

In the first two cases the parsed date is May 12, while in the third case it is December 5.</td></tr><tr><td>"12051"</td><td>
						False, until it fulfills the format’s length.						
					</td></tr><tr><td>"120511"</td><td>
						It should be parsed depending on the date format:
						![datetimepicker militaryparsing 4](images/datetimepicker_militaryparsing_4.png)

In the first case the entered string has not reached the format's length, that's why it returns False.

Note that in the second case the parsed date is November 5, 2012, while in the third case it is - December 5, 2011.</td></tr><tr><td>"Jan"</td><td>
						Sets the current day and year, and the month parsed.
					</td></tr><tr><td>"Jan21"</td><td>
						Should parse 21 of January, current year.
					</td></tr></table>

# See Also

 * [Formatting]({%slug raddatetimepicker-features-formatting%})
