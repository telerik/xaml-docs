---
title: Opening Modes
page_title: Opening Modes
description: Check our &quot;Opening Modes&quot; documentation article for the RadMenu {{ site.framework_name }} control.
slug: radmenu-features-opening-modes
tags: opening,modes
published: True
position: 1
---

# Opening Modes

If a menu item in the __RadMenu__ control contains any children, they are shown depending on a user action. There are two opening modes that recognize the following two actions:

* The child items are shown when the mouse is over the parent.

* The child items are shown when the user clicks on the parent.

This behavior of the __RadMenu__ control can be controlled via the __ClickToOpen__ property. The default value is __False__ which means that the child items are displayed upon a hover action.

![{{ site.framework_name }} RadMenu Open Child Items on Hover](images/RadMenu_Features_Opening_Modes_01.png)

Setting the property to __True__ will make the child items appear upon a mouse click on their parent. Note that the children do not automatically hide,  but they will wait for a mouse click again.



```XAML
	<telerik:RadMenu ClickToOpen="True">
	    ...
	</telerik:RadMenu>
```

To illustrate this case here is a snapshot of the menu upon a hover:

![{{ site.framework_name }} RadMenu Do Not Open Menu on Hover](images/RadMenu_Features_Opening_Modes_02.png)

and upon a mouse click:

![{{ site.framework_name }} RadMenu Open on Mouse Click](images/RadMenu_Features_Opening_Modes_03.png)

## See Also

 * [Opening and Closing Delays]({%slug radmenu-features-opening-and-closing-delays%})

 * [Orientation and DropDownPlacement]({%slug radmenu-features-orientation%})

 * [Click Modes]({%slug radmenu-features-click-modes%})
