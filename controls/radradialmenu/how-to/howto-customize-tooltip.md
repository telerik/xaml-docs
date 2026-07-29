---
title: Customize the ToolTip
page_title: Customize the ToolTip
description: Check our &quot;Customize the ToolTip&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
slug: radradialmenu-howto-customize-tooltip
tags: customize,the,tooltip
published: True
position: 0
---

# Customize the ToolTip

This topic describes how to customize the ToolTip shown while hovering a __RadialMenuItem__. By default the ToolTip will display the Header of the item.      

We will go through the following sections:

* [Disable the ToolTip](#disable-the-tooltip)

* [Customize the ToolTipContent](#customize-the-tooltipcontent)

* [Customize the MenuToolTipStyle](#customize-the-menutooltipstyle)

* [Change the ToolTip position](#change-the-tooltip-position)

## Disable the ToolTip

You can completely disable showing the ToolTip for the whole __RadRadialMenu__ by setting the __ShowToolTip__ property as shown in __Example 1__.        

__Example 1: Disabling the ToolTip__

<snippet id='radradialmenu-how-to-howto-customize-tooltip-block_1-xaml' />

## Customize the ToolTipContent

__ToolTipContent__ property of the __RadialMenuItem__ allows you to customize the content shown inside the tooltip.        

__Example 2: Custom ToolTipContent__

<snippet id='radradialmenu-how-to-howto-customize-tooltip-block_2-xaml' />

Figure 1: Custom ToolTipContent
![Rad Radial Menu Customize Tool Tip 01](images/RadRadialMenu_Customize_ToolTip_01.png)

## Customize the MenuToolTipStyle

You could customize the Style and Template of the ToolTip of the __RadRadialMenu__ by creating a Style based on the default __MenuToolToolTipStyle__ with a TargetType set to __MenuToolTip__.        

>tip The default __MenuToolTipStyle__ could be extracted the UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} installation folder. Go into the __Themes.Implicit__ folder and select the theme that you have chosen to use. Drill down to find the Telerik.Windows.Controls.Navigation.xaml file in the directory that corresponds to your theme. From this resource dictionary extract the __MenuToolToolTipStyle__ and copy it into your project.          

__Example 3__ shows a quick sample of a custom MenuToolTipStyle.        

__Example 3: Custom MenuToolTipStyle__

<snippet id='radradialmenu-how-to-howto-customize-tooltip-block_3-xaml' />

Figure 2: Custom MenuToolTipStyle
![Rad Radial Menu Customize Tool Tip 02](images/RadRadialMenu_Customize_ToolTip_02.png)

## Change the ToolTip position

You could change the default position of the __RadialMenu__ ToolTip through the __MenuToolTipEventArgs__ received inside the __PreviewToolTipOpen__ event handler. The following example demonstrates the approach.        

__Example 4: Subscribe to PreviewToolTipOpen event__

<snippet id='radradialmenu-how-to-howto-customize-tooltip-block_4-xaml' />

__Example 5: Set the position inside the event handler__

<snippet id='radradialmenu-how-to-howto-customize-tooltip-block_5-cs' />

Figure 3: ToolTip with Left position set
![Rad Radial Menu Customize Tool Tip 03](images/RadRadialMenu_Customize_ToolTip_03.png)

## See Also

 * [Events]({%slug radradialmenu-events-overview%})