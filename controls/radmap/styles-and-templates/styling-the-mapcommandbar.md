---
title: Styling the MapCommandBar
page_title: Styling the MapCommandBar
description: Styling the MapCommandBar
slug: radmap-styles-and-templates-styling-the-mapcommandbar
tags: styling,the,mapcommandbar
published: True
position: 3
---

# Styling the MapCommandBar

The __MapCommandBar__ exposes a __Style__ property which allows you to apply a style to it and modify its appearance.

You have two options:

* To create an empty style and set it up on your own. 

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

>tip As the __MapCommandBar__ control is part of the template of the __RadMap__, you can edit the __RadMap's__ template and directly style that instance of the control. More about styling the __RadMap__ can be found [here]({%slug radmap-styling-and-templates-styling-the-radmap%}).

To copy the default styles, load your project in Expression Blend and open the User Control that holds the __MapCommandBar__. In the 'Objects and Timeline' pane, select the __MapCommandBar__ you want to style. From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tip If you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __MapCommandBar__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.

{% if site.site_name == 'Silverlight' %}
If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __MapCommandBar__. Their names indicate to which part of the __MapCommandBar__ appearance they are assigned.
{% endif %}

>To change the button's default toggled and hover colors, you have to edit their default styles.

{% if site.site_name == 'Silverlight' %}
![](images/RadMap_StylesAndTemplates_StylingMapCommandBar_01.png)
{% endif %}

* __ControlOuterBorderVertical_Normal__ - a brush that represents the border color of the buttons inside the __MapCommandBar__ control.

* __MapDropDownButtonBackground__ - a brush that represents the background color of the drop down button with an eye-like icon.

* __MapEyePathFill__ - a brush that represents the fill color of the eye shape.

* __MapEyePathStroke__ - a brush that represents the stroke color of the eye shape.

* __MapEyeEllipseFill__ - a brush that represents the fill color of the iris in the eye shape.

* __MapEyeEllipseStroke__ - a brush that represents the stroke color of the iris in the eye shape.

* __MapDdropDownOuterBorderBrush__ - a brush that represents the outer border color of the button's drop down.

* __MapDropDownOuterBackground__ - a brush that represents the outer background color of the button's drop down.

* __MapDropDownBorderBrush__ - a brush that represents the inner border color of the button's drop down.

* __MapDropDownBackground__ - a brush that represents the inner background color of the button's drop down.

* __MapButtonBackground__ - a brush that represents the background color of the command buttons inside the drop down.

* __MapDropDownButtonOpacity__ - represents the opacity value of the command buttons inside the drop down.

* __MapCommandBarStyle__ - represents the __Style__ applied to the __MapCommandBar__. 

{% if site.site_name == 'Silverlight' %}
Here is an example of these resources modified:

![](images/RadMap_StylesAndTemplates_StylingMapCommandBar_02.png)

And here is a snapshot of the result:

![](images/RadMap_StylesAndTemplates_StylingMapCommandBar_03.png)
{% endif %}

# See Also
 * [Template Structure]({%slug radmap-styles-and-templates-template-structure%})
 * [Styling the RadMap]({%slug radmap-styling-and-templates-styling-the-radmap%})
 * [Styling the MapNavigation]({%slug radmap-styles-and-templates-styling-the-mapnavigation%})
 * [Styling the MapZoomBar]({%slug radmap-styles-and-templates-styling-the-mapzoombar%})
 * [Styling the MapScale]({%slug radmap-styles-and-templates-styling-the-mapscale%})
 * [Styling the MapMouseLocationIndicator]({%slug radmap-styles-and-templates-styling-the-mapmouselocationindicator%})