---
title: Handling Item Clicks
description: Learn how to handle RadMenuItem Click events or the RadContextMenu ItemClick event.
type: how-to
page_title: Handling RadContextMenu Item Clicks
slug: kb-contextmenu-handle-item-clicks
position: 0
tags: radcontextmenu, radmenuitem, click, itemclick, events
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

Handle a click on a RadContextMenu item by subscribing to the RadMenuItem Click event or the RadContextMenu ItemClick event.

## Solution

Choose the Click event for a specific menu item or the ItemClick event when one handler should process clicks from child menu items.



There are two ways to handle a click on an item:

* [Handle the Click event of the RadMenuItem](#handle-the-click-event-of-the-radmenuitem)

* [Handle the ItemClick event of the RadContextMenu](#handle-the-itemclick-event-of-the-radcontextmenu)

## Handle the Click Event of the RadMenuItem

Handling the __Click__ event of each item is the straight-forward way. But it has some __disadvantages__:

* You have to attach an event handler to each item. This makes the code harder to maintain.

* It is not suitable when having dynamic items.

>note If the __RadMenuItem__ is in the role of a header (has child items), the __ItemClick__ event will not be raised unless the __NotifyOnHeaderClick__ property is set to __True__.

Here is an example of an event handler attached to the __Click__ event and how to get the instance of the clicked item.



__Attach RadMenuItem Click Handlers__
```XAML
<telerik:RadContextMenu xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
    <telerik:RadMenuItem Header="Item 1"
                         Click="RadMenuItem_Click" />
    <telerik:RadMenuItem Header="Item 2"
                         Click="RadMenuItem_Click" />
    <telerik:RadMenuItem Header="Item 3"
                         Click="RadMenuItem_Click" />
</telerik:RadContextMenu>
```



__Handle the Click Event in C#__
```C#
private void RadMenuItem_Click( object sender, RadRoutedEventArgs e )
{
    RadMenuItem item = sender as RadMenuItem;
    //implement the logic regarding the instance here.
}
```

The handler receives the clicked `RadMenuItem` through the `sender` argument.

## Handle the ItemClick Event of the RadContextMenu

Handling the __ItemClick__ event of the __RadContextMenu__ gives you more flexibility, as it fires each time a child menu item is clicked. This approach is the most suitable when having a dynamic data scenario.

>note If the __RadMenuItem__ is in the role of a header (has child items), the __ItemClick__ event will not be raised unless the __NotifyOnHeaderClick__ property is set to __True__.

Here is an example of an event handler attached to the __ItemClick__ event and how to get the instance of the clicked item.



__Attach the RadContextMenu ItemClick Handler__
```XAML
<telerik:RadContextMenu xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                        ItemClick="radContextMenu_ItemClick">
    <telerik:RadMenuItem Header="Item 1" />
    <telerik:RadMenuItem Header="Item 2" />
    <telerik:RadMenuItem Header="Item 3" />
</telerik:RadContextMenu>
```



__Handle the ItemClick Event in C#__
```C#
private void radContextMenu_ItemClick(object sender, RadRoutedEventArgs e)
{
    RadMenuItem item = e.OriginalSource as RadMenuItem;
    //implement the logic regarding the instance here.
}
```

The `ItemClick` handler receives the clicked item from `e.OriginalSource`.

## See Also

* [Getting Started]({%slug contextmenu-getting-started%})

* [Events - Overview]({%slug radcontextmenu-events-overview%})

* [Use RadContextMenu with a RadGridView]({%slug kb-contextmenu-use-with-radgridview%})

* [Select the clicked Item of a RadTreeView]({%slug kb-contextmenu-select-clicked-item-radtreeview%})

* [Create Menu Button with RadContextMenu and ToggleButton]({%slug kb-contextmenu-create-menu-button-with-togglebutton%})

* [Use Commands with the RadContextMenu]({%slug kb-contextmenu-use-commands%})
