---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadTileView {{ site.framework_name }} control.
slug: radtileview-events
tags: events
published: True
position: 3
---

# Events

This article describes the __RadTileView__ and __RadTileViewItem__ events.

## RadTileView Events

The __RadTileView__ exposes the following events:

* __TileStateChanged__: Raised when the state of the item is changed.			

* __PreviewTileStateChanged__: Raised before the state of the item is changed. It is cancelable by setting the __Handled__ property of the event arguments to __True__.			

* __PreviewTileDragStarted__: Fired before a drag operation has started. It is cancelable by setting the __Handled__ property of the event arguments to __True__.			

* __TileDragStarted__: Fired after a drag operation has started.

* __TileDragEnded__: Fired after a drag operation has ended.

* __TilePositionChanged__: Fired when a tile's position has been changed while reordering the tiles with dragging.

* __PreviewTilePositionChanged__: Fired before the position of the item is changed. It is cancelable by setting the __Handled__ property of the event arguments to __True__.

* __PreviewTilesStateChanged__: Raised before the state of any items is changed. It is cancelable by setting the __Handled__ property of the event arguments to __True__.	

* __TilesStateChanged__: Raised after the state of all items is changed.

* __TilesPositionChanged__: Raised after the position of all items is changed and after all related animations have completed.

* __TilesAnimationCompleted__: Raised when the tiles animations have completed. The event handler receives two arguments:
	* The __sender__ argument contains the __RadTileView__ object triggering the tile animations.
	* A __TilesAnimationCompletedEventArgs__ object, which exposes an __AnimatedContainers__ property that gets the collection of the __RadTileViewItems__ that were animated.			  

## Selection Events

The RadTileView control also exposes several selection events. Please note that these events should be used instead of the standard **SelectionChanged** event.

* __PreviewTileSelectionChanged__: This event fires just before the selection state of the tile gets changed. You can use the event to cancel the selection of the tile by setting the __Handled__ property of the event arguments to __True__.

* __TileSelectionChanged__: This event fires just after the selection state of the tile is changed.

* __PreviewTilesSelectionChanged__: This event fires just before the selection operation completes. For example, if you select multiple items using the Shift key + Mouse click (in Extended selection mode), the event will get fired only once. You can use the event to cancel the selection of the tile by setting the __Handled__ property of the event arguments to __True__.

* __TilesSelectionChanged__: This event fires just after the selection operation completes. For example, if you select multiple items using the Shift key + Mouse click (in Extended selection mode), the event will get fired only once.

## RadTileViewItem Events

The __RadTileViewItem__ exposes the following events:

* __PositionChanged__: Fired when a tile's position has been changed while reordering the tiles with dragging.

* __PreviewTileStateChanged__: Raised before the state of the item is changed. It is cancelable by setting the __Handled__ property of the event arguments to __True__.

* __TileStateChanged__: Raised when the state of the item is changed.

## See Also
 * [Getting Started]({%slug radtileview-getting-started%})