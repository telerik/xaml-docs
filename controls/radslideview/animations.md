---
title: Animations
page_title: Animations
description: Check our &quot;Animations&quot; documentation article for the RadSlideView control.
slug: radslideview-animations
tags: animations, radslideview
published: True
position: 3
---

# Animations

The `RadSlideView` control has a built-in support for animations. It has default animations, which are enabled out-of-the-box.

## Customizing the Default Animations

RadSlideView has two `MoveАnimation` instances defined in its default style. You can modify them by creating a new `AnimationSelector` instance for the `AnimationManager.AnimationSelector` attached property. Then, add a new `AnimationGroup` with two `MoveAnimation` instances for the newly created AnimationSelector. You can alter these animations by customizing their duration via the `Duration` property and setting a speed ratio using the `SpeedRatio` property. Also, you can apply an easing by setting the `Easing` property.

__Customizing the default animations for RadSlideView__
```XAML
    <telerik:RadSlideView>
        <telerik:AnimationManager.AnimationSelector>
            <telerik:AnimationSelector>
                <telerik:AnimationGroup AnimationName="SlideTransitionAnimation">
                    <telerik:MoveAnimation AnimationName="InAnimation" TargetElementName="PART_CurrentItemHost" Duration="00:00:01">
                        <telerik:MoveAnimation.Easing>
                            <QuadraticEase EasingMode="EaseOut"/>
                        </telerik:MoveAnimation.Easing>
                    </telerik:MoveAnimation>
                    <telerik:MoveAnimation AnimationName="OutAnimation" TargetElementName="PART_NextItemHost" Duration="00:00:01">
                        <telerik:MoveAnimation.Easing>
                            <QuadraticEase EasingMode="EaseIn"/>
                        </telerik:MoveAnimation.Easing>
                    </telerik:MoveAnimation>
                </telerik:AnimationGroup>
            </telerik:AnimationSelector>
        </telerik:AnimationManager.AnimationSelector>
    </telerik:RadSlideView>
```

>important For the animations to be applied correctly, do not remove the `AnimationName` and `TargetElementName` properties of the above elements.

__RadSlideView with modified animations__

![{{ site.framework_name }} RadSlideView with modified animations](images/radslideview-animations-0.gif)

## Disabling the Default Animation

To disable the animations, set the `IsAnimationEnabled` attached property of the AnimationManager class to __False__.

__Disable RadSlideView element's animations__
```XAML
    <telerik:RadSlideView telerik:AnimationManager.IsAnimationEnabled="False"/>
```

## See Also
* [Navigation Buttons]({%slug radslideview-navigation-buttons%})