---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadNumericUpDown {{ site.framework_name }} control.
slug: radnumericupdown-overview
tags: overview
published: True
position: 0
CTAControlName: RadNumericUpDown
---

# {{ site.framework_name }} NumericUpDown Overview

__RadNumericUpDown__ provides a rich user experience by allowing users to define various value formats, as well as additionally customize them to meet the customers' business requirements. Besides the predefined numeric, percentage and currency formats, developers can also create their custom formats. Additionally, the control allows you to define minimum and maximum values to which the user can increment/decrement the input’s value. 

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![{{ site.framework_name }} RadNumericUpDown Overview](images/RadNumericUpDown_General.png)

## Key Features

* __Formatting options__: You can set different formatting options to be applied over the control's value. Read more about this in the [Formatting]({%slug radnumericupdown-formatting%}) article.

* __Keyboard and mouse support__: The control supports updating the value via the keyboard and the mouse. You can do that with the mouse wheel or the up/down and page up/down keys. Read more about this in the [Keyboard Support]({%slug radnumericupdown-navigation%}) article.

* __Different display modes__: RadNumericUpDown allows you to change between two display modes. The default one is the up-down mode that shows a textbox input and paired arrow buttons next to it. And the other one displays only the arrow buttons. You can switch between the modes via the __ShowTextBox__ boolean property.

* __Custom value change step__: The control allows you to define the value step that will be applied to the value upon each increase/decrease. Read more about this in the [Behavior]({%slug radnumericupdown-behavior%}) article.

* __Read-only mode__: RadNumericUpDown supports read-only mode in which the end user cannot set custom values.

>tip Get started with the control with its [Getting Started]({%slug radnumericupdown-drag-and-drop%}) help article that shows how to use it in a basic scenario.

> Check out the demos at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#NumericUpDown){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF NumericUpDown Homepage](https://www.telerik.com/products/wpf/numericupdown.aspx)
* [Get Started with the Telerik UI for WPF NumericUpDown]({%slug radnumericupdown-drag-and-drop%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF NumericUpDown Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also  
 * [Visual Structure]({%slug radnumericupdown-structure%})
 * [Behavior]({%slug radnumericupdown-behavior%})
 
