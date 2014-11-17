---
title: Modifying the Group Panel
page_title: Modifying the Group Panel
description: Modifying the Group Panel
slug: gridview-modifying-group-panel
tags: modifying,the,group,panel
published: True
position: 6
---

# Modifying the Group Panel

__RadGridView__ exposes two properties - __GroupPanelBackground__ and __GroupPanelForeground__which allow you to make basic modifications of the__Group Panel__ (area).

>tipThe __RadGridView__ also exposes two style properties - __GroupPanelStyle__ and __GroupPanelItemStyle__. To learn how to use them in order to style the__Group Panel__ read [here]({%slug radgridview-styles-and-templates-styling-the-group-panel%}).

>[Here]({%slug gridview-visual-structure%}) you can read more information about the visual structure of the __RadGridView__.

## Setting the GroupPanelBackground

In the following example the group panel background is set to YellowGreen.

#### __XAML__

{{region gridview-modifying-group-panel_0}}

	<telerik:RadGridView GroupPanelBackground="Coral">
{{endregion}}

![](images/RadGridView_Grouping_ModifyingGroupPanel_010.png)

## Setting the GroupPanelForeground

Similarly to group panel's background you may also change the group panel's foreground. Consider the following example.

#### __XAML__

{{region gridview-modifying-group-panel_1}}

	<telerik:RadGridView GroupPanelBackground="Coral" GroupPanelForeground="AntiqueWhite">
{{endregion}}

And the result is:

![](images/RadGridView_Grouping_ModifyingGroupPanel_020.png)

Check out the following topics which explain in great details the __RadGridView__'s grouping functionality.

* Learn the [basic]({%slug gridview-grouping-basics%}) of the grouping behavior.

* Using group [aggregates]({%slug gridview-grouping-aggregates%}).

* [Implement]({%slug gridview-programmatic-grouping%}) programmatic grouping.

* Use [group footers]({%slug gridview-group-footers%}) for displaying summaries.

# See Also

 * [Basic Filtering]({%slug gridview-basic-filtering2%})

 * [Programmatic Filtering]({%slug gridview-programmatic-filtering%})

 * [Multiple Selection]({%slug gridview-multiple-selection%})
