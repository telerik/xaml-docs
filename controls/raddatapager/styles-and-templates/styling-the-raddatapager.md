---
title: Styling RadDataPager
page_title: Styling RadDataPager
description: Styling RadDataPager
slug: raddatapager-styles-and-templates-styling-the-raddatapager
tags: styling,the,raddatapager
published: True
position: 2
---

# Styling RadDataPager



>Before reading this topic, you might find it useful to get familiar with the [Template Structure of the RadDataPager]({%slug raddatapager-styles-and-templates-template-structure%}) and the [Template Structure of the DataPagerPresenter]({%slug raddatapager-styles-and-templates-template-structure%}).

 __RadDataPager__ exposes a __Style__ property which allows you to apply a style to it and modify its appearance.

You have two options:

* To create an empty style and set it up on your own. 

* To copy the default style of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

To copy the default styles, load your project in __Expression Blend__ and open the User Control that holds __RadDataPager__. In the ___'Objects and Timeline'___ pane select __RadDataPager__ you want to style. From the menu choose ***Object -> Edit Style -> Edit a Copy***. You will be prompted for the name of the style and where to be placed.

>If you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking ___'OK'___, __Expression Blend__ will generate the default style of __RadDataPager__ control in the __Resources__ section of your __User Control__. The properties available for the style will be loaded in the ___'Properties'___ pane and you will be able to modify their default values. You can also edit the generated __XAML__ in the __XAML View__ or in __Visual Studio__.

As the UI of __RadDataPager__ is wrapped in the __DataPagerPresenter__ control, you have to style it, too. It is to be found in the __ControlTemplate__ for __RadDataPager__. Bring the __ControlTemplate__ into edit by returning to the main scene, selecting __RadDataPager__ and choosing form the menu ***Object -> Edit Template -> Edit Current***. Select the __DataPagerPresenter__ control and from the menu choose ***Object -> Edit Style -> Edit a Copy***. This will generate the default style for it in the __Resources__ section.

>If you want to just style the numeric buttons, you don't need to generate the style for the __DataPagerPresenter__ control. The resources responsible for the buttons get generated with __RadDataPager's__ style.{% if site.site_name == 'Silverlight' %}

If you go to the 'Resources' pane, you will see an editable list of resources generated together with the style and used by it. In this list you will find the brushes, styles and templates needed to change the visual appearance of  __RadDataPager__. Their names indicate to which part of __RadDataPager__ appearance they are assigned.{% endif %}{% if site.site_name == 'Silverlight' %}


![](images/RadDataPager_Styles_and_Templates_StylingTheRadDataPager_01.png)

{% endif %}

* ***RadPager_Indicator*** - represents the brush for the indicators inside the __First, Last, Previous, Next__ buttons.

* ***RadPager_NumericPresenter_Border*** - represents the brush for the border around the numeric buttons.

* ***RadPager_NumericPresenter_Background*** - represents the brush for the background behind the numeric buttons.

* ***RadPager_Separator1*** - represents the first brush for the separator between the buttons group and the textbox group.

* ***RadPager_Separator2*** - represents the second brush for the separator between the buttons group and the textbox group.

* ***DataPagerPresenterTemplate*** - represents the __ControlTemplate__ for the __DataPagerPresenter__.

* ***DataPagerPresenterStyle*** - represents the __Style__ for the __DataPagerPresenter__.

* ***RadDataPagerTemplate*** - represents the __ControlTemplate__ for __RadDataPager__.

* ***RadPager_Background*** - represents the brush for the background of __RadDataPager__.

* ***RadPager_Border*** - represents the brush for the border of __RadDataPager__.

* ***RadPager_Foreground*** - represents the brush for the foreground of __RadDataPager__.

* ***RadPager_Page_TopShadow*** - represents the brush for the shadow of the top of the numeric button.

* ***RadPager_Page_Over*** - represents the brush for the background of the numeric button, when the mouse is over it.

* ***RadPager_Page_Checked*** - represents the brush for the background of the numeric button, when it is selected.

* ***RadPager_Page_Disabled*** - represents the brush for the background of the numeric button's disabled visual element.

* ***RadPageTemplate*** - represents the __ControlTemplate__ for the numeric button.

* ***RadPager_Page_Background*** - represents the brush for the background of the numeric button in its normal state.

* ***RadPager_Page_Border*** - represents the brush for the border of the numeric button.

* ***RadPageStyle*** - represents the __Style__ for the numeric button.

* ***RadDataPagerStyle*** - represents the __Style__ for __RadDataPager__.

## See Also

 * [Template Structure]({%slug raddatapager-styles-and-templates-template-structure%})

 * [Styling Numeric Buttons]({%slug raddatapager-styles-and-templates-styling-the-numeric-buttons%})

 * [Styling Other Elements]({%slug raddatapager-styles-and-templates-styling-the-other-elements%})
