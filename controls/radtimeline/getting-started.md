---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtimeline-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This topic will walk you through the creating of __RadTimeline__.    

## Assembly References

In order to use __RadTimeline__ control in your project you have to add references to the following assemblies:

* __Telerik.Windows.Controls.dll__
* __Telerik.Windows.Controls.DataVisualization.dll__
* __Telerik.Windows.Data.dll__

You can include the control in your page by either dragging it from the toolbox in Visual Studio or manually creating the control. __Example 1__ demonstrate how to create __RadTimeline__ in XAML.

#### __[XAML] Example 1: Creating RadTimeline control__

{{region xaml-radtimeline-getting-started_0}}
	   <telerik:RadTimeline PeriodStart="2016/01/01" 
                            PeriodEnd="2016/06/01" 
                            VisiblePeriodStart="2016/01/01" 
                            VisiblePeriodEnd="2016/03/22"
                            StartPath="Date"
                            DurationPath="Duration">
            <telerik:RadTimeline.Intervals>
                <telerik:MonthInterval />
                <telerik:WeekInterval />
                <telerik:DayInterval />
                <telerik:HourInterval />
            </telerik:RadTimeline.Intervals>
        </telerik:RadTimeline>
{{endregion}}

#### __Figure 1: RadTimeline visualization__
![](images/RadTimeline_Getting_Started_0.png)

## RadTimeline items

The RadTimeline control presents its data in two types of occurrences(events). The first one is a one-time occurrence which happens once in a time. The second type represents periodical occurrence. It requires a strict __Start__ and __End__ time to be presented.

#### __Figure 2: RadTimeline items visualization__
![](images/RadTimeline_Getting_Started_1.PNG)

>tip More information about how to populate the control with __TimelineItems__ and __TimelineInstantItems__ can be found in the [DataBinding help article]({%slug radtimeline-databinding%}) in our documentation.

## See Also
 * [Overview]({%slug radtimeline-overview%})
 * [MVVM Support]({%slug radtimeline-mvvm-support%})
