---
title: How to apply multiple animations for showing and hiding RadDesktopAlert
page_title: How to apply multiple animations for showing and hiding RadDesktopAlert
description: Check our &quot;How to apply multiple animations for showing and hiding RadDesktopAlert&quot; documentation article for the RadDesktopAlert {{ site.framework_name }} control.
slug: raddesktopalert-how-to-apply-multiple-animations-for-showing-and-hiding-raddesktopalert
tags: how,to,apply,aniamtion,group
published: True
position: 1
---

# How to apply multiple animations for showing and hiding RadDesktopAlert

Using the __ShowAnimation__ and __HideAnimation__ properties of the __DesktopAlertManager__ you could easily apply an animation or group of animations that all __RadDesktopAlert__ instances will use to show and hide. Both properties are of type __RadAnimation__ and only animations that inherits and extents that class could be set to them. __RadAnimation__ class also provides the ability to use some the common animation properties like __SpeedRatio__ and __AnimationName__.

This is the list of the several build-in animations you could apply:

* FadeAnimation

* ResizeAnimation

* ScaleAniamation

* SlideAnimation

* MoveAnimation

You could either set a single animation to the __ShowAnimation__ and __HideAnimation__ properties or use the __AnimationGroup__ to group several animations from the list above and play them simultaneously.

>To learn more about the methods and properties exposed by the API for each of the other animations mentioned above take a look at [this topic](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.animation).

## Applying AnimationGroup

Using the __AnimationGroup__ class you could group animations and play them simultaneously. You could easily add or remove animation objects of this composite animation using its __Children__ property that is of type __IList__. 

The next code snippet shows how to apply an __AnimationGroup__ to both the __ShowAnimation__ and __HideAnimation__ properties of __DesktopAlertManager__:

__Applying AnimationGroup__

<snippet id='raddesktopalert-how-to-apply-multiple-animations-for-showing-and-hiding-raddesktopalert-applying_animationgroup-cs' />


__Applying AnimationGroup__

<snippet id='raddesktopalert-how-to-apply-multiple-animations-for-showing-and-hiding-raddesktopalert-applying_animationgroup-vb' />


>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/DesktopAlert/ShowingAndHidingUsingAnimationGroup).

## See Also

 * [DesktopAlertManager]({%slug raddesktopalert-desktop-alert-manager%})