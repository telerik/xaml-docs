---
title: Color Mode
page_title: Color Mode
description: Check our &quot;Color Mode&quot; documentation article for the RadColorEditor {{ site.framework_name }} control.
slug: radcoloreditor-features-color-mode
tags: color,mode
published: True
position: 0
---

# {{ site.framework_name }} RadColorEditor Color Mode

The __RadColorEditor__ control allows supports the most popular color models. You can choose which one to use by setting the  __ColorMode__ property.

The __ColorMode__ property is an enumeration of type __ColorMode__ and it exposed the following members:				

#### __[XAML] Example 1: Set the color model to RGB__
{{region radcoloreditor-features-color-mode_0}}
	<telerik:RadColorEditor x:Name="colorEditor" SelectedColor="Red" ColorMode="RGB"/>
{{endregion}}

* __RGB__: Sets the color model to [RGB(Red, Green and Blue)](http://en.wikipedia.org/wiki/RGB_color_model)  
	![radcoloreditor-features-rgb](images/radcoloreditor-features-rgb.png)

	#### __[XAML] Example 2: Set the color model to HLS__
	{{region radcoloreditor-features-color-mode_1}}
		<telerik:RadColorEditor x:Name="colorEditor" SelectedColor="Green" ColorMode="HLS"/>
	{{endregion}}

* __HLS__: Sets the color model to [HLS (Hue, Luminance and Saturation)](http://en.wikipedia.org/wiki/HSL_and_HSV)  
	![radcoloreditor-features-hls](images/radcoloreditor-features-hls.png)

	#### __[XAML] Example 3: Set the color model to HSV__
	{{region radcoloreditor-features-color-mode_2}}
		<telerik:RadColorEditor x:Name="colorEditor" SelectedColor="Green" ColorMode="HSV"/>
	{{endregion}}

* __HSV__: Sets the color model to [HSV (Hue, Saturation and Value)](http://en.wikipedia.org/wiki/HSL_and_HSV)  
	![radcoloreditor-features-hsv](images/radcoloreditor-features-hsv.png)

	#### __[XAML] Example 4: Set the color model to CMYK__
	{{region radcoloreditor-features-color-mode_3}}
		<telerik:RadColorEditor x:Name="colorEditor" SelectedColor="Green" ColorMode="CMYK"/>
	{{endregion}}

* __CMYK__: Sets the color model to [CMYK (Cyan, Magenta, Yellow and Key/Black)](http://en.wikipedia.org/wiki/Cmyk)  
	![radcoloreditor-features-cmyk](images/radcoloreditor-features-cmyk.png)

## See Also
 * [Structure]({%slug radcoloreditor-structure%})
 * [Getting Started]({%slug radcoloreditor-getting-started%})
