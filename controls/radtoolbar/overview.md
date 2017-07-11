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

The __RadToolBar__ also enables you to apply conditional styling to its items. The [ToolBarContainerStyleSelector](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_toolbarcontainerstyleselector.htm) class allows you to easily specify different styles for the different control types by providing a collection of [ToolBarContainerStyle](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_toolbarcontainerstyle.htm) objects.

There are also pre-defined styles for many of the standart controls – Button, RadButton, ToggleButton, RadToggleButton, CheckBox, RadioButton, RadRadioButton, RadDropDownButton, TextBox, TextBlock, RadToolBarSeparator{% if site.site_name == 'Silverlight' %}, RadSeparator{% endif %}.

## See Also

 * [Getting Started]({%slug radtoolbar-getting-started%})

 * [ToolBarTray Overview]({%slug radtoolbartray-overview%})

 * [Item Alignment]({%slug radtoolbar-features-itemalignment%})

 * [RadToolBar API Reference](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_radtoolbar.htm)