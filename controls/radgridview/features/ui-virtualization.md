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

__RadGridView's API__ supports __UI Virtualization__, which processes only information that is loaded in viewable area. This reduces the memory footprint of the application and speeds up the loading time thus additionally enhancing the UI performance. 

The grid utilizes horizontal and vertical virtualization and introduces container recycling for a further improvement of speed and memory footprint. This is of great importance when the control is bound to large data sets. The __UI virtualization__ technique ensures only the containers (rows/cells) which are shown in the viewport will be created. The container recycling pushes further the speed of scrolling __horizontally__ and __vertically__. This feature enables RadGridView to reuse the existing containers over and over again for different data items, instead of creating new ones.

These techniques, combined with the outstanding LINQ-based data engine, guarantee fast performance.
        
>tipThe standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.

>When column virtualization is enabled, only those cells that are visible in the view port are initialized. When the view port or scroll position changes, these cells are reused to represent the new visible cells.
On the other hand, when EnableColumnVirtualization is False, all of the needed cell are initialized. The default internal behavior ensures that only the visible ones are measured.
        
>tipBy default they are both set to True.     

You can check this [troubleshooting article]({%slug gridview-troubleshooting-style-disappears-scrolling%}) on some issues with styling the visual elements.
        
>In case UI Virtualization is disabled, then all the visual elements will be loaded once RadGridView is visualized and its items are populated. Otherwise only the visible items will be populated.

## Disable Column Virtualization

In order to disable the UI __Column Virtualization__ behavior, you should configure __EnableColumnVirtualization__ property to __False__. See the example below:

#### __XAML__

{{region radgridview-features-ui-virtualization_3}}
	<telerik:RadGridView x:Name="radGridView" EnableColumnVirtualization="False"/>
{{endregion}}


## Disable Row Virtualization

In order to disable the UI __Row Virtualization__ behavior, you should configure __EnableRowVirtualization__ property of to __False__. See the example below:

#### __XAML__

{{region radgridview-features-ui-virtualization_4}}
	<telerik:RadGridView x:Name="radGridView" EnableRowVirtualization="False"/>
{{endregion}}


# See Also

 * [Degraded Performance]({%slug gridview-troubleshooting-performance%})

 * [Styling or content mixed-up on scrolling]({%slug gridview-troubleshooting-style-disappears-scrolling%})

 * [Grouped Scenario]({%slug gridview-performance-grouped%})
