---
title: Get Item by Path
page_title: Get Item by Path
description: Check our &quot;Get Item by Path&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-get-item-by-path
tags: get,item,by,path
published: True
position: 1
---

# Get Item by Path

The __RadTreeView__ API offers you the ability to get an item by path programmatically. This tutorial will show you how to do that.

## Using GetItemByPath in static RadTreeView

Here is an ordinary treeview declaration: 

<snippet id='radtreeview-how-to-get-item-by-path-block_1-xaml' />

![{{ site.framework_name }} RadTreeView Sample Declaration](images/RadTreeView_HowToGetItemByPath_001.PNG)

For example, see the following situation - you want to retrieve the treeview item with __Header__ Soccer. In order to do that you need to perform the following steps:

1. Create a path, including only the treeview items' header and using some separator.

2. Set the __telerik:TextSearch.TextPath__ attached property to indicate which property to be used as a path segment.

	<snippet id='radtreeview-how-to-get-item-by-path-block_2-xaml' />

3. Invoke the __GetItemByPath()__ method of the __RadTreeView__ class. 

	<snippet id='radtreeview-how-to-get-item-by-path-block_3-cs' />
	<snippet id='radtreeview-how-to-get-item-by-path-block_4-vb' />

	The __GetItemByPath()__ method will work only __after__ the treeview has __loaded__. It will not work before that.
	
	<snippet id='radtreeview-how-to-get-item-by-path-block_5-cs' />
	<snippet id='radtreeview-how-to-get-item-by-path-block_6-vb' />
	
	>Note that, invoking the __GetItemByPath()__ method will expand the target item without animation, regardless the value of the [AnimationManager.IsAnimationEnabled]({%slug radtreeview-how-to-disable-default-animation%}) property.

The __RadTreeView__ class supports __PathSeparator__ property, which represents the default separator. The default separator for the __RadTreeView__ is "__\\__", but it can be changed. Here you can see how the previous example will look like if you set the __PathSeparator__ property. 

<snippet id='radtreeview-how-to-get-item-by-path-block_7-cs' />
<snippet id='radtreeview-how-to-get-item-by-path-block_8-vb' />

>The __RadTreeView__ has __ExpandItemByPath()__ method which internally uses the __GetItemByPath()__, and in addition expands the item

## Using GetItemByPath in a Data Bound RadTreeView

You can see how to use the __GetItemByPath()__ method with a tree in a data binding scenario in the [Expand and Select Item with Load on Demand Enabled RadTreeView]({%slug radtreeview-howto-exapand-select-item-with-lod-enabled-treeview%}) article.

## See Also
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
 * [Templated Nodes]({%slug radtreeview-styles-and-templates-templated-nodes%})