---
title: Pasting Value With Spaces in Front and Back Does Not Work
description: Pasting a copied numeric value that contains untrimmed text does not work.
page_title: Pasting Number String Containing Trailing or Leading White Spaces Not Shown
type: howto
slug: kb-numericupdown-paste-whitespaces-value
position: 0 
tags: trim,text
ticketid: 1502980
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3.1020</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadNumericUpDown for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Pasting a copied numeric value that contains untrimmed text does not work. In this case nothing happens.

## Solution

Subscribe the RadNumericUpDown control to the DataObject's [Pastring event](https://docs.microsoft.com/en-us/dotnet/api/system.windows.dataobject.addpastinghandler?view=net-5.0) and implement the pasting manually. 


```C#
	DataObject.AddPastingHandler(this.numericUpDown, OnNumericUpDownPaste);
```


```C#
	private void OnNumericUpDownPaste(object sender, DataObjectPastingEventArgs e)
	{
		var copiedString = e.DataObject.GetData(typeof(string)) as string;
		if (copiedString != null)
		{
			copiedString = copiedString.Trim();
			double number = 0;
			var success = double.TryParse(copiedString, out number);
			if (success)
			{
				this.numericUpDown.SetCurrentValue(RadNumericUpDown.ValueProperty, number);
				e.CancelCommand();
			}
		}
	}
```