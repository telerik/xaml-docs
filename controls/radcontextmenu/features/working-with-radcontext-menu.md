---
title: RadContextMenu Usage
page_title: RadContextMenu Usage
description: Check our &quot;RadContextMenu Usage&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-features-working-with-radcontext-menu
tags: radcontextmenu,usage
published: True
position: 0
---

# RadContextMenu Usage

This article will make you familiar with the basics around the usage of the __RadContextMenu__. The following topics will be discussed:

* [Attach a RadContextMenu to a Control](#attach-a-radcontextmenu-to-a-control)

* [Add Menu Items to the RadContextMenu](#add-menu-items-to-the-radcontextmenu)

* [Get the Clicked Element](#get-the-clicked-element)

## Attach a RadContextMenu to a Control

To attach a __RadContextMenu__ to a control, you have to set the instance of it to the __RadContextMenu.ContextMenu__ attached property.

__Example 1: Attach a RadContextMenu__

<snippet id='radcontextmenu-features-working-with-radcontext-menu-example_1_attach_a_radcontextmenu-xaml' />


__Example 1: Attach a RadContextMenu__

<snippet id='radcontextmenu-features-working-with-radcontext-menu-example_1_attach_a_radcontextmenu-cs' />

<snippet id='radcontextmenu-features-working-with-radcontext-menu-example_1_attach_a_radcontextmenu-vb' />


## Add Menu Items to the RadContextMenu

>The class that represents the individual menu items is __Telerik.Windows.Controls.RadMenuItem__, located in the __Telerik.Windows.Controls.Navigation__ assembly.

>tip To learn more about the __RadMenuItem__ control, please take a look at the [RadMenu's documentation]({%slug radmenu-overview%}).

The __RadContextMenu__ accepts __RadMenuItems__ as child items. Here is a sample declaration of several child menu items.

__Example 2: Add Menu Items__

<snippet id='radcontextmenu-features-working-with-radcontext-menu-example_2_add_menu_items-xaml' />


__Example 2: Add Menu Items__

<snippet id='radcontextmenu-features-working-with-radcontext-menu-example_2_add_menu_items-cs' />

<snippet id='radcontextmenu-features-working-with-radcontext-menu-example_2_add_menu_items-vb' />


## Get the Clicked Element

When an element gets clicked and the __RadContextMenu__ appears, you might need to get the instance of that element. This can be very useful when you have an __ItemsControl__ that integrates with the __RadContextMenu__, as you can get the instance of the item that has been clicked. For this purpose, the __RadContextMenu__ exposes the __GetClickedElement\<T\>()__ method. This will return the first element of type __T__ in the VisualTree, that is part of the route of the __RadContextMenu's__ triggering event.

For example, if you have a __RadTreeView__ with a __RadContextMenu__ attached, and you want to get the instance of the __RadTreeViewItem__, which has been right-clicked, you can use the following lines of code.

__Example 3: Get clicked element__

<snippet id='radcontextmenu-features-working-with-radcontext-menu-example_3_get_clicked_element-cs' />

<snippet id='radcontextmenu-features-working-with-radcontext-menu-example_3_get_clicked_element-vb' />


>tip A more complex example scenario can be found in the [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%}) topic and in the [Select the Clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%}) topic.

## See Also

 * [Opening on a Specific Event]({%slug radcontextmenu-features-opening-on-specific-event%})

 * [Key Modifiers]({%slug radcontextmenu-key-modifiers%})

 * [Placement]({%slug radcontextmenu-features-placement%})

 * [Events - Overview]({%slug radcontextmenu-events-overview%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Select  the Clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})