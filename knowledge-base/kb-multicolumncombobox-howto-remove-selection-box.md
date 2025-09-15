---
title: Remove the Selection Boxes Inside RadMultiColumnComboBox
description: How to remove the selection boxes of RadMultiColumnComboBox.
type: how-to
page_title: Create consistent display with RadComboBox.
slug: kb-multicolumncombobox-howto-remove-selection-box
position: 0
tags: mccb, multicolumncombobox, selectionbox, radcombobox, selecteditem, selection, consistent, remove, close, button
ticketid: 1382797
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadMultiColumnComboBox for WPF</td>
	</tr>
</table>


## Description
The selection boxes of the RadMultiColumnComboBox is visible by default.

## Solution

To hide the selection boxes, the SelectionBoxesVisibility property can be set to Collapsed.


```C#
	<telerik:RadMultiColumnComboBox SelectionBoxesVisibility="Collapsed"/>
```
