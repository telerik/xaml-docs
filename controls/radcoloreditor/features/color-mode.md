---
title: Color Mode
page_title: Color Mode
description: Check our &quot;Color Mode&quot; documentation article for the RadColorEditor {{ site.framework_name }} control.
slug: radcoloreditor-features-color-mode
tags: color,mode
published: True
position: 0
---

# Color Mode

The __RadColorEditor__ control allows supports the most popular color models. You can choose which one to use by setting the  __ColorMode__ property.

The __ColorMode__ property is an enumeration of type __ColorMode__ and it exposed the following members:				

__Example 1: Set the color model to RGB__
```XAML
	<telerik:RadColorEditor x:Name="colorEditor" SelectedColor="Red" ColorMode="RGB"/>
```

* __RGB__: Sets the color model to [RGB(Red, Green and Blue)](http://en.wikipedia.org/wiki/RGB_color_model)  
	![radcoloreditor-features-rgb](images/radcoloreditor-features-rgb.png)

	__Example 2: Set the color model to HLS__
	```XAML
		<telerik:RadColorEditor x:Name="colorEditor" SelectedColor="Green" ColorMode="HLS"/>
	```

* __HLS__: Sets the color model to [HLS (Hue, Luminance and Saturation)](http://en.wikipedia.org/wiki/HSL_and_HSV)  
	![radcoloreditor-features-hls](images/radcoloreditor-features-hls.png)

	__Example 3: Set the color model to HSV__
	```XAML
		<telerik:RadColorEditor x:Name="colorEditor" SelectedColor="Green" ColorMode="HSV"/>
	```

* __HSV__: Sets the color model to [HSV (Hue, Saturation and Value)](http://en.wikipedia.org/wiki/HSL_and_HSV)  
	![radcoloreditor-features-hsv](images/radcoloreditor-features-hsv.png)

	__Example 4: Set the color model to CMYK__
	```XAML
		<telerik:RadColorEditor x:Name="colorEditor" SelectedColor="Green" ColorMode="CMYK"/>
	```

* __CMYK__: Sets the color model to [CMYK (Cyan, Magenta, Yellow and Key/Black)](http://en.wikipedia.org/wiki/Cmyk)  
	![radcoloreditor-features-cmyk](images/radcoloreditor-features-cmyk.png)

## See Also
 * [Structure]({%slug radcoloreditor-structure%})
 * [Getting Started]({%slug radcoloreditor-getting-started%})
