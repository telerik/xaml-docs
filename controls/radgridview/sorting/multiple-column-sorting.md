---
title: Multiple-Column Sorting
page_title: Multiple-Column Sorting
description: Learn how you can sort data in Telerik's WPF DataGrid ascending by the Est. column and then sort again by the Stadium column without removing previous sorting.
slug: gridview-multiple-column-sorting
tags: multiple-column,sorting
published: True
position: 3
---

# Multiple-Column Sorting

The `RadGridView` control allows you to sort multiple columns. To do this at run-time, hold the __Shift__ key when clicking on the column headers. To change this, refer to the [Specify Multiple-Column Sorting Modifier Keys]({%slug %}#specify-multiple-column-sorting-modifier-keys) section of this article.

On the snapshot below, the data in RadGridView is sorted ascending by the Est. column and then sorted again by the Stadium column, without removing the previous sorting.
       
![Telerik WPF DataGrid MultiColumnSorting 1](images/RadGridView_MultiColumnSorting_1.png)

To learn how to implement programmatic sorting in your RadGridView, read on this [article]({%slug gridview-sorting-programmatic%}).

## Column Sort Sequence Indicator

The RadGridView control allows you to display sequence indicators for the sorting operations. To enable this, set the `ShowColumnSortIndexes` property of RadGridView to __True__. 

You can check how the column headers will look like after the user has sorted on multiple columns.

![Telerik WPF DataGrid MultiColumnSorting 2](images/RadGridView_MultiColumnSorting_2.png)

## Specify Multiple-Column Sorting Modifier Keys

RadGridView provides the option to specify the modifier keys when performing multi-column sorting. This is done via the `MultipleColumnSortModifiers` property of RadGridView and it is of the type of [ModifierKeys](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.modifierkeys?view=windowsdesktop-8.0). The default value of the MultipleColumnSortModifiers property is `ModifierKeys.Shift`.

#### __[XAML] Changing the modifier key for the multi-column sorting__
{{region gridview-multiple-column-sorting-0}}
    <telerik:RadGridView ItemsSource="{Binding Clubs}" MultipleColumnSortModifiers="Ctrl"/>
{{endregion}}

## See Also
 * [RadGridView Overview]({%slug gridview-overview2%})
 * [Basic Sorting]({%slug gridview-sorting-basics%})
 * [Programmatic Sorting]({%slug gridview-sorting-programmatic%})
 * [Custom Sorting]({%slug gridview-sorting-custom%})