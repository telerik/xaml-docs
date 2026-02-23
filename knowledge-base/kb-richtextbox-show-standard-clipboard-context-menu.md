---
title: Displaying Standard Clipboard Context Menu in RichTextBox
description: How to keep only the copy, cut and paste options in the context menu with of RadRichTextBox in UI for WPF.
type: how-to
page_title: How to Modify the ContextMenu of RadRichTextBox
meta_title: How to Show Standard Clipboard Context Menu in RadRichTextBox
slug: kb-richtextbox-show-standard-clipboard-context-menu
tags: richtextbox, readonly, contextmenu, copy, clipboard, ui-for-wpf
res_type: kb
ticketid: 1710116
---

## Environment
<table>
<tbody>
<tr>
<td>Product</td>
<td>UI for WPF RichTextBox</td>
</tr>
<tr>
<td>Version</td>
<td>2023.1.315</td>
</tr>
</tbody>
</table>

## Description

How to modify the context menu of RadRichTextBox for WPF, in order to have only the standard clipboard operations - copy, cut and paste.

## Solution

To achieve this, you can use the `Showing` event of the RadRichTextBox' `ContextMenu`. This will allow you to remove all other menu items and leave only the ones with the clipboard operations.

```C#
var contextMenu = (Telerik.Windows.Controls.RichTextBoxUI.ContextMenu)rtb.ContextMenu;
contextMenu.Showing += ContextMenu_Showing;
```

```C#
private void ContextMenu_Showing(object sender, ContextMenuEventArgs e)
{
     // removes the last two groups from the context menu and leaves only the group with the clipboard operations
     e.ContextMenuGroupCollection.RemoveAt(1);
     e.ContextMenuGroupCollection.RemoveAt(1);
}
```

An alternative approach would be to create a custom `ContextMenuContentBuilder` and modify the menu there. 

Both approaches are shown in the [following help article]({%slug radrichtextbox-features-context-menu%}).
