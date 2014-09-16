---
title: Create Horizontal TreeView
page_title: Create Horizontal TreeView
description: Create Horizontal TreeView
slug: radtreeview-how-to-create-horizontal-treeview
tags: create,horizontal,treeview
publish: True
position: 12
---

# Create Horizontal TreeView



## 

This tutorial will show you how to create a __RadTreeView__ with horizontal orientation.

Here is an ordinary treeview declaration: 

#### __XAML__

{{region radtreeview-how-to-create-horizontal-treeview_0}}
	<telerik:RadTreeView>
	    <telerik:RadTreeViewItem Header="Sport Categories">
	        <telerik:RadTreeViewItem Header="Football">
	            <telerik:RadTreeViewItem Header="Futsal"/>
	            <telerik:RadTreeViewItem Header="Soccer"/>
	        </telerik:RadTreeViewItem>
	        <telerik:RadTreeViewItem Header="Tennis">
	            <telerik:RadTreeViewItem Header="Table Tennis"/>
	        </telerik:RadTreeViewItem>
	        <telerik:RadTreeViewItem Header="Cycling">
	            <telerik:RadTreeViewItem Header="Road Cycling"/>
	            <telerik:RadTreeViewItem Header="Indoor Cycling"/>
	            <telerik:RadTreeViewItem Header="Mountain Bike"/>
	        </telerik:RadTreeViewItem>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
	{{endregion}}



![](images/RadTreeView_HowToCreateHorizontalTreeView_001.PNG)

In order to create a horizontal treeview you need to set the __ItemContainerStyle__property of the __RadTreeView__and the __RadTreeViewItem__.

Declare the following style in the resources of your application. It will set the __ItemsPanel__to a __StackPanel__with __Horizontal__orientation: 

#### __XAML__

{{region radtreeview-how-to-create-horizontal-treeview_1}}
	<Style TargetType="telerik:RadTreeViewItem" x:Key="TreeViewItemStyle">
	    <Setter Property="ItemsPanel">
	        <Setter.Value>
	            <ItemsPanelTemplate>
	                <StackPanel HorizontalAlignment="Center" Margin="4,6" Orientation="Horizontal" />
	            </ItemsPanelTemplate>
	        </Setter.Value>
	    </Setter>
	</Style>
	{{endregion}}



Apply this style to the __ItemContainerStyle__of the treeview and each treeview item. 

#### __XAML__

{{region radtreeview-how-to-create-horizontal-treeview_2}}
	<telerik:RadTreeView ItemContainerStyle="{StaticResource TreeViewItemStyle}">
	    <telerik:RadTreeViewItem Header="Sport Categories" ItemContainerStyle="{StaticResource TreeViewItemStyle}">
	        <telerik:RadTreeViewItem Header="Football" ItemContainerStyle="{StaticResource TreeViewItemStyle}">
	            <telerik:RadTreeViewItem Header="Futsal" ItemContainerStyle="{StaticResource TreeViewItemStyle}"/>
	            <telerik:RadTreeViewItem Header="Soccer" ItemContainerStyle="{StaticResource TreeViewItemStyle}"/>
	        </telerik:RadTreeViewItem>
	        <telerik:RadTreeViewItem Header="Tennis" ItemContainerStyle="{StaticResource TreeViewItemStyle}">
	            <telerik:RadTreeViewItem Header="Table Tennis" ItemContainerStyle="{StaticResource TreeViewItemStyle}"/>
	        </telerik:RadTreeViewItem>
	        <telerik:RadTreeViewItem Header="Cycling" ItemContainerStyle="{StaticResource TreeViewItemStyle}">
	            <telerik:RadTreeViewItem Header="Road Cycling" ItemContainerStyle="{StaticResource TreeViewItemStyle}"/>
	            <telerik:RadTreeViewItem Header="Indoor Cycling" ItemContainerStyle="{StaticResource TreeViewItemStyle}"/>
	            <telerik:RadTreeViewItem Header="Mountain Bike" ItemContainerStyle="{StaticResource TreeViewItemStyle}"/>
	        </telerik:RadTreeViewItem>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
	{{endregion}}



Here is the result: 

![](images/RadTreeView_HowToCreateHorizontalTreeView_010.PNG)

# See Also

 * [Styling the Expander]({%slug radtreeview-styling-and-appearance-styling-expander%})

 * [Templated Nodes]({%slug radtreeview-styles-and-templates-templated-nodes%})

 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
