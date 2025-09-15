---
title: RadContextMenu Does not Close after Displaying Dialog Window
description: After selecting an item from the RadContextMenu, it remains open.
type: troubleshooting
page_title: RadContextMenu Stays Open after Selecting a Menu Item
slug: kb-contextmenu-does-not-close-after-selecting-menu-item
position: 0
tags: contextmenu, does, not, close, after, selecting, menu, item, stays, open
ticketid: 1477178
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2020.2.617</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadContextMenu for WPF</td>
	</tr>
</table>

## Description

RadContextMenu stays open after selecting a menu item and/or opening a dialog window.

## Solution

This behavior is observed because of the timing of executing a menu item's command or [custom click logic]({%slug radcontextmenu-how-to-handle-item-clicks%}) and closing the menu along with the nature of the dialog windows. The custom click logic of the item is executed before the closing of the menu and if a dialog is opened at this point, it freezes the rest of the UI and the menu remains opened.

To resolve this you can use the application's **Dispatcher** to delay the opening of the dialog as shown in **Example 1**.

__Example 1: Delaying the opening of a dialog window__
```XAML
    private void RadContextMenu_ItemClick(object sender, Telerik.Windows.RadRoutedEventArgs e)
    {
        Dispatcher.BeginInvoke(new Action(() =>
        {
            MessageBox.Show("Command Executed!");
        }));
    }
```

## See Also
* [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})