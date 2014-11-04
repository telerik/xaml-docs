---
title: How to configure the VisibleRange
page_title: How to configure the VisibleRange
description: How to configure the VisibleRange
slug: radscheduleview-features-viewdefinitions-configure-visiblerange
tags: how,to,configure,the,visiblerange
published: True
position: 3
---

# How to configure the VisibleRange

The built-in __RadScheduleView__ ViewDefinitions have specific ways to determine what the visible range will be when the CurrentDate property is set:

Type	|	VisibleRangeStart	|	VisibleDays
---	|	---	|	---
DayViewDefinition	|	CurrentDate	|	1
WeekViewDefinition	|	The first day of the week, containing CurrentDate	|	7
MonthViewDefinition	|	The first day of the first week of the month, containing CurrentDate	|	42
TimelineViewDefinition	|	CurrentDate	|	7

>The VisibleRangeEnd is VisibleRangeStart+VisibleDays for all view definitions.

>tipThe easiest way to create a WeekViewDefinition that behaves like the DayViewDefinition is to use a DayViewDefinition and set its VisibleDays=7.

For advanced customization of the VisibleRange the ViewDefinitionBase class provides two virtual methods:				

#### __C#__

{{region radscheduleview-features-viewdefinitions-configure-visiblerange_0}}
	protected virtual DateTime GetVisibleRangeStart (DateTime currentDate, CultureInfo culture, DayOfWeek? firstDayOfWeek);

	protected virtual DateTime GetVisibleRangeEnd(DateTime currentDate, CultureInfo culture, DayOfWeek? firstDayOfWeek);
{{endregion}}

For example, the following class represents a MonthViewDefinition that starts from the first week of CurrentDate:   				

#### __C#__

{{region radscheduleview-features-viewdefinitions-configure-visiblerange_1}}
	public class CustomMonthViewDefinition : MonthViewDefinition
	{
		protected override DateTime GetVisibleRangeStart(DateTime currentDate, CultureInfo culture, DayOfWeek? firstDayOfWeek)
		{
			return CalendarHelper.GetFirstDayOfWeek(currentDate, firstDayOfWeek.Value);
		}
	}
{{endregion}}

Since VisibleDays is 42 by default, this CustomMonthViewDefinition will display 6 weeks, as the standard MonthViewDefinition does.

Here is how to use the CustomMonthViewDefinition:

#### __XAML__

{{region radscheduleview-features-viewdefinitions-configure-visiblerange_2}}
	<telerik:RadScheduleView>
		<telerik:RadScheduleView.ViewDefinitions>
			<local:CustomMonthViewDefinition />
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
{{endregion}}
