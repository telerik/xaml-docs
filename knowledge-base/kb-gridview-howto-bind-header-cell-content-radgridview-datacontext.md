---
title: How to Bind the Content in the Header Cell to RadGridView's DataContext
description: Binding header cell's content to properties in the viewmodel.
page_title: Bind Header Cell Content to Properties in the ViewModel
type: how-to
slug: kb-gridview-howto-bind-header-cell-content-radgridview-datacontext
position: 0
tags: gridview, binding, header, cell, content, datacontext
ticketid: 1168725
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.3.917</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

How to bind the header cells' content to properties in RadGridView's DataContext.

## Solution

As the DataContext of the **GridViewHeaderCell** is different than the one of its parent RadGridView control, in order to bind properties of its content to such in the viewmodel, you need to use a **RelativeSource** binding.


```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}">
		<telerik:GridViewDataColumn.Header>
			<TextBlock Text="{Binding DataContext.NamePropertyString, RelativeSource={RelativeSource AncestorType=telerik:RadGridView}}" />
		</telerik:GridViewDataColumn.Header>
	</telerik:GridViewDataColumn>
```
