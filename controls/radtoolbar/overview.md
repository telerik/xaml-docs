---
title: Overview
page_title: Overview
description: Overview
slug: radtoolbar-overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'Silverlight' %}
![RadToolBar Silevrlight Icon](images/toolbar_sl_icon.png)
{% endif %}

{% if site.site_name == 'WPF' %}
![RadToolBar WPF Icon](images/toolbar_wpf_icon.png)
{% endif %}

Thank you for choosing Telerik __RadToolBar__!

![RadToolBar](images/RadToolBar.png)

__RadToolBar__ is an __ItemsControl__ that can contain a group of controls (items). The __RadToolBar__ can also display its items in accompanying (pop-up) overflow area if the available area is too small.

The __RadToolBar__ mimics the functionality and behavior of the Visual Studio toolbar with its __Strip__ and __Overflow__ areas. All the items in the toolbar will jump between the strip and the overflow depending on the toolbar's size. In addition, the developer is able to stick items into one of these areas using the attached __OverflowMode__ property.

By default, when not all items in the __ToolBar__ are visible, the __OverflowButton__ will be enabled so it can display its content. Respectively, it will be disabled when all items in the __ToolBar__ are displayed. In order the __OverflowButton__ to be automatically hidden instead of disabled, set the __AutoHideOverflowButton__ property to __True__. This property has a lower priority compared to  __OverflowButtonVisibility__.

The __RadToolBar__ also enables you to apply conditional styling to its items. The [ToolBarContainerStyleSelector](https://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_toolbarcontainerstyleselector.htm) class allows you to easily specify different styles for the different control types by providing a collection of [ToolBarContainerStyle](https://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_toolbarcontainerstyle.htm) objects.

There are also pre-defined styles for many of the standart controls – Button, RadButton, ToggleButton, RadToggleButton, CheckBox, RadioButton, RadRadioButton, RadDropDownButton, TextBox, TextBlock, RadToolBarSeparator{% if site.site_name == 'Silverlight' %}, RadSeparator{% endif %}.

## See Also  
 * [Getting Started]({%slug radtoolbar-getting-started%})
 * [ToolBarTray Overview]({%slug radtoolbartray-overview%})
 * [Item Alignment]({%slug radtoolbar-features-itemalignment%})
 * [RadToolBar API Reference](https://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_radtoolbar.htm)
