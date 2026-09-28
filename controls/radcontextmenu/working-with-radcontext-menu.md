---
title: Attaching a Context Menu
page_title: Attaching a Context Menu
description: Learn how to attach a RadContextMenu to a UI element in the Telerik UI for WPF documentation.
components: ["contextmenu"]
slug: radcontextmenu-features-working-with-radcontext-menu
tags: radcontextmenu,attaching,contextmenu
published: True
position: 4
---

# Attaching a Context Menu

To attach a __RadContextMenu__ to a UI element, set an instance of it to the __RadContextMenu.ContextMenu__ attached property.

## Attach a Context Menu to a UI Element

The following example attaches an empty context menu to a __TextBox__.

__Attach a RadContextMenu in XAML__
```XAML
<TextBox xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
         x:Name="textBox"
         Width="200"
         VerticalAlignment="Top">
    <telerik:RadContextMenu.ContextMenu>
        <telerik:RadContextMenu>
        </telerik:RadContextMenu>
    </telerik:RadContextMenu.ContextMenu>
</TextBox>
```

__Attach a RadContextMenu in Code__
```C#
RadContextMenu radContextMenu = new RadContextMenu();
RadContextMenu.SetContextMenu(this.textBox, radContextMenu);
```

The code creates a context menu and attaches it to the `textBox` control.


## See Also

* [Setting the Opening Event]({%slug radcontextmenu-features-opening-on-specific-event%})

* [Keyboard Support]({%slug radcontextmenu-key-modifiers%})

* [Menu Placement]({%slug radcontextmenu-features-placement%})

* [Events - Overview]({%slug radcontextmenu-events-overview%})

* [Context Menu Owner]({%slug radcontextmenu-features-context-menu-owner%})