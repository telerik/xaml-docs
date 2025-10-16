---
title: Drop event not fired
page_title: Get ListBoxItem Under the Mouse When DragOver
description: How to catch the RadListBoxItem element under the mouse when drag over or drop on RadListBox.
type: how-to
slug: kb-listbox-get-listboxitem-under-mouse-when-dragover
position: 0
tags: drop,dragdropmanager,originalsource
ticketid: 1429724
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2.618</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadListBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to get the RadListBoxItem element under the mouse when __DragDropManager.DragOver__ or __DragDropManager.Drop__ is fired for RadListBox.

## Solution

In the DragOver or Drop event handler, get the OriginalSource of the event arguments. This is the element under the mouse. From it, you can use the ParentOfType<T> method to get the RadListBoxItem.


```C#
	private void OnRadListBoxDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
		var elementUnderMouse = (FrameworkElement)e.OriginalSource;
		var item = elementUnderMouse.ParentOfType<RadListBoxItem>();		
	}
```

Note that if you don't data bind the ItemsSource of RadListBox, the OriginalSource of the event arguments might be the RadListBoxItem itself.

## See Also  
* [Visual Tree Helpers]({%slug common-visual-tree-helpers%})