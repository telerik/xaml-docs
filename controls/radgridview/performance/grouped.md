---
title: Grouped Scenario
page_title: Grouped Scenario
description: Grouped Scenario
slug: gridview-performance-grouped
tags: grouped,scenario
published: True
position: 0
---

# Grouped Scenario

## Perfomance tips in grouped scenario

In order to increase the scrolling performance you could:

* increase the __Height__ of the rows (GridViewRow)

* increase the __FontSize__ of the cells (GridViewCell)

* increase the __Width__ of the columns

>Please note that the bigger visual elements you have, the faster the scrolling speed will be.
         
>tipAs of __Q3 2012__ we have introduced a new property of the RadGridView __GroupRenderMode__. The default mode is Nested, and the new one is Flat. When you set the __Flat mode__, the GridView will render rows one below the other. This leads to a very good perfromance when the grid is grouped on several levels and has a lot of data.
          
# See Also

 * [Tips and Tricks]({%slug radgridview-performance-tips-tricks%})
