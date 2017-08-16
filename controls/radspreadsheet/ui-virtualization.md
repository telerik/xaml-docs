---
title: UI Virtualization
page_title: UI Virtualization
description: UI Virtualization
slug: radspreadsheet-ui-virtualization
tags: ui,virtualization
published: True
position: 13
---

# UI Virtualization



__RadSpreadsheet__ supports __UI Virtualization__, which enables it to processes only information that is loaded in the viewable area. In this way, UI elements are created only for the parts of the document actually shown on screen. This reduces the memory footprint of the application and speeds up the loading time, thus additionally enhancing the UI performance. 

>importantTry not to place RadSpreadsheet in controls/panels which will measure it with infinity. For example, __ScrollViewer__, __StackPanel__ and Grid with __Row.Height="Auto"__ or __Column.Width="Auto"__ will measure with infinity. In these cases, RadSpreadsheet is measured with infinity and cannot determine what part of the document is shown in the viewport, therefore the virtualization turns off.

## See Also

 * [Visual Structure]({%slug radspreadsheet-visual-structure%})

 * [Working with UI Selection]({%slug radspreadsheet-ui-working-with-selection%})
