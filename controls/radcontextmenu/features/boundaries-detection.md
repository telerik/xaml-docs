---
title: Boundaries Detection
page_title: Boundaries Detection
description: Boundaries Detection
slug: radcontextmenu-features-boundaries-detection
tags: boundaries,detection
publish: True
position: 6
site_name: Silverlight
---

# Boundaries Detection



## 

When you continuously open sub-menu items, you might face the situation when there is not enough space to open the next menu item. The __RadContextMenu__control comes with a boundary detection functionality out of the box. This means that the __RadContextMenu__ detects the Silverlight plug-in's boundaries and opens the child items in the opposite direction when the screen boundaries are to be crossed. When there is not enough space in both directions, the control will adjust its items' position to make them visible wherever this is possible.

![](images/RadContextMenu_Features_Boundaries_Detection_01.png)

The following table demonstrates the RadContextMenu behavior when encounters a screen edge:
<table><th><tr><td>Placement</td><td>Top Edge</td><td>Bottom Edge</td><td>Left Edge</td><td>Right Edge</td></tr></th><tr><td>Absolute</td><td>Aligns to the top edge.</td><td>Aligns to the bottom edge.</td><td>Aligns to the left edge.</td><td>Aligns to the right edge.</td></tr><tr><td>AbsolutePoint</td><td>Aligns to the top edge.</td><td>The popup alignment point changes to the bottom-left corner of the RadContextMenu.</td><td>Aligns to the left edge.</td><td>The popup alignment point changes to the top-right corner of the RadContextMenu.</td></tr><tr><td>Bottom</td><td>Aligns to the top edge.</td><td>The target origin changes to the top-left corner of the target area and the popup alignment point changes to the bottom-left corner of the RadContextMenu.</td><td>Aligns to the left edge.</td><td>Aligns to the right edge.</td></tr><tr><td>Center</td><td>Aligns to the top edge.</td><td>Aligns to the bottom edge.</td><td>Aligns to the left edge.</td><td>Aligns to the right edge.</td></tr><tr><td>Left</td><td>Aligns to the top edge.</td><td>Aligns to the bottom edge.</td><td>The target origin changes to the top-right corner of the target area and the popup alignment point changes to the top-left corner of the RadContextMenu. </td><td>Aligns to the right edge.</td></tr><tr><td>Mouse</td><td>Aligns to the top edge.</td><td>The target origin changes to the top-left corner of the target area (the bounds of the mouse pointer) and the popup alignment point changes to the bottom-left corner of the RadContextMenu.</td><td>Aligns to the left edge.</td><td>Aligns to the right edge.</td></tr><tr><td>MousePoint</td><td>Aligns to the top edge.</td><td>The popup alignment point changes to the bottom-left corner of the RadContextMenu.</td><td>Aligns to the left edge.</td><td>The popup alignment point changes to the top-right corner of the popup.</td></tr><tr><td>Relative</td><td>Aligns to the top edge.</td><td>Aligns to the bottom edge.</td><td>Aligns to the left edge.</td><td>Aligns to the right edge.</td></tr><tr><td>RelativePoint</td><td>Aligns to the top edge.</td><td>The popup alignment point changes to the bottom-left corner of the RadContextMenu.</td><td>Aligns to the left edge.</td><td>The popup alignment point changes to the top-right corner of the popup.</td></tr><tr><td>Right</td><td>Aligns to the top edge.</td><td>Aligns to the bottom edge.</td><td>Aligns to the left edge.</td><td>The target origin changes to the top-left corner of the target area and the popup alignment point changes to the top-right corner of the RadContextMenu.</td></tr><tr><td>Top</td><td>The target origin changes to the bottom-left corner of the target area and the popup alignment point changes to the top-left corner of the RadContextMenu. In effect, this is the same as when Placement is Bottom.</td><td>Aligns to the bottom edge.</td><td>Aligns to the left edge.</td><td>Aligns to the right edge.</td></tr></table>

# See Also

 * [Visual Structure]({%slug radcontextmenu-visual-structure%})

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Opening and Closing Delays]({%slug radcontextmenu-features-opening-and-closing-delays%})
