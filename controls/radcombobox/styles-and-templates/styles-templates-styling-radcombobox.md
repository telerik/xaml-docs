---
title: Styling RadComboBox
page_title: Styling RadComboBox
description: Styling RadComboBox
slug: radcombobox-styles-templates-styling-radcombobox
tags: styling,radcombobox
publish: False
position: 2
---

# Styling RadComboBox



The __RadComboBox__can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control. 

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

To copy the default style, load your project in Expression Blend and open the User Control that holds the __RadComboBox__. In the 'Objects and Timeline' pane select the __RadComboBox__you want to style.



From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.



>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __RadComboBox__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values.

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __RadComboBox.__Their names indicate to which part of the __RadComboBox'__appearance they are assigned.



>tipChanging the value of the resources can be done by clicking on the color indicator or the icon next to them.

Modify the resource to bring the desired appearance to the __RadComboBox__. For more detailed information, please, view the __Example__ section below.

## Example

Here is an example of the above resource modified.



Here is a snapshot of the result, when the mouse is over the __RadComboBox__:



and when the __RadComboBox__ is expanded.


