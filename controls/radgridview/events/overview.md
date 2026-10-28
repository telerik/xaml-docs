---
title: Overview
page_title: Events Overview
description: Learn more about the data, selection, edit, delete, sorting, filtering, grouping and other events exposed by RadGridView - Telerik's {{ site.framework_name }} DataGrid. 
components: ["gridview"]
slug: gridview-events-overview
tags: overview
published: True
position: 0
---

# Events Overview

This topic covers the specific events exposed by the __RadGridView__ control and its sub elements __GridViewColumn__, __GridViewRow__ and __GridViewCell__. The events are first grouped by control and then by their general purpose.

## RadGridView

The following sections group RadGridView events by purpose.

<a id="data-events"></a>

### RadGridView Data Events
            
* __DataLoading__: Occurs before the grid view data is loaded. The type of the passed event arguments is __GridViewDataLoadingEventArgs__. The event is raised when the control is first bound, when its **ItemsSource** is changed or when a [TableDefinition]({%slug gridview-basic-hierarchies%}#defining-the-gridviewtabledefinition) is updated.

* __DataLoaded__: Occurs when the grid view data is loaded. The type of the passed event arguments is {% if site.site_name == 'WPF' %}__System.EventArgs__{% endif %}{% if site.site_name == 'Silverlight' %}__GridViewDataLoadingEventArgs__{% endif %}. The event is raised when the control is first bound, when its **ItemsSource** is changed,when a [TableDefinition]({%slug gridview-basic-hierarchies%}#defining-the-gridviewtabledefinition) is updated or when a data operation (such as sorting, filtering and/or grouping) is performed. 

>note The DataLoading and DataLoaded events are triggered when the ItemsSource is changed.

* __BindingValidationError__: Occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __EventArgs__.

* __AddingNewDataItem__: Occurs when a new data item is about to be added. The type of the passed event arguments is __GridViewAddingNewEventArgs__.

<a id="selection-events"></a>

### RadGridView Selection Events

* __CurrentCellInfoChanged__: Occurs when the selected grid cell has changed. The type of the passed event arguments is __GridViewCurrentCellInfoChangedEventArgs__.

* __SelectionChanged__: Occurs when the selected grid row has changed. The type of the passed event arguments is __SelectionChangeEventArgs__.

* __RowActivated__: Occurs when a row is activated - when user double click on it or press enter. The type of the passed event arguments is __RowEventArgs__.

* __RowLoaded__: Occurs anytime the row appears within the view port. The type of the passed event arguments is __RowLoadedEventArgs__.

* __RowUnloaded__: Occurs anytime the row disappears within the view port. The type of the passed event arguments is __RowUnloadedEventArgs__.

<a id="edit-events"></a>

### RadGridView Edit Events

* __RowEditEnded__: Occurs when row validation passed successfully and new data is committed to the __RadGridView__.__ItemsSource__. The type of the passed event arguments is __GridViewRowEditEndedEventArgs__.

* __CellEditEnded__: Occurs when cell validation is passed successfully and new data is committed to the __RadGridView__.__ItemsSource__. The type of the passed event arguments is __GridViewCellEditEndedEventArgs__.

* __BeginningEdit__: Occurs when the cell is about to enter into EditMode. The type of the passed event arguments is __GridViewBeginningEditRoutedEventArgs__.

* __PreparingCellForEdit__: Occurs after the BeginningEdit event. It allows you to obtain a reference to the editing element and change its properties.

* __PreparedCellForEdit__: Occurs after the PreparingCellForEdit event.

See [Edit Events]({%slug gridview-events-edit%}) for more information.

### Delete Event

See [Delete Events]({%slug gridview-events-delete%}) for more information.

### Validation Events

See [Validation Events]({%slug gridview-events-validation%}) for more information.

### Filtering Events

See [Filtering Events]({%slug gridview-filtering-event-model%}) for more information.

### Sorting Events 

* __Sorting__: Occurs when the grid data is about to be sorted. The type of the passed event arguments is __GridViewSortingEventArgs__.

* __Sorted__: Occurs when the grid data has been sorted. The type of the passed event arguments is __GridViewSortedEventArgs__.

See [Sorting Events]({%slug gridview-sorting-basics%}#events) for more information.

### Searching Events

* __Searching__: Occurs when the grid data is about to be searched. The type of the passed event arguments is __GridViewSearchingEventArgs__ which contains the value of the text which was entered in the search panel **TextBox** - **SearchText**. They also contain a boolean property which indicates whether the event should be canceled - **Cancel**.

* __Searched__: Occurs when the grid data has been searched. The type of the passed event arguments is __GridViewSearchedEventArgs__ which contains the value of the text which was entered in the search panel **TextBox** - **SearchText**.

<a id="grouping"></a>

### Grouping Events

* __Grouping__: Occurs when the grid data is about to be grouped. The type of the passed event arguments is __GridViewGroupingEventArgs__.

* __Grouped__: Occurs when the grid data has been grouped. The type of the passed event arguments is __GridViewGroupedEventArgs__.

* __ChildTableDefinitionAdded__: Occurs when a new child table definition has been added. The type of the passed event arguments is __TableDefinitionCreatedEventArgs__.

See [Grouping Events]({%slug gridview-events-grouping%}) for more information.

### Exporting Events 
          
* __ElementExporting__: Occurs when the grid data is being exported. It is a direct replacement of the __Exporting__ event.

* __ElementExported__: Occurs after the __ElementExporting__ event where you can access the StreamWriter and write additional data to the stream.

* __ElementExportingToDocument__: Occurs when the grid data is being exported to Xlsx or Pdf.

* __ElementExportedToDocument__: Occurs after the ElementExportingToDocument event. Within it you can access the StreamWriter and write additional data to the stream.

See [Export Events]({%slug gridview-export-events%}) for more information.

### Row Details Events

* __UnloadingRowDetails__: Occurs when the row details are being unloaded. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.

* __RowDetailsVisibilityChanged__: Occurs when the visibility of the row details has changed. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.

* __LoadingRowDetails__: Occurs when the row details are being loaded. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.

### Column Resizing Events

* __ColumnWidthChanging__: Occurs when the column is being resized. Can be canceled. The type of the passed event arguments is __ColumnWidthChangingEventArgs__.

* __ColumnWidthChanged__: Occurs after the resize is complete. The type of the passed event arguments is __ColumnWidthChangedEventArgs__.

See [Column Resizing Events]({%slug gridview-column-resize-event%}) for more information.

<a id="other"></a>

### Column Generation and Row Expansion Events

* __AutoGeneratingColumn__: Occurs each time new column is auto generated by the grid view control. The type of the passed event arguments is __GridViewAutoGeneratingColumnEventArgs__.

* __RowIsExpandedChanged__: Occurs when a row's expanded state is changed - when its hierarchy child is expanded or collapsed.

	__Example 1: Shows if the row is expanded__

	The following example checks whether the row is expanded.

	<snippet id='radgridview-events-overview-example_1_shows_if_the_row_is_expanded-cs' />


* __RowIsExpandedChanging__: Occurs when a row's expanded state is about to be changed - when its hierarchy child is expanded or collapsed.

	__Example 2: Cancel the expanding__

	The following example cancels row expansion.

	<snippet id='radgridview-events-overview-example_2_cancel_the_expanding-cs' />


>note Both __RowIsExpandedChanged__ and __RowIsExpandedChanging__ occur only when a [Hierarchy]({%slug gridview-hierachy-overview%}) is defined. They do not apply when using the __RowDetailsTemplate__ property with another __RadGridView__.

## GridViewColumn

The following event reports changes to a column's sorting state.

<a id="sorting"></a>

### Column Sorting Events

* __SortingStateChanged__: Occurs when the sorting state of the column is changed. The type of the passed event arguments is `RadRoutedPropertyChangedEventArgs<SortingState>`.

## GridViewRow

The following sections describe events exposed by GridViewRow.

<a id="data-events-1"></a>

### GridViewRow Data Events
          
* __BindingValidationError__: Occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __ValidationErrorEventArgs__.

<a id="selection-events-1"></a>

### GridViewRow Selection Events

* __Selected__: Occurs when the grid row is selected. The type of the passed event arguments is __RoutedEventArgs__.

* __Unselected__: Occurs when the grid row is deselected. The type of the passed event arguments is __RoutedEventArgs__.

<a id="other-1"></a>

### Row Expansion Events

* __IsExpandedChanged__: Occurs when __GridViewRow__ changes its __IsExpanded__ state. The type of the passed event arguments is __RoutedEventArgs__.

## GridViewCell

The following sections describe events exposed by GridViewCell.

<a id="data-events-2"></a>

### GridViewCell Data Events

* __BindingValidationError__: Occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __ValidationErrorEventArgs__.

<a id="edit-events-1"></a>

### GridViewCell Edit Events

* __IsEditorVisibleChanged__: Occurs when the cell editor's visibility changes. The type of the passed event arguments is `RoutedPropertyChangedEventArgs<bool>`.

## See Also

* [Validation Events]({%slug gridview-events-validation%})
* [Column Resizing Events]({%slug gridview-column-resize-event%})
* [Export Events]({%slug gridview-export-events%})
* [Grouping Events]({%slug gridview-events-grouping%})
* [Sorting Events]({%slug gridview-sorting-basics%}#events)
* [Filtering Events]({%slug gridview-filtering-event-model%})
* [Delete Events]({%slug gridview-events-delete%})
* [Edit Events]({%slug gridview-events-edit%})
