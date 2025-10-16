---
title: Key Modifiers
page_title: Key Modifiers
description: Check our &quot;Key Modifiers&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-key-modifiers
tags: key,modifiers
published: True
position: 2
---

# Key Modifiers

The __ModifierKey__ property allows you to use a modifier key, which in combination with the mouse action opens the __RadContextMenu__. When setting the __ModifierKey__ property you can choose among several available values:

* __Alt__ - specifies that the __Alt__ button must be pressed, in order to open the __RadContextMenu__.

* __Apple__ - specifies that the __Apple__ button must be pressed, in order to open the __RadContextMenu__.

* __Control__ - specifies that the __Control__ button must be pressed, in order to open the __RadContextMenu__.

* __None__ - specifies that __none of the buttons__ must be pressed, in order to open the __RadContextMenu__. __(default)__

* __Shift__ - specifies that the __Shift__ button must be pressed, in order to open the __RadContextMenu__.

* __Windows__ - specifies that the __Windows__ button must be pressed, in order to open the __RadContextMenu__.

Here is an example of a __RadContextMenu__ that requires the Control button to be pressed in order to open.



```XAML
	<TextBox Width="200"
	 VerticalAlignment="Top">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu ModifierKey="Control">
	            ...
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</TextBox>
```

If you run your application and just right-click the __TextBox__ control, nothing will happen. The combination of holding the "__Control__" key and then right-clicking the button actually opens the __RadContextMenu__.

## See Also

 * [Opening on a Specific Event]({%slug radcontextmenu-features-opening-on-specific-event%})

 * [Placement]({%slug radcontextmenu-features-placement%})

 * [Opening and Closing Delays]({%slug radcontextmenu-features-opening-and-closing-delays%})
