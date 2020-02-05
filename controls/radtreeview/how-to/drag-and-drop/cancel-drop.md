---
title: Cancel Drop
page_title: Cancel Drop
description: Check our &quot;Cancel Drop&quot; documentation article for the RadTreeView WPF control.
slug: radtreeview-how-cancel-drop
tags: drag,drop,cancel,drop
published: True
position: 9
---

# Cancel Drop

This article demonstrates how to cancel the drop operation. This is useful when you want to forbid the dropping on or the dropping of a particular item when using the RadTreeView control.

To do so, you can subscribe the RadTreeView element to the [DragDropManager.Drop]({%slug dragdropmanager-events%}#drop-target-events) event and set the **DropAction** of the [TreeViewDragDropOptions]({%slug radtreeview-features-drag-and-drop%}#using-the-treeviewdragdropoptions-object) to **DropAction.None**.

#### __[C#] Example 1: Subscribing the control for the Drop event__
{{region cs-radtreeview-how-cancel-drop-0}}
	DragDropManager.AddDropHandler(this.radTreeView, OnDrop, true);
{{endregion}}	

#### __[C#] Example 2: Canceling the drag__
{{region cs-radtreeview-how-cancel-drop-1}}
	private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
		TreeViewDragDropOptions options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
		if (options != null && options.DragSourceItem != null)
		{
			// cancel the drop operation under a certain condition
			options.DropAction = DropAction.None;
		}
	}
{{endregion}}

## Code Example

This section contains a runnable code example showing how to cancel dropping on a specific item.

#### __[XAML] Example 3: Treeview definition__
{{region xaml-radtreeview-how-cancel-drop-2}}
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
{{endregion}}

#### __[C#] Example 4: Subscribing the control for DragInitialize__
{{region cs-radtreeview-how-cancel-drop-3}}
	DragDropManager.AddDropHandler(this.radTreeView, OnDrop, true);
{{endregion}}
	
#### __[C#] Example 5: Defining the DragInitialize handler and implementing logic that checks if the item can be dragged__
{{region cs-radtreeview-how-cancel-drop-4}}
	private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
		TreeViewDragDropOptions options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
		if (options != null && options.DragSourceItem != null)
		{
			RadTreeViewItem dropTargetItem = options.DropTargetItem;
			if (dropTargetItem.Header.ToString() == "Football")
			{
				options.DropAction = DropAction.None;
			}
		}
	}
{{endregion}}

In this case you cannot drop items on the "Football" item.

## See Also

 * [Cancel Drag Start]({%slug radtreeview-how-cancel-drag-start%})
 * [Enable Only Drop Inside]({%slug radtreeview-how-to-enabled-drop-inside-only%})
 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
 * [Implement Copy Drag]({%slug radtreeview-how-to-implement-copy-drag%})