---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radmaskedinput-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadMaskedInput__.

## List of all RadMaskedInput SDK examples:{% if site.site_name == 'WPF' %}

* __Customizations__ - This example demonstrates how the masked input control can be customized. 	The Bank Account RadMaskedCurrencyInput uses a customized culture to represent its value as a Bank Input form. The modified culture changes the CurrencyGroupSizes and the CurrencyGroupSeparator. 	The Full Name RadMaskedTextInput uses a multiline mask with embedded text to enable first and last name input. It also uses a customized formatting token, which converts the first character of each name section to a capital one. The three masked input controls also use different kinds of validation - through Data Annotation attributes, intrinsic Validation and custom.

* __Customizations__ - This example demonstrates how the masked input control can be customized. 	The Bank Account RadMaskedCurrencyInput uses a customized culture to represent its value as a Bank Input form. The modified culture changes the CurrencyGroupSizes and the CurrencyGroupSeparator. 	The Full Name RadMaskedTextInput uses a multiline mask with embedded text to enable first and last name input. It also uses a customized formatting token, which converts the first character of each name section to a capital one. The three masked input controls also use different kinds of validation - through Data Annotation attributes, intrinsic Validation and custom.

* __Data validation__ - The DataValidation SDK sampleof the MaskedInput Controls demonstrates how you can:    -- Validate the data value on load with IDataErrorInfo    -- Validate with throwing DataExceptions      -- Validate with using Data Annotations

* __Dynamic format string__ - Users often need to type doubles like 1.234, 56.78, 123.9 and they do NOT need to see these values to be completed with zeros like: 	- 1.23400 	- 56.7800 	-123.90000 To achieve this effect users can users can use No-Mask (Mask="") and update the FormatString property runtime. Furthermore, users need delete and backspace keys to not produce zeros. For example pressing delete here 12.3|45 to produce 12.35 but not 12.305. This is demonstrated in the sample with overriding the HandleBackKeyNomask and HandleDeleteKeyNoMask methods of the RadMaskedNumericInput. Finally, it is good idea to limit the input somehow both on the left and on the right of  the decimal point because double loses precision after 15 digits.

* __Dynamic format string__ - Users often need to type doubles like 1.234, 56.78, 123.9 and they do NOT need to see these values to be completed with zeros like: 	- 1.23400 	- 56.7800 	-123.90000 To achieve this effect users can users can use No-Mask (Mask="") and update the FormatString property runtime. Furthermore, users need delete and backspace keys to not produce zeros. For example pressing delete here 12.3|45 to produce 12.35 but not 12.305. This is demonstrated in the sample with overriding the HandleBackKeyNomask and HandleDeleteKeyNoMask methods of the RadMaskedNumericInput. Finally, it is good idea to limit the input somehow both on the left and on the right of  the decimal point because double loses precision after 15 digits.

* __Ip address__ - The IP address demo shows how you can set up an IpAddressViewModel and validate it on user Input. The IpAddressViewModel validates with separating the 4 parts into 4 byte properties and also validates with System.Net.IpAddress class.

* __Customizations__ - This example demonstrates how the masked input control can be customized. 	The Bank Account RadMaskedCurrencyInput uses a customized culture to represent its value as a Bank Input form. The modified culture changes the CurrencyGroupSizes and the CurrencyGroupSeparator. 	The Full Name RadMaskedTextInput uses a multiline mask with embedded text to enable first and last name input. It also uses a customized formatting token, which converts the first character of each name section to a capital one. The three masked input controls also use different kinds of validation - through Data Annotation attributes, intrinsic Validation and custom.

* __Ip address__ - The IP address demo shows how you can set up an IpAddressViewModel and validate it on user Input. The IpAddressViewModel validates with separating the 4 parts into 4 byte properties and also validates with System.Net.IpAddress class.

* __Value to text converter__ - This example demonstrates the usage of an IValueConverter to convert and customize the Value into Display Text.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Customizations__ - This example demonstrates how the masked input control can be customized. 	The Bank Account RadMaskedCurrencyInput uses a customized culture to represent its value as a Bank Input form. The modified culture changes the CurrencyGroupSizes and the CurrencyGroupSeparator. 	The Full Name RadMaskedTextInput uses a multiline mask with embedded text to enable first and last name input. It also uses a customized formatting token, which converts the first character of each name section to a capital one. The three masked input controls also use different kinds of validation - through Data Annotation attributes, intrinsic Validation and custom.

* __Data validation__ - The DataValidation SDK sampleof the MaskedInput Controls demonstrates how you can:    -- Validate the data value on load with IDataErrorInfo    -- Validate with throwing DataExceptions      -- Validate with using Data Annotations

* __Dynamic format string__ - Users often need to type doubles like 1.234, 56.78, 123.9 and they do NOT need to see these values to be completed with zeros like: 	- 1.23400 	- 56.7800 	-123.90000 To achieve this effect users can users can use No-Mask (Mask="") and update the FormatString property runtime. Furthermore, users need delete and backspace keys to not produce zeros. For example pressing delete here 12.3|45 to produce 12.35 but not 12.305. This is demonstrated in the sample with overriding the HandleBackKeyNomask and HandleDeleteKeyNoMask methods of the RadMaskedNumericInput. Finally, it is good idea to limit the input somehow both on the left and on the right of  the decimal point because double loses precision after 15 digits.

* __Value to text converter__ - This example demonstrates the usage of an IValueConverter to convert and customize the Value into Display Text.{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).
