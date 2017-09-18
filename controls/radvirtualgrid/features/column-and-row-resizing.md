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

## See Also

* [Alternation]({%slug virtualgrid-alternation%})

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})