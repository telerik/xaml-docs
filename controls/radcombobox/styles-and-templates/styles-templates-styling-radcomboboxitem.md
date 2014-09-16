---
title: Styling RadComboBoxItem
page_title: Styling RadComboBoxItem
description: Styling RadComboBoxItem
slug: radcombobox-styles-templates-styling-radcomboboxitem
tags: styling,radcomboboxitem
published: False
position: 3
---

# Styling RadComboBoxItem



The __RadComboBoxItem__can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control. 

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

Load your project in Expression Blend and open the User Control that holds the __RadComboBox__. There are two ways to copy the default style for the __RadComboBoxItem__:

* If you have static __RadComboBoxItems__, you can select one of them in the 'Objects and Timeline' pane and choose *Object -> Edit Style -> Edit a Copy *from the menu. After that you have to apply the generated style to the other __RadComboBoxItems__.

* You can also use the __ItemContainerStyle__ property of the __RadComboBox__. In this way you have to set the style only once and it will be applied to all of the __RadComboBoxItems__. To copy the default style via the __ItemContainerStyle__ property select the __RadComboBox__ holding the items and choose *Object -> Edit Additional Styles -> Edit Generated Item Container (ItemContainerStyle) -> Edit a Copy *from the menu.

You will be prompted for the name of the style and where to be placed.



>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __RadComboBoxItem__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values.

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __RadComboBoxItem.__Their names indicate to which part of the __RadComboBoxItem's__appearance they are assigned.



>tipChanging the value of the resources can be done by clicking on the color indicator or the icon next to them.

Modify the resource to bring the desired appearance to the __RadComboBoxItem__. For more detailed information, please, view the __Example__ section below.

## Example

Here is an example of the above resource modified.



Here is a snapshot of the result, when the mouse is over the __RadComboBoxItem__:



and when the __RadComboBoxItem__ is selected.
