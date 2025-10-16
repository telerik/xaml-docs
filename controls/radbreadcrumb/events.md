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

__CurrentItemChanged event handler__
```C#
	private void RadBreadcrumb_CurrentItemChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
		var breadcrumb = (RadBreadcrumb)sender;
		object currentItem = breadcrumb.CurrentItem;
        }
```    

## See Also  
 * [Getting Started]({%slug radbreadcrumb-getting-started%})
 * [Features Overview]({%slug radbreadcrumb-features-overview%})
