---
title: Delete
page_title: Delete Events
description: Learn more about the delete events of Telerik's {{ site.framework_name }} DataGrid that occur when data is about to be deleted or has been already deleted by the user.
slug: gridview-events-delete
tags: delete
published: True
position: 3
---

# Delete Events

The delete events are ment to support the deleting data process. They occur when the data in the __RadGridView__ is about to be deleted or has been already deleted by the user.

Currently the delete events occur once for all the rows to be deleted. To get notified use the following events exposed by the __RadGridView__ control:

* [Delete Events Lifecycle](#delete-events-lifecycle)

* [Deleting event](#deleting-event)

* [Deleted event](#deleted-event)

## Delete Events Lifecycle

It is important to know that each one of the delete events is fired only when the user is trying to delete row/rows in the __RadGridView__ control by invoking the __Delete__ command, for example via the Delete button on the keyboard.

The __Deleting__ event always occurs when the user is about to delete the row/rows. The __Deleting__ event can be __canceled__ thus allowing you to stop the delete process. To do so set the __Cancel__ property of the event arguments to __True__.

If the Deleting event is not canceled then the data is deleted and the __Deleted__ event fires.

## Deleting event

The __Deleting__ event occurs when the row/rows is about to be deleted. It fires only once for all the selected rows (in case the [SelectionMode]({%slug gridview-multiple-selection%}) is set to Multiple or Extended). The Deleting event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type. 


* A __GridViewDeletingEventArgs__ object. This object has the following properties: 


* __Cancel__ - gets or sets the value indicating whether the event should be canceled. 


* __Items__ - IEnumerable<Object> collection of the gridview's items to be deleted 

You can subscribe to the __Deleting__ event declaratively or runtime like this:



<snippet id='radgridview-events-delete-block_1-xaml' />





<snippet id='radgridview-events-delete-block_2-cs' />

<snippet id='radgridview-events-delete-block_2-vb' />



The Deleting event is cancelable. The example below uses the __Deleting__ event to ask the user for confirmation before the deletion is performed.



<snippet id='radgridview-events-delete-block_3-cs' />

<snippet id='radgridview-events-delete-block_3-vb' />


## Deleted event

The __Deleted__ event occurs when the data has been deleted. The __Deleted__ event handler receives two arguments:The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type. 
A __GridViewDeletedEventArgs__ object. This object has the following properties: 

* __Items__ - IEnumerable<Object> collection of the gridview's items that have been deleted

You can subscribe to the __Deleted__ event declaratively or runtime like this:



<snippet id='radgridview-events-delete-block_4-xaml' />




<snippet id='radgridview-events-delete-block_5-cs' />

<snippet id='radgridview-events-delete-block_5-vb' />



## See Also

 * [Overview]({%slug gridview-events-overview%})
 * [Commands]({%slug gridview-commands-overview%})
