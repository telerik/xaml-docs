---
title: CurrentItem, SelectedItem & SelectedItems
page_title: CurrentItem, SelectedItem & SelectedItems
description: CurrentItem, SelectedItem & SelectedItems
slug: gridview-selection-selecteditem-currentitem
tags: currentitem,vs,selecteditem
published: True
position: 4
---

# CurrentItem, SelectedItem & SelectedItems

This article explains the usage of the [SelectedItem](#selecteditem), [CurrentItem](#currentitem) & [SelectedItems](#selecteditems) properties.

## SelectedItem

The **SelectedItem** property of RadGridView is used to access the data item of the selected row. It changes its value every time the selected row changes and exposes the object to which the row is bound. As it is a dependency property, you can easily bind it to a value in your viewmodel as demonstrated in **Example 1** & **Example 2**.

#### __[XAML] Example 1: Binding to SelectedItem__

{{region xaml-gridview-selection-selecteditem-currentitem-1}}
	<telerik:RadGridView SelectedItem="{Binding SelectedItem}" />
{{endregion}}

#### __[C#] Example 2: The viewmodel's SelectedItem property__

{{region cs-gridview-selection-selecteditem-currentitem-1}}
	public class MainViewModel : ViewModelBase
	{
		private object selectedItem;

		public object SelectedItem
		{
			get { return this.selectedItem; }
			set
			{
				if (value != this.selectedItem)
				{
					this.selectedItem = value;
					this.OnPropertyChanged("SelectedItem");
				}
			}
		}
	}
{{endregion}}

#### __[VB.NET] Example 2: The viewmodel's SelectedItem property__

{{region vb-gridview-selection-selecteditem-currentitem-1}}
	Public Class MainViewModel
	Inherits ViewModelBase

		Private _selectedItem As Object

		Public Property SelectedItem() As Object
			Get
				Return Me._selectedItem
			End Get
			Set(ByVal value As Object)
				If value IsNot Me._selectedItem Then
					Me._selectedItem = value
					Me.OnPropertyChanged("SelectedItem")
				End If
			End Set
		End Property
	End Class
{{endregion}}

## CurrentItem

The **CurrentItem** property of the RadGridView corresponds to the CurrentItem of the bound **ICollectionView**. It may or may not coincide with the selected row and SelectedItem respectively.

>Prior to **Q2 2010** version, the current item was synchronized with the selected item. As a result, the first row of the GridView was selected initially. To prevent this, you would simply need to set the __IsSynchronizedWithCurrentItem__ property of RadGridView to False. In Q2 2010 version, the IsSynchronizedWithCurrentItem is **null** by default. In this case, SelectedItem is synchronized with the CurrentItem only if **CollectionView** is used as **ItemsSource**.

## SelectedItems

The __SelectedItems__ property is a collection of data items, which holds the currently selected items. With this said, you can add and remove items from this collection in order to select and deselect the corresponding rows. 

You can use the SelectedItems collection only when the [SelectionUnit]({%slug gridview-selection-basics%}#selection-units) is set to **FullRow** (the default value), otherwise it is **null**. It contains more than one item only when the [SelectionMode]({%slug gridview-selection-basics%}#selection-modes) is either **Multiple** or **Extended**.

## See Also

 * [Basic Selection]({%slug gridview-selection-basics%})

 * [Programmatic Selection]({%slug radgridview-selection-programmatic-selection%})

 * [Multiple Selection]({%slug gridview-multiple-selection%})
