---
title: Insert and Remove Data
page_title: Insert and Remove Data
description: Check our &quot;Insert and Remove Data&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-insert-data-and-remove-data
tags: insert,remove,data
published: True
position: 2
---

# Insert and Remove Data

* [Methods](#methods)

* [Events](#events)

__RadVirtualGrid__ exposes an API for inserting and removing rows and columns at given index. This can be achieved through the following methods:

> The methods for removing a row or column cannot be utilized for pinned rows or columns.

## Methods

* __InsertNewRowAtIndex(int index)__: Increases the table capacity by adding a row at given index

* __InsertNewColumnAtIndex(int index)__: Increases the table capacity by adding a column at given index

* __RemoveRowAtIndex(int index)__: Decreases the capacity of the table by removing a row at given index

* __RemoveColumnAtIndex(int index)__: Decreases the capacity of the table by removing a column at given index

>When inserting a row or a column, the control simply increases its capacity. Updating the source collection with this modification needs to be done manually as well.

## Events

Events related to a deletint operation will be raised when the selected indexes are deleted through the __Delete key__.

### Deleting

Raised when the selected indexes of __RadVirtualGrid__ are about to be deleted. The __VirtualGridDeletingEventArgs__ expose the __Indexes__ property.

* __Cancel__: As the event arguments are of type __CancelEventArgs__, the event can be canceled through this property.

* __Indexes__: The selected indexes that are about to be deleted.

__Example 1: Subscribing to the Deleting event__
```C#
	private void VirtualGrid_Deleting(object sender, VirtualGridDeletingEventArgs e) 
	{ 
	}
```

### Deleted

This event is raised when the selected indexes of the control have been deleted. Similarly to the __VirtualGridDeletingEventArgs__, the __VirtualGridDeletedEventArgs__ provide the __Indexes property__

* __Indexes__: The selected indexes that have been deleted.

__Example 2: Subscribing to the Deleted event__
```C#
	private void VirtualGrid_Deleted(object sender, VirtualGridDeletedEventArgs e) 
	{ 
	}
```

## See Also

* [Editing]({%slug virtualgrid-editing%})

* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})
