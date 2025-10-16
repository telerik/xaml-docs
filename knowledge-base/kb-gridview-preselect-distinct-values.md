---
title: Pre-Check Distinct Values CheckBoxes in FilteringControl of RadGridView
description: How to manually check options in the distinct values list of the FilteringControl.
type: how-to
page_title: Preselect Distinct Values in Column Filtering Popup of RadGridView
slug: kb-gridview-preselect-distinct-values
position: 0
tags: preselect,distinct,values
ticketid: 1538106
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td></td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to manually check options in the distinct values list of the FilteringControl of a column.

## Solution

The following example shows how to pre-select options from the list of the distinct values of a column on loading of RadGridView. One way to do this is to subscribe to the Loaded event of RadGridView and get the ColumnFilterDescriptor of the column where the distinct values should be checked. Then use the `AddDistinctValue` method of the DistinctFilter as shown in the [Programmatic Filtering]({%slug gridview-filtering-programmatic%}#filtering-single-column) article.


```C#
	private void RadGridView_Loaded(object sender, RoutedEventArgs e)
	{
		GridViewColumn column = this.gridView.Columns["City"];
		IColumnFilterDescriptor filterDescriptor = column.ColumnFilterDescriptor;
		filterDescriptor.DistinctFilter.AddDistinctValue("Sofia");
		filterDescriptor.DistinctFilter.AddDistinctValue("London");
		filterDescriptor.DistinctFilter.AddDistinctValue("Seattle");
	}
```
