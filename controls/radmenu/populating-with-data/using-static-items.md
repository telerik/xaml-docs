---
title: Using Static Items
page_title: Using Static Items
description: Check our &quot;Using Static Items&quot; documentation article for the RadMenu {{ site.framework_name }} control.
slug: radmenu-populating-with-data-using-static-items
tags: using,static,items
published: True
position: 2
---

# Using Static Items

This tutorial will walk you through the common task of populating __RadMenu__ with __RadMenuItems__ declaratively. 

__Example 1__ shows a regular __RadMenu__ declaration without items.

__Example 1: RadMenu declaration__

<snippet id='radmenu-populating-with-data-using-static-items-block_1-xaml' />

In order to add items you need to use the __RadMenu's Items__ property. The __Items__ property is an __ItemCollection__ which contains your __RadMenuItems__. For example, the following lines will add the top-level items of the menu.

__Example 2: RadMenu with static top-level items__

<snippet id='radmenu-populating-with-data-using-static-items-block_2-xaml' />

#### __Figure 1: RadMenu with static top-level items__

![{{ site.framework_name }} RadMenu with Static Top Level Items](images/RadMenu_Populating_with_Data_Using_Static_Items_01.png)

Each of the __RadMenuItems__ can have child items that are defined in the same way. __Example 3__ illustrates how to add submenu items to one of the top-level items.

__Example 3: Adding static submenu items__

<snippet id='radmenu-populating-with-data-using-static-items-block_3-xaml' />

#### __Figure 2: RadMenu with static submenu items__
![{{ site.framework_name }} RadMenu RadMenu with static submenu items](images/RadMenu_Populating_with_Data_Using_Static_Items_02.png)

The submenu items can also have children on their own.

## See Also

 * [Populating with Data - Overview]({%slug radmenu-populating-with-data-overview%})

 * [Data Binding Support Overview]({%slug radmenu-populating-with-data-data-binding-support-overview%})

 * [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%})