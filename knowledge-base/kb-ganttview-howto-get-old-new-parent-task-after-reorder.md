---
title: Get Old and New Parent of a Task after Reordering via Drag and Drop
description: How to acquire the old and new parent of a task after reorder.
type: how-to
page_title: Acquire Old and New Parent of a GanttTask afer Drag-Drop
slug: kb-ganttview-howto-get-old-new-parent-task-after-reorder
position: 0
tags: ganttview, get, 
ticketid: 1401263
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.1 318</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGanttView for WPF</td>
	    </tr>
    </tbody>
</table>


## Description

How to acquire the old and new parent of a task after reorder via drag and drop.

## Solution

For the purpose you can define a [custom GanttDragDropBehavior]({%slug radganttview-dragdrop-custom-behaviors%}) and override its **Drop** method as follows:


```C#
  	protected override void Drop(SchedulingDragDropState state)
  	{
		var task = state.DraggedItem as GanttTask;
		var item = this.Gantt.ExpandCollapseService.HierarchicalCollectionAdapter.GetItemWrapperByItemKey(task);
		var previousParent = item.Parent;
		base.Drop(state);
		var newItem = this.Gantt.ExpandCollapseService.HierarchicalCollectionAdapter.GetItemWrapperByItemKey(task);
		var newParent = newItem.Parent;
  	}
```

## See Also
* [Custom GanttDragDropBehavior]({%slug radganttview-dragdrop-custom-behaviors%})
