---
title: How to Define Consecutive Input
page_title: How to Define Consecutive Input
description: How to Define Consecutive Input
slug: radmaskedinput-howto-allow-skip-placeholders
tags: how,to,define,consecutive,input
publish: True
position: 0
---

# How to Define Consecutive Input



## 

In the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls if in the user input is similar to __4_5,_12,345__, each placeholder indicating that no value is added is replaced by a __0__, thus displaying the value of __405,012,345__:

#### __XAML__

{{region radmaskedinput-howto-allow-skip-placeholders_0}}
	        <telerik:RadMaskedNumericInput x:Name="radMaskedNumericInput" 
	                                       HorizontalAlignment="Center"
	                                       Culture="en-US"
	                                       EmptyContent="Enter digits"
	                                       Mask="#9.0"
	                                       SelectionOnFocus="SelectAll"
	                                       SpinMode="PositionAndValue"
	                                       TextMode="PlainText"
	                                       UpdateValueEvent="LostFocus"
	                                       Value="12345" />
	{{endregion}}



![](images/radmaskedinput_howto_skip_placeholders.png)

However, if you need to define a consecutive input so that entering a new digit to this number  _____,_12,345__ will result in adding the digit to the first available position: _____,412,345__, you can set the __AllowSkipPlaceholders__ property to __False__:

#### __XAML__

{{region radmaskedinput-howto-allow-skip-placeholders_1}}
	        <telerik:RadMaskedNumericInput x:Name="radMaskedNumericInput" 
	                                       HorizontalAlignment="Center"
	                                       AllowSkipPlaceholders="False"
	                                       Culture="en-US"
	                                       EmptyContent="Enter digits"
	                                       Mask="#9.0"
	                                       SelectionOnFocus="SelectAll"
	                                       SpinMode="PositionAndValue"
	                                       TextMode="PlainText"
	                                       UpdateValueEvent="LostFocus"
	                                       Value="12345" />
	{{endregion}}



![](images/radmaskedinput_howto_skip_placeholders_false.png)
