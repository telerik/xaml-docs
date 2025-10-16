---
title: Resolve Axis Labels Clipping
page_title: Resolve Axis Labels Clipping
description: This article described the caching mechanism of the chartview.
slug: radchartview-troubleshooting-clipped-axis-labels
tags: troubleshooting,caching,mechanism,clipped,chart,label
published: True
position: 0
---

# Resolve Axis Labels Clipping

This article describes common behavior that can be encountered when using LabelTemplate for the chart axis. In general, if you set the size of the element in the template (at run-time) to a size bigger than the presenter that owns the template, the element will be clipped. This behavior comes from the size caching mechanism of the chart.
      
When the chart is initially loaded it caches the size of most of its elements, as labels and data point visuals, to optimize the performance by re-using the cached sizes. In order to update the size of those elements, you will need to manually change something in the chart via its public API. For example, change the value of a property or call a method. 

Lets take for example the scenario with custom LabelTemplate (of a chart axis) where the size of the element in the DataTemplate changes at run-time. Because the size of the ContentPresenter that wraps the element in the DataTemplate is cached, the element will be clipped if its size becomes bigger than the size of the ContentPresenter. In such case to trigger the size recalculation and update you can reset the LabelTemplate of the axis after you change the size of the element in the template.
	  	  
__Example 1: Updating the chart's API by resetting the LabelTemplate__

```C#	
	// change the size here
	
	var template = axis.LabelTemplate;
	axis.LabelTemplate = null;
	axis.LabelTemplate = template;
```
