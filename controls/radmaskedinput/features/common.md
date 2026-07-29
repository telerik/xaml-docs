---
title: Common
page_title: Common
description: Check our &quot;Common&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-features-common
tags: common
published: True
position: 1
---

# Common

This article lists features that are common between the __RadMaskedInput__ controls.

* [No-Mask Functionality](#no-mask-functionality)
* [Input Behavior](#input-behavior)
* [Text and TextMode](#text-and-textmode-properties)
* [ValueToTextConverter](#valuetotextconverter)
* [Add/Remove the ClearButton](#add-remove-the-clearbutton)
* [IsLastPositionEditable](#islastpositioneditable)
* [TextBoxStyle](#textboxstyle)

## No-Mask Functionality

You can take advantage of the 'no-mask' functionality of the __RadMaskedTextInput,RadMaskedNumericInput__ and the __RadMaskedCurrenyInput__ controls by setting the __Mask__ property to __""__ like so:		

__Example 1: Setting no-mask functionality__
<snippet id='radmaskedinput-features-common-block_1-xaml' />

This feature creates __RadMaskedInput__ controls that allow unlimited input. And as the __Mask__ property is empty, the controls won't expect a certain number of characters and this is why they will automatically update to fit the user input.	  

>tip The 'no-mask' functionality will remove the restrictions usually applied by the __Mask__ property on the type and the number of input characters in each of the controls. Still you can set the __FormatString__ property to control the input in the __RadMaskedInput__ controls when they don't specify a __Mask__. For example you can use the [Standard Numeric Format Strings](http://msdn.microsoft.com/en-us/library/dwhawy9k.aspx) and [Custom Numeric Format Strings](http://msdn.microsoft.com/en-us/library/0c899ak8.aspx) to control the input in the __RadMaskedNumericInput__ and the __RadMaskedCurrencyInput__. This means that if you need to restrict the number of digits after the decimal point to 2 in a __RadMaskedNumericInput__, you can set its __FormatString__ property to __"n2"__: <br/><br /> `<telerik:RadMaskedNumericInput Mask="" FormatString="n2"/>`

## Input Behavior

The __RadMaskedInput__ controls allow you to specify the characters input behavior using the __InputBehavior__ property. The property is an enumeration of type __InputBehavior__ and exposes the following values:		

* __Replace__: Inputs characters on the right of the current caret position.

* __Insert__: Inserts characters before the caret's current position for as long as there are empty positions to fill. When there are no empty positions to fill on left of the caret, then the characters are added on right of the caret.		  

>You can change the __InputBehavior__ using the __Insert__ key. Also please keep in mind that the __InputBehavior__ reflects the behavior of the __Backspace__ and __Delete__ keys		  

## Text and TextMode properties

The __RadMaskedInput__ controls expose a __Text__ property that gets the value displayed in the control when it isn't focused. The value of this property depends on the __TextMode__ enumeration, that exposed the following values:		

* __MaskedText__: When this mode is enabled the __Text__ property value represents the formatted __Value__ including the placeholder characters.		  

* __PlainText__: When this mode is enabled the __Text__ property value represents the formatted __Value__ without the placeholder characters.

__Example 2: Setting TextMode property in XAML__
<snippet id='radmaskedinput-features-common-block_2-xaml' />

![{{ site.framework_name }} RadMaskedInput Different Text Modes](images/radmaskedinput_features_text_mode.png)

## ValueToTextConverter

The __RadMaskedInput__ controls allow you to set an __IValueConverter__ to change the __Text__ property depending on the __Value__. The following example will illustrate a sample implementation of the ValueToTextConverter property.		

Let's start by defining an __IValueConverter__:		

__Example 3: Implementing IValueConverter interface__
<snippet id='radmaskedinput-features-common-block_3-cs' />
<snippet id='radmaskedinput-features-common-block_3-vb' />

Now we can define the __NumericValueToTextConverter__ as a resource in our application and apply it to the __RadMaskedNumericInput__ properties.		

__Example 5: Setting the IValueConverter to the ValueToTextConverter property in XAML__
<snippet id='radmaskedinput-features-common-block_4-xaml' />

![{{ site.framework_name }} RadMaskedInput ValueToTextConverter](images/radmaskedinput_features_converter.png)

## Add/Remove the ClearButton

The default __Template__ of the __RadMaskedInput__ controls defines a __ClearButton__ that allows the user to clear the input. You can hide this button by setting the __IsClearButtonVisible__ property to __False__.

__Example 6: Setting the IsClearButtonVisible property__
<snippet id='radmaskedinput-features-common-block_5-xaml' />

![{{ site.framework_name }} RadMaskedInput Clear Button Hidden](images/radmaskedinput_features_clear_button.png)

## IsLastPositionEditable

The __IsLastPositionEditable__ property indicates whether the last position in the __RadMaskedInput__ controls can be modified or not. If the property is set to __True__, the user will be able to edit the value in the last available position of the control. This is the default behavior of the __RadMaskedInput__ controls. However, if you need to restrict the user from changing this value, you can set the __IsLastPositionEditable__ property to __False__.		

## TextBoxStyle

The __RadMaskedInput__ controls have a `TextBoxStyle` property which allows you to modify the style of the underlying text box element representing the input. The property is of type `Style` which targets `PreviewInputTextBox`.

__Example 7: Setting TextBoxStyle__
<snippet id='radmaskedinput-features-common-block_6-xaml' />

## See Also
 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})
 * [MaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})
 * [MaskedTextInput]({%slug radmaskedinput-features-controls-text%})
 * [MaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})
 * [Mask Tokens]({%slug radmaskedinput-features-mask-tokens%})