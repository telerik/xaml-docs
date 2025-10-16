---
title: RadGridView Column Header doesn't auto change width
description: Telerik DataGrid column header doesn't change size when text gets smaller.
type: troubleshooting
page_title: DataGrid column header doesn't shrink to fit the new Header size at runtime.
slug: kb-gridview-column-header-autofit
position: 0
tags: autofit,width,gridviewlength
ticketid: 1389043
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1 220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

When I change RadGridView column header from a longer to a shorter string, the column header width doesn't change its size to autofit.

## Solution

To make the header fit its content, reset the Width of the column when the Header changes.


```C#
	public void MethodCalledWhenTheHeaderPropertyChanges()
	{
		var column = this.radGridView.Columns[0];
		column.Width = new GridViewLength(1, GridViewLengthUnitType.Pixel);
		column.Width = new GridViewLength(1, GridViewLengthUnitType.Auto);
	}
```

