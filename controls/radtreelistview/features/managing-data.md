---
title: Managing Data
page_title: Managing Data
description: Check our &quot;Managing Data&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-features-managing-data
tags: managing,data
published: True
position: 5
---

# Managing Data



Telerik's __RadTreeListView__ allows you not only to display sets of data, but also to manage them. You are able to use the standard operations - __Insert__, __Update__ and __Delete__. You can also validate the data. Besides using this functionality, you are able to control it via the several events raised at the most important key points of the operation.

>tip As the __RadTreeListView__ directly inherits the __RadGridView__ it uses the same data management mechanism. To learn more read the [respective topics]({%slug gridview-managing-data-overview%}) in the __RadGridView's__ documentation.

## Managing Collections

Some data sources, such as those implementing __INotifyCollectionChanged__ (__ObservableCollection<T>__), support data inserts, change notifications, etc. This means that they will automatically handle the creation of new objects in the collection and will send notifications to the __DataBinding__ engine that the data has changed. When using collections that don't support inserts and change notifications as data source, you have to create the new items manually and to rebind the grid to the modified data source in order to display the modified data.

## Adding New Entries

The adding of new entries is achieved via the __GridViewNewRow__ control, which appears when the user hits the "Insert" key or when the developer initiates an add operation.

>As for now the __RadTreeListView__ is not capable of automatically adding items to any level of the hierarchy. If you use the default approach, the items will be added to the root level. Still you are able to add items by manually adding the item to the source collection at the level you want.

## Updating an Entry

The updating of entries takes place in the same cell, where the data is displayed. Only one item and only one cell in it can be edited at a time. You are able to restrict certain cells or the entire grid from being edited. In order to edit a cell, the user can hit the __"F2"__ key or the developer can initialize an edit operation. 

## Deleting an Entry

You are able to remove items from the __RadGridView__ by manipulating the __ItemsSource__ collection.

## Validation

Tha __RadGridView__ allows you to validate the data entered in the managed cells by applying custom validating rules. You can validate for each cell or you can validate the whole row at a time.

## See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})

 * [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%})

 * [Data Binding]({%slug radtreelistview-features-data-binding%})
