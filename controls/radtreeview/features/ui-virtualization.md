---
title: UI Virtualization
page_title: UI Virtualization
description: This article will go through the UI Virtualization mechanism of the RadTreeView.
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

__Example 1__ demonstrates a simple __RadTreeView__ declaration. You can find __RadTreeViewSampleData__ custom class implementation in the [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%}) help article.

#### __[XAML] Example 1: Bind RadTreeView to large number of items__

{{region radtreeview-features-ui-virtualization_0}}
	<UserControl.Resources>	
	    <sampleData:RadTreeViewSampleData x:Key="DataSource"/>	
	    <DataTemplate x:Key="TeamDataTemplate">
	        <TextBlock Text="{Binding Name}"/>
	    </DataTemplate>	
	</UserControl.Resources>
	
	<Grid x:Name="LayoutRoot">	
	    <telerik:RadTreeView x:Name="radTreeView" ItemsSource="{Binding Source={StaticResource DataSource}, Path=VeryLargeDataSource}"
	                ItemTemplate="{StaticResource TeamDataTemplate}">
	    </telerik:RadTreeView>	
	</Grid>
{{endregion}}

The __RadTreeView__ is bound to a collection with 10000 __Team__ objects. By default the __IsVirtualizing__ property is set to __False__. Which means that when you try to expand the "Teams" node, it will take a few minutes in order the containers to be generated. That will freeze your application.

In this case you need to use the __UI Virtualization__ behavior of the __RadTreeView__. 

## Enable UI Virtualization

In order to enable the UI Virtualization behavior, you should set the __IsVirtualizing__ property of the __RadTreeView__ to __True__. See the example below:

>When the __IsVirtualizing__ proeprty is set to __True__, the __ChildDefaultLength__ property can be set to the expected header size of the __TreeViewItems__ if it will be different than the default __MinHeight__ of 24 for the __TreeViewItems__.

<!-- -->

> Do not place __RadTreeView__ in controls/panels which will measure it with infinity as this will disable the __UI Virtualization__. For example, __ScrollViewer__, __StackPanel__ and __Grid__ with __Row.Height=Auto__ or __Column.Width=Auto__ will measure it in that way. You can place it in RowDefinition with Height="*" instead. 

#### __[XAML] Example 2: Set IsVirtualizing property__

{{region radtreeview-features-ui-virtualization_1}}
	<telerik:RadTreeView x:Name="radTreeView" IsVirtualizing="True">
{{endregion}}

Now when you try to expand the first node, then only those elements that will be on the screen will be generated.

>tip When the __RadTreeView__'s __IsVirtualizing__ property is set to __False__, then all items within an expanded level are created. The performance may not be as bad if there is a deep hierarchy and all items are initially collapsed. Around 200 expanded items may run smooth.

>Note that internally the __IsVirtualizing__ property sets the __TreeViewPanel.IsVirtualizing__ attached property. In the previous example setting the __IsVirtualizing__ property can be replaced with the following initialization:	
`<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True">`

>Where the __telerikTreeView__ alias points to the __Telerik.Windows.Controls.TreeView__ namespace in the __Telerik.Windows.Controls.Navigation__ assembly.

## Setting the TreeVirtualizationMode

When you want to specify the method the __TreeViewPanel__ uses to manage virtualizing its child items, then you should set the __TreeVirtualizationMode__ property of the __TreeViewPanel__.

The __TreeVirtualizationMode__ property is a __VirtualizationMode__ enumeration which may accept the following values:

> In some version of Visual Studio MS XAML Parser could throw a 'Ambiguous match found.' error in the output when the __VirtualizationMode__ property is used. This error comes from the fact that __TreeViewPanel__ inherits from the MS VirtualizingPanel which in .Net4.5 exposes that same property which is hiding an inheritance property. The XAML Parser is designed to work in that way so we have introduced another attached property which is doing the same thing. We suggest to use the telerik:TreeViewPanel.TreeVirtualizationMode property instead.

## TreeVirtualizationMode.Standard

When you use __VirtualizationMode__.__Standard__, then items that are out of view and are not expanded will be virtualized. Additionally, no container caching or reuse is done. This mode is suited for long lists with little jagging and little scrolling/searching. It consumes less memory at expense of CPU. Expanding and scrolling through a heavily indented hierarchy will mean that little items will be virtualized since most of them will be expanded.

#### __[XAML] Example 3: Setting Standard virtualization mode__

{{region radtreeview-features-ui-virtualization_2}}
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.TreeVirtualizationMode="Standard">
	{{endregion}}

## TreeVirtualizationMode.Recycling

When you use __VirtualizationMode__.__Recycling__, then items that are out of view and are not expanded will be virtualized. Additionally, containers are cached and reused at __ItemsControl__ level. The container cache is cleared after 3 seconds of inactivity. This mode is suited for long lists with little jagging. Scrolling longer lists is very fast. It consumes more memory at expense of CPU. Expanding and scrolling though a heavily indented hierarchy will mean little items will be virtualized since most of them will be expanded.

#### __[XAML] Example 4: Setting Recycling virtualization mode__

{{region radtreeview-features-ui-virtualization_3}}
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.TreeVirtualizationMode="Recycling">
{{endregion}}

## TreeVirtualizationMode.Hierarchical

When you use __VirtualizationMode__.__Hierarchical__, then items that are out of view will be virtualized. Expanded items are also virtualized. Containers are cached and reused at TreeView level. This mode is suited for indented hierarchies and fully expanded trees. Scrolling may be slower in longer lists (collapsed trees) but faster when the tree is expanded. Expanding and scrolling through a long heavily indented hierarchy should be fast.

#### __[XAML] Example 5: Setting Hierarchical virtualization mode__

{{region radtreeview-features-ui-virtualization_4}}
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.VirtualizationMode="Hierarchical">
{{endregion}}

> By default, a __TreeViewPanel__ creates an item container for each visible item and discards it when it is no longer needed (such as when the item is scrolled out of view). When an ItemsControl contains many items, the process of creating and discarding item containers can negatively affect performance. 

>When __TreeVirtualizationMode__ is set to __Recycling__, the __TreeViewPanel__ reuses item containers instead of creating a new one each time. When __TreeViewPanel__ cannot recycle item containers, it uses the standard mode of virtualization, which is to create and discard item containers for each item. The following list describes the cases when the __TreeViewPanel__ cannot recycle item containers:

> - The __ItemsControl__ contains item containers of different types. 
> - You explicitly create the item containers for the __ItemsControl__.

<!-- -->

## ScrollViewer and Virtualization

When using UI virtualization, RadTreeView does not create containers (visual elements) for each data item. Only containers for data items which should be visualized in the viewport are created. RadTreeView then figures out the size of a particular container by creating it and measuring it. With this said, if the container is not created (is virtualized) RadTreeView can only guess its size. As a result, you might experience changes in the sizes of the scrollbar thumbs when bringing new items into view which is expected and cannot be avoided.

## See Also
 * [Load on Demand]({%slug radtreeview-features-load-on-demand%})
 * [Data Binding]({%slug radtreeview-features-data-binding%})
 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
