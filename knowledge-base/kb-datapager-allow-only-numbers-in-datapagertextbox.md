---
title: Allow Numbers Only in the PageIndex TextBox of RadDataPager
description: Allow entering only numeric input in the DataPagerTextBox.
page_title: Disable Alphabetical Characters in the Page Index Input of DataPager
type: how-to
slug: kb-allow-only-numbers-in-datapagertextbox
position: 0
tags: pageindex,datapagertextbox,regex
ticketid: 1480886
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.1023</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDataPager for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Allow entering only numeric input in the DataPagerTextBox that shows the current page index.

## Solution

Subscribe to the __Loaded__ event of RadDataPager in order to get the DataPagerTextBox control representing the page index input. Then subscribe to the __PreviewTextInput__ event of DataPagerTextBox. In the handler, you can check the current Text and if there is a non-numeric value, set the __Handled__ property of the event arguments to True. This will cancel the input.


```C#
	private void RadDataPager_Loaded(object sender, RoutedEventArgs e)
	{
		var dataPagerTextBox = this.radDataPager.FindChildByType<DataPagerTextBox>();
		dataPagerTextBox.PreviewTextInput += Tb_PreviewTextInput;
	}

	private void DataPagerTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
	{
		Regex regex = new Regex("[^0-9]+");
		e.Handled = regex.IsMatch(e.Text);
	}
```