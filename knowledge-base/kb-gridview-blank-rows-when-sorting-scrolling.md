---
title: Child Hierarchy Blank Rows When Sorting or Scrolling RadGridView
description: Rows content missing when sorting or scrolling RadGridView control.
page_title: Empty Rows In RadGridView After Order or Scroll DataGrid
type: troubleshooting
slug: kb-gridview-blank-rows-when-sorting-scrolling
position: 0
tags: child,hierarchy,rows,blank
ticketid: 1422931
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2 729</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

Rows are blank when sorting or scrolling the RadGridView control. This can also be observed for child rows when hierarchy is used.

## Solution 1

Such issues may appear when using the default GroupRenderMode (Nested) of RadGridView. To resolve this, set GroupRenderMode to Flat.


```XAML
	<telerik:RadGridView GroupRenderMode="Flat" />
```

## Solution 2

Also, similar issues can occur when setting properties of the GridViewRow controls in code. For example:

GridViewRow row = GetRowMethod();  

row.Visibility = Visibility.Collapsed; // or similar

To resolve this, avoid setting GridViewRow properties directly. Instead use the __RowStyle__ property of RadGridView and data bind any properties you want.
