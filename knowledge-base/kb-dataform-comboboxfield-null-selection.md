---
title: DataForm DataFormComboBoxField SelectedItem Becomes Null After Commit Button Click
page_title: The SelectedItem property of the DataFormComboBoxField is set to null after the changes are commited and RadDataForm control is unloaded.
description: DataFormComboBoxField Selection Cleared When the Control gets Unloaded from the Visual Tree.
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

The following setup produces null value in the SelectedItem of DataFormComboBoxField on Commit button click.

#### __[XAML]__
{{region kb-dataform-comboboxfield-null-selection-0}}
	<telerik:DataFormComboBoxField DataMemberBinding="{Binding SelectedItem}"
								   ItemsSource="{Binding Items}" />
{{endregion}}

This happens if the Commit button unloads the control from the visual tree. For example, if hosted in dialog window that gets closed on commit.

## Solution

To resolve this, add a `ComboBox` control directly inside of the `Content` of the data field.

#### __[XAML]__
{{region kb-dataform-comboboxfield-null-selection-1}}
	<telerik:DataFormComboBoxField>
		<telerik:RadComboBox SelectedItem="{Binding SelectedItem}" 
							 ItemsSource="{Binding Items}"  />
	</telerik:DataFormComboBoxField>  
{{endregion}}