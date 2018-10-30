---
title: Column and Row Resizing 
page_title: Column and Row Resizing
description: Column and Row Resizing
slug: virtualgrid-column-and-row-resizing
tags: column, row, resizing
published: True
position: 7
---

# Column and Row Resizing

By default, __RadVirtualGrid__ will enable resizing of its columns and disable resizing of the rows.

The control enables changing the column width and row height at runtime through the UI. This can be achieved by positioning the mouse over the columns vertical grid line and dragging it until the needed width of the column is achieved. Respectively, the rows can be resized by placing the mouse cursor over the horizontal grid line in the row header and dragging to the required height.

#### __Figure 1: Resizing the columns of RadVirtualGrid__
![Resizing the columns of RadVirtualGrid](images/RadVirtualGrid_Features_ColumnAndRowResizing_01.png)

## Disable Column Resizing

The mechanism that the control provides for disabling the column resizing, is its __CanUserResizeColumns__ property. When set to __False__, the user will not be able to resize the columns of the control.

## Enable Row Resizing

The ability to resize the rows of __RadVirtualGrid__ can be manipulated through the __CanUserResizeRows__ property. Its default value is __False__. When set to true, the user will be able to resize the rows of the control.

## Fit Column Width

>important The ability to use this mechanism depends on the value of the __MeasureTextOnRender__ property. More information can be found in the [Getting Started]({%slug virtualgrid-getting-started2%})

__RadVirtualGrid__ supports setting the width of a given column to be as large as biggest cell's content present in the viewport. This can be done through the __FitColumnWidthToContent__ method. It accepts the index of the column that needs to be resized.

>important Invoking the __FitColumnWidthToContent__ also depends on the __MainPanel__ of the control to be loaded. This is needed so the control can actually perform the measuring calculations. Thus, calling the method right after the __InitializeComponent__ method of the application is __not recommended__.

A possible way to ensure that the visual elements of __RadVirtualGrid__ are already generated, is to handle the __Loaded__ event of the control. 

#### __[C#] Example 1: Invoking the FitColumnWidthToContent method__

{{region cs-radvirtualgrid-features-column-and-row-resizing_0}}
	private void VirtualGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.VirtualGrid.FitColumnWidthToContent(1);
        }
{{endregion}}

## See Also

* [Alternation]({%slug virtualgrid-alternation%})

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})
