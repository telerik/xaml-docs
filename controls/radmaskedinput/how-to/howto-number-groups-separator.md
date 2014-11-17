---
title: How to Remove the Thousands Separator
page_title: How to Remove the Thousands Separator
description: How to Remove the Thousands Separator
slug: radmaskedinput-howto-number-groups-separator
tags: how,to,remove,the,thousands,separator
published: True
position: 1
---

# How to Remove the Thousands Separator



## 

By default the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls use a culture-aware thousands separator:

#### __XAML__

{{region radmaskedinput-howto-number-groups-separator_0}}
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



![](images/radmaskedinput_howto_thousands_separator.png)

If you need to remove the thousands separator, you can set the __AutoFillNumberGroupSeparator__ property to __False__:

#### __XAML__

{{region radmaskedinput-howto-number-groups-separator_1}}
    <telerik:RadMaskedNumericInput x:Name="radMaskedNumericInput" 
                                   HorizontalAlignment="Center"
                                   AutoFillNumberGroupSeparators="False"
                                   Culture="en-US"
                                   EmptyContent="Enter digits"
                                   Mask="#9.0"
                                   SelectionOnFocus="SelectAll"
                                   SpinMode="PositionAndValue"
                                   TextMode="PlainText"
                                   UpdateValueEvent="LostFocus"
                                   Value="12345" />
	{{endregion}}

![](images/radmaskedinput_howto_remove_thousands_separator.png)
