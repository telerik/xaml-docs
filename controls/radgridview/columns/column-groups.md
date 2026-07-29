---
title: Column Groups
page_title: Column Groups
description: Learn how to combine grid columns in column groups visually represented by common headers when using RadGridView - Telerik's {{ site.framework_name }} DataGrid. 
slug: gridview-column-groups
tags: merged,column, headers, groups
published: True
position: 6
---

# Column Groups

Columns in RadGridView may be grouped in __column groups__ visually represented by common column headers.
        
## Define Column Groups

To enable __column grouping__ you need to add **GridViewColumnGroup** instances to RadGridView's **ColumnGroups** collection as illustrated in **Example 1**.
     
__Example 1: Define column groups__

<snippet id='radgridview-columns-column-groups-example_1_define_column_groups-xaml' />


#### Figure 1: RadGridView with Column Groups

![Telerik UI for {{ site.framework_name }} RadGridView column groups with shared Vehicle info and Dimensions headers](images/RadGridView_ColumnHeaders_7.png)

Please observe that to add a specific column to a certain column group, you need to set the __ColumnGroupName__ property of the column to match the value of the __Name__ property of the relevant __GridViewColumnGroup__.

Note also that the __GridViewColumnGroup__ class has a __Header__ property which defines the content to be shown inside the common header. It may be a simple string or a visual element. 

>tip In case that no header is specified the **Name** of the __GridViewColumnGroup__ will be displayed.

## Nested Column Groups

Column groups can also be __nested__. **Example 2** shows how this is achieved.
 
__Example 2: Nested column groups__

<snippet id='radgridview-columns-column-groups-example_2_nested_column_groups-xaml' />


#### Figure 2: Nested column groups

![Telerik UI for {{ site.framework_name }} RadGridView nested column groups under a shared Data header](images/RadGridView_ColumnHeaders_8.png)

## Define Custom Header

You can define a __custom header__ for the __GridViewColumnGroup__ through its **HeaderTemplate**.

__Example 3: Define GridViewColumnGroup.HeaderTemplate__

<snippet id='radgridview-columns-column-groups-example_3_define_gridviewcolumngroup_headertemplate-xaml' />


In addition, you can style the headers by defining a style targeting the **CommonColumnHeader** element and setting it as the **HeaderStyle** for the **GridViewColumnGroup**. For information on how to apply an implicit style, have a look at the [Styling Column Groups]({%slug gridview-styling-merged-column-headers%}) article.

## Virtualization Modes

Column groups also support **UI virtualization** meaning that only the visual elements that are loaded in the viewable area are processed. This way, the performance of the control can be significantly enhanced.

This functionality can be configured through the __EnableColumnGroupsVirtualization__ boolean property. Its default value is **True** in which case UI virtualization is enabled.

This mode is especially useful in more complicated scenarios where additional features such as [frozen columns]({%slug gridview-columns-frozen-columns%}), [reordering of columns]({%slug gridview-columns-reordering-columns%}), etc. are used.

>important When the column group virtualization feature is enabled, __column group names should be unique__.

## Add or Remove Multiple Column Groups at Once

As of **R3 2020 SP** the ColumnGroups property is of type [RadObservableCollection]({%slug consuming-data-radobservablecollection%}) which exposes the **AddRange** and **RemoveRange** methods that can be used when adding or removing multiple groups at once in order to improve performance.

__Example 4: Add or remove multiple column groups at once__

<snippet id='radgridview-columns-column-groups-example_4_add_or_remove_multiple_column_groups_at_once-cs' />

<snippet id='radgridview-columns-column-groups-example_4_add_or_remove_multiple_column_groups_at_once-vb' />


An alternative is to use the **SuspendNotifications** and **ResumeNotifications** methods prior and after adding or removing the groups.

__Example 5: Suspend and resume notifications__

<snippet id='radgridview-columns-column-groups-example_5_suspend_and_resume_notifications-cs' />

<snippet id='radgridview-columns-column-groups-example_5_suspend_and_resume_notifications-vb' />


## Specific Scenarios

This section will cover some specific scenarios when using column groups.

For the purpose of this demonstration we will define the following groups.

__Example 6: Sample column groups setup__

<snippet id='radgridview-columns-column-groups-example_6_sample_column_groups_setup-xaml' />


In case the user moves the frozen column splitter in the middle of an existing column group, then it will be __divided into two separate groups__. **Figures 3 to 5** demonstrate this scenario.

#### Figure 3: Initial setup with FrozenColumnSplitter at default position

![Telerik UI for {{ site.framework_name }} RadGridView column groups before moving the frozen column splitter](images/columngroups_frozencolumn_1.png)

#### Figure 4: A duplicate column group is created when FrozenColumnSplitter moved after the first column

![Telerik UI for {{ site.framework_name }} RadGridView column groups split after moving the frozen column splitter past the first column](images/columngroups_frozencolumn_2.png)

#### Figure 5: ColumnGroup's Header is still visible after scrolling to the right

![Telerik UI for {{ site.framework_name }} RadGridView column group header remaining visible during horizontal scrolling](images/columngroups_frozencolumn_3.png)

When scrolling horizontally, the column group header remains visible until there are still visible sub-columns under the specific group.

Defined column groups are now __drawn only if they are specified for at least one visible column__. 

When some GridViewColumns do not have a **ColumnGroupName** specified, they are __placed under an empty ColumnGroup__. This is illustrated in **Figure 6**.

#### Figure 6: Various setups illustrating the default space fill
 
![Telerik UI for {{ site.framework_name }} RadGridView column groups showing default empty group space layout example one](images/columngroups_defaultgroups_1.png)

![Telerik UI for {{ site.framework_name }} RadGridView column groups showing default empty group space layout example two](images/columngroups_defaultgroups_2.png)

![Telerik UI for {{ site.framework_name }} RadGridView column groups showing default empty group space layout example three](images/columngroups_defaultgroups_3.png)

## See Also

* [Styling Column Groups]({%slug gridview-styling-merged-column-headers%})
* [Column Headers]({%slug gridview-columns-column-headers%})
* [Reordering Columns]({%slug gridview-columns-reordering-columns%})
* [Frozen Columns]({%slug gridview-columns-frozen-columns%})
