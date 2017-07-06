---
title: Overview
page_title: Overview
description: Overview
slug: radmaskedinput-overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'Silverlight' %}![RadMaskedInput for Silverlight Icon](images/maskedinput_sl_icon.png){% endif %}
{% if site.site_name == 'WPF' %}![RadMaskedInput for WPF Icon](images/maskedinput_wpf_icon.png){% endif %}

__RadMaskedInput__ controls allow controlled data input in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} applications. They enhance the functionality of a TextBox by adding input validation and masks, such as date, IP Address, SSN, phone number, digits, currency and decimals.				

![RadMaskedInput Overview](images/maskedinput-overview-0.png)

## Key Features

This is a list with short descriptions of the top-of-the-line features of Telerik's __RadMaskedInput__ controls.

* __Rich set of mask tokens__: The masked input controls allows you to define a mask rule that restricts the entered value. You can find more about this and the available tokens in the [Mask Tokens]({%slug radmaskedinput-features-mask-tokens%}) article.

* __Validation__: RadMaskedInput controls use a mask to distinguish between proper and improper user input. Read more about this in the [Validation]({%slug radmaskedinput-features-validation%}) section.

* __Text Input__: You can use the [RadMaskedTextInput]({%slug radmaskedinput-features-controls-text%}) control which supports restriction of the user input to customized text formats.

* __DateTime Input__: You can use the  [RadMaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%}) control which ensures that the date entered by the user is verified and accurate. You can also specify the culture information by setting the __Culture__ property.

* __Numeric Input__: You can use the [RadMaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%}) control which supports restricting the user input to decimal, fixed-point, percent and currency values, where currency values are also culture sensitive.

* __Currency Input__: You can use the [RadMaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%}) control which allows broad customization of culture-aware currency values.

* __Keyboard Support__:  In addition to the standard keyboard input, the RadMaskedInput controls deliver the convenience of desktop applications with support for arrow-key [navigation]({%slug radmaskedinput-features-keyboard-mouse%}).

* __Globalization Support__: Full [globalization support]({%slug radmaskedinput-features-globalization%}) is provided out-of-the-box through the __Culture__ property of the __RadMaskedInput__ controls.

* __Undo/Redo Support__: All RadMaskedInput controls support Undo/Redo operations. You can simply press the Ctrl+Z / Ctrl+Y key combination to take advantage of this feature.

>tip Get started with the control with its [Getting Started]({%slug radmaskedinput-getting-started%}) help article that shows how to use it in a basic scenario.

>Check out the control demos at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](http://demos.telerik.com/silverlight/#MaskedInput/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](http://demos.telerik.com/wpf/){% endif %}

## See Also

 * [GettingStarted]({%slug radmaskedinput-getting-started%})
 * [MaskedInputExtensions]({%slug radmaskedinput-features-extensions%})
 * [Placeholder]({%slug radmaskedinput-features-placeholder%})
 * [Watermark]({%slug radmaskedinput-features-watermark%})
