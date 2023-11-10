---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadHeatMap {{ site.framework_name }} control.
slug: radheatmap-overview
tags: overview
published: True
position: 0
CTAControlName: RadHeatMap
---

# {{ site.framework_name }} HeatMap Overview

The __RadHeatMap__ control can be used to visualize numeric data in a matrix like representation along two axes. Its purpose is to present the data in colored rectangles where the color of each represents the rectangle's value and makes it quite easy to perceive and compare all values.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![{{ site.framework_name }} RadHeatMap Overview](images/radheatmap-overview-0.png)

## Key Features

* __Different visualization set up mechanisms__: You can visualize the data differently based on the heatmap definition. There are two definitions types - __Categorical__ and __Horizontal/Vertical__. Read more about this in the [Populating With Data]({%slug radheatmap-populating-with-data%}) article.

* __Colorizers__: Each colorizer produces a collection of colors. RadHeatMap applies these colors to its children according to their values.  You can choose from the following list of available colorizers to customize the way your HeatMap looks. 

	* __HeatMapValueGradientColorizer__: Represents a colorizer, which contains a set of GradientStops. It chooses the color to be applied to the RadHeatMap item's value and colorizer's gradient stops. Each GradientStop.Offset value can be absolute or relative (between 0 and 1) depending on the IsAbsolute property value.

	* __HeatMapRangeColorizer__: Represents a colorizer, which contains a set of HeatMapRangeColor objects.It chooses the brush to be applied according to the cell's value and the From and To values of each HeatMapRangeColor. The values of each HeatMapRangeColor can be absolute or relative (between 0 and 1) depending on the IsAbsolute property value.
	
	Read more about this in the [Colorizers]({%slug radheatmap-colorizers%}) article.

* __Selection__: The control provides a visual selection of items. Read more about this in the [Selection]({%slug radheatmap-selection%}) article.

* __Tooltips__: RadHeatMap supports tooltips for its items. You can specify a tooltip template and display the details of the item itself. Read more about this in the [ToolTip]({%slug radheatmap-tooltip%}) article.

* __Row/Column Headers customization__: You can easily customize the labels inside the row/column headers. Read more about this in the [Labels]({%slug radheatmap-row-column-headers%}) article.

* __Labels__: You can show labels in the cells generated for the plotted data. Read more about this in the [Labels]({%slug radheatmap-labels%}) article.

* __Customizable templates__: The control allows you to customize the appearance of the control as well as its elements.

>tip Get started with the control with its [Getting Started]({%slug radheatmap-getting-started%}) help article that shows how to use it in a basic scenario.

> Check out the online demos at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#TabControl/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF HeatMap Homepage](https://www.telerik.com/products/wpf/heatmap.aspx)
* [Get Started with the Telerik UI for WPF HeatMap]({%slug radheatmap-getting-started%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF HeatMap Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also
* [Getting Started]({%slug radheatmap-getting-started%})
* [Developer Focused Examples]({%slug radheatmap-sdk-examples%})
