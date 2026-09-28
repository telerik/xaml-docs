---
title: Context Menu Owner
page_title: Context Menu Owner
description: Learn how to access the element that opened a RadContextMenu and retrieve the clicked element in the Telerik UI for WPF documentation.
components: ["contextmenu"]
slug: radcontextmenu-features-context-menu-owner
tags: context,menu,owner,clicked,element
published: True
position: 10
---

# Context Menu Owner

The __RadContextMenu__ provides properties and methods for working with the UI element that opened it. You can access the owner, determine the mouse position, retrieve a clicked item from the event route, and restore focus to the owner after the menu closes.

## Access the Context Menu Owner

The `UIElement` property returns the element to which the __RadContextMenu__ is attached. The `MousePosition` property returns the mouse position relative to the element that caused the menu to open.

__Access the Context Menu Owner and Mouse Position__
```C#
UIElement owner = this.radContextMenu.UIElement;
Point position = this.radContextMenu.MousePosition;
```

Use the owner and position information when a command needs to update the element that opened the menu or interpret the location of the click.

## Get the Clicked Element

When an element gets clicked and the __RadContextMenu__ appears, you can use the `GetClickedElement<T>()` method to retrieve the first element of type `T` in the visual tree that is part of the route of the event that opened the menu.

For example, if you have a __RadTreeView__ with a __RadContextMenu__ attached, handle the __Opened__ event to retrieve the __RadTreeViewItem__ that was clicked.

__Get the Clicked Element in C#__
```C#
private void RadContextMenu_Opened(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
    RadContextMenu contextMenu = (RadContextMenu)sender;
    RadTreeViewItem item = contextMenu.GetClickedElement<RadTreeViewItem>();
}
```

The returned `RadTreeViewItem` is the item that opened the context menu.

>tip More complex examples are available in [Using RadContextMenu within RadGridView]({%slug kb-contextmenu-use-with-radgridview%}) and [Selecting the Clicked Item of a RadTreeView]({%slug kb-contextmenu-select-clicked-item-radtreeview%}).

## Restore Focus to the Context Menu Owner

When opened, the __RadContextMenu__ automatically receives focus. Set `RestoreFocusToTargetElement` to `True` to return focus to the element that opened the menu after it closes.

__Restore Focus to the Context Menu Owner__
```XAML
<telerik:RadContextMenu xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                        RestoreFocusToTargetElement="True" />
```

## See Also

* [Getting Started]({%slug contextmenu-getting-started%})

* [Setting the Opening Event]({%slug radcontextmenu-features-opening-on-specific-event%})

* [Using RadContextMenu within RadGridView]({%slug kb-contextmenu-use-with-radgridview%})

* [Selecting the Clicked Item of a RadTreeView]({%slug kb-contextmenu-select-clicked-item-radtreeview%})

* [Retrieve the Clicked Item When Opening a RadContextMenu]({%slug kb-contextmenu-retrieve-clicked-item-when-opening%})