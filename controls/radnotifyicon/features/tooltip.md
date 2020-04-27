---
title: Tooltip
page_title: Tooltip
description: This article allows demonstrates how to display a tooltip when the user's mouse is over the RadNotifyIcon.
slug: radnotifyicon-tooltip
tags: tooltip, custom, notifyicon
position: 3
---

# Tooltip

You can configure the tooltip that is displayed when the user hovers over the icon with the __TooltipText__ property. If you want to customize the tooltip, you can use __CustomTooltipContent__ and __CustomTooltipContentTemplate__ properties. 

## TooltipText

To display a normal tooltip, set the __TooltipText__ property as demonstrated in __Example 1__.

#### __[XAML] Example 1: Setting TooltipText__
{{region xaml-radnotifyicon-tooltip-0}}
    
    <telerik:RadNotifyIcon
            x:Name="icon"
            TooltipText="My tooltip">
    </telerik:RadNotifyIcon>
{{endregion}}

#### __Figure 1: RadNotifyIcon with tooltip__

![RadNotifyIcon with tooltip](images/radnotifyicon_tooltip.png)

## CustomTooltipContent and CustomTooltipContentTemplate

In order to customize the look of the tooltip, use the __CustomTooltipContent__ and __CustomTooltipContentTemplate__ properties. The DataContext inside the __CustomTooltipContentTemplate__ property will be whatever is set to the __CustomTooltipContent__. If any of these properties are set, the value of the __TooltipText__ property will be ignored. 

#### __[XAML] Example 2: Setting CustomTooltipContent and CustomTooltipContentTemplate__
{{region xaml-radnotifyicon-tooltip-1}}
    
    <telerik:RadNotifyIcon
        x:Name="icon"
        TooltipText="This value will be ignored"
        CustomTooltipContent="My styled tooltip">
        <telerik:RadNotifyIcon.CustomTooltipContentTemplate>
            <DataTemplate>
                <Border Background="Bisque">
                    <TextBlock Text="{Binding}" Padding="10"/>
                </Border>
            </DataTemplate>
        </telerik:RadNotifyIcon.CustomTooltipContentTemplate>
    </telerik:RadNotifyIcon>
{{endregion}}

#### __Figure 2: RadNotifyIcon with custom tooltip__

![RadNotifyIcon with custom tooltip](images/radnotifyicon_customtooltip.png)

## IsCustomTooltipOpen

The __IsCustomTooltipOpen__ property allows you to check whether a custom tooltip is currently open. 

#### __[C#] Example 7: Using the IsCustomTooltipOpen property__
{{region cs-radnotifyicon-popup-8}}

    var isOpen = this.icon.IsCustomTooltipOpen;
{{endregion}}

#### __[VB.NET] Example 7: Using the IsCustomTooltipOpen property__
{{region vb-radnotifyicon-popup-9}}

    Dim isOpen = Me.icon.IsCustomTooltipOpen
{{endregion}}

## See Also 

* [Events]({%slug radnotifyicon-events%})
* [Popup]({%slug radnotifyicon-popup%})
* [ContextMenu]({%slug radnotifyicon-contextmenu%})
* [Balloon Notifications]({%slug radnotifyicon-balloon-notifications%})