---
title: Events
page_title: Events
description: Events
slug: radtreelistview-events
tags: events
published: True
position: 8
---

# Events

The __RadTreeListView__ inherits the __RadGridView__. In this way, it has the same set of events as the __RadGridView__. To learn more about the __RadGridView's__ events read its {% if site.site_name == 'Silverlight' %}[Events](http://www.telerik.com/help/silverlight/gridview-events-overview.html){% endif %}{% if site.site_name == 'WPF' %}[Events](http://www.telerik.com/help/wpf/gridview-events-overview.html){% endif %} topics.

Here is a list of events exposed by the RadTreeListView control:

* **PreviewDragEnded**: Occurs before the drag has been ended. The type of the passed event arguments is __RadTreeListViewDragEndedEventHandler__.

	#### __[C#] Example 1: Get the Dragged Items in PreviewDragEnded event handler__
		{{region cs-radtreelistview-events-events_0}}
			private void RadTreeListView_PreviewDragEnded(object sender, RadTreeListViewDragEndedEventArgs e)
			{
				var draggedItems = e.DraggedItems;  
			}
		{{endregion}}      

## See Also

 * [Getting Started]({%slug radtreeliestview-getting-started%})
