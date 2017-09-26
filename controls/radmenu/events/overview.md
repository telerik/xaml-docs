---
title: Overview
page_title: Overview
description: Overview
slug: radmenu-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic covers the specific events exposed by the __RadMenu__ control.
        

The __RadMenu__ is an __ItemsControl__. Almost all of the exposed events are inherited from the __ItemsControl__ class. The __RadMenu__ and the __RadMenuItem__ add several additional events for the developers.        

The __RadMenu__ control raises the following specific event:        

* __ItemClick__ - occurs each time an item in the __RadMenu__ gets clicked. The event handler receives two arguments:            

	* The sender argument contains the __RadMenu__. This argument is of type object, but can be cast to the __RadMenu__ type.              

	* A __RadRoutedEventArgs__ object.              

>By default this event won't fire for items that contain child menu items. You can change this behavior by setting the __NotifyOnHeaderClick__ property of the __RadMenu__ to __True__.          

>The __ItemClick__ event is fired after the __Click__ event of the clicked __RadMenuItem__.          

The __RadMenuItem__ raises the following specific events:        

* __Checked__ - occurs each time the item gets checked (occurs only for checkable items). The event handler receives two arguments:            

	* The sender argument contains the __RadMenuItem__. This argument is of type object, but can be cast to the __RadMenuItem__ type.              

	* An __RoutedEventArgs__ object.              

* __Click__ - occurs each time the item gets clicked. The event handler receives two arguments:            

	* The sender argument contains the __RadMenuItem__. This argument is of type object, but can be cast to the __RadMenuItem__ type.

	* A __RadRoutedEventArgs__ object.

>By default this event won't fire for items that contain child menu items. You can change this behavior by setting the __NotifyOnHeaderClick__ property of the __RadMenu__ to __True__.

* __SubmenuClosed__ - occurs each time the child items of the item get hidden. The event handler receives two arguments:

	* The sender argument contains the __RadMenuItem__. This argument is of type object, but can be cast to the __RadMenuItem__ type.

	* A __RadRoutedEventArgs__ object.

* __SubmenuOpened__ - occurs each time the child items of the item get displayed. The event handler receives two arguments:

	* The sender argument contains the __RadMenuItem__. This argument is of type object, but can be cast to the __RadMenuItem__ type.

	* A __RadRoutedEventArgs__ object.

* __Unchecked__ - occurs each time the item gets unchecked (occurs only for checkable items). The event handler receives two arguments:

	* The sender argument contains the __RadMenuItem__. This argument is of type object, but can be cast to the __RadMenuItem__ type.

	* A __RoutedEventArgs__ object.

>If a checkable item is clicked, the __Click__ of the __RadMenuItem__ and the __ItemClick__ of the __RadMenu__ events will occur first and then the __Checked__/__Unchecked__ events.

## See Also

 * [Overview]({%slug radmenu-overview%})

 * [Visual Structure]({%slug radmenu-visual-structure%})

 * [Populating with Data - Overview]({%slug radmenu-populating-with-data-overview%})
