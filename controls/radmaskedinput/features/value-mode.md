---
title: Value Mode
page_title: Value Mode
description: Check our &quot;Value Mode&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-features-value-mode
tags: value,mode
published: True
position: 3
---

# Value Mode

> This feature is supported only in __RadMaskedTextInput__.

__RadMaskedTextInput__ allows you to set the behavior of the Value property in a mask scenario (when the Mask property is set). By default the Value holds the characters without including the placeholders and the literals defined in the mask. You can alter this and allow the value to hold also literal and placeholders by setting the __ValueMode__ property of the control. The property is an enum of type ValueMode which contains several options described in the next sections.

__Example 1: Setting the value mode__
```XAML
	<telerik:RadMaskedTextInput ValueMode="IncludeLiteralsAndPlaceholders"/>
```

## Plain mode

This is the default mode and it tells the masked input to store the value without any placeholders or literals given in the mask. For example, if the Mask is set to "##-##" and you enter "22-22", the Value property will contain "2222". The oposite scenario also applies - if you set the Value property to "2222" the control will display "22-22". If you set the Value to "222" the displayed value will be "22-2_", where the '_' character is the default placeholder.

> The displayed text can be get via the Text property of RadMaskedTextInput.

## IncludeLiterals mode

When this mode is enabled the Value property of the masked input control will contain also the literals defined in the Mask property. For example if the Mask is set to "##-##" and you enter "22-22" the Value property will contain the value "22-22", where the '-' character is the literal from the mask. If you set the Value to "22-2", the displayed text will be "22-2_", where the '_' character is the default placeholder.

Note that if you set a Value that doesn't include literals, the control will automatically, parse it according to the applied Mask and then update the Value property. For example setting the Value to "222" will display "22-2_" and then the Value will be updated to "22-2".

## IncludePlaceholders mode

When this mode is enabled the Value property of the masked input control will contain also the placeholders for the missing positions required by the Mask property. For example if the Mask is set to "####" and you enter "222" the Value property will be "222_", where the '_' character is the default placeholder.

## IncludeLiteralsAndPlaceholders mode

When this mode is enabled the Value property of the masked input control will contain also the literals and placeholders for the missing positions required by the Mask property. For example if the Mask is set to "##-##" and you enter "222" the Value property will be "22-2_".
 
## See Also
 * [Common Features]({%slug radmaskedinput-features-common%})
 * [MaskedTextInput]({%slug radmaskedinput-features-controls-text%})
