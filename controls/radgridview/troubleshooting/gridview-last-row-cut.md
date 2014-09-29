---
title: Last row is not fully visible
page_title: Last row is not fully visible
description: Last row is not fully visible
slug: gridview-troubleshooting-last-row-cut
tags: last,row,is,not,fully,visible
published: True
position: 19
---

# Last row is not fully visible



## 

__PROBLEM__

When you have set a TextWrapping for a column, consequently the row's height becomes bigger. As the user scrolls to the bottom, it is possible that the __last row is not fully visible__, its content has been cut.
        

__CAUSE__

RadGridView relies on average row calculations to display the visual elements as you scroll down.
          Since you have enabled TextWrapping on a column, the default row's height is now more than 25 PX. In that case some of the rows may not be calculated accurately.
        

__SOLUTION__

If you want to avoid this behavior you may force RadGridView to correctly calculate its rows by __setting the RowHeight property to a fixed size__. This size should be properly set based on the actual row height you have after the text has been wrapped.
        

# See Also

 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
