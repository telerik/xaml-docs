---
title: Styling the RadContextMenu
page_title: Styling the RadContextMenu
description: Styling the RadContextMenu
slug: radcontextmenu-styles-and-templates-styling-the-context-menu
tags: styling,the,radcontextmenu
publish: True
position: 2
---

# Styling the RadContextMenu

{% if site.site_name == 'Silverlight' %}

>tipTo learn about styling and templating the __RadMenuItem__, please take a look at the [Styles and Templates](http://www.telerik.com/help/silverlight/radmenu-styles-and-templates-overview.html) section of the __RadMenu's__ help.{% endif %}{% if site.site_name == 'WPF' %}

>tipTo learn about styling and templating the __RadMenuItem__, please take a look at the [Styles and Templates](http://www.telerik.com/help/wpf/radmenu-styles-and-templates-overview.html) section of the __RadMenu's__ help.{% endif %}

The __RadContextMenu__can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control. 

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

To copy the default style, load your project in Expression Blend. As the attached __RadContextMenu__ is not visible in Expression Blend you have to use a dummy. From the 'Assets' pane select the __RadContextMenu__ control and draw one. In the 'Objects and Timeline' pane select it and from the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __RadContextMenu__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.

>tipAfter finishing with the style, you can set it to the desired __RadContextMenu__ control. Don't forget to delete the dummy you have drawn in the beginning.{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __RadContextMenu.__Their names indicate to which part of the __RadContextMenu__appearance they are assigned.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadContextMenu_Styling_RadContextMenu_01.png){% endif %}

* __PanelBackground__ - a brush that represents the background of the main content area.

* __PanelBorderBrush__ - a brush that represents the color of the __RadContextMenu's__ borders.

* __MenuIconAreaBackground__ - a brush that represents the background of the menu icon area.

* __RadContetntMenuStyle__ - the default Style generated for the __RadContextMenu__.

>tipChanging the value of the resources can be done by clicking on the color indicator or the icon next to them.{% if site.site_name == 'Silverlight' %}

Modify the resource to bring the desired appearance to the __RadContextMenu__. {% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadContextMenu_Styling_RadContextMenu_02.png){% endif %}{% if site.site_name == 'Silverlight' %}

Here is a snapshot of the result.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadContextMenu_Styling_RadContextMenu_03.png){% endif %}

# See Also

 * [Styles and Templates - Overview]({%slug radcontextmenu-styles-and-templates-overview%})

 * [Template Structure]({%slug radcontextmenu-styles-and-templates-template-structure%})

 * [Visual Structure]({%slug radcontextmenu-visual-structure%})
