---
title: Create a Menu Button with RadContextMenu and ToggleButton
description: Learn how to create a drop-down menu button by binding a ToggleButton to a RadContextMenu.
type: how-to
page_title: Create a Menu Button with RadContextMenu and ToggleButton
slug: kb-contextmenu-create-menu-button-with-togglebutton
position: 0
tags: radcontextmenu, togglebutton, menu button, drop-down button, ischecked, isopen
res_type: kb
---

## Environment

<table>
<tbody>
<tr>
<td>Product Version</td>
<td>2026.1.415</td>
</tr>
<tr>
<td>Product</td>
<td>RadContextMenu for WPF</td>
</tr>
</tbody>
</table>

## Description

Create a drop-down menu button that displays additional options when the user clicks a ToggleButton.

## Solution

Attach a RadContextMenu to the ToggleButton and bind the ToggleButton.IsChecked property to the RadContextMenu.IsOpen property.

1. Define the ToggleButton and attach the RadContextMenu.

__Define the ToggleButton and RadContextMenu__
```XAML
<ToggleButton xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
              Content="Click me"
              HorizontalAlignment="Left"
              IsChecked="{Binding IsOpen, ElementName=radContextMenu, Mode=TwoWay}">
    <telerik:RadContextMenu.ContextMenu>
        <telerik:RadContextMenu x:Name="radContextMenu" Placement="Bottom">
            <telerik:RadMenuItem Header="Item 1" />
            <telerik:RadMenuItem Header="Item 2" />
            <telerik:RadMenuItem Header="Item 3" />
        </telerik:RadContextMenu>
    </telerik:RadContextMenu.ContextMenu>
</ToggleButton>
```

The `IsChecked` binding keeps the ToggleButton state synchronized with the RadContextMenu.IsOpen property.

__RadContextMenu Menu Button__
![WPF RadContextMenu menu button](images/kb-contextmenu-create-menu-button-with-togglebutton.png)

## See Also

* [Getting Started]({%slug contextmenu-getting-started%})
* [Menu Placement]({%slug radcontextmenu-features-placement%})
* [RadContextMenu Overview]({%slug contextmenu-overview%})