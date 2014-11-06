---
title: Events
page_title: Events
description: Events
slug: raddatapager-events-overview
tags: events
published: True
position: 6
---

# Events

This topic covers the specific events exposed by the __RadDataPager__ control.

The __RadDataPager__ control raises the following specific events:

* __PageIndexChanging__ - occurs before the __PageIndex__ gets changed. The event handler receives two arguments: 

* The sender argument contains the __RadDataPager__. This argument is of type object, but can be cast to the __RadDataPager__ type. 

* A
                {% if site.site_name == 'Silverlight' %}[PageIndexChangingEventArgs ](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_pageindexchangingeventargs.html){% endif %}{% if site.site_name == 'WPF' %}[PageIndexChangingEventArgs ](http://www.telerik.com/help/wpf/t_telerik_windows_controls_pageindexchangingeventargs.html){% endif %}
                object.

* __PageIndexChanged__ - occurs after the __PageIndex__ has been changed. The event handler receives two arguments: 

* The sender argument contains the __RadDataPager__. This argument is of type object, but can be cast to the __RadDataPager__ type. 

* A {% if site.site_name == 'Silverlight' %}[PageIndexChangedEventArgs ](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_pageindexchangedeventargs.html){% endif %}{% if site.site_name == 'WPF' %}[PageIndexChangedEventArgs ](http://www.telerik.com/help/wpf/t_telerik_windows_controls_pageindexchangedeventargs.html){% endif %} object.

# See Also

 * [Getting Started]({%slug raddatapager-getting-started%})

 * [Paging Essentials]({%slug raddapager-features-paging-essentials%})

 * [Interact with the User before the Page Changes]({%slug raddatapager-how-to-interact-with-with-user-before-page-changes%})
