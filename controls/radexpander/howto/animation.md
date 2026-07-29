---
title: Customize Expander Animation
page_title: Customize Expander Animation
description: This article shows how to disable or enable and also customize the RadExpander default expand/collapse animations.
slug: radexpander-howto-animation
tags: expander,animation
published: True
position: 1
---

# Expander Animation

The RadExpander control has an animation enabled by default. 

To disable or enable the animation, set the __AnimationManager.IsAnimationEnabled__ attached property on RadExpander. 

__Example 1: Disabling animation in XAML__
<snippet id='radexpander-howto-animation-example_1_disabling_animation_in_xaml-xaml' />


__Example 2: Disabling animation in code__
<snippet id='radexpander-howto-animation-example_2_disabling_animation_in_code-cs' />

<snippet id='radexpander-howto-animation-example_2_disabling_animation_in_code-vb' />


## Customize Animations

To customize RadExpander animations, use the __AnimationManager.AnimationSelector__ property. The supported animation class is __ExpanderExpandCollapseAnimation__ which exposes few properties to customize the animation.

* __Direction__: An enumeration property of type __AnimationDirection__ which specifies the direction of the animation.
* __TargetElementName__: A property of type __string__ that gets or sets the name of the element that should be animated.
* __AnimationName__: A property of type __string__ that gets or sets the name of the animation. For example:
	* __ExpandDirection is set to Up or Down:__ To modify the animation the AnimationName needs to be set to __Expand or Collapse__.
	* __ExpandDirection is set to Right or Left:__ To modify the animation the AnimationName needs to be set to __ExpandHorizontal or CollapseHorizontal__.
* __SpeedRatio__: A property of type __double__ that gets or sets the speed of the animation.

__Example 3: Modify the animations when ExpandDirection is Up or Down__
<snippet id='radexpander-howto-animation-example_3_modify_the_animations_when_expanddirection_is_up_or_down-xaml' />


__Example 4: Modify the animations when ExpandDirection is Right or Left__
<snippet id='radexpander-howto-animation-example_4_modify_the_animations_when_expanddirection_is_right_or_left-xaml' />


## See Also
* [Getting Started]({%slug expander-getting-started%})
* [Expand Direction]({%slug radexpander-features-expand_direction%})
