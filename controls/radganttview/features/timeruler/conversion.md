---
title: Pixels and PixelLength Conversion
page_title: Conversion between Pixels and PixelLength
description: Check our &quot;Conversion between Pixels and PixelLength&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-features-timeruler-conversion
tags: conversion,between,pixels,and,pixellength
published: True
position: 1
---

# Pixels and PixelLength Conversion 

This article demonstrates how to convert between screen size (in pixels) and TimeSpan value representing the PixelLength of RadGanttView.

The PixelLength property works with TimeSpan values, like 1 hour, 30 minutes and so on. In some cases it is more useful to be able to set the PixelLength based on screen size in order to be able to fill a specific area in the application. In those cases you can manually test and see what TimeSpan is appropriate by hardcoding values or you can use the approach that is discussed in this article to set it to exact pixel number. 

## Converting Pixels to PixelLength

The PixelLength property of the RadGanttView control is responsible for setting the horizontal size of the TimeRuler. In order to set it to a value that matches actual screen size you can use the following formula.

`PixelLength = (Ticks of the VisibleRange) / (desired pixels)`

  
```C#	
	double pixelsWidth = 760;
	var maxTicks = this.GanttView.VisibleRange.End.Subtract(this.GanttView.VisibleRange.Start).Ticks / pixelsWidth;	
	this.GanttView.PixelLength = TimeSpan.FromTicks(maxTicks);
```

## Converting PixelLength to Pixels

The inverse conversion of PixelLength to pixels could be implemented with the following formula: 

`Pixels = (Ticks of the VisibleRange) / (desired PixelLength.Ticks)`

  
```C#
	var maxTicks = this.GanttView.PixelLength.Ticks;	
	var pixels = this.GanttView.VisibleRange.End.Subtract(this.GanttView.VisibleRange.Start).Ticks / maxTicks;
```

>tip Find a runnable project showing the previous methods in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/GanttView/PixelsToPixelLengthConversion).