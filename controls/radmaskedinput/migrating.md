---
title: Migration from RadMaskedTextBox
page_title: Migration from RadMaskedTextBox
description: Migration from RadMaskedTextBox
slug: radmaskedinput-migrating
tags: migration,from,radmaskedtextbox
published: True
position: 3
---

# Migration from RadMaskedTextBox

## How to migrate from the RadMaskedTextBox to the RadMaskedInput

The __RadMaskedTextBox__ component is obsolete and will be removed with the __Q2 2014__ release. The component had many known limitations which drove us to the decision to create a suite of 4 __MaskedInput__ components that further enhance the user experience when working with controlled data input. The suite includes __RadMaskedTextInput__, __RadMaskedCurrencyInput__, __RadMaskedNumericInput__ and __RadMaskedDateTimeInput__ controls. They all share common functionality but each one is designed to handle specific type of input. This way we managed to cover a broader set of requirements in the controls related mostly to the specifics of each type of value input:
        
|RadMaskedInput Component|Value type|
|------------------------|----------|
|RadMaskedNumericInput|double?|
|RadMaskedCurrencyInput|decimal?|
|RadMaskedTextInput|string|
|RadMaskedDateTimeInput|System.DateTime?|

This is why we strongly encourage all existing and new customers to use the [RadMaskedInput](http://www.telerik.com/help/wpf/radmaskedinput-overview.html) suite of controls instead.        

The API of all __RadMaskedInput__ components closely mirrors the __RadMaskedTextBox__ API which makes the migration between the old and the new components straight-forward. However, it is important to note that the __MaskedTextBox__ __MaskType__ property is not available within the __MaskedInput__ components as instead each component represents a specific type of input. You can use the information below to choose a __RadMaskedInput__ component based on the current __MaskType__ of your __RadMaskedTextBox__:        

* __MaskType=”Standard”__ - Choose between __RadMaskedTextInput__, __RadMaskedNumericInput__ and __RadMaskedCurrencyinput__ based on the type of input you need to provide for your users: numeric, currency or string.            

* __MaskType=”DateTime”__ - Use a __RadMaskedDateTimeInput__.            

* __MaskType=”None”__ - Use the [NoMask](http://www.telerik.com/help/wpf/radmaskedinput-features-common.html) functionality of the __RadMaskedTextInput__, __RadMaskedNumericInput__ and __RadMaskedCurrencyinput__ and choose the component based on the type of input you need to provide for your users: numeric, currency or string.            

The other API changes are listed in the table below:

|RadMaskedTextBox|RadMaskedInputs|
|----------------|---------------|
|IsSpinEnabled|[SpinMode](http://www.telerik.com/help/wpf/radmaskedinput-features-keyboard-mouse.html)|
|MaxLength|Use the [MaskedInputExtensions](http://www.telerik.com/help/wpf/radmaskedinput-features-extensions.html) MaskedInputExtensions.Maximum for RadMaskedNumericInput and RadMaskedCurrencyInput MaskedInputExtensions.MaxTextLength for RadMaskedTextInput|
|IsEmpty|You can check if the Value property of a MaskedInput component equals null to see if the component is empty.|

At the same time in the __RadMaskedInput__ components you will find a more extensive set of features further demonstrated in the examples available within the {% if site.site_name == 'Silverlight' %}[ UI for Silverlight demo application](https://demos.telerik.com/silverlight/){% endif %}{% if site.site_name == 'WPF' %}[ UI for WPF demo application](https://demos.telerik.com/wpf/){% endif %}.        

## See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})