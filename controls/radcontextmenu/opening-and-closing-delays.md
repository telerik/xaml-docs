---
title: Opening and Closing Delays
page_title: Opening and Closing Delays
description: Check our &quot;Opening and Closing Delays&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
components: ["contextmenu"]
slug: radcontextmenu-features-opening-and-closing-delays
tags: opening,and,closing,delays
published: True
position: 9
---

# Opening and Closing Delays

The __RadContextMenu__ allows you to specify a delay for the closing and opening actions of its child items. This means that you make the __RadContextMenu__ wait for a specific amount of time before opening or closing a sub menu. In order to specify these delays you can set the __ShowDelay__ and __HideDelay__ properties. They are of type __Duration__ and have the following format in XAML "0:0:0.00".

Here is an example of a __RadContextMenu__ with a delay before opening a sub menu equal to one second and a delay before closing a sub menu also equal to one second.

__Set Opening and Closing Delays__

<snippet id='radcontextmenu-features-opening-and-closing-delays-block_1-xaml' />

## Keep the Context Menu Open

By default, the __RadContextMenu__ closes when the user clicks a menu item. Set `StaysOpen` to `True` when the menu should remain open after an item is selected.

__Keep the Context Menu Open__
```XAML
<telerik:RadContextMenu xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                        StaysOpen="True" />
```

## See Also

* [Setting the Opening Event]({%slug radcontextmenu-features-opening-on-specific-event%})

* [Keyboard Support]({%slug radcontextmenu-key-modifiers%})

* [Menu Placement]({%slug radcontextmenu-features-placement%})
