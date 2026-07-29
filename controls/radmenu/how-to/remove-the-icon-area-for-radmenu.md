---
title: How to Remove and Modify the Icon Area for RadMenu
page_title: How to Remove and Modify the Icon Area for RadMenu
description: Check our &quot;How to remove and modify the Icon area for RadMenu&quot; documentation article for the RadMenu {{ site.framework_name }} control.
slug: radmenu-how-to-remove-the-icon-area-for-radmenu
tags: how,to,remove,and,modify,the,icon,area,for,radmenu
published: True
position: 4
---

# How to Remove and Modify the Icon Area for RadMenu

This article shows how to remove the Icon area and also how to modify it in order to fit different sized Icons.

## How to Remove the Menu Icon

By default each __MenuItem__ has reserved space for an icon:

![RadMenu Icon Area](images/RadMenuIcon.jpg)

Since Q2 2010 __RadMenu__ has a property for defining the width of the column, which is reserved for the Icons. The property is called __IconColumnWidth__. When you set this property to 0 the space for the icons disappears.

![{{ site.framework_name }} RadMenu Icon Column Width 0](images/RadMenu_IconColumnWidth.jpg)

## Set Different Icon Area Width for Each MenuItem

By default all of the MenuItems have equal space reserved for an icon. You can control the width of each MenuItem icon area by using the items' __IconColumnWidth__ property.

__Example 1: Modify MenuItem Icon Area Width__
<snippet id='radmenu-how-to-remove-the-icon-area-for-radmenu-block_1-xaml' />

![Modify MenuItem Icon Area Width](images/RadMenu_HowTo_How_to_remove_and_modify_the_Icon_area.jpg)

## See Also

 * [Getting Started]({%slug radmenu-getting-started%})
 * [Icons]({%slug radmenu-features-icons%})
 * [Overview]({%slug radmenu-populating-with-data-overview%})