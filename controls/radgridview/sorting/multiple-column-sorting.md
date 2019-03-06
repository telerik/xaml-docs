---
title: Multiple-column Sorting
page_title: Multiple-column Sorting
description: Learn how you can sort data in Telerik's {{ site.framework_name }} DataGrid ascending by the Est. column and then sort again by the Stadium column without removing previous sorting.
slug: gridview-multiple-column-sorting
tags: multiple-column,sorting
published: True
position: 3
---

# Multiple-column Sorting

On the snapshot bellow the data in __RadGridView__ is sorted ascending by the Est. column and then sorted again by the Stadium column, without removing the previous sorting. This feature is called multi column sorting.
       
![Telerik {{ site.framework_name }} DataGrid MultiColumnSorting 1](images/RadGridView_MultiColumnSorting_1.png)

To learn how to implement progtammatic sorting in your __RadGridView__ read on this [topic]({%slug gridview-sorting-programmatic%}).

>tipRun-time you can sort by multiple columns by just holding the __Shift__ key pressed and click all column headers you wish to sort your data by. For more key combinations read the [Keyboard Support]({%slug gridview-overview-keyboard-support%}) topic.

As of __Q2 2013__, the user can benefit from __Column Sort Sequence Indicator__. In order to have this feature enabled you need to set __ShowColumnSortIndexes__ property of RadGridView to __True__.

You can check how the column headers will look like after the user has sorted on multiple columns.

![Telerik {{ site.framework_name }} DataGrid MultiColumnSorting 2](images/RadGridView_MultiColumnSorting_2.png)

## See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Basic Sorting]({%slug gridview-sorting-basics%})

 * [Programmatic Sorting]({%slug gridview-sorting-programmatic%})

 * [Custom Sorting]({%slug gridview-sorting-custom%})
