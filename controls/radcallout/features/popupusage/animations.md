---
title: Animations
page_title: Animations
description: Check our &quot;Overview&quot; documentation article for the RadCallout {{ site.framework_name }} control.
slug: radcallout-features-animations
tags: animations
published: True
position: 0
---

# Animations

When the __RadCallout__ is placed inside a Popup element, you can add animations. Through the __CalloutPopupSettings__ class, you can animate the showing and/or closing effect of the Popup. You can choose from a variety of built-in animations or create your custom animation effect so that you can add an additional look to the RadCallout. To add animation to the Popup, you just need to set the __ShowAnimationType__ and /or __CloseAnimationType__ property of the settings class.

The complete customization of the RadCallout animation is done from the __CalloutPopupSettings__ class. Several properties can be used for this purpose.

* __ShowAnimationDuration__: A property of type __double__ that gets or sets a duration of the animation when shown, in seconds.
* __CloseAnimationDuration__: A property of type __double__ that gets or sets a duration of the animation when closed, in seconds.

* __ShowAnimationEasing__: A property of type __IEasingFunction__ that gets or sets the easing function of the shown animation.
* __CloseAnimationEasing__: A property of type __IEasingFunction__ that gets or sets the easing function of the close animation.

* __ShowAnimationDelay__: A property of type __double__ that gets or sets a delay of the animation when shown, in seconds.
* __CloseAnimationDelay__: A property of type __double__ that gets or sets a delay of the animation when closed, in seconds.

For this tutorial, we are going to show the RadCallout inside a Popup on a button click and animate its opening and closing state. First, we need to define our RadButton control and subscribe to its __Click__ event.

__Example 1: Defining RadButton__
<snippet id='radcallout-features-popupusage-animations-example_1_defining_radbutton-xaml' />

In the click event handler, we can declare our RadCallout control. To show the control, we need to use the CalloutPopupService.Show() static method. The third parameter (not required) of this method accepts CalloutPopupSettings object. You can use these settings, for example, to change the position of the __Popup__, add animation, etc.

__Example 2: Setting RadCallout in code behind__
<snippet id='radcallout-features-popupusage-animations-example_2_setting_radcallout_in_code_behind-cs' />

#### __Figure 1: Popup animation__
![{{ site.framework_name }} RadCallout Popup animation](images/radcallout-features-animations_1.gif)

## Animation Types

Several different built-in animations can be used to animate RadCallout placed inside Popup. You can customize the duration, delay and easing function of each animation. The easing functions make the animation much more realistic and smoother. There is a set of predefined easing functions in WPF, and you are allowed to create custom ones, too.

>To learn more about the easing functions you can take a look at this [MSDN help article](
https://msdn.microsoft.com/en-us/library/ee308751%28v=VS.100%29.aspx?f=255&MSPPError=-2147217396).

__Example 3: Show and Close Animation with Easing functions applied__
<snippet id='radcallout-features-popupusage-animations-example_3_show_and_close_animation_with_easing_functions_applied-cs' />

#### __Figure 2: Animated Popup with Easing functions__
![{{ site.framework_name }} RadCallout Animated Popup with Easing functions](images/radcallout-features-animations_easing.gif)

### Fade Animation

The __CalloutAnimation.Fade__ animation fades the Popup control opening/closing effect. 

__Example 4: Setting Fade Animation__
<snippet id='radcallout-features-popupusage-animations-example_4_setting_fade_animation-cs' />

#### __Figure 3: Fade animation for opening and closing state__
![{{ site.framework_name }} RadCallout Fade animation for opening and closing state](images/radcallout-features-animations_fade_cloud.gif)

### Move Animation

The __CalloutAnimation.Move__ animation adds a moving effect to the opening/closing state of the Popup. 

__Example 5: Setting Move Animation__
<snippet id='radcallout-features-popupusage-animations-example_5_setting_move_animation-cs' />

#### __Figure 4: Move animation for opening and closing state__
![{{ site.framework_name }} RadCallout Move animation for opening and closing state](images/radcallout-features-animations_move_ellipse.gif)

### FadeAndMove Animation

The __CalloutAnimation.FadeAndMove__ animation is represented by a combination of __Fade__ and __Move__ animations.

__Example 6: Setting FadeAndMove Animation__
<snippet id='radcallout-features-popupusage-animations-example_6_setting_fadeandmove_animation-cs' />

#### __Figure 5: FadeAndMove animation for opening and closing state__
![{{ site.framework_name }} RadCallout FadeAndMove animation for opening and closing state](images/radcallout-features-animations_fademove_kaboom.gif)

### Reveal Animation

The __CalloutAnimation.Reveal__ animation animates the clipping effect to the control.

__Example 7: Setting Reveal Animation__
<snippet id='radcallout-features-popupusage-animations-example_7_setting_reveal_animation-cs' />

#### __Figure 6: Reveal animation for opening and closing state__
![{{ site.framework_name }} RadCallout Reveal animation for opening and closing state](images/radcallout-features-animations_reveal_rectangle.gif)

### FadeAndReveal Animation

The __CalloutAnimation.FadeAndReveal__ animation is represented by a combination of __Fade__ and __Reveal__ animations.

__Example 8: Setting FadeAndReveal Animation__
<snippet id='radcallout-features-popupusage-animations-example_8_setting_fadeandreveal_animation-cs' />

#### __Figure 7: FadeAndReveal animation for opening and closing state__
![{{ site.framework_name }} RadCallout FadeAndReveal animation for opening and closing state](images/radcallout-features-animations_fadereveal_roundedrectangle.gif)

### Scale Animation

The __CalloutAnimation.Scale__ animation controls the scale of the object. This animation uses the center point of the control for scaling.

__Example 9: Setting Scale Animation__
<snippet id='radcallout-features-popupusage-animations-example_9_setting_scale_animation-cs' />

#### __Figure 8: Scale animation for opening and closing state__
![{{ site.framework_name }} RadCallout Scale animation for opening and closing state](images/radcallout-features-animations_scale_cloud.gif)

### FadeAndScale Animation

The __CalloutAnimation.FadeAndScale__ animation is represented by a combination of __Fade__ and __Scale__ animations.

__Example 10: Setting FadeAndScale Animation__
<snippet id='radcallout-features-popupusage-animations-example_10_setting_fadeandscale_animation-cs' />

#### __Figure 9: FadeAndScale animation for opening and closing state__
![{{ site.framework_name }} RadCallout FadeAndScale animation for opening and closing state](images/radcallout-features-animations_fadescale_ellipse.gif)

## Disable Animation

To globally disable the animation for all Popups elements holding RadCallout controls, CalloutPopupService.IsAnimationEnabled static property can be set to false.

__Example 11: Disable Animation__
<snippet id='radcallout-features-popupusage-animations-example_11_disable_animation-cs' />

## See Also

* [Getting Started]({%slug radcallout-getting-started%})
* [CalloutPopupService]({%slug radcallout-features-calloutpopupservice%})
