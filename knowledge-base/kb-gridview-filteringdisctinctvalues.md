---
title: RadGridView Column Filtering Enum Values
description: "How to filter Enum values in the distinct value filter in GridViewDataColumn."
type: how-to
page_title: Filtering Distinct Values in RadGridView Column For WPF
slug: kb-gridview-filtering-enum-disctinct-values
position: 0
tags: gridView,giltering,distinct,values
ticketid: 1615231
res_type: kb
---

## Environment

<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2023.2.718</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>RadGridView for WPF</td>
        </tr>
    </tbody>
</table>


## Description

How to filter Enum values in __GridView__ column and display all of them in the distinct value filter.

## Solution

You can use the [DistinctValuesLoading]({%slug gridview-filtering-customizing-distinct-values%}) event of `RadGridView`.


```C#
	private void RadGridView_DistinctValuesLoading(object sender, 	Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
	{
		var dataColumn = e.Column as GridViewBoundColumnBase;
		if (dataColumn != null && dataColumn.DataType.IsEnum)
		{
			e.ItemsSource = Enum.GetValues(dataColumn.DataType);
		}
	}
```

