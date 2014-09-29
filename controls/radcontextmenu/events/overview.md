---
title: Overview
page_title: Overview
description: Overview
slug: radcontextmenu-events-overview
tags: overview
published: True
position: 0
---

# Overview



## 

This topic covers the specific events exposed by the __RadContextMenu__control.
        

The __RadContextMenu__is an __ItemsControl__. Almost all of the exposed events are inherited from the __ItemsControl__ class. The __RadContextMenu__adds several additional events for the developer.
        {% if site.site_name == 'Silverlight' %}

>tip
            To learn more about the events raised by the __RadMenuItem,__ please take a look at the [RadMenu's help](http://www.telerik.com/help/silverlight/radmenu-overview.html).
          {% endif %}{% if site.site_name == 'WPF' %}

>tip
            To learn more about the events raised by the __RadMenuItem,__ please take a look at the [RadMenu's help](http://www.telerik.com/help/wpf/radmenu-overview.html).
          {% endif %}

The __RadContextMenu__control raises the following specific event:
        

* __ItemClick__ - occurs each time an item in the __RadContextMenu__gets clicked. The event handler receives two arguments:
            

* 
                The sender argument contains the __RadContextMenu__. This argument is of type object but can be cast to the __RadContextMenu__type.
              

* 
                A __RadRoutedEventArgs__ object.
              

>If the __RadMenuItem__ is in the role of a header (has child items), the __ItemClick__ event won't be raised, unless the __NotifyOnHeaderClick__ property is set to __True__.
              

>The __ItemClick__ event is fired after the __Click__ event of the clicked __RadMenuItem__.
              

* __Opening__ - occurs each time before __RadContextMenu__ gets opened. The event handler receives two arguments:
            

* 
                The sender argument contains the __RadContextMenu__. This argument is of type object but can be cast to the __RadContextMenu__type.
              

* 
                A __RadRoutedEventArgs__ object.
              If you handle this event (set e.Handled = true), you will prevent __RadContextMenu__ to open.
            

* __Opened__ - occurs each time the __RadContextMenu__ gets opened. The event handler receives two arguments:
            

* 
                The sender argument contains the __RadContextMenu__. This argument is of type object but can be cast to the __RadContextMenu__type.
              

* 
                A __RoutedEventArgs__ object.
              

* __Closed__ - occurs each time the __RadContextMenu__ gets closed. The event handler receives two arguments:
            

* 
                The sender argument contains the __RadContextMenu__. This argument is of type object but can be cast to the __RadContextMenu__type.
              

* 
                A __RoutedEventArgs__ object.
              

# See Also

 * [Overview]({%slug radcontextmenu-overview%})

 * [Visual Structure]({%slug radcontextmenu-visual-structure%})

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Populating with Data - Overview]({%slug radcontextmenu-populating-with-data-overview%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
