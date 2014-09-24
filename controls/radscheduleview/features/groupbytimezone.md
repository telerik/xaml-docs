---
title: Grouping By TimeZone
page_title: Grouping By TimeZone
description: Grouping By TimeZone
slug: radscheduleview-features-groupbytimezone
tags: grouping,by,timezone
published: True
position: 16
---

# Grouping By TimeZone



RadScheduleView supports grouping by time zone. This can be achieved by adding a __TimeZoneGroupDescription__ to the GroupDescriptionSource property of RadScheduleView:
      



#### __XAML__

{{region radscheduleview-features-groupbytimezone_0}}
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}" TimeZonesSource="{Binding TimeZones}">
	   <telerik:RadScheduleView.ViewDefinitions>
	      <telerik:DayViewDefinition />
	      <telerik:WeekViewDefinition />
	      <telerik:MonthViewDefinition  />
	      <telerik:TimelineViewDefinition />
	   </telerik:RadScheduleView.ViewDefinitions>
	   <telerik:RadScheduleView.GroupDescriptionsSource>
	      <telerik:GroupDescriptionCollection>
	         <telerik:TimeZoneGroupDescription />
	      </telerik:GroupDescriptionCollection>
	   </telerik:RadScheduleView.GroupDescriptionsSource>
	</telerik:RadScheduleView>
	{{endregion}}



This type of grouping groups the appointments by their TimeZone property. One appointment cannot be displayed in two timezones.




             
          ![Group By TimeZone](images/radscheduleview_timezonegrouping1.png)



>

Grouping by TimeZone is not supported for MonthViewDefinition. 

## 
        TimeZonesSource property
      


The displayed groups can be configured by the __TimeZonesSource__property of the control. This property can be bound to any collection of __TimeZoneInfo objects__.
If this property is not set,{% if site.site_name == 'WPF' %} all system time zones will be displayed.{% endif %}{% if site.site_name == 'Silverlight' %} the Time Zones that will be displayed are TimeZoneInfo.Local and TimeZoneInfo.Utc.{% endif %}



When the view is grouped by a TimeZone, the EditApointmentDialog will display the Start and End time converted to the corresponding TimeZone: 






         
      ![Group By TimeZone](images/radscheduleview_timezonegrouping2.png)
