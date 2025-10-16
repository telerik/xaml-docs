---
title: Select a Cell Region by Dragging the Mouse from One Cell to Another
description: How to enable selection of cells via continuous drag of the mouse between two cells.
page_title: Add Cells to the Selection on Mouse Drag Between Two Cells
type: how-to
slug: kb-virtualgrid-mouse-drag-selection
position: 0
tags: mouse, drag, select, cell, region
ticketid: 1577425
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2022.3.912</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadVirtualGrid for WPF</td>
	</tr>
</table>

## Description

How to select a RadVirtualGrid cell region by dragging the mouse from one cell to another.

## Solution

To achieve this requirement, first set up handlers for the `MouseLeftButtonDown` and `MouseLeftButtonUp` events of RadVirtualGrid:

__Adding the event handlers__ 
```C#
	this.VirtualGrid.AddHandler(RadVirtualGrid.MouseLeftButtonDownEvent, new MouseButtonEventHandler(VirtualGrid_MouseLeftButtonDown), true);
	this.VirtualGrid.AddHandler(RadVirtualGrid.MouseLeftButtonUpEvent, new MouseButtonEventHandler(VirtualGrid_MouseLeftButtonUp), true);
```

Note that we do this with the `AddHandler` method so that we can set the `handledEventsToo` parameter. This is required, because the RadVirtualGrid internally handles these events and our custom handlers will not be invoked otherwise.

Then, in the `MouseLeftButtonDown` event handler, with the help of the [GetRowIndexAtMousePosition and GetColumnIndexAtMousePosition]({%slug virtualgrid-get-row-or-column-index-of-the-mouse-position%}) methods we get ahold of the row and column indexes of the initial cell which will serve as an anchor for the selected region.

__Handling the MouseLeftButtonDown event__ 
```C#
	private int startRowIndex = -1;
	private int startColumnIndex = -1;

	private void VirtualGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		var virtualGrid = sender as RadVirtualGrid;
		var border = e.OriginalSource as CanvasInputBorder;
		this.startRowIndex = virtualGrid.GetRowIndexAtMousePosition(border);
		this.startColumnIndex = virtualGrid.GetColumnIndexAtMousePosition(border);
	}
```

Then in a similar fashion, we can obtain the last selected cell in the `MouseLeftButtonUp` event handler. Then, based on the start and end cells, we can create a new `CellRegion` and use the [SelectCellRegion]({%slug virtualgrid-programmatic-selection%}) method to select it.

__Handling the MouseLeftButtonDown event__ 
```C#
	private void VirtualGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
	{
		var virtualGrid = sender as RadVirtualGrid;
		var border = e.OriginalSource as CanvasInputBorder;
		var endColumnIndex = virtualGrid.GetColumnIndexAtMousePosition(border);
		var endRowIndex = virtualGrid.GetRowIndexAtMousePosition(border);

		var left = Math.Min(startColumnIndex, endColumnIndex);
		var top = Math.Min(startRowIndex, endRowIndex);
		var width = Math.Abs(startColumnIndex - endColumnIndex) + 1;
		var height = Math.Abs(startRowIndex - endRowIndex) + 1;

		virtualGrid.SelectCellRegion(new CellRegion(left, top, width, height));
	}
```

>You can also perform the logic of the `MouseLeftButtonUp` event on `MouseMove` but you will need to add some additional logic to stop the selection process when the mouse button is released.

## See Also
* [Get the Row or Column Index of the Mouse Position]({%slug virtualgrid-get-row-or-column-index-of-the-mouse-position%})
* [Programmatic Selection]({%slug virtualgrid-programmatic-selection%})
