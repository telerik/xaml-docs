---
title: How to Control the Selection When the SelectedItem is Removed
page_title: How to Control the Selection When the SelectedItem is Removed
description: How to Control the Selection When the SelectedItem is Removed
slug: radtabcontrol-how-to-control-selected-item-on-removed-tab
tags: how,to,control,the,selection,when,the,selecteditem,is,removed
published: True
position: 14
---

# How to Control the Selection When the SelectedItem is Removed



The __RadTabControl__ allows you to control the selection behavior of the control in case the __SelectedItem__ is removed. 

## SelectedItemRemoveBehaviour property

The __SelectedItemRemoveBehaviour__ property allows you to choose which __RadTabItem__ should be selected next in case the currently selected __RadTabItem__ is removed. The property is enumeration of type __SelectedItemRemoveBehaviour__ and it exposes the following members:

* __SelectNone__ - use it to set the __RadTabControl.SelectedItem__ to null 

* __SelectFirst__ - use it to select the first item of the __RadTabControl.Items__ collection

* __SelectLast__ - use it to select the last item of the __RadTabControl.Items__ collection

* __SelectPrevious__ - use it to select the __RadTabItem__ positioned before the __SelectedItem__ in the __RadTabControl.Items__ collection

* __SelectNext__ - use it to select the __RadTabItem__ positioned after the __SelectedItem__ in the __RadTabControl.Items__ collection

# See Also

 * [How To Add Close Button to the Tab Headers]({%slug radtabcontrol-how-to-add-close-button-to-the-tab-headers%})[TabControlDatabinding](http://demos.telerik.com/silverlight/#TabControl/Databinding)
