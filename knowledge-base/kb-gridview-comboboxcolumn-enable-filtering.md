---
title: Enable Filtering in GridViewComboBoxColumn of RadGridView
page_title: Make GridViewComboBoxColumn Editable and Allow Filtering
description: How to turn on filtering of the ComboBox in GridViewComboBoxColumn part of Telerik RadGridView.
type: how-to
slug: kb-gridview-comboboxcolumn-enable-filtering
position: 0
tags: gridview, combobox, column, filterin, datagrid
ticketid: 1576072
res_type: kb
category: knowledge-base
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.2.511</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to enable the editing and filtering of the `RadComboBox` of a `GridViewComboBoxColumn` in `RadGridView`.

## Solution

To enable the editing, set the `IsComboBoxEditable` property of the `GridViewComboBoxColumn` to `true`. To enable also the filtering, set the `IsFilteringEnabled` property of the `RadComboBox` element to `true`.

  
```XAML
	<telerik:GridViewComboBoxColumn DataMemberBinding="{Binding CountryId}"
									IsComboBoxEditable="True"
									SelectedValueMemberPath="Id"
									DisplayMemberPath="Name">
			<telerik:GridViewComboBoxColumn.EditorStyle>
				<Style TargetType="telerik:RadComboBox">
					<Setter Property="IsFilteringEnabled" Value="True" />			
				</Style>
		</telerik:GridViewComboBoxColumn.EditorStyle>
	</telerik:GridViewComboBoxColumn>
```