---
title: Caching mechanism
page_title: Caching mechanism
description: This article described the Caching mechanism of the chartview.
slug: radchartview-troubleshooting-caching-mechanism
tags: troubleshooting,caching,mechanism,clipped,chart,label
published: True
position: 0
---

# Caching mechanism

This article describes common behavior that can be encountered from the caching mechanism of the RadChartView.
      
When the chart is loaded it caches the size of most of its elements, as labels and data point visuals to optimize the performance and it uses this cache size. In order to update these elements, you need to update a property or call a method from the chart's API. 

For example, in a scenario with custom label template where the size of the element in the DataTemplate changes at run-time. Because the size of the ContentPresenter that wraps the elements in the DataTemplate is cached, the element will be clipped if its size becomes bigger than the size of the ContentPresenter. In such case to trigger the size update you can reset the PointTemplate of the series after you change the size.
	  	  
#### __[C#] Example 1: Updating the chart by resetting the PointTemplate__

{{region radchartview-troubleshooting-caching-mechanism_0}}
	var template = series.PointTemplate;
	series.PointTemplate = null;
	series.PointTemplate = template;
{{endregion}}


