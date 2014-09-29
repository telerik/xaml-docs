---
title: Styling the RadRichTextBox
page_title: Styling the RadRichTextBox
description: Styling the RadRichTextBox
slug: radrichtextbox-styles-and-templates-styling-radrichtextbox
tags: styling,the,radrichtextbox
published: True
position: 2
---

# Styling the RadRichTextBox



The __RadRichTextBox__can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control. 

You have two options:

* To create an empty style and set it up on your own. 

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

To copy the default style, load your project in Expression Blend and open the User Control that holds the __RadRichTextBox__. In the 'Objects and Timeline' pane, select the __RadRichTextBox__you want to style. From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __RadRichTextBox__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio. For example, you can change the background of the __RadRichTextBox__ by modifying the __Background__ property.

# See Also

 * [Styles and Templates - Overview]({%slug radrichtextbox-styles-and-tempaltes-overview%})

 * [Template Structure]({%slug radrichtextbox-styles-and-templates-template-structure%})
