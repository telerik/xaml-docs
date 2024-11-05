---
title: Get Visible Items in RadGridView When Full Text Search and Search Filtering is Disabled
description: How to access the search results in the data view of WPF RadGridView when a Full Text Search operation is executed.
type: how-to
page_title: Access Found Rows in DataGrid for WPF When Search as you Type and IsSearchFilteringEnabled is False
slug: kb-gridview-get-search-results-when-filtering-disabled
tags: radgridview, wpf, full text search, visible items, filtering
res_type: kb
ticketid: 1669278
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
<td>2023.2.718</td>
</tr>
</tbody>
</table>

## Description

How to access the search results (row data items) in RadGridView, when search as you type is executed and the `IsSearchFilteringEnabled` setting is False.

## Solution

You can create a new `SearchFilterDescriptor` object and use it in a new [QueryableCollectionView]({%slug consuming-data-queryablecollectionview%}) instance. This will allow you to manually filter the original data collection and get the needed results.

#### __[C#]__
{{region kb-gridview-get-search-results-when-filtering-disabled-0}}
	var searchPanel = this.gridView.FindChildByType<GridViewSearchPanel>();
	if (searchPanel != null)
	{
		var dataMembers = this.gridView.Columns.OfType<GridViewBoundColumnBase>()
			.Select(col => SearchDataMemberDescriptor.FromColumn(col))
			.OfType<SearchDataMemberDescriptor>()
			.ToList();

		var descriptor = new SearchFilterDescriptor(dataMembers, FilterOperatorType.Positive, this.gridView.SearchStateManager);
		descriptor.FilterValue = ((SearchViewModel)searchPanel.DataContext).SearchText;
		var qcv = new QueryableCollectionView((IEnumerable)this.gridView.ItemsSource);
		qcv.FilterDescriptors.Add(descriptor);
		
		var foundItems = qcv.OfType<MyRowItemInfo>();
	}
{{endregion}}


