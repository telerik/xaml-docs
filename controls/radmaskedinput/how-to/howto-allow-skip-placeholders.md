---
title: How to Define Consecutive Input
page_title: How to Define Consecutive Input
description: Check our &quot;How to Define Consecutive Input&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-howto-allow-skip-placeholders
tags: how,to,define,consecutive,input
published: True
position: 0
---

# How to Define Consecutive Input

In the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls if in the user input is similar to __4_5,_12,345__, each placeholder indicating that no value is added is replaced by a __0__, thus displaying the value of __405,012,345__:

__Example 1: Each placeholder is replaced by 0__
```XAML
	<telerik:RadMaskedNumericInput HorizontalAlignment="Center"
								   Culture="en-US"
								   EmptyContent="Enter digits"
								   Mask="#9.0"
								   SelectionOnFocus="SelectAll"
								   SpinMode="PositionAndValue"
								   TextMode="PlainText"
								   UpdateValueEvent="LostFocus"
								   Value="12345" />
```

![{{ site.framework_name }} RadMaskedInput Placeholders Replaced with 0](images/radmaskedinput_howto_skip_placeholders.png)

However, if you need to define a consecutive input so that entering a new digit to this number  _____,_12,345__ will result in adding the digit to the first available position: _____,412,345__, you can set the __AllowSkipPlaceholders__ property to __False__:

__Example 2: Setting the AllowSkipPlaceholders property__
```XAML
	<telerik:RadMaskedNumericInput HorizontalAlignment="Center"
								   AllowSkipPlaceholders="False"
								   Culture="en-US"
								   EmptyContent="Enter digits"
								   Mask="#9.0"
								   SelectionOnFocus="SelectAll"
								   SpinMode="PositionAndValue"
								   TextMode="PlainText"
								   UpdateValueEvent="LostFocus"
								   Value="12345" />
```

![{{ site.framework_name }} RadMaskedInput Skipped Placeholders](images/radmaskedinput_howto_skip_placeholders_false.png)