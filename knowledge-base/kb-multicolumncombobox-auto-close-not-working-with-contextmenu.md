---
title: MultiColumnComboBox DropDown Doesn't Close After Context Menu Is Opened
page_title: KeepDropDownOpen of RadMultiColumnComboBox Set to False Doesn't Auto-Close the Popup After a Context Menu Is Opened Inside the Popup
description: Opening a ContextMenu inside the dropdown of a MultiColumnComboBox is breaking the KeepDropDownOpen setting.
type: troubleshooting
slug: kb-multicolumncombobox-auto-close-not-working-with-contextmenu
position: 0
tags: kb
ticketid: 0000000
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
			<td>RadMultiColumnComboBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Setting the `KeepDropDownOpen` property of RadMultiColumnComboBox to `False` enables the auto closing feature of the drop down part of the control. However, opening a RadContextMenu for an element inside the dropdown is breaking the functionality. This means that clicking outside of the RadMultiColumnComboBox control won't close its drop down.

## Solution

To resolve this, set the `RestoreFocusToTargetElement` property of the `RadContextMenu` control to `True`.


```XAML
	<telerik:RadMultiColumnComboBox KeepDropDownOpen="False">
			<telerik:RadContextMenu.ContextMenu>
				<telerik:RadContextMenu RestoreFocusToTargetElement="True">
					<telerik:RadMenuItem Header="Copy"/>
				</telerik:RadContextMenu>
			</telerik:RadContextMenu.ContextMenu>
	</telerik:RadMultiColumnComboBox>
```
