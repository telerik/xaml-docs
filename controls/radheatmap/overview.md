---
title: Overview
page_title: Overview
description: Overview
slug: radheatmap-overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'Silverlight' %}
![](images/heatmap_sl_46_text.png)
{% endif %}{% if site.site_name == 'WPF' %}
![](images/heatmap_wpf_46_text.png)
{% endif %}

Thank you for choosing Telerik __RadHeatMap__!			

The __RadHeatMap__ control can be used to visualize numeric data in a matrix like representation along two axes. Its purpose is to present the data in colored rectangles where the color of each represents the rectangle's value and makes it quite easy to perceive and compare all values.

>In order to use __RadHeatMap__ control in your projects you have to add references to the following assemblies: 
>	- __Telerik.Windows.Controls.dll__
>	- __Telerik.Windows.Controls.DataVisualization.dll__ 
>	- __Telerik.Windows.Data.dll__

__RadHeatMap's key features list:__

* Two types of HeatMap definitions:
	* __Categorical__
	* __Horizontal/Vertical__

* __Colorizers__ - each colorizer produces a collection of colors. RadHeatMap applies these colors to its children according to their values.  You can choose from the following list of available colorizers to customize the way your HeatMap looks:

* __HeatMapValueGradientColorizer__ - represents a colorizer, which contains a set of GradientStops. It chooses the color to be applied to the RadHeatMap item's value and colorizer's gradient stops. Each GradientStop.Offset value can be absolute or relative (between 0 and 1) depending on the IsAbsolute property value.

* __HeatMapRangeColorizer__ - represents a colorizer, which contains a set of HeatMapRangeColor objects.It chooses the brush to be applied according to the cell's value and the From and To values of each HeatMapRangeColor. The values of each HeatMapRangeColor can be absolute or relative (between 0 and 1) depending on the IsAbsolute property value.

* __Tooltips__ - RadHeatMap supports tooltips for its items. You can specify a tooltip template and display the details of the item itself. 

* __Customizeable templates__ - allows you to customize the appearance of the control as well as its elements.