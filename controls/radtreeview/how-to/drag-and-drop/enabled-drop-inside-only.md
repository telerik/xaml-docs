---
title: Enable Only Drop Inside
page_title: Enable Only Drop Inside
description: Check our &quot;Enable Only Drop Inside&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-enabled-drop-inside-only
tags: enable,only,drop,inside
published: True
position: 3
---

# Enable Only Drop Inside

This tutorial demonstrates how to enable dropping inside the __RadTreeViewItems__, but not around them. 

For the purpose of this tutorial will be used the following treeview declaration: 

<snippet id='radtreeview-how-to-drag-and-drop-enabled-drop-inside-only-block_1-xaml' />

>tip The __RadTreeView__ is data bound to a collection of business objects. For more information, read the [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%}) topic.

In order to implement only drop inside you need to perform the following steps: 

* Attach to the __DragDropManager DragOver__ event:			

	<snippet id='radtreeview-how-to-drag-and-drop-enabled-drop-inside-only-block_2-cs' />
	<snippet id='radtreeview-how-to-drag-and-drop-enabled-drop-inside-only-block_3-vb' />

	>tip __RadTreeView__ handles internally the __DragDropManager__ events and in order to invoke a custom handler, you need to explicitly specify that you're adding a handler that should be invoked even for already handled events. This is done through the last - __bool__ argument of the __DragDropManager.AddDragOverHandler__ extension method.			  

* In the event handler you should use the following code:

	<snippet id='radtreeview-how-to-drag-and-drop-enabled-drop-inside-only-block_4-cs' />
	<snippet id='radtreeview-how-to-drag-and-drop-enabled-drop-inside-only-block_5-vb' />

	Please note that if you want the changes applied on the __TreeViewDragDropOptions__ object to affect the __DragVisual__ element, you have to invoke the __UpdateDragVisual()__ method.			

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/TreeView/EnableOnlyDropInsideItem).

## See Also
 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
 * [Implement Copy Drag]({%slug radtreeview-how-to-implement-copy-drag%})
 * [Auto Expand on Drag Over]({%slug radtreeview-how-to-enable-auto-expand-drag-over%})