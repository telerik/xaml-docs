---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-viewdefinitions-overview
tags: overview
published: True
position: 0
---

# Overview

The ScheduleView provides the functionality of displaying the data in different views. There are four predefined views from which you can choose to easily navigate through the appointments. These views ensure better flexibility and save time to write or modify the logic behind all different controls to make them work as one. You can customize each view – you can modify its orientation, the number of days displayed, customize the time ruler, etc.

* __Day View__: Displays the appointments for a single day. It is always grouped by date and additionally can be grouped by resource. It can be oriented horizontally or vertically. If there is more than 1 day displayed in this view, the listing starts from value of the __CurrentDate__ property set to the ScheduleView control.

* __Week View__: Contains the same properties as the DayView with the only difference that the displayed period is not just a single day but the days of a whole week. It is always grouped by date and additionally can be grouped by resource. The difference between the DayView and the WeekView is that the first displayed date in WeekView is the first day of the week of the __CurrentDate__ property.

* __Month View__: Displays by default the appointments in one month and allows you to browse through long-term periods. It is always grouped by week and additionally can be grouped by resource. The MonthView can be oriented only horizontally.

* __Timeline View__: Displays the days and the hours in a timeline like matter. It cannot be grouped by date, but only by resource. The TimelineView can be oriented horizontally or vertically. The first day in this view is the value of the __CurrentDate__ property of the ScheduleView control.

* __Agenda View__: Display a set of appointments for a specific period of time. Read more in the [Agenda View]({%slug radscheduleview-viewdefinitions-agenda%}) article.

Also, through defining different properties you can create your own custom view.

>More information about the common for all views properties can be found [here]({%slug radscheduleview-viewdefinitions-configuration%}) and for view specific properties - [here]({%slug radscheduleview-viewdefinitions-specificproperties%}).

## How to set the views

RadScheduleView has different definitions for each view. It has four types of predefined view definitions, as mentioned earlier:

* DayViewDefiniton

* MonthViewDefinition

* TimelineViewDefinition

* WeekViewDefinition

* AgendaViewDefinition

In order to include each one of the views in the RadScheduleView, they have to be defined as follows:


```XAML
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}" x:Name="scheduleView">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:DayViewDefinition/>
			<telerik:MonthViewDefinition/>
			<telerik:WeekViewDefinition/>
			<telerik:TimelineViewDefinition/>
			<telerik:AgendaViewDefinition/>
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
```


```C#
	MonthViewDefinition monthDefintion = new MonthViewDefinition();
	DayViewDefinition dayDefintion = new DayViewDefinition();
	WeekViewDefinition weekDefinition = new WeekViewDefinition();
	TimelineViewDefinition timelineDefinition = new TimelineViewDefinition();
	AgendaViewDefinition agendaViewDefinition = new AgendaViewDefinition();
	this.scheduleView.ViewDefinitions.Add(monthDefintion);
	this.scheduleView.ViewDefinitions.Add(dayDefintion);
	this.scheduleView.ViewDefinitions.Add(timelineDefinition);
	this.scheduleView.ViewDefinitions.Add(weekDefinition);
	this.scheduleView.ViewDefinitions.Add(agendaViewDefinition);
```

## See Also  
 * [Configuration]({%slug radscheduleview-viewdefinitions-configuration%})
 * [View specific properties]({%slug radscheduleview-viewdefinitions-specificproperties%})
 * [How to configure the VisibleRange]({%slug radscheduleview-features-viewdefinitions-configure-visiblerange%})
