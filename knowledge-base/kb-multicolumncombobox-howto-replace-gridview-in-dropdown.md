---
title: Replace the RadGridView element in the dropdown
description: Use a RadTreeView instead of a RadGridView in the RadMultiColumnComboBox dropdown.
type: how-to
page_title: Switch the RadGridView element inside the popup for a RadTreeView.
slug: kb-multicolumncombobox-howto-replace-gridview-in-dropdown
position: 0
tags: mccb, multicolumncombobox, treeview, element, dropdown, replace
ticketid: 1520617
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

Replace the RadGridView in the dropdown popup of the RadMultiColumnComboBox.  

## Solution

1. Create a class inheriting [DropDownContentManager](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.multicolumncombobox.dropdowncontentmanager) and implement the necessary methods. This class provides interaction with the DropDown element of the RadMultiColumnComboBox.

2. Create a class inheriting [SelectionBridge](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.multicolumncombobox.selectionbridge). This class is reponsible for synchronizing the selection between the dropdown element and the RadMultiColumnComboBox. Return an instance of this class in the __InitializeSelectionBridge__ method of the DropDownContentManager. 

3. Create a class inheriting [ItemsSourceProvider](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.multicolumncombobox.itemssourceprovider). This class is responsible for providing the ItemsSource to the element inside the dropdown along with any other relevant properties. 

4. Create a class inheriting RadMultiColumnComboBox and set the __DropDownContentManager__ property to instance of the class created in step 1. 

5. [Extract the ControlTemplate]({%slug styling-apperance-editing-control-templates%}) of the RadMultiColumnComboBox for the theme that you use and replace the RadGridView element inside the dropdown. 

> Check out the following [SDK example](https://github.com/telerik/xaml-sdk/tree/master/MultiColumnComboBox/TreeViewInDropDown) for an example implementation of the steps outlined above. 

<!-- -->

>tip Download the [source code]({%slug download-product-files-wpf%}) to examine how the above mentioned classes are implemented for the RadGridView. 

## See Also 

* [RadMultiColumnComboBox Getting Started]({%slug multicolumncombobox-getting-started%})