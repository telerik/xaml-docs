---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
slug: radradialmenu-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic covers the specific events exposed by the __RadRadialMenu__ control. 

## RadRadialMenu Events

The __RadRadialMenu__ control raises the following specific events:

* __Opening__: Occurs before __RadRadialMenu__ gets opened.             

* __Opened__: Occurs each time the __RadialMenu__ gets opened.            

* __Closed__: Occurs each time __RadRadialMenu__ gets closed.            

* __Navigated__: Occurs when the user navigates to another view (child items) or returns back through the RadialMenuButton.            

All of the listed events receive two arguments:

* The sender argument contains the __RadRadialMenu__. This argument is of type object, but can be cast to the __RadRadialMenu__ type.

* A __RadRoutedEventArgs__ object.

### PreviewToolTipOpen

The [PreviewToolTipOpen]({%slug radradialmenu-howto-customize-tooltip%}#change-the-tooltip-position) event occurs when the ToolTip is about to be shown. The event receives the following arguments:            

* The sender argument contains the __RadRadialMenu__. This argument is of type object, but can be cast to the __RadRadialMenu__ type.                

* __RadialMenuNavigatingEventArgs__ object. It provides __Placement__ property which sets the position of the ToolTip.

### Navigating

Available, since the __R1 2021__ release and occurs before a menu level changes. The event receives the following arguments:

* The sender argument contains the __RadRadialMenu__. This argument is of type object, but can be cast to the __RadRadialMenu__ type.                

* __RadialMenuNavigatingEventArgs__ object, which exposes the following properties:

	* __IsNavigatingBack__: A boolean property, which indicates whether the user is navigating backward. 

	* __MenuItemSource__: Gets the menu item from which the navigation started, if there is one.

	* __MenuItemTarget__: Gets the menu item to which the user is trying to navigate to.

	* __AutoSizeMenuItems__: Gets or sets whether the level to which the user is navigating will have its segments [auto-sized]({%slug radradialmenu-features-configuration%}#automatically-size-the-menuitems).

__Example 1: Handling the Navigating event__

```C#
	private void RadRadialMenu_Navigating(object sender, Controls.RadialMenuNavigatingEventArgs e)
	{
		// Auto-size menu items only when they are more than 2
		if (e.MenuItemTarget != null && e.MenuItemTarget.ChildItems.Count <= 2)
		{
			e.AutoSizeMenuItems = false;
		}
	}
```

## RadRadialMenuItem Events

__RadRadialMenuItem__ raises the following specific event: 

* __Click__: Occurs each time an item gets clicked. The event handler receives two arguments:            

	* The sender argument contains the __RadRadialMenuItem__. This argument is of type object, but can be cast to the __RadRadialMenuItem__ type.                  

	* A __RadRoutedEventArgs__ object.                  
