---
title: TimeIndicators
page_title: TimeIndicators
description: Telerik RadScheduleView for WPF provides the option to visually mark a specific time on the timeline, using TimeIndicator objects.
slug: radscheduleview-features-timeindicators
tags: currenttimeindicator,timeindicator
published: True
position: 21
---

# TimeIndicators

__RadScheduleView__ provides the option to visually mark a specific time on the timeline.

The time indicator is visualized with a straight line that goes across the timer ruler and appointments area of RadScheduleView. To add an indicator set the __TimeIndicatorsCollection__ property of the control and populate it with __TimeIndicator__ objects.

The TimeIndicator class allows you to set __Offset__ and __Location__.

* __Offset__ is a `TimeSpan` property which determines an offset relative to the current DateTime (DateTime.Now).
* __Location__ is a `CurrentTimeIndicatorLocation` property which determines the location of the indicator. This can be set to the following locations:
	* __TimeRulerArea__: The indicator is drawn only in the TimeRulerArea. 
	* __AppointmentsArea__: The indicator is drawn only in the AppointmentsArea.
	* __WholeArea__: The indicator is drawn in both areas - TimeRulerArea and AppointmentsArea.
	
__Example 1: Adding time indicators in XAML__
```XAML
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:DayViewDefinition />
		</telerik:RadScheduleView.ViewDefinitions>
		<telerik:RadScheduleView.TimeIndicatorsCollection>
			<telerik:TimeIndicatorsCollection>
				<telerik:TimeIndicator Location="WholeArea" />
				<telerik:TimeIndicator Offset="-02:15" Location="WholeArea" />
			</telerik:TimeIndicatorsCollection>
		</telerik:RadScheduleView.TimeIndicatorsCollection>
	</telerik:RadScheduleView>	
```

__Example 2: Adding time indicators in code__
```C#
	var collection = new TimeIndicatorsCollection();
	collection.Add(new TimeIndicator() { Location = CurrentTimeIndicatorLocation.WholeArea });
	collection.Add(new TimeIndicator() { Location = CurrentTimeIndicatorLocation.WholeArea, Offset = new TimeSpan(-2, -15, 0) });
	this.radScheduleView.TimeIndicatorsCollection = collection;
```

#### Figure 1: RadScheduleView with two time indicators
![{{ site.framework_name }} RadScheduleView RadScheduleView with two time indicators](images/radscheduleview-features-timeindicator-0.png)

## TimeIndicatorStyleSelector

The __TimeIndicatorStyleSelector__ property of RadScheduleView is used to provide styles for the __TimeIndicatorItem__ controls generated from the TimeIndicators in the TimeIndicatorsCollection. 

The default __TimeIndicatorStyleSelector__ class can be used to customize the time indicators in the different locations (TimeRulerArea, AppointmentsArea and WholeArea).

Additionally, a class that derives from StyleSelector can be created in order to provide custom style selection logic.

## CurrentTimeIndicator

This a special time indicator that is not in the TimeIndicatorsCollection, but it is displayed in the same way, with the sole difference that it shows on the current DateTime (DateTime.Now). The offset of the TimeIndicator items is relative to the position of the current time indicator. Read more in the [CurrentTimeIndicator]({%slug radscheduleview-features-currenttimeindicator%}) article. 

## Custom TimeIndicator

The following example shows how to inherit the TimeIndicator class and override its __GetDateTime__ method. This allows creating an indicator with a concrete date, instead of using an offset.

__Example 3: Creating a custom TimeIndicator__
```C#
	public class CustomTimeIndicator : TimeIndicator
    {
        public DateTime DateTime { get; set; }

        public override DateTime GetDateTime()
        {
            return this.DateTime;
        }
    }
```

__Example 4: Using the custom TimeIndicator__
```XAML	
	<telerik:RadScheduleView.TimeIndicatorsCollection>
		<telerik:TimeIndicatorsCollection>
			<local:CustomTimeIndicator DateTime="5/7/2020 16:15" />
		</telerik:TimeIndicatorsCollection>
	</telerik:RadScheduleView.TimeIndicatorsCollection>
```

## See Also  
* [Getting Started]({%slug radscheduleview-getting-started%})
* [Visual Structure]({%slug radscheduleview-getting-started-visual-structure%})
* [View Definintions]({%slug radscheduleview-viewdefinitions-overview%})

