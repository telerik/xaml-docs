---
title: Focus the RadWatermakTextBox Element of RadMultiColumnComboBox
description: This article will show you how to focus the RadWatermarkTextBox element of RadMultiColumnComboBox.
page_title: Focus the Input Control of RadMultiColumnComboBox
type: how-to
slug: kb-radmulticolumncombobox-focus-radwatermarktextbox
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

How to focus the `RadWatermakTextBox` element of the `RadMultiColumnComboBox` control.

## Solution

Subscribe to the `Loaded` event of RadMultiColumnComboBox and utilize the [FindChildByType]({%slug common-visual-tree-helpers%}#childrenoftypeextensions) method to retrive the `RadWatermarkTextBox` element. Then, you can call its `Focus` method.

#### __[C#] Retrieve the RadWatermarkTextBox element on the Loaded event of RadMultiColumnComboBox__
{{region kb-radmulticolumncombobox-focus-radwatermarktextbox-0}}
    private void RadMultiColumnComboBox_Loaded(object sender, RoutedEventArgs e)
    {
    	var mccb = (RadMultiColumnComboBox)sender;

    	var textBox = mccb.FindChildByType<RadWatermarkTextBox>();
    	if (textBox != null)
    	{
    		textBox.Focus();
    	}
    }
{{endregion}}

>tip You can cache the RadWatermarkTextBox instance in a field and invoke the Focus method when required.