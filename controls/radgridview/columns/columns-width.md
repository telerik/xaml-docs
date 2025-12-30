---
title: Columns Width
page_title: Columns Width
description: Check out our examples of how you can control the column width either on a grid or column level within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-setting-columns-width
tags: width,columns
published: True
position: 13
---

# Controlling Columns Width

The GridViewColumn elements can be manually sized by setting their width.

The column width can be set on the GridViewColumn elements via the `Width` property or on the RadGridView control via the `ColumnWidth` property. Both are of type `ColumnWidth`.

There are several values that you can assign to the property:

* `SizeToCells`&mdash;The width is set according to the longest text from the cells.

* `SizeToHeader`&mdash;The width is set according to the length of the column's header. This is the __default sizing behavior__. 

* `Auto`&mdash;The width is set according to the longest value(might be the header or a value within the cell).

* `*` (star)&mdash;The column would take as much space as there is available.	

* __Fixed Width__&mdash;You can set a fixed width for all the columns.

## Setting the Width of All Columns with the ColumnWidth Property

Setting the RadGridView's `ColumnWidth` property affects all columns' size which don't have their `Width` set explicitly. The `Width` property of the column has higher priority than the `ColumnWidth` of RadGridView.

**Example 1: Setting RadGridView's ColumnWidth**

```XAML
	<telerik:RadGridView ItemsSource="{Binding Clubs}" ColumnWidth="*">
```

**Example 2: Setting RadGridView's ColumnWidth in code**

```C#
	this.clubsGrid.ColumnWidth = new Telerik.Windows.Controls.GridViewLength(1, Telerik.Windows.Controls.GridViewLengthUnitType.Star);
```
```VB.NET

	Me.clubsGrid.ColumnWidth = New Telerik.Windows.Controls.GridViewLength(1, Telerik.Windows.Controls.GridViewLengthUnitType.Star)
```

## Setting the Width of a Column

Apart from setting the width for all the columns within the RadGridView, you can set the width for each individual column through its `Width` property. 

**Example 3: Setting the width of a specific column**

```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Width="Auto" />	
```

**Setting the width of a specific column in code**

```C#
	this.clubsGrid.Columns[0].Width = Telerik.Windows.Controls.GridViewLength.Auto;	
```
```VB.NET
	Me.clubsGrid.Columns(0).Width = Telerik.Windows.Controls.GridViewLength.Auto	
```

## Setting Column MinWidth and MaxWidth

The minimum and maximum widths of the column headers can be adjusted using the `MinWidth` and `MaxWidth` properties of the GridViewColumn. 

Also, these can be adjusted via the `MinColumnWidth` and `MaxColumnWidth` properties of RadGridView.

> Using a `0` value for the `MinWidth` and `MinColumnWidth` properties is not supported. If you use a fixed size, use at least `1`.


## See Also  
 * [Reordering Columns]({%slug gridview-columns-reordering-columns%}) 
 * [Resizing Columns]({%slug gridview-columns-resizing-columns%})
 * [Frozen Columns]({%slug gridview-columns-frozen-columns%})
 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})
