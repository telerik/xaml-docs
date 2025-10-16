---
title: Adding Double-Click Behavior to Expand/Collapse GanttTask in RadGanttView for WPF
description: Learn how to implement a double-click function to expand and collapse the gantt task in RadGanttView for WPF.
type: how-to
page_title: How to Add Double-Click Behavior to Expand/Collapse Task in RadGanttView for WPF
slug: kb-ganttview-double-click-expand-collapse-task
tags: wpf, double-click, expand, collapse, summary,task
res_type: kb
---

## Environment

| Product | Version |
| --- | --- |
| UI for WPF | 2023.3.1010 |

## Description

How to add a double-click action that expands/collapses the clicked GanttTask in RadGanttView for WPF.

## Solution

Subscribe to the `MouseDoubleClick` event on the RadGanttView control. Then, in the event handler use the `ExpandCollapseService` of the GanttView control to expand and collapse items. To get the collapse/expand state of the `GanttTask` objects, you can use the `GetItemWrapperByItemKey` of the `HierarchicalCollectionAdapter`.


```C#
	private void RadGanttView_MouseDoubleClick(object sender, MouseButtonEventArgs args)
	{
		var gantt = (RadGanttView)sender;
		var selectedTask = gantt.SelectedItem as GanttTask; 
		if (selectedTask != null && selectedTask.Children.Count > 0)
		{
			HierarchicalItem hierarchicalItem = gantt.ExpandCollapseService.HierarchicalCollectionAdapter.GetItemWrapperByItemKey(selectedTask);
			if (hierarchicalItem != null)
			{
				if (hierarchicalItem.IsExpanded)
				{
					gantt.ExpandCollapseService.CollapseItem(gantt.SelectedItem);
				}
				else
				{
					gantt.ExpandCollapseService.ExpandItem(gantt.SelectedItem);
				}
			}
		}                   
	}
```
