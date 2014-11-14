---
title: Overview
page_title: Overview
description: Overview
slug: radradialmenu-events-overview
tags: overview
published: True
position: 0
---

# Overview



This topic covers the specific events exposed by the __RadRadialMenu__ control. 

## RadRadialMenu Events

The __RadRadialMenu__ control raises the following specific events:

* __Opening__ - occurs before __RadRadialMenu__ gets opened.             

* __Opened__ - occurs each time the __RadialMenu__ gets opened.            

* __Closed__ - occurs each time __RadRadialMenu__ gets closed.            

* __Navigated__ - occurs when the user navigates to another view (child items) or returns back through the RadialMenuButton.            

All of the listed events receive two arguments:

* The sender argument contains the __RadRadialMenu__. This argument is of type object, but can be cast to the __RadRadialMenu__ type.

* A __RadRoutedEventArgs__ object.

Additionally, __RadRadialMenu__ provides the following event:

* __PreviewToolTipOpen__ - occus when the ToolTip is about to be shown. The event receives the following arguments:            

	* The sender argument contains the __RadRadialMenu__. This argument is of type object, but can be cast to the __RadRadialMenu__ type.                

	* __MenuToolTipEventArgs__ object. It provides __Placement__ property which sets the position of the ToolTip.                

## RadRadialMenuItem Events

__RadRadialMenuItem__ raises the following specific event: 

* __Click__ - occurs each time the item gets clicked. The event handler receives two arguments:            

	* The sender argument contains the __RadRadialMenuItem__. This argument is of type object, but can be cast to the __RadRadialMenuItem__ type.                  

	* A __RadRoutedEventArgs__ object.                  
