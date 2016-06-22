---
title: Column
page_title: Column Events
description: Column Events
slug: gridview-column-resize-event
tags: column, events
published: True
position: 6
---

# Column Events

In this article we will discuss all RadGridView events related to **columns**:

* [AutoGeneratingColumn](#autogeneratingcolumn)

* [ColumnReordering](#columnreordering)

* [ColumnDisplayIndexChanged](#columndisplayindexchanged)

* [ColumnReordered](#columnreordered)

* [ColumnWidthChanging event](#columnwidthchanging-event)

* [ColumnWidthChanged event](#columnwidthchanged-event)

You can subscribe to the events either declaratively or runtime. **Example 1** shows how to achieve this with the **AutoGeneratingColumn** event. You can subscribe to any of the other events analogically.

#### __[XAML] Example 1: Subscribing to column events__

	{{region gridview-column-resize-event_0}}
	<telerik:RadGridView Name="gridView" AutoGeneratingColumn="gridView_AutoGeneratingColumn"/>
	{{endregion}}

#### __[C#] Example 1: Subscribing to column events__

	{{region gridview-column-resize-event_1}}
	gridView.AutoGeneratingColumn += new EventHandler<AutoGeneratingColumnEventArgs>(gridView_AutoGeneratingColumn);
	{{endregion}}

#### __[VB.NET] Example 1: Subscribing to column events__

	{{region gridview-column-resize-event_2}}
	AddHandler gridView.AutoGeneratingColumn, AddressOf gridView_AutoGeneratingColumn
	{{endregion}}

## AutoGeneratingColumn

When RadGridView's **AutoGenerateColumns** property is set to **True** (the default value), RadGridView will create a separate column for each public property of the bound objects and the **AutoGeneratingColumn** event will be triggered for each of those columns.

The **GridViewAutoGeneratingColumnEventArgs** class provides you with a few useful properties:

* **Cancel**: By setting this to **True**, you can cancel the creation of the current column.

* **Column**: The column that is being generated.

* **ItemPropertyInfo**: Information about the property, based on which the column is generated.

**Example 2** demonstrates how you can cancel the creation of a specific column:

#### __[C#] Example 2: Cancel the creation of DateTime columns__

	{{region gridview-column-resize-event_3}}
    private void gridView_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
    {
        if (e.ItemPropertyInfo.PropertyType == typeof(DateTime))
        {
            e.Cancel = true;
        }
    }
	{{endregion}}

#### __[VB.NET] Example 2: Cancel the creation of DateTime columns__

	{{region gridview-column-resize-event_4}}
	Private Sub gridView_AutoGeneratingColumn(sender As Object, e As GridViewAutoGeneratingColumnEventArgs)
		If e.ItemPropertyInfo.PropertyType = GetType(DateTime) Then
			e.Cancel = True
		End If
	End Sub
	{{endregion}}

## ColumnReordering

The __ColumnReordering__ event occurs when RadGridView's columns are being reordered either programmatically or through the UI.

>The user can reorder columns only if the __CanUserReorderColumns__ is set to __True__ (which is the default value). 

Through the __ColumnReorderingEventArgs__ you can access the following properties:

* __Cancel__: By setting this to **True**, you can cancel the reordering of the current column.

* __Column__: The column that is being reordered.

* __NewDisplayIndex__: The new DisplayIndex of the reordered column.

>If ColumnReordering is canceled, the **ColumnDisplayIndexChanged** and __ColumnReordered__ events do not fire. 

## ColumnDisplayIndexChanged

The __ColumnDisplayIndexChanged__ event occurs when RadGridView's columns have been reordered or  when you have programmatically changed the **DisplayIndex** of a column. It is triggered for every column affected by the reordering (whose DisplayIndex has changed).
 
Through the __GridViewColumnEventArgs__ you can access the **Column** whose **DisplayIndex** has changed.

## ColumnReordered

The __ColumnReordered__ event occurs after the reorder of columns is complete.

Through the __GridViewColumnEventArgs__ you can access the **Column** that has been reordered.

## ColumnWidthChanging

The __ColumnWidthChanging__ event occurs when the column is being resized either programmatically or through the UI.

>The user can resize columns only if the __CanUserResizeColumns__ is set to __True__ (which is the default value). 

Through the __ColumnWidthChangingEventArgs__ of its event handler you can access:

* __Cancel__: By setting this to **True**, you can cancel the resizing of the current column.

* __Column__: The column that is being resized.

* __HorizontalChangeWidth__: A double value which indicates the number of pixels that would be added/subtracted to the column width. If you shrink the width the value will be negative, e.g. -10.

* __OriginalWidth__: A double value which represents the original width of the column.

>If the ColumnWidthChanging is canceled, the column does not change its width and the __ColumnWidthChanged__ event does not fire. 

The following example shows how to allow the user to widen the column, bot not shrink it:

#### __[C#] Example 3: Disable decreasing the column width__

	{{region gridview-column-resize-event_5}}
	void gridView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{ 
	   if (e.HorizontalChangeWidth < 0)
	   {
	      e.Cancel = true;
	   }
	}
	{{endregion}}

#### __[VB.NET] Example 3: Disable decreasing the column width__

	{{region gridview-column-resize-event_6}}
	Private Sub gridView_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs)
		If e.HorizontalChangeWidth < 0 Then
	  		e.Cancel = True
	 	End If
	End Sub
	{{endregion}}

>When the user __double clicks__ the header cell gripper and the column is resized according to its content, only the __ColumnWidthChanged__ event is fired.

## ColumnWidthChanged

The __ColumnWidthChanged__ event occurs after the resize of a column is complete. It also fires when the user double clicks the header cell gripper to automatically resize the column to fit its content.

Through its event handler you can access the __ColumnWidthChangedEventArgs__ object which provides you with the following properties: 

* __Column__: The column that has been resized.

* __NewWidth__: The new width of the resized column.

* __OriginalWidth__: The original width of the resized column.

## See Also

* [Defining Columns]({%slug gridview-columns-defining-columns%})

* [Reordering Columns]({%slug gridview-columns-reordering-columns%})

* [Resizing Columns]({%slug gridview-columns-resizing-columns%})