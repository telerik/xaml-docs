---
title: Styling the MapNavigation
page_title: Styling the MapNavigation
description: Styling the MapNavigation
slug: radmap-styles-and-templates-styling-the-mapnavigation
tags: styling,the,mapnavigation
published: True
position: 4
---

# Styling the MapNavigation



The __MapNavigation__exposes a __Style__ property which allows you to apply a style to it and modify its appearance.

You have two options:

* To create an empty style and set it up on your own. 

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

>tipAs the __MapNavigation__control is part of the template of the __RadMap__, you can edit the __RadMap's__ template and directly style that instance of the control. More about styling the __RadMap__ can be found [here]({%slug radmap-styling-and-templates-styling-the-radmap%}).

To copy the default styles, load your project in Expression Blend and open the User Control that holds the __MapNavigation__. In the 'Objects and Timeline' pane, select the __MapNavigation__you want to style. From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __MapNavigation__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of the __MapNavigation____.__ Their names indicate to which part of the __MapNavigation__appearance they are assigned.{% endif %}

>To change the button's default toggled and hover colors, you have to edit their default styles.{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadMap_StylesAndTemplates_StylingMapNavigation_01.png){% endif %}

* __ControlOuterBorderVertical_Normal__ - a brush that represents the border color of the buttons inside the __MapNavigation's__ template.

* __MapNavigationButtonLeftBackground__ - a brush that represents the background color of the left navigation button.

* __MapNavigationArrowLeftMargin__ - represents the margin of the arrow icon inside the left navigation button.

* __MapNavigationButtonLeftCornerRadius__ - represents the corner radius of the left navigation button.

* __MapNavigationButtonSize__ - represents the size of the navigation buttons.

* __MapNavigationButtonLeftMargin__ - represents the margin of the left navigation button.

* __MapNavigationButtonOpacity__ - represents the opacity of the navigation buttons.

* __MapNavigationButtonUpBackground__ - a brush that represents the background color of the upper navigation button.

* __MapNavigationArrowUpMargin__ - represents the margin of the arrow icon inside the upper navigation button.

* __MapNavigationButtonUpCornerRadius__ - represents the corner radius of the upper navigation button.

* __MapNavigationButtonUpMargin__ - represents the margin of the upper navigation button.

* __MapNavigationButtonRightBackground__ - a brush that represents the background color of the right navigation button.

* __MapNavigationArrowRightMargin__ - represents the margin of the arrow icon inside the right navigation button.

* __MapNavigationButtonRightCornerRadius__ - represents the corner radius of the right navigation button.

* __MapNavigationButtonRightMargin__ - represents the margin of the right navigation button.

* __MapNavigationButtonDownBackground__ - a brush that represents the background color of the lower navigation button.

* __MapNavigationArrowDownMargin__ - represents the margin of the arrow icon inside the lower navigation button.

* __MapNavigationButtonDownCornerRadius__ - represents the corner radius of the lower navigation button.

* __MapNavigationButtonDownMargin__ - represents the margin of the lower navigation button.

* __MapNavigationCenterButtonBorderThickness__ - represents the thickness of the border of the central navigation button.

* __MapNavigationCenterButtonBackground__ - a brush that represents the background color of the central navigation button.

* __MapNavigationCenterButtonCornerRadius__ - represents the corner radius of the central navigation button.

* __MapNavigationCenterButtonSize__ - represents the size of the central navigation button.

* __MapNavigationStyle__ - represents the __Style__ applied to the __MapNavigaiton__ control.{% if site.site_name == 'Silverlight' %}

Here is an example of these resources modified:{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadMap_StylesAndTemplates_StylingMapNavigation_02.png){% endif %}{% if site.site_name == 'Silverlight' %}

And here is a snapshot of the result.{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadMap_StylesAndTemplates_StylingMapNavigation_03.png){% endif %}

# See Also

 * [Template Structure]({%slug radmap-styles-and-templates-template-structure%})

 * [Styling the RadMap]({%slug radmap-styling-and-templates-styling-the-radmap%})

 * [Styling the MapCommandBar]({%slug radmap-styles-and-templates-styling-the-mapcommandbar%})

 * [Styling the MapZoomBar]({%slug radmap-styles-and-templates-styling-the-mapzoombar%})

 * [Styling the MapScale]({%slug radmap-styles-and-templates-styling-the-mapscale%})

 * [Styling the MapMouseLocationIndicator]({%slug radmap-styles-and-templates-styling-the-mapmouselocationindicator%})
