---
title: ContextMenu
page_title: ContextMenu
description: This article allows demonstrates the context menu feature of the RadNotifyIcon. 
slug: radnotifyicon-contextmenu
tags: context, menu, notifyicon
position: 2
---

# {{ site.framework_name }} RadNotifyIcon ContextMenu

You can display a context menu when the user interacts with the notify icon with the help of the __TrayContextMenu__ property. 

## TrayContextMenu

The __TrayContextMenu__ property expects a value of type [RadContextMenu]({%slug contextmenu-getting-started%}). __Example 1__ demonstrates how it can be used. 

#### __[XAML] Example 1: Setting PopupContent and PopupContentTemplate__
{{region xaml-radnotifyicon-contextmenu-0}}
    
    <telerik:RadNotifyIcon
        x:Name="icon">
        <telerik:RadNotifyIcon.TrayContextMenu>
            <telerik:RadContextMenu IconColumnWidth="0">
                <telerik:RadMenuItem Header="Item 1" />
                <telerik:RadMenuItem Header="Item 2" />

                <telerik:RadMenuItem Header="Item 3" />
            </telerik:RadContextMenu>
        </telerik:RadNotifyIcon.TrayContextMenu>
    </telerik:RadNotifyIcon>
{{endregion}}

#### __Figure 1: RadContextMenu displayed over the icon__

![RadContextMenu displayed over the icon](images/radnotifyicon_contextmenu.png)

## ContextMenuActivationMouseEvent

The __ContextMenuActivationMouseEvent__ property determines when the context menu will be shown. The default value is __RightClick__.

#### __[XAML] Example 2: Setting ContextMenuActivationMouseEvent__
{{region xaml-radnotifyicon-contextmenu-1}}
    
    <telerik:RadNotifyIcon ContextMenuActivationMouseEvent="RightDoubleClick" />
{{endregion}}

## See Also 

* [Events]({%slug radnotifyicon-events%})
* [Tooltip]({%slug radnotifyicon-tooltip%})
* [Popup]({%slug radnotifyicon-popup%})
* [Balloon Notifications]({%slug radnotifyicon-balloon-notifications%})