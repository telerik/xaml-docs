---
title: Overview
page_title: Events Overview
description: Learn more about the data, selection, edit, delete, sorting, filtering, grouping and other events exposed by RadGridView - Telerik's {{ site.framework_name }} DataGrid. 
slug: gridview-events-overview
tags: overview
published: True
position: 0
---

# Events Overview

This topic covers the specific events exposed by the __RadGridView__ control and its sub elements __GridViewColumn__, __GridViewRow__ and __GridViewCell__. The events are first grouped by control and then by their general purpose.

## RadGridView

### Data Events
            
* __DataLoading__: Occurs before the grid view data is loaded. The type of the passed event arguments is __GridViewDataLoadingEventArgs__. The event is raised when the control is first bound, when its **ItemsSource** is changed or when a [TableDefinition]({%slug gridview-basic-hierarchies%}#defining-the-gridviewtabledefinition) is updated.

* __DataLoaded__: Occurs when the grid view data is loaded. The type of the passed event arguments is {% if site.site_name == 'WPF' %}__System.EventArgs__{% endif %}{% if site.site_name == 'Silverlight' %}__GridViewDataLoadingEventArgs__{% endif %}. The event is raised when the control is first bound, when its **ItemsSource** is changed,when a [TableDefinition]({%slug gridview-basic-hierarchies%}#defining-the-gridviewtabledefinition) is updated or when a data operation (such as sorting, filtering and/or grouping) is performed. 

>The DataLoading and DataLoaded events are triggered when the ItemsSource is changed

* __BindingValidationError__: Occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __EventArgs__.

* __AddingNewDataItem__: Occurs when a new data item is about to be added. The type of the passed event arguments is __GridViewAddingNewEventArgs__.

### Selection Events

* __CurrentCellInfoChanged__: Occurs when the selected grid cell has changed. The type of the passed event arguments is __GridViewCurrentCellInfoChangedEventArgs__.

* __SelectionChanged__: Occurs when the selected grid row has changed. The type of the passed event arguments is __SelectionChangeEventArgs__.

* __RowActivated__: Occurs when a row is activated - when user double click on it or press enter. The type of the passed event arguments is __RowEventArgs__.

* __RowLoaded__: Occurs anytime the row appears within the view port. The type of the passed event arguments is __RowLoadedEventArgs__.

* __RowUnloaded__: Occurs anytime the row disappears within the view port. The type of the passed event arguments is __RowUnloadedEventArgs__.

### Edit Events

* __RowEditEnded__: Occurs when row validation passed successfully and new data is committed to the __RadGridView__.__ItemsSource__. The type of the passed event arguments is __GridViewRowEditEndedEventArgs__.

* __CellEditEnded__: Occurs when cell validation is passed successfully and new data is committed to the __RadGridView__.__ItemsSource__. The type of the passed event arguments is __GridViewCellEditEndedEventArgs__.

* __BeginningEdit__: Occurs when the cell is about to enter into EditMode. The type of the passed event arguments is __GridViewBeginningEditRoutedEventArgs__.

* __PreparingCellForEdit__: Occurs after the BeginningEdit event. It allows you to obtain a reference to the editing element and change its properties.

* __PreparedCellForEdit__: Occurs after the PreparingCellForEdit event.

Get more information about the edit events [here]({%slug gridview-events-edit%}).

### Delete Event

Get more information about the delete events [here]({%slug gridview-events-delete%}).    

### Validation Events

Get more information about the validation events [here]({%slug gridview-events-validation%}).

### Filtering Events

Get more information about the filtering events [here]({%slug gridview-filtering-event-model%}).  

### Sorting Events 

* __Sorting__: Occurs when the grid data is about to be sorted. The type of the passed event arguments is __GridViewSortingEventArgs__.

* __Sorted__: Occurs when the grid data has been sorted. The type of the passed event arguments is __GridViewSortedEventArgs__.

Get more information about the sorting events [here]({%slug gridview-sorting-basics%})

### Searching Events

* __Searching__: Occurs when the grid data is about to be searched. The type of the passed event arguments is __GridViewSearchingEventArgs__ which contains the value of the text which was entered in the search panel **TextBox** - **SearchText**. They also contain a boolean property which indicates whether the event should be canceled - **Cancel**.

* __Searched__: Occurs when the grid data has been searched. The type of the passed event arguments is __GridViewSearchedEventArgs__ which contains the value of the text which was entered in the search panel **TextBox** - **SearchText**.

### Grouping 

* __Grouping__: Occurs when the grid data is about to be grouped. The type of the passed event arguments is __GridViewGroupingEventArgs__.

* __Grouped__: Occurs when the grid data has been grouped. The type of the passed event arguments is __GridViewGroupedEventArgs__.

* __ChildTableDefinitionAdded__: Occurs when a new child table definition has been added. The type of the passed event arguments is __TableDefinitionCreatedEventArgs__.

Get more information about the grouping events [here]({%slug gridview-events-grouping%}).

### Exporting Events 
          
* __ElementExporting__: Occurs when the grid data is being exported. It is a direct replacement of the __Exporting__ event.

* __ElementExported__: Occurs after the __ElementExporting__ event where you can access the StreamWriter and write additional data to the stream.

* __ElementExportingToDocument__: Occurs when the grid data is being exported to Xlsx or Pdf.

* __ElementExportedToDocument__: Occurs after the ElementExportingToDocument event. Within it you can access the StreamWriter and write additional data to the stream.

Get more information about the exporting events [here]({%slug gridview-export-events%}).

### Row Details Events

* __UnloadingRowDetails__: Occurs when the row details are being unloaded. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.

* __RowDetailsVisibilityChanged__: Occurs when the visibility of the row details has changed. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.

* __LoadingRowDetails__: Occurs when the row details are being loaded. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.

### Column Resizing Events

* __ColumnWidthChanging__: Occurs when the column is being resized. Can be canceled. The type of the passed event arguments is __ColumnWidthChangingEventArgs__.

* __ColumnWidthChanged__: Occurs after the resize is complete. The type of the passed event arguments is __ColumnWidthChangedEventArgs__.

Get more information about the column resizing events [here]({%slug gridview-column-resize-event%})

### Other

* __AutoGeneratingColumn__: Occurs each time new column is auto generated by the grid view control. The type of the passed event arguments is __GridViewAutoGeneratingColumnEventArgs__.

* __RowIsExpandedChanged__: Occurs when a row's expanded state is changed - when its hierarchy child is expanded or collapsed.

	__Example 1: Shows if the row is expanded__

	```C#
		private void ClubsGrid_RowIsExpandedChanged(object sender, Telerik.Windows.Controls.GridView.RowEventArgs e)
		{
		var row = e.Row as GridViewRow;
		MessageBox.Show(row.IsExpanded.ToString());
		}                        
	```

* __RowIsExpandedChanging__: Occurs when a row's expanded state is about to be changed - when its hierarchy child is expanded or collapsed.

	__Example 2: Cancel the expanding__

	```C#
		private void ClubsGrid_RowIsExpandedChanging(object sender, Telerik.Windows.Controls.GridView.RowCancelEventArgs e)
		{
		e.Cancel = true;
		}
	```

>Both __RowIsExpandedChanged__ and __RowIsExpandedChanging__ occur only when there is [Hierarchy]({%slug gridview-hierachy-overview%}) defined and won't be applied if using the __RowDetailsTemplate__ property with another __RadGridView__.

## GridViewColumn

### Sorting

* __SortingStateChanged__: Occurs when the sorting state of the column is changed. The type of the passed event arguments is __RadRoutedPropertyChangedEventArgs<SortingState>__.

## GridViewRow

### Data Events
          
* __BindingValidationError__: Occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __ValidationErrorEventArgs__.

### Selection Events

* __Selected__: Occurs when the grid row is selected. The type of the passed event arguments is __RoutedEventArgs__.

* __Unselected__: Occurs when the grid row is deselected. The type of the passed event arguments is __RoutedEventArgs__.

### Other

* __IsExpandedChanged__: Occurs when __GridViewRow__ changes its __IsExpanded__ state. The type of the passed event arguments is __RoutedEventArgs__.

## GridViewCell

### Data Events

* __BindingValidationError__: Occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __ValidationErrorEventArgs__.

### Edit Events

* __IsEditorVisibleChanged__: Occurs when the cell editors has visibility changed. The type of the passed event arguments is __RoutedPropertyChangedEventArgs<bool>__.

## See Also

* [Validation Events]({%slug gridview-events-validation%})
* [Column Resizing Events]({%slug gridview-column-resize-event%})
* [Export Events]({%slug gridview-export-events%})
* [Grouping Events]({%slug gridview-events-grouping%}#)
* [Sorting Events]({%slug gridview-sorting-basics%}#events)
* [Filtering Events]({%slug gridview-filtering-event-model%})
* [Delete Events]({%slug gridview-events-delete%})
* [Edit Events]({%slug gridview-events-edit%})

