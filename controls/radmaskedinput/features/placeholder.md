---
title: Placeholder
page_title: Placeholder
description: Placeholder
slug: radmaskedinput-features-placeholder
tags: placeholder
published: True
position: 5
---

# Placeholder



## 

The __Placeholder__ character is a character used to represent the absence of user input in a __RadMaskedInput__ control. The default value is an underscore (_). The __Placeholder__ character will be displayed in a __RadMaskedInput__ control for any mask position that the user has not filled in yet.

#### __XAML__

{{region radmaskedinput-features-placeholder_0}}
	<telerik:RadMaskedTextInput Mask="####" />
	{{endregion}}



![](images/RadMaskedTextBox_Features_Placeholder_Default.png)

If you want to change the default __Placeholder__, you should set a __RadMaskedInput__ control's __Placeholder__ property, like in the example below:

#### __XAML__

{{region radmaskedinput-features-placeholder_1}}
	<telerik:RadMaskedTextInput Mask="####" Placeholder="$" />
	{{endregion}}



![](images/RadMaskedTextBox_Features_Placeholder_Custom.png)

>tipYou can set a watermark content to the __RadMaskedInput__ controls by using the __EmptyContent__ and __EmptyContentTemplate__ properties. When the __Value__ of a __RadMaskedInput__ control is null or empty the __EmptyContent__ will be displayed. For more information, read [Watermark]({%slug radmaskedinput-features-watermark%}).

# See Also

 * [Getting Started]({%slug radmaskedinput-getting-started%})

 * [Common Features]({%slug radmaskedinput-features-common%})

 * [Mask Tokens]({%slug radmaskedinput-features-mask-tokens%})
