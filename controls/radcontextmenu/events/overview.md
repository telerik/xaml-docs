---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic covers the specific events exposed by the __RadContextMenu__ control.

The __RadContextMenu__ is an __ItemsControl__. Almost all of the exposed events are inherited from the __ItemsControl__ class. The __RadContextMenu__ adds several additional events for the developer.

>tip To learn more about the events raised by the __RadMenuItem__, please take a look at the [RadMenu's help]({%slug radmenu-overview%}).

The __RadContextMenu__ control raises the following specific event:        

* __ItemClick__ - occurs each time an item in the __RadContextMenu__ gets clicked. The event handler receives two arguments:

	* The sender argument contains the __RadContextMenu__. This argument is of type object but can be cast to the __RadContextMenu__ type.

	* A __RadRoutedEventArgs__ object.

>If the __RadMenuItem__ is in the role of a header (has child items), the __ItemClick__ event won't be raised, unless the __NotifyOnHeaderClick__ property is set to __True__.              

>The __ItemClick__ event is fired after the __Click__ event of the clicked __RadMenuItem__.              

* __Opening__ - occurs each time before __RadContextMenu__ gets opened. The event handler receives two arguments:            

	* The sender argument contains the __RadContextMenu__. This argument is of type object but can be cast to the __RadContextMenu__ type.              

	* A __RadRoutedEventArgs__ object.

	If you handle this event (set e.Handled = true), you will prevent __RadContextMenu__ to open.            

* __Opened__ - occurs each time the __RadContextMenu__ gets opened. The event handler receives two arguments:

	* The sender argument contains the __RadContextMenu__. This argument is of type object but can be cast to the __RadContextMenu__ type.

	* A __RoutedEventArgs__ object.

* __Closed__ - occurs each time the __RadContextMenu__ gets closed. The event handler receives two arguments:

	* The sender argument contains the __RadContextMenu__. This argument is of type object but can be cast to the __RadContextMenu__ type.

	* A __RoutedEventArgs__ object.

## See Also

 * [Overview]({%slug contextmenu-overview1%})

 * [Visual Structure]({%slug radcontextmenu-visual-structure%})

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
