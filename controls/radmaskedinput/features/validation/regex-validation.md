---
title: Regex Validation
page_title: Regex Validation
description: Regex Validation
slug: radmaskedinput-validation-regex-validation
tags: using,dataannotation,attributes,regex,radmaskedtextinput
published: True
position: 2
---

# Regex Validation

>important This feature is supported only by the __RadMaskedTextInput__ control.

RadMaskedTextInput allows you to enable an additional validation rule by defining a regular experession. The regex is applied over the value received after the Mask property validates the entered text.

## Setting Regular Expression

The regex can be set via the __ValidationRegex__ property of the RadMaskedTextInput control.

{% if site.site_name == 'WPF' %}
#### __[XAML] Example 1: Setting regex validation__
{{region xaml-radmaskedinput-features-regex-validation-0}}
	<telerik:RadMaskedTextInput Mask="a20"                                    
								ValidationRegex="^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$" 
								maskedInput:ValidationHelper.DisplayValidationErrors="True"  />		
{{endregion}}
{% endif %}


{% if site.site_name == 'Silverlight' %}
#### __[XAML] Example 1: Setting regex validation__
{{region xaml-radmaskedinput-features-regex-validation-1}}
	<telerik:RadMaskedTextInput Mask="a20"                                    
								ValidationRegex="^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$" />		
{{endregion}}
{% endif %}
							
__Example 1__ shows how to restrict the user to enter only a valid email address with a maximum text length of 20 alphanumeric or special characters.
							
> Take the [ValueMode]({%slug radmaskedinput-features-value-mode%}) property into account when composing the regular expression. Depending on the mode the Value of the control might contain placeholders and literals.

## Predefined Regular Expressions

The validation feature provides few predefined regular expressions that can be used.

* __Email__: This expression allows you to validate email addresses.
* __IP__: This expression allows you to validate IP addresses.

You can access the predefined regular expressions via the __ValidationHelper__ class. It exposes the regexes via static readonly properties. 

> The ValidationHelper class can be found in the following namespace: `xmlns:maskedInput="clr-namespace:Telerik.Windows.Controls.MaskedInput;assembly=Telerik.Windows.Controls.Input"`

#### __[XAML] Example 2: Setting predefined regex in XAML__
{{region xaml-radmaskedinput-features-regex-validation-2}}
	<telerik:RadMaskedTextInput ValidationRegex="{x:Static maskedInput:ValidationHelper.Email}" />		
{{endregion}}

#### __[C#] Example 3: Setting predefined regex in code__
{{region cs-radmaskedinput-features-regex-validation-3}}
	this.maskedTextInput.ValidationRegex = ValidationHelper.Email;
{{endregion}}

## Set Error Message

You can set the error that will be shown in the validation tooltip via the __ErrorMessage__ property of the RadMaskedInput control.

#### __[C#] Example 4: Setting predefined regex in code__
{{region cs-radmaskedinput-features-regex-validation-4}}
	<telerik:RadMaskedTextInput ErrorMessage="Invalid email address"/>
{{endregion}}

#### __Figure 1: Custom error message__
![](images/radmaskedinput-features-regex-validation-0.png)

{% if site.site_name == 'WPF' %}
## Display Validation Errors

The visual element that presents the validation errors is not displayed by default when there is an error. If you want to display it set the __ValidationHelper.DisplayValidationErrors__ attached property on the masked input control to __True__.

#### __[XAML] Example 5: Enabling the validation errors visual__
{{region xaml-radmaskedinput-features-regex-validation-5}}
	<telerik:RadMaskedTextInput maskedInput:ValidationHelper.DisplayValidationErrors="True"  />
{{endregion}}
{% endif %}

## See Also
* [Getting Started]({%slug radmaskedinput-getting-started%})
* [Mask Tokens]({%slug radmaskedinput-features-mask-tokens%})


