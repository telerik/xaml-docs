---
title: Change the Default Height of a TreeViewItem
page_title: Change the Default Height of a TreeViewItem
description: Change the Default Height of a TreeViewItem
slug: radtreeview-how-to-change-default-height-treeviewitem
tags: change,the,default,height,of,a,treeviewitem
published: True
position: 8
---

# Change the Default Height of a TreeViewItem

This tutorial will show you how to change the __default height__ of a treeview.

Here is a simple treeview declaration: 

#### __XAML__

{{region radtreeview-how-to-change-default-height-treeviewitem_0}}
	<telerik:RadTreeView>
	    <telerik:RadTreeViewItem Header="Sport Categories">
	        <telerik:RadTreeViewItem Header="Football">
	            <telerik:RadTreeViewItem Header="Futsal"/>
	            <telerik:RadTreeViewItem Header="Soccer"/>
	        </telerik:RadTreeViewItem>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
	{{endregion}}

![](images/RadTreeView_HowToChangeDefaultHeight_001.png)

In order to change the default height of the treeview item, you need to perform the following steps:

1. Add an appropriate style in the resources: 

	#### __XAML__

	{{region radtreeview-how-to-change-default-height-treeviewitem_1}}
		<Style TargetType="telerik:RadTreeViewItem" x:Key="TreeViewItemStyle">
			<Setter Property="MinHeight" Value="50"></Setter>
		</Style>
		{{endregion}}

2. Set the __ItemContainerStyle__ of the __RadTreeView__ and the __RadTreeViewItem__. 

	#### __XAML__

	{{region radtreeview-how-to-change-default-height-treeviewitem_2}}
		<telerik:RadTreeView ItemContainerStyle="{StaticResource TreeViewItemStyle}">
			<telerik:RadTreeViewItem Header="Sport Categories" ItemContainerStyle="{StaticResource TreeViewItemStyle}">
				<telerik:RadTreeViewItem Header="Football" ItemContainerStyle="{StaticResource TreeViewItemStyle}">
					<telerik:RadTreeViewItem Header="Futsal" ItemContainerStyle="{StaticResource TreeViewItemStyle}"/>
					<telerik:RadTreeViewItem Header="Soccer" ItemContainerStyle="{StaticResource TreeViewItemStyle}"/>
				</telerik:RadTreeViewItem>
			</telerik:RadTreeViewItem>
		</telerik:RadTreeView>
		{{endregion}}

And here is the result: 
![](images/RadTreeView_HowToChangeDefaultHeight_010.png)

# See Also
 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
 * [Hierarchical Data Templates]({%slug radtreeview-populating-with-data-hierarchical-data-templates%})