---
title: How to Attach Context Menu to Gantt Event Containers
description: Show context menu only for event containers of RadGanttView control.
type: how-to
page_title: Add RadContextMenu in RadGanttView EventContainer elements
slug: kb-ganttview-add-contextmenu-for-event-containers
position: 0
tags: context,menu,event,container
ticketid: 1428118
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2.510</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGanttView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to display a context menu for the event container elements of RadGanttView.

## Solution

Define the context menu on the RadGanttView level and show it only when an EventContainer is clicked. To do this, handle the ContextMenuOpening event.


```XAML
	<telerik:RadGanttView ContextMenuOpening="RadGanttView_ContextMenuOpening">
		<telerik:RadContextMenu.ContextMenu>
			<telerik:RadContextMenu>
				<telerik:RadMenuItem Header="Click me!" Command="{Binding MyCommand}" />
			</telerik:RadContextMenu>
		</telerik:RadContextMenu.ContextMenu>
	</telerik:RadGanttView>
```


```XAML
	private void RadGanttView_ContextMenuOpening(object sender, ContextMenuEventArgs e)
	{
		var source = (FrameworkElement)e.OriginalSource;
		var container = source.ParentOfType<EventContainer>();
		if (container == null)
		{
			e.Handled = true;
		}
	}
```

Setting `e.Handled = true` will cancel the menu opening.

## See Also  
* [ParentOfType]({%slug common-visual-tree-helpers%})