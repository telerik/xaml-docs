---
title: Select  the clicked Item of a RadTreeView
page_title: Select  the clicked Item of a RadTreeView
description: Check our &quot;Select  the clicked Item of a RadTreeView&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-how-to-select-the-clicked-item-of-radtreeview
tags: select,,the,clicked,item,of,a,radtreeview
published: True
position: 1
---

# Select  the clicked Item of a RadTreeView

This tutorial will show you how to select the item that was clicked, while opening the __RadContextMenu__. In order to achieve this, you have to do the following things:

* Handle the __Opened__ event of the __RadContextMenu__

* Get an instance of the clicked __RadTreeViewItem__

* Set the __SelectedItem__ of the __RadTreeView__

Before starting, here is a sample __RadTreeView__ with a sample __RadContextMenu__ attached.



<snippet id='radcontextmenu-how-to-select-the-clicked-item-of-radtreeview-block_1-xaml' />


To handle the __Opened__ event attach an event handler to it.



<snippet id='radcontextmenu-how-to-select-the-clicked-item-of-radtreeview-block_2-xaml' />




<snippet id='radcontextmenu-how-to-select-the-clicked-item-of-radtreeview-block_3-cs' />

<snippet id='radcontextmenu-how-to-select-the-clicked-item-of-radtreeview-block_3-vb' />


In it get the instance of the clicked __RadTreeViewItem__ by calling the __GetClickedElement\<T\>()__ method of the __RadContextMenu__.



<snippet id='radcontextmenu-how-to-select-the-clicked-item-of-radtreeview-block_4-cs' />

<snippet id='radcontextmenu-how-to-select-the-clicked-item-of-radtreeview-block_4-vb' />


The last thing to do is to set the __SelectedItem__ property of the __RadTreeView__ to the __instance__ of the __RadTreeView__ item that has been clicked.

>If you are having a dynamic data scenario, where the __RadTreeView__ is bound to a collection, you have to set the __SelectedItem__ property to the __DataContext__ of the clicked __RadTreeViewItem__.



<snippet id='radcontextmenu-how-to-select-the-clicked-item-of-radtreeview-block_5-cs' />

<snippet id='radcontextmenu-how-to-select-the-clicked-item-of-radtreeview-block_5-vb' />


## See Also

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
