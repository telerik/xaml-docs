---
title: Programmatic Selection
page_title: Programmatic Selection
description: Programmatic Selection
slug: radgridview-selection-programmatic-selection
tags: programmatic,selection
published: True
position: 3
---

# Programmatic Selection

Besides the built-in selection functionality, you are able to use a programmatic approach to select the data in the __RadGridView__. The __RadGridView__ exposes several properties which allow you to manipulate the selected data. You are able to:

* [Set the selected item](#selecteditem)

* [Set the current item](#currentitem)

* [Add or remove items to/from the selection](#selecteditems)

* [Set the selected cell](#selectedcells)

* [Select all of the items](#selecting-all-items)

* [Deselect all of the items](#deselecting-all-items)

>tipYou can download a runnable project showing how to bind the __SelectedItems__ collection of the RadGridView to a property in your ViewModel [here](https://github.com/telerik/xaml-sdk), the example is listed as __GridView/BindingSelectedItemsFromViewModel__.
        
## SelectedItem

To access the data item of the selected row use the __SelectedItem__ property. It changes its value every time when the row selection changes and exposes the object to which the row is bound. You can use it when the __SelectionUnit__ is set to __FullRow__ (default), otherwise it is null.

#### __C#__

{{region radgridview-selection-programmatic-selection_0}}

	Employee e = this.radGridView.SelectedItem as Employee;
{{endregion}}

#### __VB.NET__

{{region radgridview-selection-programmatic-selection_1}}

	Dim e As Employee = TryCast(Me.radGridView.SelectedItem, Employee)
{{endregion}}

You can also set the __SelectedItem__ to an item in the __RadGridView's__ data source and it will get automatically selected. For example, if you want on a certain action the first item in your __RadGridView__ to be selected, you can do the following.

#### __C#__

{{region radgridview-selection-programmatic-selection_2}}

	this.radGridView.SelectedItem = ( ( ObservableCollection<Employee> )this.radGridView.ItemsSource ).First();
{{endregion}}

#### __VB.NET__

{{region radgridview-selection-programmatic-selection_3}}

	Me.radGridView.SelectedItem = (DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee))).First()
{{endregion}}

Just make sure that the data is already loaded in the gridview (e.g. you can use the above code in the __DataLoaded__ event of the RadGridView)

>tipYou can also make another control like __ListBox__ or __ComboBox__ to pass the __SelectedItem__ to the __RadGridView__. 

## CurrentItem

The __CurrentItem__ property of the RadGridView corresponds to the CurrentItem of the bound ICollectionView. It may or may not coincide with the selected row. However, in most of the cases these two rows are one and the same.

You can also set the __CurrentItem__ to an item in the __RadGridView's__ data source and it will get automatically selected. For example, if you want on a certain action the first item in your __RadGridView__ to be current you can do the following.

#### __C#__

{{region radgridview-selection-programmatic-selection_4}}

	this.radGridView.CurrentItem = ( ( ObservableCollection<Employee> )this.radGridView.ItemsSource ).First();
{{endregion}}

#### __VB.NET__

{{region radgridview-selection-programmatic-selection_5}}

	Me.radGridView.CurrentItem = (DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee))).First()
{{endregion}}

>tipYou can also make another control like __ListBox__ or __ComboBox__ to pass the __CurrentItem__ to the __RadGridView__.

>Prior to Q2 2010 version, the current item was synchronized with the selected item. As a result, the __first row__ of the GridView was __selected initially__. To prevent this, you would simply need to set the __IsSynchronizedWithCurrentItem__ property of RadGridView to __False__. In __Q2 2010__ version, the __IsSynchronizedWithCurrentItem__ is null by default - SelectedItem is synchronized with the CurrentItem only if CollectionView is used as ItemsSource

## SelectedItems

The __SelectedItems__ is a collection of data items, which holds the currently selected items. As it is a collection you can get, add and remove items from it. In this way you can easily manipulate the selection, e.g. selecting and deselecting items on certain criteria. You can use it when the __SelectionUnit__ is set to __FullRow__ (default), otherwise it is null. It will contain more than one item when the __SelectionMode__ is either __Multiple__ or __Extended__. 

>If the selection mode is set to __Single__ it will always hold at most one item.

#### __C#__

{{region radgridview-selection-programmatic-selection_6}}

	public void DeselectItem( object itemToDeselect )
	{
	    this.radGridView.SelectedItems.Remove( itemToDeselect );
	}
	public void SelectItem( object itemToSelect )
	{
	    this.radGridView.SelectedItems.Add( itemToSelect );
	}
{{endregion}}

#### __VB.NET__

{{region radgridview-selection-programmatic-selection_7}}

	Public Sub DeselectItem(itemToDeselect As Object)
	 Me.radGridView.SelectedItems.Remove(itemToDeselect)
	End Sub
	Public Sub SelectItem(itemToSelect As Object)
	 Me.radGridView.SelectedItems.Add(itemToSelect)
	End Sub
{{endregion}}

>If you add more than one item in the __SelectedItems__ while the selection mode is single, the selection will disappear. Consider working with the collection only when you are using __Multiple__ or __Extended__ selection mode.

>You can add or remove items to the __SelectedItems__ collection, but cannot change its instance because it is read only.

## SelectedCells

Represents a collection of __GridViewCellInfo__ objects which represent the business object and the column of the selected cell/cells. You can work with it when the __SelectionUnit__ is set to __Cell__, otherwise it will be null.

#### __C#__

{{region radgridview-selection-programmatic-selection_8}}

	GridViewCellInfo cellToSelect = new GridViewCellInfo(item, column, this.radGridView);
	public void SelectCell(GridViewCellInfo cellToSelect  )
	{
	    this.radGridView.SelectedCells.Add( cellToSelect );
	}
	public void DeselectCell(GridViewCellInfo cellToSelect )
	{
	    this.radGridView.SelectedCells.Remove( cellToSelect  );
	}
{{endregion}}

#### __VB.NET__

{{region radgridview-selection-programmatic-selection_9}}

	    Private cellToSelect As New GridViewCellInfo(item, column, Me.radGridView)
	    Public Sub SelectCell(cellToSelect As GridViewCellInfo)
	        Me.radGridView.SelectedCells.Add(cellToSelect)
	    End Sub
	    Public Sub DeselectCell(cellToSelect As GridViewCellInfo)
	        Me.radGridView.SelectedCells.Remove(cellToSelect)
	    End Sub
{{endregion}}

## Selecting All Items

The __RadGridView__ control exposes a __SelectAll()__ method, which allows you to select all items at once.

#### __C#__

{{region radgridview-selection-programmatic-selection_10}}

	this.radGridView.SelectAll();
{{endregion}}

#### __VB.NET__

{{region radgridview-selection-programmatic-selection_11}}

	Me.radGridView.SelectAll()
{{endregion}}

## Deselecting All Items

There are two ways to remove the selection. The first one is to set the __SelectedItem__ property to null.

#### __C#__

{{region radgridview-selection-programmatic-selection_12}}

	this.radGridView.SelectedItem = null;
{{endregion}}

#### __VB.NET__

{{region radgridview-selection-programmatic-selection_13}}

	Me.radGridView.SelectedItem = Nothing
{{endregion}}

The second one is to call the __Clear()__ method of the __SelectedItems__ collection.

#### __C#__

{{region radgridview-selection-programmatic-selection_14}}

	this.radGridView.SelectedItems.Clear();
{{endregion}}

#### __VB.NET__

{{region radgridview-selection-programmatic-selection_15}}

	Me.radGridView.SelectedItems.Clear()
{{endregion}}

# See Also

 * [Basic Selection]({%slug gridview-selection-basics%})

 * [Multiple Selection]({%slug gridview-multiple-selection%})

 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})

 * [Programmatic Sorting]({%slug gridview-sorting-programmatic%})
