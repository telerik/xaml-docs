---
title: Popup Animation
page_title: Popup Animation
description: Popup Animation
slug: radbuttons-features-popup-animation
tags: popup,animation,button,dropdown,split,fade,scroll,none,slide
published: True
position: 7
---

# Popup Animation

[RadDropDownButton]({%slug radbuttons-features-dropdown-button%}) and [RadSplitButton]({%slug radbuttons-features-split-button%}) support popup animations. The animation is triggered when the drop down content of the button is opened.

> By default the animation is not enabled.

To enable the animation you can set the __PopupAnimation__ property of the button. 

#### __[XAML] Example 1: Setting PopupAnimation__  
{{region radbuttons-features-popup-animation-0}}
	<telerik:RadDropDownButton PopupAnimation="Scroll">
{{endregion}}

The property is an enum of type __System.Windows.Controls.Primitives.PopupAnimation__ and also determines the animation type.

* __Fade__: The popup control gradually appears, or fades out, depending on its current state (open or not).

	![](images/radbuttons-features-popup-animations-0.gif)

* __Slide__: The popup control slides down starting from the lower left corner of the button. If the screen doesn't have enough space for the popup, the sliding will behave differently according to the position of the popup.
	
	![](images/radbuttons-features-popup-animations-1.gif)

* __Scroll__: The popup control scrolls from the lower left corner of the button. If the screen doesn't have enought space for the popup, the scrolling will behave differently according to the position of the popup.
	
	![](images/radbuttons-features-popup-animations-2.gif)

* __None__: The popup control appears without animation. This is the default value of the property.

	![](images/radbuttons-features-popup-animations-3.gif)

## See Also

* [Getting Started]({%slug radbuttons-getting-started%})
* [DropDown Button]({%slug radbuttons-features-dropdown-button%})
* [Split Button]({%slug radbuttons-features-split-button%})