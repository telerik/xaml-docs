---
title: Opening and Closing Delays
page_title: Opening and Closing Delays
description: Opening and Closing Delays
slug: radmenu-features-opening-and-closing-delays
tags: opening,and,closing,delays
published: True
position: 2
---

# Opening and Closing Delays

The __RadMenu__ allows you to specify delays for its closing and opening actions. This means that you can make the __RadMenu__ wait for a specific amount of time before opening or closing a menu. In order to specify these delays you can set the __ShowDelay__ and __HideDelay__ properties. They are of type __Duration__ and have the following format in XAML "0:0:0.00".

>Note that when the __ClickToOpen__ property is set to __True__, the delays don't affect the __RadMenu's__ behavior.

Here is an example of a __RadMenu__ with a delay before opening a menu equal to one second and a delay before closing a menu also equal to one second.

#### __XAML__

{{region radmenu-features-opening-and-closing-delays_0}}
	<telerik:RadMenu VerticalAlignment="Top" ShowDelay="0:0:1" HideDelay="0:0:1">
	    ...
	</telerik:RadMenu>
{{endregion}}

# See Also

 * [Opening Modes]({%slug radmenu-features-opening-modes%})

 * [Animation]({%slug radmenu-features-animation%})

 * [Click Modes]({%slug radmenu-features-click-modes%})