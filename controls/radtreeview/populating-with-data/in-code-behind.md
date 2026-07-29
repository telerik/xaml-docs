---
title: In Code-Behind
page_title: In Code-Behind
description: Check our &quot;In Code-Behind&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-populating-with-data-in-code-behind
tags: in,code-behind
published: True
position: 3
---

# In Code-Behind

This tutorial will walk you through the common tasks of __adding__ and __removing RadTreeViewItems__ programmatically.  

Here is a snapshot of a regular treeview without treeview items: 

![{{ site.framework_name }} RadTreeView Without Items](images/RadTreeView_PopulatingWithDataCodeBehind___001.PNG)

<snippet id='radtreeview-populating-with-data-in-code-behind-block_1-xaml' />

## Adding TreeView Items 

In order to add new treeview items to a treeview control, first you have to create an instance of the __RadTreeViewItem__ class, set its properties like __Header__, __Foreground__, etc., and then add it to the treeview items collection. 

<snippet id='radtreeview-populating-with-data-in-code-behind-block_2-cs' />
<snippet id='radtreeview-populating-with-data-in-code-behind-block_3-vb' />

In order to create your hierarchical structure deeper, you just need to add __RadTreeViewItem__ child nodes to any of the previously declared items. For example, here is the same __AddTreeViewItems()__ method, but this time a little more extended: 

<snippet id='radtreeview-populating-with-data-in-code-behind-block_4-cs' />
<snippet id='radtreeview-populating-with-data-in-code-behind-block_5-vb' />

This will be the result if you execute the __AddTreeViewItems()__ method: 
![{{ site.framework_name }} RadTreeView Populated from Code-Behind](images/RadTreeView_PopulatingWithDataCodeBehind___010.PNG)

>tip Consider declaring treeview items in XAML instead of adding them by code whenever it's possible. This includes situations when you know what items you need at design time.

## Removing TreeView Items 

In order to remove a treeview item you have to remove it from the treeview items collection.

<snippet id='radtreeview-populating-with-data-in-code-behind-block_6-cs' />
<snippet id='radtreeview-populating-with-data-in-code-behind-block_7-vb' />

## See Also
 * [DataBinding - Overview]({%slug radtreeview-populating-with-data-databinding-overview%})
 * [Populating with Data - Declaratively]({%slug radtreeview-populating-with-data-declaratively%})
 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})
 * [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%})
 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})
 * [Binding to ADO.NET Data Service]({%slug radtreeview-populating-with-data-databinding-to-adonet-service%})