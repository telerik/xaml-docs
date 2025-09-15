---
title: How Disable the RadMenuItem Element's Animations
description: This article showcases how to disable the animations of the RadMenuItem element.
page_title: Disable the Animations of the RadMenuItem Element
type: how-to
slug: kb-menuitem-disable-animations
position: 0
tags: 
ticketid: 1691674
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2025.2.521</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadMenu for WPF</td>
	    </tr>
        <tr>
	    	<td>Product</td>
	    	<td>RadContextMenu for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to disable the animations of the `RadMenuItem` element.

## Solution

The `RadMenuItem` element is used in controls such as the `RadMenu` and the `RadContextMenu`. To disable the animation, set the `AnimationManager.AnimationSelector` attached property to __null__.

__Disabling the animation of the RadMenuItem element__
```XAML
    <Application.Resources>
        <!-- If NoXaml is used: BasedOn="{StaticResource RadMenuItemStyle}" -->
        <Style TargetType="telerik:RadMenuItem">
            <Setter Property="telerik:AnimationManager.AnimationSelector" Value="{x:Null}"/>
        </Style>
    </Application.Resources>
```