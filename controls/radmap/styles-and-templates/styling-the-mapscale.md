---
title: Styling the MapScale
page_title: Styling the MapScale
description: Styling the MapScale
slug: radmap-styles-and-templates-styling-the-mapscale
tags: styling,the,mapscale
published: True
position: 6
---

# Styling the MapScale

The __MapScale__ exposes a __Style__ property which allows you to apply a style to it and modify its appearance.

You have two options:

* To create an empty style and set it up on your own. 

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

>tip As the __MapScale__ control is part of the template of the __RadMap__, you can edit the __RadMap's__ template and directly style that instance of the control. More about styling the __RadMap__ can be found [here]({%slug radmap-styling-and-templates-styling-the-radmap%}).

To copy the default styles, load your project in Expression Blend and open the User Control that holds the __MapScale__. In the 'Objects and Timeline' pane, select the __MapScale__ you want to style. From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tip If you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __MapScale__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.

{% if site.site_name == 'Silverlight' %}
If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __MapScale__. Their names indicate to which part of the __MapScale__ appearance they are assigned.

![](images/RadMap_StylesAndTemplates_StylingMapScale_01.png)
{% endif %}

* __MapScaleForeground__ - a brush that represents the foreground color of the control.

* __MapScaleBackground__ - a brush that represents the background color of the scale element.

* __MapScaleBorderBrush__ - a brush that represents the border color of the scale element.

* __MapScaleLabelBackground__ - a brush that represents the background color of the label element.

* __MapScaleLabelBorderBrush__ - a brush that represents the inner border color of the label element.

* __MapScaleLabelOuterBorderBrush__ - a brush that represents the outer border color of the label element.

* __MapScaleLabelOuterBorderThickness__ - represents the thickness of the outer border of the label element.

* __MapScaleLabelCornerRadius__ - represents the corner radius of the inner border of the label element.

* __MapScaleLabelOuterCornerRadius__ - represents the corner radius of the outer border of the label element.

* __MapScaleStyle__ - represents the __Style__ applied to the __MapScale__ control.

{% if site.site_name == 'Silverlight' %}
Here is an example of these resources modified:

![](images/RadMap_StylesAndTemplates_StylingMapScale_02.png)

And here is a snapshot of the result:

![](images/RadMap_StylesAndTemplates_StylingMapScale_03.png)
{% endif %}

## See Also
 * [Template Structure]({%slug radmap-styles-and-templates-template-structure%})
 * [Styling the RadMap]({%slug radmap-styling-and-templates-styling-the-radmap%})
 * [Styling the MapCommandBar]({%slug radmap-styles-and-templates-styling-the-mapcommandbar%})
 * [Styling the MapNavigation]({%slug radmap-styles-and-templates-styling-the-mapnavigation%})
 * [Styling the MapZoomBar]({%slug radmap-styles-and-templates-styling-the-mapzoombar%})
 * [Styling the MapMouseLocationIndicator]({%slug radmap-styles-and-templates-styling-the-mapmouselocationindicator%})