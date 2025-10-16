---
title: How to Remove the Thousands Separator
page_title: How to Remove the Thousands Separator
description: Check our &quot;How to Remove the Thousands Separator&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-howto-number-groups-separator
tags: how,to,remove,the,thousands,separator
published: True
position: 1
---

# How to Remove the Thousands Separator

By default the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls use a culture-aware thousands separator:

__Example 1: AutoFillNumberGroupSeparators set to true which is by default__
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

![{{ site.framework_name }} RadMaskedInput Thousands Separator](images/radmaskedinput_howto_thousands_separator.png)

If you need to remove the thousands separator, you can set the __AutoFillNumberGroupSeparator__ property to __False__:

__Example 2: Setting the AutoFillNumberGroupSeparators property to false__
```XAML
	<telerik:RadMaskedNumericInput HorizontalAlignment="Center"
								   AutoFillNumberGroupSeparators="False"
								   Culture="en-US"
								   EmptyContent="Enter digits"
								   Mask="#9.0"
								   SelectionOnFocus="SelectAll"
								   SpinMode="PositionAndValue"
								   TextMode="PlainText"
								   UpdateValueEvent="LostFocus"
								   Value="12345" />
```

![{{ site.framework_name }} RadMaskedInput without Thousands Separator](images/radmaskedinput_howto_remove_thousands_separator.png)