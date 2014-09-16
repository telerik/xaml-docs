---
title: Styling the QuickAccessToolbar
page_title: Styling the QuickAccessToolbar
description: Styling the QuickAccessToolbar
slug: radribbonview-styling-quickaccesstoolbar
tags: styling,the,quickaccesstoolbar
publish: True
position: 5
---

# Styling the QuickAccessToolbar



The __RadRibbonView QuickAccessToolBar__ control can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control.
			

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

In order to copy the default style, load your project in Expression Blend and open the User Control that holds the __RadRibbonView__. In the 'Objects and Timeline' pane select the __QuickAccessToolBar__ you want to style.
				{% if site.site_name == 'Silverlight' %}![](images/RibbonView_Styling_QAT_Locate.png){% endif %}{% if site.site_name == 'WPF' %}![](images/RibbonView_Styling_QAT_LocateWPF.png){% endif %}

From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.
				![](images/RibbonView_Styling_QAT_CreateStyle.png)

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __QuickAccessToolBar__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values.
				{% if site.site_name == 'Silverlight' %}

If you want to change the __ControlTemplate__ elements of the __QuickAccessToolBar__ select the style in the 'Objects and Timeline' pane, right-click on it and choose Edit Template -> Edit Current. In the same pane the element parts for the __QuickAccessToolBar's__ template will get loaded.
					{% endif %}{% if site.site_name == 'WPF' %}

You can modify these properties to achieve the desired appearance. However the most of the visual parts of the __QuickAccessToolBar__ have to be styled in the template of it. To modify it select the style in the 'Objects and Timeline' pane, right-click on it and choose *Edit Template -> Edit Current*. In the same pane the element parts for the __QuickAccessToolBar's__ template will get loaded.
					{% endif %}![](images/RibbonView_Styling_QAT_ControlTemplate.png){% if site.site_name == 'WPF' %}

Change the elements' properties untill you get the desired look.

>tipYou can also modify the trigger defined for the __QuickAccessToolBar__. It is located in the 'Triggers' pane.
						![](images/RibbonView_Styling_QAT_Triggers.png){% endif %}{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __QuickAccessToolBar__.____Their names indicate to which part of the __QuickAccessToolBar's__appearance they are assigned.
					![](images/RibbonView_Styling_QAT_Resources.png)

* 
							QatBelowBackgroundBrush - a brush that represents the background color of the __QuickAccessToolBar__, when it is positioned bellow the RibbonView control
						

* 
							QatBelowOuterBorderBrush - a brush that represents the color of the __QuickAccessToolBar__'s border, when it is positioned bellow the RibbonView control
						

* 
							QatButtonArrow - a brush that represents the background color of the __Quick Access Menu____Button__ indicator
						

* 
							QatButtonArrowHighlight - a brush that represents the color of the __Quick Access Menu____Button__ indicator's border
						

* 
							QuickAccessToolBarStyle - represents the style applied to the __QuickAccessToolBar__

>tipChanging the value of the resources can be done by clicking on the color indicator or the icon next to them.

Modify the resource to bring the desired appearance to the __QuickAccessToolBar__. For more detailed information, please, view the __Example__ section below.
					{% endif %}

# See Also

 * [Styling the RadRibbonView]({%slug radribbonview-styling-ribbonview%})

 * [RadRibbonView Template Structure]({%slug radribbonview-styling-templatestructure%})

 * [Styling the RadRibbonView TitleBar]({%slug radribbonview-styling-titlebar%})

 * [Styling the ApplicationButton]({%slug radribbonview-styling-applicationbutton%})
