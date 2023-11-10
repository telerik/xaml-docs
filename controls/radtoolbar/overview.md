---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadToolBar {{ site.framework_name }} control.
slug: radtoolbar-overview
tags: overview
published: True
position: 0
CTAControlName: RadToolBar
---

# {{ site.framework_name }} ToolBar Overview

Thank you for choosing Telerik __RadToolBar__!

__RadToolBar__ is an __ItemsControl__ that can contain a group of controls (items). The __RadToolBar__ can also display its items in accompanying (pop-up) overflow area if the available area is too small.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![RadToolBar](images/RadToolBar.png)

The __RadToolBar__ mimics the functionality and behavior of the Visual Studio toolbar with its __Strip__ and __Overflow__ areas. All the items in the toolbar will jump between the strip and the overflow depending on the toolbar's size. In addition, the developer is able to stick items into one of these areas using the attached __OverflowMode__ property.

By default, when not all items in the __ToolBar__ are visible, the __OverflowButton__ will be enabled so it can display its content. Respectively, it will be disabled when all items in the __ToolBar__ are displayed. In order the __OverflowButton__ to be automatically hidden instead of disabled, set the __AutoHideOverflowButton__ property to __True__. This property has a lower priority compared to  __OverflowButtonVisibility__.

The __RadToolBar__ also enables you to apply conditional styling to its items. The [ToolBarContainerStyleSelector](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.toolbarcontainerstyleselector) class allows you to easily specify different styles for the different control types by providing a collection of [ToolBarContainerStyle](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.toolbarcontainerstyle) objects.

There are also pre-defined styles for many of the standard controls – Button, RadButton, ToggleButton, RadToggleButton, CheckBox, RadioButton, RadRadioButton, RadDropDownButton, TextBox, TextBlock, RadToolBarSeparator{% if site.site_name == 'Silverlight' %}, RadSeparator{% endif %}.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF ToolBar Homepage](https://www.telerik.com/products/wpf/toolbar.aspx)
* [Get Started with the Telerik UI for WPF ToolBar]({%slug radtoolbar-getting-started%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF ToolBar Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also  
 * [Getting Started]({%slug radtoolbar-getting-started%})
 * [ToolBarTray Overview]({%slug radtoolbartray-overview%})
 * [Item Alignment]({%slug radtoolbar-features-itemalignment%})
 * [RadToolBar API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.radtoolbar)
