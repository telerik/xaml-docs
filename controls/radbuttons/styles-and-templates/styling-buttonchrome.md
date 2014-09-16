---
title: Styling the ButtonChrome
page_title: Styling the ButtonChrome
description: Styling the ButtonChrome
slug: radbuttons-styles-and-templates-styling-buttonchrome
tags: styling,the,buttonchrome
publish: True
position: 2
---

# Styling the ButtonChrome



The __ButtonChrome__ control was part of the template of the __RadButtons__. It was responsible for the visual appearance of the button. 
     If you're using an older version fo the RadControl, this article will help you style the __ButtonChrome__ control. 
     It can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control. 

You have two options:

* To create an empty style and set it up on your own. 

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

To copy the default style, load your project in Expression Blend and open the User Control that holds the __RadButton__. Edit its template and in the 'Objects and Timeline' pane select the __ButtonChrome__. From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __ButtonChrome__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __ButtonChrome.__Their names indicate to which part of the __RadButton__appearance they are assigned.{% endif %}

# See Also

 * [Template Structures]({%slug radbuttons-styles-and-templates-template-structures%})

 * [Styling the RadButton]({%slug radbuttons-styles-and-templates-styling-the-radbutton%})

 * [Styling the RadDropDownButton]({%slug radbuttons-styles-and-templates-styling-the-radropdownbutton%})

 * [Styling the RadRadioButton]({%slug radbuttons-styles-and-templates-styling-the-radradiobutton%})

 * [Styling the RadSplitButton]({%slug radbuttons-styles-and-templates-styling-the-radsplitbutton%})

 * [Styling the RadToggleButton]({%slug radbuttons-styles-and-templates-styling-the-radtogglebutton%})
