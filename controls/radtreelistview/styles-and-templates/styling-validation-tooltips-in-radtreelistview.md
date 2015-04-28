---
title: Styling Validation Tooltips in RadTreeListView
page_title: Styling Validation Tooltips in RadTreeListView
description: Styling Validation Tooltips in RadTreeListView
slug: styling-validation-tooltip-in-treelistview
tags: styling,validation,tooltips,in,treelistview
published: True
position: 3
---

## Styling Validation ToolTips in RadTreeListView ##

You can modify the look of the RadTreeListView and its elements by either changing some of the resources exposed by the API, or by modifying their ControlTemplates. In the control template, you are allowed to reorder the template parts and to add your own elements. However, when changing the control template you should be careful to include all required parts.

As __RadTreeListView__ inherits __RadGridView__ directly, please refer to the [Styling Validation ToolTips in RadGridView]({%slug styling-validation-tooltip-in-gridview%}).

> For customizing __TreeListViewRow__ you need to modify a __ControlTemplate__ with **x:Key="TreeListViewRow_ValidationToolTipTemplate"** instead of **x:Key="GridViewRow_ValidationToolTipTemplate"**