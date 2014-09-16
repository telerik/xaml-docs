---
title: Programmatic Grouping
page_title: Programmatic Grouping
description: Programmatic Grouping
slug: gridview-programmatic-grouping
tags: programmatic,grouping
publish: True
position: 2
---

# Programmatic Grouping



## 

Besides the built-in grouping functionality you are able to use a programmatic approach to group the data in the __RadGridView__. This is achieved via the __GroupDescriptors__ property of the __RadGridView__. This collection of __IGroupDescriptor__ objects allows you to use descriptors (GroupDescriptors or ColumnGroupDescriptors) which define the grouping criteria and the group's sorting direction for the data that is bound to the __RadGridView__. As this is a collection you are able not only to add, but to remove or clear the entries in it too.

When you add a new descriptor to the collection, the data is automatically grouped according it. To learn how to create and configure descriptors take a look at the following example.

#### __C#__

{{region gridview-programmatic-grouping_0}}
	GroupDescriptor descriptor = new GroupDescriptor();
	descriptor.Member = "Country";
	descriptor.SortDirection = ListSortDirection.Ascending;
	{{endregion}}



#### __VB.NET__

{{region gridview-programmatic-grouping_1}}
	Dim descriptor As New GroupDescriptor()
	descriptor.Member = "Country"
	descriptor.SortDirection = ListSortDirection.Ascending
	{{endregion}}



The __Member__ property defines the property, by which the data will be grouped, and the __SortDirection__ property allows you to define the direction by which the groups will be sorted.

And now you can create a descriptor:

#### __XAML__

{{region gridview-programmatic-grouping_2}}
	<telerik:GroupDescriptor Member="Country"
	                             SortDirection="Ascending" />
	{{endregion}}



To use the created descriptor to sort the data in the __RadGridView__ you have to add it to the __GroupDescriptors__ collection.

#### __XAML__

{{region gridview-programmatic-grouping_3}}
	<telerik:RadGridView x:Name="radGridView"
	                         AutoGenerateColumns="False">
	    <telerik:RadGridView.GroupDescriptors>
	        <telerik:GroupDescriptor Member="Country"
	                                     SortDirection="Ascending" />
	    </telerik:RadGridView.GroupDescriptors>
	    ...
	</telerik:RadGridView>.
	{{endregion}}



#### __C#__

{{region gridview-programmatic-grouping_4}}
	this.radGridView.GroupDescriptors.Add( descriptor );
	{{endregion}}



#### __VB.NET__

{{region gridview-programmatic-grouping_5}}
	Me.radGridView.GroupDescriptors.Add(descriptor)
	{{endregion}}



After the application is run with this descriptor defined, the __RadGridView__ data will be grouped by the __Country__ property and will look as if you have dragged and dropped the __Country__ column into the grouping area.

Except the __Member__ and the __SortDirection__ properties, the __GroupDescriptor__ exposes two more. The __DisplayContent__ property allows you to change the content of the rectangle representing the group that appears in the grouping area.

#### __XAML__

{{region gridview-programmatic-grouping_6}}
	<telerik:GroupDescriptor Member="Country"
	                             SortDirection="Ascending"
	                             DisplayContent="Country Group" />
	{{endregion}}



#### __C#__

{{region gridview-programmatic-grouping_7}}
	GroupDescriptor descriptor = new GroupDescriptor();
	descriptor.Member = "Country";
	descriptor.SortDirection = ListSortDirection.Ascending;
	descriptor.DisplayContent = "Country Group";
	{{endregion}}



#### __VB.NET__

{{region gridview-programmatic-grouping_8}}
	Dim descriptor As New GroupDescriptor()
	descriptor.Member = "Country"
	descriptor.SortDirection = ListSortDirection.Ascending
	descriptor.DisplayContent = "Country Group"
	{{endregion}}



![](images/RadGridView_ProgrammaticGrouping_1.png)

>tipIn the group rows you are able to display aggregate functions, which display information about the data contained in the group. To learn more about how to add aggregate functions to the group rows take a look at the [Group Aggregates]({%slug gridview-grouping-aggregates%}) topic.

An alternative way of manipulating the group descriptors of RadGridView is the new (added in Q3 2010) __ColumnGroupDescriptor__ class. It has three important properties:

* __Column__ - the column that will be grouped
            

* __DisplayContent__ - allows you to change the content of the rectangle representing the group that appears in the grouping area.
            

* __SortDirection__ - allows you to define the direction by which the groups will be sorted
            

As you see the last two properties are similar to the same properties of the GroupDescriptor class. 

>As of __Q3 2011__ you can add the __ColumnGroupDescriptor__ both in the __code behind and XAML__. With all the prior versions you can only set it in code behind.

Here is a code snippet which adds a ColumnGroupDescriptor to RadGridView which groups by the Name column in descending order:

#### __XAML__

{{region gridview-programmatic-grouping_11}}
	<telerik:ColumnGroupDescriptor Column="{Binding Columns[\Name\], ElementName=clubsGrid}"
	                             SortDirection="Descending"  />
	{{endregion}}



#### __C#__

{{region gridview-programmatic-grouping_9}}
	this.clubsGrid.GroupDescriptors.Add(new ColumnGroupDescriptor() 
	{ 
	 Column = this.clubsGrid.Columns["Name"],
	 SortDirection = ListSortDirection.Descending
	});
	{{endregion}}



#### __VB.NET__

{{region gridview-programmatic-grouping_10}}
	Me.clubsGrid.GroupDescriptors.Add(New ColumnGroupDescriptor() With { _
	 .Column = Me.clubsGrid.Columns("Name"), _
	 .SortDirection = ListSortDirection.Descending _
	})
	{{endregion}}



# See Also

 * [Basic Grouping]({%slug gridview-grouping-basics%})

 * [Grouping events]({%slug gridview-events-grouping%})

 * [Multiple-column Grouping]({%slug gridview-multiple-column-grouping%})

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})

 * [Group Footers]({%slug gridview-group-footers%})

 * [Modifying the Group Panel]({%slug gridview-modifying-group-panel%})
