---
title: ContextMenu
page_title: ContextMenu
description: This article allows demonstrates the context menu feature of the RadNotifyIcon. 
slug: radnotifyicon-contextmenu
tags: context, menu, notifyicon
position: 2
---

# ContextMenu

You can display a context menu when the user interacts with the notify icon with the help of the __TrayContextMenu__ property. 

## TrayContextMenu

The __TrayContextMenu__ property expects a value of type [RadContextMenu]({%slug contextmenu-getting-started%}). __Example 1__ demonstrates how it can be used. 

__Example 1: Setting TrayContextMenu__
<snippet id='radnotifyicon-features-contextmenu-block_1-xaml' />

#### __Figure 1: RadContextMenu displayed over the icon__

![RadContextMenu displayed over the icon](images/radnotifyicon_contextmenu.png)

## ContextMenuActivationMouseEvent

The __ContextMenuActivationMouseEvent__ property determines when the context menu will be shown. The default value is __RightClick__.

__Example 2: Setting ContextMenuActivationMouseEvent__
<snippet id='radnotifyicon-features-contextmenu-block_2-xaml' />

## See Also 

* [Events]({%slug radnotifyicon-events%})
* [Tooltip]({%slug radnotifyicon-tooltip%})
* [Popup]({%slug radnotifyicon-popup%})
* [Balloon Notifications]({%slug radnotifyicon-balloon-notifications%})