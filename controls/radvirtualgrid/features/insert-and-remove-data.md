---
title: Insert and Remove Data
page_title: Insert and Remove Data
description: Insert and Remove Data
slug: virtualgrid-insert-data-and-remove-data
tags: insert,remove,data
published: True
position: 2
---

# Insert and Remove Data

__RadVirtualGrid__ exposes an API for inserting and removing rows and columns at given index. This can be achieved through the following methods:

> The methods for removing a row or column cannot be utilized for pinned rows or columns

* __InsertNewRowAtIndex(int index)__: Increases the table capacity by adding a row at given index

* __InsertNewColumnAtIndex(int index)__: Increases the table capacity by adding a column at given index

* __RemoveRowAtIndex(int index)__: Decreases the capacity of the table by removing a row at given index

* __RemoveColumnAtIndex(int index)__: Decreases the capacity of the table by removing a column at given index

>When inserting a row or a column, the control simply increases its capacity. Updating the source collection with this modification needs to be done manually as well.

## See Also

* [Editing]({%slug virtualgrid-editing%})

* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})