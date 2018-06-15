---
title: Get the Row or Column Index of the Mouse Position
page_title: Get the Row or Column Index of the Mouse Position
description: Get the Row or Column Index of the Mouse Position
slug: virtualgrid-get-row-or-column-index-of-the-mouse-position
tags: row, column, index, mouse
published: True
position: 0
---

# Get the Row or Column Index of the Mouse Position

In a scenario when the row/column index for the mouse position is needed, the __GetRowIndexAtMousePosition__ and __GetColumnIndexAtMousePosition__ come in handy. In order to return the needed index, they accept a parameter of type __CanvasInputBorder__. This __Border__ is used internally by __RadVirtualGrid__ to enable mouse interaction with the control. For example, if the row and column index for the __MouseRightButtonDown__ event of__RadVirtualGrid__ are needed, its handler would be similar to the following one.

#### __[C#] Example 1: Getting the Row and Column Index on MouseRightButtonDown event__
{{region radvirtualgrid-selection_programmatic-selection_0}}
	private void VirtualGrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var border = e.OriginalSource as CanvasInputBorder;

            var columnIndex = this.VirtualGrid.GetColumnIndexAtMousePosition(border);
            var rowIndex = this.VirtualGrid.GetRowIndexAtMousePosition(border);
        }
{{endregion}}

## See Also

* [Selection]({%slug virtualgrid-selection%})

* [Multiple Selection]({%slug virtualgrid-multiple-selection%})

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})

* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})