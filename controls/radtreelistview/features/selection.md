---
title: Selection
page_title: Selection
description: Selection
slug: radtreelistview-features-selection
tags: selection
published: True
position: 9
---

# Selection



The __RadTreeListView__ provides you with a selection functionality, which allows the user to select one or more items from the data displayed by the control.

## Selection Modes

The __RadTreeListView__ provides three selection modes, which allow you to manipulate the type of selection. This is controlled by the __SelectionMode__ enumeration property which has the following entries:

* __Single__ - only one item can be selected at a time. __(default value)__

* __Multiple__ - items are added to the selection when they get clicked and get removed when they get clicked again. 

* __Extended__ - items are added to the selection only by combining the mouse clicks with the __Ctrl__ or __Shift__ key. 

## Selection Units

The __RadTreeListView__ provides two selection units, which allow you to manipulate what units are selected when you interact with the grid. This is controlled by the __SelectionUnit__ enumeration property which has the following entries:

* __FullRow__ - this is the default value. Clicking within the cells will select the row.

* __Cell__ - the clicked cell is selected only. Depending on the value of the __SelectionModes__ property, you can have more than one selected cell. 

## Selected items

__RadTreeListView__ provides several properties to get the data behind the selected items - __SelectedItem__, __SelectedItems__ and __SelectedCells__. 

* __SelectedItem__ - the business object that sits behind the selected row. You can use it when the __SelectionUnit__ is set to __FullRow__ (default), otherwise it is ___null___. 

* __SelectedItems__ - a collection of the business objects that sits behind the selected rows. You can use it when the __SelectionUnit__ is set to __FullRow__ (default), otherwise it is null. It will contain more than one item when the __SelectionMode__ is either __Multiple__ or __Extended__. 

* __SelectedCells__ - a collection of __GridViewCellInfo__ objects which represent the business object and the column of the selected cell/cells. You can use it when the __SelectionUnit__ is set to __Cell__, otherwise it is ___null___.



As the __RadTreeListView__ directly inherits the __RadGridView__ it uses its selection mechanism. The __RadGridView__ allows you to implement programmatic selection, multiple selection and more. To learn more read the [respective topics]({%slug gridview-selection-basics%}) in the __RadGridView's__ documentation.

## See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})

 * [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%})

 * [Sorting]({%slug radtreelistview-features-sorting%})

 * [Filtering]({%slug radtreelistview-features-filtering%})
