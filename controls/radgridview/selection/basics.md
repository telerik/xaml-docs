---
title: Basic Selection
page_title: Basic Selection
description: This article describes the various selection modes and selection units provided by the RadGridView control.
slug: gridview-selection-basics
tags: basic,selection
published: True
position: 0
---

# Basic Selection

__RadGridView__ provides you with selection functionality, which allows the user to select one or more rows and/or cells from the data displayed by the control.

>tipThe selection mechanism can be controlled programmatically too. For more information take a look at the [Programmatic Selection]({%slug radgridview-selection-programmatic-selection%}) article.

This article is split in the following sections:

* [Selection Modes](#selection-modes)
* [Selection Units](#selection-units)
* [Selected Items](#selected-items)
* [Disabling Selection](#disabling-selection)
* [Events](#events)

Users can select an item in through the control's UI by clicking somewhere on the desired row.

#### Figure 1: Row Selection

![Row Selection](images/RadGridView_BasicSelection_1.png)

If enabled, users can also select a single cell or multiple cells as shown in **Figure 2**.

#### Figure 2: Cell Selection

![Cell Selection](images/RadGridView_BasicSelection_2.png)

To set the selection unit, use the __SelectionUnit__ enumeration property of the RadGridView. Setting it to __FullRow__ will enable the selection of rows (default), while setting it to __Cell__ will enable the cell selection.

## Selection Modes

The __RadGridView__ control provides three selection modes, which allow you to manipulate the type of selection. This is controlled by the __SelectionMode__ enumeration property which has the following values:

* __Single__: Only one item can be selected at a time. __(default value)__

* __Multiple__: Items are added to the selection when they get clicked and get removed when they get clicked again. 

* __Extended__: Items are added to the selection only by combining the mouse clicks with the __Ctrl__ or __Shift__ keys. 

>tipTo learn more about the multiple selection (the __Multiple__ and __Extended__ selection modes) take a look at the [Multiple Selection]({%slug gridview-multiple-selection%}) topic.

## Selection Units

__RadGridView__ also provides three selection units, which allow you to manipulate what units are selected when you interact with the grid. This is controlled by the __SelectionUnit__ enumeration property which has the following values:

* __FullRow__: This is the default value. Clicking within the cells will select the whole row.    
* __Cell__: Only te clicked cell is selected. Depending on the value of the __SelectionModes__ property you can have more than one selected cell. 
* __Mixed__: You can select both cells and rows. To select a row you should click either on the **row indicator** or outside any cells in the row.

## Selected items

__RadGridView__ provides several properties to get the data behind the selected items - __SelectedItem__, __SelectedItems__ and __SelectedCells__. 

* __SelectedItem__: The business object corresponding to the selected row. If the **SelectionUnit** is **Cell** or no full rows have been selected, it's value is **null**.
* __SelectedItems__: A collection of the business objects corresponding to the selected rows. If the **SelectionUnit** is **Cell** or no full rows have been selected, the collection is empty.
* __SelectedCells__: A collection of __GridViewCellInfo__ objects which represent the corresponding business object(s) and the column(s) of the selected cell(s).

## Disabling Selection

To disable the selection functionality you can set the __CanUserSelect__ property to **False**.

>This will only disable the selection. The user will still be able to change the current item.

>This will disable the selection for only the end-user. It still will be possible to manipulate the selection programmatically.
          
#### __[XAML] Example 1: Set the CanUserSelect property in XAML__

{{region xaml-gridview-selection-basics_0}}
	<telerik:RadGridView x:Name="radGridView"
	                 CanUserSelect="False">
	</telerik:RadGridView>
{{endregion}}

#### __[C#] Example 1: Set the CanUserSelect property in code-behind__

{{region cs-gridview-selection-basics_1}}
	this.radGridView.CanUserSelect = false;
{{endregion}}

#### __[VB.NET] Example 1: Set the CanUserSelect property in code-behind__

{{region vb-gridview-selection-basics_2}}
	Me.radGridView.CanUserSelect = False
{{endregion}}

## Events

There are five events relevant to the selection functionality in the RadGridView - __SelectionChanging, SelectionChanged, CurrentCellChanged, SelectedCellsChanging and SelectedCellChanged__. To learn more about each of them go to the [Selection Events]({%slug gridview-selection-events%}) article.

## See Also

 * [Multiple Selection]({%slug gridview-multiple-selection%})
 * [Programmatic Selection]({%slug radgridview-selection-programmatic-selection%})
 * [Basic Filtering]({%slug gridview-filtering-basic%})
 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})