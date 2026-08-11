---
title: Modify foreground color of Selected/Hovered row
page_title: Modify foreground color of Selected/Hovered row
description: Check our &quot;Modify foreground color of Selected/Hovered row&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-how-to-modify-foreground-row
tags: modify,foreground,color,of,selected/hovered,row
published: True
position: 1
---

# Modify foreground color of Selected/Hovered row

This help article explains how to change the foreground color of the __TreeListViewRow__ upon selecting it or hovering over it.

## Creating a Style Targeting TreeListViewRow

In order to achieve this you can create a style targeting TreeListViewRow and add triggers that change its __Foreground__ as demonstrated in __Example 1__.

> __Example 1__ uses the WarehouseViewModel and its dependencies defined in the [Getting Started]({%slug radtreeliestview-getting-started%}) article of the RadTreeListView.

__Example 1: Custom style targeting TreeListViewRow__
<snippet id='radtreelistview-how-to-modify-foreground-row-block_1-xaml' />

> The demonstrated approach may not be relevant for all UI for WPF themes. 

#### __Figure 1: Result from Example 1 in the Fluent theme__
![Selected and Hovered TreeListViewRows](images/TreeListView_Hovered_MouseOver_Row.png)