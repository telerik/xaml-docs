---
title: Visual States
page_title: Visual States
description: Check our &quot;Visual States&quot; documentation article for the RadMenu {{ site.framework_name }} control.
slug: radmenu-styles-and-templates-visual-states
tags: visual,states
published: True
position: 2
---

# Visual States

Like most {{ site.framework_name }} controls, the __RadMenu__ and the __RadMenuItem__ use the __VisualStateManager__ to modify their appearance depending on a condition. This topic will explain the states of the both and will focus on the states of the __RadMenuItem__ and how they are used from the different templates.

## RadMenu Visual States

The __RadMenu__ control exposes several common states, grouped as follows:        

* CommonStates           

	* __Normal__ - the normal state of the control.

	* __Disabled__ - the state of the control, when it gets disabled.

* FocusStates

	* __Focused__ - the state of the control, when it gets focused.

	* __Unfocused__ - the state of the control, when it loses focus.

## RadMenuItem Visual States

The __RadMenuItem__ exposes several states, grouped as follows:

* CommonStates

	* __Normal__ - the normal state of the control.

	* __Highlighted__ - the state of the control, when the mouse is over it.

	* __Disabled__ - the state of the control, when it is disabled.

	* __Focused__ - the state of the control, when its sub items are expanded.

* CheckStateGroup

	* __Checked__ - the state of the control, when it gets checked (applied only when the control is marked as checkable).

	* __HideIcon__ - the state of the icon, when there is no icon specified.

	* __Unchecked__ - the state of the control, when it gets unchecked (applied only when the control is marked as checkable).

* FocusStates

	* __Unfocused__ - the state of the control, when it isn't focused.

>tip Only one state of a group can be active. For example, if the control goes into the Checked state, it cannot be in the HideIcon state too. By default the Checked state should display a mark before the item, so it should hide the icon no matter if it is null or not. If the item is not checked and the icon is not defined, the HideIcon state will get activated and the empty icon will get hidden.

The several templates of the __RadMenuItem__ don't handle all of the states, but only those, which they need. When generated through Expression Blend, the logic placed in these templates also gets generated. In the following table you can see which states the specific template makes use of.

Templates\States	|	Normal	|	Highlighted	|	Disabled	|	Focused	|	Checked	|	HideIcon	|	Unchecked	|	Unfocused
---	|	---	|	---	|	---	|	---	|	---	|	---	|	---	|	---
Top-Level Header	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)
Top-level Item	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)
Submenu Header	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)
Submenu Item	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/yes_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)
Separator	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)	|	![{{ site.framework_name }} RadMenu ](images/no_icon.png)

Note that, when using the __Submenu Header Template__ the item indicates when the mouse is over it via the __Focused__ state. On the other hand, the __Submenu Item Template__ uses the __Highlighted__ state.        

The __Top-Level Templates__ make use of both of the states, depending on the opening mode, e.g. when it is set to click-to-open the __Highlighted__ is used for mouse over and the __Focused__ - for click. Otherwise the item goes in the __Focused__ state at the mouse over action and no logic for the __Highlighted__ state is needed.        

>The __Submenu Item__ can't enter the __Focused__ state, because it has no children to display. That's why it uses the __Highlighted__ state. The __Separator Item__ doesn't need to implement states' animation, because it should not respond to the user's actions.          

## See Also

 * [Styles and Templates - Overview]({%slug radmenu-styles-and-templates-overview%})

 * [Styling the RadMenu]({%slug radmenu-styling-and-templates-styling-radmenu%})

 * [Styling the RadMenuItem]({%slug radmenu-styling-and-appearance-styling-radmenuitem%})
