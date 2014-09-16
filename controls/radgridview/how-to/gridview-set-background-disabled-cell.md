---
title: Change Background for Disabled Grid Elements
page_title: Change Background for Disabled Grid Elements
description: Change Background for Disabled Grid Elements
slug: gridview-how-to-set-background-disabled-cell
tags: change,background,for,disabled,grid,elements
publish: True
position: 7
---

# Change Background for Disabled Grid Elements



The goal of this tutorial is to show you how to change the __Background for a disabled Cell/Row__.

## 

When the GridView is not enabled (i.e. its property IsEnabled is set to False), then you cannot change the Background of its rows/cells.
        

Please note that once you disable RadGridView, GridViewRow, GridViewColumn, GridViewCell you perform this logic on a cell level. For example when you disable the whole grid, a gray border appeared and you cannot change the Background, MouseOver and Selection effects are lost also.
        

If you want to maintain these effects you should predefine the [template of GridViewCell]({%slug gridview-styling-cell%}) and modify the Border element named __Background_Disabled__.
          You should change its background color to a color, which allows __transparency__.
        

# See Also

 * [Styling a Cell]({%slug gridview-styling-cell%})
