---
title: Work with Selection
page_title: Work with Selection
description: Work with Selection
slug: radtreeview-how-to-how-to-work-with-selection
tags: work,with,selection
publish: False
position: 4
---

# Work with Selection



## 

__RadTreeView__ supports single and multiple selection.

To select an item set the __IsSelected__ property of the __RadTreeViewItem__ to __True__. The __RadTreeViewItem__ and __RadTreeView__ classes expose the following events for working with selection:

* __PreviewSelected__ - fired before the item is selected. You can cancel the selection in the event handler.

* __Selected__ - fired after the item has been selected.

* __SelectionChanged__  - fired each time an item(s) is(are) added or removed from the selection.
		  

* __PreviewUnselected__- fired before the item is unselected. You can cancel the "deselection" of the item in the event handler.

* __Unselected__ - fired after the item has been deselected.

>tipThe order of firing the events is:

* __PreviewSelected__

* __Selected__

* __SelectionChanged__

* __PreviewUnselected__

* __Unselected__

>

If you handle the __PreviewUnselected__event, the item will not be unselected. However, this does not cancel the selection itself. In this way an item will remain selected.

Similarly if you handle the __PreviewSelected__ event, the item will not be selected.

Another way to select an item is to add it to the __SelectedItems__ collection of the __RadTreeView__ class. There are several properties available in the __RadTreeView__ class for working with the selection:

* __SelectedItem__ - current selected item.

* __SelectedContainer__ - current selected item container.

* __SelectedItems__ - collection representing the currently selected items.

* __SelectionMode__ - enumeration that allows you to set the selection mode of the __RadTreeView__. Set it to __SelectionMode.Single__ for single selection, set it to __SelectionMode.Multiple__ for multiple selection. When the selection mode is set to __Multiple__, multiple items can be selected at one time by holding down the control key and clicking multiple items with the mouse or by using the keyboard. A second click on a selected item will unselect that item.

For more information read the topic about [Working with Selection]({%slug radtreeview-feautres-treeviewitem-selection%}).

# See Also

 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})

 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
