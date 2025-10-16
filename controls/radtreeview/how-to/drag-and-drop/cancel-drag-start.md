---
title: Cancel Drag Start
page_title: Cancel Drag Start
description: Check our &quot;Cancel Drag Start&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-cancel-drag-start
tags: drag,drop,cancel,start,draginitialize
published: True
position: 8
---

# Cancel Drag Start

This article demonstrates how to cancel the drag operation before it started. This is useful when you want to forbid dragging specific items from the treeview control.

To cancel the dragging you can subscribe the RadTreeView element to the [DragDropManager.DragInitialize]({%slug dragdropmanager-events%}) event and set the Data and DragVisual of its event arguments to null.

__Example 1: Subscribing the control for DragInitialize__
```C#
	DragDropManager.AddDragInitializeHandler(this.radTreeView, OnTreeViewDragInitialize, true);
```	

__Example 2: Canceling the drag__
```C#
	private void OnTreeViewDragInitialize(object sender, DragInitializeEventArgs e)
	{	
		// If the drag should be canceled set the data and the visual to null
		e.Data = null;
		e.DragVisual = null;
	}
```

## Code Example

This section contains a runnable code example showing how to cancel dragging for a specific item.

__Example 3: Treeview definition__
```XAML
	<telerik:RadTreeView x:Name="radTreeView" IsDragDropEnabled="True">
		<telerik:RadTreeViewItem Header="Sport Categories" IsExpanded="True">
			<telerik:RadTreeViewItem Header="Football" IsExpanded="True">
				<telerik:RadTreeViewItem Header="Futsal"/>
				<telerik:RadTreeViewItem Header="Soccer"/>
			</telerik:RadTreeViewItem>
			<telerik:RadTreeViewItem Header="Tennis"/>
			<telerik:RadTreeViewItem Header="Cycling"/>
		</telerik:RadTreeViewItem>
	</telerik:RadTreeView>
```

__Example 4: Subscribing the control for DragInitialize__
```C#
	DragDropManager.AddDragInitializeHandler(this.radTreeView, OnTreeViewDragInitialize, true);
```
	
__Example 5: Defining the DragInitialize handler and implementing logic that checks if the item can be dragged__
```C#
	private void OnTreeViewDragInitialize(object sender, DragInitializeEventArgs e)
	{
		TreeViewDragDropOptions options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
		if (options != null && options.DragSourceItem != null)
		{
			RadTreeViewItem draggedItem = options.DragSourceItem;
			if (draggedItem.Header.Equals("Sport Categories"))
			{
				e.Data = null;
				e.DragVisual = null;
			}
		}
	}
```

In this case you cannot drag the "Sport Categories" item which is the root of the treeview.

> You can find a runnable example demonstrating this approach in a data binding scenario in our GitHub SDK repository after navigating to [TreeView/CancelDragStart](https://github.com/telerik/xaml-sdk/tree/master/TreeView/CancelDragStart).

## See Also
 * [Enable Only Drop Inside]({%slug radtreeview-how-to-enabled-drop-inside-only%})
 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
 * [Implement Copy Drag]({%slug radtreeview-how-to-implement-copy-drag%})