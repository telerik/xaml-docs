---
title: ItemTemplate
page_title: ItemTemplate
description: Check our &quot;ItemTemplate&quot; documentation article for the RadLegend {{ site.framework_name }} control.
slug: radlegend-itemtemplate
tags: itemtemplate
published: True
position: 1
---

# ItemTemplate

The RadLegend control exposes an ItemTemplate property which you can use to change the default ItemTemplate. The DataContext of the template is a LegendItem object.

{% if site.site_name == 'Silverlight' %}
Note that a GeometryCloneConverter is used in the Path.Data Binding. This is to work around a limitation in the Silverlight framework, where an exception is  thrown when a static resource is used to set the Data property of a Path.
{% endif %}

A simple demonstration how to use the ItemTemplate property is given below:

{% if site.site_name == 'WPF' %}

<snippet id='radlegend-itemtemplate-simple_demonstration_wpf-xaml' />
{% endif %}

{% if site.site_name == 'Silverlight' %}

<snippet id='radlegend-itemtemplate-simple_demonstration_silverlight-xaml' />
{% endif %}

And here is the end result:
![radlegend-itemtemplate-0](images/radlegend-itemtemplate-0.png)