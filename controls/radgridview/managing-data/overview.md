---
title: Overview
page_title: Overview
description: Overview
slug: gridview-managing-data-overview
tags: overview
published: True
position: 0
---

# Overview

Telerik's __RadGridView__ allows you not only to display sets of data, but also to manage them. You are able to use the standard operations - __Insert, Update and Delete__. You can also validate the data. Besides using this functionality, you are able to control it via the several events raised at the most important key points of the operation.

## Managing Collections

Some data sources, such as those implementing __INotifyCollectionChanged(ObservableCollection<T>)__, support data inserts, change notifications and etc. This means that they will automatically handle the creation of new objects in the collection and send notifications to the __DataBinding__ engine that the data has changed. When using collections that don't support inserts and change notifications as data source, you have to create the new items manually and rebind the grid to the modified data source to display the modified data.

> When __DataTable__ is needed as a source collection of __RadGridView__, it is recommended to use its __DefaultView__ property. It raises a notification for a collection change and its __DataRowView__ implements __INotifyPropertyChanged__ interface, thus the UI will be updated out-of-the-box.

## Adding New Entries

The adding of new entires is achieved via the __GridViewNewRow__ control, which appears when the user hits the "Insert" key or when the developer initiate an add operation. To learn more about how to add items to your __RadGridView__ control take a look at the [Adding New Entries]({%slug gridview-managing-data-add-new-entries%}) topic.

## Updating an Entry

The updating of entries takes place in the same cell, where the data is displayed. Only one item and only one cell in it can be edited at a time. You are able to restrict certain cells or the entire grid from being edited. To edit a cell the user can hit the "F2" key or the developer can initialize an edit operation. To learn more about how to add items to your __RadGridView__ control take a look at the [Updating an Entry]({%slug gridview-managing-data-updating-entry%}) topic.

## Deleting an Entry

You are able to remove items from the __RadGridView__ by manipulating the __ItemsSource__ collection. To learn how to do it and what other features can be used when determining the items to remove take a look at the [Deleting an Entry]({%slug gridview-managing-data-deleting-entry%}) topic.

## Validation

Tha __RadGridView__ allows you to validate the data entered in the managed cells by applying custom validating rules. You can validate for each cell or validate the whole row at a time. To learn how to implement the validation take a look at the [Validation]({%slug gridview-managing-data-validation%}) topic.

## Events

The data editing model of the __RadGridView__ provides an editing process which consists of several steps. Each step is supplemented by an event on __RadGridView__ control. These events allow the developer to inject custom logic in the editing process and control it as required. The events related to the editing logic are:

* __GridViewDataControl.BeginningEdit__ - occurs when the cell is about to enter into EditMode (can be cancelled).

* __GridViewDataControl.PreparingCellForEdit__ - occurs when the cell is entering edit mode (can be cancelled).

* __GridViewDataControl.PreparedCellForEdit__ - occurs when the cell is prepared for edit.

* __GridViewDataControl.RowValidating__ - occurs when a row is about to commit new content (can stop commit process of the row).

* __GridViewDataControl.RowValidated__ - occurs when a row has validated the new content.

* __GridViewDataControl.CellValidating__ - occurs when a cell is about to commit new content (can stop commit process of the cell).

* __GridViewDataControl.CellValidated__ - occurs when a cell has validated the new content.

* __GridViewDataControl.CellEditEnded__ - occurs when a cell validation is passed successfully and new data is committed to the __RadGridView.ItemsSource__.

* __GridViewDataControl.RowEditEnded__ - occurs when a row validation has passed successfully and new data is committed to the __RadGridView.ItemsSource__.

To learn more about the events in the __RadGridView__ take a look at the [Events]({%slug gridview-events-overview%}) topic.

# See Also

 * [Adding New Entries]({%slug gridview-managing-data-add-new-entries%})

 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})

 * [Deleting an Entry]({%slug gridview-managing-data-deleting-entry%})

 * [Validating]({%slug gridview-managing-data-validation%})
