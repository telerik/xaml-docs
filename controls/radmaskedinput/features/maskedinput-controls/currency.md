---
title: MaskedCurrencyInput
page_title: MaskedCurrencyInput
description: MaskedCurrencyInput
slug: radmaskedinput-features-controls-currency
tags: maskedcurrencyinput
published: True
position: 1
---

# MaskedCurrencyInput

The __RadMaskedCurrencyInput__ represents the basic control that can be used to restrict the input of currency values.				

{% if site.site_name == 'Silverlight' %}
>In order to use the __RadMaskedCurrencyInput__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Controls.Input__  

>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
{% endif %}

{% if site.site_name == 'WPF' %} 
>In order to use the __RadMaskedCurrencyInput__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Controls.Input__
>	- __Telerik.Windows.Data__  

>You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
{% endif %}

Here is a simple definition of a __RadMaskedCurrencyInput__ control:				

#### __XAML__
{{region radmaskedinput-features-controls-currency_0}}
	<telerik:RadMaskedCurrencyInput x:Name="radMaskedCurrencyInput"
	                                Width="200"
	                                Margin="20 20 20 10"
	                                Culture="en-US"
	                                EmptyContent="Enter digits"
	                                InputBehavior="Replace"
	                                Mask="#9.2"
	                                SelectionOnFocus="SelectAll"
	                                TextMode="PlainText"
	                                UpdateValueEvent="LostFocus"
	                                Value="12345.67" />
{{endregion}}

![](images/radmaskedinput_currencyinput_default.png)

You can further customize the __RadMaskedCurrencyInput__ control's behavior by setting the IsCurrencySymbolVisible property to False thus hiding the culture specific currency symbol. By default this property is set to True.
				
You can further restrict the user input by setting the __FormatString__ property.It uses [Standard Numeric Format Strings](http://msdn.microsoft.com/en-us/library/dwhawy9k.aspx) and [Custom Numeric Format Strings](http://msdn.microsoft.com/en-us/library/0c899ak8.aspx) to further format the __Text__ property.				

#### __XAML__
{{region radmaskedinput-features-controls-currency_1}}
	<telerik:RadMaskedCurrencyInput x:Name="radMaskedCurrencyInput"
	                                HorizontalAlignment="Center"
	                                EmptyContent="Enter currency"
	                                Culture="en-US"
	                                FormatString="{}The currency value is {0:c2}, the numeric value is {0:n2}"
	                                UpdateValueEvent="LostFocus"
	                                SpinMode="PositionAndValue" 
	                                Value="123456"/>
{{endregion}}

![](images/radmaskedinput_currencyinput_format_string.png)

# See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})
 * [MaskedTextInput]({%slug radmaskedinput-features-controls-text%})
 * [MaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})
 * [Common Features]({%slug radmaskedinput-features-common%})