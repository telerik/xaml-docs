---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the on-screen RadVirtualKeyboard WPF control.
slug: radvirtualkeyboard-overview
tags: overview
published: True
position: 0
CTAControlName: RadVirtualKeyboard
---

# {{ site.framework_name }} VirtualKeyboard Overview

VirtualKeyboard is a visual keyboard component rendered on the screen that mimics keyboard interactions without a phyisical device.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![{{ site.framework_name }} RadVirtualKeyboard Overview](images/radvirtualkeyboard-overview-1.png)

>tip Get started with the control with its [Getting Started]({%slug radvirtualkeyboard-getting-started%}) help article that shows how to use it in a basic scenario.

## Key Features

* __Native key input__&mdash;The keyboard device is not focusable and each button click sends a native key down action that is passed to the currently focused element. This means that no special code for binding the keyboard component with the input element is required.

* __Customizeable layouts__&mdash;The buttons layout can be customized by implementing custom key layout factory class or by loading an .xml file with a special format.

* __Language culture support__&mdash;You can assign a specific culture that will be applied to the letter keys or you can enable the automatic synchronization with the current OS input language.

* __Sound__&mdash; The keyboard supports a clicking sound that is played on button press. The sound can be disabled or replaced with a custom one.

* __Customizeable buttons__&mdash;The visualization of each button can be customized with `DataTemplates`.

> Check out the demos application at [demos.telerik.com](https://demos.telerik.com/wpf/).

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF VirtualKeyboard Homepage](https://www.telerik.com/products/wpf/virtual-keyboard.aspx)
* [Get Started with the Telerik UI for WPF VirtualKeyboard]({%slug radvirtualkeyboard-getting-started%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF VirtualKeyboard Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also
* [Getting Started]({%slug radvirtualkeyboard-getting-started%})
* [Visual Structure]({%slug radvirtualkeyboard-visual-structure%})
* [Keys Layout]({%slug radvirtualkeyboard-keys-layout%})
* [Customize Keys]({%slug radvirtualkeyboard-customize-keys%})
