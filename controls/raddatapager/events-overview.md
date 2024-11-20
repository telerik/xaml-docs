---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadDataPager {{ site.framework_name }} control.
slug: raddatapager-events-overview
tags: events
published: True
position: 6
---

# {{ site.framework_name }} DataPager Events

This topic covers the specific events exposed by the __RadDataPager__ control.

The __RadDataPager__ control raises the following specific events:

* __PageIndexChanging__ - occurs before the __PageIndex__ gets changed. The event handler receives two arguments: 

* The sender argument contains the __RadDataPager__. This argument is of type object, but can be cast to the __RadDataPager__ type. 

* A [PageIndexChangingEventArgs ](http://www.telerik.com/help/wpf/t_telerik_windows_controls_pageindexchangingeventargs.html) object.

* __PageIndexChanged__ - occurs after the __PageIndex__ has been changed. The event handler receives two arguments: 

* The sender argument contains the __RadDataPager__. This argument is of type object, but can be cast to the __RadDataPager__ type. 

* A [PageIndexChangedEventArgs ](http://www.telerik.com/help/wpf/t_telerik_windows_controls_pageindexchangedeventargs.html) object.

## See Also  
 * [Getting Started]({%slug raddatapager-getting-started%})
 * [Interact with the User before the Page Changes]({%slug raddatapager-how-to-interact-with-with-user-before-page-changes%})
