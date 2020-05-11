---
title: Tooltip
page_title: Tooltip
description: This article allows demonstrates how to display a tooltip when the user's mouse is over the RadNotifyIcon.
slug: radnotifyicon-tooltip
tags: tooltip, notifyicon
position: 3
---

# Tooltip

You can configure the tooltip that is displayed when the user hovers over the icon with the __TooltipContent__ property. 

## Show ToolTip

To display a tooltip, set the **TooltipContent** property as demonstrated in __Example 1__. 

#### __[XAML] Example 1: Setting TooltipContent__
{{region xaml-radnotifyicon-tooltip-0}}
    
    <telerik:RadNotifyIcon
            x:Name="icon"
            TooltipContent="My tooltip">
    </telerik:RadNotifyIcon>
{{endregion}}

#### __Figure 1: RadNotifyIcon with tooltip__

![RadNotifyIcon with tooltip](images/radnotifyicon_tooltip.png)

## See Also 

* [Events]({%slug radnotifyicon-events%})
* [Popup]({%slug radnotifyicon-popup%})
* [ContextMenu]({%slug radnotifyicon-contextmenu%})
* [Balloon Notifications]({%slug radnotifyicon-balloon-notifications%})
