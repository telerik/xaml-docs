---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-events
tags: events
published: True
position: 8
---

# Events

The __RadTreeListView__ and the __RadGridView__ derives from __GridViewDataControl__. In this way, it has the same set of events as the __RadGridView__. To learn more about the __RadGridView's__ events read its [Events]({%slug gridview-events-overview%}) topics.

Here is a list of events exposed by the RadTreeListView control:

* **PreviewDragEnded**: Occurs before the drag has ended. The type of the passed event arguments is __RadTreeListViewDragEndedEventHandler__.

	__Example 1: Get the Dragged Items in PreviewDragEnded event handler__
		```C#
			private void RadTreeListView_PreviewDragEnded(object sender, RadTreeListViewDragEndedEventArgs e)
			{
				var draggedItems = e.DraggedItems;  
			}
		```      

## See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})
