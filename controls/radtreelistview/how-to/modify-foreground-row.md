---
title: Modify foreground color of Selected/Hovered row
page_title: Modify foreground color of Selected/Hovered row
description: Modify foreground color of Selected/Hovered row
slug: radtreelistview-how-to-modify-foreground-row
tags: modify,foreground,color,of,selected/hovered,row
published: True
position: 1
---

# Modify foreground color of Selected/Hovered row



This help article explains how to modify the foreground color of __TreeListViewRow__ on selecting it or hovering over it.

## 

Every row shows a set of __GridViewCells__. In order to change the foreground of all the __GridViewCells__ when their parent row is hovered/selected you should predefine the template of __TreeListViewRow__ and access the part __DataCellsPresenter__. This element is a plain presenter used to display the cells contained in a row.
        

You should then add an additional animation to the default hover/selection states of a row and manipulate the Foreground property of **PART_DataCellsPresenter**.
        

For sample code you can check this [article]({%slug gridview-how-to-modify-foreground-row%}) for __RadGridView__. 
        

# See Also

 * [Templates Structure]({%slug radtreelistview-templates-structure%})
