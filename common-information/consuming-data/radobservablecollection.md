---
title: Observable Collections
page_title: RadObservableCollection and ObservableItemCollection
description: This article provides information about the RadObservableCollection and ObservableItemCollection classes.
slug: consuming-data-radobservablecollection
tags: radobservablecollection, observableitemcollection
published: True
position: 13
---

# RadObservableCollection and ObservableItemCollection

This article will give you information about the **RadObservableCollection**.

* [Overview](#overview)
* [Methods](#methods)
* [Properties](#properties)
* [Events](#events)
* [ObservableItemCollection](#observableitemcollection)

## Overview

Simply put, a RadObservableCollection represents an **ObservableCollection** that has the ability to suspend change notification events. Here is a typical use-case:

__Example 1: Using RadObservableCollection__

```C#
	clubs.SuspendNotifications();
    foreach (var item in newItems)
    {
        clubs.Add(item);
    }
    clubs.ResumeNotifications();
```
```VB.NET
	clubs.SuspendNotifications()
	For Each item In newItems
		clubs.Add(item)
	Next item
	clubs.ResumeNotifications()
```

## Methods

* **AddRange**: Adds the elements of the specified collection to the end of the RadObservableCollection. You can use this method to perform a bulk add operation.

* **InsertRange**: 	Inserts the elements of the specified collection at the specified index. You can use this method to perform a bulk add operation, starting at the specified index.

* **RemoveRange**: Removes the elements of the specified collection from the RadObservableCollection. You can use this method to perform a bulk remove operation.

>important It is important to note that all three of the above methods will call the **ResumeNotifications** method, even if notifications were previously suspended manually.

* **SuspendNotifications**: Suspends the notifications. You can use this when you're about to add a large number of new items and do not want to raise the **CollectionChanged** event for each item.

* **ResumeNotifications**: Resumes the notifications. You can use this once you're finished with adding the new items.

>Calling the ResumeNotifications method after adding items to the collection with suspended notifications raises the **CollectionChanged** event with **NotifyCollectionChangedAction.Reset**.

* **Reset**: Raises the **CollectionChanged** event with **NotifyCollectionChangedAction.Reset**.

## Properties

* **NotificationsSuspended**: Gets a value indicating whether change notifications are suspended.

There is also a public read-only property called `ShouldResetOnResumeNotifications`. It gets a value that indicates whether RadObservableCollection would raise CollectionChanged event with Reset action, when a bulk add/remove operation takes place. This API is internal and this behavior cannot be changed. The property value is set to `true` which means that calling `ResumeNotifications` will always use the Reset action.

## Events

* **CollectionChanging**: Occurs when collection is changing - i.e., an item is being added/removed. The **CollectionChangingEventArgs** of the event handler holds the following properties:

	* **Action**: Gets or sets the collection change action. It is of type **CollectionChangeAction**.

	* **Cancel**: Set this to **True** to cancel the changes.
	
	* **Index**: Gets or sets the index of the current item being added/removed.

	* **Item**: Gets or sets the currently added/removed item.

* **PropertyChanged**: Occurs when a property value changes.

## ObservableItemCollection

__ObservableItemCollection__ extends __RadObservableCollection__ by exposing the __ItemChanged__ event. It is raised when one of the properties of the items present in the collection is changed.

**ItemChanged**: The event provides the following properties:

 * **Item**: Gets the item that has changed.
 * **PropertyName**: Gets the name of the property that has changed.

## See Also

* [Consuming Data Overview]({%slug consuming-data-overview%})

* [In-Memory Data]({%slug consuming-data-in-memory-data%})
