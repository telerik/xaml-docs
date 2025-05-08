---
title: UI Virtualization
page_title: UI Virtualization
description: Check our &quot;UI Virtualization&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-ui-virtualization
tags: ui,virtualization
published: True
position: 13
---

# UI Virtualization

__RadRichTextBox__ supports __UI Virtualization__, which enables it to processes only information that is loaded in the viewable area. In this way, UI elements are created only for the parts of the document actually shown on screen. This reduces the memory footprint of the application and speeds up the loading time, thus additionally enhancing the UI performance. 

>importantTry not to place RadRichTextBox in controls/panels which will measure it with infinity. For example, __ScrollViewer__, __StackPanel__ and Grid with __Row.Height="Auto"__ or __Column.Width="Auto"__ will measure with infinity. In these cases, RadRichTextBox is measured with infinity and cannot determine what part of the document is shown in the viewport, therefore the virtualization turns off.

## See Also  
* [Import/Export]({%slug radrichtextbox-features-import-export%})
* [Formatting API]({%slug radrichtextbox-features-formatting-api%})
