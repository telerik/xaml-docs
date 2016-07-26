---
title: How to apply multiple animations for showing and hiding RadDesktopAlert
page_title: How to apply multiple animations for showing and hiding RadDesktopAlert
description: How to apply multiple animations for showing and hiding RadDesktopAlert
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

>To learn more about the methods and properties exposed by the API for each of the other animations mentioned above take a look at [this topic](http://docs.telerik.com/devtools/wpf/api/html/N_Telerik_Windows_Controls_Animation.htm).

## Applying AnimationGroup

Using the __AnimationGroup__ class you could group animations and play them simultaneously. You could easily add or remove animation objects of this composite animation using its __Children__ property that is of type __IList__. 

The next code snippet shows how to apply an __AnimationGroup__ to both the __ShowAnimation__ and __HideAnimation__ properties of __DesktopAlertManager__:

#### __[C#] Applying AnimationGroup__

{{region cs-raddesktopalert-how-to-apply-animation-group_1}}
	AnimationGroup groupIn = new AnimationGroup();
	groupIn.Children.Add(new FadeAnimation() { Direction = AnimationDirection.In });
	groupIn.Children.Add(new ScaleAnimation() { Direction = AnimationDirection.In, MinScale = 0.9 });

	AnimationGroup groupOut = new AnimationGroup();
	groupOut.Children.Add(new FadeAnimation() { Direction = AnimationDirection.Out });
	groupOut.Children.Add(new ScaleAnimation() { Direction = AnimationDirection.Out, MinScale = 0.9 });

	this.AnimationGroupManager.ShowAnimation = groupIn;
	this.AnimationGroupManager.HideAnimation = groupOut;
{{endregion}}

#### __[VB] Applying AnimationGroup__

{{region vb-raddesktopalert-how-to-apply-animation-group_2}}
	Dim groupIn As New AnimationGroup() 
	groupIn.Children.Add(New FadeAnimation() With { Key .Direction = AnimationDirection.[In] })
	groupIn.Children.Add(New ScaleAnimation() With { Key .Direction = AnimationDirection.[In], Key .MinScale = 0.9 })

	Dim groupOut As New AnimationGroup()
	groupOut.Children.Add(New FadeAnimation() With { Key .Direction = AnimationDirection.Out })
	groupOut.Children.Add(New ScaleAnimation() With { Key .Direction = AnimationDirection.Out, Key .MinScale = 0.9 })

	Me.AnimationGroupManager.ShowAnimation = groupIn
	Me.AnimationGroupManager.HideAnimation = groupOut
{{endregion}}

>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk), the example is listed as DesktopAlert/ShowingAndHidingUsingAnimationGroup.

# See Also

 * [DesktopAlertManager]({%slug raddesktopalert-desktop-alert-manager%})