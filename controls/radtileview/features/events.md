---
title: Events
page_title: Events
description: Events
slug: radtileview-events
tags: events
publish: True
position: 3
---

# Events



This article describes the __RadTileView__ and __RadTileViewItem__ events.
	

## RadTileView Events

The __RadTileView__ exposes the following events:
		

* __TileStateChanged__ - raised when the state of the item is changed.
			

* __PreviewTileStateChanged__ - raised before the state of the item is changed. It is cancelable by setting the __Handled__ property of the event arguments to __True__.
			

* __PreviewTileDragStarted__ - fired before a drag operation has started. It is cancelable by setting the __Handled__ property of the event arguments to __True__.
			

* __TileDragStarted__ - fired after a drag operation has started.
			

* __TileDragEnded__ - fired after a drag operation has ended.
			

* __TilePositionChanged__ - fired when a tile's position has been changed while reordering the tiles with dragging.
			

* __PreviewTilePositionChanged__ - fired before the position of the item is changed. It is cancelable by setting the __Handled__ property of the event arguments to __True__.
			

* __PreviewTilesStateChanged__ - raised before the state of any items is changed. It is cancelable by setting the __Handled__ property of the event arguments to __True__.
			

* __TilesStateChanged__ - raised after the state of all items is changed.
			

* __TilesPositionChanged__ - raised after the position of all items is changed and after all related animations have completed.
			

* __TilesAnimationCompleted__ - raised when the tiles animations have completed. The event handler receives two arguments:
			

* The __sender__ argument contains the __RadTileView__ object triggering the tile animations.

* A __TilesAnimationCompletedEventArgs__ object, which exposes an __AnimatedContainers__ property that gets the collection of the __RadTileViewItems__ that were animated.
			  

## RadTileViewItem Events

The __RadTileViewItem__ exposes the following events:
		

* __PositionChanged__ - fired when a tile's position has been changed while reordering the tiles with dragging.
			

* __PreviewTileStateChanged -__ raised before the state of the item is changed. It is cancelable by setting the __Handled__ property of the event arguments to __True__.
			

* __TileStateChanged__ - raised when the state of the item is changed.
			

# See Also

 * [Getting Started]({%slug radtileview-getting-started%})
