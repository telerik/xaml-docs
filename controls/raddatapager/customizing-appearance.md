---
title: Customizing Appearance
page_title: Customizing Appearance
description: Check our &quot;Customizing Appearance&quot; documentation article for the RadDataPager {{ site.framework_name }} control.
slug: raddatapager-styles-and-templates-styling-the-numeric-buttons
tags: styling,the,numeric,buttons
published: True
position: 7
---

# Customizing Appearance

RadDataPager provides few properties that allows you to customize the appearance of its elements.

## Customizing the Numeric Buttons

The numeric buttons of the DataPager components can be customized via the `NumericButtonStyle` property. The property expects a `Style` object with its `TargetType` set to `RadRadioButton`.

__Setting NumericButtonStyle__
<snippet id='raddatapager-customizing-appearance-setting_numericbuttonstyle-xaml' />


![{{ site.framework_name }} RadDataPager Customized Numeric Buttons](images/raddatapager-styles-and-templates-styling-the-numeric-buttons-0.png)

The data context passed to the button is an object of type {% if site.site_name == 'Silverlight' %}[PageViewModel](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.controls.data.datapager.pageviewmodel){% else %}[PageViewModel](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.data.datapager.pageviewmodel){% endif %}. The `IsCurrent` property of the `PageViewModel` can be used to determine if button is selected (the current page button).

## Customizing the TextBox

The text area that allows you to enter the page index can be customized via the `TextBoxStyle` property. The property expects a `Style` object with its `TargetType` set to `TextBox`.

__Setting the TextBoxStyle__
<snippet id='raddatapager-customizing-appearance-setting_the_textboxstyle-xaml' />


![{{ site.framework_name }} RadDataPager Customized TextBox](images/raddatapager-styles-and-templates-styling-the-numeric-buttons-1.png)