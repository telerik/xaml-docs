---
title: Column Groups
page_title: Column Groups
description: Column Groups
slug: gridview-column-groups
tags: merged,column, headers, groups
published: True
position: 6
site_name: WPF
---

# Column Groups/Merged column headers

__Columns in RadGridView may be grouped in column groups__ visually presented by common column headers (GridViewColumnGroups). As of version __Q2 2015__ we also introduced [column group virtualization](#virtualization-modes). 

* [Define Column Groups](#define-column-groups)
* [Define Custom Header](#define-custom-header)
* [Virtualization Modes](#virtualization-modes)
* [Styling Column Groups]({%slug gridview-styling-merged-column-headers%})
        
## Define Column Groups

Columns in RadGridView may be grouped in __column groups__(added with __Q3 2011__). Column groups are visually presented by __common column headers__.

To enable __column grouping__ you need to define __RadGridView.ColumnGroups__ as illustrated below.
     
#### __[XAML]Example 1: Definining ColumnGroups and specifying them for columns__
{{region xaml-gridview-columns-column-headers_3}}

	<telerik:RadGridView x:Name="RadGridView1" GridLinesVisibility="Vertical" Width="450" CanUserFreezeColumns="False" AutoGenerateColumns="False" IsFilteringAllowed="False"  ShowGroupPanel="False" RowIndicatorVisibility="Collapsed">
		<telerik:RadGridView.ColumnGroups>
			<telerik:GridViewColumnGroup Name="VehicleInfo" Header="Vehicle info" />
			<telerik:GridViewColumnGroup Name="Dimensions" Header="Dimensions" />
		</telerik:RadGridView.ColumnGroups>
		<telerik:RadGridView.Columns>
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Make}" ColumnGroupName="VehicleInfo" />
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Model}" ColumnGroupName="VehicleInfo" />
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Length}" ColumnGroupName="Dimensions" />
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Width}"  ColumnGroupName="Dimensions" />
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Heigth}" ColumnGroupName="Dimensions" />
		</telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

__Figure 1:__ Column Groups.
![Rad Grid View Column Headers 7](images/RadGridView_ColumnHeaders_7.png)

__GridViewColumnGroup__ has a __Header__ property which defines the content to be shown inside the common header. It may be a simple string or a visual element. 

>tipIn case no Header is specified, its default value is the Name of __GridViewColumnGroup__.

To tell that a specific column belongs to a specific group, you need to set the __ColumnGroupName__ property of the column to match the value of the __Name__ property of the relevant __GridViewColumnGroup__.

For example:

#### __[XAML]Example 2: Specify ColumnGroupName for a column__

{{region xaml-gridview-columns-column-headers_4}}

	<telerik:GridViewColumnGroup  Name="VehicleInfo" Header="Vehicle info" />
	 ...
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Make}" ColumnGroupName="VehicleInfo" />
{{endregion}}

Column groups can be __nested__. They can be defined like so:
 
#### __[XAML]Example 3: Nested ColumnGroups__

{{region xaml-gridview-columns-column-headers_5}}

	<telerik:RadGridView.ColumnGroups>
		<telerik:GridViewColumnGroup  Name="Data" Header="Data">
			<telerik:GridViewColumnGroup  Name="VehicleInfo" Header="Vehicle info" />
			<telerik:GridViewColumnGroup  Name="Dimensions" Header="Dimensions" />
		</telerik:GridViewColumnGroup>
	</telerik:RadGridView.ColumnGroups>
{{endregion}}

__Figure 2:__ Nested ColumnGroups.
![Rad Grid View Column Headers 8](images/RadGridView_ColumnHeaders_8.png)

## Define Custom Header

You can define a __custom header__ for the __GridViewColumnGroup__ through its HeaderTemplate:

#### __[XAML]Example 4: Define GridViewColumnGroup.HeaderTemplate__

{{region xaml-gridview-columns-column-headers_6}}

	<telerik:GridViewColumnGroup Name="Data">
	    <telerik:GridViewColumnGroup.HeaderTemplate>
	        <DataTemplate>
	            <TextBox Text="Data"/>
	        </DataTemplate>
	    </telerik:GridViewColumnGroup.HeaderTemplate>
	</telerik:GridViewColumnGroup>
{{endregion}}

## Virtualization Modes

Based on client feedback, as of version __Q2 2015__ we introduced __column group improvements__. They include column groups virtualization. The default mode enables __container recycling for a better performance__ results. 

It can be configured through setting RadGridView.__EnableColumnGroupsVirtualization__ property: 
* __True__ (default) – enables horizontal container recycling 
* __False__ – there is no virtualization logic

This mode is especially useful when there is some more complicated usage of column groups including additional features as [Frozen Column]({%slug gridview-columns-frozen-columns%}), [reordering of columns]({%slug gridview-columns-reordering-columns%}), etc.

>When the column group virtualization is enabled, the __Name should be unique__.

With the new virtualization mode, we can also offer a __better visual representation__. 

For the purpose of demonstration, let's define more illustrative Names:
#### __[XAML]Example 5: Sample ColumnGroups setup__
	<telerik:RadGridView.ColumnGroups>			
		<telerik:GridViewColumnGroup Name="Level2group1">
			<telerik:GridViewColumnGroup Name="Level1group11"/>
			<telerik:GridViewColumnGroup Name="Level1group12"/>
		</telerik:GridViewColumnGroup>
		<telerik:GridViewColumnGroup Name="Level2group2">
			<telerik:GridViewColumnGroup Name="Level1group21"/>
			<telerik:GridViewColumnGroup Name="Level1group22"/>
		</telerik:GridViewColumnGroup>
	</telerik:RadGridView.ColumnGroups>

* In case the user moves the frozen column splitter in a middle of an existing ColumnGroup, then it will be __divided into two separate ColumnGroups__. That way the user can still have __visual representation on the second part when scrolling horizontally__. 

__Figure 3:__ Initial setup with FrozenColumnSplitter at default position.
![Initial setup with FrozenColumnSplitter](images/columngroups_frozencolumn_1.png)

__Figure 4:__ FrozenColumnSplitter moved after first column and a duplicate ColumnGroup is created.
![FrozenColumnSplitter moved after first column](images/columngroups_frozencolumn_2.png)

__Figure 5:__ ColumnGroup's Header is still visible after scrolling to the right.
![FrozenColumnSplitter moved after first column](images/columngroups_frozencolumn_3.png)

* On __scrolling horizontally__, the ColumnGroup header remains visible until there are still visible sub-columns under the specific group. You can refer to Figure 3 above. 

* Defined ColumnGroups are now __drawn only if they are specified for at least one column__. 

* When not all GridViewColumns are configured with ColumnGroupName, then the independent ones are __placed under one common empty ColumnGroup__.

__Figure 6:__ Various setups illustrating the default space fill.
 
![Nested groups and Default space fill](images/columngroups_defaultgroups_1.png)

![Nested groups and Default space fill](images/columngroups_defaultgroups_2.png)

![Nested groups and Default space fill](images/columngroups_defaultgroups_3.png)

