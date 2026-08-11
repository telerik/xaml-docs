---
title: Iterate Through TreeViewItems
page_title: Iterate Through TreeViewItems
description: Check our &quot;Iterate Through TreeViewItems&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-iterate-through-treeviewitems
tags: iterate,through,treeviewitems
published: True
position: 11
---

# Iterate Through TreeViewItems

Telerik __RadTreeView__ class inherits from __ItemsControl__. The __Items__ collection of the __ItemsControl__ is a collection of data objects, __not__ from __RadTreeViewItems__. There is a very important concept about the items and item containers. When you bind an __ItemsControl__ you have your data items populating the __Items__ collection of the control. The containers are the __visual presentations__ of those data items (in this case the containers are the __RadTreeViewItems__). Containers are not created automatically when the __ItemsControl__ is bound, but are created __asynchronously and only when needed__. For example in the case with the TreeView, the containers are not being created until their parent is expanded.

So how you can get the container from the data item? Or in this case - how to get the RadTreeViewItem from your data object which you receive when traversing the Items collection?

There are several helper methods that can be used. Each ItemsControl has a Property named __ItemContainerGenerator__. It is of type __ItemContainerGenerator__. This class has the following methods that can help you in this case:		

* __DependencyObject.ContainerFromIndex(int index)__ - returns the Container for the given index from the Items collection.
* __DependencyObject.ContainerFromItem(object item)__ -  returns the Container for the given data item from the Items collection.

So here is an example about how to get access to all of the Containers in the __RadTreeView__:

The item container may be null if it isn't still generated from the runtime. That's why you should access the containers when your control is generated and added to the visual tree. 



<snippet id='radtreeview-how-to-iterate-through-treeviewitems-block_1-cs' />
<snippet id='radtreeview-how-to-iterate-through-treeviewitems-block_2-vb' />

{% if site.site_name == 'Silverlight' %}



<snippet id='radtreeview-how-to-iterate-through-treeviewitems-block_3-cs' />
<snippet id='radtreeview-how-to-iterate-through-treeviewitems-block_4-vb' />

{% endif %}

{% if site.site_name == 'WPF' %}



<snippet id='radtreeview-how-to-iterate-through-treeviewitems-block_5-cs' />
<snippet id='radtreeview-how-to-iterate-through-treeviewitems-block_6-vb' />

{% endif %}

## See Also
 * [Bind to a Selected Item]({%slug radtreeview-how-to-bind-selected-item%})
 * [Add Context Menu]({%slug radtreeview-how-to-add-context-menu%})
 * [Bind RadTreeView to Self-Referencing Data]({%slug radtreeview-how-to-bind-to-self-referencing-data%})
 * [Bind RadTreeView to Hierarchical Data and Use Style Binding]({%slug radtreeview-howto-bind-hierarchical-data-style-binding%})