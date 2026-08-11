---
title: Edit
page_title: Edit Events
description: Learn more about the edit events of Telerik's {{ site.framework_name }} DataGrid that occur when data is about to be edited or has been already edited by the user.
slug: gridview-events-edit
tags: edit
published: True
position: 2
---

# Edit Events


The edit events are ment to support the editing data process. They occur when the data in the __RadGridView__ is about to be edited or has been already edited by the user.

Currently the edit events occur on row and cell level. To get notified use the following events exposed by the __RadGridView__ control:

* [Edit Events Lifecycle](#edit-events-lifecycle)

* [BeginningEdit](#beginningedit-event)

* [PreparingCellForEdit](#preparingcellforedit-event)

* [PreparedCellForEdit](#preparedcellforedit-event)

* [CellEditEnded](#celleditended-event)

* [RowEditEnded](#roweditended-event)

## Edit Events Lifecycle

It is important to know that each one of the edit events is fired only when the user is trying to edit data in __RadGridView__ control.

The __BeginningEdit__ event always occurs when the user is about to edit the data. The __BeginningEdit__ event allows you to stop the edit process by setting the boolean property __Cancel__ to __True__. Note that regarding the fact that the edit process is cancelled, the __BeginningEdit__ event will still be raised. If not canceled, the __PreparingCellForEdit__ event is fired. You can access the default editing element there and set its properties if needed. The PreparingCellForEdit can be canceled too, thus preventing the __PreparedCellForEdit__ event to fire.

The __CellEditEnded__ event is always fired before __RowEditEnded__ event.

## BeginningEdit Event

The __BeginningEdit__ event occurs when the cell is about to enter into __EditMode__. The __BeginningEdit__ event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __GridViewBeginningEditRoutedEventArgs__ object. This object has the following properties:

* __Cancel__ - gets or sets the value indicating whether the event should be canceled. 

* __Cell__ - gets or sets the cell. 

* __Row__ - gets or sets the row. 

You can subscribe to the __BeginningEdit__ event declaratively or runtime like this:



<snippet id='radgridview-events-edit-block_1-xaml' />





<snippet id='radgridview-events-edit-block_2-cs' />

<snippet id='radgridview-events-edit-block_2-vb' />


The __BeginningEdit__ event is cancelable:



<snippet id='radgridview-events-edit-block_3-cs' />

<snippet id='radgridview-events-edit-block_3-vb' />



The example below uses the __BeginningEdit__ event to show a tool tip when the user tries to edit a cell from a certain column:



<snippet id='radgridview-events-edit-block_4-cs' />

<snippet id='radgridview-events-edit-block_4-vb' />



## PreparingCellForEdit Event

The PreparingCellForEdit event fires after the __BeginningEdit__ event. It allows you to access the default editor and initialize some of its properties if needed. The event handler receives two arguments:

* The __sender__ argument contains __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __GridViewPreparingCellForEditEventArgs__ object. This object has the following properties:

* __Cancel__ - gets or sets the value indicating whether the event should be canceled. 

* __Column__ - gets the column that the cell belong to. 

* __Row__ - gets the row that the cell belong to. 

* __EditingElement__ - gets the default editing element

The example below uses the __PreparingCellForEdit__ event to access the underlying TextBox editing element and set its TextWrapping property to Wrap:



<snippet id='radgridview-events-edit-block_5-cs' />

<snippet id='radgridview-events-edit-block_5-vb' />


## PreparedCellForEdit Event

The __PreparedCellForEdit__ event fires after the __PreparingCellForEdit__ event (if not canceled). When fired, the editing element is already prepared, e.g. the text is already selected. This is the place where you can alter this behavior. 

The event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __GridViewPreparingCellForEditEventArgs__ object. This object has the following properties:

* __Column__ - gets the column that the cell belong to. 

* __Row__ - gets the row that the cell belong to. 

* __EditingElement__ - gets the default editing element

The example below uses the __PreparedCellForEdit__ event to prevent the selection of the text inside the editing element:



<snippet id='radgridview-events-edit-block_6-cs' />

<snippet id='radgridview-events-edit-block_6-vb' />



## CellEditEnded Event

The __CellEditEnded__ occurs when cell validation is passed successfully and new data is committed to the __RadGridView.ItemsSource__. The __CellEditEnded__ event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type. 

* A __GridViewCellEditEndedEventArgs__ object. This object has the following properties:

* __Cell__ - Gets the edited cell.

* __EditAction__ - Gets the edit action.

* __EditingElement__ - Gets the editor element.

* __NewData__ - Gets the new data.

* __OldData__ - Gets the old data.

>important If the edited cell's column has a **CellEditTemplate** set, the **e.NewData** property will always be **null**. You can get the new value through the **e.EditingElement** parameter instead.

The __EditAction__ property is a __GridViewEditAction__ enumeration, which exposes the following values:

* __Cancel__

* __Commit__

You can subscribe to the __CellEditEnded__ event declaratively or runtime like this:



<snippet id='radgridview-events-edit-block_7-xaml' />





<snippet id='radgridview-events-edit-block_8-cs' />

<snippet id='radgridview-events-edit-block_8-vb' />



The example below uses the __CellEditEnded__ event to show a message box containing details of the cell being edited - like column's __Unique name__ and the __new value__ of the cell:



<snippet id='radgridview-events-edit-block_9-cs' />

<snippet id='radgridview-events-edit-block_9-vb' />


## RowEditEnded Event

The __RowEditEnded__ event occurs when row validation passed successfully and new data is committed to the __RadGridView.ItemsSource__.The __RowEditEnded__ event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __GridViewRowEditEndedEventArgs__ object. This object has the following properties:

* __NewData__ - Gets the new data of the edited row.

* __Row__ - Gets the edited __GridViewRow__.

* __EditAction__ - Gets the edit action.

* __EditOperationType__ - Gets the edit operation type.

>tip The __EditOperationType__ property is a __EditOperationType__ enumeration, which exposes the following values:

* __Insert__

* __Edit__

You can subscribe to the __RowEditEnded__ event declaratively or runtime like this:



<snippet id='radgridview-events-edit-block_10-xaml' />




<snippet id='radgridview-events-edit-block_11-cs' />

<snippet id='radgridview-events-edit-block_11-vb' />


The example below uses the __RowEditEnded__ to display the new data of the edited row in a text block. It also assumes that the grid is bound to List of __Employee__ objects:



<snippet id='radgridview-events-edit-block_12-cs' />

<snippet id='radgridview-events-edit-block_12-vb' />


>tip The __CellEditEnded__ event is always fired before __RowEditEnded__ event.

## See Also

 * [Events - Overview]({%slug gridview-events-overview%})

 * [Validation Events]({%slug gridview-events-validation%})
