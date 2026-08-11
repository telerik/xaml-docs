---
title: Cancel Drop
page_title: Cancel Drop
description: Check our &quot;Cancel Drop&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-cancel-drop
tags: drag,drop,cancel,drop
published: True
position: 9
---

# Cancel Drop

This article demonstrates how to cancel the drop operation. This is useful when you want to forbid the dropping on or the dropping of a particular item when using the RadTreeView control.

To do so, you can subscribe the RadTreeView element to the [DragDropManager.Drop]({%slug dragdropmanager-events%}#drop-target-events) event and set the **DropAction** of the [TreeViewDragDropOptions]({%slug radtreeview-features-drag-and-drop%}) to **DropAction.None**.

__Example 1: Subscribing the control for the Drop event__
<snippet id='radtreeview-how-to-drag-and-drop-cancel-drop-block_1-cs' />

__Example 2: Canceling the drag__
<snippet id='radtreeview-how-to-drag-and-drop-cancel-drop-block_2-cs' />

## Code Example

This section contains a runnable code example showing how to cancel dropping on a specific item.

__Example 3: Treeview definition__
<snippet id='radtreeview-how-to-drag-and-drop-cancel-drop-block_3-xaml' />

__Example 4: Subscribing the control for DragInitialize__
<snippet id='radtreeview-how-to-drag-and-drop-cancel-drop-block_4-cs' />
	
__Example 5: Defining the DragInitialize handler and implementing logic that checks if the item can be dragged__
<snippet id='radtreeview-how-to-drag-and-drop-cancel-drop-block_5-cs' />

In this case you cannot drop items on the "Football" item.

## See Also

 * [Cancel Drag Start]({%slug radtreeview-how-cancel-drag-start%})
 * [Enable Only Drop Inside]({%slug radtreeview-how-to-enabled-drop-inside-only%})
 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
 * [Implement Copy Drag]({%slug radtreeview-how-to-implement-copy-drag%})