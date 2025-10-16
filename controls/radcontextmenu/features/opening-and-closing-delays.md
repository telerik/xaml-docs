---
title: Opening and Closing Delays
page_title: Opening and Closing Delays
description: Check our &quot;Opening and Closing Delays&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-features-opening-and-closing-delays
tags: opening,and,closing,delays
published: True
position: 4
---

# Opening and Closing Delays

The __RadContextMenu__ allows you to specify a delay for the closing and opening actions of its child items. This means that you make the __RadContextMenu__ wait for a specific amount of time before opening or closing a sub menu. In order to specify these delays you can set the __ShowDelay__ and __HideDelay__ properties. They are of type __Duration__ and have the following format in XAML "0:0:0.00".

Here is an example of a __RadContextMenu__ with a delay before opening a sub menu equal to one second and a delay before closing a sub menu also equal to one second.



```XAML
	<telerik:RadMenu VerticalAlignment="Top"
	                 ShowDelay="0:0:1"
	                 HideDelay="0:0:1">
	    ...
	</telerik:RadMenu>
```