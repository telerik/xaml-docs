---
title: Styling DataFormDataField
page_title: Styling DataFormDataField
description: Styling DataFormDataField
slug: raddataform-styles-and-templates-styling-dataformdatafield
tags: styling,dataformdatafield
published: True
position: 4
---

# Styling DataFormDataField



> Before reading this topic, you might find useful to get familiar with the[Template Structure of the DataFormDataField  control](D30D9A7D-C51D-4EF8-B58D-C0DC967FCB41#DataFormDataField).
        

The __RadDataForm__ fields can be styled by creating an appropriate __Style__ and setting it to the __DataFieldStyle__ property of the __RadDataForm__.
        

You have two options:
        

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

Load your project in Expression Blend and open the User Control that holds the __RadDataForm__.  You have to use a dummy control in order to get the default style. To create one, find the __DataFormDataField__ control in the 'Assets'  and draw one on the art board. In the 'Objects and Timeline' pane select the __DataFormDataField__ that you've drawn and from the menu choose  Object -> Edit Style -> Edit a Copy. You will be prompted for the name of the style and where to be placed.
        

>If you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.
        

After clicking 'OK', Expression Blend will generate the default style of the __DataFormDataField__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.

To apply the style to the real cells, set it to the __DataFieldStyle__ property of the __RadDataForm__.



#### __XAML__

{{region raddataform-styles-and-templates-styling-dataformdatafield_0}}

	<telerik:RadDataForm x:Name="dataForm" DataFieldStyle="{StaticResource DataFormDataFieldStyle}"/>
	{{endregion}}


