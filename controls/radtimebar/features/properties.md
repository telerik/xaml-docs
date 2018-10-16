---
title: Properties
page_title: Properties
description: Properties
slug: radtimebar-properties
tags: properties
published: True
position: 0
---

# Properties



> There is a required precedence of the __TimeBar's__ properties. This means that the __Start Time__ should always be set before the __End Time__. A required precedence of Properties is given in the code snippet below.

#### __XAML__

{{region xamlradtimebar-properties_0}}
	<telerik:RadTimeBar x:Name="timeBar" Width="950" Height="250"      
						PeriodStart="01-01-2011"
						PeriodEnd="01/01/2012"
						VisiblePeriodStart="01/01/2011"
						VisiblePeriodEnd="06/01/2011"
						SelectionStart="02/01/2011"
						SelectionEnd="03/01/2011"
						MinSelectionRange="28.00:00:00"                            
						MaxSelectionRange="31.00:00:00"                            
						IsSnapToIntervalEnabled="True" >
		<telerik:RadTimeBar.Intervals>
			<telerik:MonthInterval />
		</telerik:RadTimeBar.Intervals>
	</telerik:RadTimeBar>
{{endregion}} 
	
__PeriodStart__ - gets or sets the timeline's start date
__PeriodEnd__ - gets or sets the timeline's end data
__VisiblePeriodStart__ - gets or sets the currently visible start date
__VisiblePeriodEnd__ - gets or sets the the currently visible end date
__Intervals__ - determines the displayed time intervals

Currently the supported intervals are:
*         Century;
*         Decade;
*         Year;
*         Quarter;
*         Month;
*         Week;
*         Day;
*         Hour;
*         Minute;
*         Second;
*         Millisecond;

A sample Intervals section may look like this:

#### __XAML__

{{region radtimebar-properties_1}}
	<telerik:RadTimeBar.Intervals>
	     <telerik:YearInterval />
	     <telerik:MonthInterval/>
	     <telerik:WeekInterval/>
	     <telerik:DayInterval/>
	 </telerik:RadTimeBar.Intervals>
	{{endregion}}



Every interval has a preset collection of formatting strings that creates the string representation of a given date to match the interval. RadTimeBar automatically choses the appropriate string formatter according to the control size and visible range. For example year interval uses the following set of formatting strings:

“yyyy”

“yy”

__SelectionStart__ and __SelectionEnd__ – These properties determine the beginning of the selected range in the TimeBar control.

__IsSnapToIntervalEnabled__- This turns on the snapping functionality, which will restrict the moving of the selection thumb, so that it will snap to the items' lines.

__MinSelectionRange__ and __MaxSelectionRange__ - These properties define the Selection Range interval thus you won't be able to select interval lower than the MinSelectionRange and higher than MaxSelectionRange.

__IntervalSpans__ -this property can be set from each Interval except Decade and Quarter. It is used to group the given Interval Items Together. For example setting:

#### __XAML__

{{region radtimebar-properties_2}}
	<telerik:RadTimeBar.Intervals>
	   <telerik:SecondInterval IntervalSpans="10"/>
	</telerik:RadTimeBar.Intervals>
	{{endregion}}



will make the seconds in groups with 10 each. You can also set more than one *IntervalSpan* simultaneously by separating them with comma:

#### __XAML__

{{region radtimebar-properties_3}}
	<telerik:RadTimeBar.Intervals>
	   <telerik:SecondInterval IntervalSpans="10,15,30" />
	   <telerik:MinuteInterval IntervalSpans="1,10,15,30" />
	</telerik:RadTimeBar.Intervals>
	{{endregion}}



__CurrentItemInterval__ and __CurrentGroupInterval__ properties can be used in code-behind to take the current item respectively group interval span set.

__MinZoomRange__ and __MaxZoomRange__ -  These properties set the minimal and maximum range of the TimeBar that can be zoomed.
