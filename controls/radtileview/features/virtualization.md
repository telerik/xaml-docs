---
title: UI Virtualization
page_title: UI Virtualization
description: Check our &quot;UI Virtualization&quot; documentation article for the RadTileView {{ site.framework_name }} control.
slug: radtileview-features-virtualization
tags: ui,virtualization
published: True
position: 7
---

# UI Virtualization

The `RadTileView` API supports __UI Virtualization__, which processes only information loaded in the viewable area, which reduces the memory footprint of the application and speeds up the loading time thus enhancing additionally the UI performance.

> The standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.The default `ItemsPanel` for the RadTileView is `TileViewPanel`. It derives from `VirtualizingPanel`. It calculates the number of visible items and works with the `ItemContainerGenerator` from an `ItemsControl` (such as the RadTileView) to create UI elements only for visible items.

In order to enable the Virtualization feature of the RadTileView, set the `IsVirtualizing` property to __True__.

The following tutorial shows how to bind to a collection of business objects and virtualize the items displayed in a RadTileView element using the IsVirtualizing property.

Here is a simple RadTileView declaration:			


```XAML
	<UserControl.DataContext>
		<sampleData:RadTileViewSampleData x:Key="DataSource" />
	</UserControl.DataContext>
	<Grid>
		<telerik:RadTileView ColumnWidth="300" 
							 ContentTemplate="{StaticResource contentTemplate}"
							 ItemsSource="{Binding}"
							 ItemTemplate="{StaticResource headerTemplate}"
							 MinimizedColumnWidth="250"
							 MinimizedRowHeight="200"
							 RowHeight="300" />
	</Grid>
```

The RadTileView is bound to a collection with 5000 objects. By default the IsVirtualizing property is set to __False__. Which means that when run the application, it will take a while to generate the `RadTileViewItem` containers. That will freeze your application.

In this case you need to use the UI Virtualization behavior of the RadTileView.			

## Enable UI Virtualization

In order to enable the UI Virtualization behavior, you should set the IsVirtualizing property of the RadTileView to __True__. See the example below:				


```XAML
	    <telerik:RadTileView x:Name="radTileView" IsVirtualizing="True" />
```

Now when you run the application, only those elements that might be on the screen will be generated. For example if you have 5 columns x 1000 rows of restored tiles, but only those that are visible on the screen will be realized. And as you scroll to display more tiles - their containers will be generated on the fly. The same applies to the Minimized items - those that are visible will be realized and the containers for the rest will be generated only after they are brough into view by scrolling.

> Note that internally the IsVirtualizing property sets the `TileViewPanel.IsVirtualizing` attached property. In the previous example setting the IsVirtualizing property can be replaced with the following initialization:
> `<telerik:RadTileView x:Name="radTileView" telerik:TileViewPanel.IsVirtualized="True"/>`

## TileViewPanel Properties

The TileViewPanel exposes several attached properties for customizing its behavior. They are as follows and can be set on the RadTileView control:

* `TileViewPanel.InfiniteHeight`&mdash;Gets or sets the height of the TileViewPanel when it is hosted in panel that measures it with infinity. It is of the type of `double` and has a default value of __2000__.
* `TileViewPanel.InfiniteWidth`&mdash;Gets or sets the width of the TileViewPanel when it is hosted in panel that measures it with infinity. It is of the type of `double` and has a default value of __2000__.
* `TileViewPanel.IsColumnsShrinkEnabled`&mdash; Gets or sets whether the columns will shrink dynamically based on the content or the layour requirements. It is of the type of `bool` and has a default value of __false__. This means that dynamic shrinking will be disabled.
* `TileViewPanel.IsRowsShrinkEnabled`&mdash;Gets or sets whether the rows will shrink dynamically based on the content or the layour requirements. It is of the type of `bool` and has a default value of __false__. This means that dynamic shrinking will be disabled.
* `TileViewPanel.IsShrinkEnabled`&mdash;Gets or sets whether both rows and columns will shrink dynamically. It is of the type of `bool` and has a default value of __false__.
* `TileViewPanel.IsSizeBoundToPosition`&mdash;Gets or sets whether the tiles are bound to their positions in the panel, meaning that when the items are moved, their sizes are also swapped. It is of the type of `bool` and has a default value of __false__.
* `TileViewPanel.IsVirtualized`&mdash;Gets or sets whether the UI virtualization mechanism is enabled. It is not required to set this property directly as it is set internally by the `IsVirtualizing` property of RadTileView.