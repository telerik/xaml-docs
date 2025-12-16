---
title: Grouping
page_title: Grouping
description: Learn how you can easily group data by one or more columns by dragging the desired column to the GroupPanel of RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-overview-grouping
tags: grouping
published: True
position: 3
---

# Grouping

__RadGridView__ provides you with a built-in grouping functionality, which allows the user to easily group the data by one or more columns. To do so the user has to just drag the desired column to the __GridViewGroupPanel__, located at the top of the __RadGridView__. If __RadGridView__ is not grouped, the __GridViewGroupPanel__ shows a customizable hint.

#### **Figure 1: Grouped RadGridView**

![Telerik {{ site.framework_name }} DataGrid Functional Overview Grouping 1](images/RadGridView_FunctionalOverview_Grouping_1.png)

You can define grouping either in the XAML or in the code-behind.

__Example 1: Grouping applied through XAML__

```XAML
	<telerik:RadGridView x:Name="radGridView"
	                AutoGenerateColumns="False">
	    <telerik:RadGridView.GroupDescriptors>
	        <telerik:GroupDescriptor Member="Country"
	                            SortDirection="Ascending" />
	        <!--You can add more group descriptors here-->
	    </telerik:RadGridView.GroupDescriptors>
	</telerik:RadGridView>
```

You can achieve the same result if you define your grouping in the code-behind like this:

__Example 1: Grouping applied programmatically__

```C#
	GroupDescriptor descriptor = new GroupDescriptor();
	descriptor.Member = "Country";
	descriptor.SortDirection = ListSortDirection.Ascending;
	descriptor.DisplayContent = "Country Group";
	this.radGridView.GroupDescriptors.Add(descriptor);
	//You can create and add more descriptors here
```
```VB.NET
	Dim descriptor As New GroupDescriptor()
	descriptor.Member = "Country"
	descriptor.SortDirection = ListSortDirection.Ascending
	descriptor.DisplayContent = "Country Group"
	Me.radGridView.GroupDescriptors.Add(descriptor)
	'You can create and add more descriptors here
```


>Тhe __GroupDescriptors__ property of RadGridView is a __collection__ so you can add more than one __GroupDescriptor__ to a certain __RadGridView__.

>tip Consider using the code-behind approach only when changing the grouping criteria __run-time__.

Check out the chapters entirely dedicated to the grouping functionality of __RadGridView__ and find the answers to the following questions:

* How does the [basic grouping]({%slug gridview-grouping-basics%}) work.

* How to [define grouping]({%slug gridview-programmatic-grouping%}) using __GroupDescriptors__ in both XAML and code-behind.

* How to configure [Grouping Modes]({%slug gridview-grouping-groupingmodes%}).

* How to use the exposed [grouping events]({%slug gridview-grouping-basics%}).

* How to [disable]({%slug gridview-grouping-basics%}) the default grouping per column or for the whole __RadGridView__ control.

* How to [modify the group panel]({%slug gridview-modifying-group-panel%}).

* How to group your data by [multiple-columns]({%slug gridview-multiple-column-grouping%}).

* How to [style the group rows]({%slug gridview-styling-group-row%}).

* How to define [aggregate functions]({%slug gridview-grouping-aggregates%}) to the group rows.

* How to use the [group footers]({%slug gridview-group-footers%}).

## See Also
 
 * [Filtering]({%slug gridview-overview-filtering%})

 * [Data Selection]({%slug gridview-overview-data-selection%})

 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
