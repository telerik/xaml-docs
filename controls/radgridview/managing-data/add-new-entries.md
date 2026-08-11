---
title: Adding New Entries
page_title: Adding New Entries
description: Read more about the two ways of adding new entries in Telerik's DataGrid - by pressing the Insert key or by calling the BeginInsert method.
slug: gridview-managing-data-add-new-entries
tags: adding,new,entries
published: True
position: 1
---

# Adding New Entries

RadGridView comes with out-of-the-box insert functionality.

There are three ways to insert a new row in RadGridView:

* By pressing the __Insert__ key
* By clicking on the row which is shown in the control when the `NewRowPosition` property is set to either __Top__ or __Bottom__. To learn more about this approach, check this [article]({%slug gridview-new-row%}).
* By calling the `BeginInsert` method

__Adding new rows with BeginInsert()__
<snippet id='radgridview-managing-data-add-new-entries-adding_new_rows_with_begininsert-cs' />

<snippet id='radgridview-managing-data-add-new-entries-adding_new_rows_with_begininsert-vb' />


When a user adds a new item, an empty row is created in which the user can input data.

__The newly created row__

![Telerik UI for {{ site.framework_name }} RadGridView showing a newly inserted empty row ready for data entry](images/RadGridView_AddingNewItems_1.png)

>important If the `IsReadOnly` property of RadGridView is set to __True__ or the `CanUserInsertRows` property is set to __False__, no row is added. Additionally, the underlying object should expose a default constructor for an empty row to be added.

## Modifying New Entries

The next step in implementing the adding functionality is to attach event handlers to the `AddingNewDataItem` and the `RowEditEnded` events.

__Add handlers for the AddingNewDataItem and RowEditEnded events__
<snippet id='radgridview-managing-data-add-new-entries-add_handlers_for_the_addingnewdataitem_and_roweditended_events-xaml' />


The AddingNewDataItem event is raised before a new row is added to RadGridView. A typical use case would be when you have to set initial values for an initialized object. You can do this by passing an object to the `GridViewAddingNewEventArgs`'s `NewObject` property.

__The AddingNewDataItem event handler__
<snippet id='radgridview-managing-data-add-new-entries-the_addingnewdataitem_event_handler-cs' />

<snippet id='radgridview-managing-data-add-new-entries-the_addingnewdataitem_event_handler-vb' />


If the ItemsSource is a `DataTable.DefaultView`, you can initialize the newly inserted item as shown below:

__Adding a new item to a DataTable__
<snippet id='radgridview-managing-data-add-new-entries-adding_a_new_item_to_a_datatable-cs' />

<snippet id='radgridview-managing-data-add-new-entries-adding_a_new_item_to_a_datatable-vb' />


>tip Via the `OwnerGridViewItemsControl` property of the `GridViewAddingNewEventArgs` class you can access the `GridViewItemsControl` for the `RadGridView` that raised the event.

## Committing New Entries

The `RowEditEnded` event is raised when new data is added to RadGridView. This can be done in any of the following ways: 

* When the user presses the __Enter__ key.
* When the `CommitEdit` method is called.
* When another row is selected.
* When the insert operation is cancelled by pressing the __Escape__ key or calling the `CancelEdit` method.

You can access the `EditAction` (__Commit__ or __Cancel__) and the `GridViewEditOperationType` (__Insert__ or __Edit__) using `GridViewRowEditEndedEventArgs` of the RowEditEnded event. It also allows you to access the new data via the `NewData` property.

__Handling the RowEditEnded event__
<snippet id='radgridview-managing-data-add-new-entries-handling_the_roweditended_event-cs' />

<snippet id='radgridview-managing-data-add-new-entries-handling_the_roweditended_event-vb' />


When the new item is committed, it is added to RadGridView's `Items` collection.

__The new row__

![Telerik UI for {{ site.framework_name }} RadGridView showing the committed new row after data entry is completed](images/RadGridView_AddingNewItems_2.png)

## See Also

 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})

 * [Deleting an Entry]({%slug gridview-managing-data-deleting-entry%})

 * [Validating]({%slug gridview-managing-data-validation%})

 * [Adding Rows]({%slug gridview-rows-adding-rows%})
