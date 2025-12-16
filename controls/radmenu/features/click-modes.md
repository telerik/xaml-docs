---
title: Click Modes
page_title: Click Modes
description: Check our &quot;Click Modes&quot; documentation article for the RadMenu {{ site.framework_name }} control.
slug: radmenu-features-click-modes
tags: click,modes
published: True
position: 10
---

# Click Modes

By default if an item in the __RadMenu__ control is clicked, the menu gets closed. You are able to control this behavior by setting the __StaysOpenOnClick__ property of the __RadMenuItem__. The default value is __False__.

If you set this property to __True__, the menu won't get closed upon a click on the item.



```XAML
	<telerik:RadMenuItem Header="Sidebar"
	             StaysOpenOnClick="True" />
```

![{{ site.framework_name }} RadMenu Stays Open On Click](images/RadMenu_Click_Modes_01.png)

>tip You might find this functionality very useful, when having checkable menu items in your __RadMenu__. It allows you to keep the menu open, when a menu item gets checked. To learn more about this type of items read [here]({%slug radmenu-features-checkable-items%}).

## See Also

 * [Opening Modes]({%slug radmenu-features-opening-modes%})

 * [Opening and Closing Delays]({%slug radmenu-features-opening-and-closing-delays%})

 * [Events - Overview]({%slug radmenu-events-overview%})
