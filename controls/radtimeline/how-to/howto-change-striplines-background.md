---
title: Change the periods strip lines background
page_title: Change the periods strip lines background
description: Check our &quot;Change the periods strip lines background&quot; documentation article for the RadTimeline {{ site.framework_name }} control.
slug: radtimeline-howto-change-striplines-background
tags: change,timeline,background, striplines, strip, lines
published: True
position: 1
---

# Change the periods' strip line background

This help topic will demonstrate how to change the background of the strip lines displayed behind the RadTimeline control’s periods. 
![RadTimeline - How to change the strip lines background 1](images/radtimeline-howto-change-striplines-background-01.png)

The lines are represented by __TimelineStripLineControl__ which exposes couple of Style properties that can be used for changing its background. They accept a Style targeting a native Border element that is used for drawing the strip lines. 
* __NormalStyle__ - this style is applied on each odd strip line occurrence
* __AlternateStyle__ - this style is applied on each even strip line occurrence

You can use an implicit Style to set the style on the __TimelineStripLineControls__. The following example demonstrates this approach:
 

```XAML
	<telerik:RadTimeline PeriodStart="2015-2-24" 
						 PeriodEnd="2016-2-24" 
						 Height="200">
		<telerik:RadTimeline.Intervals>
			<telerik:YearInterval />
			<telerik:QuarterInterval />
			<telerik:MonthInterval />
			<telerik:WeekInterval />
			<telerik:DayInterval />
		</telerik:RadTimeline.Intervals>
	</telerik:RadTimeline>
```
	

```XAML
	<Window.Resources>
		<Style TargetType="Border" x:Key="normalStyle">
			<Setter Property="Background" Value="#F67E4B" />
		</Style>

		<Style TargetType="Border" x:Key="alternateStyle">
			<Setter Property="Background" Value="#FCE4C2" />
		</Style>

		<Style TargetType="telerik:TimelineStripLineControl">
			<Setter Property="NormalStyle" Value="{StaticResource normalStyle}" />
			<Setter Property="AlternateStyle" Value="{StaticResource alternateStyle}" />
		</Style>
	</Window.Resources>
```

> The RadTimeline control doesn't expose a property that sets/gets the Style for the TimelineStripLineControls and this is why we define the style implicitly in the resources.
	
![RadTimeline - How to change the strip lines background 2](images/radtimeline-howto-change-striplines-background-02.png)

## See Also
 * [Overview] ({%slug radtimeline-overview %})
 * [Properties]({%slug radtimeline-properties %})
 * [DataBinding]({%slug radtimeline-databinding %})
 * [SDK Examples]({%slug radtimeline-sdk-examples %})