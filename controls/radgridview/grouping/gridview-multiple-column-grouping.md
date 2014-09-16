---
title: Multiple-column Grouping
page_title: Multiple-column Grouping
description: Multiple-column Grouping
slug: gridview-multiple-column-grouping
tags: multiple-column,grouping
publish: True
position: 3
---

# Multiple-column Grouping



## 

On the snapshot you can see how the data in the __RadGridView__ is grouped by two columns - the __Country__ and the __Title__. The data is first grouped by the __Country__ column and then the data in the separate groups is grouped again by the __Title__ column.

__![](images/RadGridView_MultiColumnGrouping_1.png)__

The user can do it via the built-in grouping mechanism by dragging and dropping more than one column headers into the grouping area.

__![](images/RadGridView_MultiColumnGrouping_2.png)__

>The data in the __RadGridView__ will be grouped depending on the order the user drops the headers in the grouping area.

After adding several headers you are allowed to reorder them by dragging the rectangle representing the grouping criteria and dropping it at the desired position.

__![](images/RadGridView_MultiColumnGrouping_3.png)__

It is also possible to group the data by multiple columns programmatically by using the __GroupDescriptors__ collection of the __RadGridView__. To learn more about it take a look at the [Programmatic Grouping]({%slug gridview-programmatic-grouping%}) topic.

If you want to implement multi-column grouping you just have to define __GroupDescriptor__or__ColumnGroupDescriptor__ objects for the desired grouping criteria and add them to the __GroupDescriptors__ collection. It can be done at design time:

#### __XAML__

{{region gridview-multiple-column-grouping_0}}
	<telerik:RadGridView x:Name="radGridView"
	                        AutoGenerateColumns="False">
	   <telerik:RadGridView.GroupDescriptors>
	       <telerik:GroupDescriptor Member="Country"
	                                    SortDirection="Ascending" />
	       <telerik:GroupDescriptor Member="Title"
	                                    SortDirection="Ascending" />
	   </telerik:RadGridView.GroupDescriptors>
	</telerik:RadGridView>
	{{endregion}}



This can be done at run time via managed code too:

#### __C#__

{{region gridview-multiple-column-grouping_1}}
	GroupDescriptor countryDescriptor = new GroupDescriptor();
	countryDescriptor.Member = "Country";
	countryDescriptor.SortDirection = ListSortDirection.Ascending;
	this.radGridView.GroupDescriptors.Add( countryDescriptor );
	GroupDescriptor titleDescriptor = new GroupDescriptor();
	titleDescriptor.Member = "Title";
	titleDescriptor.SortDirection = ListSortDirection.Ascending;
	this.radGridView.GroupDescriptors.Add( titleDescriptor );
	{{endregion}}



#### __VB.NET__

{{region gridview-multiple-column-grouping_2}}
	Dim countryDescriptor As New GroupDescriptor()
	countryDescriptor.Member = "Country"
	countryDescriptor.SortDirection = ListSortDirection.Ascending
	Me.radGridView.GroupDescriptors.Add(countryDescriptor)
	Dim titleDescriptor As New GroupDescriptor()
	titleDescriptor.Member = "Title"
	titleDescriptor.SortDirection = ListSortDirection.Ascending
	Me.radGridView.GroupDescriptors.Add(titleDescriptor)
	{{endregion}}



The result is the same as if the user has dragged and dropped the desired columns into the grouping area:

__![](images/RadGridView_MultiColumnGrouping_1.png)__

# See Also

 * [Basic Grouping]({%slug gridview-grouping-basics%})

 * [Programmatic Grouping]({%slug gridview-programmatic-grouping%})

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})

 * [Group Footers]({%slug gridview-group-footers%})

 * [Modifying the Group Panel]({%slug gridview-modifying-group-panel%})
