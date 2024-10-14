---
title: Load items in the ItemsLoading event of VirtualQueryableCollectionView manually When Used in RadGridView
description: Handle the VirtualQueryableCollectionView.ItemsLoading event in RadGridView for WPF to load data on demand, suitable for large data sources.
type: how-to
page_title: How to Use VirtualQueryableCollectionView for On-Demand Data Loading in RadGridView
slug: kb-virtualqueryablecollectionview-gridview-itemsloading-manuall
tags: radgridview, wpf, virtualqueryablecollectionview, itemloading, on-demand data loading
res_type: kb
ticketid: 1666946
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadGridView for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2024.3.821</td>
</tr>
</tbody>
</table>

## Description

How to manually load data in `RadGridView` using the `VirtualQueryableCollectionView` and its `ItemsLoading` event, without working with `IQueryable` collection source. 

This approach is meaningful when you don't want to load all your data in-memory, but fetch it in the `ItemsLoading` event handler.

## Solution

To do this, you can initialize the `VirtualQueryableCollectionView` with an empty collection source which later will be populated with data. 

To adjust the total items count, set the `VirtualItemCount` property of the collection view.

In the `ItemsLoading` event handler, you can manually fetch and add items in the collection view.

#### __[C#] Setting up the VirtualQueryableCollectionView__
{{region kb-virtualqueryablecollectionview-gridview-itemsloading-manuall-0}}
	public MainWindow()
	{
		InitializeComponent();
		
		var vqcv = new VirtualQueryableCollectionView(new ObservableCollection<RowInfo>()) { LoadSize = 10, VirtualItemCount = 1000  };            
		vqcv.ItemsLoading += VirtualQueryableCollectionView_ItemsLoading;	
		this.gridView.ItemsSource = vqcv;
	}

	private void VirtualQueryableCollectionView_ItemsLoading(object? sender, VirtualQueryableCollectionViewItemsLoadingEventArgs e)
	{
		var vqcv = (VirtualQueryableCollectionView)sender;
		var newItems = // fetch the new portion of items here
		foreach (var item in newItems)
		{
			vqcv.Add(item);
		}
	}
{{endregion}}


