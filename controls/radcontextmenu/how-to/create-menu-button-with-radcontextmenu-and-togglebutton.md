---
title: Create Menu Button with RadContextMenu and ToggleButton
page_title: Create Menu Button with RadContextMenu and ToggleButton
description: Check our &quot;Create Menu Button with RadContextMenu and ToggleButton&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton
tags: create,menu,button,with,radcontextmenu,and,togglebutton
published: True
position: 2
---

# Create Menu Button with RadContextMenu and ToggleButton

In some scenarios you need to have a button that displays additional options upon clicking. This tutorial will show you how to achieve such drop-down button behavior using only a __ToggleButton__ and a __RadContextMenu__. The two things you have to do are the following:

* Attach a __RadContextMenu__ to the __ToggleButton__

* Bind the __IsChecked__ property of the __ToggleButton__ to the __IsOpen__ property of the __RadContextMenu__

Here is the final code snippet.



```XAML
	<ToggleButton Content="Click me"
	              HorizontalAlignment="Left"
	              IsChecked="{Binding IsOpen, ElementName=radContextMenu, Mode=TwoWay}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu" Placement="Bottom">
	            <telerik:RadMenuItem Header="Item 1" />
	            <telerik:RadMenuItem Header="Item 2" />
	            <telerik:RadMenuItem Header="Item 3" />
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ToggleButton>
```

The things you have to make attention to here are: how the __RadContextMenu__ is attached to the __ToggleButton__ and the __ElementBinding__ applied to the __ToggleButton's__ __IsChecked__ property.

![{{ site.framework_name }} RadContextMenu Menu Button](images/RadContextMenu_How_To_Menu_Button_01.png)

## See Also

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Placement]({%slug radcontextmenu-features-placement%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Select  the clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
