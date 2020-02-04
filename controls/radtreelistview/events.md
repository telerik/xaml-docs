---
title: Events
page_title: Events
description: Check our "Events" documentation article for the RadTreeListView WPF control.
slug: radtreelistview-events
tags: events
published: True
position: 8
---

# Events

The __RadTreeListView__ and the __RadGridView__ derives from __GridViewDataControl__. In this way, it has the same set of events as the __RadGridView__. To learn more about the __RadGridView's__ events read its [Events]({%slug gridview-events-overview%}) topics.

Here is a list of events exposed by the RadTreeListView control:

* **PreviewDragEnded**: Occurs before the drag has ended. The type of the passed event arguments is __RadTreeListViewDragEndedEventHandler__.

	#### __[C#] Example 1: Get the Dragged Items in PreviewDragEnded event handler__
		{{region cs-radtreelistview-events-events_0}}
			private void RadTreeListView_PreviewDragEnded(object sender, RadTreeListViewDragEndedEventArgs e)
			{
				var draggedItems = e.DraggedItems;  
			}
		{{endregion}}      

## See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})
