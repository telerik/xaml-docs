---
title: Pinned Rows and Columns
page_title: Pinned Rows and Columns
description: Pinned Rows and Columns
slug: virtualgrid-pinned-rows-and-columns
tags: pinned,rows,columns
published: True
position: 1
---

# Pinned Rows and Columns

__RadVirtualGrid__ provides pinning mechanism for both its rows and columns. Through it a given row can be pinned to the top or bottom of the grid. Respectively, a column can be pinned to the left or right side of __RadVirtualGrid__. Thus, they will not take part in the vertical or horizontal scrolling. This functionality can be controlled through the following methods exposed by the API of the control.

* __PinRowTop(int index)__: Pins a row at a given index on the top

* __PinRowBotton(int index)__: Pins a row at a given index to the bottom

* __PinColumnLeft(int index)__: Pins a column at a given index to the left

* __PinColumnRight(int index)__: Pins a column at a given index to the right

Unpinning an already pinned row or column can be achieved through the __UnpinRow__ and __UnpinColumn__ methods:

* __UnpinRow(int index)__: Unpins a row at a given index

* __UnpinColumn(int index)__: Unpins a column at a given index

## See also

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})