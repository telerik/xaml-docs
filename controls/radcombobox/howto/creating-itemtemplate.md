---
title: Creating ItemTemplate and SelectionBoxTemplate
page_title: Creating ItemTemplate and SelectionBoxTemplate
description: Check our &quot;Creating ItemTemplate and SelectionBoxTemplate&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-creating-itemtemplate
tags: creating,itemtemplate,and,selectionboxtemplate
published: True
position: 1
include_in_navigation: False
---

# Creating ItemTemplate and SelectionBoxTemplate

The RadComboBox exposes the __ItemTemplate__ and __SelectionBoxTemplate__ properties which allow you to define a custom datatemplate for its drop down items and for its selected item when the RadComboBox is not editable. 

## Define an ItemTemplate

If you want RadComboBox to visualize more information, you can define a custom DataTemplate and set it to the __ItemTemplate__ property of the control. This template will be applied to the selected item(when RadComboBox is not editable), as well as, all of the items displayed in the dropdown. For an example implementation, check out the [Define a Custom ItemTemplate]({%slug radcombobox-populating-with-data-binding-to-object%}) section of the __Binding to Collection__ article in our documentation.

## Define a SelectionBoxTemplate

In order to define a separate template for the selected item of a Non-Editable RadComboBox, you can set the __SelectionBoxTemplate__ property of the control to a custom datatemplate. For an example implementation, check out the [SelectionBoxTemplate]({%slug radcombobox-populating-with-data-selectionbox%}) article in our documentation.

## See Also

 * [Setting up AutoComplete]({%slug radcombobox-setting-up-autocomplete%})
 * [RadComboBox Virtualization]({%slug radcombobox-howto-virtualization%})
