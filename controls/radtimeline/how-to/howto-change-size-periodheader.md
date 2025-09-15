---
title: Change the size of the timelines' period header
page_title: Change the size of the timelines' period header
description: Check our &quot;Change the size of the timelines' period header&quot; documentation article for the RadTimeline {{ site.framework_name }} control.
slug: radtimeline-howto-change-size-periodheader
tags: change,timeline,size, height, timelineitemcontainer, 
published: True
position: 1
---

# Change the size of the timelines' period header

This help topic will demonstrate how to change the size of the RadTimeline' period header.

![RadTimeline - How to change the size of the period header 1](images/radtimeline-howto-change-size-periodheader-01.png)

The period header zone can be customized by using __PeriodHeaderStyle__ property of the RadTimeline. This accept a Style targeting a native Border element that is used for drawing the period header. 

You can use a custom Style to customize the period header. The following example demonstrates this approach. First we are going to declare our RadTimeline control.
 
__Example 1: Declare RadTimeline control__
```XAML
	<telerik:RadTimeline PeriodStart="2019-2-24" PeriodEnd="2020-2-24" Height="200">
		<telerik:RadTimeline.Intervals>
			<telerik:YearInterval />
			<telerik:QuarterInterval />
			<telerik:MonthInterval />
			<telerik:WeekInterval />
			<telerik:DayInterval />
		</telerik:RadTimeline.Intervals>
	</telerik:RadTimeline>
```

Now to increase the size of the period header, we can create custom style targeting Border element and set its Height property to custom value.	
	
__Example 2: Customize the Period Header__
```XAML
	<telerik:RadTimeline PeriodStart="2019-2-24"
						PeriodEnd="2020-2-24" 
						Height="200">
		<telerik:RadTimeline.PeriodHeaderStyle>
			<Style TargetType="Border">
				<Setter Property="VerticalAlignment" Value="Top"/>
				<Setter Property="BorderBrush" Value="Bisque" />
				<Setter Property="BorderThickness" Value="2" />
				<Setter Property="Height" Value="50" />
			</Style>
		</telerik:RadTimeline.PeriodHeaderStyle>
		<telerik:RadTimeline.Intervals>
			<telerik:YearInterval />
			<telerik:QuarterInterval />
			<telerik:MonthInterval />
			<telerik:WeekInterval />
			<telerik:DayInterval />
		</telerik:RadTimeline.Intervals>
	</telerik:RadTimeline>
```

![RadTimeline - How to change the size of the period header 2](images/radtimeline-howto-change-size-periodheader-02.png)

> In a scenario when you have applied grouping, you have to keep in mind that when you change the height of the period header, you will also need to update the padding of the __TimelineItemGroupsPanel__ element. Otherwise, the first group will be overlapped by the period header Border element.

To update the padding of the __TimelineItemGroupsPanel__ element, we can create a custom implicit style. __Example 2__ demonstrates this:

__Example 3: Update Padding of the TimelineItemGroupsPanel__
```XAML
	<Window.Resources>
		<Style TargetType="telerik:TimelineItemContainer" >
			<Setter Property="ItemsPanel">
				<Setter.Value>
					<ItemsPanelTemplate>
						<telerik:TimelineItemGroupsPanel Padding="0 70 0 5" />
					</ItemsPanelTemplate>
				</Setter.Value>
			</Setter>
		</Style>
	</Window.Resources>
```


## See Also
 * [Overview] ({%slug radtimeline-overview %})
 * [Properties]({%slug radtimeline-properties %})
 * [DataBinding]({%slug radtimeline-databinding %})
 * [SDK Examples]({%slug radtimeline-sdk-examples %})
