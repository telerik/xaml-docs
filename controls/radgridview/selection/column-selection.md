---
title: Column Selection
page_title: Column Selection
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn about the three approaches to adding entire columns to the grid's selection.
slug: gridview-column-selection
tags: column,selection
published: True
position: 4
---

# {{ site.framework_name }} RadGridView Column Selection

As of **R3 2016** entire columns can be added to RadGridView's selection. This can be done in any of the following ways:

* [Through the UI](#select-columns-through-the-ui)

* [Via a column's IsSelected property](#select-columns-via-a-columns-isselected-property)

* [Using the SelectCellRegion method](#using-the-selectcellregion-method)

>importantColumn selection is only available when **SelectionMode** is either **Multiple** or **Extended** and **SelectionUnit** is either **Cell** or **Mixed**.

## Select Columns Through the UI

RadGridView's new **CanUserSelectColumns** property determines whether users can add a whole column to the current selection. The default value is **False**, but when set to **True**, a new [RadDropDownButton]({%slug radbuttons-getting-started%}#raddropdownbutton) appears in RadGridView's  top right corner. When clicked, a **ListBox** appears, whose **ItemsSource** is bound to RadGridView's **Columns** collection. The user can then check and uncheck columns in order to add and remove them from the current selection. 

>Column selection behaves differently depending on the **SelectionMode** - when dealing with **Extended** selection, if you want to select multiple columns, you need to hold down the **Ctrl** key.

#### __[C#] Example 1: Setting RadGridView's CanUserSelectColumns property__  
{{region cs-gridview-column-selection_1}}
	this.radGridView.CanUserSelectColumns = true;
{{endregion}}

#### __[VB.NET] Example 1: Setting RadGridView's CanUserSelectColumns property__  
{{region vb-gridview-column-selection_1}}
	Me.radGridView.CanUserSelectColumns = True
{{endregion}}

#### __Figure 1: Selecting columns through the UI__  
![Telerik {{ site.framework_name }} DataGrid column selection](images/gridview-columnselection.png)

The __hide column selection button__, set the RadGridView's **ColumnsSelectionButtonVisibility** property.

#### __[XAML] Example 2: Setting RadGridView's ColumnsSelectionButtonVisibility property in XAML__  
{{region xaml-gridview-column-selection_2}}
	<telerik:RadGridView CanUserSelectColumns="True" ColumnsSelectionButtonVisibility="Collapsed" />
{{endregion}}

#### __[C#] Example 3: Setting RadGridView's ColumnsSelectionButtonVisibility property in code__  
{{region cs-gridview-column-selection_3}}
	this.radGridView.ColumnsSelectionButtonVisibility = Visibility.Collapsed;
{{endregion}}

#### __[VB.NET] Example 3: Setting RadGridView's ColumnsSelectionButtonVisibility property in code__  
{{region vb-gridview-column-selection_3}}
	Me.radGridView.ColumnsSelectionButtonVisibility = Visibility.Collapsed
{{endregion}}

## Select Columns Via a Column's IsSelected Property

Columns can also be selected programmatically by setting their **IsSelected** property.

>Bear in mind that this will only work if **CanUserSelectColumns** is set to **True**. 

#### __[C#] Example 4: Setting a column's IsSelected property__  
{{region cs-gridview-column-selection_4}}
	this.radGridView.Columns["Name"].IsSelected = true;
{{endregion}}

#### __[VB.NET] Example 4: Setting a column's IsSelected property__  
{{region vb-gridview-column-selection_4}}
	Me.radGridView.Columns("Name").IsSelected = True
{{endregion}}

## Using the SelectCellRegion Method

Another way to programmatically select columns is by using the [SelectCellRegion method]({%slug radgridview-selection-programmatic-selection%}#selecting-cell-regions).

#### __[C#] Example 5: Selecting a column with the SelectCellRegion method__  
{{region cs-gridview-column-selection_5}}
	this.radGridView.SelectCellRegion(new CellRegion(this.radGridView.Columns["Name"].DisplayIndex, 0, 1, this.radGridView.Items.Count));
{{endregion}}

#### __[VB.NET] Example 5: Selecting a column with the SelectCellRegion method__  
{{region vb-gridview-column-selection_5}}
	Me.radGridView.SelectCellRegion(New CellRegion(Me.radGridView.Columns("Name").DisplayIndex, 0, 1, Me.radGridView.Items.Count))
{{endregion}}

## See Also  
 * [Basic Selection]({%slug gridview-selection-basics%})
 * [Programmatic Selection]({%slug radgridview-selection-programmatic-selection%})
 * [Basic Filtering]({%slug gridview-filtering-basic%})
 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})
 * [Multiple-column Sorting]({%slug gridview-multiple-column-sorting%})
