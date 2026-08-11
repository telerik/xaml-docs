---
title: Animations
page_title: Animations
description: RadSplashScreen provides two built-in animations - one for opening and one for closing of the screen. Replace them with any RadAnimation.
slug: radsplashscreen-features-animations
tags: progress,bar,splashscreen,busyindicator
published: True
position: 2
---

# Animations

RadSplashScreen provides two built-in animations - one for opening and one for closing of the screen. 

The default animations are fade-in and fade-out. To change them, set the __ShowAnimation__ and __HideAnimation__ static properties of the RadSplashScreenManager class.

You can set the properties to any animation object that derives from [RadAnimation](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.animation.radanimation).

__Example 1: Replacing the default show and hide animations__
<snippet id='radsplashscreen-features-animations-block_1-cs' />

## Disable  Animations

To disable the animations, set the corresponding property (__ShowAnimation__ or __HideAnimation__) to null.

__Example 2: Disabling animations__
<snippet id='radsplashscreen-features-animations-block_2-cs' />

## Change Animations Speed

To change the speed of the show and hide animations, set the __SpeedRatio__ property of the RadAnimation object. 

__Example 3: Changing the speed of the animations__
<snippet id='radsplashscreen-features-animations-block_3-cs' />

## See Also  
* [Getting Started]({%slug radsplashscreen-getting-started%})
* [Splash Screen Manager]({%slug radsplashscreen-features-splashscreenmanager%})