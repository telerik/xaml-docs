---
title: History Support
page_title: History Support - Breadcrumb
description: The history support allows you to save a list of previously selected items in RadBreadcrumb.
slug: radbreadcrumb-history
tags: support,history
published: True
position: 6
---

# History Support

The history feature allows you to keep track of the items that were selected in the breadcrumb. Each time an item gets unselected it gets on top of the history stack.

![A picture showing the WPF RadBreadcrumb history feature](images/radbreadcrumb-history-0.png)

The history tracking is enabled by default. To disable it, set the `IsHistoryEnabled` property of `RadBreadcrumb` to `false`.

__Disabling the history feature__
<snippet id='radbreadcrumb-history-disabling_the_history_feature-xaml' />

The drop down area where the history items appear can be toggled manually via the `IsHistoryOpen` property of `RadBreadcrumb`. The property can be used also to get the current state of the drop down.

To access the history items, use the `HistoryItems` collection property of `RadBreadcrumb`. The collection contains `RadBreadcrumbBarItem` objects.

__Getting history items__
<snippet id='radbreadcrumb-history-getting_history_items-cs' />

By default the history stores up to 10 items. To change this, set the `HistorySize` property of `RadBreadcrumb`.

__Changing the history size__
<snippet id='radbreadcrumb-history-changing_the_history_size-xaml' />

## See Also  
 * [Getting Started]({%slug radbreadcrumb-getting-started%})
 * [Features]({%slug radbreadcrumb-features-overview%})
