---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
components: ["contextmenu"]
slug: radcontextmenu-key-modifiers
tags: keyboard,support,key,modifiers
published: True
position: 6
---

# Keyboard Support

The __ModifierKey__ property allows you to use a modifier key, which in combination with the mouse action opens the __RadContextMenu__. When setting the __ModifierKey__ property you can choose among several available values:

* __Alt__ - specifies that the __Alt__ button must be pressed, in order to open the __RadContextMenu__.

* __Apple__ - specifies that the __Apple__ button must be pressed, in order to open the __RadContextMenu__.

* __Control__ - specifies that the __Control__ button must be pressed, in order to open the __RadContextMenu__.

* __None__ - specifies that __none of the buttons__ must be pressed, in order to open the __RadContextMenu__. __(default)__

* __Shift__ - specifies that the __Shift__ button must be pressed, in order to open the __RadContextMenu__.

* __Windows__ - specifies that the __Windows__ button must be pressed, in order to open the __RadContextMenu__.

Here is an example of a __RadContextMenu__ that requires the Control button to be pressed in order to open.

__Require a Modifier Key__
```XAML
<TextBox xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
         Width="200"
         VerticalAlignment="Top">
    <telerik:RadContextMenu.ContextMenu>
        <telerik:RadContextMenu ModifierKey="Control">
            <!-- Add menu items here. -->
        </telerik:RadContextMenu>
    </telerik:RadContextMenu.ContextMenu>
</TextBox>
```

If you run your application and just right-click the __TextBox__ control, nothing will happen. The combination of holding the "__Control__" key and then right-clicking the button actually opens the __RadContextMenu__.

## Show Keyboard Cues

The `ShowKeyboardCuesOnOpen` property controls the visibility of keyboard cues when the __RadContextMenu__ opens. Its default value is `null`, which shows access keys when the menu is opened through the keyboard. Set it to `True` to always show keyboard cues, or to `False` to hide them.

__Show Keyboard Cues When Opening__
```XAML
<telerik:RadContextMenu xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                        ShowKeyboardCuesOnOpen="True" />
```

Setting `ShowKeyboardCuesOnOpen` to `True` removes the need to hold the `Alt` key when the __RadContextMenu__ is opened with the mouse.

## See Also

* [Setting the Opening Event]({%slug radcontextmenu-features-opening-on-specific-event%})

* [Menu Placement]({%slug radcontextmenu-features-placement%})

* [Opening and Closing Delays]({%slug radcontextmenu-features-opening-and-closing-delays%})
