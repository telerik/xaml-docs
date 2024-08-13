---
title: UI Virtualization
page_title: UI Virtualization
description: Check our &quot;UI Virtualization&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-features-ui-virtualization
tags: ui,virtualization
published: True
position: 12
---

# UI Virtualization

The __RadTreeListView API__ supports __UI Virtualization__, which processes only information that is loaded in the viewable area, which reduces the memory footprint of the application and speeds up the loading time, thus additionally enhancing the UI performance. 

The grid utilizes horizontal and vertical virtualization and introduces container recycling for a further improvement of speed and memory footprint. This is of great importance when __RadTreeListView__ is bound to large data sets. The __UI virtualization__ technique ensures that the grid creates only the needed containers (rows/cells) which are shown in the viewport of the grid. The container recycling pushes further the speed of scrolling __horizontally__ and __vertically__. This feature enables __RadTreeListView__ to reuse the existing containers over and over again for different data items, instead of creating new ones. These techniques, combined with the outstanding LINQ-based data engine, guarantee the exceptional fast performance of Telerik’s __RadTreeListView__.

>The standard layout system creates item containers and computes layout for each item associated with a list control. The word ___"virtualize"___ refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.

__RadTreeListView__ directly inherits the __RadGridView__ and it uses its virtualization mechanism. To learn more read the [respective topic]({%slug radgridview-features-ui-virtualization%}) in the __RadGridView's__ documentation.

## See Also  
 * [Getting Started]({%slug radtreeliestview-getting-started%})
 * [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%}) 
 * [Common UI Virtualization]({%slug common-ui-virtualization%})
 * [Performance]({%slug radtreelistview-performance%})
