---
title: Working with ItemPrepared Event
page_title: Working with ItemPrepared Event
description: Check our &quot;Working with ItemPrepared Event&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-events-working-with-item-prepared-event
tags: working,with,itemprepared,event
published: True
position: 1
---

# Working with ItemPrepared Event

The purpose of this tutorial is to show you how to work with the __RadTreeView__'s __ItemPrepared__ event. This event occurs when a child __RadTreeViewItem__ has been prepared and is now ready for use. The main goal of this event is to perform binding of __RadTreeViewItem__ properties to the data objects.

The example shown in this tutorial will demonstrate you how to bind the check state of individual treeview items to a __ToggleState__ property of a class.

In few words, the approaches that you should follow are:

* Create a sample data source

	For the purpose of this example the following business objects will be used:

	<snippet id='radtreeview-events-working-with-item-prepared-event-block_1-cs' />
	<snippet id='radtreeview-events-working-with-item-prepared-event-block_2-vb' />

	The __CheckState__ property of the __DataItem__ class will be bound to the __CheckState__ property of the __RadTreeViewItem__.

	<snippet id='radtreeview-events-working-with-item-prepared-event-block_3-cs' />
	<snippet id='radtreeview-events-working-with-item-prepared-event-block_4-vb' />

	The __RawDataSource__ does nothing special, except for initializing the sample data for the __RadTreeView__. This is the data source for the treeview.

* Add a new __RadTreeView__ declaration. Enable the following properties:
	* __IsOptionElementsEnabled__
	* __IsTriStateMode__

	<snippet id='radtreeview-events-working-with-item-prepared-event-block_5-xaml' />



* Declare a __RawDataSource__ object as a resource in your XAML and set the __RadTreeView__'s __ItemsSource__ property.

	<snippet id='radtreeview-events-working-with-item-prepared-event-block_6-xaml' />

* Declare a new [HierarchicalDataTemplate]({%slug radtreeview-populating-with-data-hierarchical-data-templates%}) in your XAML resources and set the __RadTreeView__'s __ItemTemplate__ property.

	<snippet id='radtreeview-events-working-with-item-prepared-event-block_7-xaml' />

* The final and most important step is to attach to the __ItemPrepared__ event of the __RadTreeView__.

	<snippet id='radtreeview-events-working-with-item-prepared-event-block_8-xaml' />

	Switch to the code-behind and in the event handler add a code, synchronizing the __CheckState__ property of the __RadTreeViewItem__ object with the __CheckState__ property of the __DataItem__ object.

	<snippet id='radtreeview-events-working-with-item-prepared-event-block_9-cs' />
	<snippet id='radtreeview-events-working-with-item-prepared-event-block_10-vb' />
		
* The example so far is almost complete. However, there are some drawbacks. The __RadTreeViewItem__'s __CheckState__ property is synchronized just once. If the user checks\unchecks a specific treeview item, the source object will not be updated. In order to solve this problem you should attach to the __RadTreeViewItem__'s __Checked__ and __Unchecked__ events.

	<snippet id='radtreeview-events-working-with-item-prepared-event-block_11-cs' />
	<snippet id='radtreeview-events-working-with-item-prepared-event-block_12-vb' />

## See Also
 * [Events-Overview]({%slug radtreeview-events-overview%})