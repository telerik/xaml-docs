---
title: How to remove and modify the Icon area for RadMenu
page_title: How to remove and modify the Icon area for RadMenu
description: How to remove and modify the Icon area for RadMenu
slug: radmenu-how-to-remove-the-icon-area-for-radmenu
tags: how,to,remove,and,modify,the,icon,area,for,radmenu
published: True
position: 4
---

# How to remove and modify the Icon area for RadMenu

This article shows how to remove the Icon area and also how to modify it in order to fit different sized Icons.

* [How to remove the menu Icon area](#how-to-remove-the-menu-icon)

* [How to modify the menu Icon area](#how-to-modify-the-menu-icon-area)

## How to remove the menu Icon

By default each __MenuItem__ has reserved space for an Icon:

![](images/RadMenuIcon.jpg)

Since Q2 2010 __RadMenu__ has a property for defining the width of the column, which is reserved for the Icons. The property is called __IconColumnWidth__. And when set to 0 the space for the Icon disappears.

![](images/RadMenu_IconColumnWidth.jpg)

## How to modify the menu Icon area

By default all of the MenuItems has equal space reserved for an Icon. With the Q2 2013 version of the controls there is a new property named __IconColumnWidth__ which enables setting a custom Icon width on each __RadMenuItem/RadMenuGroupItem__.

![Rad Menu How To How to remove and modify the Icon area](images/RadMenu_HowTo_How_to_remove_and_modify_the_Icon_area.jpg)

#### __XAML__

{{region xaml-radmenu-how-to-remove-and-modify-icon-area_01}}
	<telerik:RadMenu VerticalAlignment="Top" IconColumnWidth="60">
	    <telerik:RadMenuItem Header="Circle Sizes" x:Name="sizeRadMenu" IconColumnWidth="0">
	        <telerik:RadMenuItem Header="Small" IconTemplate="{StaticResource IconTemplate}" IconColumnWidth="35" Height="35" />
	        <telerik:RadMenuItem Header="Medium" IconTemplate="{StaticResource IconTemplate}" IconColumnWidth="45" Height="45" />
	        <telerik:RadMenuItem Header="Large" IconTemplate="{StaticResource IconTemplate}" IconColumnWidth="55" Height="55" />
	    </telerik:RadMenuItem>
	</telerik:RadMenu>
{{endregion}}

# See Also

 * [Getting Started]({%slug radmenu-getting-started%})

 * [Icons]({%slug radmenu-features-icons%})

 * [Overview]({%slug radmenu-populating-with-data-overview%})
