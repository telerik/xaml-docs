---
title: Hide the Drop-Down Button of of RadMultiColumnComboBox
description: This article will show you how hide the drop-down button of RadMultiColumnComboBox.
page_title: RadMultiColumnComboBox without drop-down button
type: how-to
slug: kb-radmulticolumncombobox-hide-drop-down-button
position: 0
tags: wpf, 
res_type: kb
ticketid: 1596801
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2024.1.312</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadMultiColumnComboBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to hide the drop-down button of the `RadMultiColumnComboBox` control.

## Solution

Subscribe to the `Loaded` event of RadMultiColumnComboBox and utilize the [ChildrenOfType]({%slug common-visual-tree-helpers%}#childrenoftypeextensions) method to retrive the `RadDropDownButton` element with __x:Name="PART_DropDownButton"__. Then, set its `Visibility` property to `Visibility.Collapsed`.

#### __[C#] Retrieve the RadDropDownButton element on the Loaded event of RadMultiColumnComboBox__
{{region kb-radmulticolumncombobox-hide-drop-down-button-0}}
    private void RadMultiColumnComboBox_Loaded(object sender, RoutedEventArgs e)
    {
    	var mccb = (RadMultiColumnComboBox)sender;
        
    	var dropDownButton = mccb.ChildrenOfType<RadDropDownButton>().FirstOrDefault(x => x.Name == "PART_DropDownButton");
    	if (dropDownButton != null)
    	{
    		dropDownButton.Visibility = Visibility.Collapsed;
    	}
    }
{{endregion}}