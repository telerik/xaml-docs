---
title: Column and Row Resizing 
page_title: Column and Row Resizing
description: Check our &quot;Column and Row Resizing&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-column-and-row-resizing
tags: column, row, resizing
published: True
position: 7
---

# Column and Row Resizing

By default, `RadVirtualGrid` will enable resizing of its columns and disable resizing of the rows.

The control enables changing the column width and row height at runtime through the UI. This can be achieved by positioning the mouse over the columns vertical grid line and dragging it until the needed width of the column is achieved. Respectively, the rows can be resized by placing the mouse cursor over the horizontal grid line in the row header and dragging to the required height.

__Resizing the columns of RadVirtualGrid__

![{{site.framework_name}} Resizing the columns of RadVirtualGrid](images/RadVirtualGrid_Features_ColumnAndRowResizing_01.png)

## Disable Column Resizing

The mechanism that the control provides for disabling the column resizing, is its `CanUserResizeColumns` property. When set to __False__, the user will not be able to resize the columns of the control.

## Enable Row Resizing

The ability to resize the rows of RadVirtualGrid can be manipulated through the `CanUserResizeRows` property. Its default value is __False__. When set to true, the user will be able to resize the rows of the control.

## Fit Column Width

>important The ability to use this mechanism depends on the value of the `MeasureTextOnRender` property. More information can be found in the [Getting Started]({%slug virtualgrid-getting-started2%})

RadVirtualGrid supports setting the width of a given column to be as large as biggest cell's content present in the viewport. This can be done through the `FitColumnWidthToContent` method. It accepts the index of the column that needs to be resized.

>tip If the MeasureTextOnRender property is set to __True__, the FitColumnWidthToContent method will return the calculated column width. Otherwise, the return value will be __0.0__.

>important Invoking the FitColumnWidthToContent also depends on the __MainPanel__ of the control to be loaded. This is needed, so the control can actually perform the measuring calculations. Thus, calling the method right after the `InitializeComponent` method of the application is not recommended.

A possible way to ensure that the visual elements of RadVirtualGrid are already generated, is to handle the `Loaded` event of the control. 

__Invoking the FitColumnWidthToContent method__
```C#
	private void VirtualGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.VirtualGrid.FitColumnWidthToContent(1);
        }
```

## See Also

* [Alternation]({%slug virtualgrid-alternation%})

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})
