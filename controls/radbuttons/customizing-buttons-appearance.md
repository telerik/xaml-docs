---
title: Customizing Button Appearance
page_title: Customizing Buttons Appearance
description: Check our &quot;Customizing Buttons Appearance&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-customizing-buttons-appearance
tags: styling, templates, style, customize
published: True
position: 6
---

# Customizing the Buttons Appearance

This article describes how to customize the buttons from the RadButtons suite.

To customize the appearance of the __RadButtons__, you can use the standard properties that are provided by the `Control` class, like `Background`, `Foreground`, `Effect`, etc. In addition to that, the buttons expose a couple of extra properties described below. Also, the attached properties from the [ThemeHelper]({%slug styling-appearance-theme-helper%}) class can be used to easily change some of the brushes used by the buttons.

## Setting the Corner Radius

The corners of the button can be rounded by setting the `CornerRadius` property.

<snippet id='radbuttons-customizing-buttons-appearance-block_1-xaml' />

## Setting Background Brush Visibility 

The background brush of the button in its __Normal__ state can be hidden via the `IsBackgroundVisible` property. This is helpful when you want to hide the backround without handling brush objects.

<snippet id='radbuttons-customizing-buttons-appearance-block_2-xaml' />

## Customizing Button Styles

To customize the button styles, you can define a `Style` object and set the needed button properties. 

To modify the template of a button, you can set the `Template` property. This approach can be used for more complex or specific customizations which are not possible with the available properties. 

The following example shows how to define implicit styles for all available RadButton elements. An implicit style is a `Style` object without its `x:Key` set, which will apply it to all elements of the corresponding `TargetType` in the style's scope.

__Implicit styles for the RadButton elements__
<snippet id='radbuttons-customizing-buttons-appearance-implicit_styles_for_the_radbutton_elements-xaml' />

If you need to apply a custom `Style` to a specific button instance, you can set its `x:Key` and then assign the `Style` property of the button.

__An explicit style for assigned to a RadButton element__
<snippet id='radbuttons-customizing-buttons-appearance-an_explicit_style_for_assigned_to_a_radbutton_element-xaml' />

In case you need to modify the `ControlTemplate` of a button, you can [open the Telerik.Windows.Controls.xaml file]({%slug styling-apperance-editing-control-templates%}) and copy the template of the corresponding button in your project, and then change it as needed.


