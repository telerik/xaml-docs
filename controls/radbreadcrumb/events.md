---
title: Events
page_title: Events - Breadcrumb
description: This article lists the events exposed by the RadBreadcrumb control.
slug: radbreadcrumb-events
tags: events,overview
published: True
position: 3
---

# Events

This topic covers the specific events exposed by the `RadBreadcrumb` control.

* `CurrentItemChanged`&mdash;Occurs after the value of the `CurrentItem` property of `RadBreadcrumb` is changed.

	#### __[C#] CurrentItemChanged event handler__
	{{region radbreadcrumb-events-0}}
		private void RadBreadcrumb_CurrentItemChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            var breadcrumb = (RadBreadcrumb)sender;
            object currentItem = breadcrumb.CurrentItem;
        }
	{{endregion}}    

## See Also  
 * [Getting Started]({%slug radbreadcrumb-getting-started%})
 * [Features Overview]({%slug radbreadcrumb-features-overview%})