---
title: TimeRuler Configuration
page_title: TimeRuler Configuration
description: Check our &quot;TimeRuler Configuration&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-end-user-capabilities-timerulerconfiguration
tags: timeruler,configuration
published: True
position: 4
---

# TimeRuler Configuration

This topic describes how to configure the TimeRuler of the RadScheduleView control.

## TimeRuler Configuration

There are two key properties that control the Height of the TimeRuler:

* __MinTimeRulerExtent__- gets or sets the minimum height of the TimeRuler in pixels. If the viewport is smaller than this value, a scrollbar will appear.

* __MaxTimeRulerExtent__- gets or sets the maximum height of the TimeRuler in pixels. If the viewport is bigger than this value, empty space will appear below the time ruler.



```XAML
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}"  
	                          MinTimeRulerExtent="300" 
	                          MaxTimeRulerExtent="600" >
	            <telerik:RadScheduleView.ViewDefinitions>
	                <telerik:DayViewDefinition  />
	                <telerik:WeekViewDefinition />
	                <telerik:TimelineViewDefinition />
	            </telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
```

The TimeRuler resizes according the size of the RadScheduleView until the TimeRuler extend is between the Min/MaxTimeRulerExtent properties.

The height of all TimeSlots cannot be greater than the value of MaxTimeRulerExtent property and cannot be smaller than the value of the MinTimeRulerExtent property. Here are several scenarios using Min/MaxTimeRulerExtent properties:

* __Setting the MinTimeRulerExtent__

In this scenario, if the RadScheduleView control is resized so that the viewport is smaller than the value of the MinTimeRulerExtent property, a ScrollBar appears. The height of the extend is the value of the MinTimeRulerExtent property.

![Configurate TimeRuler 01](images/radscheduleview_end_user_capabilities_configurate_timeRuler_01.png)

* __Setting the MaxTimeRulerExtent__

In this scenario, if the RadScheduleView control is resized so that the extend is greater than the value of the MaxTimeRulerExtent property, the SlotItems stop resizing and the remained space is left empty.

![Configurate TimeRuler 02](images/radscheduleview_end_user_capabilities_configurate_timeRuler_02.png)

## See Also

 * [ScheduleView Overview]({%slug radscheduleview-overview%})