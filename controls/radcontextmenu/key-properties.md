---
title: Key Properties
page_title: Key Properties
description: Key Properties
slug: radcontextmenu-key-properties
tags: key,properties
published: True
position: 4
---

# Key Properties

This topic will go through the key properties of __RadContextMenu__ as follows

* [IconColumnWidth](#iconcolumnwidth)
* [StaysOpen](#staysopen)
* [HorizontalOffset](#horizontaloffset)
* [EventName](#eventname)
* [ModifierKey](#modifierkey)
* [MousePosition](#mouseposition)
* [UIElement](#uielement)
* [VerticalOffset](#verticaloffset)

## IconColumnWidth

By default __RadContextMenu__ displays a column used for visualizing the icons of the menu items. 
![RadContextMenu Icon Column](images/RadContextMenu_KeyProperties_01.png)

Its width can be controlled through the __IconColumnWidth__ property. For example, it can be entirely hidden by setting the property value to 0.

#### __[XAML] Example 1: Setting the IconColumnWidth property__
	 <telerik:RadContextMenu IconColumnWidth="0"/>

#### __Figure 1: RadContextMenu with hidden icon column__
![RadContextMenu Icon Column](images/RadContextMenu_KeyProperties_02.png)

## StaysOpen

Setting this property manipulates whether __RadContextMenu__ will close automatically or not. Its default value is __False__. By setting it to __True RadContextMenu__ will stay open when the user clicks the menu items.

## HorizontalOffset

__RadContextMenu__ provides a mechanism for controlling the horizontal distance between the target origin and the popup alignment point through the __HorizontalOffset__ property.

#### __[XAML] Example 2: Setting the HorizontalOffset property__
	<telerik:RadContextMenu HorizontalOffset="150"/>


#### __Figure 2: RadContextMenu with its HorizontalOffset property set__
![RadContextMenu Icon Column](images/RadContextMenu_KeyProperties_03.png)
 
## EventName

__RadContextMenu__ can be opened only when a specific event is raised. __EventName__ is the property through which the given event can be pointed to.

## ModifierKey

The __ModifierKey__ property is used in conjunction with the __EventName__ one. It is used when opening __RadContextMenu__ only for a specific event is needed, but with a specified modifier key pressed as well. It is an enumeration type and has the following values.

## MousePosition

The __MousePosition__ property provides information regarding the position of the mouse at the moment when the menu was opened relative to the element that caused its opening. It returns a __Point__ value.

## UIElement

Returns the instance of the element to which __RadContextMenu__ is attached.

## VerticalOffset

Similarly to the __HorizontalOffset__ property, the __VerticalOffset__ one provides a mechanism for setting the vertical distance between the target origin and the popup alignment point. 

## See Also

 * [Key Modifiers]({%slug radcontextmenu-key-modifiers%})

 * [Opening on a Specific Event]({%slug radcontextmenu-features-opening-on-specific-event%})

 * [Placement]({%slug radcontextmenu-features-placement%})

 * [Opening and Closing Delays]({%slug radcontextmenu-features-opening-and-closing-delays%})