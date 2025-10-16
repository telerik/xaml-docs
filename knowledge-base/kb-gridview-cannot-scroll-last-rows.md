---
title: Last Row Disappears in RadGridView
description: The vertical scrolling cannot reach the last row when RowHeight smaller than pinned rows.
type: troubleshooting
page_title: RadGridView Cannot Scroll to the Last Rows 
slug: kb-gridview-cannot-scroll-last-rows
position: 0
tags: pinned, rows, last, row, cut 
ticketid: 1511715
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.617</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

RadGridView cannot scroll to the last one or few rows when RowHeight is set and few rows are pinned.

This happens when the RowHeight property value is smaller than the MinHeight of the pin button in the pinned rows (which is around 20px).

## Solution

To resolve this, ensure that the MinHeight of the pin button in the rows is 0 or a value smaller or equal than the RowHeight. To set the MinHeight, you can define an implicit style targeting GridViewPinButton and set its MinHeight property.


```XAML
	<telerik:RadGridView GroupRenderMode="Flat"
						 PinnedRowsPosition="Top"
						 RowHeight="17">
		<telerik:RadGridView.Resources>
			<Style TargetType="telerik:GridViewPinButton" BasedOn="{StaticResource GridViewPinButtonStyle}">
				<Setter Property="MinHeight" Value="0" />
			</Style>
		</telerik:RadGridView.Resources>
	</telerik:RadGridView>
```