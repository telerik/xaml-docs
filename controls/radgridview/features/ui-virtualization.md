---
title: UI Virtualization
page_title: UI Virtualization
description: UI Virtualization
slug: radgridview-features-ui-virtualization
tags: ui,virtualization
published: True
position: 13
---

# UI Virtualization



The __RadGridView____API__ supports __UI Virtualization__, which processes only information that is loaded in the viewable area. This reduces the memory footprint of the application and speeds up the loading time thus additionally enhancing the UI performance. 

## 

The grid utilizes horizontal and vertical virtualization and introduces container recycling for a further improvement of speed and memory footprint. This is of great importance when __RadGridView__is bound to large data sets. The __UI virtualization__technique ensures that the grid creates only the containers (rows/cells) which are shown in the viewport of the grid. The container recycling pushes further the speed of scrolling __horizontally__and __vertically__. This feature enables __RadGridView__to reuse the existing containers over and over again for different data items, instead of creating new ones.
        

These techniques, combined with the outstanding LINQ-based data engine, guarantee the exceptional fast performance of Telerik’s __RadGridView__.
        

>The standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.

The following tutorial shows how to bind to a collection of business objects and virtualize the items displayed in a __RadGridView__ element using the __EnableColumnVirtualization__and __EnableRowVirtualization__ property.
        

>tipBy default they are both set to True.
          

You can check this [troubleshooting article]({%slug gridview-troubleshooting-style-disappears-scrolling%}) on some issues with styling the visual elements.
        

>In case the UI Virtualization is disabled, then all the visual elements will be loaded once RadGridView is visualized and its items are populated. Otherwise only the visible items will be populated.
          

Here is a simple __RadGridView__ declaration.
        

#### __XAML__

{{region radgridview-features-ui-virtualization_0}}
	<telerik:RadGridView x:Name="radGridView"/>
	{{endregion}}



The __RadGridView__ is populated with 500 000 rows.
        

#### __C#__

{{region radgridview-features-ui-virtualization_1}}
	this.radGridView.ItemsSource = this.GetVeryLargeDataSource();
	{{endregion}}



#### __VB.NET__

{{region radgridview-features-ui-virtualization_2}}
	Me.radGridView.ItemsSource = Me.GetVeryLargeDataSource()
	{{endregion}}



## Disable Column Virtualization

In order to disable the UI __Column__ Virtualization behavior, you should set the __EnableColumnVirtualization__property of the __RadGridView__ to __False__. See the example below:

#### __XAML__

{{region radgridview-features-ui-virtualization_3}}
	<telerik:RadGridView x:Name="radGridView" EnableColumnVirtualization="False"/>
	{{endregion}}



## Disable Row Virtualization

In order to disable the UI __Row__Virtualization behavior, you should set the __EnableRowVirtualization__ property of the __RadGridView__ to __False__. See the example below:

#### __XAML__

{{region radgridview-features-ui-virtualization_4}}
	<telerik:RadGridView x:Name="radGridView" EnableRowVirtualization="False"/>
	{{endregion}}



# See Also

 * [Degraded Performance]({%slug gridview-troubleshooting-performance%})

 * [Styling or content mixed-up on scrolling]({%slug gridview-troubleshooting-style-disappears-scrolling%})

 * [Grouped Scenario]({%slug gridview-performance-grouped%})
