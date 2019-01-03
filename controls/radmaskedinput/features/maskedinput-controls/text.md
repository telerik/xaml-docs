---
title: MaskedTextInput
page_title: MaskedTextInput
description: RadMaskedTextInput represents a control that can be used to restrict the input of text values.
slug: radmaskedinput-features-controls-text
tags: maskedtextinput
published: True
position: 2
---

# MaskedTextInput

__RadMaskedTextInput__ represents a control that can be used to restrict the input of text values.

## Defining RadMaskedTextInput

The following example shows how to define the control and set few of its properties.

#### __[XAML] Example 1: Define RadMaskedTextInput in XAML__
{{region xaml-radmaskedinput-features-controls-text_0}}
	<telerik:RadMaskedTextInput EmptyContent="Enter digits"
	                            InputBehavior="Replace"
	                            Mask="a20"
	                            SelectionOnFocus="SelectAll"
	                            TextMode="PlainText"
	                            UpdateValueEvent="LostFocus"
	                            Value="Sample Text" />
{{endregion}}

#### Figure 2: RadMaskedTextInput example
![](images/radmaskedinput_textinput_default.png)

## Formatting the Value

You can format the entered value using the __FormatString__ property of the RadMaskedTextInput control. 

The property works with the standard .NET string formats.

The format will be applied only when the control is unfocused.

#### __[XAML] Example 2: Setting the FormatString property__
{{region xaml-radmaskedinput-features-controls-text_1}}
	<telerik:RadMaskedTextInput Value="Adam"
								Mask="a4" 
	                            FormatString="{}UserName: {0} NickName: {0}"/>
{{endregion}}

#### Figure 2: Showing the text value when the control is focused
![](images/radmaskedinput_textinput_format_string_focused.png)

#### Figure 3: Showing the text value when the control is unfocused
![](images/radmaskedinput_textinput_format_string.png)

## Setting the Value Mode

The value mode allows you to set the behavior of the Value property in a mask scenario (when the Mask property is set). By default the Value property holds the characters without including the placeholders and the literals defined in the mask. You can alter this and allow the value to hold also literal and placeholders by setting the __ValueMode__ property of the control.

Read more about this in the [Value Mode]({%slug radmaskedinput-features-value-mode%}) article.

## See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})
 * [MaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})
 * [MaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})
 * [Common Features]({%slug radmaskedinput-features-common%})