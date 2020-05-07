---
title: TimeIndicator
page_title: TimeIndicator
description:
slug: radscheduleview-features-timeindicator
tags: currenttimeindicator,timeindicator
published: True
position: 21
---

# TimeIndicator

__RadScheduleView__ provides the option to visually mark a specific time on the timeline.

The time indicator is visualized with a straight line that goes across the timer ruler and appointments area of RadScheduleView. To add an indicator set the __TimeIndicatorsCollection__ property of the control and populate it with __TimeIndicator__ objects.

The TimeIndicator class allows you to set __Offset__ and __Location__.

* __Offset__ is a `TimeSpan` property which determines an offset relative to the current DateTime (DateTime.Now).
* __Location__ is a `CurrentTimeIndicatorLocation` property which determines the location of the indicator. This can be set to the following locations:
	* __TimeRulerAre__: The indicator is drawn only in the TimeRulerArea. 
	* __AppointmentsArea__: The indicator is drawn only in the AppointmentsArea.
	* __WholeArea__: The indicator is drawn in both areas - TimeRulerArea and AppointmentsArea.
	
#### __[XAML] Example 1: Adding time indicators in XAML__
{{region radscheduleview-features-timeindicator-0}}
{{endregion}}

#### __[C#] Example 2: Adding time indicators in code__
{{region radscheduleview-features-timeindicator-1}}
{{endregion}}

## TimeIndicatorStyleSelector

The __TimeIndicatorStyleSelector__ property of RadScheduleView is used to provide styles for the __TimeIndicatorItem__ controls generated from the TimeIndicators in the TimeIndicatorsCollection. 

The default __TimeIndicatorStyleSelector__ class can be used to customize the time indicators in the different locations (TimeRulerArea, AppointmentsArea and WholeArea).

#### __[XAML] Example 3: Using the default TimeIndicatorStyleSelector__
{{region radscheduleview-features-timeindicator-2}}
{{endregion}}

Additionally, a class that derives from TimeIndicatorStyleSelector can created in order to provide custom style selection logic.

#### __[C#] Example 4: Creating custom TimeIndicatorStyleSelector__
{{region radscheduleview-features-timeindicator-3}}
{{endregion}}

#### __[XAML] Example 5: Using the custom TimeIndicatorStyleSelector__
{{region radscheduleview-features-timeindicator4}}
{{endregion}}

## CurrentTimeIndicator

This a special time indicator that is not in the TimeIndicatorsCollection, but it display in the same way, with the sole difference that it shows on the current DateTime (DateTime.Now). The offset of the TimeIndicator items is relative to the position of the current time indicator. Read more in the [CurrentTimeIndicator]({%slug radscheduleview-features-currenttimeindicator%}) article. 

## Custom Time Indicator

The following example shows how to inherit the TimeIndicator class and override its __GetDateTime__ method. This allows creating an indicator with a concrete date, instead of using an offset.

## See Also



