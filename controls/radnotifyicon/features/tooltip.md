---
title: Tooltip
page_title: Tooltip
description: This article allows demonstrates how to display a tooltip when the user's mouse is over the RadNotifyIcon.
slug: radnotifyicon-tooltip
tags: tooltip, notifyicon
position: 3
---

# {{ site.framework_name }} RadNotifyIcon Tooltip

You can configure the tooltip that is displayed when the user hovers over the icon with the __TooltipContent__ property. By default a styled custom tooltip is shown. If you want to show the native tooltip, set the **UseNativeTooltip** property to **True**.

## Native ToolTip

To display a native tooltip, set the __UseNativeTooltip__ property as demonstrated in __Example 1__. When this property is **True** the ToString() value of the **TooltipContent** will be shown in the tooltip.

#### __[XAML] Example 1: Setting TooltipContent__
{{region xaml-radnotifyicon-tooltip-0}}
    
    <telerik:RadNotifyIcon
            x:Name="icon"
            TooltipContent="My tooltip"
            UseNativeTooltip="True">
    </telerik:RadNotifyIcon>
{{endregion}}

#### __Figure 1: RadNotifyIcon with tooltip__

![RadNotifyIcon with tooltip](images/radnotifyicon_tooltip.png)

> In order for theming to be applied, you can ommit the setting of the **UseNativeTooltip** property.

## TooltipContent and TooltipContentTemplate

The RadNotifyIcon provides a default TooltipContentTemplate that will be styled according to your theme. You can also customize it as per your requirements. The DataContext inside the __TooltipContentTemplate__ property will be whatever is set to the __TooltipContent__. 

#### __[XAML] Example 2: Setting TooltipContent and TooltipContentTemplate__
{{region xaml-radnotifyicon-tooltip-1}}
    
    <telerik:RadNotifyIcon
        x:Name="icon"
        TooltipContent="My styled tooltip">
        <telerik:RadNotifyIcon.TooltipContentTemplate>
            <DataTemplate>
                <Border Background="Bisque">
                    <TextBlock Text="{Binding}" Padding="10"/>
                </Border>
            </DataTemplate>
        </telerik:RadNotifyIcon.TooltipContentTemplate>
    </telerik:RadNotifyIcon>
{{endregion}}

#### __Figure 2: RadNotifyIcon with customized tooltip__

![RadNotifyIcon with customized tooltip](images/radnotifyicon_customtooltip.png)

## IsTooltipOpen

The __IsTooltipOpen__ property allows you to check whether a styled tooltip is currently open. 

#### __[C#] Example 3: Using the IsTooltipOpen property__
{{region cs-radnotifyicon-tooltip-2}}

    var isOpen = this.icon.IsTooltipOpen;
{{endregion}}

#### __[VB.NET] Example 3: Using the IsTooltipOpen property__
{{region vb-radnotifyicon-tooltip-3}}

    Dim isOpen = Me.icon.IsTooltipOpen
{{endregion}}

## See Also 

* [Events]({%slug radnotifyicon-events%})
* [Popup]({%slug radnotifyicon-popup%})
* [ContextMenu]({%slug radnotifyicon-contextmenu%})
* [Balloon Notifications]({%slug radnotifyicon-balloon-notifications%})
