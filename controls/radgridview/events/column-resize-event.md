---
title: Column
page_title: Column Events
description: Learn more about the column events of Telerik's {{ site.framework_name }} DataGrid that you can subscribe to declaratively or at runtime.
slug: gridview-column-resize-event
tags: column, events
published: True
position: 6
---

# Column Events

In this article we discuss RadGridView events related to **columns**:

* [AutoGeneratingColumn](#autogeneratingcolumn)

* [ColumnReordering](#columnreordering)

* [ColumnDisplayIndexChanged](#columndisplayindexchanged)

* [ColumnReordered](#columnreordered)

* [ColumnWidthChanging](#columnwidthchanging)

* [ColumnWidthChanged](#columnwidthchanged)

You can subscribe to these events declaratively or at runtime. **Example 1** shows you how to subscribe to the **AutoGeneratingColumn** event. 

__Example 1: Subscribing to column events__

	```XAML
	<telerik:RadGridView Name="gridView" AutoGeneratingColumn="gridView_AutoGeneratingColumn"/>
```

__Example 1: Subscribing to column events__

	```C#
	gridView.AutoGeneratingColumn += gridView_AutoGeneratingColumn;
```
```VB.NET
	AddHandler gridView.AutoGeneratingColumn, AddressOf gridView_AutoGeneratingColumn
```

## AutoGeneratingColumn

When you set RadGridView's **AutoGenerateColumns** property to **True** (the default value), RadGridView creates a column for each public property of the bound objects and the **AutoGeneratingColumn** event is triggered for each of those columns.

You can use the following properties of the **GridViewAutoGeneratingColumnEventArgs** class:

* **Cancel**: Setting this to **True** cancels the creation of the current column.

* **Column**: The column that is being generated.

* **ItemPropertyInfo**: Information about the property, based on which the column is generated.

**Example 2** demonstrates how you can cancel the creation of a specific column:

__Example 2: Cancelling the creation of DateTime columns__

	```C#
	private void gridView_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
	{
	    if (e.ItemPropertyInfo.PropertyType == typeof(DateTime))
	    {
	        e.Cancel = true;
	    }
	}
```
```VB.NET
	Private Sub gridView_AutoGeneratingColumn(sender As Object, e As GridViewAutoGeneratingColumnEventArgs)
	    If e.ItemPropertyInfo.PropertyType = GetType(DateTime) Then
	        e.Cancel = True
	    End If
	End Sub
```

## ColumnReordering

The __ColumnReordering__ event occurs when you reorder RadGridView's columns programmatically or through the UI.

>You can reorder columns only if __CanUserReorderColumns__ is set to __True__ (which is the default value). 

Using __ColumnReorderingEventArgs__ you can access the following properties:

* __Cancel__: Setting this to **True** cancels the reordering of the current column.

* __Column__: The column that is being reordered.

* __NewDisplayIndex__: The new DisplayIndex of the reordered column.

>If you cancel ColumnReordering, **ColumnDisplayIndexChanged** and __ColumnReordered__ events are not triggered. 

## ColumnDisplayIndexChanged

The __ColumnDisplayIndexChanged__ event occurs when you reorder RadGridView's columns or when you programmatically change the **DisplayIndex** of a column. It is triggered for every column affected by the reordering (that is, whose DisplayIndex has changed).
 
You can access the **Column** whose **DisplayIndex** has changed using __GridViewColumnEventArgs__.

## ColumnReordered

The __ColumnReordered__ event occurs after the reorder of columns is complete.

You can access the **Column** that has been reordered using __GridViewColumnEventArgs__.

## ColumnWidthChanging

A __ColumnWidthChanging__ event occurs when you resize a column programmatically or through the UI.

>You can resize columns only if __CanUserResizeColumns__ is set to __True__ (which is the default value). 

Through the __ColumnWidthChangingEventArgs__ of its event handler you can access the following:

* __Cancel__: Setting this to **True** cancels the resizing of the current column.

* __Column__: The column that is being resized.

* __HorizontalChangeWidth__: A double value that indicates the number of pixels that would be added to or subtracted from the column width. If you shrink the width, the value is negative, for example, -10.

* __OriginalWidth__: A double value that represents the original width of the column.

>If you cancel ColumnWidthChanging, the column's width does not change and the __ColumnWidthChanged__ event is not triggered. 

The following example shows you how to allow the user to widen a column, but not shrink it:

__Example 3: Disable decreasing the column width__

	```C#
	void gridView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{
	    if (e.HorizontalChangeWidth.Value < 0)
	    {
	        e.Cancel = true;
	    }
	}
```
```VB.NET
	Private Sub gridView_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs)
	    If e.HorizontalChangeWidth.Value < 0 Then
	        e.Cancel = True
	    End If
	End Sub
```

>When the user __double-clicks__ the header cell gripper and the column is resized according to its content, only the  __ColumnWidthChanged__ event is triggered.

## ColumnWidthChanged

The __ColumnWidthChanged__ event occurs after the resize of a column is complete. It also triggers when the user double-clicks the header cell gripper to resize the column to fit its content.

You can access the following properties of the __ColumnWidthChangedEventArgs__ object: 

* __Column__: The column that has been resized.

* __NewWidth__: The new width of the resized column.

* __OriginalWidth__: The original width of the resized column.

## See Also

* [Defining Columns]({%slug gridview-columns-defining-columns%})

* [Reordering Columns]({%slug gridview-columns-reordering-columns%})

* [Resizing Columns]({%slug gridview-columns-resizing-columns%})
