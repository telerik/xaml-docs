---
title: Programmatic Grouping
page_title: Programmatic Grouping
description: Read this article to learn how to programmatically group Telerik's {{ site.framework_name }} DataGrid by adding group descriptors to the control's GroupDescriptors collection.
slug: gridview-programmatic-grouping
tags: programmatic,grouping
published: True
position: 2
---

# Programmatic Grouping

Besides the built-in grouping functionality you are able to use a programmatic approach to group the data in __RadGridView__. This is achieved via the control's __GroupDescriptors__ collection. This collection of __IGroupDescriptor__ objects allows you to use descriptors (__GroupDescriptor__ or __ColumnGroupDescriptor__) to define grouping criteria and group's sorting direction for the bound data. 

>The **GroupDescriptorsCollection** is an **ObservableItemCollection** which means you can not only add, but also remove descriptors from it as well as clear the collection.

This article will describe two implementations of the IGroupDescriptor interface.

* [GroupDescriptor](#groupdescriptor)
* [ColumnGroupDescriptor](#columngroupdescriptor)
* [Expanding and collapsing a group](#expanding-and-collapsing-a-group)
* [Check if a group is expanded](#check-if-a-group-is-expanded)

## GroupDescriptor

When you add a new descriptor to the collection, RadGridView's data is automatically grouped according it. **Example 1** demonstrates how to create and configure group descriptors.

__Example 1: Initiate and configure group descriptors__

<snippet id='radgridview-grouping-programmatic-grouping-example_1_initiate_and_configure_group_descriptors-cs' />

<snippet id='radgridview-grouping-programmatic-grouping-example_1_initiate_and_configure_group_descriptors-vb' />


The __Member__ property defines the property, by which the data will be grouped, and the __SortDirection__ property allows you to define the direction in which the groups will be sorted.

**Example 2** illustrates how to create the group descriptor in XAML.

__Example 2: Define group descriptors in XAML__

<snippet id='radgridview-grouping-programmatic-grouping-example_2_define_group_descriptors_in_xaml-xaml' />


To use the created descriptor to group the data in the __RadGridView__ you have to add it to the __GroupDescriptors__ collection.

__Example 3: Add descriptor to GroupDescriptors collection__

<snippet id='radgridview-grouping-programmatic-grouping-example_3_add_descriptor_to_groupdescriptors_collection-xaml' />


__Example 3: Add descriptor to GroupDescriptors collection__

<snippet id='radgridview-grouping-programmatic-grouping-example_3_add_descriptor_to_groupdescriptors_collection-cs' />

<snippet id='radgridview-grouping-programmatic-grouping-example_3_add_descriptor_to_groupdescriptors_collection-vb' />


After the descriptor is defined, the data will be grouped by the __Country__ property and will look as if you have dragged and dropped the __Country__ column header into the grouping area.

Except __Member__ and __SortDirection__ properties, the __GroupDescriptor__ exposes a __DisplayContent__ property which allows you to change the content of the rectangle representing the group in the grouping area.

__Example 4: Set the DisplayContent property__

<snippet id='radgridview-grouping-programmatic-grouping-example_4_set_the_displaycontent_property-xaml' />


__Example 4: Set the DisplayContent property__

<snippet id='radgridview-grouping-programmatic-grouping-example_4_set_the_displaycontent_property-cs' />

<snippet id='radgridview-grouping-programmatic-grouping-example_4_set_the_displaycontent_property-vb' />


#### Figure 1: The box displayed in the group panel after the DisplayContent is set

![Telerik UI for {{ site.framework_name }} RadGridView group panel showing a programmatic GroupDescriptor with custom display content](images/RadGridView_ProgrammaticGrouping_1.png)

>tip In the group rows you are able to display aggregate functions, which display information about the data contained in the group. To learn more about how to add aggregate functions to the group rows take a look at the [Group Aggregates]({%slug gridview-grouping-aggregates%}) topic.

## ColumnGroupDescriptor

An alternative way of manipulating the group descriptors of RadGridView is the new (added in Q3 2010) __ColumnGroupDescriptor__ class. It has three important properties:

* __Column__: The column that will be grouped.
            
* __DisplayContent__: Allows you to change the content of the rectangle representing the group that appears in the grouping area.
            
* __SortDirection__: Allows you to define the direction in which the groups will be sorted.

As you see the last two properties are similar to the same properties of the GroupDescriptor class. 

> As of __Q3 2011__ you can add a __ColumnGroupDescriptor__ both in __code behind and XAML__. With all the prior versions you can only set it in code behind.

**Example 5** shows how to add a ColumnGroupDescriptor to RadGridView which groups by the Name column in descending order.

__Example 5: Add ColumnGroupDescriptor to RadGridView__

<snippet id='radgridview-grouping-programmatic-grouping-example_5_add_columngroupdescriptor_to_radgridview-xaml' />


__Example 5: Add ColumnGroupDescriptor to RadGridView__

<snippet id='radgridview-grouping-programmatic-grouping-example_5_add_columngroupdescriptor_to_radgridview-cs' />

<snippet id='radgridview-grouping-programmatic-grouping-example_5_add_columngroupdescriptor_to_radgridview-vb' />


## Expanding and Collapsing a Group

The groups of the control can be programmatically expanded and collapsed through the __ExpandGroup__ and __CollapseGroup__ methods of the control. Passing a group to them can be achieved by type casting a given group to the [IGroup](https://docs.telerik.com/devtools/wpf/api/telerik.windows.data.igroup) interface. The following example demonstrates how the __ExpandGroup__ method can be called. The __CollapseGroup__ one can be used in the same manner.

__Example 6: Call the ExpandGroup method of RadGridView__

<snippet id='radgridview-grouping-programmatic-grouping-example_6_call_the_expandgroup_method_of_radgridview-cs' />

<snippet id='radgridview-grouping-programmatic-grouping-example_6_call_the_expandgroup_method_of_radgridview-vb' />


## Check if a group is expanded

>The __IsExpanded__ method can also be used to check whether a hierarchy item is expanded. More information can be found in the [Basic Hierarchies]({%slug gridview-basic-hierarchies%}) topic.

When checking whether a given group is expanded, the __IsExpanded__ method of __RadGridView__ comes in handy. When a group is passed as a parameter to it, it will return a boolean value determining whether the group is expanded or not.

__Example 7: Call the IsExpanded method of RadGridView__

<snippet id='radgridview-grouping-programmatic-grouping-example_7_call_the_isexpanded_method_of_radgridview-cs' />

<snippet id='radgridview-grouping-programmatic-grouping-example_7_call_the_isexpanded_method_of_radgridview-vb' />


## See Also

 * [Basic Grouping]({%slug gridview-grouping-basics%})
 * [Grouping Modes]({%slug gridview-grouping-groupingmodes%})
 * [Grouping events]({%slug gridview-events-grouping%})
 * [Multiple-column Grouping]({%slug gridview-multiple-column-grouping%})
 * [Group Aggregates]({%slug gridview-grouping-aggregates%})
 * [Group Footers]({%slug gridview-group-footers%})
 * [Modifying the Group Panel]({%slug gridview-modifying-group-panel%})
