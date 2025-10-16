---
title: Modifying Group Panel
page_title: Modifying Group Panel
description: Learn how you can make basic modifications of the Group Panel by using the GroupPanelBackground and GroupPanelForeground properties of Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-modifying-group-panel
tags: modifying,group,panel
published: True
position: 6
---

# Modifying Group Panel

__RadGridView__ exposes two properties - __GroupPanelBackground__ and __GroupPanelForeground__ which allow you to make basic modifications of the __Group Panel__ (area).

>tipThe __GridView__ also exposes two style properties - __GroupPanelStyle__ and __GroupPanelItemStyle__. To learn how to use them in order to style the __Group Panel__ read [here]({%slug radgridview-styles-and-templates-styling-the-group-panel%}).

>[Here]({%slug gridview-visual-structure%}) you can read more information about the visual structure of the __RadGridView__.

## Setting the GroupPanelBackground

In the following example the group panel background is set to YellowGreen.



```XAML
	<telerik:RadGridView GroupPanelBackground="Coral" />
```

![Telerik {{ site.framework_name }} DataGrid Grouping ModifyingGroupPanel 010](images/RadGridView_Grouping_ModifyingGroupPanel_010.png)

## Setting the GroupPanelForeground

Similarly to group panel's background you may also change the group panel's foreground. Consider the following example.



```XAML
	<telerik:RadGridView GroupPanelBackground="Coral" GroupPanelForeground="AntiqueWhite" />
```

And the result is:

![Telerik {{ site.framework_name }} DataGrid Grouping ModifyingGroupPanel 020](images/RadGridView_Grouping_ModifyingGroupPanel_020.png)

Check out the following topics which explain in great details the __RadGridView__'s grouping functionality.

* Learn the [basic]({%slug gridview-grouping-basics%}) of the grouping behavior.

* Using group [aggregates]({%slug gridview-grouping-aggregates%}).

* [Implement]({%slug gridview-programmatic-grouping%}) programmatic grouping.

* Use [group footers]({%slug gridview-group-footers%}) for displaying summaries.

## See Also

 * [Style Group Panel]({%slug radgridview-styles-and-templates-styling-the-group-panel%})

 * [Basic Filtering]({%slug gridview-filtering-basic%})

 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})

 * [Multiple Selection]({%slug gridview-multiple-selection%})
