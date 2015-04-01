---
title: Add Check Boxes (Radio Buttons) Next to Each Item
page_title: Add Check Boxes (Radio Buttons) Next to Each Item
description: Add Check Boxes (Radio Buttons) Next to Each Item
slug: radtreeview-how-to-add-checkboxes-next-to-each-item
tags: add,check,boxes,(radio,buttons),next,to,each,item
published: True
position: 7
---

# Add Check Boxes (Radio Buttons) Next to Each Item

This tutorial demonstrates how to take advantage of the built-in CheckBox support in the __RadTreeViewItems__.

__RadTreeView__ provides check boxes displayed next to each item. Enable this behavior by setting the __IsOptionElementsEnabled__ property of the __RadTreeView__ to __True__.

To handle the change of the item check state use the __PreviewChecked__, __Checked__, __PreviewUnchecked__ and __Unchecked__ events. These events are available both on the __RadTreeView__ and on the __RadTreeViewItem__ classes.

To see the Item check state use the __CheckState__ property of the __RadTreeViewItem__ class. The __CheckState__ property is a __ToggleState__ enumeration and has the following values:		

* __On__ - the Item is checked.
* __Off__ - the Item is not checked.
* __Indeterminate__ - the Item has items that are checked and items that are not checked. This state is available only when the RadTreeView __IsTriStateMode__ property is set to __True__.

If the check boxes need to have "tri-states" set the __IsTriStateMode__ property of the __RadTreeView__ to __True__. When this mode is activated the __CheckState__ property of each item is depending on the __CheckState__ property of its child items. In this mode the item will be checked only if all of its child items are checked too.

> Please keep in mind that the __RadTreeView__ 'tri-state' check boxes logic is desined to work in declaratively populated __RadTreeView__ control. This is why if your applicaiton implements an MVVM approach and the __RadTreeView__ is databound, it's best to define custom 'tri-state' logic in your ViewModels following [this  tutorial]({%slug radtreeview-howto-tri-state-mvvm%}).

For more information, read the topic about [CheckBox Support]({%slug check-box-support%}).

# See Also
 * [ItemEditTemplate]({%slug radtreeview-populating-with-data-item-edit-template%})
 * [Implement a Tri-State CheckBox logic using MVVM]({%slug radtreeview-howto-tri-state-mvvm%})
 * [Expand and Collapse Items]({%slug radtreeview-how-to-expand-and-collapse-items%})