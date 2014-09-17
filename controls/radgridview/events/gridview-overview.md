---
title: Overview
page_title: Overview
description: Overview
slug: gridview-events-overview
tags: overview
published: True
position: 0
---

# Overview



This topic covers the specific events exposed by the __RadGridView__ control and its sub elements __GridViewColumn__, __GridViewRow__ and __GridViewCell.__The events are first grouped by control and then by their general purpose.

## RadGridView



* Data Events
            

* __DataLoading__ - occurs before the grid view data is loaded. The type of the passed event arguments is __GridViewDataLoadingEventArgs__.
              

* __DataLoaded__ - occurs when the grid view data is loaded. The type of the passed event arguments is
                {% if site.site_name == 'WPF' %}__System.EventArgs__{% endif %}{% if site.site_name == 'Silverlight' %}__GridViewDataLoadingEventArgs__.
                {% endif %}

* __BindingValidationError__ - occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __EventArgs__.
              

* __AddingNewDataItem__ - occurs when a new data item is about to be added. The type of the passed event arguments is __GridViewAddingNewEventArgs__.
              

* 
            Selection Events
            

* __CurrentCellChanged__ - occurs when the selected grid cell has changed. The type of the passed event arguments is __GridViewCurrentCellChangedEventArgs__.
              

* __SelectionChanged__ - occurs when the selected grid row has changed. The type of the passed event arguments is __SelectionChangeEventArgs__.
              

* __RowActivated__ - occurs when a row is activated - when user double click on it or press enter. The type of the passed event arguments is __RowEventArgs__

* 
              Loading Events ([Read more]({%slug gridview-rowloaded-event%}))
              

* __RowLoaded__ - occurs anytime the row appears within the view port. The type of the passed event arguments is __RowLoadedEventArgs__.
                

* __RowUnloaded__ - occurs anytime the row disappears within the view port. The type of the passed event arguments is __RowUnloadedEventArgs__.
                

* Edit Events ([Read more]({%slug gridview-events-edit%}))
          

* __RowEditEnded__ - occurs when row validation passed successfully and new data is committed to the __RadGridView__.__ItemsSource__. The type of the passed event arguments is __GridViewRowEditEndedEventArgs__.
            

* __CellEditEnded__ - occurs when cell validation is passed successfully and new data is committed to the __RadGridView__.__ItemsSource__. The type of the passed event arguments is __GridViewCellEditEndedEventArgs__.
            

* __BeginningEdit__ - occurs when the cell is about to enter into EditMode. The type of the passed event arguments is __GridViewBeginningEditRoutedEventArgs__.
            

* __PreparingCellForEdit__ - occurs after the BeginningEdit event. It allows you to obtain a reference to the editing element and change its properties.
            

* __PreparedCellForEdit__ - occurs after the PreparingCellForEdit event.
            

* Delete Events ([Read more]({%slug gridview-events-delete%}))
          

* Validation Events ([Read more]({%slug gridview-events-validation%}))
        

* Filtering Events ([Read more](58E28F2D-0079-457E-AD57-EB837D43C2BE#Events))
        

* Sorting Events ([Read more](FFEF9E84-B518-4DF1-819B-247298BAA176#Events))
        

* __Sorting__ - occurs when the grid data is about to be sorted. The type of the passed event arguments is __GridViewSortingEventArgs__.
          

* __Sorted__ - occurs when the grid data has been sorted. The type of the passed event arguments is __GridViewSortedEventArgs__.
          

* Grouping ([Read more](435984A5-EE5A-485B-9803-8A024F49EF11#Events))
           

* __Grouping__ - occurs when the grid data is about to be grouped. The type of the passed event arguments is __GridViewGroupingEventArgs__.

* __Grouped__ - occurs when the grid data has been grouped. The type of the passed event arguments is __GridViewGroupedEventArgs__.

* __ChildTableDefinitionAdded__ - occurs when a new child table definition has been added. The type of the passed event arguments is __TableDefinitionCreatedEventArgs__.

* Exporting Events ([Read more]({%slug gridview-export-events%}))
        

* __Exporting__ - occurs when the grid data is being exported. The type of the passed event arguments is __GridViewExportEventArgs__. The event will be obsoleted in Q2 2010.
          

* __ElementExporting__ - occurs when the grid data is being exported. It is a direct replacement of the __Exporting__ event.
          

* __ElementExported__ - occurs after the __ElementExporting__ event where you can access the StreamWriter and write additional data to the stream.
          

* Row Details Events
        

* __UnloadingRowDetails__ - Occurs when the row details are being unloaded. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.
          

* __RowDetailsVisibilityChanged__ - occurs when the visibility of the row details has changed. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.
          

* __LoadingRowDetails__ - occurs when the row details are being loaded. The type of the passed event arguments is __GridViewRowDetailsEventArgs__.
          

* Column Resizing Events ([Read more]({%slug gridview-column-resize-event%}))
        

* __ColumnWidthChanging__ - occurs when the column is being resized. Can be canceled. The type of the passed event arguments is __ColumnWidthChangingEventArgs__

* __ColumnWidthChanged__ - occurs after the resize is complete. The type of the passed event arguments is __ColumnWidthChangedEventArgs__

* Other
      

* __AutoGeneratingColumn__ - occurs each time new column is auto generated by the grid view control. The type of the passed event arguments is __GridViewAutoGeneratingColumnEventArgs__.
        

## GridViewColumn



* Sorting
          

* __SortingStateChanged__ - occurs when the sorting state of the column is changed. The type of the passed event arguments is __RadRoutedPropertyChangedEventArgs<SortingState>__.
            

## GridViewRow



* Data Events
          

* __BindingValidationError__ - occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __ValidationErrorEventArgs__.
            

* Selection Events
          

* __Selected__ - occurs when the grid row is selected. The type of the passed event arguments is __RoutedEventArgs__.
            

* __Unselected__ - occurs when the grid row is deselected. The type of the passed event arguments is __RoutedEventArgs__.
            

* Other
          

* __Loaded / Unloaded__

* __IsExpandedChanged__ - occurs when __GridViewRow__ changes its __IsExpanded__ state. The type of the passed event arguments is __RoutedEventArgs__.
            

## GridViewCell



* Data Events
          

* __BindingValidationError__ - occurs when a data validation error is reported by a binding source. The type of the passed event arguments is __ValidationErrorEventArgs__.
            

* Edit Events
        

* __IsEditorVisibleChanged__ - occurs when the cell editors has visibility changed. The type of the passed event arguments is __RoutedPropertyChangedEventArgs<bool>__.
          

# See Also

 * [Validation]({%slug gridview-events-validation%})
