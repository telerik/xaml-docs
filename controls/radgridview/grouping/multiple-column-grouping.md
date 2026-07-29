---
title: Multiple-column Grouping
page_title: Multiple-Column Grouping
description: Learn how to enable multiple-column grouping in Telerik's {{ site.framework_name }} DataGrid by dragging and dropping more than one column headers into the grouping area. 
slug: gridview-multiple-column-grouping
tags: multiple-column,grouping
published: True
position: 3
---

# Multiple-Column Grouping

On the snapshot you can see how the data in the __RadGridView__ is grouped by two columns - the __Country__ and the __Title__. The data is first grouped by the __Country__ column and then the data in the separate groups is grouped again by the __Title__ column.

![Telerik UI for {{ site.framework_name }} RadGridView grouped first by Country and then by Title](images/RadGridView_MultiColumnGrouping_1.png)

The user can do it via the built-in grouping mechanism by dragging and dropping more than one column headers into the grouping area.

![Telerik UI for {{ site.framework_name }} RadGridView dragging multiple column headers into the group panel](images/RadGridView_MultiColumnGrouping_2.png)

>The data in the __RadGridView__ will be grouped depending on the order the user drops the headers in the grouping area.

After adding several headers you are allowed to reorder them by dragging the rectangle representing the grouping criteria and dropping it at the desired position.

![Telerik UI for {{ site.framework_name }} RadGridView reordering multiple grouping criteria in the group panel](images/RadGridView_MultiColumnGrouping_3.png)

It is also possible to group the data by multiple columns programmatically by using the __GroupDescriptors__ collection of __RadGridView__. To learn more about it take a look at the [Programmatic Grouping]({%slug gridview-programmatic-grouping%}) topic.

If you want to implement multi-column grouping you just have to define __GroupDescriptor__ or __ColumnGroupDescriptor__ objects for the desired grouping criteria and add them to the __GroupDescriptors__ collection. It can be done at design time:



<snippet id='radgridview-grouping-multiple-column-grouping-block_1-xaml' />


This can be done at run time via managed code too:



<snippet id='radgridview-grouping-multiple-column-grouping-block_2-cs' />

<snippet id='radgridview-grouping-multiple-column-grouping-block_2-vb' />


The result is the same as if the user has dragged and dropped the desired columns into the grouping area:

![Telerik UI for {{ site.framework_name }} RadGridView showing the result of programmatic multi-column grouping by Country and Title](images/RadGridView_MultiColumnGrouping_1.png)

## See Also

 * [Basic Grouping]({%slug gridview-grouping-basics%})

 * [Programmatic Grouping]({%slug gridview-programmatic-grouping%})

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})

 * [Group Footers]({%slug gridview-group-footers%})

 * [Modifying the Group Panel]({%slug gridview-modifying-group-panel%})
