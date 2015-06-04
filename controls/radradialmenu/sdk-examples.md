---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radradialmenu-sdk-examples
tags: sdk,examples
published: True
position: 3
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadRadialMenu__.

## List of all RadRadialMenu SDK examples:

{% if site.site_name == 'WPF' %}

* __[Binding ItemsSource](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/BindingItemsSource)__ - 
This example demonstrates how to bind a collection of custom objects to the ItemsSource property of RadRadialMenu.
* __[Customizing the center button](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/CustomRadialButtonContent)__ - 
This example demonstrates how to customize the ContentTemplate and BackContentTemplate of the RadialMenuButton.
* __[Custom ToolTip](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/CustomTooltip)__ - 
This example demonstrates how to customize the ToolTipContent and MenuToolTipStyle of the RadRadialMenuItem.
* __[How to add Commands to RadRadialMenuItems](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/ItemCommands)__ - 
This example demonstrates how to add commands to the RadRadialMenuItems to a RadRadialMenu and RadRadialContextMenu which manipulate an Image's RenderTransform.
* __[Quick mode RadialMenu](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/MenuQuickMode)__ - 
This example demonstrates the expected behavior when the RadRadialMenu.EnableQuickMode is set to True. The default value of that static Boolean property is False. By design when the RadRadialMenu is being shown or closed its animation will be triggered. While that animation is being animated if a different animation is triggered it will not be executed and the initial animation will complete fully. When the EnableQuickMode is set to True that initial animation will be interrupted and the new one will be executed.
* __[Open RadialMenu on show](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/OpenMenuOnShow)__ - 
This example demonstrates how to achieve a behavior where the RadRadialMenu is directly shown in its opened state rather than the default one.
* __[RadRadialMenu positioning](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/Positioning)__ - 
This example demonstrates how to set the postion where the RadRadialMenu would be placed when used a ContextMenu.
* __[Show/Hide as ContextMenu](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/ShowHideAsContextMenu)__ - 
This example demonstrates how to set different events in order to show and hide the RadRadialMenu when it is used as ContextMenu of an element. The events could be set via the ShowEventName and HideEventName properties of the control or via KeyBinding.
* __[Declaring RadRadialMenu as ContextMenu](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/SimpleRadialContextMenu)__ - 
This example demonstrates how to declare the RadRadialMenu as a ContextMenu of a control.
* __[Declaring standalone RadRadialMenu](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/SimpleRadialMenu)__ - 
This example demonstrates how to declare the RadRadialMenu as a standalone menu.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Binding ItemsSource](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/BindingItemsSource)__ - 
This example demonstrates how to bind a collection of custom objects to the ItemsSource property of RadRadialMenu.
* __[Customizing the center button](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/CustomRadialButtonContent)__ - 
This example demonstrates how to customize the ContentTemplate and BackContentTemplate of the RadialMenuButton.
* __[Custom ToolTip](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/CustomTooltip)__ - 
This example demonstrates how to customize the ToolTipContent and MenuToolTipStyle of the RadRadialMenuItem.
* __[How to add Commands to RadRadialMenuItems](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/ItemCommands)__ - 
This example demonstrates how to add commands to the RadRadialMenuItems to a RadRadialMenu and RadRadialContextMenu which manipulate an Image's RenderTransform.
* __[Quick mode RadialMenu](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/MenuQuickMode)__ - 
This example demonstrates the expected behavior when the RadRadialMenu.EnableQuickMode is set to True. The default value of that static Boolean property is False. By design when the RadRadialMenu is being shown or closed its animation will be triggered. While that animation is being animated if a different animation is triggered it will not be executed and the initial animation will complete fully. When the EnableQuickMode is set to True that initial animation will be interrupted and the new one will be executed.
* __[Open RadialMenu on show](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/OpenMenuOnShow)__ - 
This example demonstrates how to achieve a behavior where the RadRadialMenu is directly shown in its opened state rather than the default one.
* __[RadRadialMenu positioning](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/Positioning)__ - 
This example demonstrates how to set the postion where the RadRadialMenu would be placed when used a ContextMenu.
* __[Show/Hide as ContextMenu](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/ShowHideAsContextMenu)__ - 
This example demonstrates how to set different events in order to show and hide the RadRadialMenu when it is used as ContextMenu of an element. The events could be set via the ShowEventName and HideEventName properties of the control or via KeyBinding.
* __[Declaring RadRadialMenu as ContextMenu](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/SimpleRadialContextMenu)__ - 
This example demonstrates how to declare the RadRadialMenu as a ContextMenu of a control.
* __[Declaring standalone RadRadialMenu](https://github.com/telerik/xaml-sdk/tree/master/RadialMenu/SimpleRadialMenu)__ - 
This example demonstrates how to declare the RadRadialMenu as a standalone menu.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).