---
title: Opening and Closing Delays
page_title: Opening and Closing Delays
description: Opening and Closing Delays
slug: radcontextmenu-features-opening-and-closing-delays
tags: opening,and,closing,delays
publish: True
position: 4
---

# Opening and Closing Delays



## 

The __RadContextMenu__ allows you to specify a delay for the closing and opening actions of its child items. This means that you make the __RadContextMenu__ wait for a specific amount of time before opening or closing a sub menu. In order to specify these delays you can set the __ShowDelay__ and __HideDelay__ properties. They are of type __Duration__ and have the following format in XAML "0:0:0.00".

Here is an example of a __RadContextMenu__with a delay before opening a sub menu equal to one second and a delay before closing a sub menu also equal to one second.

#### __XAML__

{{region radcontextmenu-features-opening-and-closing-delays_0}}
	<telerik:RadMenu VerticalAlignment="Top"
	                           ShowDelay="0:0:1"
	                           HideDelay="0:0:1">
	    ...
	</telerik:RadMenu>
	{{endregion}}


