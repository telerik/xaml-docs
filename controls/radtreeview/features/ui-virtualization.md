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

The `RadTreeView` API supports UI Virtualization, which processes only information loaded in the viewable area, which reduces the memory footprint of the application and speeds up the loading time thus enhancing additionally the UI performance.

> The standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.

>The default `ItemsPanel` for the RadTreeView is `TreeViewPanel`. The TreeViewPanel derives from `VirtualizingPanel`. It calculates the number of visible items and works with the `ItemContainerGenerator` from an `ItemsControl` (such as TreeView) to create UI elements only for visible items.

The following tutorial shows how to bind to a collection of business objects and virtualize the items displayed in a RadTreeView element using the `IsVirtualizing` property.

The following example demonstrates a simple RadTreeView declaration. You can find `RadTreeViewSampleData` custom class implementation in the [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%}) help article.

__Binding RadTreeView to large number of items__
```XAML
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
```

The RadTreeView is bound to a collection with 10000 Team objects. By default the `IsVirtualizing` property is set to __False__. Which means that when you try to expand the "Teams" node, it will take a few minutes in order the containers to be generated. That will freeze your application.

In this case you need to use the UI Virtualization behavior of the RadTreeView. 

## Enable UI Virtualization

In order to enable the UI Virtualization behavior, you should set the `IsVirtualizing` property of the RadTreeView to __True__. See the example below:

The default minimum height of the `RadTreeViewItems` is 24. This value is taken into consideration during the virtualization process. To change it, set the `ChildDefaultLength` property of the `TreeViewPanel`. To set the property, assign the `ItemsPanel` property of `RadTreeView`.

__Setting the ChildDefaultLength property of the TreeViewPanel__
```XAML
	<telerik:RadTreeView>
		<telerik:RadTreeView.ItemsPanel>
			<ItemsPanelTemplate>
				<telerik:TreeViewPanel ChildDefaultLength="48" />
			</ItemsPanelTemplate>
		</telerik:RadTreeView.ItemsPanel>
	</telerik:RadTreeView>
```

> Hosting RadTreeView in panels which will measure it with infinity will disable the UI virtualization. Examples of such panels are `ScrollViewer`, `StackPanel`, and `Grid` with `Row.Height=Auto` or `Column.Width=Auto`. You can place it in a `Grid` panel with `RowDefinition` with Height="*" instead. 

__Set IsVirtualizing property__
```XAML
	<telerik:RadTreeView x:Name="radTreeView" IsVirtualizing="True">
```

Now when you try to expand the first node, then only those elements that will be on the screen will be generated.

>tip When the RadTreeView's `IsVirtualizing` property is set to __False__, then all items within an expanded level are created. The performance may not be as bad if there is a deep hierarchy and all items are initially collapsed. Around 200 expanded items may run smooth.

>Note that internally the `IsVirtualizing` property sets the `TreeViewPanel.IsVirtualizing` attached property. In the previous example setting the `IsVirtualizing` property can be replaced with the following initialization:	
`<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True">`

>Where the __telerikTreeView__ alias points to the __Telerik.Windows.Controls.TreeView__ namespace in the __Telerik.Windows.Controls.Navigation__ assembly.

## Setting the TreeVirtualizationMode

When you want to specify the method the `TreeViewPanel` uses to manage virtualizing its child items, then you should set its `TreeVirtualizationMode` property.

The TreeVirtualizationMode property is a `VirtualizationMode` enumeration which may accept the following values:

> In some version of Visual Studio MS XAML Parser could throw a 'Ambiguous match found.' error in the output when the __VirtualizationMode__ property is used. This error comes from the fact that __TreeViewPanel__ inherits from the MS VirtualizingPanel which in .Net4.5 exposes that same property which is hiding an inheritance property. The XAML Parser is designed to work in that way so we have introduced another attached property which is doing the same thing. We suggest to use the telerik:TreeViewPanel.TreeVirtualizationMode property instead.

## TreeVirtualizationMode.Standard

When you use `VirtualizationMode.Standard`, then items that are out of view and are not expanded will be virtualized. Additionally, no container caching or reuse is done. This mode is suited for long lists with little jagging and little scrolling/searching. It consumes less memory at expense of CPU. Expanding and scrolling through a heavily indented hierarchy will mean that little items will be virtualized since most of them will be expanded.

__Setting Standard virtualization mode__
```XAML
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.TreeVirtualizationMode="Standard">
	```

## TreeVirtualizationMode.Recycling

When you use `VirtualizationMode.Recycling`, then items that are out of view and are not expanded will be virtualized. Additionally, containers are cached and reused at `ItemsControl` level. The container cache is cleared after 3 seconds of inactivity. This mode is suited for long lists with little jagging. Scrolling longer lists is very fast. It consumes more memory at expense of CPU. Expanding and scrolling though a heavily indented hierarchy will mean little items will be virtualized since most of them will be expanded.

__Setting Recycling virtualization mode__
```XAML
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.TreeVirtualizationMode="Recycling">
```

## TreeVirtualizationMode.Hierarchical

When you use `VirtualizationMode.Hierarchical`, then items that are out of view will be virtualized. Expanded items are also virtualized. Containers are cached and reused at TreeView level. This mode is suited for indented hierarchies and fully expanded trees. Scrolling may be slower in longer lists (collapsed trees) but faster when the tree is expanded. Expanding and scrolling through a long heavily indented hierarchy should be fast.

__Setting Hierarchical virtualization mode__
```XAML
	<telerik:RadTreeView x:Name="radTreeView" telerikTreeView:TreeViewPanel.IsVirtualizing="True" telerikTreeView:TreeViewPanel.VirtualizationMode="Hierarchical">
```

> By default, a `TreeViewPanel` instance creates an item container for each visible item and discards it when it is no longer needed (such as when the item is scrolled out of view). When an ItemsControl contains many items, the process of creating and discarding item containers can negatively affect performance. 

>When the `TreeVirtualizationMode` property is set to `Recycling`, the `TreeViewPanel` reuses item containers instead of creating a new one each time. When TreeViewPanel cannot recycle item containers, it uses the standard mode of virtualization, which is to create and discard item containers for each item. The following list describes the cases when the TreeViewPanel cannot recycle item containers:

> - The `ItemsControl` contains item containers of different types. 
> - You explicitly create the item containers for the `ItemsControl`.

## ScrollViewer and Virtualization

When using UI virtualization, RadTreeView does not create containers (visual elements) for each data item. Only containers for data items which should be visualized in the viewport are created. RadTreeView then figures out the size of a particular container by creating it and measuring it. With this said, if the container is not created (is virtualized) RadTreeView can only guess its size. As a result, you might experience changes in the sizes of the scrollbar thumbs when bringing new items into view which is expected and cannot be avoided.

## See Also
 * [Load on Demand]({%slug radtreeview-features-load-on-demand%})
 * [Data Binding]({%slug radtreeview-features-data-binding%})
 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
