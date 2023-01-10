---
title: Popup
page_title: Popup
description: This article demonstrates the popup feature of the RadNotifyIcon. 
slug: radnotifyicon-popup
tags: Popup,notifyicon
position: 1
---

# {{ site.framework_name }} RadNotifyIcon Popup

The __RadNotifyIcon__ allows for displaying a popup upon interacting with the icon or by manually calling the exposed methods. 

## PopupContent and PopupContentTemplate

The __PopupContent__ and __PopupContentTemplate__ properties allow for setting the popup's content and changing its default look. Whatever is set to the __PopupContent__ will be the DataContext inside the __PopupContentTemplate__. __Example 1__ demonstrates how you can setup those properties. 

#### __[XAML] Example 1: Setting PopupContent and PopupContentTemplate__
{{region xaml-radnotifyicon-popup-0}}
    
    <telerik:RadNotifyIcon
        x:Name="icon"
        PopupContent="Hello, world!"
        PopupActivationMouseEvent = "LeftClick">
        <telerik:RadNotifyIcon.PopupContentTemplate>
            <DataTemplate>
                <Border Background="Bisque">
                    <TextBlock Text="{Binding}" Padding="10"/>
                </Border>
            </DataTemplate>
        </telerik:RadNotifyIcon.PopupContentTemplate>
    </telerik:RadNotifyIcon>
{{endregion}}

#### __Figure 1: RadNotifyIcon with activated popup__

![RadNotifyIcon with activated popup](images/radnotifyicon_popup.png)

## PopupActivationMouseEvent

The __PopupActivationMouseEvent__ property determines when the popup will be shown. The default value is __LeftClick__.

#### __[XAML] Example 2: Setting PopupActivationMouseEvent__
{{region xaml-radnotifyicon-popup-1}}
    
    <telerik:RadNotifyIcon PopupActivationMouseEvent="LeftDoubleClick" />
{{endregion}}

## PopupShowDuration

The __PopupShowDuration__ specifies the amount of time in __milliseconds__ after which the popup will begin to close automatically. The default value is __5000__ milliseconds (5s). 

#### __[XAML] Example 3: Setting PopupShowDuration__
{{region xaml-radnotifyicon-popup-2}}
    
    <telerik:RadNotifyIcon PopupShowDuration="10000" />
{{endregion}}

## PopupCloseMode

The __PopupCloseMode__ is a bitwise enumeration, which controls the actions that will close the popup. The possible values are:

* **None**: The popup can only be closed in code (with the __HidePopup__ method) or by clicking on the notify icon. 
* **Deactivate**: The popup can be closed by clicking outside of it or by deactivating it with a windows keyboard shortcut.
* **Timeout**: The popup will be closed after the time specified by the __PopupShowDuration__ runs out. This is the default value.

#### __[XAML] Example 4: Closing the popup on deactivation or timeout__
{{region xaml-radnotifyicon-popup-3}}
    
    <telerik:RadNotifyIcon PopupCloseMode="Deactivate, TimeOut"  />
{{endregion}}

## Programmatically Showing the Popup

The RadNotifyIcon allows for programmatically showing a popup through the __ShowPopup__ method. It exposes one overload, which provides the option of specifying a screen location. 

* **void ShowPopup()**: Shows the popup on top of the notify icon.
* **void ShowPopup(Point location)**: Shows the popup at the provided location.

    #### __[C#] Example 5: Using the ShowPopup method__
    {{region cs-radnotifyicon-popup-4}}

        this.icon.ShowPopup();
    {{endregion}}

    #### __[VB.NET] Example 5: Using the ShowPopup method__
    {{region vb-radnotifyicon-popup-5}}

        Me.icon.ShowPopup()
    {{endregion}}

## Programmatically Hiding the Popup

You can manually hide the popup with the __HidePopup__ method as shown in __Example 6__.

#### __[C#] Example 6: Using the HidePopup method__
{{region cs-radnotifyicon-popup-6}}

    this.icon.HidePopup();
{{endregion}}

#### __[VB.NET] Example 6: Using the HidePopup method__
{{region vb-radnotifyicon-popup-7}}

    Me.icon.HidePopup()
{{endregion}}

## Popup animations

You can control the opening and closing animation with the __PopupShowAnimation__ and __PopupHideAnimation__ properties respectively. They expect an animation of type [RadAnimation](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.animation.radanimation) and by default [FadeAnimations](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.animation.fadeanimation) are used.

#### __[XAML] Example 7: Setting PopupShowAnimation and PopupHideAnimation__
{{region xaml-radnotifyicon-popup-8}}

    <Grid>
        <Grid.Resources>
            <telerik:ScaleAnimation x:Key="showAnimation" MinScale="0.1" MaxScale="0.9" Duration="00:00:02" />
            <telerik:ScaleAnimation x:Key="hideAnimation" MinScale="0.9" MaxScale="0.1" Duration="00:00:02" />
        </Grid.Resources>
        <telerik:RadNotifyIcon
            x:Name="icon"
            PopupContent="Hello, world!"
            PopupActivationMouseEvent = "LeftDoubleClick"
            PopupShowAnimation="{StaticResource showAnimation}"
            PopupHideAnimation="{StaticResource hideAnimation}">
            <telerik:RadNotifyIcon.PopupContentTemplate>
                <DataTemplate>
                    <Border Background="Bisque">
                        <TextBlock Text="{Binding}" Padding="10"/>
                    </Border>
                </DataTemplate>
            </telerik:RadNotifyIcon.PopupContentTemplate>
        </telerik:RadNotifyIcon>
    </Grid>
{{endregion}}

## IsPopupOpen

The __IsPopupOpen__ property allows you to check whether a popup is currently open.

#### __[C#] Example 8: Using IsPopupOpen__
{{region cs-radnotifyicon-popup-9}}

    var isOpen = this.icon.IsPopupOpen;
{{endregion}}

#### __[VB.NET] Example 8: Using IsPopupOpen__
{{region vb-radnotifyicon-popup-10}}

    Dim isOpen = Me.icon.IsPopupOpen
{{endregion}}

## See Also 

* [Events]({%slug radnotifyicon-events%})
* [Tooltip]({%slug radnotifyicon-tooltip%})
* [ContextMenu]({%slug radnotifyicon-contextmenu%})
* [Balloon Notifications]({%slug radnotifyicon-balloon-notifications%})