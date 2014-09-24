---
title: Boundaries Detection
page_title: Boundaries Detection
description: Boundaries Detection
slug: radmenu-boundaries-detection
tags: boundaries,detection
published: True
position: 11
site_name: Silverlight
---

# Boundaries Detection



## 

When you continuously open sub-menu items, you might face the situation when there is not enough space to open the next menu item. The __RadMenu__control comes with a boundary detection functionality out of the box. This means that the __RadMenu__ detects the Silverlight plug-in's boundaries and opens the child items in the opposite direction when the screen boundaries are to be crossed. When there is not enough space in both directions, the control will adjust its items' position to make them visible wherever possible.
        

![](images/RadMenu_Boundaries_Detection_01.png)

The following table demonstrates __RadMenu__ dropdown behavior when encounters a screen edge:
<table><th><tr><td>DropDownPlacement</td><td>Top Edge</td><td>Bottom Edge</td><td>Left Edge</td><td>Right Edge</td></tr></th><tr><td>Top</td><td>The target origin changes to the bottom-left corner of the target area and the popup alignment point changes to the top-left corner of the RadMenu. In effect, this is the same as when Placement is Bottom.</td><td>Aligns to the bottom edge.</td><td>Aligns to the left edge.</td><td>Aligns to the right edge.</td></tr><tr><td>Bottom</td><td>Aligns to the top edge.</td><td>The target origin changes to the top-left corner of the target area and the popup alignment point changes to the bottom-left corner of the RadMenu.</td><td>Aligns to the left edge.</td><td>Aligns to the right edge.</td></tr><tr><td>Left</td><td>Aligns to the top edge.</td><td>Aligns to the bottom edge.</td><td>The target origin changes to the top-right corner of the target area and the popup alignment point changes to the top-left corner of the RadMenu. </td><td>Aligns to the right edge.</td></tr><tr><td>Right</td><td>Aligns to the top edge.</td><td>Aligns to the bottom edge.</td><td>Aligns to the left edge.</td><td>The target origin changes to the top-left corner of the target area and the popup alignment point changes to the top-right corner of the RadMenu.</td></tr></table>

# See Also

 * [Visual Structure]({%slug radmenu-visual-structure%})

 * [Orientation and DropDownPlacement]({%slug radmenu-features-orientation%})

 * [Keyboard Navigation]({%slug radmenu-keyboard-navigation%})
