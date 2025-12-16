---
title: Templating the TimeRulerItems
page_title: Templating the TimeRulerItems
description: Check our &quot;Templating the TimeRulerItems&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-styles-and-templates-templating-timeruleritems
tags: templates,timeruleritems
published: True
position: 3
---

# Templating the TimeRulerItems

__RadScheduleView__ provides a wide range of customizable __TimeRulerItems__. The term __TimeRulerItem__ refers to the major and minor ticks inside the TimeRuler, date group headers in TimelineView as well as day buttons and weekdays headers in MonthView.

>tip See the [Configuring the TimeRuler ticks]({%slug radscheduleview-features-timeruler-ticks-configuration%}) topic for further details on the different TimeRuler items.

This topic explains how to define the __TimeRulerItemTemplateSelector__ property of RadScheduleView in order to customize the templates of the TimeRuler items.

__TimeRulerItemTemplateSelector__ is used to set a DataTemplate to the TimeRulerItems according to their type and the current ViewDefintion of the ScheduleView. Additionally, __TimeRulerItemTemplateSelector__ provides a separate template for vertical and horizontal orientation of the ViewDefinitions (except MonthViewDefinition, as it does not support Orientation).

The next figures show the templates in the different ViewDefinitions of __RadScheduleView__.

#### __Figure 1: TimeRulerItems templates in DayViewDefinition with Orientation = "Vertical"__
![{{ site.framework_name }} RadScheduleView TimeRulerItems templates in DayViewDefinition with Orientation = "Vertical"](images/radscheduleview_templating_timeruleritems_01.png)

#### __Figure 2: TimeRulerItems templates in DayViewDefinition with Orientation = "Horizontal"__
![{{ site.framework_name }} RadScheduleView TimeRulerItems templates in DayViewDefinition with Orientation = "Horizontal"](images/radscheduleview_templating_timeruleritems_02.png)

#### __Figure 3: TimeRulerItems templates in WeekViewDefinition with Orientation = "Vertical"__
![{{ site.framework_name }} RadScheduleView TimeRulerItems templates in WeekViewDefinition with Orientation = "Vertical"](images/radscheduleview_templating_timeruleritems_03.png)

#### __Figure 4: TimeRulerItems templates in WeekViewDefinition with Orientation = "Horizontal"__
![{{ site.framework_name }} RadScheduleView TimeRulerItems templates in WeekViewDefinition with Orientation = "Horizontal"](images/radscheduleview_templating_timeruleritems_04.png)

#### __Figure 5: TimeRulerItems templates in TimelineViewDefinition with Orientation = "Horizontal"__
![{{ site.framework_name }} RadScheduleView TimeRulerItems templates in TimelineViewDefinition with Orientation = "Horizontal"](images/radscheduleview_templating_timeruleritems_05.png)

#### __Figure 6: TimeRulerItems templates in TimelineViewDefinition with Orientation = "Vertical"__
![{{ site.framework_name }} RadScheduleView TimeRulerItems templates in TimelineViewDefinition with Orientation = "Vertical"](images/radscheduleview_templating_timeruleritems_06.png)

#### __Figure 7: TimeRulerItems templates in MonthViewDefinition__
![{{ site.framework_name }} RadScheduleView TimeRulerItems templates in MonthViewDefinition](images/radscheduleview_templating_timeruleritems_07.png)

>tip Minor tick templates are by design empty. This could be easily changed by assigning a StringFormat through the [Formatting properties]({%slug radscheduleview-features-formatting%}) of the ViewDefinitions.

Example 1 shows how to configure DayViewDefinition and the corresponding VerticalDayMajorItem and VerticalDayMinorItem templates in order to achieve a more detailed view of the TimeRuler.

First, you will need to retrieve the default __TimeRulerItemTemplateSelector__ from the UI for WPF installation folder. Go to the Themes.Implicit folder and select the theme that you use in your application. Drill down to find the Telerik.Windows.Controls.ScheduleView.xaml file in that directory. From this resource dictionary, extract the __TimeRulerItemTemplateSelector__ and copy it to the Resources inside your application.

__Example 1__ shows TimeRulerItemTemplateSelector with modified VerticalDayMajorItemTemplate and VerticalDayMinorItemTemplate.

__Example 1: Modified TimeRulerItemTemplateSelector__

```XAML
	<telerikScheduleView:TimeRulerItemTemplateSelector x:Key="TimeRulerItemTemplateSelector">
		...    
		<telerikScheduleView:TimeRulerItemTemplateSelector.VerticalDayMajorItemTemplate>
			<DataTemplate>
				<TextBlock Text="{Binding FormattedValue}" TextAlignment="Right" FontSize="11" MinWidth="50"/>
			</DataTemplate>
		</telerikScheduleView:TimeRulerItemTemplateSelector.VerticalDayMajorItemTemplate>
		<telerikScheduleView:TimeRulerItemTemplateSelector.VerticalDayMinorItemTemplate>
			<DataTemplate>                
				<TextBlock Text="{Binding FormattedValue}" FontSize="10" Foreground="Gray" TextAlignment="Right" MinWidth="50"/>
			</DataTemplate>
		</telerikScheduleView:TimeRulerItemTemplateSelector.VerticalDayMinorItemTemplate>   
		...
	</telerikScheduleView:TimeRulerItemTemplateSelector>
```

>The text of the TextBlock inside the templates is bound to the __FormattedValue__ property, which is formed after the StringFormat is set through the [Formatting properties]({%slug radscheduleview-features-formatting%}) of the ViewDefinitions is applied.

>The DataContext of the templates is of type _TimeRulerItemProxy_ - it contains information about the DateTime and the Duration of the TimeRulerItem.

All that is left is to set __TimeRulerItemTemplateSelector__ property of the ScheduleView. Additionally, DayViewDefinition has its MajorTickLength and MinorTickLength set to 1h and 15min, respectively, and the TimerulerMinorTickStringFormat is set to display the minutes.

__Example 2__ shows how the __RadScheduleView__ is defined.

__Example 2: RadScheduleView with TimeRulerItemTemplateSelector set__

```XAML
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}" 
            TimeRulerItemTemplateSelector="{StaticResource TimeRulerItemTemplateSelector}">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:DayViewDefinition MajorTickLength="1h" MinorTickLength="15min" 
									   TimerulerMinorTickStringFormat=":{0:mm}" />            
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>   
```

__Figure 8__ shows the final result.

#### __Figure 8: RadScheduleView with customized TimeRuler__
![{{ site.framework_name }} RadScheduleView RadScheduleView with customized TimeRuler](images/radscheduleview_templating_timeruleritems_08.png)

## See Also

 * [Configuring the TimeRuler ticks]({%slug radscheduleview-features-timeruler-ticks-configuration%})

 * [Formatting properties]({%slug radscheduleview-features-formatting%})
 
 * [Styling the TimeRulerItems]({%slug radscheduleview-styles-and-templates-styling-timeruleritems%})
