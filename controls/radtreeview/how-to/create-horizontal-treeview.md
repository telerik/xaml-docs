---
title: Create Horizontal TreeView
page_title: Create Horizontal TreeView
description: Check our &quot;Create Horizontal TreeView&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-create-horizontal-treeview
tags: create,horizontal,treeview
published: True
position: 12
---

# Create Horizontal TreeView

This tutorial will show you how to create a __RadTreeView__ with horizontal orientation.

Here is an ordinary treeview declaration: 

<snippet id='radtreeview-how-to-create-horizontal-treeview-block_1-xaml' />

![{{ site.framework_name }} RadTreeView Sample Declaration](images/RadTreeView_HowToCreateHorizontalTreeView_001.PNG)

In order to create a horizontal treeview you need to set the __ItemContainerStyle__ property of the __RadTreeView__ and the __RadTreeViewItem__.

Declare the following style in the resources of your application. It will set the __ItemsPanel__ to a __StackPanel__ with __Horizontal__ orientation: 

<snippet id='radtreeview-how-to-create-horizontal-treeview-block_2-xaml' />

Apply this style to the __ItemContainerStyle__ of the treeview and each treeview item. 

<snippet id='radtreeview-how-to-create-horizontal-treeview-block_3-xaml' />

Here is the result:
![{{ site.framework_name }} RadTreeView Horizontal Orientation](images/RadTreeView_HowToCreateHorizontalTreeView_010.PNG)

## See Also
 * [Styling the Expander]({%slug radtreeview-styling-and-appearance-styling-expander%})
 * [Templated Nodes]({%slug radtreeview-styles-and-templates-templated-nodes%})
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})