---
title: Styling the RadRibbonToggleButton
page_title: Styling the RadRibbonToggleButton
description: Styling the RadRibbonToggleButton
slug: radribbonview-styling-ribbontogglebutton
tags: styling,the,radribbontogglebutton
published: True
position: 13
---

# Styling the RadRibbonToggleButton



The __RadRibbonToggleButton__ can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control.
			

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

In order to copy the default style, load your project in Expression Blend and open the User Control that holds the __RadRibbonView__. In the 'Objects and Timeline' pane select the __RadRibbonToggleButton__ you want to style.
				

{% if site.site_name == 'Silverlight' %}![](images/RibbonView_Styling_ToggleButton_Locate.png){% endif %}{% if site.site_name == 'WPF' %}![](images/RibbonView_Styling_ToggleButton_LocateWPF.png){% endif %}

From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.
				![](images/RibbonView_Styling_ToggleButton_CreateStyle.png)

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __RadRibbonToggleButton__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values.
				{% if site.site_name == 'Silverlight' %}

If you want to change the __ControlTemplate__ elements of the __RadRibbonToggleButton__ select the style in the 'Objects and Timeline' pane, right-click on it and choose Edit Template -> Edit Current. In the same pane the element parts for the __RadRibbonToggleButton's__ template will get loaded.
					{% endif %}{% if site.site_name == 'WPF' %}

You can modify these properties to achieve the desired appearance. However the most of the visual parts of the __RadRibbonToggleButton__ have to be styled in the template of it. To modify it select the style in the 'Objects and Timeline' pane, right-click on it and choose *Edit Template -> Edit Current*. In the same pane the element parts for the __RadRibbonToggleButton's__ template will get loaded.
					{% endif %}![Ribbon View Styling Toggle Button Control Template](images/RibbonView_Styling_ToggleButton_ControlTemplate.png){% if site.site_name == 'WPF' %}

Change the elements' properties untill you get the desired look.

>tipYou can also modify the default __VisualStates__ defined for the __RadRibbonToggleButton__. They are located in the 'States' pane.
						![Ribbon View Styling Toggle Button States](images/RibbonView_Styling_ToggleButton_States.png){% endif %}{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __RadRibbonToggleButton____.__Their names indicate to which part of the __RadRibbonToggleButton's__ appearance they are assigned.
					![](images/RibbonView_Styling_ToggleButton_Resources.png)

* __RadRibbonBarButtonSelectedBorder -__ a brush that represents the color of the __RadRibbonToggleButton's__ border, when the button is toggled.
              

* __RadRibbonBarButtonSelectedBackground -__ a brush that represents the background color of the __RadRibbonToggleButton__, when the button is toggled.
              

* __RadRibbonBarButtonSelectedBorderInner -__a brush that represents the color of the __RadRibbonToggleButton's__inner border, when the button is toggled.
              

* __RadRibbonBarButtonOverBorder__ - a brush that represents the color of the __RadRibbonToggleButton's__ border, when the mouse is over it.
              

* __RadRibbonBarButtonOverBackground__ - a brush that represents the background color of the __RadRibbonToggleButton__, when the mouse is over it.
              

* __RadRibbonBarButtonOverBorderInner__ - a brush that represents the color of the __RadRibbonToggleButton's__ inner border, when the mouse is over it.
              

* __RadRibbonBarButtonPressedBorder__ - a brush that represents the color of the __RadRibbonToggleButton's__ border, when the button gets pressed.
              

* __RadRibbonBarButtonPressedBackground__ - a brush that represents the background color of the __RadRibbonToggleButton__, when the button gets pressed.
              

* __RadRibbonBarButtonPressedBorderInner__ - a brush that represents the color of the __RadRibbonToggleButton's__ inner border, when the button gets pressed.
              

* __RadRibbonToggleButtonStyle__ - represents the style created for the __RadRibbonToggleButton__.
              

>tipChanging the value of the resources can be done by clicking on the color indicator or the icon next to them.

Modify the resource to bring the desired appearance to the __RadRibbonToggleButton__. For more detailed information, please, view the 
						[Example](#example) section below.
					{% endif %}

>tipBy default the __Background__ and the __BroderBrush__ properties of the __RadRibbonToggleButton__are transparent. To modify them, edit the __RadRibbonToggleButtonStyle__resource and change these properties in the 'Properties' pane. The __Foreground__property of the button can also be set from there.
          

# See Also

 * [Styling the RadRibbonView]({%slug radribbonview-styling-ribbonview%})

 * [Styling the RadRibbonTab]({%slug radribbonview-styling-ribbontab%})

 * [Styling the RadRibbonGroup]({%slug radribbonview-styling-ribbongroup%})

 * [Styling the RadRibbonButton]({%slug radribbonview-styling-ribbonbutton%})

 * [Styling the RadRibbonRadioButton]({%slug radribbonview-styling-ribbonradiobutton%})

 * [Styling the RadRibbonSplitButton]({%slug radribbonview-styling-ribbonsplitbutton%})

 * [Styling the RadRibbonDropDownButton]({%slug radribbonview-styling-ribbondropdownbutton%})
