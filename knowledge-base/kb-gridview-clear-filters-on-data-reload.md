---
title: Reset GridView Column Filter When RadGridView Data is Reloaded
description: How to remove the column filter when the ItemsSource of RadGridView is reset.
type: how-to
page_title: Clear the Applied GridViewDataColumn Filters on Data Refresh in RadGridView
slug: kb-gridview-clear-filters-on-data-reload
tags: radgridview, wpf, gridview, filter, refresh, data
res_type: kb
ticketid: 1673415
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2024.4.1213</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to remove the column filter when the ItemsSource of RadGridView is reset.

## Solution

By default the column filter is not cleared when the ItemsSource of RadGridView gets updated. To do this, manually clear the ColumnFilterDescriptor of the GridViewDataColumn objects.


```C#
	foreach (var column in gridView.Columns.OfType<GridViewDataColumn>())
	{
		column.ColumnFilterDescriptor.Clear();
	}
```
