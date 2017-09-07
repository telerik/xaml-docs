---
title: Expand and Collapse Items
page_title: Expand and Collapse Items
description: Expand and Collapse Items
slug: radtreeview-how-to-expand-and-collapse-items
tags: expand,and,collapse,items
published: True
position: 5
---

# Expand and Collapse Items

To expand an item click on the expander icon. To expand an item programmatically set the __IsExpanded__ property to __True__. To collapse an item set the __IsExpanded__ property to __False__. When the item is expanded/collapsed it fires the __PreviewExpand__, __Expanded__ and __PreviewCollapsed__, __Collapsed__ events respectively. These events are available for the __RadTreeView__ and __RadTreeViewItem__ classes.		

When you need to expand or collapse all the items recursively for a given item use the __ExpandAll()__ and __CollapseAll()__ methods of the __RadTreeViewItem__ respectively. When you need to expand/collapse all the nodes in the tree use __ExpandAll()__ and __CollapseAll()__ methods of the __RadTreeView__.		

>If the __RadTreeView__ is bound, the expand methods can only be called after the tree has loaded.		  

When you need to have only a single branch of the tree expanded, set the __IsSingleExpandPath__ property of the __RadTreeView__ to __True__. Setting this property to __True__ will automatically collapse the already expanded branch if a new branch is going to be expanded.		

The __RadTreeView__ API offers you the ability to expand an item by path programmatically. In order to do this you should use the __ExpandItemByPath()__ method of the RadTreeView.
		
>caution Using the __ExpandItemByPath()__ method of the __RadTreeView__ class is a __potentially expensive operation if the item is not visible__. The method will recursively expand and scroll items into view, updating the layout numerous times. Almost certainly the method should not be called in a loop (multiple times). If you need to do so, there is probably a better way to achieve what you need.

For more information read the topic about [Expanding and Collapsing Items]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%}).		

## See Also
 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
 * [Selection]({%slug radtreeview-feautres-treeviewitem-selection%})
 * [Expanding and Collapsing Items]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%})