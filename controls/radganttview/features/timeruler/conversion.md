---
title: Conversion between Pixels and PixelLength
page_title: Conversion between Pixels and PixelLength
description: Conversion between Pixels and PixelLength
slug: radganttview-features-timeruler-conversion
tags: conversion,between,pixels,and,pixellength
publish: True
position: 1
---

# Conversion between Pixels and PixelLength



In this help article I will demonstrate how you could set real pixels to the __PixelLength__ property of the RadGanttView control which is of __TimeSpan__ type.
            

Usually you would be setting the PixelLength property to for example 1 hour and 30 minutes but in some cases it is more useful to be able to set the PixelLength to real pixels in order to be able to fill a specific area in your application. In those cases you could either test and see what TimeSpan is appropriate for you or use the approach that is discussed in this article to set it to exact pixel number.
            

## Converting Pixels to PixelLength

The PixelLength property of the RadGanttView control is responsible for setting the horizontal size of the TimeRuler and in order to set it to a value that represents pixels you will need to implement the following formula:
                

__PixelLength = (Ticks of the VisibleRange) / (desired pixels)__

The next code snippets shows how to implement the above formula in order to set the PixelLength to 760 pixels:
                

#### __XAML__

{{region radganttview-features-timeruler-conversion-1}}
	<telerik:RadGanttView x:Name="GanttView">
	    ...
	</telerik:RadGanttView>
	{{endregion}}



#### __C#__

{{region radganttview-features-timeruler-conversion-1}}
	var maxTicks = this.GanttView.VisibleRange.End.Subtract(this.GanttView.VisibleRange.Start).Ticks / 760;
	
	this.GanttView.PixelLength = TimeSpan.FromTicks(maxTicks);
	{{endregion}}



## Converting PixelLength to Pixels

The inverse conversion of PixelLength to pixels could be implemented by the following formula:
                

__Pixels = (Ticks of the VisibleRange) / (desired PixelLength.Ticks)__

The next code snippets show how to implement the described above formula in order to get the Pixels representation of desired TimeSpan:
                

#### __XAML__

{{region radganttview-features-timeruler-conversion-1}}
	<telerik:RadGanttView x:Name="GanttView">
	    ...
	</telerik:RadGanttView>
	{{endregion}}



#### __C#__

{{region radganttview-features-timeruler-conversion-2}}
	var maxTicks = this.GanttView.PixelLength.Ticks;
	
	var pixels = this.GanttView.VisibleRange.End.Subtract(this.GanttView.VisibleRange.Start).Ticks / maxTicks;
	{{endregion}}



>tipYou can download a runnable project of the previous example from our online SDK repository
                        [here](https://github.com/telerik/xaml-sdk), the example is listed as __GanttView / PixelsToPixelLengthConversion__.
                    
