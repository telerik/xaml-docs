---
title: Using Static Items
page_title: Using Static Items
description: Check our &quot;Using Static Items&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-populating-with-data-using-static-items
tags: using,static,items
published: True
position: 2
---

# Using Static Items

This tutorial will walk you through the common task of populating the __RadContextMenu__ with __RadMenuItems__ declaratively. 

Here is a regular __RadContextMenu__ declaration without items attached to a __TextBox__:

{% if site.site_name == 'Silverlight' %}


<snippet id='radcontextmenu-populating-with-data-using-static-items-block_1-xaml' />

{% endif %}

{% if site.site_name == 'WPF' %}


<snippet id='radcontextmenu-populating-with-data-using-static-items-block_2-xaml' />

{% endif %}

In order to add items you need to use the __RadContextMenu's Items__ property. The __Items__ property is an __ItemCollection__ which contains your __RadMenuItems__. For example, take a look at the following lines.

{% if site.site_name == 'Silverlight' %}


<snippet id='radcontextmenu-populating-with-data-using-static-items-block_3-xaml' />

{% endif %}
{% if site.site_name == 'WPF' %}


<snippet id='radcontextmenu-populating-with-data-using-static-items-block_4-xaml' />

{% endif %}

Here is a snapshot of the current result.

![{{ site.framework_name }} RadContextMenu with Static Items](images/RadContextMenu_Populating_with_Data_Static_Items_01.png)

>tip Each of the __RadMenuItems__ can have child items, that are defined in the same way.

The __RadMenuItem__ exposes an __Icon__ property, which allows you to specify an icon for it. Here is an example.

{% if site.site_name == 'Silverlight' %}


<snippet id='radcontextmenu-populating-with-data-using-static-items-block_5-xaml' />

{% endif %}

{% if site.site_name == 'WPF' %}


<snippet id='radcontextmenu-populating-with-data-using-static-items-block_6-xaml' />

{% endif %}

![{{ site.framework_name }} RadContextMenu with Items with Icons](images/RadContextMenu_Populating_with_Data_Static_Items_02.png)

>tip Consider declaring menu items in XAML instead of adding them by code whenever it's possible. This includes situations when you know what items you need at design time.

## See Also

 * [Data Binding Support Overview]({%slug radcontextmenu-populating-with-data-data-binding-support-overview%})

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})

 * [Template and Style Selectors]({%slug radcontextmenu-populating-with-data-template-and-style-selectors%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
