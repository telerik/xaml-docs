---
title: Configuration
page_title: Configuration
description: Check our &quot;Configuration&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-viewdefinitions-configuration
tags: configuration
published: True
position: 1
---

# Configuration

RadScheduleView's predefined ViewDefinitions have various properties, which can be set in order the views to be configured best. Some of them are common for all views, others are specific for each view. In the following section we will go through all common properties.      

>For more information about the view specific properties, check [here]({%slug radscheduleview-viewdefinitions-specificproperties%}).

* [Title](#title)

* [LargeChangeInterval](#largechangeinterval)

* [SmallChangeInterval](#smallchangeinterval)

* [DayStartTime](#daystarttime)

* [DayEndTime](#dayendtime)

* [VisibleDays](#visibledays)

* [FirstDayOfWeek](#firstdayofweek)

* [StretchGroupHeaders](#stretchgroupheaders)

* [Orientation](#orientation)

* [GroupFilter](#groupfilter)

* [SubGroupsFilter](#subgroupsfilter)

## Title

Gets or sets the title of the view.LargeChangeInterval

## LargeChangeInterval

Gets or sets the date time interval with which the current will be increased or decreased when clicking on the navigation buttons in the header of the ScheduleView. The default values of the __LargeChangeInterval__ property are:

* 1d (1 day) for DayView

* 7d (7 days) for WeekView

* 1m (1 month) for MonthView

* 7d (7 days) for TimelineView

The property is of type __DateTimeInterval__. In the following example the __LargeChangeInterval__ property of DayView is set to 2 days and of MonthView is set of 2 months and 4 days.

__Example 1: Setting the LargeChangeInterval property in XAML__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_1-xaml' />

__Example 2: Setting the LargeChangeInterval property in code__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_2-cs' />

## SmallChangeInterval

Gets or sets the small change interval of the ScheduleView. It indicates the date time interval with which the current will be increased or decreased when moving the scrollbar. The default values of the __SmallChangeInterval__ are:      

* 7d (7 days) for MonthView

* 1d (1 day) for TimelineView

Setting the SmallChangeInterval property of a DayViewDefiniton and WeekViewDefinition won’t change the behavior of the view. That is due to that using the vertical scrollbar will not navigate to the next set of days, but will scroll the current view.      

The following example shows how to set the __SmallChangeInterval__ property of a MonthViewDefinition to 11 days and of a TimelineViewDefinition to 3 days:

__Example 3: Setting the SmallChangeInterval property in XAML__
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_3-xaml' />

__Example 4: Setting the SmallChangeInterval property in code__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_4-cs' />

## DayStartTime

Gets or sets the time used to indicate the start of the TimeRuler. The default value of the DayStartTime for all views is 00:00:00 or 12:00 AM.      

The DayStartTime is of type TimeSpan. It will not affect the look of the MonthView, since MonthView does not display time.      

The following example illustrates how to set the DayStartTime for DayView, WeekView and TimelineView:

__Example 5: Setting the DateStartTime property in XAML__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_5-xaml' />

__Example 6: Setting the DateStartTime property in code__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_6-cs' />

> MonthViewDefinition and AgendaViewDefinition do not support the __DayStartTime__ property.

## DayEndTime

Gets or sets the time used to indicate the end of the view. The default values of the DayStartTime for the view are:      

* 1.00:00:00 (1 day) for DayView

* 1.00:00:00 (1 day) for WeekView

* 1.00:00:00 (1 day) for TimelineView

The DayEndTime property is of type TimeSpan. The MonthView will be affected in the following manner – if there are appointments out of the displayed time range, they won’t be displayed in the MonthView also.      

The following example illustrates how to set the DayStartTime for DayView, WeekView and TimelineView:      

__Example 7: Setting the DayEndTime property in XAML__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_7-xaml' />

__Example 8: Setting the DayEndTime property in code__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_8-cs' />

> MonthViewDefinition and AgendaViewDefinition do not support the __DayEndTime__ property.

## VisibleDays

Gets or sets the visible dates in the view. It indicates the count of the dates that will be shown in the view. The default values of the VisibleDays property are:      

* 1 day for DayView

* 7 days for WeekView

* 42 days for MonthView

* 7 days for TimelineView

The following code-snippet illustrates how to set the VisibleDays property in XAML and in code-behind for all predefined views:      

__Example 9: Setting the VisibleDays property in XAML__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_9-xaml' />

__Example 10: Setting the VisibleDays property in code__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_10-cs' />

#### __Figure 1: RadScheduleView with VisibleDays set__  
![radschedule View viewdefinitions configuration 01](images/radscheduleView_viewdefinitions_configuration_01.png)

## FirstDayOfWeek

Gets or sets the first weekday with which the week will start according to the view. It affects only the WeekView and MonthView. Once set, it will override the FirstDayOfWeek property of the ScheduleView and the one that is default for the culture.

## StretchGroupHeaders

If set to True (default value) and there is more available space in the ViewDefintion left, it will be distributed among the groups. 

__Example 11: Setting the StretchGroupHeaders property__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_11-xaml' />

#### __Figure 2: RadScheduleView with StretchGroupHeaders set__  
![{{ site.framework_name }} RadScheduleView RadScheduleView with StretchGroupHeaders set](images/radscheduleView_viewdefinitions_configuration_08.png)

## Orientation

Gets or sets the orientation of the view. When the orientation is horizontal the TimeRuler is also horizontally oriented, but the GroupHeaders are oriented vertically and vice versa.      

Values can be Vertical or Horizontal. __Not present in MonthView.__ This is measured according to the position of the TimeRuler. The default values of Orientation property are:      

* Vertical for DayView

* Vertical for WeekView

* Horizontal for TimelineView

The following code-snippets show how to set the Orientation property in XAML and code-behind:      

__Example 12: Setting the Orientation property in XAML__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_12-xaml' />

__Example 13: Setting the Orientation property in code__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_13-cs' />

The following figures show the how the Orientation property affects the views.

#### __Figure 3: DayView with Horizontal Orientation__  
![radschedule View viewdefinitions configuration 05](images/radscheduleView_viewdefinitions_configuration_05.png)

#### __Figure 4: WeekView with Horizontal Orientation__  
![radschedule View viewdefinitions configuration 06](images/radscheduleView_viewdefinitions_configuration_06.png)

#### __Figure 5: TimelineView with Vertical Orientation__  
![radschedule View viewdefinitions configuration 07](images/radscheduleView_viewdefinitions_configuration_07.png)

## GroupFilter

The __GroupFilter__ property can be used when in a grouped scenario a given group needs to be excluded. It is a predicate that takes a given group as a parameter and returns a boolean value determining whether the group should take part in the grouping operation or not. The following example demonstrates how __RadScheduleView__ can display only weekends or only working days through its __GroupFilter__.

__Example 14: Defining the GroupFilter predicate in the view model__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_14-cs' />

__Example 15: Applying the GroupFilter to a WeekView__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_15-xaml' />

#### __Figure 6: WeekView with applied GroupFilter__  
![radschedule View viewdefinitions configuration 07](images/radscheduleView_viewdefinitions_configuration_09.png)
 
## SubGroupsFilter

As of __R2 2017__ RadScheduleView exposes the __SubGroupsFilter__ mechanism. It provides the option to control whether a given item should be visible in a particular group or not. The following example demonstrates how RadScheduleView can be populated with some sample Resources and how they can be visualized in a given group and hidden in another.

__Example 16: Defining the SubGroupsFilter in the view model__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_16-cs' />

__Example 17: Populating RadScheduleView with Resources and binding the SubGroupsFilter__  
<snippet id='radscheduleview-features-viewdefinitions-configuration-block_17-xaml' />

#### __Figure 7: WeekView with applied SubGroupsFilter__  
![radschedule View viewdefinitions configuration 07](images/radscheduleView_viewdefinitions_configuration_10.png)

## See Also  
 * [ViewDefinitions - Overview]({%slug radscheduleview-viewdefinitions-overview%})
 * [View specific properties]({%slug radscheduleview-viewdefinitions-specificproperties%})