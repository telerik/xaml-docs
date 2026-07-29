---
title: Add Scrolling to RadContextMenu
page_title: Add Scrolling to RadContextMenu
description: Check our &quot;Add Scrolling to RadContextMenu&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-how-to-add-scrolling-to-radcontextmenu
tags: add,scrolling,to,radcontextmenu
published: True
position: 5
---

# Add Scrolling to RadContextMenu

Anytime you implement a RadContextMenu which displays a long list of items, or simply wish to limit the number of items visible in the menu, you can add scrolling functionality to RadContextMenu, and more specifically vertical scrolling. The process to do that is very simple and straightforward. This article will guide you through the process. 

## Use Height and DropDownHeight properties      

__RadContextMenu__ has Height property. If you set it, but the __RadMenuItems__ inside it doesn't fit in this size, you will see two buttons which can be used to scroll through your collection:

![Rad Context Menu Scrolling 01](images/RadContextMenu_Scrolling_01.png)

But if any of your __RadMenuItems__ has submenu items, they will be placed inside another popup. That's why we've added *DropDownHeight* property for __RadMenuItem__. The value of the property shows the height of RadMenuItem's submenu. The behavior when the items doesn't fit in the set DropDownHeight is the same as described above:

![Rad Context Menu Scrolling 02](images/RadContextMenu_Scrolling_02.png)

Here's a simple code that shows how to use Height and DropDownHeight properties:



<snippet id='radcontextmenu-how-to-add-scrolling-to-radcontextmenu-block_1-xaml' />


## Scrolling in RadMenuGroupItem

If you are using __RadMenuGroupItem__ you can control scrolling inside it via ScrollViewer's attached properties - VerticalScrollBarVisibility and HorizontalScrollBarVisibility.



<snippet id='radcontextmenu-how-to-add-scrolling-to-radcontextmenu-block_2-xaml' />


![Rad Context Menu Scrolling 03](images/RadContextMenu_Scrolling_03.png)
