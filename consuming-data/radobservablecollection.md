---
title: RadObservableCollection
page_title: RadObservableCollection
description: RadObservableCollection
slug: consuming-data-radobservablecollection
tags: radobservablecollection
published: True
position: 13
---

# RadObservableCollection

This article will give you information about the **RadObservableCollection**.

* [Overview](#overview)
* [Methods](#methods)
* [Properties](#properties)
* [Events](#events)

## Overview

Simply put, a RadObservableCollection represents an **ObservableCollection** that has the ability to suspend change notification events. Here is a typical use-case:

#### __[C#] Example 1: Using RadObservableCollection__

{{region cs-consuming-data-radobservablecollection_1}}
	clubs.SuspendNotifications();
    foreach (var item in newItems)
    {
        clubs.Add(item);
    }
    clubs.ResumeNotifications();
{{endregion}}

#### __[VB.NET] Example 1: Using RadObservableCollection__

{{region vb-consuming-data-radobservablecollection_1}}
	clubs.SuspendNotifications()
	For Each item In newItems
		clubs.Add(item)
	Next item
	clubs.ResumeNotifications()
{{endregion}}

## Methods

* **AddRange**: Adds the elements of the specified collection to the end of the RadObservableCollection. You can use this method to perform a bulk add operation.

* **InsertRange**: 	Inserts the elements of the specified collection at the specified index. You can use this method to perform a bulk add operation, starting at the specified index.

* **RemoveRange**: Removes the elements of the specified collection from the RadObservableCollection. You can use this method to perform a bulk remove operation.

>important It is important to note that all three of the above methods will call the **ResumeNotifications** method, even if notifications were previously suspended manually.

* **SuspendNotifications**: Suspends the notifications. You can use this when you're about to add a large number of new items and do not want to raise the **CollectionChanged** event for each item.

* **ResumeNotifications**: Resumes the notifications. You can use this once you're finished with adding the new items.

* **Reset**: Raises the **CollectionChanged** event with **NotifyCollectionChangedAction.Reset**.

## Properties

* **NotificationsSuspended**: Gets a value indicating whether change notifications are suspended.

* **ShouldResetOnResumeNotifications**: Gets a value that indicates whether RadObservableCollection would raise CollectionChanged event with **Reset** action, when a bulk add/remove operation takes place.

## Events

* **CollectionChanging**: Occurs when collection is changing - i.e., an item is being added/removed. The **CollectionChangingEventArgs** of the event handler holds the following properties:

	* **Action**: Gets or sets the collection change action. It is of type **CollectionChangeAction**.

	* **Cancel**: Set this to **True** to cancel the changes.
	
	* **Index**: Gets or sets the index of the current item being added/removed.

	* **Item**: Gets or sets the currently added/removed item.

* **PropertyChanged**: Occurs when a property value changes.