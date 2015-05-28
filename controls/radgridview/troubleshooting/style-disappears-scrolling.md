---
title: Styling or content mixed-up on scrolling
page_title: Styling or content mixed-up on scrolling
description: Styling or content mixed-up on scrolling
slug: gridview-troubleshooting-style-disappears-scrolling
tags: styling,or,content,mixed-up,on,scrolling
published: True
position: 13
---

# Styling or content mixed-up on scrolling

__PROBLEM__

__Scenario 1__

You have applied a Style for the GridViewCell or GridViewRow element. Then: 

1. Scroll so the first visual elements are out of view

2. Scroll back to top of the GridView

3. You will notice that the styles have mixed up

__Scenario 2__

You have applied a Template or set a Value for the GridViewCell element. Then: 

1. Scroll so the first visual elements are out of view

2. Scroll back to top of the GridView

3. You will notice that the cells' contents have mixed up

__Scenario 3__

Your Bindings are relying on RelativeSource or ElementName sources. 
        
__Scenario 4__

You are creating a binding to GridViewCell.Value inside a DataTemplate.
        
__CAUSE__

Such problems are usually caused by directly working with the values of the rows/cells. Generally it is not a good practice to work with the visual elements of RadGridView as when the virtualization is enabled, then its rows and cells are reused. RadGridView uses same cells to display different values and your binding fails to update.
        
Please note that it is enabled by default. You may find more information about __UI Virtualization__ in this [help article]({%slug radgridview-features-ui-virtualization%}).
        
__SOLUTION__

Use [CellStyleSelector]({%slug gridview-cell-style-selector%}) to set the style for the Cells and [RowStyleSelector]({%slug gridview-rowstyleselector%}) to set styles for the Rows

# See Also

 * [Getting Started with RadGridView]({%slug gridview-getting-started2%})
 
 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
