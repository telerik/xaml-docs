---
title: DataForm DataFormComboBoxField SelectedItem Becomes Null After Commit Button Click
page_title: DataFormComboBoxField Selection Cleared When the Control Gets Unloaded from the Visual Tree
description: The SelectedItem property of the DataFormComboBoxField is set to null after the changes are committed and RadDataForm control is unloaded.
type: troubleshooting
slug: kb-dataform-comboboxfield-null-selection
position: 0
tags: kb
ticketid: 1549500
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
			<td>RadDataForm for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The following setup produces a `null` value in the `SelectedItem` of the RadDataFormComboBoxField on Commit button click.


```XAML
	<telerik:DataFormComboBoxField DataMemberBinding="{Binding SelectedItem}"
								   ItemsSource="{Binding Items}" />
```

This happens if the Commit button unloads the control from the visual tree. For example, if hosted in dialog window that gets closed on commit.

## Solution

To resolve this, add a `RadComboBox` control directly inside of the `Content` of the data field.


```XAML
	<telerik:DataFormComboBoxField>
		<telerik:RadComboBox SelectedItem="{Binding SelectedItem}" 
							 ItemsSource="{Binding Items}"  />
	</telerik:DataFormComboBoxField>  
```
