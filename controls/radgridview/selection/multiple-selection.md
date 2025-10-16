---
title: Multiple Selection
page_title: Multiple Selection
description: Get started with Telerik's {{ site.framework_name }} DataGrid allowing users to select more than one item from the displayed data.
slug: gridview-multiple-selection
tags: multiple,selection
published: True
position: 1
---

# Multiple Selection

__RadGridView__ allows users to select more than one item from the displayed data. By default only a single row/cell can be selected at a time but you can set the __SelectionMode__ property to either __Multiple__ or __Extended__ to enable multiple selection.

__Example 1: Set SelectionMode__

```XAML
	<telerik:RadGridView x:Name="radGridView"
	                         SelectionMode="Extended">
	    <!--...-->
	</telerik:RadGridView>
```

__Example 1: Set SelectionMode__

```C#
	this.radGridView.SelectionMode = System.Windows.Controls.SelectionMode.Extended;
```
```VB.NET
	Me.radGridView.SelectionMode = System.Windows.Controls.SelectionMode.Extended
```

The __Multiple__ value of the __SelectionMode__ enumeration allows the user to add an item to the selection just by clicking on it. It will be removed when it gets clicked again.

The __Extended__ selection on the other hand, allows users to select multiple records using the common key modifiers - __Shift__ and __Ctrl__. Holding __Shift__ while selecting a row will select the range of rows between the newly-selected row and the previously-selected one. By holding __Ctrl__ upon selection, the selected row will be added to the current selection or removed from it if it has already been selected. The same rules apply to the cells if the [SelectionUnit]({%slug gridview-selection-basics%}) property is set to __Cell__. If no modifiers are pressed when selecting a unit only that unit will be selected.

>tipPressing __Ctrl+A__ will select all items.

![Telerik {{ site.framework_name }} DataGrid cell selection](images/RadGridView_MultipleSelection_1.png)![{{ site.framework_name }} RadGridView Multiple Selection](images/gridview_cell_selection.png)

You can access all selected rows (or data items) through the __SelectedItems__ collection and all the selected cells through the __SelectedCells__ collection. The following example demonstrates how to bind a __ListBox__ to the selected items of a grid:

__Example 2: Use the SelectedItems property__

```XAML
	<ListBox x:Name="listBoxSelectedItems"
	 DisplayMemberPath="Name"
	 ItemsSource="{Binding SelectedItems, ElementName=radGridView}" />
```

__Example 2: Use the SelectedItems property__

```C#
	listBoxSelectedItems.ItemsSource = this.radGridView.SelectedItems;
```
```VB.NET
	listBoxSelectedItems.ItemsSource = Me.radGridView.SelectedItems
```

>When multiple items are selected the __SelectedItem__ property has the value of the first selected one.

## See Also

 * [Basic Selection]({%slug gridview-selection-basics%})
 * [Programmatic Selection]({%slug radgridview-selection-programmatic-selection%})
 * [Basic Filtering]({%slug gridview-filtering-basic%})
 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})
 * [Multiple-column Sorting]({%slug gridview-multiple-column-sorting%})
