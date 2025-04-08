---
title: Styling Validation Tooltips
page_title: Styling Validation Tooltips
description: Check our &quot;Styling Validation Tooltips&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: styling-validation-tooltip-in-treelistview
tags: styling,validation,tooltips,treelistview
published: True
position: 3
---

# Styling Validation ToolTips in RadTreeListView

You can modify the look of __RadTreeListView__ and its elements by either changing some of the resources exposed by the API, or by modifying their __ControlTemplates__. In the control template, you are allowed to reorder the template parts and to add your own elements. However, when changing the control template you should be careful to include all required parts.

As __RadTreeListView__ inherits __RadGridView__ directly, please refer to the [Styling Validation ToolTips in RadGridView]({%slug styling-validation-tooltip-in-gridview%}).

> For customizing __TreeListViewRow__ you need to modify a __ControlTemplate__ with **x:Key="TreeListViewRow_ValidationToolTipTemplate"** instead of **x:Key="GridViewRow_ValidationToolTipTemplate"**

## See Also

* [Validation]({%slug gridview-managing-data-validation%})
