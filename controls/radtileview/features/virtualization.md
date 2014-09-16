---
title: UI Virtualization
page_title: UI Virtualization
description: UI Virtualization
slug: radtileview-features-virtualization
tags: ui,virtualization
publish: True
position: 7
---

# UI Virtualization



The __RadTileView__ API supports __UI Virtualization__, which processes only information loaded in the viewable area, which reduces the memory footprint of the application and speeds up the loading time thus enhancing additionally the UI performance.
			

>The standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.The default __ItemsPanel__ for the __RadTileView__ is __TileViewPanel__. The __TileViewPanel__derives from __VirtualizingPanel__. It calculates the number of visible items and works with the __ItemContainerGenerator__ from an __ItemsControl__ (such as the __TileView__) to create UI elements only for visible items.
					

In order to enable the __Virtualization__ feature of the __RadTileView__, you need to set the __IsVirtualizing__ property to __True__.
			

The following tutorial shows how to bind to a collection of business objects and virtualize the items displayed in a __RadTileView__ element using the __IsVirtualizing__ property.
			

Here is a simple __RadTileView__ declaration:
			

#### __XAML__

{{region radtileview-features-virtualization_0}}
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
	{{endregion}}



The __RadTileView__ is bound to a collection with 5000 objects. By default the __IsVirtualizing__ property is set to __False__. Which means that when run the application, it will take a while to generate the __RadTileViewItems__ containers. That will freeze your application.
			

In this case you need to use the __UI Virtualization__ behavior of the __RadTileView__.
			

## Enable UI Virtualization

In order to enable the __UI____Virtualization__ behavior, you should set the __IsVirtualizing__ property of the __RadTileView__ to __True__. See the example below:
				

#### __XAML__

{{region radtileview-features-virtualization_1}}
	    <telerik:RadTileView x:Name="radTileView" IsVirtualizing="True" />
	{{endregion}}



Now when you run the application, only those elements that might be on the screen will be generated. For example if you have 5 columns x 1000 rows of restored tiles, but only those that are visible on the screen will be realized. And as you scroll to display more tiles - their containers will be generated on the fly. The same applies to the Minimized items - those that are visible will be realized and the containers for the rest will be generated only after they are brough into view by scrolling.

>Note that internally the __IsVirtualizing__ property sets the __TileViewPanel.IsVirtualizing__ attached property. In the previous example setting the __IsVirtualizing__ property can be replaced with the following initialization:
						

	<telerik:RadTileView x:Name="radTileView" telerik:TileViewPanel.IsVirtualized="True"/>


