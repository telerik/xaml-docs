---
title: UpdateValueEvent
page_title: UpdateValueEvent
description: UpdateValueEvent
slug: radmaskedinput-features-update-value
tags: updatevalueevent
published: True
position: 4
---

# UpdateValueEvent



## 

The __UpdateValueEvent__ property of the __RadMaskedTextInput__ controls allows you to specify when the __Value__ property will be changed. If __UpdateValueEvent__ is set to __PropertyChanged__, the __Value__ will be changed on every key stroke, assuming that you are typing. If the __UpdateValueEvent__ is set to __LostFocus__, the __Value__ will be changed only after the __RadMaskedTextInput__ control loses its focus.

#### __XAML__

{{region radmaskedinput-features-update-value_0}}
	<!--  Setting UpdateValueEvent to LostFocus  -->
	        <telerik:RadMaskedNumericInput x:Name="radMaskedNumericInput" 
	                                Mask="c3"
	                                UpdateValueEvent="LostFocus" />
	<!--  Setting UpdateValueEvent to PropertyChanged  -->
	        <telerik:RadMaskedNumericInput x:Name="radMaskedNumericInput2" 
	                                Mask="c3"
	                                UpdateValueEvent="PropertyChanged" />
	{{endregion}}



>tipThe default value of all __RadMaskedInput__'s __UpdateValueEvent__ property is __UpdateValueEvent.PropertyChanged__.



>tipYou can see a live demo demonstrating the __UpdateValueEvent__ property [here](http://demos.telerik.com/silverlight/#MaskedInput/MaskedNumericInput).

# See Also

 * [Getting Started]({%slug radmaskedinput-getting-started%})

 * [Common Features]({%slug radmaskedinput-features-common%})

 * [Mask Tokens]({%slug radmaskedinput-features-mask-tokens%})
