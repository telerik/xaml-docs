---
title: Reordering Tiles
page_title: Reordering Tiles
description: Check our &quot;Reordering Tiles&quot; documentation article for the RadTileView {{ site.framework_name }} control.
slug: radtileview-features-reordering-tiles
tags: reordering, dragging, drop, tiles
published: True
position: 8
---

# Reordering Tiles

The tiles in __RadTileView__ can be reordered via drag and drop operation. The dragged __RadTileViewItem__ will be swapped with the item under the mouse. This feature is enabled by default, but you can disable it with the __IsItemDraggingEnabled__ property of __RadTileView__.

__Example 1: Disabling the drag reordering__
```XAML
	<telerik:RadTileView IsItemDraggingEnabled="False"/>
```

## Drag Mode

__RadTileView__ supports two drag modes - __Slide__ and __Swap__. The mode is contoled through the __DragMode__ property.

* __Slide__: The tiles swap their positions on mouse over. This is the default drag mode.
* __Swap__: The tiles swap their positions when the dragged tile is dropped.

__Example 2: Changing the drag mode__
```XAML
	<telerik:RadTileView DragMode="Swap" />
```
	
## Autoscrolling	

__RadTileView__ supports autoscrolling while dragging a tile. To enable this feature use the __IsAutoScrollingEnabled__ property.

__Example 3: Enabling autoscrolling__
```XAML
	<telerik:RadTileView IsAutoScrollingEnabled="True">
```

## See Also

* [Getting Started]({%slug radtileview-getting-started%})
* [Animation]({%slug radtileview-animation%})
* [Minimizing And Maximizing]({%slug radtileview-minimizing-and-maximizing%})
