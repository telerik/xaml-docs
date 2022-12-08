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

# Overview

VirtualKeyboard is a visual keyboard component rendered on the screen that mimics keyboard interactions without a phyisical device.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![WPF RadVirtualKeyboard Overview](images/radvirtualkeyboard-overview-1.png)

>tip Get started with the control with its [Getting Started]({%slug radvirtualkeyboard-getting-started%}) help article that shows how to use it in a basic scenario.

## Key Features

* __Native key input__&mdash;The keyboard device is not focusable and each button click sends a native key down action that is passed to the currently focused element. This means that no special code for binding the keyboard component with the input element is required.

* __Customizeable layouts__&mdash;The buttons layout can be customized by implementing custom key layout factory class or by loading an .xml file with a special format.

* __Language culture support__&mdash;You can assign a specific culture that will be applied to the letter keys or you can enable the automatic synchronization with the current OS input language.

* __Sound__&mdash; The keyboard supports a clicking sound that is played on button press. The sound can be disabled or replaced with a custom one.

* __Customizeable buttons__&mdash;The visualization of each button can be customized with `DataTemplates`.

> Check out the demos application at [demos.telerik.com](https://demos.telerik.com/wpf/).

## See Also
* [Getting Started]({%slug radvirtualkeyboard-getting-started%})
* [Visual Structure]({%slug radvirtualkeyboard-visual-structure%})
* [Keys Layout]({%slug radvirtualkeyboard-keys-layout%})
* [Customize Keys]({%slug radvirtualkeyboard-customize-keys%})
