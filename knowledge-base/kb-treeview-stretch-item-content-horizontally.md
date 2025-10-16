---
title: Get Content of RadTreeViewItem to Fill Full Size of Container
page_title: How to Stretch RadTreeViewItem Content Horizontally
description: Stretching Telerik RadTreeView item's content horizontally to fill the available space.
type: how-to
slug: kb-treeview-stretch-item-content-horizontally
position: 0
tags: horizontal,alignment,stretch,fill,full,size
ticketid: 1419373
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.618</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadTreeView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to stretch RadTreeViewItem content horizontally in order to fill the full size of the container.

## Solution

Set the __HorizontalContentAlignment__ property of RadTreeViewItem to Stretch.

To apply this globally to all RadTreeViewItems in the treeview, use the ItemContainerStyle property.


```XAML
	<telerik:RadTreeView.ItemContainerStyle>
		<Style TargetType="telerik:RadTreeViewItem">
			<Setter Property="HorizontalContentAlignment" Value="Stretch" />
		</Style>
	</telerik:RadTreeView.ItemContainerStyle>
```

To apply it per item set the property directly on the RadTreeViewItem.


```XAML
	<telerik:RadTreeViewItem HorizontalContentAlignment="Stretch" />
```
