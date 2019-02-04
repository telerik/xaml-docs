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

To disable or enable the animation set the __AnimationManager.IsAnimationEnabled__ attached property on RadExpander. 

#### __[XAML] Example 1: Disabling animation in XAML__
{{region radexpander-howto-animation_0}}
	<telerik:RadExpander telerik:AnimationManager.IsAnimationEnabled="False" />
{{endregion}}

#### __[C#] Example 2: Disabling animation in code__
{{region radexpander-howto-animation_1}}        
	AnimationManager.SetIsAnimationEnabled(this.radExpander, false);
{{endregion}}

#### __[VB.NET] Example 2: Disabling animation in code__
{{region radexpander-howto-animation_2}}    
	AnimationManager.SetIsAnimationEnabled(Me.radExpander, False)            
{{endregion}}

## Customize Animations

To customize the RadExpander animations use the __AnimationManager.AnimationSelector__ property. The supported animation class is ExpanderExpandCollapseAnimation which exposes few properties to customize the animation

#### __[XAML] Example 3: Change the speed of the animations using the SpeedRation property (when ExpandDirection is Up or Down)__
{{region radexpander-howto-animation_3}}
	<telerik:RadExpander>
		<telerik:AnimationManager.AnimationSelector>
			<telerik:AnimationSelector>
				<telerik:ExpanderExpandCollapseAnimation AnimationName="Expand" 
														 Direction="In"
														 SpeedRatio="0.2"
														 TargetElementName="Content" />
				<telerik:ExpanderExpandCollapseAnimation AnimationName="Collapse" 
														 Direction="Out"
														 SpeedRatio="0.2"
														 TargetElementName="Content" />
			</telerik:AnimationSelector>
		</telerik:AnimationManager.AnimationSelector>
	</telerik:RadExpander>
{{endregion}}

> The previous code snippet is applicable only when the ExpandState property of RadExpander is set to Up or Down.

When the ExpandState property is set to Right or Left you need to use a different AnimationNames for the ExpanderExpandCollapseAnimation objects. The expand AnimationName is "ExpandHorizontal" and the collapse AnimationName is "CollapseHorizontal".

#### __[XAML] Example 4: Change the speed of the animations using the SpeedRation property (when ExpandDirection is Right or Left)__
{{region radexpander-howto-animation_4}}
	<telerik:RadExpander>
		<telerik:AnimationManager.AnimationSelector>
			<telerik:AnimationSelector>
				<telerik:ExpanderExpandCollapseAnimation AnimationName="ExpandHorizontal" 
														 Direction="In"
														 SpeedRatio="0.2"
														 TargetElementName="Content" />
				<telerik:ExpanderExpandCollapseAnimation AnimationName="CollapseHorizontal" 
														 Direction="Out"
														 SpeedRatio="0.2"
														 TargetElementName="Content" />
			</telerik:AnimationSelector>
		</telerik:AnimationManager.AnimationSelector>
	</telerik:RadExpander>
{{endregion}}

## See Also
* [Getting Started]({%slug expander-getting-started%})
* [Expand Direction]({%slug radexpander-features-expand_direction%})