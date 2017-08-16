---
title: UI Virtualization
page_title: UI Virtualization
description: UI Virtualization
slug: radtreeview-features-ui-virtualization
tags: ui,virtualization
published: True
position: 9
---

# UI Virtualization

The __RadTreeView__ API supports __UI Virtualization__, which processes only information loaded in the viewable area, which reduces the memory footprint of the application and speeds up the loading time thus enhancing additionally the UI performance.

> The standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.

>The default __ItemsPanel__ for the __RadTreeView__ is __TreeViewPanel__. The __TreeViewPanel__ derives from __VirtualizingPanel__. It calculates the number of visible items and works with the __ItemContainerGenerator__ from an __ItemsControl__ (such as TreeView) to create UI elements only for visible items.

The following tutorial shows how to bind to a collection of business objects and virtualize the items displayed in a __RadTreeView__ element using the __IsVirtualizing__ property.

Here is a simple __RadTreeView__ declaration.

#### __XAML__

{{region radtreeview-features-ui-virtualization_0}}
	<UserControl.Resources>
	
	    <sampleData:RadTreeViewSampleData x:Key="DataSource"/>
	
	    <DataTemplate x:Key="TeamDataTemplate">
	        <TextBlock Text="{Binding Name}"/>
	    </DataTemplate>
	
	</UserControl.Resources>
	
	<Grid x:Name="LayoutRoot" Background="White">
	
	    <telerik:RadTreeView x:Name="radTreeView">            
	        <telerik:RadTreeViewItem Header="League A">
	
	            <telerik:RadTreeViewItem Header="Teams" 
	                ItemsSource="{Binding Source={StaticResource DataSource}, Path=VeryLargeDataSource}"
	                ItemTemplate="{StaticResource TeamDataTemplate}"/>
	
	        </telerik:RadTreeViewItem>
	    </telerik:RadTreeView>
	
	</Grid>
	{{endregion}}

The __RadTreeViewItem__ with __Header__ "Teams" is bound to a collection with 10000 __Team__ objects. By default the __IsVirtualizing__ property is set to __False__. Which means that when you try to expand the "Teams" node, it will take a few minutes in order the containers to be generated. That will freeze your application.

In this case you need to use the __UI Virtualization__ behavior of the __RadTreeView__. 

## Enable UI Virtualization

In order to enable the UI Virtualization behavior, you should set the __IsVirtualizing__ property of the __RadTreeView__ to __True__. See the example below:

#### __XAML__

{{region radtreeview-features-ui-virtualization_1}}
	<telerik:RadTreeView x:Name="radTreeView" IsVirtualizing="True">
	{{endregion}}

Now when you try to expand the "Teams" node, then only those elements that might be on the screen will be generated.

>tip When the __RadTreeView__'s __IsVirtualizing__ property is set to __False__, then all items within an expanded level are created. The performance may not be as bad if there is a deep hierarchy and all items are initially collapsed. Around 200 expanded items may run smooth.

>Note that internally the __IsVirtualizing__ property sets the __TreeViewPanel.IsVirtualizing__ attached property. In the previous example setting the __IsVirtualizing__ property can be replaced with the following initialization:	
`<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True">`

>Where the __telerikTreeView__ alias points to the __Telerik.Windows.Controls.TreeView__ namespace in the __Telerik.Windows.Controls.Navigation__ assembly.

## Setting the VirtualizationMode

When you want to specify the method the __TreeViewPanel__ uses to manage virtualizing its child items, then you should set the __VirtualizationMode__ property of the __TreeViewPanel__.

The __VirtualizationMode__ property is a __VirtualizationMode__ enumeration which may accept the following values:

## VirtualizationMode.Standard

When you use __VirtualizationMode__.__Standard__, then items that are out of view and are not expanded will be virtualized. Additionally, no container caching or reuse is done. This mode is suited for long lists with little jagging and little scrolling/searching. It consumes less memory at expense of CPU. Expanding and scrolling through a heavily indented hierarchy will mean that little items will be virtualized since most of them will be expanded.

#### __XAML__

{{region radtreeview-features-ui-virtualization_2}}
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.VirtualizationMode="Standard">
	{{endregion}}



## VirtualizationMode.Recycling

When you use __VirtualizationMode__.__Recycling__, then items that are out of view and are not expanded will be virtualized. Additionally, containers are cached and reused at __ItemsControl__ level. The container cache is cleared after 3 seconds of inactivity. This mode is suited for long lists with little jagging. Scrolling longer lists is very fast. It consumes more memory at expense of CPU. Expanding and scrolling though a heavily indented hierarchy will mean little items will be virtualized since most of them will be expanded.

#### __XAML__

{{region radtreeview-features-ui-virtualization_3}}
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.VirtualizationMode="Recycling">
	{{endregion}}

## VirtualizationMode.Hierarchical

When you use __VirtualizationMode__.__Hierarchical__, then items that are out of view will be virtualized. Expanded items are also virtualized. Containers are cached and reused at TreeView level. This mode is suited for indented hierarchies and fully expanded trees. Scrolling may be slower in longer lists (collapsed trees) but faster when the tree is expanded. Expanding and scrolling through a long heavily indented hierarchy should be fast.

#### __XAML__

{{region radtreeview-features-ui-virtualization_4}}
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.VirtualizationMode="Hierarchical">
	{{endregion}}



> By default, a __TreeViewPanel__ creates an item container for each visible item and discards it when it is no longer needed (such as when the item is scrolled out of view). When an ItemsControl contains a many items, the process of creating and discarding item containers can negatively affect performance. 

>When __VirtualizationMode__ is set to __Recycling__, the __TreeViewPanel__ reuses item containers instead of creating a new one each time. When __TreeViewPanel__ cannot recycle item containers, it uses the standard mode of virtualization, which is to create and discard item containers for each item. The following list describes the cases when the __TreeViewPanel__ cannot recycle item containers:

> - The __ItemsControl__ contains item containers of different types. 
> - You explicitly create the item containers for the __ItemsControl__.

<!-- -->
>When the __IsVirtualizing__ is set to __True__, the __ChildDefaultLength__ property can be set to the expected header size of the __TreeViewItems__ if it will be different than the default __MinHeight__ of 24 for the __TreeViewItems__.

## See Also
 * [Load on Demand]({%slug radtreeview-features-load-on-demand%})
 * [Data Binding]({%slug radtreeview-features-data-binding%})
 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
