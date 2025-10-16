---
title: Select Text in a ReadOnly RadGridView Cell
description: How to select the cell text when the GridView column is in readonly mode.
type: how-to
page_title: Select text using the mouse when a DataGrid cell is read-only.
slug: kb-gridview-text-selection-on-readonly-cell
position: 0
tags: gridview,datagrid,readonly,text,cell
ticketid: 1569968
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2.621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to select the cell text when the GridView column is in readonly mode.

## Solution

Define a custom `CellTemplate` containing a read-only `TextBox` element.


```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" IsReadOnly="True">
		<telerik:GridViewDataColumn.CellTemplate>
			<DataTemplate>
				<TextBox IsReadOnly="True" Text="{Binding Name}" BorderThickness="0" Background="Transparent"/>
			</DataTemplate>
		</telerik:GridViewDataColumn.CellTemplate>
	</telerik:GridViewDataColumn>
```