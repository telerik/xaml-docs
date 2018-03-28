---
title: Resetting the Capacity
page_title: Resetting the Capacity
description: Resetting the Capacity
slug: virtualgrid-resetting-the-capacity
tags: resetting, capacity
published: True
position: 9
---

# Resetting the Capacity

Inserting and removing rows or columns does not affect the __InitialRowCount__ or __InitialColumnCount__ properties. Thus, __RadVirtualGrid__ supports resetting its capacity to the values that are initially set for them. This can be achieved through the __Reset__ method and its two overloads:

* __Reset()__: Resets the capacity of the control to the values of the __InitialRowCount__ and __InitialColumnCount__ properties.

* __Reset(int rowCount, int columnCount)__: Through this overload of the Reset method, the capacity of __RadVirtualGrid__ can be reset to values different from the ones initially set to the __InitialRowCount__ and __InitialColumnCount__ properties. Furthermore, the two properties will be updated accordingly.

## See also

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})

* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})

* [Custom Data Provider]({%slug virtualgrid-custom-dataprovider%})