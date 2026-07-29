---
title: Indeterminate State Animation Customization
page_title: Indeterminate State Animation Customization
description: This article will show you how to modify the default animation of RadCircularProgressBar control.
slug: radcircularprogressbar-animation-customization
tags: customize animation, animation
published: True
position: 7
---

# Indeterminate State Animation Customization

The indeterminate state animation of `RadCircularProgressBar` is represented by the `AnimationManager` class. To customize the default animation, create a new `RadDoubleAnimation` object instance for the `AnimationManager.AnimationSelector` attached property. To apply the custom animation correctly, set the `AnimationName` property's value to __IndeterminateIndicatorAnimation__.

>important The `TargetElementName` property has to be set to __PART\_IndicatorPath__. `PropertyName` property has to be equal to __(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)__.

__Setting a custom RadDoubleAnimation__
<snippet id='radcircularprogressbar-animation-customization-setting_a_custom_raddoubleanimation-xaml' />


![RadCircularProgressBar with custom animation](images/radcircularprogressbar-animation-customization-0.gif)

## Animation Easing

The `RadDoubleAnimation` class supports applying animation easing. To do so, set any object that implements the `IEasingFunction` interface to its `Easing` property.

The following code snippet shows the above example with a custom `BounceEase` instance:

__Applying a BounceEase animation easing__
<snippet id='radcircularprogressbar-animation-customization-applying_a_bounceease_animation_easing-xaml' />


![RadCircularProgressBar with animation easing](images/radcircularprogressbar-animation-customization-1.gif)

## See Also
* [Custom Content]({%slug radcircularprogressbar-custom-content%})