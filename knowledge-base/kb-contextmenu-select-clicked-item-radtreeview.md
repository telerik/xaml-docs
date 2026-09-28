---
title: Selecting the Clicked Item of a RadTreeView
description: Learn how to select the RadTreeViewItem clicked before a RadContextMenu opens.
type: how-to
page_title: Selecting the Clicked RadTreeViewItem with RadContextMenu
slug: kb-contextmenu-select-clicked-item-radtreeview
position: 0
tags: radcontextmenu, radtreeview, radtreeviewitem, selecteditem, opened
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

Select the RadTreeViewItem that was clicked when the RadContextMenu opens.

## Solution

Handle the RadContextMenu Opened event, get the clicked RadTreeViewItem, and assign it to the RadTreeView.SelectedItem property.

This tutorial will show you how to select the item that was clicked, while opening the __RadContextMenu__. In order to achieve this, you have to do the following things:

* Handle the __Opened__ event of the __RadContextMenu__

* Get an instance of the clicked __RadTreeViewItem__

* Set the __SelectedItem__ of the __RadTreeView__

Before starting, here is a sample __RadTreeView__ with a sample __RadContextMenu__ attached.



__Attach RadContextMenu to RadTreeView__
```XAML
<telerik:RadTreeView xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" x:Name="radTreeView">
    <telerik:RadContextMenu.ContextMenu>
        <telerik:RadContextMenu x:Name="radContextMenu">
            <telerik:RadMenuItem Header="Menu Option 1" />
            <telerik:RadMenuItem Header="Menu Option 2" />
            <telerik:RadMenuItem Header="Menu Option 3" />
        </telerik:RadContextMenu>
    </telerik:RadContextMenu.ContextMenu>
    <telerik:RadTreeViewItem Header="Category1">
        <telerik:RadTreeViewItem Header="Product1" />
        <telerik:RadTreeViewItem Header="Product2" />
        <telerik:RadTreeViewItem Header="Product3" />
    </telerik:RadTreeViewItem>
    <telerik:RadTreeViewItem Header="Category2" />
    <telerik:RadTreeViewItem Header="Category3" />
    <telerik:RadTreeViewItem Header="Category4">
        <telerik:RadTreeViewItem Header="Product A" />
        <telerik:RadTreeViewItem Header="Product B" />
        <telerik:RadTreeViewItem Header="Product C" />
    </telerik:RadTreeViewItem>
    <telerik:RadTreeViewItem Header="Category5" />
</telerik:RadTreeView>
```

To handle the __Opened__ event attach an event handler to it.



__Handle the RadContextMenu Opened Event__
```XAML
<telerik:RadContextMenu xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                        x:Name="radContextMenu"
                        Opened="RadContextMenu_Opened">
    <telerik:RadMenuItem Header="Menu Option 1" />
    <telerik:RadMenuItem Header="Menu Option 2" />
    <telerik:RadMenuItem Header="Menu Option 3" />
</telerik:RadContextMenu>
```



__Define the Opened Event Handler in C#__
```C#
private void RadContextMenu_Opened( object sender, RoutedEventArgs e )
{
}
```

In it get the instance of the clicked __RadTreeViewItem__ by calling the __GetClickedElement\<T\>()__ method of the __RadContextMenu__.



__Get the Clicked RadTreeViewItem in C#__
```C#
private void RadContextMenu_Opened(object sender, RoutedEventArgs e)
{
    RadTreeViewItem item = this.radContextMenu.GetClickedElement<RadTreeViewItem>();
}
```

The last thing to do is to set the __SelectedItem__ property of the __RadTreeView__ to the __instance__ of the __RadTreeView__ item that has been clicked.

>note If you are having a dynamic data scenario, where the __RadTreeView__ is bound to a collection, you have to set the __SelectedItem__ property to the __DataContext__ of the clicked __RadTreeViewItem__.



__Select the Clicked Item in C#__
```C#
private void RadContextMenu_Opened(object sender, RoutedEventArgs e)
{
    RadTreeViewItem item = this.radContextMenu.GetClickedElement<RadTreeViewItem>();
    if (item != null)
    {
        this.radTreeView.SelectedItem = item;
    }
}
```

The selected item is now available through the `SelectedItem` property of the tree view.

## See Also

* [Context Menu Owner]({%slug radcontextmenu-features-context-menu-owner%})

* [Use RadContextMenu with a RadGridView]({%slug kb-contextmenu-use-with-radgridview%})

* [Create Menu Button with RadContextMenu and ToggleButton]({%slug kb-contextmenu-create-menu-button-with-togglebutton%})

* [Use Commands with the RadContextMenu]({%slug kb-contextmenu-use-commands%})

* [Handle Item Clicks]({%slug kb-contextmenu-handle-item-clicks%})
