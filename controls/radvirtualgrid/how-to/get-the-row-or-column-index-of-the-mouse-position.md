---
title: Get the Row or Column Index of the Mouse Position
page_title: Get the Row or Column Index of the Mouse Position
description: Check our &quot;Get the Row or Column Index of the Mouse Position&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-get-row-or-column-index-of-the-mouse-position
tags: row, column, index, mouse
published: True
position: 0
---

# Get the Row or Column Index of the Mouse Position

In a scenario when the row/column index for the mouse position is needed, the __GetRowIndexAtMousePosition__ and __GetColumnIndexAtMousePosition__ methods come in handy. In order to return the needed index, they accept a parameter of type __CanvasInputBorder__. This __Border__ is used internally by __RadVirtualGrid__ to enable mouse interaction with the control. For example, if the row and column indexes for the __MouseRightButtonDown__ event of __RadVirtualGrid__ are needed, its event handler would be similar to the following one.

__Getting the Row and Column Index on MouseRightButtonDown event__
```C#
	private void VirtualGrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var border = e.OriginalSource as Telerik.Windows.Controls.VirtualGrid.CanvasInputBorder;
            var columnIndex = this.VirtualGrid.GetColumnIndexAtMousePosition(border);
            var rowIndex = this.VirtualGrid.GetRowIndexAtMousePosition(border);
        }
```

If you have defined a [custom CellTemplate]({%slug radvirtualgrid-custom-cell-content%}), you would need to add additional logic to get ahold of the CanvasInputBorder.

__Getting the Row and Column Index when using a custom CellTemplate__
```C#
	private void VirtualGrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {	
	    var border = e.OriginalSource as Telerik.Windows.Controls.VirtualGrid.CanvasInputBorder;
	    if (border == null)
	    {
	        var element = e.OriginalSource as FrameworkElement;
	        var panel = element.ParentOfType<VirtualizingCanvasBase>();
	        border = panel.ChildrenOfType<CanvasInputBorder>().FirstOrDefault();
	    }
	
	    var columnIndex = this.VirtualGrid.GetColumnIndexAtMousePosition(border);
	    var rowIndex = this.VirtualGrid.GetRowIndexAtMousePosition(border);
        }
```

> The previous examples show how to use the `MouseRightButtonDown` event. To subscribe to `MouseLeftButtonDown`, you will need to use the `AddHandler` method with its last parameter set to `true`. `this.virtualGrid.AddHandler(RadVirtualGrid.MouseLeftButtonDownEvent, new MouseButtonEventHandler(virtualGrid_MouseLeftButtonDown), true);`

## See Also

* [Selection]({%slug virtualgrid-selection%})
* [Multiple Selection]({%slug virtualgrid-multiple-selection%})
* [Editing]({%slug virtualgrid-editing%})
* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})
* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})
