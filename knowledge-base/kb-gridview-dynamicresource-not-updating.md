---
title: DynamicResource not Updating When Used With Properties of GridViewColumn
description: DynamicResource setting on properties of the Telerik GridViewColumn not updated when the associated resource is changed.
type: troubleshooting
page_title: DynamicResource Bindings not Updating Header of GridViewDataColumn
slug: kb-gridview-dynamicresource-not-updating
tags: radgridview, wpf, dynamicresource, binding, localization
res_type: kb
ticketid: 1683506
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
<td>2024.3.924</td>
</tr>
</tbody>
</table>

## Description

DynamicResource setting on properties (like Header) of the Telerik GridViewColumn is not updated when the associated resource is changed.

```xaml
	<telerik:GridViewDataColumn Header="{DynamicResource Key1}">
```

## Solution

To resolve this use a TextBlock element as the Header of RadGridView and use the DynamicResource keyword with its Text property.

```xaml
	<telerik:GridViewDataColumn>
		<telerik:GridViewDataColumn.Header>
			<TextBlock Text="{DynamicResource Key1}" />
		</telerik:GridViewDataColumn.Header>
	</telerik:GridViewDataColumn>
```
