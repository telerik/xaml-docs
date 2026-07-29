---
title: Change Background for Disabled Cells
page_title: Change Background for Disabled Cells
description: Check out our tutorial showing you how to customize the look of disabled GridViewCell elements in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-set-background-disabled-cell
tags: change,background,for,disabled,grid,elements
published: True
position: 7
---

# Change Background for Disabled Grid Elements

The goal of this tutorial is to show you how to customize the look of disabled __GridViewCell__ elements. The approaches for doing so differ depending on whether you are using the older themes (which use visual states) or the newer ones (which use triggers).

## Changing the Background for Disabled GridViewCells in Newer Themes

In the newer themes, you can create a style targeting GridViewCell and add a trigger, which sets its __Background__ when the cell is disabled. A sample style is demonstrated in __Example 1__.

__Example 1: Styling Disabled GridViewCells__

<snippet id='radgridview-how-to-set-background-disabled-cell-example_1_styling_disabled_gridviewcells-xaml' />


## Changing the Background for Disabled GridViewCells in Older Themes

In older themes, you need to [extract the ControlTemplate of the GridViewCell]({%slug styling-apperance-editing-control-templates%}). You can then modify the __Disabled VisualState__ as well as the __Background_Disabled__ Border element to your liking.

In __Example 2__ we've changed the ControlTemplate so that all disabled cells have a fully opaque red background as illustrated in __Figure 1__. 

> You should make sure to extract the ControlTemplate for the theme that you are using.

__Example 2: Modifying the Disabled visual state and Background_Disabled element__

<snippet id='radgridview-how-to-set-background-disabled-cell-example_2_modifying_the_disabled_visual_state_and_background_disabled_element-xaml' />


#### __Figure 1: Disabled GridViewCells with fully opaque background__

![Telerik UI for {{ site.framework_name }} RadGridView disabled cells with a fully opaque custom background color](images/gridview-how-to-set-background-disabled-cell-1.png)

Similarly, you can define the visual state in __Example 3__ so that there's no visual difference between enabled and disabled cells.

__Example 3: No visual difference between enabled and disabled cells__

<snippet id='radgridview-how-to-set-background-disabled-cell-example_3_no_visual_difference_between_enabled_and_disabled_cells-xaml' />


#### __Figure 2: Disabled GridViewCells with transparent background__

![Telerik UI for {{ site.framework_name }} RadGridView disabled cells styled to look visually identical to enabled cells](images/gridview-how-to-set-background-disabled-cell-2.png)

## See Also

 * [Styling a Cell]({%slug gridview-styling-cell%})