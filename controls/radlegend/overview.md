---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadLegend {{ site.framework_name }} control.
slug: radlegend-overview
tags: overview
published: True
position: 0
CTAControlName: RadLegend
---

# Overview

__RadLegend__ is a stand-alone control which visualizes a list of legend items. The control could be used to create a legend for a chart ot other type of data visualization.  

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![WPF RadLegend ](images/radlegend-overview-0.png)

## Key Features

* __Default geometry visualization__: The visual items of legend come with a predefined template that contains a small rectangle geometry marking the color of the item and also a text title.

* __Flexible customization__: The legend items can be easily customized via the LegendItem objects which populate the control's Items collection. Additionally, you can fully customize the visual via the [ItemTemplate]({%slug radlegend-itemtemplate%}) of the control.

* __RadChartView integration__: The controls from the RadChartView suite come with a built-in [support for the RadLegend control]({%slug radchartview-features-radlegend-support%}).

>tip Get started with the control with its [Getting Started]({%slug radlegend-getting-started%}) help article that shows how to use it in a basic scenario.

> You can see the RadLegend control demonstrated mostly in the RadChartView examples from the demo application that can found at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#TabControl/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}

## See Also
* [ItemsPanel]({%slug radlegend-itemspanel%})
* [Marker Geometry]({%slug radlegend-marker-geometry%})
