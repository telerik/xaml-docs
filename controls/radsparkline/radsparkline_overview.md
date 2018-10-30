---
title: Overview
page_title: Overview
description: Overview
slug: radsparkline_overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'WPF' %}![sparklines wpf](images/sparklines_wpf.png){% endif %}{% if site.site_name == 'Silverlight' %}![sparklines sl](images/sparklines_sl.png){% endif %}

__RadSparkline__ is a set of controls that show an information graphic. The controls are characterized by small size, excellent performance and lightweight. By definition, the sparkline is mainly used to outline trends. However, it is very flexible in terms of data points generation and can contain from just a few points, to as many as thousands of data points.

In terms of data visualization, RadSparkline is comparable to [RadCartesianChart]({%slug radchartview-overview%}). However, in order to maximize performance, the spark lines do not utilize this many visual indicators. They also don't use an x or y axis, or multiple axes.

![RadSparkLine Overview](images/sparkline-overview-0.png)

## Key Features

* __Different visualization types__: You can use the controls from the sparkline suite to visualize your data using line, points, bars, etc. Read more about this in the [Sparkline Types]({%slug radsparkline-getting-started-types%}) article.

* __Indicators__: The indicators are visual markers that can be used to annotate the data point positions or highlight values from the plotted data. Read more about this in the [Indicators]({%slug radsparkline-features-indicators%}) article.

* __Horizontal axis__: The sparkline allows you to draw a horizontal axis that can be used to annotate the data trend. Read more about this in the [Axis]({%slug radsparkline-features-axis%}) article.

>tip Check out the [Getting Started]({%slug radsparkline-getting-started%}) help article that shows how to use the controls in a basic scenario.

> Check out the online demos at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#BulletGraph/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}

## See Also
 * [Data Binding]({%slug radsparkline_databinding%})
 * [Indicators]({%slug radsparkline-features-indicators%})