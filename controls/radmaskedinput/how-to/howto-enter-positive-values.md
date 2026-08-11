---
title: How to Enter Only Positive Numbers
page_title: How to Enter Only Positive Numbers
description: Check our &quot;How to Enter Only Positive Numbers&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-howto-enter-positive-values
tags: how,to,enter,only,positive,numbers
published: True
position: 2
---

# How to Enter Only Positive Numbers

You can control the values entered in the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls to allow only positive input.

You can use the __MaskedInputExtensions.Minimum__ attached property to define 0 as the minimum value that can be entered in the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls. This way you will restrict the user to only entering positive values in the controls.

__Example 1:  Setting the MaskedInputExtensions.Minimum attached property__
<snippet id='radmaskedinput-how-to-howto-enter-positive-values-block_1-xaml' />

You can find more information about the __MaskedInputExtensions__ class properties in the [MaskedInputExtensions]({%slug radmaskedinput-features-extensions%}) article.

## See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [Common Features]({%slug radmaskedinput-features-common%})
 * [How to Define Consecutive Input]({%slug radmaskedinput-howto-allow-skip-placeholders%})
 * [How to Remove the Thousands Separator]({%slug radmaskedinput-howto-number-groups-separator%})