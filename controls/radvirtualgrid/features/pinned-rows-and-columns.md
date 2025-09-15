---
title: Pinned Rows and Columns
page_title: Pinned Rows and Columns
description: Check our &quot;Pinned Rows and Columns&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-pinned-rows-and-columns
tags: pinned,rows,columns
published: True
position: 1
---

# Pinned Rows and Columns

VirtualGrid provides a pinning mechanism for both its rows and columns. Through it, a given row can be pinned to the top or bottom of the grid. Respectively, a column can be pinned to the left or right side of VirtualGrid. Thus, they will not take part in the vertical or horizontal scrolling. 

## Pin Rows and Columns 

The pin functionality can be controlled using the following methods exposed by the API of the control.

* `PinRowTop(int index)`&mdash;Pins a row at a given index on the top.

	__Example 1: Calling the PinRowTop method__

	```C#
		virtualGrid.PinRowTop(1);
	```

	#### __Figure 1: RadVirtualGrid with pinned row at the top__

	![RadVirtualGrid with pinned row on the top](images/RadVirtualGrid_Features_PinnedRowsColumns_01.png)

* `PinRowBotton(int index)`&mdash;Pins a row at a given index to the bottom.

	__Example 2: Calling the PinRowBottom method__

	```C#
		virtualGrid.PinRowBottom(1);
	```

	#### __Figure 2: RadVirtualGrid with pinned row at the bottom__

	![RadVirtualGrid with pinned row at the bottom](images/RadVirtualGrid_Features_PinnedRowsColumns_02.png)

* `PinColumnLeft(int index)`&mdash;Pins a column at a given index to the left.

	__Example 3: Calling the PinColumnLeft method__

	```C#
		virtualGrid.PinColumnLeft(1);
	```

	#### __Figure 3: RadVirtualGrid with pinned column on the left__

	![ RadVirtualGrid with pinned column on the left](images/RadVirtualGrid_Features_PinnedRowsColumns_03.png)

* `PinColumnRight(int index)`&mdash;Pins a column at a given index to the right.

	__Example 4: Calling the PinColumnRight method__

	```C#
		virtualGrid.PinColumnRight(1);
	```

	#### __Figure 4: RadVirtualGrid with pinned column on the right__

	![RadVirtualGrid with pinned column on the right](images/RadVirtualGrid_Features_PinnedRowsColumns_04.png)

## Unpin Rows and Columns

Unpinning an already pinned row or column can be achieved through the `UnpinRow` and `UnpinColumn` methods.

* `UnpinRow(int index)`&mdash;Unpins a row at a given index.

* `UnpinColumn(int index)`&mdash;Unpins a column at a given index.

__Example 5: Unpin methods usage__  
```C#
	virtualGrid.UnpinRow(1);
	virtualGrid.UnpinColumn(1);
```

## Commands Support

VirtualGrid exposes built-in commands for its pinning functionality. They can be accessed via the `RadVirtualGridCommands` and executed using the `PendingCommands` collection property of the VirtualGrid and its `ExecutePendingCommand` method. 

The available commands are `PinRowTop`, `PinRowBottom`, `PinColumnLeft`, `PinColumnRight`, `UnpinRow` and `UnpinColumn`. Read more about the commanding support in the [Commands Overview]({%slug virtualgrid-commands-overview%}) article.

## Usage with Filtering and Sorting

The pinned rows feature is not supported when filtering or sorting is applied. In case you already have pinned rows and then apply filtering or sorting, the rows will get unpinned. After, the filtering and sorting is cleared, the previously pinned rows will be restored.

## See also  
* [Editing]({%slug virtualgrid-editing%})  
* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})
