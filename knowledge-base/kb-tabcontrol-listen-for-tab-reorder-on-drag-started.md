---
title: How to Tell When Tabs are Being Re-ordered
description: How to use a notification to tell when tabs start reordering by dragging.
type: how-to
page_title: Listen for Tab Rearrange on DragInitialize
slug: kb-tabcontrol-listen-for-tab-reorder-on-drag-started
position: 0
tags: start,drag,drop,dragdropmanager
ticketid: 1403194
res_type: kb
---

## Environment

<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.116</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadTabControl for WPF</td>
	</tr>
</table>

## Description

How to listen for tab item re-ordering on drag start.

## Solution

Subscribe to the __DragDropManager.DragInitialize__ event.


```C#
	public void MainWindow()
	{
		InitializeComponent();
		DragDropManager.AddDragInitializeHandler(this.tabControl, OnTabControlDragInitialize, true);
	}

	private void OnTabControlDragInitialize(object sender, DragInitializeEventArgs e)
	{
		 
	}
```

## See Also
* [DragDropManager]({%slug dragdropmanager-overview%})