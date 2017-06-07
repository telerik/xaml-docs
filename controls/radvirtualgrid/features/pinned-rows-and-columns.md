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

#### __[C#] Example 1: Calling the PinRowTop method__

{{region radvirtualgrid-features_pinnedrowsandcolumns_0}}
	virtualGrid.PinRowTop(1);
{{endregion}}

#### __Figure 1: RadVirtualGrid with pinned row on the top__

![](images/RadVirtualGrid_Features_PinnedRowsColumns_01.png)

* __PinRowBotton(int index)__: Pins a row at a given index to the bottom

#### __[C#] Example 2: Calling the PinRowBottom method__

{{region radvirtualgrid-features_pinnedrowsandcolumns_1}}
	virtualGrid.PinRowBottom(1);
{{endregion}}

#### __Figure 2: RadVirtualGrid with pinned row on the bottom__

![](images/RadVirtualGrid_Features_PinnedRowsColumns_02.png)

* __PinColumnLeft(int index)__: Pins a column at a given index to the left

#### __[C#] Example 3: Calling the PinColumnLeft method__

{{region radvirtualgrid-features_pinnedrowsandcolumns_2}}
	virtualGrid.PinColumnLeft(1);
{{endregion}}

#### __Figure 3: RadVirtualGrid with pinned column on the left__

![](images/RadVirtualGrid_Features_PinnedRowsColumns_03.png)

* __PinColumnRight(int index)__: Pins a column at a given index to the right

#### __[C#] Example 4: Calling the PinColumnRight method__

{{region radvirtualgrid-features_pinnedrowsandcolumns_3}}
	virtualGrid.PinColumnRight(1);
{{endregion}}

#### __Figure 4: RadVirtualGrid with pinned column on the left__

![](images/RadVirtualGrid_Features_PinnedRowsColumns_04.png)

Unpinning an already pinned row or column can be achieved through the __UnpinRow__ and __UnpinColumn__ methods:

* __UnpinRow(int index)__: Unpins a row at a given index

* __UnpinColumn(int index)__: Unpins a column at a given index

## See also

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})