---
title: Overview
page_title: Overview
description: This article lists the most important features of the RadContextMenu control.
slug: contextmenu-overview1
tags: overview
published: True
position: 1
---

# Overview


## {% if site.site_name == 'Silverlight' %}
![](images/RadContextMenu_Overview_01.png)
{% endif %}
{% if site.site_name == 'WPF' %}
![](images/RadContextMenu_Overview_01_WPF.png)
{% endif %}

Thank you for choosing __RadContextMenu__!        

Have you ever encountered the need of building a very complicated custom menu system, while still keeping it simple for the end user? It’s easy to save space and provide additional commands or features with the __RadContextMenu__.        

![Rad Context Menu Overview 03](images/RadContextMenu_Overview_03.png)

__RadContextMenu__ provides the power to boost the existing navigation of your application. Similar to RadMenu, __RadContextMenu__ allows you to combine the ability to display hierarchical views and the advanced styling mechanism, thus letting you build even the most complicated menu systems.   

## Key Features      

* __Multi-level Menu Items__: The control supports displaying hierarchical data. You can build multiple levels of menu items as needed to achieve the navigation you’d like. [Read More]({%slug radcontextmenu-populating-with-data-data-binding-support-overview%})

* __Hierarchical Data Binding__: The control allows you to bind and visualize sets of hierarchical data. You can also populate it by consuming data from XML files, WCF services, RIA services etc. [Read More]({%slug radcontextmenu-features-data-binding%})

* __Opening on a Specific Event__: You are able to specify the event that should trigger the __RadContextMenu__ opening. You can also specify a key, that should be pressed in combination with the event. [Read More]({%slug radcontextmenu-features-opening-on-specific-event%})

* __Styling and Appearance__: __RadContextMenu__ can be fully customized. There are also various pre-defined themes that can be used to style the control. [Read More]({%slug radcontextmenu-styles-and-templates-overview%})

{% if site.site_name == 'Silverlight' %}
* __Boundary Detection__: __RadContextMenu__ detects the Silverlight plug-in boundaries and opens its child item-groups in the opposite direction when the screen boundaries are to be crossed. When there is not enough space in both directions, the control will adjust its items’ position in order to make them visible whenever this is possible. [Read More]({%slug radcontextmenu-features-boundaries-detection%})
{% endif %}

* __UI Automation Support__: Check the [UI Automation Support]({%slug common-ui-automation%}) common article.

* __Enhanced Routed Events Framework__: The events system of the control will help your code become even more elegant and concise.       

>tip Get started with the control with its [Getting Started]({%slug contextmenu-getting-started%}) help article that shows how to use it in a basic scenario.

> Check out our examples at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#ContextMenu/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}.

## See Also

* [Visual Structure]({%slug radcontextmenu-visual-structure%})
* [Key Properties]({%slug radcontextmenu-key-properties%}) 
* [Events]({%slug radcontextmenu-events-overview%})
